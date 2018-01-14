using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ButtonsOnDashbordsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ButtonsOnDashbordsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks the Actions button")]
        public void WhenUserClicksTheActionsButton()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.ActionsButton);
            menu.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [When(@"User clicks the List Details button")]
        public void WhenUserClicksTheListDetailsButton()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.ListDetailsButton);
            menu.ListDetailsButton.Click();
            Logger.Write("List Details button was clicked");
        }

        [When(@"User clicks the Columns button")]
        public void WhenUserClicksTheColumnsButton()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.ColumnButton);
            menu.ColumnButton.Click();
            Logger.Write("Column button was clicked");
        }

        [When(@"User clicks the Filters button")]
        public void WhenUserClicksTheFiltersButton()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.FilterButton);
            menu.FilterButton.Click();
            Logger.Write("Filters button was clicked");
        }

        [Then(@"Filters Button is disabled")]
        public void ThenFiltersButtonIsDisabled()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.FilterButton);
            Assert.IsTrue(Convert.ToBoolean(menu.FilterButton.GetAttribute("disabled")), "Filter Button is active");
        }

        [Then(@"List details button is disabled")]
        public void ThenListDetailsButtonIsDisabled()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.ListDetailsButton);
            Assert.IsTrue(Convert.ToBoolean(menu.ListDetailsButton.GetAttribute("disabled")), "List Details Button is active");
        }

        [Then(@"Actions button is active")]
        public void ThenActionsButtonIsActive()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.ListDetailsButton);
            StringAssert.Contains("active", menu.ActionsButton.GetAttribute("class"));
        }

        [Then(@"Actions button is not active")]
        public void ThenActionsButtonIsNotActive()
        {
            var menu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => menu.ListDetailsButton);
            Assert.IsFalse(menu.ActionsButton.GetAttribute("class").Contains("active"));
        }
    }
}