using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Scope;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.Scope
{
    [Binding]
    public class ScopeChangesSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ScopeChangesSteps(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to the '(.*)' tab on Project Scope Changes page")]
        public void WhenUserNavigatesToTheTabOnProjectScopeChangesPage(string tabName)
        {
            var page = _driver.NowAt<ScopeChangePage>();
            _driver.ExecuteAction(() => page.GetTabByName(tabName).Click());
            _driver.WaitForDataLoading(40);
        }

        [Then(@"'(.*)' tab is displayed on Project Scope Changes page")]
        public void ThenTabIsDisplayedOnProjectScopeChangesPage(string tabName)
        {
            var page = _driver.NowAt<ScopeChangePage>();
            Verify.IsTrue(page.IsTabDisplayed(tabName),$"'{tabName}' tab was not displayed");
        }

        [Then(@"following objects were not found")]
        public void ThenFollowingObjectsWereNotFound(Table table)
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            basePage.ExpandCollapseMultiselectButton("").Click();

            var projectElement = _driver.NowAt<ScopeChangePage>();
            foreach (var row in table.Rows)
            {
                var search = basePage.GetTextbox("Search");
                search.Clear();
                search.SendKeys(row["Objects"]);
                Verify.IsTrue(projectElement.CheckedAllItemCheckbox.Displayed(), "Some object is present");
                search.ClearWithHomeButton(_driver);
            }
        }

        //TODO MB replace by WhenUserExpandsMultiselectToTheTabOnProjectScopeChangesPageAndSelectsFollowingObjects
        [When(@"User expands the object to remove on ""(.*)"" tab")]
        public void WhenUserExpandsTheObjectToRemoveOnTab(string tabName)
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            try
            {
                basePage.ExpandCollapseMultiselectButton("").Click();
            }
            catch (Exception)
            {
                Thread.Sleep(5000);
                _driver.Navigate().Refresh();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                basePage.ExpandCollapseMultiselectButton("").Click();
            }
        }

        [When(@"User waits and expands the ""(.*)"" panel to remove")]
        public void WhenUserWaitsAndExpandsThePanelToRemove(string tabName)
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            try
            {
                basePage.ExpandCollapseMultiselectButton("").Click();
            }
            catch (Exception)
            {
                Thread.Sleep(30000);
                _driver.Navigate().Refresh();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                basePage.ExpandCollapseMultiselectButton("").Click();
            }
        }

        [Then(@"following items are still selected")]
        public void ThenFollowingItemsAreStillSelected()
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(basePage.CollapseMultiselectButton("").Displayed(), "Items are not selected");
            Verify.IsTrue(projectElement.CheckedSomeItemCheckbox.Displayed(), "Item checkbox is not checked");
        }

        [Then(@"no items are selected")]
        public void ThenNoItemsAreSelected()
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            Verify.IsFalse(projectElement.CheckedAllItemCheckbox.Displayed(), "Some Item is selected");
        }

        [When(@"User expands '(.*)' multiselect to the '(.*)' tab on Project Scope Changes page and selects following Objects")]
        public void WhenUserExpandsMultiselectToTheTabOnProjectScopeChangesPageAndSelectsFollowingObjects(string multiselectTitle, string tabName, Table table)
        {
            var itemsToAdd = table.Rows.Select(x => x["Objects"]).ToList();
            var basePage = _driver.NowAt<BaseDashboardPage>();

            for (int i = 0; i < 15; i++)
            {
                try
                {
                    basePage.ExpandCollapseMultiselectButton(multiselectTitle).Click();
                    break;
                }
                catch
                {
                    Thread.Sleep(2000);
                   _driver.Navigate().Refresh();
                   _driver.WaitForDataLoading();
                   WhenUserNavigatesToTheTabOnProjectScopeChangesPage(tabName);
                }
            }

            basePage.AddItemsToMultiSelect(itemsToAdd);
        }
    }
}