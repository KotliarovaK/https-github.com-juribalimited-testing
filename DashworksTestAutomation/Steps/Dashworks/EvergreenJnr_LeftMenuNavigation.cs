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
    internal class EvergreenJnr_LeftMenuNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_LeftMenuNavigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

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

        [Then(@"'(.*)' left-hand menu is highlighted")]
        public void ThenLeft_HandMenuIsHighlighted(string menuName)
        {
            var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();
            Verify.AreEqual(menu.GetMenuElementByName(menuName).GetCssValue("color"),
                "rgba(242, 88, 49, 1)", $"Incorrect color for highlighted '{menuName}' left menu");
        }

        //TODO Looks like needs to be removed as not relevant anymore
        [Then(@"Admin menu item is hidden")]
        public void ThenAdminMenuItemIsHidden()
        {
            throw new Exception("Yurii please check TODO. Refer Vitalii");
            //var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();
            //Verify.IsFalse(menu.Admin.Displayed(), "Admin menu item is displayed");
        }

        //TODO Looks like needs to be removed as not relevant anymore
        [When(@"User clicks ""(.*)"" hidden left-hand menu")]
        public void WhenUserClicksHiddenLeft_HandMenu(string menuName)
        {
            throw new Exception("Yurii please check TODO. Refer Vitalii");
            //var menu = _driver.NowAtWithoutWait<BaseDashboardPage>();
            //menu.SelectHiddenLeftHandMenu(menuName).Click();
        }
    }
}