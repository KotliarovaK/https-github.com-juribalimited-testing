using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Dashboard
{
    [Binding]
    public class EvergreenJnr_API_DashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Dashboard _dashboard;
        private readonly RestWebClient _client;

        private EvergreenJnr_API_DashboardPage(RemoteWebDriver driver, DTO.RuntimeVariables.Dashboard dashboard, RestWebClient client)
        {
            _driver = driver;
            _dashboard = dashboard;
            _client = client;
        }

        [When(@"Dashboard with ""(.*)"" name created via API and opened")]
        public void WhenUserCreateNewDashboardViaApi(string name)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}dashboard";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("Accept", "application/json");
            request.AddParameter("Content-Type", "application/json");
            request.AddParameter("dashboardName", name);
            request.AddParameter("sharedAccessType", "private");

            var response = _client.Value.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["details"]}");

            var responseContent = JsonConvert.DeserializeObject<JObject>(response.Content);
            _dashboard.Value.dashboardId = responseContent["dashboardId"].ToString();

            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}/#/dashboards/{_dashboard.Value.dashboardId}");
        }


        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedDashboard()
        {
            try
            {
                if (string.IsNullOrEmpty(_dashboard.Value.dashboardId))
                    return;

                var requestUri = $"{UrlProvider.RestClientBaseUrl}dashboard/{_dashboard.Value.dashboardId}";

                var request = new RestRequest(requestUri);
                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                var response = _client.Value.Delete(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(
                        $"Unable to execute request. Status Code: {response.StatusCode}, URI: {requestUri}");
            }
            catch
            {
            }

        }
    }
}