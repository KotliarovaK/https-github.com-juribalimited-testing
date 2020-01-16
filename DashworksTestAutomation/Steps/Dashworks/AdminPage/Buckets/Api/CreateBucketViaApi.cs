using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Buckets;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Teams.Api
{
    [Binding]
    public class CreateBucketViaApi : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Buckets.Buckets _buckets;
        private readonly RestWebClient _client;

        private CreateBucketViaApi(DTO.RuntimeVariables.Buckets.Buckets buckets, RestWebClient client)
        {
            _buckets = buckets;
            _client = client;
        }

        //| Name | TeamName | IsDefault |
        [When(@"User creates new Bucket via api")]
        public void WhenUserCreatesNewBucketViaApi(Table table)
        {
            var buckets = table.CreateSet<BucketDto>();

            if (buckets == null || !buckets.Any())
                throw new Exception("Bucket table is not set");

            if (buckets.Count(x => x.IsDefault) > 1)
                throw new Exception("More that one Bucket was set to default");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/bucket/createBucket";

            foreach (var bucket in buckets)
            {
                if (string.IsNullOrEmpty(bucket.Name))
                    throw new Exception("Unable to create Bucket with empty name");

                var request = requestUri.GenerateRequest();
                request.AddParameter("bucketName", bucket.Name);
                request.AddParameter("ownerTeamID", bucket.Team.GetId());
                request.AddParameter("default", bucket.IsDefault);

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"Bucket with {bucket.Name} name was not created via api: {response.ErrorMessage}");

                _buckets.Value.Add(bucket);
            }
        }
    }
}