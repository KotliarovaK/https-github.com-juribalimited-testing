using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios;
using AutomationUtils.Extensions;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService
{
    [Binding]
    class CreateSelfService
    {
        private readonly RemoteWebDriver _driver;
        private readonly SelfServices _selfServices;
        private readonly SelfServiceApiMethods _selfServiceApiMethods;
        private SelfServicePages _selfServicePages;

        public CreateSelfService(RemoteWebDriver driver, SelfServices selfServices, RestWebClient client, SelfServicePages selfServicePages)
        {
            _driver = driver;
            _selfServices = selfServices;
            _selfServiceApiMethods = new SelfServiceApiMethods(selfServices, client);
            _selfServicePages = selfServicePages;
        }

        [When(@"User creates Self Service via API and open it")]
        public void WhenUserCreatesSelfServiceViaAPIAndOpenIt(Table table)
        {
            var exception = string.Empty;
            _selfServices.Value.AddRange(_selfServiceApiMethods.CreateSelfService(table, out exception, ref _selfServicePages).Value);
            if (!string.IsNullOrEmpty(exception))
            {
                throw new Exception(exception);
            }

            var lastSs = _selfServices.Value.Last();

            _driver.WaitForDataLoading();
            var url = $"{UrlProvider.EvergreenUrl}#/admin/selfservice/{lastSs.ServiceId}/details";
            _driver.Navigate().GoToUrl(url);

            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(lastSs.Name);
        }

        [When(@"User opens '(.*)' Self Service")]
        public void WhenUserOpensSelfService(string selfService)
        {
            var ss = _selfServices.Value.First(x => x.Name.Equals(selfService));
            _driver.WaitForDataLoading();
            var url = $"{UrlProvider.EvergreenUrl}#/admin/selfservice/{ss.ServiceId}/details";
            _driver.Navigate().GoToUrl(url);
        }

        [When(@"User opens '(.*)' Self Service in a new tab")]
        public void WhenUserOpensSelfServiceInANewTab(string selfService)
        {
            var ss = _selfServices.Value.First(x => x.ServiceIdentifier.Equals(selfService));
            _driver.WaitForDataLoading();
            var url = $"{UrlProvider.EvergreenUrl}#/admin/selfservice/{ss.ServiceId}/details";

            _driver.OpenInNewTab(url);
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }

        [When(@"User opens Self Service with invalid ID '(.*)'")]
        public void WhenUserOpensSelfServiceWithInvalidId(string sSIvalidId)
        {
            _driver.WaitForDataLoading();
            var url = $"{UrlProvider.EvergreenUrl}#/admin/selfservice/{sSIvalidId}/details";
            _driver.Navigate().GoToUrl(url);
        }

        [Then(@"Self Service Details page is displayed correctly")]
        public void ThenSelfServiceDetailsPageIsDisplayedCorrectly()
        {
            var autocompleteElement = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(autocompleteElement.IsTextboxDisplayed("Self Service Name"),
                "Self Service Details page is not displayed correctly");
            Verify.IsTrue(autocompleteElement.IsTextboxDisplayed("Self Service Identifier"),
                "Self Service Details page is not displayed correctly");
            _driver.WaitForElementToHaveText(autocompleteElement.GetTextbox("Self Service Scope"));
            //For the stability of the Self Service's tests
            Thread.Sleep(6000);
        }

        [Then(@"Self Service URL preview that contains '(.*)' base URL and '(.*)' Self Service identifier displays")]
        public void ThenSelfServiceURLPreviewContains(string baseSelfServiceUrl, string selfServiceIdentifier)
        {
            var SelfServiceDetailsPage = _driver.NowAt<SelfServiceDetailsPage>();
            Verify.IsTrue(SelfServiceDetailsPage.SelfServiceUrlPreview(baseSelfServiceUrl, selfServiceIdentifier).Displayed(),
                "Expected Self Service URL wasn't displayed");
        }
    }
}