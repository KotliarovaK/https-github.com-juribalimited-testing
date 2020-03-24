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
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class BaseSelfServiceEndUser : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        public BaseSelfServiceEndUser(RemoteWebDriver driver)
        {
            _driver = driver;
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
