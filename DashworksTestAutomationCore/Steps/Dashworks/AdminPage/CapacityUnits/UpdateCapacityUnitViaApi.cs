using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
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

        //| OldName | Name | Description | IsDefault |
        [When(@"User updates Capacity Units via api")]
        public void WhenUserUpdatesCapacityUnitsViaApi(Table table)
        {
            var oldNames = table.GetDataByKey("OldName");
            List<CapacityUnitDto> capacityUnits = table.CreateSet<CapacityUnitDto>().ToList();

            for (int i = 0; i < oldNames.Count; i++)
            {
                var previousData = DatabaseHelper.GetCapacityUnit(oldNames[i]);
                capacityUnits[i].Name = string.IsNullOrEmpty(capacityUnits[i].Name)
                    ? previousData.Name
                    : capacityUnits[i].Name;
                capacityUnits[i].Description = string.IsNullOrEmpty(capacityUnits[i].Description)
                    ? previousData.Description
                    : capacityUnits[i].Description;
                capacityUnits[i].IsDefault = string.IsNullOrEmpty(table.GetDataByKey("IsDefault")[i]) ?
                    previousData.IsDefault
                    : previousData.IsDefault.Equals(capacityUnits[i].IsDefault)
                        ? previousData.IsDefault
                        : capacityUnits[i].IsDefault;
            }

            if (capacityUnits == null || !capacityUnits.Any())
                throw new Exception("Capacity Units table is not set");

            if (capacityUnits.Count(x => x.IsDefault) > 1)
                throw new Exception("More that one Capacity Unit was set to default");

            for (int i = 0; i < oldNames.Count; i++)
            {
                if (string.IsNullOrEmpty(oldNames[i]))
                    throw new Exception("Old Capacity Unit name was not set");

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/{new CapacityUnitDto() { Name = oldNames[i] }.GetId()}/updateCapacityUnit";

                if (string.IsNullOrEmpty(capacityUnits[i].Name))
                    throw new Exception("Unable to update Capacity Unit with empty name");

                var request = requestUri.GenerateRequest();
                request.AddParameter("objectId", null);
                request.AddParameter("name", capacityUnits[i].Name);
                request.AddParameter("description", capacityUnits[i].Description);
                request.AddParameter("isDefault", capacityUnits[i].IsDefault);
                request.AddParameter("projectId", string.Empty);

                var response = _client.Evergreen.Put(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Capacity Unit with {capacityUnits[i].Name} name was not updated via api: {response.ErrorMessage}");
                }
            }
        }
    }
}