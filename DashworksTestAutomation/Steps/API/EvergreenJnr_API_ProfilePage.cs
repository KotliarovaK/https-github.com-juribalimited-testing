using System;
using System.Net;
using System.Text.RegularExpressions;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
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
        public void ThenDefaultListPageSizeIsAndCache(int pageSize, int pageCache)
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
            var listPageSize = Convert.ToInt32(pageOptions["gridPageSize"]);
            var listPageToCache = Convert.ToInt32(pageOptions["gridPageCache"]);
            Assert.AreEqual(pageSize, listPageSize, "Incorrect Page Size on Account page");
            Assert.AreEqual(pageCache, listPageToCache, "Incorrect Cache Size on Account page");
        }

        [Then(@"page Size is ""(.*)"" on ""(.*)"" page")]
        public void ThenPageSizeIsOnPage(int pageSize, string pageName)
        {
          
        }
    }
}