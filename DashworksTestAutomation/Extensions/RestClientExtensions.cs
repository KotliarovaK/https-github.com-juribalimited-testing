using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using HtmlAgilityPack;
using RestSharp;

namespace DashworksTestAutomation.Extensions
{
    public static class RestClientExtensions
    {
        public static void AddCookies(this RestClient client, IEnumerable<Cookie> cookies)
        {
            client.CookieContainer = null;

            var cookiesJar = new CookieContainer();

            foreach (Cookie cookie in cookies)
            {
                cookiesJar.Add(cookie);
            }

            client.CookieContainer = cookiesJar;
        }

        public static AuthObject GetAuthenticationDetails(this RestClient client, string url)
        {
            var cientBaseUrl = client.BaseUrl;

            client.BaseUrl = new Uri(url);

            var requet = new RestRequest();
            var html = client.Get(requet).Content;
            var doc = new HtmlDocument();

            doc.LoadHtml(html);

            var viewstate = doc.DocumentNode.SelectSingleNode(".//input[@id='__VIEWSTATE']")
                .GetAttributeValue("value", "Failed to get VIEWSTATE");

            var eventvalidation = doc.DocumentNode.SelectSingleNode(".//input[@id='__EVENTVALIDATION']")
                .GetAttributeValue("value", "Failed to get EVENTVALIDATION");

            var viewstateGenerator = doc.DocumentNode.SelectSingleNode(".//input[@id='__VIEWSTATEGENERATOR']")
                .GetAttributeValue("value", "Failed to get VIEWSTATEGENERATOR");

            client.BaseUrl = cientBaseUrl;

            return new AuthObject()
            {
                Eventvalidation = eventvalidation,
                Viewstate = viewstate,
                ViewstateGenerator = viewstateGenerator
            };
        }
    }
}
