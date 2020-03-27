using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;


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

            //TODO remove this workaround when related bug will be fixed
            if (tabMenuName.Equals("Builder"))
            {
                try
                {
                    var bpage = _driver.NowAt<BaseDialogPage>();
                    bpage.ClickButton("YES");
                }
                catch { }
            }
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

        #region Display

        [Then(@"User sees following parent left menu items")]
        public void ThenUserSeesFollowingParentLeftMenuItems(Table table)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            List<string> actualList = new List<string>();
            try
            {
                actualList = detailsPage.GetParentMenuByName().Select(value => value.Text).ToList();
            }
            catch (StaleElementReferenceException e)
            {
                Logger.Write($"StaleElementReferenceException during retrieving of parent menu items: {e}");
                actualList = detailsPage.GetParentMenuByName().Select(value => value.Text).ToList();
            }
            Verify.AreEqual(expectedList, actualList, "Tabs for the details page are incorrect");
        }

        [Then(@"'(.*)' left menu have following submenu items:")]
        public void ThenLeftMenuHaveFollowingSubmenuItems(string parent, Table table)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = element.GetSubMenuItems(parent).Select(value => value.Text.Split(" (").First()).ToList();
            Verify.AreEqual(expectedList, actualList,
                $"Incorrect submenu items for '{parent}' parent left menu");
        }

        [Then(@"'(.*)' left submenu item is displayed")]
        public void ThenLeftSubmenuItemIsDisplayed(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(element.IsSubmenuDisplayed(submenu), $"'{submenu}' submenu was not displayed");
        }

        [Then(@"'(.*)' left submenu item with some count is displayed")]
        public void ThenLeftSubmenuItemWithSomeCountIsDisplayed(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(element.IsSubmenuCountIsDisplayed(submenu), $"'{submenu}' submenu doesn't contains items count");
        }

        [Then(@"'(.*)' left submenu item is displayed without count")]
        public void ThenLeftSubmenuItemIsDisplayedWithoutCount(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsFalse(element.IsSubmenuCountIsDisplayed(submenu), $"'{submenu}' submenu contains items count");
        }

        [Then(@"'(.*)' left submenu item with '(.*)' count is displayed")]
        public void ThenLeftSubmenuItemWithCountIsDisplayed(string submenu, int count)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            //Try to check content several times because it is updating not immediately
            if (!count.Equals(element.SubmenuItemsCount(submenu)))
            {
                //JS update count every 3 seconds
                Thread.Sleep(3000);
            }
            Verify.AreEqual(count, element.SubmenuItemsCount(submenu), $"'{submenu}' submenu items count is incorrect");
        }

        #endregion

        #region Disabled/Enabled

        [Then(@"'(.*)' left submenu item is disabled")]
        public void ThenLeftSubmenuItemIsDisabled(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(element.IsSubmenuDisabled(submenu), $"'{submenu}' submenu is not disabled");
        }

        [Then(@"'(.*)' left menu item is disabled")]
        public void ThenLeftMenuItemIsDisabled(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(element.IsParentMenuDisabled(submenu), $"'{submenu}' menu is not disabled");
        }

        #endregion

        #region Active

        [Then(@"'(.*)' left submenu item is active")]
        public void ThenLeftSubmenuItemIsActive(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(element.IsSubmenuActive(submenu), $"'{submenu}' submenu is not active");
        }

        [Then(@"'(.*)' left submenu item is not active")]
        public void ThenLeftSubmenuItemIsNotActive(string submenu)
        {
            var element = _driver.NowAt<BaseNavigationElements>();
            Verify.IsFalse(element.IsSubmenuActive(submenu), $"'{submenu}' submenu is active");
        }

        #endregion
    }
}
