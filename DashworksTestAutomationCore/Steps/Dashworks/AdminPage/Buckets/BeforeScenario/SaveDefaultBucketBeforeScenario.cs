using System;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables.Rings;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class SaveDefaultBucketBeforeScenario : SpecFlowContext
    {
        private readonly BucketUnassignedId _bucketUnassignedId;

        private SaveDefaultBucketBeforeScenario(BucketUnassignedId bucketUnassignedId)
        {
            _bucketUnassignedId = bucketUnassignedId;
        }

        //This method is actually just save Default Bucket ID
        [BeforeScenario("Set_Default_Bucket")]
        public void SetDefaultBucketBeforeScenario()
        {
            try
            {
                var bucket = new BucketDto()
                {
                    Name = "Unassigned",
                    Team = new TeamDto() { TeamName = "My Team" },
                    IsDefault = true
                };

                var id = bucket.GetId();

                if (string.IsNullOrEmpty(id))
                    throw new Exception("Unable to get Unassigned Bucket ID");

                _bucketUnassignedId.Value = id;
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to save default Bucket ID in the before scenario: {e}");
            }
        }
    }
}