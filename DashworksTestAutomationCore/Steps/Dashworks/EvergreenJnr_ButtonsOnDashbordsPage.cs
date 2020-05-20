using System;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ButtonsOnDashbordsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ButtonsOnDashbordsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Create Project button is disabled on the Base Dashboard Page")]
        public void ThenCreateProjectButtonIsDisabledOnTheBaseDashboardPage()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(button.CreateProjectButton);
            button.DisabledCreateProjectButton.Displayed();
        }

        [Then(@"Create button is disabled on the Base Dashboard Page")]
        public void ThenCreateButtonIsDisabledOnTheBaseDashboardPage()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(button.CreateActionButton);
            Verify.IsTrue(Convert.ToBoolean(button.CreateActionButton.GetAttribute("aria-disabled")), "Filter Button is active!");
        }

        [Then(@"Create button is not displayed")]
        public void ThenCreateButtonIsNotDisplayed()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(button.CreateActionButton.Displayed(),
                "Create button is displayed on the Base Dashboard Page");
        }

        [Then(@"Create button is displayed")]
        public void ThenCreateButtonIsDisplayed()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(button.CreateActionButton.Displayed(),
                "Create button is not displayed on the Base Dashboard Page");
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for Create Project button")]
        public void ThenTooltipIsDisplayedWithTextForCreateProjectButton(string text)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            _driver.MouseHover(button.CreateProjectButton);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
        }      

        [Then(@"Empty link is displayed for first row in the ""(.*)"" column")]
        public void ThenEmptyLinkIsDisplayedForFirstRowInTheColumn(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.AreEqual("Empty", page.GetColumnContentByColumnName(columnName).First(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Account Profile menu is displayed correctly")]
        public void ThenAccountProfileMenuIsDisplayedCorrectly()
        {
            var panel = _driver.NowAt<BaseHeaderElement>();
            var menu = _driver.NowAt<HeaderElement>();
            try
            {
                panel.ColumnButton.Click();
            }
            catch
            {
                Verify.IsTrue(menu.UserItemsMenu.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
            }

            Verify.IsTrue(menu.UserItemsMenu.Displayed, "Item Menu is not displayed correctly");
        }

        [Then(@"Notifications message is displayed correctly")]
        public void ThenNotificationsMessageIsDisplayedCorrectly()
        {
            var panel = _driver.NowAt<BaseHeaderElement>();
            var menu = _driver.NowAt<HeaderElement>();
            try
            {
                panel.ColumnButton.Click();
            }
            catch
            {
                Verify.IsTrue(menu.UserNotificationsMessage.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
            }

            Verify.IsTrue(menu.UserNotificationsMessage.Displayed,
                "User Notifications Message is not displayed correctly");
        }

        [Then(@"Filter Expression icon displayed within Filter Panel")]
        public void ThenFilterExpressionIconDisplayedWithinCorrectBlock()
        {
            var filterPane = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(filterPane.FilterButton);

            var panel = _driver.NowAt<FiltersElement>();
            Verify.That(panel.FilterExpressionIcon.Displayed(), "Filter expression icon placed in wrong block");
        }

        [When(@"User clicks Filter Expression icon in Filter Panel")]
        public void UserClicksFilterExpressionIconInFilterPanel()
        {
            var filterPane = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(filterPane.FilterButton);
            var panel = _driver.NowAt<FiltersElement>();
            panel.FilterExpressionIcon.Click();
        }

        [Then(@"Filter Expression displayed within Filter Panel")]
        public void ThenFilterExpressionDisplayedWithinCorrectBlock()
        {
            var filterPane = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(filterPane.FilterButton);

            var panel = _driver.NowAt<BaseDashboardPage>();
            Verify.That(panel.FiltersExpression.Displayed(), "Filter expression placed in wrong block");
        }
    }
}