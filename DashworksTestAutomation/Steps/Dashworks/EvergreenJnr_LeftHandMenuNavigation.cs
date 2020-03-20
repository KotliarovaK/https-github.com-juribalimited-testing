using System;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_LeftHandMenuNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_LeftHandMenuNavigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        #region Navigation

        [When(@"User clicks '(.*)' on the left-hand menu")]
        public void WhenUserClicksOnTheLeft_HandMenu(string listPage)
        {
            NavigateToLeftHandMenu(listPage, true);
        }

        [When(@"User quickly navigate to '(.*)' on the left-hand menu")]
        public void WhenUserQuicklyNavigateToOnTheLeft_HandMenu(string listPage)
        {
            NavigateToLeftHandMenu(listPage, false);
        }

        private void NavigateToLeftHandMenu(string menuItemName, bool waitForDataLoading)
        {
            var menu = waitForDataLoading ?
                _driver.NowAt<LeftHandMenuElement>() :
                _driver.NowAtWithoutWait<LeftHandMenuElement>();

            var menuItem = menu.GetMenuElementByName(menuItemName);
            _driver.WaitForElementToBeDisplayed(menuItem);
            menuItem.Click();
        }

        #endregion

        #region Menu Item display

        [Then(@"'(.*)' list should be displayed to the user")]
        public void ThenListShouldBeDisplayedToTheUser(string listPage)
        {
            var header = _driver.NowAt<BaseHeaderElement>();

            switch (listPage)
            {
                case "Admin":
                    header.CheckPageHeader("Projects");
                    break;

                default:
                    header.CheckPageHeader(listPage);
                    break;
            }
        }

        #endregion

        #region Highlight

        [Then(@"'(.*)' left-hand menu is highlighted")]
        public void ThenLeft_HandMenuIsHighlighted(string menuName)
        {
            var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();
            Verify.AreEqual(menu.GetMenuElementByName(menuName).GetCssValue("color"),
                "rgba(242, 88, 49, 1)", $"Incorrect color for highlighted '{menuName}' left menu");
        }

        #endregion

        #region Hidded menu

        [Then(@"'(.*)' left-hand menu item is hidden")]
        public void ThenLeft_HandMenuItemIsHidden(string menuItem)
        {
            var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();
            Verify.IsFalse(menu.IsMenuExpanded(), "Left-hand menu is expanded");
            Verify.IsFalse(menu.GetMenuElementByName(menuItem).Displayed(),
                $"'{menuItem}' left-hand menu item is displayed");
        }

        [When(@"User clicks '(.*)' hidden left-hand menu")]
        public void WhenUserClicksHiddenLeft_HandMenu(string menuItem)
        {
            var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();
            _driver.ClickByJavascript(menu.GetMenuElementByName(menuItem));
        }

        #endregion

        #region Footer and version

        [Then(@"'(.*)' Application version is displayed in the left-hand menu")]
        public void ThenApplicationVersionIsDisplayed(string versionNumber)
        {
            var page = _driver.NowAt<LeftHandMenuElement>();
            page.GetApplicationVersionElement(versionNumber);
        }

        #endregion
    }
}