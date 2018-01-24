using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using System;
using System.Net;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    internal class RestWebClient
    {
        public RestClient Value { get; set; }

        public RestWebClient()
        {
            Value = new RestClient(UrlProvider.RestClientBaseUrl);
        }

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
    }
}