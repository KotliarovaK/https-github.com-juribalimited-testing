using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_API_FiltersFunctionality : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public EvergreenJnr_API_FiltersFunctionality(RestWebClient client)
        {
            _client = client;
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
                x["translatedCategory"].ToString().Equals(categoryName) &&
                x["label"].ToString().Equals(filterName));
            var allOperators = filter["operators"];
            var operatorsValues = allOperators.Select(x => x["key"].ToString()).ToList();
            Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(), operatorsValues,
                $"Incorrect operators are displayed for {filterName} filter");
        }

        [Then(@"the following values are displayed for ""(.*)"" filter on ""(.*)"" page:")]
        public void ThenTheFollowingValuesAreDisplayedForFilter(string filterName, string pageName, Table table)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower()}/filters/options/{filterName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<JArray>(content).ToList();
            var filterValueList = responseContent.Select(x => x["text"].ToString()).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            foreach (var value in expectedList)
            {
                Assert.IsTrue(filterValueList.Contains(value), "Selected values are not displayed in that filter");
            }
        }

        [Then(@"the values are displayed for ""(.*)"" filter on ""(.*)"" page in the following order:")]
        public void ThenTheValuesAreDisplayedForFilterOnPageInTheFollowingOrder(string filterName, string pageName, Table table)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower()}/filters/options/{filterName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<JArray>(content).ToList();
            var filterValueList = responseContent.Select(x => x["text"].ToString()).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            foreach (var value in expectedList)
            {
                Assert.AreEqual(filterValueList, expectedList, "Values are not displayed in the correct order");
            }
        }

        [Then(@"""(.*)"" is displayed after ""(.*)"" in Application list filter")]
        public void ThenIsDisplayedAfterInApplicationListFilter(string item1, string item2)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}devices/filters/options/application";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<JArray>(content).ToList();
            var filterValueList = responseContent.Select(x => x["text"].ToString()).ToList();
            var itemByIndex2 = filterValueList.FindIndex(s => s.Equals(item2));
            Assert.AreEqual(item1, filterValueList[itemByIndex2 + 1]);
        }

        [Then(@"the following subcategories are displayed for ""(.*)"" Columns category:")]
        public void ThenTheFollowingSubcategoriesAreDisplayedForColumnsCategory(string categoryName, Table table)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}devices/fields?$lang=en-US";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<List<JObject>>(content).ToList();
            var subcategory = responseContent.FindAll(x => x["translatedCategory"].ToString().Equals(categoryName)).ToList();
            var subcategoryList = subcategory.Select(x => x["translatedColumnName"].ToString()).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(subcategoryList, expectedList, "Subcategory lists are not equal");
        }
    }
}