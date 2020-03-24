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
        public BaseSelfServiceEndUser(RemoteWebDriver driver, SelfServices selfServices)
        {
            _driver = driver;
            _selfServices = selfServices;
        }

        [When(@"User navigates to End User firs page of '(.*)' Self Service")]
        public void WhenUserNavigatesToEndUserFirsPageOfSelfService(string selfServiceIdentifier)
        {
            var selfService = _selfServices.Value.First(x => x.ServiceIdentifier.Equals(selfServiceIdentifier));
            int listId = selfService.ScopeId;
            string ssGuid = DatabaseHelper.GetSelfServiceObjectGuid(selfServiceIdentifier, listId);

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
    }
}
