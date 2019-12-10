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

            Utils.Verify.AreEqual(expectedList.Count, currentFilters.Count, "Filters count are different");

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

            Utils.Verify.AreEqual(expectedList.Count, currentColumns.Count, "Columns count are different");

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
                Verify.IsTrue(currentColumns.Contains(columnDto), $"Incorrect data for column with '{columnDto.Label}' name");
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
                Verify.IsTrue(currentFilters.Contains(filterDto), $"Incorrect data for filter with '{filterDto.ColumnName}' name");
            }
        }

        [Then(@"Positive number of results returned for '(.*)' requests")]
        public void ThenPositiveNumberOfResultsReturnedForRequests(string fileName)
        {
           
        }

        [Then(@"Positive number of results returned for requests:")]
        public void ThenPositiveNumberOfResultsReturnedForRequests(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                var list = row.Values.Last().Split('?').First();

                #region Ckeck that Filters and Columns count is correct to proceed with queries

                //Commented this to save time. Anyway we doing exactly the same in general test
                //CheckFiltersCount(list);
                //CheckColumnsCount(list);

                #endregion

                //var fullPath = FileSystemHelper.GeneratePathToEmbeddedResource($"QueryUrls\\{fileName}.txt");
                //var reader = new StreamReader(fullPath);
                //string content = reader.ReadToEnd();

                var url = $"{UrlProvider.RestClientBaseUrl}/{row.Values.Last().Replace($"{list}?", $"{list}?$top=100&$skip=0&")}";
                var response = _client.Value.Get(url.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    throw new Exception($"{response.StatusCode} status code for query: {row.Values.Last()}");

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
