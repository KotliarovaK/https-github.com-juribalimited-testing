using System;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Buckets;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class RemoveBucketAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Buckets.Buckets _buckets;
        private readonly RestWebClient _client;

        private RemoveBucketAfterScenario(DTO.RuntimeVariables.Buckets.Buckets buckets, RestWebClient client)
        {
            _buckets = buckets;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedBucket()
        {
            if (!_buckets.Value.Any())
                return;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/bucket/deleteBuckets";

            foreach (BucketDto bucket in _buckets.Value)
            {
                try
                {
                    var request = requestUri.GenerateRequest();
                    request.AddParameter("objectId", null);
                    request.AddParameter("selectedObjectsList", bucket.GetId());

                    var response = _client.Evergreen.Put(request);

                    if(response.StatusCode != HttpStatusCode.OK)
                        Logger.Write($"Unable to delete '{bucket.Name}' Bucket via API");
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Bucket via API: {e}");
                }
            }
        }
    }
}