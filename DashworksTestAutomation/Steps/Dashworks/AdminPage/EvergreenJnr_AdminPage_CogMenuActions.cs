﻿using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_CogMenuActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_CogMenuActions (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Cog-menu on the Admin page")]
        public void WhenUserClicksCog_MenuOnTheAdminPage()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            cogMenu.CogMenu.Click();
        }

        [When(@"User clicks Cog-menu for ""(.*)"" item on Admin page")]
        public void WhenUserClicksCog_MenuForItemOnAdminPage(string itemName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.MouseHover(cogMenu.GetCogMenuByItem(itemName));
            cogMenu.GetCogMenuByItem(itemName).Click();
        }

        [Then(@"Cog menu is not displayed on the Admin page")]
        public void ThenCogMenuIsNotDisplayedOnTheAdminPage()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            Assert.IsFalse(cogMenu.CogMenu.Displayed(), "Cog menu is displayed");
        }

        [Then(@"User sees following cog-menu items on Admin page:")]
        public void ThenUserSeesFollowingCog_MenuItemsOnAdminPage(Table items)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            for (var i = 0; i < items.RowCount; i++)
                Assert.That(page.CogMenuItems[i].Text, Is.EqualTo(items.Rows[i].Values.FirstOrDefault()),
                    "Items are not the same");
        }

        [When(@"User clicks ""(.*)"" option in Cog-menu for ""(.*)"" item on Admin page")]
        public void WhenUserClicksOptionInCog_MenuForItemOnAdminPage(string option, string itemName)
        {
            var body = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            body.BodyContainer.Click();
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.MouseHover(cogMenu.GetCogMenuByItem(itemName));
            cogMenu.GetCogMenuByItem(itemName).Click();
            _driver.WaitWhileControlIsNotDisplayed<CogMenuElements>(() => cogMenu.CogMenuDropdown);
            cogMenu.GetCogmenuOptionByName(option).Click();
            Thread.Sleep(1000);
        }

        [When(@"User move ""(.*)"" item to ""(.*)"" position on Admin page")]
        public void WhenUserMoveItemToPositionOnAdminPage(string itemName, string position)
        {
            var body = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            body.BodyContainer.Click();
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.MouseHover(cogMenu.GetCogMenuByItem(itemName));
            cogMenu.GetCogMenuByItem(itemName).Click();
            Thread.Sleep(500);
            cogMenu.GetCogmenuOptionByName("Move to position").Click();
            cogMenu.MoveToPositionField.Clear();
            cogMenu.MoveToPositionField.SendKeys(position);
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetActionsButtonByName("MOVE").Click();
        }

        [Then(@"Cog-menu DDL is displayed in High Contrast mode")]
        public void ThenCog_MenuDDLIsDisplayedInHighContrastMode()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();

            _driver.WaitForDataLoading();
            cogMenu.CogMenu.Click();
            Assert.AreEqual("rgba(21, 40, 69, 1)", cogMenu.GetCogMenuDropdownColor());
            Assert.AreEqual("rgba(0, 0, 0, 0)", cogMenu.GetCogMenuDropdownLabelColor());
        }

        [Then(@"""(.*)"" item is not displayed in the grid on Admin page")]
        public void ThenItemIsNotDisplayedInTheGridOnAdminPage(string itenName)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();

            Assert.IsFalse(cogMenu.CheckItemDisplay(itenName), "Status display is incorrect");
        }
    }
}