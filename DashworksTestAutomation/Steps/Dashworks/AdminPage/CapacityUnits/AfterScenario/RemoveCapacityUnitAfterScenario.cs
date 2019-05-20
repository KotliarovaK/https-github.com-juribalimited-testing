using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveCapacityUnitAfterScenario : SpecFlowContext
    {
        private readonly CapacityUnit _capacityUnit;
        private readonly RestWebClient _client;

        private RemoveCapacityUnitAfterScenario(CapacityUnit capacityUnit, RestWebClient client)
        {
            _capacityUnit = capacityUnit;
            _client = client;
        }

        [AfterScenario("Delete_Newly_Created_Capacity_Unit")]
        public void DeleteNewlyCreatedCapacityUnit()
        {
            try
            {
                if (!_capacityUnit.Value.Any())
                    return;

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/deleteCapacityUnits";

                foreach (CapacityUnitDto capacityUnit in _capacityUnit.Value)
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
                    catch { }
                }
            }
            catch { }
        }
    }
}