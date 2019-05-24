using System;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class SaveDefaultCapacityUnitBeforeScenario : SpecFlowContext
    {
        private readonly CapacityUnitUnassignedId _capacityUnitUnassignedId;

        private SaveDefaultCapacityUnitBeforeScenario(CapacityUnitUnassignedId capacityUnitUnassignedId)
        {
            _capacityUnitUnassignedId = capacityUnitUnassignedId;
        }

        [BeforeScenario("Save_Default_Capacity_Unit")]
        public void SaveDefaultCapacityUnit()
        {
            var capacityUnit = new CapacityUnitDto() { Name = "Unassigned", Description = "Unassigned", IsDefault = true };

            var id = capacityUnit.GetId();

            if (string.IsNullOrEmpty(id))
                throw new Exception("Unable to get Unassigned Capacity Unit ID");

            _capacityUnitUnassignedId.Value = id;
        }
    }
}