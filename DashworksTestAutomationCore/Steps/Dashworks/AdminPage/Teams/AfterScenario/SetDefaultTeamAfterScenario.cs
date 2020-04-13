using System;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Teams.AfterScenario
{
    [Binding]
    public class SetDefaultTeamAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly TeamDefaultId _teamDefaultId;

        private SetDefaultTeamAfterScenario(RestWebClient client, TeamDefaultId teamDefaultId)
        {
            _client = client;
            _teamDefaultId = teamDefaultId;
        }

        [AfterScenario("Set_Default_Team", Order = 1)]
        public void SetDefaultTeam()
        {
            if (string.IsNullOrEmpty(_teamDefaultId.Value))
                throw new Exception("Default team ID was not saved.");

            try
            {
                var team = new TeamDto() { TeamName = "My Team", Description = "Default Team", IsDefault = true };

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/team/{_teamDefaultId.Value}/updateTeam";

                var request = new RestRequest(requestUri);

                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("objectId", null);
                request.AddParameter("teamName", team.TeamName);
                request.AddParameter("description", team.Description);
                request.AddParameter("isDefault", team.IsDefault);

                var response = _client.Evergreen.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write($"Unable to make '{team.TeamName}' team as default: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
            catch { }
        }
    }
}