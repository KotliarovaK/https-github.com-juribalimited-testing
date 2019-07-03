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
        private readonly Team _team;
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly Buckets _buckets;
        private readonly RestWebClient _client;
        private readonly LastUsedBucket _lastUsedBucket;
        private readonly AddedObjects _addedObjects;
        private readonly CapacityUnit _capacityUnit;
        private readonly UserDto _user;

        public ProjectsApi(RemoteWebDriver driver, Team team, DTO.RuntimeVariables.Projects projects,
            RestWebClient client, Buckets buckets, LastUsedBucket lastUsedBucket, AddedObjects addedObjects, CapacityUnit capacityUnit, UserDto user)
        {
            _driver = driver;
            _team = team;
            _projects = projects;
            _client = client;
            _buckets = buckets;
            _lastUsedBucket = lastUsedBucket;
            _addedObjects = addedObjects;
            _capacityUnit = capacityUnit;
            _user = user;
        }

        // table example
        // | ProjectName | Scope | ProjectTemplate | Mode |
        [When(@"Project created via API and opened")]
        public void WhenUserCreateNewDashboardViaApi(Table table)
        {
            string pName = "";
            string pScope = "";
            string pTemplate = "";
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

        [AfterScenario("Delete_Newly_Created_Project")]
        public void DeleteNewlyCreatedProject()
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/deleteProjects";

            foreach (var projectName in _projects.Value)
            {
                try
                {
                    if (string.IsNullOrEmpty(projectName))
                        continue;

                    var projectId = GetProjectId(projectName);

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

        private string GetProjectId(string projectName)
        {
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectID] FROM [PM].[dbo].[Projects] where [ProjectName] = '{projectName}' AND [IsDeleted] = 0",
                    0).LastOrDefault();
            return projectId;
        }

        private string GetCreateProjectRequestScopeProperty(string scope)
        {
            return new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(scope) ? "objectType" : "listId";
        }

        private string GetObjectType(string scope)
        {
            return new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(scope) ? GetProjectObjectTypeScope(scope) : GetProjectListIdScope(scope);
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

        private string GetProjectListIdScope(string listName)
        {
            //string userId =
            //    DatabaseHelper.ExecuteReader(
            //        $"SELECT [aspnetdb].[dbo].[aspnet_Users].[UserId] FROM[aspnetdb].[dbo].[aspnet_Users] where UserName = '{_user.UserName}'", 0).LastOrDefault();

            return DatabaseHelper.ExecuteReader(
                    $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0).LastOrDefault();
        }
    }
}