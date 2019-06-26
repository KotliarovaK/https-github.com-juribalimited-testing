using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
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

        [AfterScenario("Delete_Newly_Created_Team", Order = 10)]
        public void DeleteNewlyCreatedTeam()
        {
            try
            {
                if (!_team.Value.Any())
                    return;

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/team/deleteTeams";

                foreach (TeamDto team in _team.Value)
                {
                    UnlinkTeamWithBucket(team.TeamName);

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

        private void UnlinkTeamWithBucket(string teamName)
        {
            var groupIds = DatabaseHelper.ExecuteReader(
                $"select GroupID from[PM].[dbo].[ProjectGroups] buckets join[PM].[dbo].[Teams] teams on buckets.OwnedByTeamID = teams.TeamID where teams.TeamName = '{teamName}'",
                0);

            foreach (var groupId in groupIds)
            {
                DatabaseHelper.ExecuteQuery(
                    $"update [PM].[dbo].[ProjectGroups] set OwnedByTeamID = null where GroupID = '{groupId}'");
            }
        }
    }
}