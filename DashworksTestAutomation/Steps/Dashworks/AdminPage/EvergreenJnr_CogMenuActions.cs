using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_CogMenuActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly RunNowAutomationStartTime _automationStartTime;

        public EvergreenJnr_CogMenuActions(RemoteWebDriver driver, RunNowAutomationStartTime automationStartTime)
        {
            _driver = driver;
            _automationStartTime = automationStartTime;
        }

        [When(@"User clicks Cog-menu for '(.*)' item in the '(.*)' column")]
        public void WhenUserClicksCog_MenuForItemInTheColumn(string columnContent, string column)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            cogMenu.BodyContainer.Click();
            _driver.MouseHover(cogMenu.GetCogMenuByItem(column, columnContent));
            cogMenu.GetCogMenuByItem(column, columnContent).Click();
        }

        [When(@"User moves '(.*)' item from '(.*)' column to the '(.*)' position")]
        public void WhenUserMovesItemFromColumnToThePosition(string columnContent, string column, string position)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            cogMenu.BodyContainer.Click();
            _driver.MouseHover(cogMenu.GetCogMenuByItem(column, columnContent));
            cogMenu.GetCogMenuByItem(column, columnContent).Click();
            _driver.WaitForDataLoading();
            cogMenu.GetCogMenuOptionByName("Move to position").Click();
            cogMenu.MoveToPositionField.Clear();
            cogMenu.MoveToPositionField.SendKeys(position);
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetButtonByName("MOVE").Click();
        }

        [When(@"User clicks Cog-menu on the Admin page")]
        public void WhenUserClicksCog_MenuOnTheAdminPage()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            cogMenu.CogMenu.Click();
        }

        [Then(@"Cog menu is displayed to the user")]
        public void ThenCogMenuIsDisplayedToTheUser()
        {
            var listElement = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(listElement.CogMenuList);
            Utils.Verify.IsTrue(listElement.CogMenuList.Displayed(), "Cog menu is not displayed");
        }

        [Then(@"Cog menu is not displayed on the Admin page")]
        public void ThenCogMenuIsNotDisplayedOnTheAdminPage()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            Utils.Verify.IsFalse(cogMenu.CogMenu.Displayed(), "Cog menu is displayed");
        }

        [Then(@"User sees following cog-menu items on Admin page:")]
        public void ThenUserSeesFollowingCog_MenuItemsOnAdminPage(Table items)
        {
            var page = _driver.NowAt<CogMenuElements>();
            for (var i = 0; i < items.RowCount; i++)
                Utils.Verify.That(page.CogMenuItems[i].Text, Is.EqualTo(items.Rows[i].Values.FirstOrDefault()),
                    "Items are not the same");
        }

        //TODO make it generic
        [When(@"User clicks ""(.*)"" option in Cog-menu for ""(.*)"" item on Admin page")]
        public void WhenUserClicksOptionInCog_MenuForItemOnAdminPage(string option, string itemName)
        {
            var body = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            body.BodyContainer.Click();
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.MouseHover(cogMenu.GetCogMenuByItem(itemName));
            cogMenu.GetCogMenuByItem(itemName).Click();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();

            //TODO Remove this. Just for debug
            if (itemName.Equals("15431_Third_Active"))
            {
                try
                {
                    var test = DatabaseHelper.GetAutomationActiveStatus(itemName);
                    Logger.Write($"Automation active status is '{test}'");
                }
                catch
                {
                    Logger.Write("Automation was not found in the database");
                }
            }

            //For automation
            if (option.Equals("Run now"))
            {
                _automationStartTime.Value = DateTime.Now.AddSeconds(-10);
            }
        }

        [When(@"User clicks '(.*)' option in opened Cog-menu")]
        public void WhenUserClicksOptionInOpenedCogMenu(string option)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks ""(.*)"" option in Cog-menu for ""(.*)"" item on Admin page and wait for processing")]
        public void WhenUserClicksOptionInCog_MenuForItemOnAdminPageAndWaitsProcessing(string option, string itemName)
        {
            WhenUserClicksOptionInCog_MenuForItemOnAdminPage(option, itemName);

            for (int i = 0; i < 3; i++)
            {
                if (DatabaseHelper.IsAutomationRunFinishedSuccess(DatabaseHelper.GetAutomationId(itemName)))
                {
                    break;
                }
                Thread.Sleep(5000);
            }
        }

        [Then(@"Cog-menu DDL is displayed in High Contrast mode")]
        public void ThenCog_MenuDDLIsDisplayedInHighContrastMode()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();

            _driver.WaitForDataLoading();
            cogMenu.CogMenu.Click();
            Utils.Verify.AreEqual("rgba(21, 40, 69, 1)", cogMenu.GetCogMenuDropdownColor(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.AreEqual("rgba(0, 0, 0, 0)", cogMenu.GetCogMenuDropdownLabelColor(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" item is not displayed in the grid on Admin page")]
        public void ThenItemIsNotDisplayedInTheGridOnAdminPage(string itenName)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();

            Utils.Verify.IsFalse(cogMenu.CheckItemDisplay(itenName), "Status display is incorrect");
        }
    }
}