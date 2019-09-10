using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Scope;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using RestSharp.Extensions;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.Scope
{
    [Binding]
    public class ScopeChangesSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly AddedObjects _addedObjects;
        private readonly LastUsedBucket _lastUsedBucket;

        public ScopeChangesSteps(RemoteWebDriver driver, AddedObjects addedObjects, LastUsedBucket lastUsedBucket)
        {
            _driver = driver;
            _addedObjects = addedObjects;
            _lastUsedBucket = lastUsedBucket;
        }

        [When(@"User navigates to the '(.*)' tab on Scope Changes page")]
        public void WhenUserNavigatesToTheTabOnScopeChangesPage(string tabName)
        {
            var page = _driver.NowAt<ScopeChangePage>();
            _driver.ExecuteAction(() => page.GetTabByName(tabName).Click());
            _driver.WaitForDataLoading();
        }

        [Then(@"following objects were not found")]
        public void ThenFollowingObjectsWereNotFound(Table table)
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            projectElement.PlusButton.Click();
            var basePage = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                var search = basePage.GetNamedTextbox("Search");
                search.Clear();
                search.SendKeys(row["Objects"]);
                Verify.IsTrue(projectElement.CheckedAllItemCheckbox.Displayed(), "Some object is present");
                search.ClearWithHomeButton(_driver);
            }
        }

        [When(@"User expands the object to add")]
        public void WhenUserExpandsTheObjectToAdd()
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            _driver.WaitForElementToBeDisplayed(projectElement.PlusButton);
            _driver.WaitForElementToBeEnabled(projectElement.PlusButton);
            projectElement.PlusButton.Click();
        }

        [When(@"User expands the object to remove on ""(.*)"" tab")]
        public void WhenUserExpandsTheObjectToRemoveOnTab(string tabName)
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            try
            {
                projectElement.PlusButton.Click();
            }
            catch (Exception)
            {
                Thread.Sleep(5000);
                _driver.Navigate().Refresh();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                projectElement.PlusButton.Click();
            }
        }

        [When(@"User waits and expands the ""(.*)"" panel to remove")]
        public void WhenUserWaitsAndExpandsThePanelToRemove(string tabName)
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            try
            {
                projectElement.PlusButton.Click();
            }
            catch (Exception)
            {
                Thread.Sleep(30000);
                _driver.Navigate().Refresh();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                projectElement.PlusButton.Click();
            }
        }

        //TODO Should be moved to buckets
        [When(@"User adds following Objects from list")]
        public void ThenUserAddFollowingObjectsFromList(Table table)
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                var text = row["Objects"];
                var search = basePage.GetNamedTextbox("Search");
                search.Clear();
                search.SendKeys(text);
                basePage.AddItem(text);
                search.ClearWithHomeButton(_driver);
                //Save added objects to remove it from the bucket
                _addedObjects.Value.Add(text, _lastUsedBucket.Value);
            }
            basePage.GetActionsButtonByName("ADD BUCKETS").Click();
        }

        [When(@"User adds following Objects to the Project")]
        public void WhenUserAddsFollowingObjectsToTheProject(Table table)
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            projectElement.PlusButton.Click();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                var search = basePage.GetNamedTextbox("Search");
                basePage.AddItem(row["Objects"]);
                search.ClearWithHomeButton(_driver);
            }
        }

        [When(@"User adds following Objects to the Project on ""(.*)"" tab")]
        public void WhenUserAddsFollowingObjectsToTheProjectOnTab(string tabName, Table table)
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            try
            {
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                projectElement.PlusButton.Click();
                foreach (var row in table.Rows)
                {
                    var search = basePage.GetNamedTextbox("Search");
                    basePage.AddItem(row["Objects"]);
                    search.ClearWithHomeButton(_driver);
                }
            }
            catch (Exception)
            {
                Thread.Sleep(30000);
                _driver.Navigate().Refresh();
                _driver.WaitForDataLoading();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                projectElement = _driver.NowAt<ScopeChangePage>();
                _driver.WaitForElementToBeDisplayed(projectElement.PlusButton);
                projectElement.PlusButton.Click();
                foreach (var row in table.Rows)
                {
                    var search = basePage.GetNamedTextbox("Search");
                    basePage.AddItem(row["Objects"]);
                    search.ClearWithHomeButton(_driver);
                }
            }

            basePage.ClickButtonByName("UPDATE ALL CHANGES");
        }

        [When(@"User selects following Objects to the Project")]
        public void WhenUserSelectsFollowingObjectsToTheProject(Table table)
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            projectElement.PlusButton.Click();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                var search = basePage.GetNamedTextbox("Search");
                search.Clear();
                search.SendKeys(row["Objects"]);
                basePage.AddItem(row["Objects"]);
                search.ClearWithHomeButton(_driver);
            }
        }

        [Then(@"following items are still selected")]
        public void ThenFollowingItemsAreStillSelected()
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            Verify.IsTrue(projectElement.PlusButton.Displayed(), "Items are not selected");
            Verify.IsTrue(projectElement.CheckedSomeItemCheckbox.Displayed(), "Item checkbox is not checked");
        }

        [Then(@"no items are selected")]
        public void ThenNoItemsAreSelected()
        {
            var projectElement = _driver.NowAt<ScopeChangePage>();
            Verify.IsFalse(projectElement.CheckedAllItemCheckbox.Displayed(), "Some Item is selected");
        }
    }
}
