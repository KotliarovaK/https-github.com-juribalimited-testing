using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios
{
    [Binding]
    class RemoveSelfServiceAfterScenario : SpecFlowContext
    {
        private readonly RemoveSelfServiceMethods _removeSelfServiceMethods;

        public RemoveSelfServiceAfterScenario(SelfServices selfServices, RestWebClient client)
        {
            _removeSelfServiceMethods = new RemoveSelfServiceMethods(selfServices, client);
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void deleteNewlyCreatedSelfService()
        {
            _removeSelfServiceMethods.DeleteSelfService();
        }
    }
}