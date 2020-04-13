using System;
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
    public class SetDefaultRingAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly RingUnassignedId _ringUnassignedId;

        private SetDefaultRingAfterScenario(RestWebClient client, RingUnassignedId ringUnassignedId)
        {
            _client = client;
            _ringUnassignedId = ringUnassignedId;
        }

        [AfterScenario("Set_Default_Ring", Order = 1)]
        public void SetDefaultRing()
        {
            if (string.IsNullOrEmpty(_ringUnassignedId.Value))
                throw new Exception("Unassigned Ring ID was not saved or set.");

            try
            {
                var ring = new RingDto()
                { Name = "Unassigned", Description = "Unassigned", IsDefault = true };

                var requestUri =
                    $"{UrlProvider.RestClientBaseUrl}admin/ring/{_ringUnassignedId.Value}/updateRing";

                var request = requestUri.GenerateRequest();
                request.AddParameter("name", ring.Name);
                request.AddParameter("description", ring.Description);
                request.AddParameter("isDefault", ring.IsDefault);
                request.AddParameter("ringId", _ringUnassignedId.Value);

                _client.Evergreen.Put(request);
            }
            catch (Exception e)
            {
                Logger.Write($"Some issues appears during set of Default Ring in after scenario: {e}");
            }
        }
    }
}