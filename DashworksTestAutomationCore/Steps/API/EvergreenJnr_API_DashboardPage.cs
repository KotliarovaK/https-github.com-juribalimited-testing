using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.Dashboards;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Dashboard
{
    [Binding]
    public class EvergreenJnr_API_DashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Dashboards _dashboard;
        private readonly RestWebClient _client;
        private readonly UserDto _user;

        private EvergreenJnr_API_DashboardPage(RemoteWebDriver driver, DTO.RuntimeVariables.Dashboards dashboard,
            RestWebClient client, UserDto user)
        {
            _driver = driver;
            _dashboard = dashboard;
            _client = client;
            _user = user;
        }

        [When(@"Dashboard with '(.*)' name created via API and opened")]
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

            var response = _client.Evergreen.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["details"]}");

            var responseContent = JsonConvert.DeserializeObject<JObject>(response.Content);

            var newDashboard = new DashboardDto()
            {
                DashboardName = name,
                DashboardId = responseContent["dashboardId"].ToString(),
                User = _user
            };
            _dashboard.Value.Add(newDashboard);

            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/dashboards/{newDashboard.DashboardId}");
            var dash =_driver.NowAt<EvergreenDashboardsPage>();
        }

        [When(@"Dashboard with '(.*)' name is opened via API")]
        public void WhenDashboardWithNameIsOpenedViaApi(string name)
        {
            var id = _dashboard.Value.Any(x => x.DashboardName.Equals(name))
                ? _dashboard.Value.First(x => x.DashboardName.Equals(name)).DashboardId
                : DatabaseHelper.GetDashboardId(name, _user.Id);

            _driver.Navigate()
                .GoToUrl($"{UrlProvider.EvergreenUrl}/#/dashboards/{id}");
            _driver.WaitForDataLoading(60);
        }

        [Then(@"URL contains '(.*)' dashboard Id")]
        public void ThenURLContainsDashboardId(string dashboard)
        {
            var id = _dashboard.Value.Any(x => x.DashboardName.Equals(dashboard))
                ? _dashboard.Value.First(x => x.DashboardName.Equals(dashboard)).DashboardId
                : DatabaseHelper.GetDashboardId(dashboard, _user.Id);
            Verify.Contains(id, _driver.Url, $"URL is not contains '{id}'");
        }
    }
}