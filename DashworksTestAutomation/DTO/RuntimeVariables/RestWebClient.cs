﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("displayMode", 0);
            request.AddParameter("languageName", language);
            request.AddParameter("userId", userId);

            var response = Value.Put(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }

        public string GetItemIdByName(string itemName, string pageName)
        {
            var column = "";
            var returnValue = "";
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
                throw new Exception($"Unable to execute request. URI: {requestUri}");
            var content = response.Content;

            var allItems = JsonConvert.DeserializeObject<JObject>(content)["results"];
            var item = allItems.First(x => x[column].ToString().Equals(itemName));
            return item[returnValue].ToString();
        }

        public List<string> GetAllItemsKeys(string pageName)
        {
            var returnValue = "";
            List<string> returnList = new List<string>();
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
                throw new Exception($"Unable to execute request. URI: {requestUri}");
            var content = response.Content;

            var allItems = JsonConvert.DeserializeObject<JObject>(content)["results"];
            foreach (var item in allItems) returnList.Add(item[returnValue].ToString());

            return returnList;
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