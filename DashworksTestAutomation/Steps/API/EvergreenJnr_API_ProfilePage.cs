using System;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
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
    internal class EvergreenJnr_API_ProfilePage
    {
        private readonly RestWebClient _client;
        private readonly WebsiteUrl _url;
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_API_ProfilePage(RestWebClient client, RemoteWebDriver driver, WebsiteUrl url)
        {
            _client = client;
            _driver = driver;
            _url = url;
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
                gridPageCache.Equals(string.Empty)) return;
            Assert.AreEqual(pageSize, gridPageSize, "Incorrect Page Size on Account page");
            Assert.AreEqual(pageCache, gridPageCache, "Incorrect Cache Size on Account page");
        }

        [Then(@"page Size is ""(.*)"" on ""(.*)"" page")]
        public void ThenPageSizeIsOnPage(int pageSize, string pageName)
        {
            var lastNetworkRequest = JsonConvert.DeserializeObject<JArray>(_driver.GetNetworkLogByJavascript()).Last;
            Assert.True(lastNetworkRequest["name"].ToString().Contains($"?$top={pageSize}"), $"Page Size is not {pageSize}");
        }
    }
}