using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.Providers;
using HtmlAgilityPack;
using RestSharp;
using RestSharp.Authenticators;

namespace DashworksTestAutomation.Utils
{
    public static class BambooUtil
    {
        static List<KeyValuePair<string, string>> _quarantinedTests;

        private static RestClient GetClient()
        {
            return new RestClient
            {
                BaseUrl = new Uri(BambooProvider.BaseUrl),
                Authenticator = new HttpBasicAuthenticator(BambooProvider.Username, BambooProvider.Password)
            };
        }

        public static void GetAllQuarantinedTests()
        {
            try
            {
                RestClient client = GetClient();

                #region Get all quarantined Tests

                var url = $"/browse/{BambooProvider.ProjAndBuild}-{BambooProvider.BuildNumber - 1}/test";
                var request = new RestRequest(Method.GET) { Resource = url };
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                HtmlDocument doc = new HtmlDocument();
                string html = response.Content;
                doc.LoadHtml(html);

                var quarantinedTests =
                    doc.DocumentNode.SelectNodes("//table[@id='quarantined-tests']//a[@class='test-name']");

                if (quarantinedTests == null || !quarantinedTests.Any())
                {
                    Logger.Write("There are no tests on quarantine");
                    _quarantinedTests = null;
                    return;
                }

                List<KeyValuePair<string, string>> testIdsWithNames = new List<KeyValuePair<string, string>>();
                foreach (HtmlNode node in quarantinedTests)
                {
                    var id = node.GetAttributeValue("href", null).Split('/').Last();
                    //Exclude text from parentheses from text name. Relevant only for Scenario Outline
                    var name = node.InnerText.Contains("(") ?
                        node.InnerText.Split('(').First() : node.InnerText;
                    Logger.Write($"ADDED new test: {id}: {name}");
                    testIdsWithNames.Add(new KeyValuePair<string, string>(id, name));
                }

                #endregion

                Logger.Write(testIdsWithNames != null
                    ? $"Quarantined tests: {String.Join(", ", testIdsWithNames.ToArray().Select(x => x.Value).ToArray())}"
                    : "There are not Quarantined tests!");

                _quarantinedTests = testIdsWithNames;
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to get quarantined tests: {e}");
                _quarantinedTests = null;
            }
        }

        public static void UnleashTest(string testName)
        {
            try
            {
                if (_quarantinedTests != null && _quarantinedTests.Any(x => x.Value.Equals(testName)))
                {
                    RestClient client = GetClient();

                    var testId = _quarantinedTests.First(x => x.Value.Equals(testName)).Key;
                    var url =
                        $"/rest/api/latest/plan/{BambooProvider.ProjAndBuild}-{BambooProvider.BuildNumber}/test/{testId}/unleash";
                    var request = new RestRequest(Method.POST)
                    {
                        Resource = url
                    };
                    Logger.Write($"UnleashTest: {request.Resource}");
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json; charset=utf-8");

                    request.RequestFormat = DataFormat.Json;

                    var response = client.Execute(request);

                    Logger.Write(response.StatusCode != HttpStatusCode.OK
                        ? $"Error during unleashing test: {response.StatusCode}"
                        : $"Test {testName} was unleashed");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Error during unleashing test: {e}");
            }
        }
    }
}
