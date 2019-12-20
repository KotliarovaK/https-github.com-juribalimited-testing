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

        //Can be used for parent and for sub menu.
        //Please avoid usage and replace by more specific methods
        [When(@"User navigates to the '(.*)' left menu item")]
        public void WhenUserNavigatesToTheLeftMenuItem(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetLeftMenuByName(tabMenuName).Click());
        }

        [When(@"User navigates to the '(.*)' parent left menu item")]
        public void WhenUserNavigatesToTheParentLeftMenuItem(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetParentMenuByName(tabMenuName).Click());
        }

        [When(@"User navigates to the '(.*)' left submenu item")]
        public void WhenUserNavigatesToTheParentLeftSubmenuItem(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetSubMenuByName(tabMenuName).Click());
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

        [Then(@"'(.*)' left menu item is collapsed")]
        public void ThenLeftMenuItemIsCollapsed(string section)
        {
            var page = _driver.NowAt<BaseNavigationElements>();
            Verify.IsFalse(page.IsMenuExpanded(section),
                $"'{section}' section is expanded");
        }

        #endregion

        [Then(@"'(.*)' left menu have following submenu items:")]
        public void ThenLeftMenuHaveFollowingSubmenuItems(string parent, Table table)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = element.GetSubMenuItems(parent).Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList,
                $"Incorrect submenu items for '{parent}' parent left menu");
        }
    }
}
