using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using DashworksTestAutomation.Providers;
using TechTalk.SpecFlow;
using DashworksTestAutomation.Helpers;
using TechTalk.SpecFlow.Assist;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class BaseSelfServiceEndUser : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly SelfServices _selfServices;
        private readonly ComponentsOfSelfServicePageDto _componentsOfSelfServicePageDto;
        //private readonly SelfServicePages = _selfServicePages;

        public BaseSelfServiceEndUser(RemoteWebDriver driver, SelfServices selfServices, ComponentsOfSelfServicePageDto componentsOfSelfServicePageDto)
        {
            _driver = driver;
            _selfServices = selfServices;
            _componentsOfSelfServicePageDto = componentsOfSelfServicePageDto;
            //_selfServicePages = ;
        }

        [When(@"User navigates to End User firs page with '(.*)' Self Service Identifier")]
        public void WhenUserNavigatesToEndUserFirsPageOfSelfService(string selfServiceIdentifier)
        {
            var selfService = _selfServices.Value.First(x => x.ServiceIdentifier.Equals(selfServiceIdentifier));
            int componentId = _componentsOfSelfServicePageDto.ComponentId;

            string ssGuid = DatabaseHelper.GetSelfServiceObjectGuid(selfServiceIdentifier, componentId);

            string navigationUrl = $"{UrlProvider.EvergreenUrl}#/selfservice/{selfServiceIdentifier}?ObjectId={ssGuid}";
            _driver.NavigateToUrl(navigationUrl);
        }

        [Then(@"Self Service Tools Panel displayed for end client")]
        public void ThenSelfServiceToolsPanelDisplayedForEndClient()
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            Verify.IsTrue(page.SelfServiceToolsPanel.Displayed, "Self Service Tools Panel is missing");
        }

        [When(@"User clicks on '(.*)' button on end-user Self Service page")]
        public void WhenUserClicksOnButtonOnEndUserSelfServicePage(string buttonName)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var button = page.GetButtonOnEndUserPage(buttonName);
            _driver.WaitForElementToBeEnabled(button);
            button.Click();
            _driver.WaitForDataLoading(50);
        }

        [Then(@"'(.*)' button is displayed for End User")]
        public void ThenButtonIsDisplayedForEndUser(string buttonTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var button = page.GetButtonOnEndUserPage(buttonTitle);

            Verify.IsTrue(button.Displayed, $"'{buttonTitle}' button was not displayed for End User");
        }

        [Then(@"'(.*)' button is not displayed for End User")]
        public void ThenButtonIsNotDisplayedForEndUser(string buttonTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var button = page.GetButtonOnEndUserPage(buttonTitle);

            Verify.IsFalse(button.Displayed, $"'{buttonTitle}' button was displayed for End User");
        }

        [Then(@"Header is displayed on End User page")]
        public void ThenHeaderIsDisplayedOnEndUserPage()
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsTrue(page.Header.Displayed, $"Header button was not displayed for End User");
        }

        [Then(@"Subject Title '(.*)' is displayed on End User page")]
        public void ThenSubjectTitleIsDisplayedOnEndUserPage(string subjTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsTrue(page.SubjectTitleOnEndUserPage(subjTitle).Displayed, $"Header button was not displayed for End User");
        }
    }
}
