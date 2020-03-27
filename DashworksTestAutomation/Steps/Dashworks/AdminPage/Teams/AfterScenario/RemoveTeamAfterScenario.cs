using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Teams.AfterScenario
{
    [Binding]
    public class RemoveTeamAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Teams _teams;
        private readonly RestWebClient _client;

        private RemoveTeamAfterScenario(DTO.RuntimeVariables.Teams teams, RestWebClient client)
        {
            _teams = teams;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedTeam()
        {
            if (!_teams.Value.Any())
                return;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/team/deleteTeams";

            foreach (TeamDto team in _teams.Value)
            {
                try
                {
                    DatabaseHelper.UnlinkTeamWithBucket(team.TeamName);

                    var request = new RestRequest(requestUri);

                    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                    request.AddParameter("objectId", null);
                    request.AddParameter("selectedObjectsList", team.GetId());

                    var response = _client.Evergreen.Put(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Logger.Write($"Unable to Delete '{team.TeamName}' Team via API");
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to Delete '{team.TeamName}' Team via API: {e}");
                }
            }
        }
    }
}