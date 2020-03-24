using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveAutomationActionAfterScenario : SpecFlowContext
    {
        private readonly AutomationActions _automationActions;
        private readonly RestWebClient _client;

        private RemoveAutomationActionAfterScenario(AutomationActions automationActions, RestWebClient client)
        {
            _automationActions = automationActions;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedAutomationAction()
        {
            if (!_automationActions.Value.Any())
                return;

            //Try to delete all tasks for all projects as we do not know relationship between them
            foreach (string action in _automationActions.Value)
            {
                try
                {
                    //Get all Actions IDs for this name
                    var allActionIds = DatabaseHelper.GetAutomationActions(action);

                    foreach (string actionId in allActionIds)
                    {
                        //Get automation for this action
                        var automationId = DatabaseHelper.GetAutomationIdByActionId(actionId);

                        var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation/{automationId}/actionDeleteCommand";
                        var request = requestUri.GenerateRequest();
                        request.AddParameter("selectedObjectsList", actionId);

                        var resp = _client.Evergreen.Put(request);

                        if (resp.StatusCode != HttpStatusCode.OK)
                        {
                            Logger.Write($"Unable to delete Action for Automation via API: {resp.StatusCode}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Action for Automation via API: {e}");
                }
            }
        }
    }
}