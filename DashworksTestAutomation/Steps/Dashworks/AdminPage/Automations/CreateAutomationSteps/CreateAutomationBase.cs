﻿using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations.CreateAutomationSteps
{
    [Binding]
    public class CreateAutomationBase : SpecFlowContext
    {
        protected readonly DTO.RuntimeVariables.Automations _automation;
        protected readonly RestWebClient _client;

        public CreateAutomationBase(DTO.RuntimeVariables.Automations automation, RestWebClient client)
        {
            _automation = automation;
            _client = client;
        }

        protected string CreateAutomationViaApi(Table table, bool updated = false)
        {
            var automations = table.CreateSet<AutomationsDto>();

            if (automations == null || !automations.Any())
                throw new Exception("Automation table is not set");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation";

            foreach (var automation in automations)
            {
                _automation.Value.Add(automation);

                if (string.IsNullOrEmpty(automation.automationName))
                    throw new Exception("Unable to create Automation with empty name");

                var request = requestUri.GenerateRequest();
                request.AddParameter("objectId", null);

                request.AddJsonBody(automation);

                var response = updated ? _client.Value.Put(request) : _client.Value.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Automation with {automation.automationName} name was not created via api: {response.ErrorMessage}");
                }

                var responseContent = JsonConvert.DeserializeObject<JObject>(response.Content);
                var respId = responseContent["id"].ToString();
                automation.Id = respId.Equals("0") ? string.Empty : respId;
            }

            return _automation.Value.Last().Id;
        }
    }
}
