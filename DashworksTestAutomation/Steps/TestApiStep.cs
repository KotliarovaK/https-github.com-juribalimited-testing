﻿using DashworksTestAutomation.DTO.RuntimeVariables;
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

        public TestApiStep(RestWebClient client)
        {
            _client = client;
        }

        [When(@"I perform test request to the Users API and get operators by ""(.*)"" filter")]
        public void WhenIPerformTestRequestToTheUsersAPIAndGetOperatorsByFilter(string filterName)
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

        [Then(@"following operators are displayed for ""(.*)"" filter on ""(.*)"" page:")]
        public void ThenFollowingOperatorsAreDisplayedForFilterOnPage(string filterName, string pageName, Table table)
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
            var filter = allFilters.First(x => x["label"].ToString().Equals(filterName));
            var allOperators = filter["operators"];
            var operatorsValues = allOperators.Select(x => x["key"].ToString()).ToList();
            Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(), operatorsValues);
        }

        //[Then(@"default list page size is ""(.*)"" on ""(.*)"" page")]
        //public void ThenDefaultListPageSizeIsOnPage(int pageSize, string pageName, string userName)
        //{
        //    var userId = DatabaseWorker.GetUserIdByLogin(userName);
        //    var requestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/updateAdvanced";
        //    var request = new RestRequest(requestUri);

        //    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
        //    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
        //    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
        //    request.AddParameter("userId", userId);
        //    request.AddParameter("gridPageSize", null);
        //    request.AddParameter("displayMode", 0);

        //    var response = _client.Value.Get(request);

        //    if (response.StatusCode != HttpStatusCode.OK)
        //        throw new Exception($"Unable to execute request. URI: {requestUri}");

        //    var content = response.Content;

        //    var listPageSize = gridPageSize:["operators"];
        //    Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(), operatorsValues);
        //}
    }
}