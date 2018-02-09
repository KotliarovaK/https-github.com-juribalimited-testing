using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;

namespace DashworksTestAutomation.Steps
{
    [Binding]
    internal class TestApiStep : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly ResponceDetails _responce;
        private readonly DetailsSectionToUrlConvertor _sectionConvertor;
        private readonly RemoteWebDriver _driver;
        private readonly ColumnNameToUrlConvertor _convertor;

        public TestApiStep(RestWebClient client, ResponceDetails responce,
            DetailsSectionToUrlConvertor sectionConvertor, RemoteWebDriver driver, ColumnNameToUrlConvertor convertor)
        {
            _client = client;
            _responce = responce;
            _sectionConvertor = sectionConvertor;
            _driver = driver;
            _convertor = convertor;
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
        public void ThenFollowingOperatorsAreDisplayedInCategoryForFilterOnPage(string categoryName, string filterName,
            string pageName, Table table)
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
            var filter = allFilters.First(x =>
                x["translatedCategory"].ToString().Equals(categoryName) && x["label"].ToString().Equals(filterName));
            var allOperators = filter["operators"];
            var operatorsValues = allOperators.Select(x => x["key"].ToString()).ToList();
            Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(), operatorsValues,
                $"Incorrect operators are displayed for {filterName} filter");
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

        [When(@"I perform test request to the ""(.*)"" API and get ""(.*)"" item summary for ""(.*)"" section")]
        public void WhenIPerformTestRequestToTheApiAndGetItemSummaryForSection(string pageName, string itemName,
            string sectionName)
        {
            var itemId = _client.GetDeviceIdByName(itemName, pageName);
            var section = _sectionConvertor.SectionConvertor(sectionName);
            var requestUri = "";
            if (pageName == "Mailboxes")
            {
                requestUri =
                    $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s').TrimEnd('e')}/{itemId}/{section}?$lang=en-GB";
            }
            else
            {
                requestUri =
                    $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s')}/{itemId}/{section}?$lang=en-GB";
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
            try
            {
                var item = allItems.First(x => x["friendlyName"].ToString().Equals(fieldName));
                Assert.AreEqual(state, item["visible"].ToString(), $"Incorrect display state for {fieldName}");
            }
            catch
            {
                Assert.AreEqual(state, "False", $"Incorrect display state for {fieldName}");
            }
        }

        [Then(@"""(.*)"" text displayed for ""(.*)"" empty fields")]
        public void ThenTextDisplayedForEmptyFields(string text, string sectionName)
        {
            var content = _responce.Value.Content;
            var allFields = JsonConvert.DeserializeObject<JObject>(content)["results"];
            foreach (var pair in allFields)
            {
                if (pair.ToString().Contains("address2") || pair.ToString().Contains("address3") ||
                    pair.ToString().Contains("address4") ||
                    pair.ToString().Contains("pendingStickyDepartmentMessage") ||
                    pair.ToString().Contains("pendingStickyLocationMessage"))
                    continue;
                Assert.IsTrue(!string.IsNullOrEmpty(pair.Last.ToString()),
                    "'Unknown' text is not displayed for field ");
            }
        }

        [When(@"I perform test request to the APi and get ""(.*)"" page and selected columns:")]
        public void WhenIPerformTestRequestToApiAndGetPage(string pageName, Table table)
        {
            var requestUri =
                $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower()}?$top=1000&$skip=0&{_client.GetDefaultColumnsUrlByPageName(pageName)}";
            foreach (var row in table.Rows)
            {
                requestUri += $",{ColumnNameToUrlConvertor.Convert(pageName, row["ColumnName"])}";
            }
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.ResponseUri.ToString();
        }
    }
}