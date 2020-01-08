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
        private readonly RemoveProjectMethods _removeProjectMethods;

        public RemoveProjectAfterScenario(RestWebClient client, DTO.RuntimeVariables.Projects projects)
        {
            _removeProjectMethods = new RemoveProjectMethods(client, projects);
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedProject()
        {
            _removeProjectMethods.DeleteProject();
        }
    }
}