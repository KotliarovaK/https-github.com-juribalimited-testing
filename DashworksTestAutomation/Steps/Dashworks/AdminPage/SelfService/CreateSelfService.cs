using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios;
using DashworksTestAutomation.Utils;
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

        public CreateSelfService(RemoteWebDriver driver, SelfServices selfServices, RestWebClient client)
        {
            _driver = driver;
            _selfServices = selfServices;
            _selfServiceApiMethods = new SelfServiceApiMethods(selfServices, client);
        }

        [When(@"User creates Self Service via API and open it")]
        public void WhenUserCreatesSelfServiceViaAPIAndOpenIt(Table table)
        {
            var exception = string.Empty;
            _selfServices.Value.AddRange(_selfServiceApiMethods.CreateSelfService(table, out exception).Value);
            if (!string.IsNullOrEmpty(exception))
            {
                throw new Exception(exception);
            }

            var lastSs = _selfServices.Value.Last();

            _driver.WaitForDataLoading();
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/selfservice/{lastSs.ServiceId}/details");

            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(lastSs.Name);
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