using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
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
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listsDetails;
        private readonly UserDto _user;

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
            var queryString = GetDynamicQueryStringFromUrl(_driver.Url, pageName);
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

            //_driver.Navigate().Refresh();
            _driver.Navigate().GoToUrl(url);
            _driver.WaitForDataLoading();

            //Add created list to context
            _listsDetails.AddList(listName, listId);
        }

        [When(@"User create static list with ""(.*)"" name on ""(.*)"" page with following items")]
        public void WhenUserCreateStaticListWithNameOnPageWithFollowingItems(string listName, string pageName,
            Table table)
        {
            var items = string.Empty;

            if (string.IsNullOrWhiteSpace(table.Rows.First()["ItemName"]))
                foreach (var item in _client.GetAllItemsKeys(pageName))
                    items += item + ",";
            else
                foreach (var row in table.Rows)
                    items += _client.GetItemIdByName(row["ItemName"], pageName) + ",";

            items = items.TrimEnd(',');

            #region Create list

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

            var content = response.Content;
            var responseContent = JsonConvert.DeserializeObject<JObject>(content);
            var listId = responseContent["listId"].ToString();

            #endregion

            #region Send Options to allow Put requests

            requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{listId}";

            request = new RestRequest(requestUri);

            request.AddParameter("Accept", "*/*");
            request.AddParameter("Accept-Encoding", "gzip, deflate");
            request.AddParameter("Accept-Language", "en-GB,en;q=0.9,en-US;q=0.8,ru;q=0.7");
            request.AddParameter("Access-Control-Request-Headers", "content-type");
            request.AddParameter("Access-Control-Request-Method", "PUT");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Host", UrlProvider.RestClientBaseUrl.TrimEnd('/'));
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));

            response = _client.Value.Options(request);

            #endregion

            #region Add query to list

            var queryString = GetStaticQueryStringFromUrl(pageName, listId);
            request = new RestRequest(requestUri);

            request.AddParameter("Accept", "application/json");
            request.AddParameter("Accept-Encoding", "gzip, deflate");
            request.AddParameter("Accept-Language", "en-GB,en;q=0.9,en-US;q=0.8,ru;q=0.7");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Content-Type", "application/json");
            request.AddParameter("Host", UrlProvider.RestClientBaseUrl.TrimEnd('/'));
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("listId", listId);
            request.AddParameter("listName", listName);
            request.AddParameter("listType", "Static");
            request.AddParameter("queryString", queryString);
            request.AddParameter("sharedAccessType", "Private");
            request.AddParameter("userId", DatabaseWorker.GetUserIdByLogin(_user.UserName));

            response = _client.Value.Put(request);

            #endregion

            requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{listId}/items";
            request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("items", items);

            response = _client.Value.Post(request);

            var url = $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?$listid={listId}";

            _driver.Navigate().Refresh();
            _driver.Navigate().GoToUrl(url);
            _driver.WaitForDataLoading();

            //Add created list to context
            _listsDetails.AddList(listName, listId);
        }

        [Then(@"User remove list with ""(.*)"" name on ""(.*)"" page")]
        public void ThenUserRemoveListWithNameOnPage(string listName, string pageName)
        {
            var requestUri =
                $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{_listsDetails.GetListIdByName(listName)}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = _client.Value.Delete(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }

        private string GetDynamicQueryStringFromUrl(string url, string pageName)
        {
            var queryString = string.Empty;
            var pattern = @"\?\$(.*)";
            string originalPart = Regex.Match(url, pattern).Groups[1].Value;
            if (originalPart.Contains("select="))
                queryString = "$" + originalPart;
            else
                queryString = RestWebClient.GetDefaultColumnsUrlByPageName(pageName) + "&$" + originalPart;

            if (!originalPart.Contains("filter=")) queryString += "&$filter=";

            return queryString;
        }

        private string GetStaticQueryStringFromUrl(string pageName, string listId)
        {
            var queryString = string.Empty;
            queryString = RestWebClient.GetDefaultColumnsUrlByPageName(pageName) + "&$listid=" + $"{listId}";
            return queryString;
        }
    }
}