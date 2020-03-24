using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
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

            foreach (Cookie cookie in cookies) cookiesJar.Add(cookie);

            client.CookieContainer = cookiesJar;
        }

        public static AuthObject GetAuthenticationDetails(this RestClient client, string url)
        {
            var cientBaseUrl = client.BaseUrl;

            client.BaseUrl = new Uri(url);

            var doc = new HtmlDocument();

            int attempts = 2;
            var html = string.Empty;
            while (attempts > 0)
            {
                var request = new RestRequest();
                var response = client.Get(request);
                if (response.StatusCode != HttpStatusCode.OK)
                    Logger.Write($"Automation server is not responding: {response.StatusCode}");
                html = response.Content;
                if (!string.IsNullOrEmpty(html))
                {
                    doc.LoadHtml(html);
                    break;
                }

                attempts--;
                if (attempts <= 0)
                {
                    throw new Exception("Unable to get document during Authentication Details retrieving");
                }

                Thread.Sleep(800);
            }

            if (string.IsNullOrEmpty(html))
            {
                throw new Exception("Empty response from automation server was returned. Unable to get VIEWSTATE");
            }

            try
            {
                var viewstate = string.Empty;
                try
                {
                    viewstate = doc.DocumentNode.SelectSingleNode(".//input[@id='__VIEWSTATE']")
                        .GetAttributeValue("value", "Failed to get VIEWSTATE");
                }
                catch (Exception e)
                {
                    throw new Exception($"Unable to get VIEWSTATE: {e}");
                }

                var eventvalidation = string.Empty;
                try
                {
                    eventvalidation = doc.DocumentNode.SelectSingleNode(".//input[@id='__EVENTVALIDATION']")
                        .GetAttributeValue("value", "Failed to get EVENTVALIDATION");
                }
                catch (Exception e)
                {
                    throw new Exception($"Unable to get EVENTVALIDATION: {e}");
                }

                var viewstateGenerator = string.Empty;
                try
                {
                    viewstateGenerator = doc.DocumentNode.SelectSingleNode(".//input[@id='__VIEWSTATEGENERATOR']")
                        .GetAttributeValue("value", "Failed to get VIEWSTATEGENERATOR");
                }
                catch (Exception e)
                {
                    throw new Exception($"Unable to get VIEWSTATEGENERATOR: {e}");
                }

                client.BaseUrl = cientBaseUrl;

                return new AuthObject
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

        public static RestRequest GenerateSeniorRequest(this RestClient client, string requestUri)
        {
            var auth = client.GetAuthenticationDetails(requestUri);

            var request = new RestRequest(requestUri);

            request.AddParameter("Referer", requestUri);
            request.AddParameter("__VIEWSTATE", auth.Viewstate);
            request.AddParameter("__VIEWSTATEGENERATOR", auth.ViewstateGenerator);
            request.AddParameter("__EVENTVALIDATION", auth.Eventvalidation);

            return request;
        }
    }
}