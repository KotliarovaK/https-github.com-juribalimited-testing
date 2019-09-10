﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations.AfterScenario
{
    [Binding]
    public class SetActionDisplayOrder : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public SetActionDisplayOrder(RestWebClient client)
        {
            _client = client;
        }

        [Given(@"Display order for '(.*)' automation '(.*)' action is '(.*)'")]
        public void GivenDisplayOrderForAutomationActionIs(string automationName, string actionName, int order)
        {
            var automationId = DatabaseHelper.GetAutomationId(automationName);
            var actionId = DatabaseHelper.GetAutomationActionId(actionName, automationId);
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation/{actionId}/changeActionOrder";
            var request = requestUri.GenerateRequest();
            request.AddParameter("displayOrder", order);

            var resp = _client.Value.Put(request);

            if (resp.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to set '{order}' processing order for '{actionName}' action");
        }
    }
}
