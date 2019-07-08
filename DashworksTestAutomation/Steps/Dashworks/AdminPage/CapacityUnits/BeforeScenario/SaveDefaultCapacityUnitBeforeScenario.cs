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

        //This method is actually just save Default Capacity Unit ID
        [BeforeScenario("Set_Default_Capacity_Unit")]
        public void SetDefaultCapacityUnitBeforeScenario()
        {
            try
            {
                var capacityUnit = new CapacityUnitDto() { Name = "Unassigned", Description = "Unassigned", IsDefault = true };

                var id = capacityUnit.GetId();

                if (string.IsNullOrEmpty(id))
                    throw new Exception("Unable to get Unassigned Capacity Unit ID");

                _capacityUnitUnassignedId.Value = id;
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to save default Capacity Unit ID in the before scenario: {e}");
            }
        }
    }
}