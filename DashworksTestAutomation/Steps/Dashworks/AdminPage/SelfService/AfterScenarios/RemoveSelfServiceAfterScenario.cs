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
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios
{
    [Binding]
    class RemoveSelfServiceAfterScenario : SpecFlowContext
    {
        private readonly SelfServiceApiMethods _removeSelfServiceMethods;

        public RemoveSelfServiceAfterScenario(SelfServices selfServices, RestWebClient client)
        {
            _removeSelfServiceMethods = new SelfServiceApiMethods(selfServices, client);
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedSelfService()
        {
            _removeSelfServiceMethods.DeleteSelfService();
        }
    }
}