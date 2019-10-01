using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
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

            menu.GetMenuElementByName(menuItemName).Click();
        }

        #endregion

        #region Menu Item display

        [Then(@"'(.*)' list should be displayed to the user")]
        public void ThenListShouldBeDisplayedToTheUser(string listPage)
        {
            switch (listPage)
            {
                case "All Devices":
                case "All Users":
                case "All Applications":
                case "All Mailboxes":
                    var list = _driver.NowAt<BaseDashboardPage>();
                    _driver.WaitForElementToBeDisplayed(list.Header);
                    Verify.AreEqual(listPage.ToLower(), list.Header.Text.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Admin":
                    var adminPage = _driver.NowAt<BaseDashboardPage>();
                    _driver.WaitForElementToBeDisplayed(adminPage.Header);
                    Verify.AreEqual("projects", adminPage.Header.Text.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                default:
                    throw new Exception($"'{listPage}' menu item is not valid ");
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
    }
}