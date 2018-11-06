using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    internal class RestWebClient
    {
        public RestWebClient()
        {
            Value = new RestClient(UrlProvider.RestClientBaseUrl);
        }

        public RestClient Value { get; set; }

        public void ChangeUserProfileLanguage(string userName, string language)
        {
            var userId = DatabaseWorker.GetUserIdByLogin(userName);
            var requestUri = $"{UrlProvider.RestClientBaseUrl}userProfile/updatePreferences";

            #region Send Options to allow Put requests

            var request = new RestRequest(requestUri);

            request.AddParameter("Accept", "*/*");
            request.AddParameter("Accept-Encoding", "gzip, deflate");
            request.AddParameter("Accept-Language", "en-GB,en;q=0.9,en-US;q=0.8,ru;q=0.7");
            request.AddParameter("Access-Control-Request-Headers", "content-type");
            request.AddParameter("Access-Control-Request-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            request.AddParameter("Connection", "keep-alive");
            request.AddParameter("Host", UrlProvider.RestClientBaseUrl.TrimEnd('/'));
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));

            Value.Options(request);

            #endregion

            request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("displayMode", 0);
            request.AddParameter("languageName", language);
            request.AddParameter("userId", userId);

            var response = Value.Put(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Status Code: {response.StatusCode}, URI: {requestUri}");

            #region User Language Verification

            requestUri = $"{UrlProvider.RestClientBaseUrl}security/userprofile";
            request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            response = Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");

            var content = response.Content;

            var pageOptions = JsonConvert.DeserializeObject<JObject>(content);
            var userLanguage = pageOptions["languageName"].ToString();
            Assert.AreEqual(userLanguage, language, "Profile language was not changed");

            #endregion
        }

        public string GetItemIdByName(string itemName, string pageName)
        {
            string column;
            string returnValue;
            switch (pageName)
            {
                case "Devices":
                    column = "hostname";
                    returnValue = "computerKey";
                    break;
                case "Users":
                    column = "username";
                    returnValue = "objectKey";
                    break;
                case "Applications":
                    column = "packageName";
                    returnValue = "packageKey";
                    break;
                case "Mailboxes":
                    column = "principalEmailAddress";
                    returnValue = "mailboxKey";
                    break;
                default:
                    throw new Exception($"{pageName} not found");
            }

            var requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Status Code: {response.StatusCode}, URI: {requestUri}");
            var content = response.Content;

            var allItems = JsonConvert.DeserializeObject<JObject>(content)["results"];
            var item = allItems.First(x => x[column].ToString().Equals(itemName));
            return item[returnValue].ToString();
        }

        public List<string> GetAllItemsKeys(string pageName)
        {
            string returnValue;
            switch (pageName)
            {
                case "Devices":
                    returnValue = "computerKey";
                    break;
                case "Users":
                    returnValue = "objectKey";
                    break;
                case "Applications":
                    returnValue = "packageKey";
                    break;
                case "Mailboxes":
                    returnValue = "mailboxKey";
                    break;
                default:
                    throw new Exception($"{pageName} not found");
            }

            var requestUri = $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower()}";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            var response = Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Status Code: {response.StatusCode}, URI: {requestUri}");
            var content = response.Content;

            var allItems = JsonConvert.DeserializeObject<JObject>(content)["results"];

            return allItems.Select(item => item[returnValue].ToString()).ToList();
        }

        public static string GetDefaultColumnsUrlByPageName(string pageName)
        {
            switch (pageName)
            {
                case "Devices":
                    return "$select=hostname,chassisCategory,oSCategory,ownerDisplayName";
                case "Users":
                    return "$select=username,directoryName,displayName,fullyDistinguishedObjectName";
                case "Applications":
                    return "$select=packageName,packageManufacturer,packageVersion";
                case "Mailboxes":
                    return "$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName";
                default:
                    throw new Exception($"{pageName} not found");
            }
        }
    }
}