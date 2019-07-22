using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project
{
    [Binding]
    internal class ProjectsApi : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly RestWebClient _client;

        public ProjectsApi(RemoteWebDriver driver, DTO.RuntimeVariables.Projects projects, RestWebClient client)
        {
            _driver = driver;
            _projects = projects;
            _client = client;
        }

        // table example
        // | ProjectName | Scope | ProjectTemplate | Mode |
        [When(@"Project created via API and opened")]
        public void WhenUserCreateNewDashboardViaApi(Table table)
        {
            string pName = string.Empty;
            string pScope = string.Empty;
            string pTemplate = string.Empty;
            int pMode = 0;

            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["ProjectName"]))
                    pName = row["ProjectName"];

                if (!string.IsNullOrEmpty(row["Scope"]))
                    pScope = row["Scope"];

                if (row["ProjectTemplate"].Equals("None"))
                    pTemplate = "-1";

                pMode = row["Mode"].Equals("Standalone Project") ? 1 : 3;
            }

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/createProject";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("Accept", "application/json");
            request.AddParameter("Content-Type", "application/json");

            request.AddParameter("modeId", pMode);
            request.AddParameter(GetCreateProjectRequestScopeProperty(pScope), GetObjectType(pScope));

            request.AddParameter("projectName", pName);
            request.AddParameter("template", pTemplate);

            var response = _client.Value.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["message"]}");

            var responseContent = JsonConvert.DeserializeObject<JObject>(response.Content);
            string projectId = responseContent["id"].ToString();

            _projects.Value.Add(pName);

            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{projectId}/details");

            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.ActiveProjectByName(pName), $"{pName} is not displayed on the Project page");
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedProject()
        {
            if (!_projects.Value.Any())
                return;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/deleteProjects";

            foreach (var projectName in _projects.Value)
            {
                try
                {
                    if (string.IsNullOrEmpty(projectName))
                        continue;

                    var projectId = DatabaseHelper.GetProjectId(projectName);

                    var request = new RestRequest(requestUri);

                    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                    request.AddParameter("selectedObjectsList", projectId);

                    var response = _client.Value.Post(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                        Logger.Write($"Unable to execute request. URI: {requestUri}");
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during removing '{projectName}' Project: {e}");
                }
            }
        }

        private string GetCreateProjectRequestScopeProperty(string scope)
        {
            return new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(scope) ? "objectType" : "listId";
        }

        private string GetObjectType(string scope)
        {
            return new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(scope) ? GetProjectObjectTypeScope(scope) : DatabaseHelper.GetProjectListIdScope(scope);
        }

        private string GetProjectObjectTypeScope(string scope)
        {
            if (scope.Equals("All Devices"))
                return "Devices";
            if (scope.Equals("All Users"))
                return "Users";
            if (scope.Equals("All Mailboxes"))
                return "Mailboxes";
            return "NOT FOUND";
        }
    }
}