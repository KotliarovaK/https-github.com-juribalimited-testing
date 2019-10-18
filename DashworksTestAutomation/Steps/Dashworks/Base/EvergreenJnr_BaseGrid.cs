using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    //ONLY actions with BaseGridPage !!!
    [Binding]
    class EvergreenJnr_BaseGrid : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseGrid(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        #region Select content

        [When(@"User deselect all rows on the grid")]
        public void WhenUserDeselectAllRowsOnTheGrid()
        {
            SelectUnselectAllRows(false);
        }

        [When(@"User selects all rows on the grid")]
        public void WhenUserSelectsAllRowsOnTheGrid()
        {
            SelectUnselectAllRows(true);
        }

        [Then(@"checkboxes are not displayed for content in the grid")]
        public void ThenCheckboxesAreNotDisplayedForContentInTheGrid()
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(dashboardPage.Checkboxes.All(x => !x.Displayed()),
                "Checkboxes in the grid are displayed");
            Verify.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(),
                "'Select all rows' checkbox is displayed");
        }

        [Then(@"select all rows checkbox is checked")]
        public void ThenSelectAllRowsCheckboxIsChecked()
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(_driver.GetEvergreenCheckboxState(dashboardPage.SelectAllCheckbox),
                "'Select all rows' checkbox is unchecked");
        }

        [Then(@"select all rows checkbox is unchecked")]
        public void ThenSelectAllRowsCheckboxIsUnchecked()
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            _driver.WhatForElementToBeSelected(dashboardPage.SelectAllCheckbox, false);
            Verify.IsTrue(_driver.GetEvergreenCheckboxState(dashboardPage.SelectAllCheckbox),
                "'Select all rows' checkbox is checked");
        }

        [Then(@"all checkboxes are checked in the grid")]
        public void ThenAllCheckboxesAreCheckedInTheGrid()
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            //Wait for All checkboxes are checked
            Thread.Sleep(1000);
            Verify.IsTrue(dashboardPage.Checkboxes.All(x => x.GetGridCheckboxSelectedState()),
                "Not all checkboxes are checked in the grid");
        }

        private void SelectUnselectAllRows(bool expectedCondition)
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            _driver.SetEvergreenCheckboxState(dashboardPage.SelectAllCheckbox, expectedCondition);
            _driver.WhatForElementToBeSelected(dashboardPage.SelectAllCheckbox, expectedCondition);
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
        }

        #endregion

        #region Export

        [Then(@"Export button is displayed in panel")]
        public void ThenExportButtonIsDisplayed()
        {
            var pivot = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(pivot.ExportListButton.Displayed(), "Export button is not displayed");
        }

        [Then(@"Export button is displayed disabled")]
        public void ThenExportButtonIsDisplayedDisabled()
        {
            var pivot = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(pivot.ExportListButton);
            Utils.Verify.That(pivot.ExportListButton.Disabled(), Is.True, "Export button is displayed enabled");
        }

        #endregion

        #region Archived Devices

        [When(@"User sets includes archived devices in '(.*)'")]
        public void UserIncludesArchivedDevices(string state)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();

            if (Convert.ToBoolean(state))
            {
                if (_driver.IsElementExists(page.ArchivedDevicesNotIncludedTooltip))
                {
                    page.ArchivedDevicesIcon.Click();
                    _driver.WaitForElementToBeNotDisplayed(page.ArchivedDevicesNotIncludedTooltip);
                }
            }
            else
            {
                if (_driver.IsElementExists(page.ArchivedDevicesIncludedTooltip))
                {
                    page.ArchivedDevicesIcon.Click();
                    _driver.WaitForElementToBeNotDisplayed(page.ArchivedDevicesIncludedTooltip);
                }
            }

            _driver.WaitForDataLoading();
        }

        [Then(@"Archived devices icon enabled state is '(.*)' in toolbar")]
        public void ThenArchivedDevicesIconIsEnabledInToolbar(string state)
        {
            var page = _driver.NowAt<BaseGridPage>();

            if (Convert.ToBoolean(state))
            {
                Verify.That(page.ArchivedDevicesIcon.GetCssValue("color"), Is.EqualTo("rgba(49, 122, 193, 1)"),
                    "Wrong Archived devices icon color");
                Verify.IsTrue(_driver.IsElementExists(page.ArchivedDevicesIncludedTooltip),
                    "Archived devices icon is disabled");
            }
            else
            {
                Verify.That(page.ArchivedDevicesIcon.GetCssValue("color"), Is.EqualTo("rgba(94, 95, 97, 1)"),
                    "Wrong Archived devices icon color");
                Verify.IsTrue(_driver.IsElementExists(page.ArchivedDevicesNotIncludedTooltip),
                    "Archived devices icon is enabled");
            }
        }

        #endregion

        #region Click content in the column

        [When(@"User doubleclicks on '(.*)' cell from '(.*)' column")]
        public void WhenUserDoubleclicksOnCellFromColumn(string cellText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var cell = page.GetCellFromColumn(columnName, cellText);
            _driver.DoubleClick(cell);
        }

        [When(@"User clicks on '(.*)' cell from '(.*)' column")]
        public void WhenUserClicksOnCellFromColumn(string cellText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var cell = page.GetCellFromColumn(columnName, cellText);
            cell.Click();
        }

        #endregion

        #region Check Content in the columns

        [Then(@"'(.*)' content is displayed in the '(.*)' column")]
        public void ThenContentIsDisplayedInTheColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetColumnContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            Verify.Contains(textContent, columnContent, $"'{textContent}' is not present in the '{columnName}' column");
        }

        [Then(@"'(.*)' content is not displayed in the '(.*)' column")]
        public void ThenContentIsNotDisplayedInTheColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            if (_driver.IsElementDisplayed(page.NoFoundMessage, WebDriverExtensions.WaitTime.Short))
            {
                //Message about no content in the table is displayed
                return;
            }
            else
            {
                var column = page.GetColumnContentByColumnName(columnName).ToList();
                if (column.Any())
                {
                    var columnContent = column.Select(x => x.Text).ToList();
                    Verify.IsFalse(columnContent.Contains(textContent), $"'{textContent}' is present in the '{columnName}' column");
                }
                else
                {
                    //Column doesn't have any data. Everything was removed
                    return;
                }
            }
        }

        [Then(@"Content in the '(.*)' column is equal to")]
        public void ThenContentInTheColumnIsEqualTo(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetColumnContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            Verify.IsTrue(columnContent.SequenceEqual(expectedList),
                $"Expected content is not present in the '{columnName}' column");
        }

        [Then(@"'(.*)' column contains following content")]
        public void ThenColumnContainsFollowingContent(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetColumnContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            foreach (string content in expectedList)
            {
                Verify.IsTrue(columnContent.Contains(content),
                    $"'{content}' content is not displayed in the '{columnName}' column");
            }
        }

        #endregion

        #region Clicable value

        //Change By double click
        [When(@"User change text in '(.*)' cell from '(.*)' column to '(.*)' text")]
        public void WhenUserChangeTextInCellFromColumnToText(string cellText, string columnName, string newCellText)
        {
            ChangeClickableValue(cellText, columnName, newCellText);

            SaveClickableValue();
        }

        [When(@"User change text in '(.*)' cell from '(.*)' column to '(.*)' text without saving")]
        public void WhenUserChangeTextInCellFromColumnToTextWithoutSaving(string cellText, string columnName, string newCellText)
        {
            ChangeClickableValue(cellText, columnName, newCellText);
        }

        //Change by CogMenu or when already opened for edit
        [When(@"User save '(.*)' text in clickable value")]
        public void WhenUserSaveTextInClickableValue(string newCellText)
        {
            EnterTextInClickableValue(newCellText);

            SaveClickableValue();
        }

        private void SaveClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.SaveInlineButton.Click();
            _driver.WaitForDataLoading();
        }

        private void ChangeClickableValue(string cellText, string columnName, string newCellText)
        {
            //Updated value will not be saved in test context!!!
            WhenUserDoubleclicksOnCellFromColumn(cellText, columnName);

            EnterTextInClickableValue(newCellText);
        }

        private void EnterTextInClickableValue(string newCellText)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.InputInlineTextbox.ClearWithBackspaces();
            page.InputInlineTextbox.SendKeys(newCellText);
        }

        [Then(@"Save and Cancel buttons with tooltips are displayed for clickable value")]
        public void ThenSaveAndCancelButtonsWithTooltipsAreDisplayedForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.SaveInlineButton);
            Verify.IsTrue(page.SaveInlineButton.Displayed(), "Save Inline Button is not displayed");
            Verify.IsTrue(page.CancelInlineButton.Displayed(), "Cancel Inline Button is not displayed");

            _driver.MouseHover(page.SaveInlineButton);
            Thread.Sleep(200);
            var saveTooltip = _driver.GetTooltipText();
            Verify.AreEqual("Save", saveTooltip, "Incorrect tooltip for Save button");

            _driver.MouseHover(page.CancelInlineButton);
            Thread.Sleep(200);
            var cancelTooltip = _driver.GetTooltipText();
            Verify.AreEqual("Cancel", cancelTooltip, "Incorrect tooltip for Cancel button");
        }

        [Then(@"Save and Cancel buttons are NOT displayed for clickable value")]
        public void ThenSaveAndCancelButtonsAreNotDisplayedForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();

            Verify.IsFalse(page.SaveInlineButton.Displayed(), "Save Inline Button is displayed");
            Verify.IsFalse(page.CancelInlineButton.Displayed(), "Cancel Inline Button is displayed");
        }

        [When(@"User clicks Save button for clickable value")]
        public void WhenUserClicksSaveButtonForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.SaveInlineButton.Click();

            _driver.WaitForDataLoading();
        }

        [When(@"User clicks Cancel button for clickable value")]
        public void WhenUserClicksCancelButtonForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.CancelInlineButton.Click();

            _driver.WaitForDataLoading();
        }

        #endregion

        #region GroupBy

        [When(@"User expands '(.*)' row in the groped grid")]
        public void WhenUserExpandsRowInTheGropedGrid(string groupedBy)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.ExpandGroupedRowByContent(groupedBy);
        }

        [Then(@"Grid is grouped")]
        public void ThenGridIsGrouped()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(page.IsGridGrouped(), "Grid is not grouped");
        }

        [Then(@"Grid is not grouped")]
        public void ThenGridIsNotGrouped()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(page.IsGridGrouped(), "Grid is grouped");
        }

        #endregion

        #region MoveItem

        [When(@"User moves '(.*)' item to '(.*)' item in the '(.*)' column")]
        public void WhenUserMovesItemToItemInTheColumn(string itemFrom, string itemTo, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var itemsList = page.GetColumnContentByColumnName(columnName);
            var columnContent = itemsList.Select(x => x.Text).ToList();
            var indexFrom = columnContent.IndexOf(itemFrom);
            var indexTo = columnContent.IndexOf(itemTo);
            _driver.DragAndDrop(page.DragRowElements[indexFrom], page.DragRowElements[indexTo]);
        }

        #endregion

        #region ScrollGrid

        [When(@"User scrolls grid to the bottom")]
        public void WhenUserScrollsGridToTheBottom()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.ScrollGridToTheEnd(page.TableBody);
        }

        #endregion
    }
}