using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    public class CreateAutomationViaApi : SpecFlowContext
    {
        private readonly Automation _automation;
        private readonly RestWebClient _client;

        private CreateAutomationViaApi(Automation automation, RestWebClient client)
        {
            _automation = automation;
            _client = client;
        }

        //TODO Use this step after completed
        [ When(@"User creates new Automation Unit via API")]
        public void WhenUserCreatesNewAutomationUnitViaAPI(Table table)
        {
            var automations = table.CreateSet<AutomationsDto>();

            if (automations == null || !automations.Any())
                throw new Exception("Automation table is not set");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation";

            foreach (var automation in automations)
            {
                if (string.IsNullOrEmpty(automation.automationName))
                    throw new Exception("Unable to create Automation with empty name");

                var request = new RestRequest(requestUri);

                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("objectId", null);

                request.AddJsonBody(automation);

                //request.AddParameter("active", automation.active);
                //request.AddParameter("automationId", automation.automationId);
                //request.AddParameter("automationName", automation.automationName);
                //request.AddParameter("automationScheduleTypeId", GetScheduleTypeId(automation.));
                //request.AddParameter("automationSqlAgentJobId", automation.AutomationSqlAgentJobId);
                //request.AddParameter("description", automation.Description);
                //request.AddParameter("listId", GetListId(automation.Scope));
                //request.AddParameter("objectTypeId", GetObjectTypeId(automation.Scope));
                //request.AddParameter("stopOnFailedAction", automation.StopOnFailedAction);

                var response = _client.Value.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Automation with {automation.automationName} name was not created via api: {response.ErrorMessage}");
                }
            }
        }
    }
}