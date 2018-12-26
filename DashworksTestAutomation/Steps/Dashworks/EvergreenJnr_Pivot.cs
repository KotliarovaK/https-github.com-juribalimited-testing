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

        [When(@"User selects the following Row Groups on Pivot:")]
        public void WhenUserSelectsTheFollowingRowGroupsOnPivot(Table table)
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

        [When(@"User selects the following Columns on Pivot:")]
        public void WhenUserSelectsTheFollowingColumnsOnPivot(Table table)
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

        [When(@"User selects the following Values on Pivot:")]
        public void WhenUserSelectsTheFollowingValuesOnPivot(Table table)
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

        [When(@"User adds the following ""(.*)"" on Pivot:")]
        public void WhenUserAddsTheFollowingOnPivot(string button, Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetPlusButtonOnPivotByName(button).Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["Value"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }

        [When(@"User removes ""(.*)"" Column for Pivot")]
        [When(@"User removes ""(.*)"" Row Group for Pivot")]
        public void WhenUserRemovesRowGroupForPivot(string closeButtonName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetCloseButtonForElementsByNameOnPivot(closeButtonName).Click();
        }

        [When(@"User removes ""(.*)"" Value for Pivot")]
        public void WhenUserRemoveValueForPivot(string closeButtonName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetCloseButtonForValueElementsByNameOnPivot(closeButtonName).Click();
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

        [Then(@"reset button on main panel is displayed")]
        public void ThenResetButtonOnMainPanelIsDisplayed()
        {
            var page = _driver.NowAt<PivotElementPage>();
            Assert.IsTrue(page.ResetPivotButton.Displayed(), "Reset button on main panel is not displayed");
        }

        [When(@"User clicks reset button on main panel")]
        public void WhenUserClicksResetButtonOnMainPanel()
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.ResetPivotButton.Click();
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

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SavePivotButton);
            listElement.SavePivotButton.Click();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            Assert.IsTrue(listElement.CreateNewListButton.Displayed(), "'Save' button is not displayed");
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

        [Then(@"No pivot generated message is displayed")]
        public void ThenNoPivotGeneratedMessageIsDisplayed()
        {
            _driver.WaitForDataLoading();
            var page = _driver.NowAt<PivotElementPage>();
            Assert.IsTrue(page.NoPivotTableMessage.Displayed(), "'No pivot generated' is not displayed");
        }

        [Then(@"Save button is inactive for Pivot list")]
        public void ThenSaveButtonIsInactiveForPivotList()
        {
            var page = _driver.NowAt<PivotElementPage>();
            var state = page.SaveButton.GetAttribute("disabled");
            Assert.AreEqual("true", state, "Save button is active");
        }

        [Then(@"Pivot Name field is empty")]
        public void ThenPivotNameFieldIsEmpty()
        {
            var page = _driver.NowAt<PivotElementPage>();
            Assert.IsEmpty(page.PivotNameTextBox.GetAttribute("value"), "Pivot Name field is not empty");
        }

        #region Tooltip on Pivot

        [Then(@"""(.*)"" plus button have tooltip with ""(.*)"" text")]
        public void ThenPlusButtonHaveTooltipWithText(string buttonName, string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var button = page.GetPlusButtonOnPivotByName(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Assert.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [Then(@"close button for ""(.*)"" chip have tooltip with ""(.*)"" text")]
        public void ThenCloseButtonForChipHaveTooltipWithText(string chipName, string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var element = page.GetCloseButtonForElementsByNameOnPivot(chipName);
            _driver.MouseHover(element);
            var toolTipText = _driver.GetTooltipText();
            Assert.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [Then(@"""(.*)"" chip have tooltip with ""(.*)"" text")]
        public void ThenChipHaveTooltipWithText(string chipName, string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var element = page.GetChipByNameOnPivot(chipName);
            _driver.MouseHover(element);
            var toolTipText = _driver.GetTooltipText();
            Assert.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [Then(@"back button on Pivot panel have tooltip with ""(.*)"" text")]
        public void ThenBackButtonOnPivotPanelHaveTooltipWithText(string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            _driver.MouseHover(page.BackButtonOnPivotPanel);
            var toolTipText = _driver.GetTooltipText();
            Assert.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        #endregion

        [When(@"""(.*)"" value is entered into the search box and the selection is clicked on Pivot")]
        public void WhenValueIsEnteredIntoTheSearchBoxAndTheSelectionIsClickedOnPivot(string value)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            //Clear the textbox after adding a column, so it is reset for the next loop
            columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            columnElement.AddColumn(value);
        }
    }
}
