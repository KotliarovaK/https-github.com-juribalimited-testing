using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_Pivot : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_Pivot(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to Pivot")]
        public void WhenUserNavigatesToPivot()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.CreateActionButton);
            page.CreateActionButton.Click();
            page.GetCreateButtonByName("Pivot").Click();
        }

        [When(@"User adds the following Row Groups:")]
        public void WhenUserAddsTheFollowingRowGroups(Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetButtonByNameOnPivot("ADD ROW GROUP").Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["RowGroups"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }

        [When(@"User adds the following Columns:")]
        public void WhenUserAddsTheFollowingColumns(Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetButtonByNameOnPivot("ADD COLUMN").Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["Columns"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }

        [When(@"User adds the following Values:")]
        public void WhenUserAddsTheFollowingValues(Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetButtonByNameOnPivot("ADD VALUE").Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["Values"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }

        [When(@"User clicks ""(.*)"" button in Pivot panel")]
        public void WhenUserClicksButtonInPivotPanel(string buttonLabel)
        {
            var page = _driver.NowAt<PivotElementPage>();

            page.GetButtonByNameOnPivot(buttonLabel).Click();
        }

        [When(@"User clicks Close Add Item icon in Pivot panel")]
        public void WhenUserClicksCloseAddItemIconInPivotPanel()
        {
            var page = _driver.NowAt<PivotElementPage>();

            page.CloseAddItemIcon.Click();
        }

        [Then(@"User sees ""(.*)"" category in Pivot panel")]
        public void ThenUserSeesCategoryInPivotPanel(string categoryName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var allCategories = page.PivotCategories.Select(x => x.Text).ToList();

            Assert.That(allCategories, Does.Contain(categoryName));
        }

        [When(@"User creates Pivot list with ""(.*)"" name")]
        public void WhenUserCreatesPivotListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            Assert.IsTrue(listElement.CreateNewListButton.Displayed(), "'Save' button is mot displayed");
            listElement.CreateNewListButton.Click();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(listElement.SaveButton.Displayed(), "'Save' button is not displayed");
            var page = _driver.NowAt<PivotElementPage>();
            page.PivotNameTextBox.SendKeys(listName);
            listElement.SaveButton.Click();

            //Small wait for message display
            Thread.Sleep(300);
            _driver.WaitWhileControlIsDisplayed<CustomListElement>(() => listElement.SuccessCreateMessage);
        }

        [Then(@"Pivot run was completed")]
        public void ThenPivotRunWasCompleted()
        {
            _driver.WaitForDataLoading();
            var page = _driver.NowAt<PivotElementPage>();
            Assert.IsFalse(page.NoPivotTableMessage.Displayed(), "Pivot run was failed");
        }
    }
}
