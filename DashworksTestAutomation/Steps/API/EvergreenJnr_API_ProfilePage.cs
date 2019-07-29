using System;
using System.Net;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_API_ProfilePage : TechTalk.SpecFlow.Steps
    {
        private readonly RestWebClient _client;
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;

        public EvergreenJnr_API_ProfilePage(RestWebClient client, RemoteWebDriver driver, UserDto user)
        {
            _client = client;
            _driver = driver;
            _user = user;
        }

        [Then(@"default list page Size is ""(.*)"" and Cache ""(.*)""")]
        public void ThenDefaultListPageSizeIsAndCache(string pageSize, string pageCache)
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
            var gridPageSize = pageOptions["gridPageSize"].ToString();
            var gridPageCache = pageOptions["gridPageCache"].ToString();
            if (gridPageSize.Equals(string.Empty) ||
                gridPageCache.Equals(string.Empty))
            {
                When($"User clicks \"{"Devices"}\" on the left-hand menu");
                Then($"\"{"Devices"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Devices"}\" page");
                When($"User clicks \"{"Users"}\" on the left-hand menu");
                Then($"\"{"Users"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Users"}\" page");
                When($"User clicks \"{"Applications"}\" on the left-hand menu");
                Then($"\"{"Applications"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Applications"}\" page");
                When($"User clicks \"{"Mailboxes"}\" on the left-hand menu");
                Then($"\"{"Mailboxes"}\" list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Mailboxes"}\" page");
            }
            else
            {
                Utils.Verify.AreEqual(pageSize, gridPageSize, "Incorrect Page Size on Account page");
                Utils.Verify.AreEqual(pageCache, gridPageCache, "Incorrect Cache Size on Account page");
            }
        }

        [Then(@"page Size is ""(.*)"" on ""(.*)"" page")]
        public void ThenPageSizeIsOnPage(int pageSize, string pageName)
        {
            _driver.WaitForDataLoading();
            var lastNetworkRequest = JsonConvert.DeserializeObject<JArray>(_driver.GetNetworkLogByJavascript()).Last;
            Utils.Verify.That(lastNetworkRequest["name"].ToString(), Does.Contain($"?$top={pageSize}"), $"Page Size is not {pageSize}");
        }

        [When(@"User language is changed to ""(.*)"" via API")]
        public void WhenUserChangesAccountLanguageInProfile(string lng)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}userProfile/updatePreferences";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("Accept", "application/json");
            request.AddParameter("Content-Type", "application/json");

            request.AddParameter("displayMode", 0);
            request.AddParameter("languageName", PreferenceLanguageConverter.Convert(lng));
            request.AddParameter("timeZone", "GMT Standard Time");
            request.AddParameter("userId", DatabaseWorker.GetUserIdByLogin(_user.Username));


            var response = _client.Value.Put(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["details"]}");
        }

        [When(@"User navigates to Create Readiness page of ""(.*)"" project")]
        public void WhenUserNavigatesToCreateReadinessPageOfParticularProject(string project)
        {
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{DatabaseHelper.GetProjectId(project)}/readiness/createReadiness");
            _driver.WaitForDataLoading();
        }

        [When(@"User navigates to Readiness page of ""(.*)"" project")]
        public void WhenUserNavigatesToReadinessPageOfParticularProject(string project)
        {
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{DatabaseHelper.GetProjectId(project)}/readiness");
            _driver.WaitForDataLoading();
        }
    }
}