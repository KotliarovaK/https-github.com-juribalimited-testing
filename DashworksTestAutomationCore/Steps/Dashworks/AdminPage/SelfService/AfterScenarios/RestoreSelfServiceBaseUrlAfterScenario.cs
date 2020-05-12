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
using DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios;

namespace DashworksTestAutomationCore.Steps.Dashworks.AdminPage.SelfService.AfterScenarios
{
    [Binding]
    class RestoreSelfServiceBaseUrlAfterScenario
    {
        private SelfServiceApiMethods _SelfServiceApiMethods;

        public RestoreSelfServiceBaseUrlAfterScenario(SelfServiceApiMethods ssApiMethods)
        {
            _SelfServiceApiMethods = ssApiMethods;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void RestoreSelfServiceBaseUrlToDefault()
        {
            _SelfServiceApiMethods.SetBaseUrl();
        }
    }
}
