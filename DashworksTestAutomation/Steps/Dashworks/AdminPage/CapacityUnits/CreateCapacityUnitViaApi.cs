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
    public class CreateCapacityUnitViaApi : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.CapacityUnits _capacityUnits;
        private readonly RestWebClient _client;

        private CreateCapacityUnitViaApi(DTO.RuntimeVariables.CapacityUnits capacityUnit, RestWebClient client)
        {
            _capacityUnits = capacityUnit;
            _client = client;
        }

        //| Name | Description | IsDefault |
        [When(@"User creates new Capacity Unit via api")]
        public void WhenUserCreatesNewCapacityUnitViaApi(Table table)
        {
            var capacityUnits = table.CreateSet<CapacityUnitDto>();

            if (capacityUnits == null || !capacityUnits.Any())
                throw new Exception("Capacity Units table is not set");

            if (capacityUnits.Count(x => x.IsDefault) > 1)
                throw new Exception("More that one Capacity Unit was set to default");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/createCapacityUnit";

            foreach (var capacityUnit in capacityUnits)
            {
                if (string.IsNullOrEmpty(capacityUnit.Name))
                    throw new Exception("Unable to create Capacity Unit with empty name");

                var request = new RestRequest(requestUri);

                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("objectId", null);
                request.AddParameter("name", capacityUnit.Name);
                request.AddParameter("description", capacityUnit.Description);
                request.AddParameter("isDefault", capacityUnit.IsDefault);

                var response = _client.Value.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Capacity Unit with {capacityUnit.Name} name was not created via api: {response.ErrorMessage}");
                }

                _capacityUnits.Value.Add(capacityUnit);
            }
        }
    }
}