using System;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables.Rings;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class SetDefaultBucketAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly BucketUnassignedId _bucketUnassignedId;

        private SetDefaultBucketAfterScenario(RestWebClient client, BucketUnassignedId bucketUnassignedId)
        {
            _client = client;
            _bucketUnassignedId = bucketUnassignedId;
        }

        [AfterScenario("Set_Default_Bucket", Order = 1)]
        public void SetDefaultBucket()
        {
            if (string.IsNullOrEmpty(_bucketUnassignedId.Value))
                throw new Exception("Unassigned Bucket ID was not saved or set.");

            try
            {
                var bucket = new BucketDto()
                {
                    Name = "Unassigned",
                    Team = new TeamDto() { TeamName = "My Team" },
                    IsDefault = true
                };

                var requestUri =
                    $"{UrlProvider.RestClientBaseUrl}admin/bucket/{_bucketUnassignedId.Value}/updateBucket";

                var request = requestUri.GenerateRequest();
                request.AddParameter("bucketName", bucket.Name);
                request.AddParameter("default", bucket.IsDefault);
                request.AddParameter("ownerTeamId", bucket.Team.GetId());

                var response = _client.Evergreen.Put(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    Logger.Write($"Some issues appears during set of Default Bucket in after scenario");

            }
            catch (Exception e)
            {
                Logger.Write($"Some issues appears during set of Default Bucket in after scenario: {e}");
            }
        }
    }
}