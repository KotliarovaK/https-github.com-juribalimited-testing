using System;
using System.Linq;
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
        private readonly DTO.RuntimeVariables.Automations _automations;
        private readonly RestWebClient _client;

        private RemoveAutomationActionAfterScenario(DTO.RuntimeVariables.Automations automations, AutomationActions automationActions, RestWebClient client)
        {
            _automationActions = automationActions;
            _client = client;
            _automations = automations;
        }

        //[AfterScenario("Cleanup", Order = 10)]
        //public void DeleteNewlyCreatedAutomationAction()
        //{
        //    if (!_automationActions.Value.Any())
        //        return;

        //    if (_automations.Value == null || !_automations.Value.Any())
        //    {
        //        Logger.Write("WARNING: there are no Automations from which we try to remove Actions");
        //        return;
        //    }

        //    //Try to delete all tasks for all projects as we do not know relationship between them
        //    foreach (string action in _automationActions.Value)
        //    {
        //        foreach (AutomationsDto automationsDto in _automations.Value)
        //        {
        //            try
        //            {
        //                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation/{automationsDto.Id}/actionDeleteCommand";
        //                var request = requestUri.GenerateRequest();
        //                request.AddParameter("selectedObjectsList", DatabaseHelper.GetAutomationActionId(action, automationsDto.Id));

        //                _client.Value.Put(request);
        //            }
        //            catch (Exception e)
        //            {
        //                Logger.Write($"Unable to delete Action for Automation via API: {e}");
        //            }
        //        }
        //    }
        //}
    }
}