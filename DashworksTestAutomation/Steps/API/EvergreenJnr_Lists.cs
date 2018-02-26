using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_Lists : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly UserDto _user;
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listsDetails;

        public EvergreenJnr_Lists(RestWebClient client, UserDto user, RemoteWebDriver driver, ListsDetails listsDetails)
        {
            _client = client;
            _user = user;
            _driver = driver;
            _listsDetails = listsDetails;
        }

        [When(@"User create dynamic list with ""(.*)"" name on ""(.*)"" page")]
        public void WhenUserCreateDynamicListWithNameOnPage(string listName, string pageName)
        {
            var queryString = GetQueryStringFromUrl(_driver.Url, pageName);
            var requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("listName", listName);
            request.AddParameter("listType", "dynamic");
            request.AddParameter("queryString", queryString);
            request.AddParameter("sharedAccessType", "Private");
            request.AddParameter("userId", DatabaseWorker.GetUserIdByLogin(_user.UserName));

            var response = _client.Value.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            _driver.Navigate().Refresh();

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<JObject>(content);
            var listId = responseContent["listId"].ToString();
            var url = $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?$listid={listId}";

            _driver.Navigate().GoToUrl(url);
            _driver.WaitForDataLoading();

            //Add created list to context
            _listsDetails.AddList(listName, listId);
        }

        [When(@"User create static list with ""(.*)"" name on ""(.*)"" page")]
        public void WhenUserCreateStaticListWithNameOnPage(string listName, string pageName)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("listName", listName);
            request.AddParameter("listType", "Static");
            request.AddParameter("sharedAccessType", "Private");
            request.AddParameter("userId", DatabaseWorker.GetUserIdByLogin(_user.UserName));

            var response = _client.Value.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            _driver.Navigate().Refresh();

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<JObject>(content);
            var listId = responseContent["listId"].ToString();
            var url = $"{UrlProvider.EvergreenUrl}/lists/{pageName.ToLower()}/{listId}/items";

            _driver.Navigate().GoToUrl(url);
            _driver.WaitForDataLoading();

            //Add created list to context
            _listsDetails.AddList(listName, listId);
        }

        [Then(@"User remove list with ""(.*)"" name on ""(.*)"" page")]
        public void ThenUserRemoveListWithNameOnPage(string listName, string pageName)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{_listsDetails.GetListIdByName(listName)}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Delete(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }

        private string GetQueryStringFromUrl(string url, string pageName)
        {
            var queryString = string.Empty;
            var pattern = @"\?\$(.*)";
            string originalPart = Regex.Match(url, pattern).Groups[1].Value;
            if (originalPart.Contains("select="))
            {
                queryString = "$" + originalPart;
            }
            else
            {
                queryString = RestWebClient.GetDefaultColumnsUrlByPageName(pageName) + "&$" + originalPart;
            }
            if (!originalPart.Contains("filter="))
            {
                queryString += "&$filter=";
            }
            return queryString;
        }
    }
}
