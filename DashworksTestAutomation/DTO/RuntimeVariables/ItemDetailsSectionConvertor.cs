using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    class ItemDetailsSectionConvertor
    {
        public RestClient Value { get; set; }

        public ItemDetailsSectionConvertor()
        {
            Value = new RestClient(UrlProvider.RestClientBaseUrl);
        }

        public string GetColumnNameByPageName(string pageName, string tabName)
        {
            var column = "";
            var returnValue = "";
            switch (pageName)
            {
                case "Devices":
                    column = "hostname";
                    returnValue = "deviceDetails";
                    break;
                case "Users":
                    column = "username";
                    returnValue = "userDetails";
                    break;
                case "Applications":
                    column = "packageName";
                    returnValue = "applicationDetails";
                    break;
                case "Mailboxes":
                    column = "principalEmailAddress";
                    returnValue = "mailboxDetails";
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
            var item = allItems.First(x => x[column].ToString().Equals(tabName));
            return item[returnValue].ToString();
        }
    }
}
