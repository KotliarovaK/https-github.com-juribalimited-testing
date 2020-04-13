using System;
using System.Net;
using System.Threading;
using AutomationUtils.Utils;
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

            var response = _client.Evergreen.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var pageOptions = JsonConvert.DeserializeObject<JObject>(content);
            var gridPageSize = pageOptions["gridPageSize"].ToString();
            var gridPageCache = pageOptions["gridPageCache"].ToString();
            if (gridPageSize.Equals(string.Empty) ||
                gridPageCache.Equals(string.Empty))
            {
                //Steps naming is changed. Please update appropriately From AdminLeftHandMenu class 
                When($"User clicks '{"Devices"}' on the left-hand menu");
                Then($"'{"Devices"}' list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Devices"}\" page");
                When($"User clicks '{"Users"}' on the left-hand menu");
                Then($"'{"Users"}' list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Users"}\" page");
                When($"User clicks '{"Applications"}' on the left-hand menu");
                Then($"'{"Applications"}' list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Applications"}\" page");
                When($"User clicks '{"Mailboxes"}' on the left-hand menu");
                Then($"'{"Mailboxes"}' list should be displayed to the user");
                Then($"page Size is \"{1000}\" on \"{"Mailboxes"}\" page");
            }
            else
            {
                Verify.AreEqual(pageSize, gridPageSize, "Incorrect Page Size on Account page");
                Verify.AreEqual(pageCache, gridPageCache, "Incorrect Cache Size on Account page");
            }
        }

        [Then(@"page Size is ""(.*)"" on ""(.*)"" page")]
        public void ThenPageSizeIsOnPage(int pageSize, string pageName)
        {
            _driver.WaitForDataLoading();
            var lastNetworkRequest = JsonConvert.DeserializeObject<JArray>(_driver.GetNetworkLogByJavascript()).Last;
            Verify.That(lastNetworkRequest["name"].ToString(), Does.Contain($"?$top={pageSize}"), $"Page Size is not {pageSize}");
        }

        [When(@"User language is changed to ""(.*)"" via API")]
        public void WhenUserChangesAccountLanguageInProfile(string lng)
        {
            _client.ChangeUserProfileLanguage(_user.Username, PreferenceLanguageConverter.Convert(lng));
            //Need to refresh page to apply language change
            _driver.Navigate().Refresh();
            _driver.WaitForDataLoading(60);
        } 
    }
}