using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Teams.AfterScenario
{
    [Binding]
    public class RemoveTeamAfterScenario : SpecFlowContext
    {
        private readonly Team _team;
        private readonly RestWebClient _client;

        private RemoveTeamAfterScenario(Team team, RestWebClient client)
        {
            _team = team;
            _client = client;
        }

        [AfterScenario("Delete_Created_Team", Order = 10)]
        public void DeleteCreatedTeam()
        {
            try
            {
                if (!_team.Value.Any())
                    return;

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/team/deleteTeams";

                foreach (TeamDto team in _team.Value)
                {
                    try
                    {
                        var request = new RestRequest(requestUri);

                        request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                        request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                        request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                        request.AddParameter("objectId", null);
                        request.AddParameter("selectedObjectsList", team.GetId());

                        _client.Value.Put(request);
                    }
                    catch { }
                }
            }
            catch { }
        }
    }
}