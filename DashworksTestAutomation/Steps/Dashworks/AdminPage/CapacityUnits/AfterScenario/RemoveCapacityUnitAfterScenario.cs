using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveCapacityUnitAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.CapacityUnits.CapacityUnits _capacityUnits;
        private readonly RestWebClient _client;

        private RemoveCapacityUnitAfterScenario(DTO.RuntimeVariables.CapacityUnits.CapacityUnits capacityUnit, RestWebClient client)
        {
            _capacityUnits = capacityUnit;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedCapacityUnit()
        {
            if (!_capacityUnits.Value.Any())
                return;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/deleteCapacityUnits";

            foreach (CapacityUnitDto capacityUnit in _capacityUnits.Value)
            {
                try
                {
                    var request = requestUri.GenerateRequest();
                    request.AddParameter("objectId", null);
                    request.AddParameter("selectedObjectsList", capacityUnit.GetId());

                    var resp = _client.Evergreen.Put(request);

                    if (resp.StatusCode != HttpStatusCode.OK)
                    {
                        Logger.Write($"Unable to delete Capacity Unit via API: {resp.StatusCode}");
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Capacity Unit via API: {e}");
                }
            }
        }
    }
}