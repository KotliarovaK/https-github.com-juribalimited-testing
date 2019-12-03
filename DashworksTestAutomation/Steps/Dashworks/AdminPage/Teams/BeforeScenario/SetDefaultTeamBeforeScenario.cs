using System;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Teams.AfterScenario
{
    [Binding]
    public class SetDefaultTeamBeforeScenario : SpecFlowContext
    {
        private readonly TeamDefaultId _teamDefaultId;

        private SetDefaultTeamBeforeScenario(TeamDefaultId teamDefaultId)
        {
            _teamDefaultId = teamDefaultId;
        }

        [BeforeScenario("Set_Default_Team")]
        public void SetDefaultTeam()
        {
            var team = new TeamDto() { TeamName = "My Team", Description = "Default Team", IsDefault = true };

            var id = team.GetId();

            if (string.IsNullOrEmpty(id))
                throw new Exception("Unable to get Default Team ID");

            _teamDefaultId.Value = id;
        }
    }
}