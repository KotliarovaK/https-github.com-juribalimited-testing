using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;

namespace DashworksTestAutomation.Steps
{
    [Binding]
    internal class TestApiStep : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly ResponceDetails _responce;

        public TestApiStep(RestWebClient client, ResponceDetails responce)
        {
            _client = client;
            _responce = responce;
        }

        [When(@"I perform test request to the Users API and get operators by ""(.*)"" filter")]
        public void WhenIPerformTestRequestToTheUsersApiAndGetOperatorsByFilter(string filterName)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}users/filters?$lang=en-GB";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var allFilters = JsonConvert.DeserializeObject<List<JObject>>(content);
            var filter = allFilters.First(x => x["label"].ToString().Equals(filterName));
            var allOperators = filter["operators"];
            var operatorsValues = allOperators.Select(x => x["key"].ToString()).ToList();
        }

        [Then(@"following operators are displayed in ""(.*)"" category for ""(.*)"" filter on ""(.*)"" page:")]
        public void ThenFollowingOperatorsAreDisplayedInCategoryForFilterOnPage(string categoryName, string filterName, string pageName, Table table)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower()}/filters?$lang=en-GB";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var allFilters = JsonConvert.DeserializeObject<List<JObject>>(content);
            var filter = allFilters.First(x => x["translatedCategory"].ToString().Equals(categoryName) && x["label"].ToString().Equals(filterName));
            var allOperators = filter["operators"];
            var operatorsValues = allOperators.Select(x => x["key"].ToString()).ToList();
            Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(), operatorsValues);
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
            Assert.AreEqual(pageSize, listPageSize);
            Assert.AreEqual(pageCache, listPageToCache);
        }

        [When(@"I perform test request to the ""(.*)"" API and get ""(.*)"" item summary")]
        public void WhenIPerformTestRequestToTheApiAndGetItemSummary(string pageName, string itemName)
        {
            var itemId = _client.GetDeviceIdByName(itemName, pageName);
            var tabs = _client.GetColumnNameByPageName(pageName, tabName);
            var requestUri = "";
            if (pageName == "columnName")
            {
                requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s').TrimEnd('e')}/{itemId}/{tabs}?$lang=en-GB";
            }
            else
            {
                requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s')}/{itemId}/{tabs}?$lang=en-GB";

            }
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            _responce.Value = _client.Value.Get(request);

            if (_responce.Value.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab API")]
        public void ThenFieldIsDisplayedOnDetailsTab(string fieldName, string state)
        {
            var content = _responce.Value.Content;
            var allItems = JsonConvert.DeserializeObject<JObject>(content)["metadata"];
            var item = allItems.First(x => x["friendlyName"].ToString().Equals(fieldName));
            Assert.AreEqual(state, item["visible"].ToString(), $"Incorrect display state for {fieldName}");
        }
    }
}