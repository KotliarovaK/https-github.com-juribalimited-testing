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
        static string _projAndBuild = $"{BambooProvider.ProjectKey}-{BambooProvider.BuildKey}";
        static List<KeyValuePair<string, string>> _quarantinedTests;
        static int _prevBuildId;

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
                var request = new RestRequest(Method.GET) { Resource = $"/browse/{_projAndBuild}" };
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                #region Get previous build ID

                HtmlDocument doc = new HtmlDocument();
                string html = response.Content;
                doc.LoadHtml(html);
                var buildIdElement = doc.DocumentNode.SelectNodes("//a[@class='statusIndicator']");
                _prevBuildId = int.Parse(buildIdElement.First().GetAttributeValue("href", null).Split('/').Last().Split('-').Last()) - 1;

                #endregion

                #region Get all quarantined Tests 

                request = new RestRequest(Method.GET) { Resource = $"/browse/{_projAndBuild}-{_prevBuildId}/test" };
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.RequestFormat = DataFormat.Json;
                response = client.Execute(request);

                html = response.Content;
                doc.LoadHtml(html);

                var quarantinedTests =
                    doc.DocumentNode.SelectNodes("//table[@id='skipped-tests']//a[@class='test-name']");

                List<KeyValuePair<string, string>> testIdsWithNames = new List<KeyValuePair<string, string>>();
                foreach (HtmlNode node in quarantinedTests)
                {
                    var id = node.GetAttributeValue("href", null).Split('/').Last();
                    var name = node.InnerText;
                    testIdsWithNames.Add(new KeyValuePair<string, string>(id, name));
                }

                #endregion

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
                if (_quarantinedTests != null && _quarantinedTests.Any(x => x.Value.Equals(testName)))
                {
                    RestClient client = GetClient();

                    var testId = _quarantinedTests.First(x => x.Value.Equals(testName)).Key;

                    var request = new RestRequest(Method.POST)
                    {
                        Resource = $"/rest/api/latest/plan/{_projAndBuild}-{_prevBuildId + 1}/test/{testId}/unleash"
                    };
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
