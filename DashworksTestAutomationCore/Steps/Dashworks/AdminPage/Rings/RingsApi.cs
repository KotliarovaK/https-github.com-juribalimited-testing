using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.RingsApi
{
    [Binding]
    internal class RingsApi : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly RestWebClient _client;

        public RingsApi(RemoteWebDriver driver, DTO.RuntimeVariables.Projects projects, RestWebClient client)
        {
            _driver = driver;
            _projects = projects;
            _client = client;
        }

        [When(@"User navigates to Create Readiness page of ""(.*)"" project")]
        public void WhenUserNavigatesToCreateReadinessPageOfParticularProject(string project)
        {
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{DatabaseHelper.GetProjectId(project)}/readiness/createReadiness");
            _driver.WaitForDataLoading();
        }

        [When(@"User navigates to Readiness page of ""(.*)"" project")]
        public void WhenUserNavigatesToReadinessPageOfParticularProject(string project)
        {
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{DatabaseHelper.GetProjectId(project)}/readiness");
            _driver.WaitForDataLoading();
        }
    }
}