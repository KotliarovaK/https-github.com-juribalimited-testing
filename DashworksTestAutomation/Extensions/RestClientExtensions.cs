using DashworksTestAutomation.DTO;
using HtmlAgilityPack;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

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

            var doc = new HtmlDocument();

            int attempts = 2;
            while (attempts > 0)
            {
                var requet = new RestRequest();
                var html = client.Get(requet).Content;
                if (!string.IsNullOrEmpty(html))
                {
                    doc.LoadHtml(html);
                    break;
                }

                attempts--;
                if (attempts <= 0)
                    throw new Exception("Unable to get document during Authentication Details retrieving");

                Thread.Sleep(800);
            }

            try
            {
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
            catch (Exception e)
            {
                throw new Exception($"Error getting Authentication Details: {e}");
            }
        }
    }
}