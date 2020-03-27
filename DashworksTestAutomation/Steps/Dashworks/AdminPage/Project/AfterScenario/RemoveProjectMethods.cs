using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.AfterScenario
{
    //TODO probably should be moved out of AfterScenario folder
    public class RemoveProjectMethods
    {
        private readonly RestWebClient _client;
        private readonly DTO.RuntimeVariables.Projects _projects;

        public RemoveProjectMethods(RestWebClient client, DTO.RuntimeVariables.Projects projects)
        {
            _client = client;
            _projects = projects;
        }

        public void DeleteProject()
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

                    var response = _client.Evergreen.Post(request);

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