using System;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_API_ProfilePage : TechTalk.SpecFlow.Steps
    {
        private readonly RestWebClient _client;
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_API_ProfilePage(RestWebClient client, RemoteWebDriver driver)
        {
            _client = client;
            _driver = driver;
        }

        [Then(@"default list page Size is ""(.*)"" and Cache ""(.*)""")]
        public void ThenDefaultListPageSizeIsAndCache(string pageSize, string pageCache)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}security/userprofile";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var pageOptions = JsonConvert.DeserializeObject<JObject>(content);
            var gridPageSize = pageOptions["gridPageSize"].ToString();
            var gridPageCache = pageOptions["gridPageCache"].ToString();
            if (gridPageSize.Equals(string.Empty) ||
                gridPageCache.Equals(string.Empty))
            {
                When($"User clicks \"{"Devices"}\" on the left-hand menu");
                Then($"\"{"Devices"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Devices"}\" page");
                When($"User clicks \"{"Users"}\" on the left-hand menu");
                Then($"\"{"Users"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Users"}\" page");
                When($"User clicks \"{"Applications"}\" on the left-hand menu");
                Then($"\"{"Applications"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Applications"}\" page");
                When($"User clicks \"{"Mailboxes"}\" on the left-hand menu");
                Then($"\"{"Mailboxes"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Mailboxes"}\" page");
            }
            else
            {
                Assert.AreEqual(pageSize, gridPageSize, "Incorrect Page Size on Account page");
                Assert.AreEqual(pageCache, gridPageCache, "Incorrect Cache Size on Account page");
            }
        }

        [Then(@"page Size is ""(.*)"" on ""(.*)"" page")]
        public void ThenPageSizeIsOnPage(int pageSize, string pageName)
        {
            var lastNetworkRequest = JsonConvert.DeserializeObject<JArray>(_driver.GetNetworkLogByJavascript()).Last;
            Assert.That(lastNetworkRequest["name"].ToString(), Does.Contain($"?$top={pageSize}"), $"Page Size is not {pageSize}");
        }
    }
}