using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Steps.Senior.CustomeFields.CreateCustomFields;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_Lists : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listsDetails;
        private readonly UserDto _user;
        private readonly CreateCustomFieldMethods _createCustomFieldMethods;
        private readonly UsersWithSharedLists _usersWithSharedLists;

        public EvergreenJnr_Lists(RestWebClient client, UserDto user, RemoteWebDriver driver, ListsDetails listsDetails,
            SeniorCustomFields customFields, UsersWithSharedLists usersWithSharedLists)
        {
            _client = client;
            _user = user;
            _driver = driver;
            _listsDetails = listsDetails;
            _createCustomFieldMethods = new CreateCustomFieldMethods(_client, customFields);
            _usersWithSharedLists = usersWithSharedLists;
        }

        [When(@"User creates list with '(.*)' name and missing column on '(.*)' page")]
        public void WhenUserCreatesListWithNameAndMissingColumnOnPage(string listName, string pageName)
        {
            #region Create Custom Field

            var randomCustomField = new SeniorCustomFieldDto()
            {
                AllowExternalUpdate = true,
                Enabled = true,
                FieldLabel = $"CFL_{Guid.NewGuid().ToString("N").ToUpper()}",
                FieldName = $"CFN_{Guid.NewGuid().ToString("N").ToUpper()}"
            };

            switch (pageName)
            {
                case "Devices":
                    randomCustomField.Computer = true;
                    break;
                case "Users":
                    randomCustomField.User = true;
                    break;
                case "Mailboxes":
                    randomCustomField.Mailbox = true;
                    break;
                case "Applications":
                    randomCustomField.Application = true;
                    break;
                default:
                    throw new Exception($"Unknown page type: {pageName}");
            }

            _createCustomFieldMethods.Create(new List<SeniorCustomFieldDto>() { randomCustomField });

            #endregion

            var columnsUrl =
                $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?{RestWebClient.GetDefaultColumnsUrlByPageName(pageName)}";
            columnsUrl += $",customField_{randomCustomField.Id}";

            CreateDynamicList(listName, pageName, columnsUrl);

            DatabaseHelper.DeleteCustomField(randomCustomField.Id);
        }

        [When(@"User creates broken list with '(.*)' name on '(.*)' page")]
        public void WhenUserCreateBrokenListWithNameOnPage(string listName, string pageName)
        {
            var urlWithNotExistingFilter =
                $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?$filter=(notExistingFilter%20EQUALS%20('notExistingValue'))";

            CreateDynamicList(listName, pageName, urlWithNotExistingFilter);
        }

        [When(@"User create dynamic list with ""(.*)"" name on ""(.*)"" page")]
        public void WhenUserCreateDynamicListWithNameOnPage(string listName, string pageName)
        {
            var url = CreateDynamicList(listName, pageName, _driver.Url);

            _driver.Navigate().GoToUrl(url);
            _driver.WaitForDataLoading();

            var list = _driver.NowAt<CustomListElement>();
            var activeList = list.GetActiveList();
            try
            {
                if (_driver.IsElementExists(activeList))
                {
                    _driver.MoveToElement(activeList);
                }
                _driver.ExecuteAction(() => _driver.WaitForElementToBeDisplayed(activeList));
            }
            catch (Exception e)
            {
                Logger.Write($"Created list was not active. {e}");
                Logger.Write(
                    $"Active list was not switched automatically, browser URL: {_driver.Url}");
                _driver.Navigate().Refresh();
                _driver.WaitForDataLoading();
                _driver.WaitForElementToBeDisplayed(list.GetListElementByName(listName));
                list.GetListElementByName(listName).Click();
                _driver.WaitForDataLoading();
                Verify.IsTrue(list.GetActiveList().Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            }
        }

        private string CreateDynamicList(string name, string pageName, string url)
        {
            var queryString = GetDynamicQueryStringFromUrl(url, pageName);
            var requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("listName", name);
            request.AddParameter("listType", "dynamic");
            request.AddParameter("queryString", queryString);
            request.AddParameter("sharedAccessType", "Private");
            request.AddParameter("userId", DatabaseHelper.GetUserIdByLogin(_user.Username));

            var response = _client.Evergreen.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Status Code: {response.StatusCode}, URI: {requestUri}");

            var content = response.Content;

            var responseContent = JsonConvert.DeserializeObject<JObject>(content);
            var listId = responseContent["listId"].ToString();
            var resultUrl = $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?$listid={listId}";

            //Add created list to context
            _listsDetails.AddList(name, listId);
            _usersWithSharedLists.Value.Add(_user.Username);

            return resultUrl;
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

            #region Send Options to allow Post requests

            var requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}";

            var request = new RestRequest(requestUri);

            request.AddParameter("Accept", "*/*");
            request.AddParameter("Accept-Encoding", "gzip, deflate");
            request.AddParameter("Accept-Language", "en-GB,en;q=0.9,en-US;q=0.8,ru;q=0.7");
            request.AddParameter("Access-Control-Request-Headers", "content-type");
            request.AddParameter("Access-Control-Request-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Host", UrlProvider.RestClientBaseUrl.TrimEnd('/'));
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));

            _client.Evergreen.Options(request);

            #endregion

            #region Create list

            requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}";
            request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("listName", listName);
            request.AddParameter("listType", "Static");
            request.AddParameter("sharedAccessType", "Private");
            request.AddParameter("userId", DatabaseHelper.GetUserIdByLogin(_user.Username));

            var response = _client.Evergreen.Post(request);

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
            request.AddParameter("Access-Control-Request-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Host", UrlProvider.RestClientBaseUrl.TrimEnd('/'));
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));

            _client.Evergreen.Options(request);

            #endregion

            #region Add query to list

            var queryString = GetStaticQueryStringFromUrl(pageName, listId);
            requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{listId}";
            request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("listId", listId);
            request.AddParameter("listName", listName);
            request.AddParameter("listType", "Static");
            request.AddParameter("queryString", queryString);
            request.AddParameter("sharedAccessType", "Private");
            request.AddParameter("userId", DatabaseHelper.GetUserIdByLogin(_user.Username));

            response = _client.Evergreen.Put(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            #endregion

            #region Send Options to allow Put requests

            requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{listId}/items";

            request = new RestRequest(requestUri);

            request.AddParameter("Accept", "*/*");
            request.AddParameter("Accept-Encoding", "gzip, deflate");
            request.AddParameter("Accept-Language", "en-GB,en;q=0.9,en-US;q=0.8,ru;q=0.7");
            request.AddParameter("Access-Control-Request-Headers", "content-type");
            request.AddParameter("Access-Control-Request-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Host", UrlProvider.RestClientBaseUrl.TrimEnd('/'));
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));

            _client.Evergreen.Options(request);

            #endregion

            #region Add items to list

            requestUri = $"{UrlProvider.RestClientBaseUrl}lists/{pageName.ToLower()}/{listId}/items";
            request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("items", items);

            response = _client.Evergreen.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Status Code: {response.StatusCode}, URI: {requestUri}");

            var url = $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?$listid={listId}";

            _driver.Navigate().GoToUrl(url);
            _driver.WaitForDataLoading();

            #endregion

            //Add created list to context
            _listsDetails.AddList(listName, listId);
            var list = _driver.NowAt<CustomListElement>();
            var activeList = list.GetActiveList();
            try
            {
                if (!_driver.IsElementDisplayed(activeList))
                {
                    _driver.MoveToElement(activeList);
                }
                _driver.ExecuteAction(() => _driver.WaitForElementToBeDisplayed(activeList));
            }
            catch (Exception e)
            {
                Logger.Write($"Created list was not active. {e}");
                Logger.Write(
                    $"Active list was not switched automatically, browser URL: {_driver.Url}");
                _driver.Navigate().Refresh();
                _driver.WaitForDataLoading();
                list.GetListElementByName(listName).Click();
                _driver.WaitForDataLoading();
                Verify.IsTrue(list.GetActiveList().Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            }
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

            var response = _client.Evergreen.Delete(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }

        private static string GetDynamicQueryStringFromUrl(string url, string pageName)
        {
            string queryString;
            const string pattern = @"\?\$(.*)";
            var originalPart = Regex.Match(url, pattern).Groups[1].Value;
            if (originalPart.Contains("select="))
                queryString = "$" + originalPart;
            else
                queryString = RestWebClient.GetDefaultColumnsUrlByPageName(pageName) + "&$" + originalPart;

            if (!originalPart.Contains("filter=")) queryString += "&$filter=";

            return queryString;
        }

        private static string GetStaticQueryStringFromUrl(string pageName, string listId)
        {
            var queryString = RestWebClient.GetDefaultColumnsUrlByPageName(pageName) + $"&$listid={listId}";
            return queryString;
        }
    }
}