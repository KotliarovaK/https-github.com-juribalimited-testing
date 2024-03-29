﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;
using DashworksTestAutomation.DTO.Evergreen.API;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

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
            var url = $"{UrlProvider.RestClientBaseUrl}{list.ToLower()}/fields?$lang={UserProvider.DefaultUserLanguage}";
            var response = _client.Evergreen.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            return response;
        }
        private IRestResponse GetFilterOptionsByListName(string list, string filter)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list.ToLower()}/filters/options/{filter.ToLower().Replace(" ","")}";
            var response = _client.Evergreen.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            return response;
        }

        [Then(@"All columns with correct data are returned from the API for '(.*)' list")]
        public void ThenAllColumnsWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var response = GetColumnsByListName(list);

            var currentColumns = JsonConvert.DeserializeObject<List<ColumnDto>>(response.Content).OrderBy(x => x.TranslatedColumnName).ToList();
            var expectedColumns = FileSystemHelper.ReadJsonListFromSystem<ColumnDto>($"Columns\\{list}.json").OrderBy(x => x.TranslatedColumnName).ToList();

            Verify.AreEqual(currentColumns.Count, expectedColumns.Count, "Columns count are different");

            for (int i = 0; i < expectedColumns.Count; i++)
            {
                Verify.That(JsonConvert.SerializeObject(expectedColumns[i], new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    Is.EqualTo(JsonConvert.SerializeObject(currentColumns[i], new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })),
                    $"Incorrect data for column");
            }
        }

        [Then(@"All filters with correct data are returned from the API for '(.*)' list")]
        public void ThenAllFiltersWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var response = GetFiltersByListName(list);

            var currentFilters = JsonConvert.DeserializeObject<List<FilterDto>>(response.Content).OrderBy(x => x.TranslatedTextLabel).ToList();
            var expectedFilters = FileSystemHelper.ReadJsonListFromSystem<FilterDto>($"Filters\\{list}.json").OrderBy(x => x.TranslatedTextLabel).ToList();

            Verify.AreEqual(expectedFilters.Count, currentFilters.Count, "Filters count are different");

            for (int i = 0; i < expectedFilters.Count; i++)
            {
                Verify.That(JsonConvert.SerializeObject(expectedFilters[i], new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    Is.EqualTo(JsonConvert.SerializeObject(currentFilters[i], new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })),
                    $"Incorrect data for filter");
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

        [Then(@"'(.*)' filter options of '(.*)' are displayed in the following order:")]
        public void ThenLookupOptionsAreDisplayedInTheFollowingOrder(string filter, string list, Table table)
        {
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();

            var response = GetFilterOptionsByListName(list, filter);
            var actualList = JsonConvert.DeserializeObject<List<FilterOptionsDto>>(response.Content).Select(x => x.Text)
                .ToList();

            Verify.That(actualList, Is.EqualTo(expectedList), "Options are different");
        }
    }



    public class FilterOptionsDto
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("translatedText")]
        public object TranslatedText { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }

        [JsonProperty("props")]
        public object Props { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("severity")]
        public object Severity { get; set; }
    }
}
