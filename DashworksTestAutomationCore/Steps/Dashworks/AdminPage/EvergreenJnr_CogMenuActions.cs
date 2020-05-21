using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

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

        [When(@"User clicks Cog-menu for '(.*)' item in the '(.*)' column and sees following cog-menu options")]
        public void WhenUserClicksCog_MenuForItemInTheColumnAndSeesFollowingCogMenuOptions(string columnContent, string column, Table options)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.ClickByJavascript(cogMenu.BodyContainer);
            var cogMenuElement = cogMenu.GetCogMenuByItem(column, columnContent);
            _driver.MouseHover(cogMenuElement);
            cogMenu.GetCogMenuByItem(column, columnContent).Click();

            List<String> expectedCogMenuOptions = options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()).ToList();
            List<String> cogMenuOptions = cogMenu.CogMenuItems.Select(x => x.GetText()).ToList();

            Verify.AreEqual(cogMenuOptions, expectedCogMenuOptions,
                            "Items are not the same");
        }

        [When(@"User clicks '(.*)' option in Cog-menu for '(.*)' item from '(.*)' column")]
        public void WhenUserClicksOptionInCog_MenuForItemFromColumn(string option, string columnContent, string column)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            //Close cog-menu if it is still opened from previous step
            if (cogMenu.CogMenuItems.Any(x => x.Displayed()))
            {
                _driver.ClickByJavascript(cogMenu.BodyContainer);
            }
            var cogMenuElement = cogMenu.GetCogMenuByItem(column, columnContent);
            _driver.MouseHover(cogMenuElement);
            cogMenuElement.Click();
            cogMenu.GetCogMenuOptionByName(option).Click();

            //Grid should be refreshed after making active/inactive
            if (option.Equals("Make active") || option.Equals("Make inactive"))
            {
                _driver.WaitForElementToBeNotDisplayed(cogMenuElement);
            }

            //For automation
            if (option.Equals("Run now"))
            {
                _automationStartTime.Value = DateTime.Now.AddSeconds(-10);
            }
        }

        [When(@"User clicks '(.*)' option in cogmenu for '(.*)' list")]
        public void WhenUserClicksOptionInCog_MenuForList(string option, string listName)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            //Close cog-menu if it is still opened from previous step
            if (cogMenu.CogMenuItems.Any(x => x.Displayed()))
            {
                _driver.ClickByJavascript(cogMenu.BodyContainer);
            }

            var leftPanel = _driver.NowAt<CustomListElement>();
            var itemCogMenu = leftPanel.GetSettingsIconForList(listName);

            _driver.MouseHover(itemCogMenu);
            itemCogMenu.Click();
            cogMenu.GetCogMenuOptionByName(option).Click();
        }

        [When(@"User clicks cogmenu for '(.*)' list and sees following cog-menu options")]
        public void WhenUserClicksCogMenuForListAndSeesFollowingCogMenuOptions(string listName, Table options)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.ClickByJavascript(cogMenu.BodyContainer);

            var leftPanel = _driver.NowAt<CustomListElement>();
            var itemCogMenu = leftPanel.GetSettingsIconForList(listName);

            _driver.MouseHover(itemCogMenu);
            itemCogMenu.Click();

            List<String> expectedCogMenuOptions = options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()).ToList();
            List<String> cogMenuOptions = cogMenu.CogMenuItems.Select(x => x.GetText()).ToList();

            Verify.AreEqual(cogMenuOptions, expectedCogMenuOptions,
                "Items are not the same");
        }

        [When(@"User moves '(.*)' item from '(.*)' column to the '(.*)' position")]
        public void WhenUserMovesItemFromColumnToThePosition(string columnContent, string column, string position)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.ClickByJavascript(cogMenu.BodyContainer);
            _driver.MouseHover(cogMenu.GetCogMenuByItem(column, columnContent));
            cogMenu.GetCogMenuByItem(column, columnContent).Click();
            _driver.WaitForDataLoading();
            cogMenu.GetCogMenuOptionByName("Move to position").Click();
            cogMenu.MoveToPositionField.Clear();
            cogMenu.MoveToPositionField.SendKeys(position);
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetButton("MOVE").Click();
        }

        [Then(@"Cog menu is not displayed on the Admin page")]
        public void ThenCogMenuIsNotDisplayedOnTheAdminPage()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            Verify.IsFalse(cogMenu.CogMenu.Displayed(), "Cog menu is displayed");
        }

        [When(@"User clicks '(.*)' option in opened Cog-menu")]
        public void WhenUserClicksOptionInOpenedCogMenu(string option)
        {
            ClickOnCogMenuOption(option);
        }

        [Then(@"Cog-menu DDL is displayed in High Contrast mode")]
        public void ThenCog_MenuDDLIsDisplayedInHighContrastMode()
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();

            _driver.WaitForDataLoading();
            cogMenu.CogMenu.Click();
            Verify.AreEqual("rgba(21, 40, 69, 1)", cogMenu.GetCogMenuDropdownColor(), "PLEASE ADD EXCEPTION MESSAGE");
            Verify.AreEqual("rgba(0, 0, 0, 0)", cogMenu.GetCogMenuDropdownLabelColor(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        public void ClickOnCogMenuOption(string option)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }
    }
}