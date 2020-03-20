using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Logger = DashworksTestAutomation.Utils.Logger;

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

        [When(@"User clicks the Pivot button")]
        public void WhenUserClicksTheFiltersButton()
        {
            var menu = _driver.NowAt<PivotElementPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(menu.PivotButton);
            menu.PivotButton.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Pivot panel is displayed to the user")]
        public void ThenColumnsPanelIsDisplayedToTheUser()
        {
            var pivotElement = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(pivotElement.PivotPanel.Displayed(), "Pivot panel is not displayed");
            Logger.Write("Pivot panel is visible");
        }

        [Then(@"Pivot panel is not displayed to the user")]
        public void ThenPivotPanelIsNotDisplayedToTheUser()
        {
            var rightSideActionsPanel = _driver.NowAt<BaseRightSideActionsPanel>();
            Verify.IsFalse(rightSideActionsPanel.IsPanelOpened("Pivot"), "Pivot panel is displayed");
        }

        [When(@"User closes the Pivot panel")]
        public void WhenUserClosesThePivotPanel()
        {
            var pivotPage = _driver.NowAt<PivotElementPage>();
            pivotPage.ClosePivotPanelButton.Click();
        }

        [Then(@"""(.*)"" panel is displayed to the user")]
        public void ThenPanelIsDisplayedToTheUser(string panelName)
        {
            var pivotElement = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(pivotElement.GetPanelByName(panelName).Displayed(), $"{panelName} panel is not displayed");
            Logger.Write($"{panelName} panel is visible");
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

        [When(@"User adds the ""(.*)"" category on Pivot")]
        public void WhenUserAddsTheCategoryOnPivot(string categoryName)
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            columnElement.GetSubCategoryOnPivotByName(categoryName);
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
            Verify.IsTrue(page.ResetPivotButton.Displayed(), "Reset button on main panel is not displayed");
        }

        [Then(@"reset button on main panel is not displayed")]
        public void ThenResetButtonOnMainPanelIsNotDisplayed()
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsFalse(page.ResetPivotButton.Displayed(), "Reset button on main panel is displayed");
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

            Verify.That(allCategories, Does.Contain(categoryName));
        }

        [When(@"User creates Pivot list with ""(.*)"" name")]
        public void WhenUserCreatesPivotListWithName(string listName)
        {
            var page = _driver.NowAt<PivotElementPage>();

            _driver.WaitForElementToBeDisplayed(page.SaveButton);
            page.SaveButton.Click();

            _driver.WaitForElementToBeDisplayed(page.SaveNewListButton);
            Verify.IsTrue(page.SaveNewListButton.Displayed(), "'Save' button is not displayed");
            _driver.MouseHover(page.SaveNewListButton);
            page.SaveNewListButton.Click();

            _driver.WaitForElementToBeDisplayed(page.SaveButton);
            Verify.IsTrue(page.SaveButton.Displayed(), "'Save' button is not displayed");

            page.PivotNameTextBox.Clear();
            page.PivotNameTextBox.SendKeys(listName);
            page.SaveButton.Click();

            //Small wait for message display
            //Thread.Sleep(300);
            //var listElement = _driver.NowAt<CustomListElement>();
            //_driver.WaitWhileControlIsDisplayedObsolete<CustomListElement>(() => listElement.SuccessCreateMessage);
            //Verify.IsTrue(listElement.SuccessCreateMessage.Displayed(), "Success message is not displayed");
        }

        [When(@"User updates existing pivot")]
        public void WhenUserUpdatesExistingPivot()
        {
            var page = _driver.NowAt<PivotElementPage>();

            _driver.WaitForElementToBeDisplayed(page.SaveButton);
            page.SaveButton.Click();

            _driver.WaitForElementToBeDisplayed(page.UpdateListButton);
            Verify.IsTrue(page.UpdateListButton.Displayed(), "'update' button is not displayed");
            _driver.MouseHover(page.UpdateListButton);
            page.UpdateListButton.Click();

            _driver.WaitForElementToBeDisplayed(page.SaveButton);
            Verify.IsTrue(page.SaveButton.Displayed(), "'Save' button is not displayed");
        }

        [Then(@"Pivot run was completed")]
        public void ThenPivotRunWasCompleted()
        {
            var page = _driver.NowAt<PivotElementPage>();
            //Small wait for Pivot loaded
            Thread.Sleep(500);
            _driver.WaitForDataLoading(50);
            Verify.IsFalse(page.NoPivotTableMessage.Displayed(), "Pivot run was failed");
        }

        [Then(@"Plus button is not displayed in the left-pinned column")]
        public void ThenPlusButtonIsNotDisplayedInTheLeft_PinnedColumn()
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsFalse(page.PlusButton.Displayed(), "Plus button is not displayed in the left-pinned column");
        }

        [Then(@"No pivot generated message is displayed")]
        public void ThenNoPivotGeneratedMessageIsDisplayed()
        {
            _driver.WaitForDataLoading();
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(page.NoPivotTableMessage.Displayed(), "'No pivot generated' is not displayed");
        }

        [Then(@"Save button is inactive for Pivot list")]
        public void ThenSaveButtonIsInactiveForPivotList()
        {
            var page = _driver.NowAt<PivotElementPage>();
            var state = page.SaveButton.GetAttribute("disabled");
            Verify.AreEqual("true", state, "Save button is active");
        }

        [Then(@"Save button is active for Pivot list")]
        public void ThenSaveButtonIsActiveForPivotList()
        {
            var page = _driver.NowAt<PivotElementPage>();
            var state = page.SaveButton.GetAttribute("disabled");
            Verify.AreEqual("false", state, "Save button is not active");
        }

        [Then(@"Pivot Name field is empty")]
        public void ThenPivotNameFieldIsEmpty()
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsEmpty(page.PivotNameTextBox.GetAttribute("value"), "Pivot Name field is not empty");
        }

        [When(@"User selects aggregate function ""(.*)"" on Pivot")]
        public void WhenUserSelectsAggregateFunctionOnPivot(string functionName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.AggregateFunctionsSelectBox.Click();
            page.SelectAggregateFunctionByName(functionName).Click();
        }

        [Then(@"following aggregate function are available in dropdown:")]
        public void ThenFollowingAggregateFunctionAreAvailableInDropdown(Table table)
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            pivot.AggregateFunction.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = pivot.AggregateOptionsOnPivotPanel.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList, "Aggregate function in drop-down are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"""(.*)"" is displayed in the columns for aggregate functions")]
        public void ThenIsDisplayedInTheColumnsForAggregateFunctions(string text)
        {
            _driver.WaitForDataLoading();
            var pivot = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(pivot.GetColumnsDisplayedForAggregateFunctions(text).Displayed(), $"{text} is not displayed in the columns for aggregate functions");
        }

        [Then(@"""(.*)"" is displayed at the top left corner on Pivot")]
        public void ThenIsDisplayedAtTheTopLeftCornerOnPivot(string text)
        {
            _driver.WaitForDataLoading();
            var pivot = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(pivot.GetTopLeftCornerText(text).Displayed(), $"{text} is not displayed at the top left corner");
        }

        [When(@"User clicks Plus button for ""(.*)"" Pivot value")]
        public void WhenUserClicksPlusButtonForPivotValue(string buttonName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetPlusButtonOnPivotByName(buttonName).Click();
        }

        #region Tooltip on Pivot

        [Then(@"""(.*)"" plus button have tooltip with ""(.*)"" text")]
        public void ThenPlusButtonHaveTooltipWithText(string buttonName, string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var button = page.GetPlusButtonOnPivotByName(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [Then(@"close button for ""(.*)"" chip have tooltip with ""(.*)"" text")]
        public void ThenCloseButtonForChipHaveTooltipWithText(string chipName, string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var element = page.GetCloseButtonForElementsByNameOnPivot(chipName);
            _driver.MouseHover(element);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [Then(@"""(.*)"" chip have tooltip with ""(.*)"" text")]
        public void ThenChipHaveTooltipWithText(string chipName, string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            var element = page.GetChipByNameOnPivot(chipName);
            _driver.MouseHover(element);
            string toolTipText = null;
            try
            {
                toolTipText = _driver.GetTooltipText();
            }
            catch
            {
                toolTipText = String.Empty;
            }
            Verify.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [Then(@"back button on Pivot panel have tooltip with ""(.*)"" text")]
        public void ThenBackButtonOnPivotPanelHaveTooltipWithText(string text)
        {
            var page = _driver.NowAt<PivotElementPage>();
            _driver.MouseHover(page.BackButtonOnPivotPanel);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        #endregion

        #region Chips

        [Then(@"""(.*)"" chip for Row Groups is not displayed")]
        [Then(@"""(.*)"" chip for Columns is not displayed")]
        public void ThenChipIsNotDisplayed(string chipName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsFalse(page.GetChipNameOnPivot(chipName), $"'{chipName}' chip is displayed");
        }

        [Then(@"""(.*)"" chip for Value is not displayed")]
        public void ThenChipForValueIsNotDisplayed(string chipName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsFalse(page.GetChipValueNameOnPivot(chipName), $"'{chipName}' chip is displayed");
        }

        [Then(@"""(.*)"" chip for Row Groups is displayed")]
        [Then(@"""(.*)"" chip for Columns is displayed")]
        public void ThenChipIsDisplayed(string chipName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(page.GetChipNameOnPivot(chipName), $"'{chipName}' chip is not displayed");
        }

        [Then(@"""(.*)"" chip for Value is displayed")]
        public void ThenChipForValueIsDisplayed(string chipName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(page.GetChipValueNameOnPivot(chipName), $"'{chipName}' chip is not displayed");
        }

        [When(@"User clicks close button for ""(.*)"" chip")]
        public void WhenUserClicksCloseButtonForChip(string chipName)
        {
            var page = _driver.NowAt<PivotElementPage>();
            if (page.GetCloseButtonForValueElementsByNameOnPivot(chipName).Displayed())
                page.GetCloseButtonForValueElementsByNameOnPivot(chipName).Click();
            else
                page.GetCloseButtonForElementsByNameOnPivot(chipName).Click();
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

        [Then(@"Empty value is displayed on the first place for the Pivot")]
        public void ThenEmptyValueIsDisplayedOnTheFirstPlaceForThePivot()
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(columnElement.FirstEmptyValueLeftPinned);
            Verify.IsTrue(columnElement.FirstEmptyValueLeftPinned.Displayed(), "Empty value is not displayed on the first place");
        }

        [Then(@"Empty value is not displayed on the first place for the Pivot")]
        public void ThenEmptyValueIsNotDisplayedOnTheFirstPlaceForThePivot()
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            Verify.IsFalse(columnElement.FirstEmptyValueLeftPinned.Displayed(), "Empty value is displayed on the first place");
        }

        [Then(@"Empty value is displayed on the first place for the Pivot column header")]
        public void ThenEmptyValueIsDisplayedOnTheFirstPlaceForThePivotColumnHeader()
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            Verify.IsTrue(columnElement.FirstEmptyValueHeaders.Displayed(), "Empty value is not displayed on the first place for column header");
        }

        [Then(@"Pivot column headers is displayed in following order:")]
        public void ThenPivotColumnHeadersIsDisplayedInFollowingOrder(Table table)
        {
            var columnElement = _driver.NowAt<PivotElementPage>();

            var columnNames = columnElement.GetPivotHeadersContentToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Verify.AreEqual(expectedList, columnNames, "Columns order on Pivot page is incorrect");
        }

        [Then(@"Pivot left-pinned column content is displayed in following order:")]
        public void ThenPivotLeft_PinnedColumnContentIsDisplayedInFollowingOrder(Table table)
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            _driver.WaitForDataLoading();
            var columnNames = columnElement.GetLeftPinnedColumnContentToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Verify.AreEqual(expectedList, columnNames, "Columns order on Pivot page is incorrect");
        }

        [When(@"User expanded ""(.*)"" left-pinned value on Pivot")]
        public void WhenUserExpandedLeft_PinnedValueOnPivot(string value)
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            columnElement.GetLeftPinnedExpandButtonByName(value).Click();
        }

        [Then(@"following values are displayed for ""(.*)"" column on Pivot")]
        public void ThenFollowingValuesAreDisplayedForColumnOnPivot(string columnName, Table table)
        {
            var columnElement = _driver.NowAt<PivotElementPage>();
            var leftPinnedContentList = columnElement.GetLeftPinnedColumnContentOnPivot().Select(column => column.Text).ToList();
            var columnContentList = columnElement.GetColumnContentOnPivotByName(columnName).Select(column => column.Text).ToList();
            foreach (var row in table.Rows)
            {
                for (var i = 0; i < columnElement.GetLeftPinnedColumnContentOnPivot().Count; i++)
                    if (leftPinnedContentList[i].Equals(row["Value1"]))
                    {
                        Verify.AreEqual(columnContentList[i], row["Value2"], "PLEASE ADD EXCEPTION MESSAGE");
                    }
            }
        }

        #region Sort order on Pivot

        [Then(@"numeric data in table is sorted by ""(.*)"" column in ascending order for the Pivot")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrderForThePivot(string columnName)
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var actualList = pivot.GetPivotColumnContent().Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
        }

        [Then(@"numeric data in table is sorted by ""(.*)"" column in descending order for the Pivot")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrderForThePivot(string columnName)
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var expectedList = pivot.GetPivotColumnContent().Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
        }

        [Then(@"data in the table is sorted by ""(.*)"" column in ascending order by default for the Pivot")]
        public void ThenDataInTheTableIsSortedByColumnInAscendingOrderByDefaultForThePivot(string columnName)
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var expectedList = pivot.GetPivotColumnContent().Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList);
        }

        [Then(@"data in the table is sorted by ""(.*)"" column in descending order by default for the Pivot")]
        public void ThenDataInTheTableIsSortedByColumnInDescendingOrderByDefaultForThePivot(string p0)
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var expectedList = pivot.GetPivotColumnContent().Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
        }

        [Then(@"color data in the column headers is sorted in correct order for the Pivot")]
        public void ThenColorDataInTheColumnHeadersIsSortedInCorrectOrderForThePivot()
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var colorItem = pivot.GetHeadersPivotBackgroundColor();
            var expectedList = new List<string>();
            foreach (var color in colorItem)
            {
                expectedList.Add(pivot.GetPivotNumberByColor(color));
            }
            SortingHelper.IsNumericListSorted(expectedList);
        }

        [Then(@"color data in the left-pinned column is sorted in descending order for the Pivot")]
        public void ThenColorDataInTheLeft_PinnedColumnIsSortedInDescendingOrderForThePivot()
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var colorItem = pivot.GetLeftPinnedPivotColorColumnContent();
            var expectedList = new List<string>();
            foreach (var color in colorItem)
            {
                expectedList.Add(pivot.GetPivotNumberByColor(color));
            }
            SortingHelper.IsNumericListSorted(expectedList);
        }

        [Then(@"color data in the left-pinned column is sorted in ascending order for the Pivot")]
        public void ThenColorDataInTheLeft_PinnedColumnIsSortedInAscendingOrderForThePivot()
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var colorItem = pivot.GetLeftPinnedPivotColorColumnContent();
            var expectedList = new List<string>();
            foreach (var color in colorItem)
            {
                expectedList.Add(pivot.GetPivotNumberByColor(color));
            }
            SortingHelper.IsNumericListSorted(expectedList);
        }

        [Then(@"data in the column headers is sorted in correct order for the Pivot")]
        public void ThenDataInTheColumnHeadersIsSortedInCorrectOrderForThePivot()
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var expectedList = pivot.GetPivotHeadersContentToList().Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList);
        }

        [Then(@"date in the column headers is sorted in correct order for the Pivot")]
        public void ThenDateInTheColumnHeadersIsSortedInCorrectOrderForThePivot()
        {
            var pivot = _driver.NowAt<PivotElementPage>();
            var expectedList = pivot.GetPivotHeadersContentToList().Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(expectedList, false);
        }

        #endregion

    }
}