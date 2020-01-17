using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Teams.Api
{
    [Binding]
    public class CreateTeamViaApi : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Teams _teams;
        private readonly RestWebClient _client;

        private CreateTeamViaApi(DTO.RuntimeVariables.Teams teams, RestWebClient client)
        {
            _teams = teams;
            _client = client;
        }

        //| Name | Description | IsDefault |
        [When(@"User creates new Team via api")]
        public void WhenUserCreatesNewTeamViaApi(Table table)
        {
            var teams = table.CreateSet<TeamDto>();

            if (teams == null || !teams.Any())
                throw new Exception("Teams table is not set");

            if (teams.Count(x => x.IsDefault) > 1)
                throw new Exception("More that one Team was set to default");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/team/createTeam";

            foreach (var team in teams)
            {
                if (string.IsNullOrEmpty(team.TeamName))
                    throw new Exception("Unable to create Team with empty name");

                var request = requestUri.GenerateRequest();
                request.AddParameter("teamName", team.TeamName);
                request.AddParameter("description", team.Description);
                request.AddParameter("isDefault", team.IsDefault);

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"Team with {team.TeamName} name was not created via api: {response.ErrorMessage}");

                _teams.Value.Add(team);
            }
        }
    }
}