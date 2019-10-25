using System;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
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
        private readonly Dashboards _dashboard;
        private readonly RestWebClient _client;
        private readonly UserDto _user;

        private EvergreenJnr_API_DashboardPage(RemoteWebDriver driver, Dashboards dashboard,
            RestWebClient client, UserDto user)
        {
            _driver = driver;
            _dashboard = dashboard;
            _client = client;
            _user = user;
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
            var newDashboard = new DashboardDto()
            { DashboardName = name, DashboardId = responseContent["dashboardId"].ToString() };
            _dashboard.Value.Add(newDashboard);

            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}/#/dashboards/{newDashboard.DashboardId}");
        }

        [When(@"Dashboard with ""(.*)"" name is opened via API")]
        public void WhenDashboardWithNameIsOpenedViaApi(string name)
        {
            _driver.Navigate()
                .GoToUrl($"{UrlProvider.EvergreenUrl}/#/dashboards/{DatabaseHelper.GetDashboardId(name, _user.Id)}");
            _driver.WaitForDataLoading();
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedDashboard()
        {
            if (!_dashboard.Value.Any())
                return;

            foreach (DashboardDto dashboardDto in _dashboard.Value)
            {
                try
                {
                    var requestUri = $"{UrlProvider.RestClientBaseUrl}dashboard/{dashboardDto.DashboardId}";

                    var request = new RestRequest(requestUri);
                    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                    var response = _client.Value.Delete(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Console.WriteLine($"Unable to delete dashboard with '{dashboardDto.DashboardName}' name: {response.StatusCode}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to delete dashboard with '{dashboardDto.DashboardName}' name: {e}");
                }
            }
        }
    }
}