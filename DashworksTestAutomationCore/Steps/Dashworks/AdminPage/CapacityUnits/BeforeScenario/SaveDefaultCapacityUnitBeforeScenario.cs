using System;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits;
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

        //This just for EVERGREEN projects. For other projects please use 'Given' step
        //This method is actually just save Default Capacity Unit ID
        [BeforeScenario("Set_Default_Capacity_Unit")]
        public void SetDefaultCapacityUnitBeforeScenario()
        {
            SaveDefaultCapacityUnit();
        }

        [Given(@"Save Default Capacity Unit for '(.*)' project")]
        public void GivenSaveDefaultCapacityUnitForProject(string project)
        {
            SaveDefaultCapacityUnit(project);
        }

        private void SaveDefaultCapacityUnit(string project = "")
        {
            try
            {
                CapacityUnitDto capacityUnit = null;
                switch (project)
                {
                    case "":
                        capacityUnit = new CapacityUnitDto() { Name = "Unassigned", Description = "Unassigned", IsDefault = true };
                        break;
                    case "Email Migration":
                        capacityUnit = new CapacityUnitDto() { Name = "Unassigned", Description = "Default Capacity Unit for Email Migration project", IsDefault = true, Project = project };
                        break;
                    default:
                        throw new Exception($"There are no information for default Capacity Unit for '{project}' project");
                }


                var id = capacityUnit.GetId();

                if (string.IsNullOrEmpty(id))
                    throw new Exception("Unable to get Unassigned Capacity Unit ID");

                _capacityUnitUnassignedId.Value.Add(capacityUnit);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to save default Capacity Unit ID in the before scenario: {e}");
            }
        }
    }
}