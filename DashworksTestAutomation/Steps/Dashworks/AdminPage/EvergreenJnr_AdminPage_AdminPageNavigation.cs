using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_AdminPageNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_AdminPageNavigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks ""(.*)"" navigation link on the Admin page")]
        public void WhenUserClicksNavigationLinkOnTheAdminPage(string linkName)
        {
            var link = _driver.NowAt<ProjectsPage>();
            link.GetNavigationLinkByName(linkName).Click();
        }

        [When(@"User open ""(.*)"" sub menu on Admin page")]
        public void WhenUserOpenSubMenuOnAdminPage(string menuName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.GetSubMenuByName(menuName).Click();
            _driver.WaitForDataLoading();
        }

        //TODO should be removed
        [When(@"User selects ""(.*)"" tab on the Project details page")]
        public void WhenUserSelectTabOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            projectTabs.NavigateToProjectTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" tab is selected on the Admin page")]
        public void ThenTabIsSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Utils.Verify.IsTrue(projectTabs.GetsSelectedTabByName(tabName).Displayed(), "Selected tab is not active");
        }

        [Then(@"""(.*)"" tab in Project selected on the Admin page")]
        public void ThenTabInProjectSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Utils.Verify.IsTrue(projectTabs.GetsSelectedTabInProjectByName(tabName).Displayed(), $"'{tabName}' tab is not active");
        }

        [When(@"User selects ""(.*)"" tab on the Capacity Units page")]
        public void WhenUserSelectsTabOnTheCapacityUnitsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.GetTabByNameOnCapacityUnits(tabName).Click();
        }

        [Then(@"""(.*)"" tab is not displayed to the User on Admin Page Navigation")]
        public void ThenTabIsNotDisplayedToTheUserOnAdminPageNavigation(string tabName)
        {
            var page = _driver.NowAt<AdminLeftHandMenu>();
            Utils.Verify.IsFalse(page.Automations.Displayed(), $"{tabName} tab still displayed");
        }
    }
}