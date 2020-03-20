using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService
{
    [Binding]
    class SelfServiceAgGrid : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public SelfServiceAgGrid(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User sees AgGrid")]
        public void ThenUserSeesAgGrid()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.AgGrid);
            Verify.IsTrue(_driver.IsElementDisplayed(page.AgGrid),
                "AgGrid doesn't displayed to the user");
        }
    }
}