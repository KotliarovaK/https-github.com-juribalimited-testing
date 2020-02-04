using System;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Rings;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class SaveDefaultRingBeforeScenario : SpecFlowContext
    {
        private readonly RingUnassignedId _ringUnassignedId;

        private SaveDefaultRingBeforeScenario(RingUnassignedId ringUnassignedId)
        {
            _ringUnassignedId = ringUnassignedId;
        }

        //This method is actually just save Default Ring ID
        [BeforeScenario("Set_Default_Ring")]
        public void SetDefaultRingBeforeScenario()
        {
            try
            {
                var ring = new RingDto() { Name = "Unassigned", Description = "Unassigned", IsDefault = true };

                var id = ring.GetId();

                if (string.IsNullOrEmpty(id))
                    throw new Exception("Unable to get Unassigned Ring ID");

                _ringUnassignedId.Value = id;
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to save default Ring ID in the before scenario: {e}");
            }
        }
    }
}