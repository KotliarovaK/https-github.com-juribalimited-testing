using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
    internal class EvergreenJnr_API_DetailsPage
    {
        private readonly RestWebClient _client;
        private readonly ResponceDetails _responce;
        private readonly DetailsSectionToUrlConvertor _sectionConvertor;

        public EvergreenJnr_API_DetailsPage(RestWebClient client, ResponceDetails responce,
            DetailsSectionToUrlConvertor sectionConvertor)
        {
            _client = client;
            _responce = responce;
            _sectionConvertor = sectionConvertor;
        }

        [When(@"I perform test request to the ""(.*)"" API and get ""(.*)"" item summary for ""(.*)"" section")]
        public void WhenIPerformTestRequestToTheApiAndGetItemSummaryForSection(string pageName, string itemName,
            string sectionName)
        {
            var itemId = _client.GetItemIdByName(itemName, pageName);
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
                Assert.IsFalse(!string.IsNullOrEmpty(pair.Last.ToString()),
                    "'Unknown' text is displayed for field ");
            }
        }
    }
}
