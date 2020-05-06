using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
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

        [When(@"User clicks the Actions button")]
        public void WhenUserClicksTheActionsButton()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.TableBody);
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.ActionsButton);
            menu.ActionsButton.Click();
        }

        [When(@"User clicks the List Details button")]
        public void WhenUserClicksTheListDetailsButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.ListDetailsButton);
            menu.ListDetailsButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks the Dashboard Details button")]
        public void WhenUserClicksTheDashboardDetailsButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.DashboardsDetailsButton);
            menu.DashboardsDetailsButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks the Permissions button")]
        public void WhenUserClicksThePermissionsButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.PermissionsButton);
            menu.PermissionsButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks the Dashboard Permissions button")]
        public void WhenUserClicksTheDashboardPermissionsButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.DashboardPermissionsButton);
            menu.DashboardPermissionsButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks the Columns button")]
        public void WhenUserClicksTheColumnsButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.ColumnButton);
            menu.ColumnButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks the Filters button")]
        public void WhenUserClicksTheFiltersButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            //TODO remove this. Just to check ports issue
            Thread.Sleep(1300);
            _driver.WaitForDataLoadingInActionsPanel();
            //TODO remove this. Just to check ports issue
            Thread.Sleep(1300);
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);
            //TODO remove this. Just to check ports issue
            Thread.Sleep(1300);
            menu.FilterButton.Click();
            //TODO remove this. Just to check ports issue
            Thread.Sleep(1300);
            _driver.WaitForDataLoading();
        }
        
        [When(@"User clicks the Associations button")]
        public void WhenUserClicksTheAssociationButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.AssociationButton);
            menu.AssociationButton.Click();
            _driver.WaitForDataLoading();
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

        [Then(@"Filters Button is disabled")]
        public void ThenFiltersButtonIsDisabled()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);
            Verify.IsTrue(Convert.ToBoolean(menu.FilterButton.GetAttribute("disabled")), "Filter Button is active");
        }

        [Then(@"Associations Button is highlighted")]
        public void ThenAssociationsButtonIsEnabled()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.AssociationButton);
            Verify.IsTrue(Convert.ToBoolean(menu.AssociationButton.GetAttribute("class").Contains("active")), "Association Button is inactive");
        }

        [Then(@"Filter button on AGgrid is disabled")]
        public void ThenFilterButtonOnAGgridIsDisabled()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);
            Verify.IsTrue(Convert.ToBoolean(menu.FilterButton.GetAttribute("disabled")),
                "Filter button on AGgrid is active");
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

        [Then(@"List details button is disabled")]
        public void ThenListDetailsButtonIsDisabled()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            //Waiting for changed List details button state
            Thread.Sleep(500);
            _driver.WaitForElementToBeDisplayed(menu.ListDetailsButton);
            Verify.IsTrue(Convert.ToBoolean(menu.ListDetailsButton.GetAttribute("disabled")),
                "List Details Button is active");
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