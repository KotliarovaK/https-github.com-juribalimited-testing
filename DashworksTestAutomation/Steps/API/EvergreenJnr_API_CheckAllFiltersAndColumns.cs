using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;
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

        private IRestResponse GetFiltersByListName(string list)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list}/filters?$lang={UserProvider.DefaultUserLanguage}";
            var response = _client.Evergreen.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            return response;
        }

        private IRestResponse GetColumnsByListName(string list)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list.ToLower()}/fields?$lang=en-US";
            var response = _client.Evergreen.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            return response;
        }

        [Then(@"All columns with correct data are returned from the API for '(.*)' list")]
        public void ThenAllColumnsWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var response = GetColumnsByListName(list);

            var currentColumns = JsonConvert.DeserializeObject<List<ColumnDto>>(response.Content);
            var expectedColumns = FileSystemHelper.ReadJsonListFromSystem<ColumnDto>($"Columns\\{list}.json");

            Verify.AreEqual(currentColumns.Count, expectedColumns.Count, "Columns count are different");

            foreach (ColumnDto columnDto in expectedColumns)
            {
                Verify.That(currentColumns.Contains(columnDto), $"Incorrect data for column with '{columnDto.ColumnName}' name");
            }
        }

        [Then(@"All filters with correct data are returned from the API for '(.*)' list")]
        public void ThenAllFiltersWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var response = GetFiltersByListName(list);

            var currentFilters = JsonConvert.DeserializeObject<List<FilterDto>>(response.Content);
            var expectedFilters = FileSystemHelper.ReadJsonListFromSystem<FilterDto>($"Filters\\{list}.json");

            Verify.AreEqual(expectedFilters.Count, currentFilters.Count, "Filters count are different");

            foreach (FilterDto filterDto in expectedFilters)
            {
                Verify.IsTrue(currentFilters.Contains(filterDto), $"Incorrect data for filter with '{filterDto.Label}' name");
            }
        }

        [Then(@"Positive number of results returned for requests:")]
        public void ThenPositiveNumberOfResultsReturnedForRequests(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                var list = row.Values.Last().Split('?').First();
                var url = $"{UrlProvider.RestClientBaseUrl}/{row.Values.Last().Replace($"{list}?", $"{list}?$top=100&$skip=0&")}";
                var response = _client.Evergreen.Get(url.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"{response.StatusCode} status code for query: {row.Values.Last()}");
                }

                var responseData = JsonConvert.DeserializeObject<JObject>(response.Content);
                var metadata = responseData["metadata"] as JObject;
                var metadataCount = int.Parse(metadata["count"].ToString());

                var results = responseData["results"] as JArray;
                var resultsCount = results.Count;

                Verify.IsTrue(metadataCount > 0, $"Metadata count is zero for '{row.Values.ToArray()[1]}/{row.Values.ToArray()[0]}' filter");
                Verify.IsTrue(resultsCount > 0, $"Results Count is zero fo '{row.Values.ToArray()[1]}/{row.Values.ToArray()[0]}' filter");
            }
        }
    }
}
