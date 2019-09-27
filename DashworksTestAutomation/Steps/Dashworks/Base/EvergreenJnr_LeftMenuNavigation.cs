using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    class EvergreenJnr_LeftMenuNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_LeftMenuNavigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        #region Menu naviagtion

        [When(@"User navigates to the '(.*)' left menu item")]
        public void WhenUserNavigatesToTheLeftMenuItem(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetLeftMenuByName(tabMenuName).Click());
        }

        #endregion

        [Then(@"'(.*)' page should be displayed to the user")]
        public void ThenPageShouldBeDisplayedToTheUser(string pageTitle)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(_driver.IsElementDisplayed(page.Header, WebDriverExtensions.WaitTime.Short), $"'{pageTitle}' page was not opened");
            Verify.AreEqual(pageTitle, page.Header.Text, "Incorrect page header");
        }
    }
}
