using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.AfterScenario
{
    [Binding]
    class RemoveProjectAfterScenario : SpecFlowContext
    {
        protected readonly RestWebClient _client;
        protected readonly DTO.RuntimeVariables.Projects _projects;

        public RemoveProjectAfterScenario(RestWebClient client, DTO.RuntimeVariables.Projects projects)
        {
            _client = client;
            _projects = projects;
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
                    {
                        Logger.Write(
                            $"Unable to execute request. \r\nStatus code: {response.StatusCode}URI: {requestUri}\r\nError message: {response.ErrorMessage}");
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during removing '{projectName}' Project: {e}");
                }
            }
        }
    }
}
