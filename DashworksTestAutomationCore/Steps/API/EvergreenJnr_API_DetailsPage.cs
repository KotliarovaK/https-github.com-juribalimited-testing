﻿using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_API_DetailsPage : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly ResponceDetails _response;
        private readonly DetailsSectionToUrlConvertor _sectionConvertor;

        public EvergreenJnr_API_DetailsPage(RestWebClient client, ResponceDetails response,
            DetailsSectionToUrlConvertor sectionConvertor)
        {
            _client = client;
            _response = response;
            _sectionConvertor = sectionConvertor;
        }

        [When(@"I perform test request to the ""(.*)"" API and get ""(.*)"" item summary for ""(.*)"" section")]
        public void WhenIPerformTestRequestToTheApiAndGetItemSummaryForSection(string pageName, string itemName,
            string sectionName)
        {
            var itemId = _client.GetItemIdByName(itemName, pageName);
            var section = _sectionConvertor.SectionConvertor(sectionName);
            var requestUri = "";
            requestUri = pageName == "Mailboxes" ?
                $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s').TrimEnd('e')}/{itemId}/{section}?$lang=en-GB" :
                $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s')}/{itemId}/{section}?$lang=en-GB";

            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            _response.Value = _client.Evergreen.Get(request);

            if (_response.Value.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab API")]
        public void ThenFieldIsDisplayedOnDetailsTab(string fieldName, string state)
        {
            var content = _response.Value.Content;
            var allItems = JsonConvert.DeserializeObject<JObject>(content)["metadata"];
            var item = allItems.First(x => x["friendlyName"].ToString().Equals(fieldName));
            Utils.Verify.AreEqual(state, item["visible"].ToString(), $"Incorrect display state for {fieldName}");
        }

        [Then(@"following fields are displayed with next state on Details tab API")]
        public void ThenFollowingFieldsAreDisplayedWithNextStateOnDetailsTabAPI(Table table)
        {
            var content = _response.Value.Content;
            var allItems = JsonConvert.DeserializeObject<JObject>(content)["metadata"];

            foreach (var row in table.Rows)
            {
                var item = allItems.First(x => x["friendlyName"].ToString().Equals(row["FieldName"]));
                Utils.Verify.AreEqual(row["DisplayState"], item["visible"].ToString(),
                    $"Incorrect display state for {row["FieldName"]}");
            }
        }

        [Then(@"""(.*)"" text displayed for ""(.*)"" empty fields")]
        public void ThenTextDisplayedForEmptyFields(string text, string sectionName)
        {
            var content = _response.Value.Content;
            var allFields = JsonConvert.DeserializeObject<JObject>(content)["results"];
            foreach (var pair in allFields)
            {
                if (pair.ToString().Contains("address2") ||
                    pair.ToString().Contains("address3") ||
                    pair.ToString().Contains("address4") ||
                    pair.ToString().Contains("pendingStickyDepartmentMessage") ||
                    pair.ToString().Contains("pendingStickyLocationMessage"))
                    continue;
                Utils.Verify.IsFalse(!string.IsNullOrEmpty(pair.Last.ToString()),
                    "'Unknown' text is displayed for field ");
            }
        }
    }
}