using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.AfterScenario;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project
{
    [Binding]
    internal class ProjectsApi : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly RestWebClient _client;
        private readonly RemoveProjectMethods _removeProjectMethods;
        private readonly DTO.RuntimeVariables.Projects _projects;

        public ProjectsApi(RemoteWebDriver driver, DTO.RuntimeVariables.Projects projects, RestWebClient client)
        {
            _driver = driver;
            _client = client;
            _removeProjectMethods = new RemoveProjectMethods(client, projects);
            _projects = projects;
        }

        // table example
        // | ProjectName | Scope | ProjectTemplate | Mode |
        [When(@"Project created via API and opened")]
        public void WhenUserCreateNewProjectViaApiAndOpened(Table table)
        {
            var projectId = CreateProjectViaApi(table);
            var projectName = _projects.Value.Last();

            _driver.NowAt<BaseHeaderElement>();
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{projectId}/details");

            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(projectName);
        }

        // table example
        // | ProjectName | Scope | ProjectTemplate | Mode |
        [When(@"Project created via API")]
        public void WhenUserCreateNewProjectViaApi(Table table)
        {
            CreateProjectViaApi(table);
        }

        private string CreateProjectViaApi(Table table)
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
            var request = requestUri.GenerateRequest();
            request.AddParameter("Accept", "application/json");
            request.AddParameter("Content-Type", "application/json");

            request.AddParameter("modeId", pMode);
            request.AddParameter(GetCreateProjectRequestScopeProperty(pScope), GetObjectType(pScope));

            request.AddParameter("projectName", pName);
            request.AddParameter("template", pTemplate);

            var response = _client.Evergreen.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["message"]}");

            var responseContent = JsonConvert.DeserializeObject<JObject>(response.Content);
            string projectId = responseContent["id"].ToString();

            _projects.Value.Add(pName);

            return projectId;
        }

        [When(@"Projects created by User are removed via API")]
        public void WhenUserRemovesNewProjectsViaApi()
        {
            _removeProjectMethods.DeleteProject();
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