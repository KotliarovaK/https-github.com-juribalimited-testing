using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveAutomationAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Automations _automations;
        private readonly RestWebClient _client;

        private RemoveAutomationAfterScenario(DTO.RuntimeVariables.Automations automation, RestWebClient client)
        {
            _automations = automation;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedAutomation()
        {
            if (!_automations.Value.Any())
                return;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation/deleteAutomations";

            foreach (AutomationsDto automation in _automations.Value)
            {
                try
                {
                    var request = requestUri.GenerateRequest();
                    request.AddParameter("objectId", null);
                    request.AddParameter("selectedObjectsList", automation.Id);

                    var resp = _client.Evergreen.Put(request);
                    if (resp.StatusCode != HttpStatusCode.OK)
                    {
                        Logger.Write($"Unable to delete Automation via API: {resp.StatusCode}");
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Automation via API: {e}");
                }
            }
        }
    }
}