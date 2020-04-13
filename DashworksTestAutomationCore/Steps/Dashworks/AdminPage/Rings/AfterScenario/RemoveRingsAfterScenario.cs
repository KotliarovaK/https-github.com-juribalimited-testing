using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Rings;
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
        private readonly DTO.RuntimeVariables.Rings.Rings _rings;
        private readonly RestWebClient _client;

        private RemoveRingsAfterScenario(DTO.RuntimeVariables.Rings.Rings rings, RestWebClient client)
        {
            _rings = rings;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
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

                    var response = _client.Evergreen.Put(request);

                    if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        Logger.Write($"Some error occurs during Rings deleting: {response.StatusCode}, {response.ErrorMessage}");
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Ring via API: {e}");
                }
            }
        }
    }
}