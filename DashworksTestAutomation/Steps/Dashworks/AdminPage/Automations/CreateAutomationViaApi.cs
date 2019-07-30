using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    public class CreateAutomationsViaApi : SpecFlowContext
    {
        private readonly Automation _automation;
        private readonly RestWebClient _client;

        private CreateAutomationsViaApi(Automation automation, RestWebClient client)
        {
            _automation = automation;
            _client = client;
        }

        [ When(@"User creates new Automation via API")]
        public void WhenUserCreatesNewAutomationViaAPI(Table table)
        {
            var automations = table.CreateSet<AutomationsDto>();

            if (automations == null || !automations.Any())
                throw new Exception("Automation table is not set");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation";

            foreach (var automation in automations)
            {
                if (string.IsNullOrEmpty(automation.automationName))
                    throw new Exception("Unable to create Automation with empty name");

                var request = requestUri.GenerateRequest();
                request.AddParameter("objectId", null);

                request.AddJsonBody(automation);

                var response = _client.Value.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Automation with {automation.automationName} name was not created via api: {response.ErrorMessage}");
                }

                _automation.Value.Add(automation);
            }
        }
    }
}