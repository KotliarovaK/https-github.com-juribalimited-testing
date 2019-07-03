using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using RestSharp;
using System;
using System.Net;
using DashworksTestAutomation.DTO;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class BucketsApi : SpecFlowContext
    {
        private readonly Buckets _buckets;
        private readonly RestWebClient _client;

        public BucketsApi(RestWebClient client, Buckets buckets)
        {
            _client = client;
            _buckets = buckets;
        }


        [AfterScenario("Delete_Newly_Created_Bucket")]
        public void DeleteAllBucketAfterScenarioRun()
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/bucket/deleteBuckets";

            foreach (var bucketName in _buckets.Value)
            {
                try
                {
                    if (string.IsNullOrEmpty(bucketName))
                        continue;

                    var bucketId = DatabaseHelper.ExecuteReader(
                        $"SELECT [GroupID] FROM [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucketName}'", 0)[0];

                    var request = new RestRequest(requestUri);

                    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                    request.AddParameter("objectId", null);
                    request.AddParameter("selectedObjectsList", bucketId);

                    var response = _client.Value.Put(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                        Logger.Write($"Unable to execute request. URI: {requestUri}");
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during '{bucketName}' Bucket removing: {e}");
                }
            }
        }
    }
}