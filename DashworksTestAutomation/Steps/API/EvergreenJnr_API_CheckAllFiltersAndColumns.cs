using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using System.IO;
using DashworksTestAutomation.DTO.Evergreen.API;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    class EvergreenJnr_API_CheckAllFiltersAndColumns : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public EvergreenJnr_API_CheckAllFiltersAndColumns(RestWebClient client)
        {
            _client = client;
        }

        private IRestResponse CheckFiltersCount(string list)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list}/fields?$lang=en-US";
            var response = _client.Value.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            var currentFilters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FilterDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<FilterDto>($"Filters\\{list}.json");

            Assert.AreEqual(expectedList.Count, currentFilters.Count, "Filters count are different");

            return response;
        }

        private IRestResponse CheckColumnsCount(string list)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list.ToLower()}/filters?$lang=en-US";
            var response = _client.Value.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            var currentColumns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ColumnDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<ColumnDto>($"Columns\\{list}.json");

            Assert.AreEqual(expectedList.Count, currentColumns.Count, "Columns count are different");

            return response;
        }

        [Then(@"All columns with correct data are returned from the API for '(.*)' list")]
        public void ThenAllColumnsWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var response = CheckColumnsCount(list);

            var currentColumns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ColumnDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<ColumnDto>($"Columns\\{list}.json");

            foreach (ColumnDto columnDto in expectedList)
            {
                Assert.True(currentColumns.Contains(columnDto), $"Incorrect data for column with '{columnDto.Label}' name");
            }
        }

        [Then(@"All filters with correct data are returned from the API for '(.*)' list")]
        public void ThenAllFiltersWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var response = CheckFiltersCount(list);

            var currentFilters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FilterDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<FilterDto>($"Filters\\{list}.json");

            foreach (FilterDto filterDto in expectedList)
            {
                Assert.True(currentFilters.Contains(filterDto), $"Incorrect data for filter with '{filterDto.ColumnName}' name");
            }
        }

        [Then(@"Positive number of results returned for '(.*)' requests")]
        public void ThenPositiveNumberOfResultsReturnedForRequests(string fileName)
        {
            #region Ckeck that Filters and Columns count is correct to proceed wit queries

            var list = fileName.Replace("QueryUrls", string.Empty).ToLower();

            CheckFiltersCount(list);
            CheckColumnsCount(list);

            #endregion

            var fullPath = FileSystemHelper.GeneratePathToEmbeddedResource($"QueryUrls\\{fileName}.txt");
            var reader = new StreamReader(fullPath);
            string content = reader.ReadToEnd();

            foreach (string query in content.SplitByLinebraeak())
            {
                var url = $"{UrlProvider.RestClientBaseUrl}/{query.Replace($"{list}?", $"{list}?$top=100&$skip=0&")}";
                var response = _client.Value.Get(url.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    throw new Exception($"{response.StatusCode} status code for query: {query}");

                var responseData = JsonConvert.DeserializeObject<JObject>(response.Content);
                var metadata = responseData["metadata"] as JObject;
                var metadataCount = int.Parse(metadata["count"].ToString());

                var results = responseData["results"] as JArray;
                var resultsCount = results.Count;

                Assert.True(metadataCount > 0, "Metadata count is zero");
                Assert.True(resultsCount > 0, "Results Count is zero");
            }
        }
    }
}
