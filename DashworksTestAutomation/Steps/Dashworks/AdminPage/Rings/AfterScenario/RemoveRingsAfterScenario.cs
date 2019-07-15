using System;
using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveRingsAfterScenario : SpecFlowContext
    {
        private readonly Rings _rings;
        private readonly RestWebClient _client;

        private RemoveRingsAfterScenario(Rings rings, RestWebClient client)
        {
            _rings = rings;
            _client = client;
        }

        [AfterScenario("Delete_Newly_Created_Ring", Order = 10)]
        public void DeleteNewlyCreatedRing()
        {
            if (!_rings.Value.Any())
                return;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/ring/deleteRings";

            foreach (RingDto ring in _rings.Value)
            {
                try
                {
                    var request = requestUri.GenerateRequest();
                    request.AddParameter("selectedObjectsList", ring.GetId());

                    _client.Value.Put(request);
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Ring via API: {e}");
                }
            }
        }
    }
}