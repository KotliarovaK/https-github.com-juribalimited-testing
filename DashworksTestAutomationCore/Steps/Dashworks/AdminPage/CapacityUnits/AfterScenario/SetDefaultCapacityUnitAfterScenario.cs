using System;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class SetDefaultCapacityUnitAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly CapacityUnitUnassignedId _capacityUnitUnassignedId;

        private SetDefaultCapacityUnitAfterScenario(RestWebClient client, CapacityUnitUnassignedId capacityUnitUnassignedId)
        {
            _client = client;
            _capacityUnitUnassignedId = capacityUnitUnassignedId;
        }

        [AfterScenario("Set_Default_Capacity_Unit", Order = 1)]
        public void Set_Default_Capacity_Unit()
        {
            if (!_capacityUnitUnassignedId.Value.Any())
                throw new Exception("Unassigned Capacity Unit ID was not saved or set.");

            foreach (CapacityUnitDto capacityUnitDto in _capacityUnitUnassignedId.Value)
            {
                try
                {
                    var requestUri =
                        $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/{capacityUnitDto.GetId()}/updateCapacityUnit";

                    var request = requestUri.GenerateRequest();
                    request.AddParameter("objectId", null);
                    request.AddParameter("name", capacityUnitDto.Name);
                    request.AddParameter("description", capacityUnitDto.Description);
                    request.AddParameter("isDefault", capacityUnitDto.IsDefault);
                    request.AddParameter("projectId", string.Empty);

                    _client.Evergreen.Put(request);
                }
                catch (Exception e)
                {
                    Logger.Write($"Some issues appears during set of Default Capacity Unit in after scenario: {e}");
                }
            }
        }
    }
}