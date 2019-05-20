using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits
{
    [Binding]
    public class UpdateCapacityUnitViaApi : SpecFlowContext
    {
        private readonly RestWebClient _client;

        private UpdateCapacityUnitViaApi(RestWebClient client)
        {
            _client = client;
        }

        [When(@"User updates Capacity Units via api")]
        public void WhenUserUpdatesCapacityUnitsViaApi(Table table)
        {
            var capacityUnits = table.CreateSet<CapacityUnitDto>();

            if (capacityUnits == null || !capacityUnits.Any())
                throw new Exception("Capacity Units table is not set");

            if (capacityUnits.Count(x => x.IsDefault) > 1)
                throw new Exception("More that one Capacity Unit was set to default");

            foreach (CapacityUnitDto capacityUnit in capacityUnits)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/{capacityUnit.GetId()}/updateCapacityUnit";

                if (string.IsNullOrEmpty(capacityUnit.Name))
                    throw new Exception("Unable to update Capacity Unit with empty name");

                var request = new RestRequest(requestUri);

                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("objectId", null);
                request.AddParameter("name", capacityUnit.Name);
                request.AddParameter("description", capacityUnit.Description);
                request.AddParameter("isDefault", capacityUnit.IsDefault);
                request.AddParameter("projectId", string.Empty);

                var response = _client.Value.Put(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Capacity Unit with {capacityUnit.Name} name was not updated via api: {response.ErrorMessage}");
                }
            }
        }
    }
}