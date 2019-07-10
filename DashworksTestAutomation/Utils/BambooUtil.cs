using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var url = $"/browse/{BambooProvider.ProjectKey}-{BambooProvider.BuildNumber - 1}/test";
                var request = new RestRequest(Method.GET) { Resource = url };
                Logger.Write($"GetAllQuarantinedTests: {url}");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                HtmlDocument doc = new HtmlDocument();
                string html = response.Content;
                doc.LoadHtml(html);

                var quarantinedTests =
                    doc.DocumentNode.SelectNodes("//table[@id='quarantined-tests']//a[@class='test-name']");

                List<KeyValuePair<string, string>> testIdsWithNames = new List<KeyValuePair<string, string>>();
                foreach (HtmlNode node in quarantinedTests)
                {
                    var id = node.GetAttributeValue("href", null).Split('/').Last();
                    var name = node.InnerText;
                    testIdsWithNames.Add(new KeyValuePair<string, string>(id, name));
                }

                #endregion

                if (_quarantinedTests != null)
                    Logger.Write($"1 Quarantined tests: {String.Join(", ", testIdsWithNames.ToArray().Select(x => x.Value).ToArray())}");
                else
                    Logger.Write("1 There are not Quarantined tests!");

                _quarantinedTests = testIdsWithNames;
            }
            catch
            {
                _quarantinedTests = null;
            }
        }

        public static void UnleashTest(string testName)
        {
            try
            {
                if (_quarantinedTests != null)
                    Logger.Write($"2 Quarantined tests: {String.Join(", ", _quarantinedTests.ToArray().Select(x => x.Value).ToArray())}");
                else
                    Logger.Write("2 There are not Quarantined tests!");

                if (_quarantinedTests != null && _quarantinedTests.Any(x => x.Value.Equals(testName)))
                {
                    RestClient client = GetClient();

                    var testId = _quarantinedTests.First(x => x.Value.Equals(testName)).Key;
                    var url =
                        $"/rest/api/latest/plan/{BambooProvider.ProjectKey}-{BambooProvider.BuildNumber}/test/{testId}/unleash";
                    var request = new RestRequest(Method.POST)
                    {
                        Resource = url
                    };
                    Logger.Write($"UnleashTest: {request.Resource}");
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json; charset=utf-8");

                    request.RequestFormat = DataFormat.Json;

                    var response = client.Execute(request);
                }
            }
            catch { }
        }
    }
}
