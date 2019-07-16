using System;
using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveCapacityUnitAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.CapacityUnits _capacityUnits;
        private readonly RestWebClient _client;

        private RemoveCapacityUnitAfterScenario(DTO.RuntimeVariables.CapacityUnits capacityUnit, RestWebClient client)
        {
            _capacityUnits = capacityUnit;
            _client = client;
        }

        [AfterScenario("Delete_Newly_Created_Capacity_Unit", Order = 10)]
        public void DeleteNewlyCreatedCapacityUnit()
        {
            try
            {
                if (!_capacityUnits.Value.Any())
                    return;

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/deleteCapacityUnits";

                foreach (CapacityUnitDto capacityUnit in _capacityUnits.Value)
                {
                    try
                    {
                        var request = new RestRequest(requestUri);

                        request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                        request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                        request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                        request.AddParameter("objectId", null);
                        request.AddParameter("selectedObjectsList", capacityUnit.GetId());

                        _client.Value.Put(request);
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Unable to delete Capacity Unit via API: {e}");
                    }
                }
            }
            catch { }
        }
    }
}