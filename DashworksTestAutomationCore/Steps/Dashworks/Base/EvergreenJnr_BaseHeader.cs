using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    //ONLY actions with BaseHeaderElement !!!
    [Binding]
    class EvergreenJnr_BaseHeader : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseHeader(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks '(.*)' header breadcrumb")]
        public void WhenUserClicksHeaderBreadcrumb(string breadcrumb)
        {
            var header = _driver.NowAt<BaseHeaderElement>();
            header.ClickBreadcrumb(breadcrumb);
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
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);
            menu.FilterButton.Click();
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

        [When(@"User clicks the Pages button")]
        public void WhenUserClicksThePagesButton()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(menu.PagesButton);
            menu.PagesButton.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Page with '(.*)' header is displayed to user")]
        public void ThenPageWithHeaderIsDisplayedToUser(string pageTitle)
        {
            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(pageTitle);
        }

        [Then(@"Filters Button is disabled")]
        public void ThenFiltersButtonIsDisabled()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);            
            Verify.IsTrue(menu.FilterButton.Disabled(), "Filter Button is active");
        }

        [Then(@"Associations Button is highlighted")]
        public void ThenAssociationsButtonIsHighlighted()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.AssociationButton);
            Verify.IsTrue(menu.AssociationButton.IsElementActive(), "Association Button is not highlighted");
        }

        [Then(@"Pages Button is highlighted")]
        public void ThenPagesButtonIsHighlighted()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.PagesButton);
            Verify.IsTrue(menu.PagesButton.IsElementActive(), "Pages Button is not highlighted");
        }

        [Then(@"Pages Button is not highlighted")]
        public void ThenPagesButtonIsNotHighlighted()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            _driver.WaitForElementToBeDisplayed(menu.PagesButton);
            Verify.IsFalse(menu.PagesButton.IsElementActive(), "Pages Button is highlighted");
        }

        [Then(@"List details button is disabled")]
        public void ThenListDetailsButtonIsDisabled()
        {
            var menu = _driver.NowAt<BaseHeaderElement>();
            //Waiting for changed List details button state
            Thread.Sleep(500);
            _driver.WaitForElementToBeDisplayed(menu.ListDetailsButton);
            Verify.IsFalse(menu.ListDetailsButton.Disabled(), "List Details Button is active");
        }
    }
}
