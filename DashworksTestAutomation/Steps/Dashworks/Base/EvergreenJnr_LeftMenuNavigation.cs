using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
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

        [When(
@"User navigates to the '(.*)' left menu item")]
        public void WhenUserNavigatesToTheLeftMenuItem(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetLeftMenuByName(tabMenuName).Click());
        }

        #endregion

        #region Expanded/Collapsed state

        [Then(@"'(.*)' left menu item is expanded")]
        public void ThenLeftMenuItemIsExpanded(string section)
        {
            var page = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(page.IsMenuExpanded(section),
                $"'{section}' section is collapsed");
        }

        #endregion

        //TODO subheader should be moved to separate web element
        #region Subheader

        [Then(@"Page with '(.*)' subheader is displayed to user")]
        public void ThenPageWithSubheaderIsDisplayedToUser(string subHeader)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(_driver.IsElementDisplayed(page.SubHeader, WebDriverExtensions.WaitTime.Short), $"Page with '{subHeader}' is not displayed");
            Verify.AreEqual(subHeader, page.SubHeader.Text, "Incorrect page header");
        }

        #endregion
    }
}
