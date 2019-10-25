using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
            Verify.IsFalse(_driver.GetEvergreenCheckboxState(dashboardPage.SelectAllCheckbox),
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
            var columnContent = page.GetColumnContentByColumnName(columnName);
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
                var column = page.GetColumnContentByColumnName(columnName);
                if (column.Any())
                {
                    Verify.IsFalse(column.Contains(textContent), $"'{textContent}' is present in the '{columnName}' column");
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
            var columnContent = page.GetColumnContentByColumnName(columnName);
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            Verify.IsTrue(columnContent.SequenceEqual(expectedList),
                $"Expected content is not present in the '{columnName}' column");
        }

        [Then(@"'(.*)' column contains following content")]
        public void ThenColumnContainsFollowingContent(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var columnContent = page.GetColumnContentByColumnName(columnName);
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            foreach (string content in expectedList)
            {
                Verify.IsTrue(columnContent.Contains(content),
                    $"'{content}' content is not displayed in the '{columnName}' column");
            }
        }

        //For case when just empty cell are displayed. Probably also for case when no cells displayed
        [Then(@"Column '(.*)' with no data displayed")]
        public void ThenFollowingColumnDisplayedWithoutNoData(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var originalList = page.GetColumnContentByColumnName(columnName);

            foreach (var item in originalList)
            {
                Verify.That(item, Is.EqualTo(""), $"Incorrect content is displayed in the {columnName}");
            }
        }

        [Then(@"numbers sum in the '(.*)' column is equal to '(.*)'")]
        public void ThenNumbersSumInTheColumnIsEqualTo(string columnName, int expectedSum)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var numbers = page.GetColumnContentByColumnName(columnName);
            var total = numbers.Where(x => !string.IsNullOrEmpty(x)).Sum(x => Convert.ToInt32(x));
            Verify.That(total, Is.EqualTo(expectedSum),
                $"Sum of objects in the '{columnName}' column is incorrect!");
        }

        [Then(@"data in table is sorted by '(.*)' column in descending order")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();

            var expectedList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"data in table is sorted by '(.*)' column in ascending order")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();

            var actualList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"date in table is sorted by '(.*)' column in descending order")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();

            var originalList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"date in table is sorted by '(.*)' column in ascending order")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();

            var originalList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList);
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in ascending order")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var actualList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in descending order")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var expectedList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"color data is sorted by '(.*)' column in ascending order")]
        public void ThenColorDataIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var expectedList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            if (columnName.Equals("Compliance") || columnName.Equals("Owner Compliance"))
            {
                SortingHelper.IsListSortedByEnum<ColorCompliance>(new List<string>(expectedList));
            }
            else
            {
                SortingHelper.IsListSortedByEnum<Color>(new List<string>(expectedList));
            }
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"color data is sorted by '(.*)' column in descending order")]
        public void ThenColorDataIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var expectedList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            if (columnName.Equals("Compliance") || columnName.Equals("Owner Compliance"))
            {
                SortingHelper.IsListSortedByEnum<ColorCompliance>(new List<string>(expectedList), false);
            }
            else
            {
                SortingHelper.IsListSortedByEnum<Color>(new List<string>(expectedList), false);
            }
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Color data displayed with correct color and tooltip for ""(.*)"" column")]
        public void ThenColorDataDisplayedWithCorrectColorAndTooltip(string column)
        {
            var page = _driver.NowAt<BaseGridPage>();

            var ColumnValues = page.GetColumnContentByColumnName(column).Where(x => !x.Equals("")).ToList();
            var ColumnColors = page.GetColumnColors(column).Where(x => !x.Equals("")).ToList();
            var ColumnToolTips = page.GetColumnTooltips(column).Where(x => !x.Equals("")).ToList();

            for (int i = 0; i < ColumnValues.Count; i++)
            {
                Utils.Verify.That(ColumnColors[i], Does.Contain(ColorsConvertor.Convert(ColumnValues[i])),
                    $"Wrong color {ColumnColors[i]} for label {ColumnValues[i]}");
            }

            ColumnValues = ColumnValues.ConvertAll(d => d.ToLower());
            ColumnToolTips = ColumnToolTips.ConvertAll(d => d.ToLower());

            Utils.Verify.That(ColumnValues, Is.EqualTo(ColumnToolTips));
        }

        [Then(@"boolean data is sorted by '(.*)' column in ascending order")]
        public void ThenBooleanDataIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var expectedList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<BooleanState>(new List<string>(expectedList));
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"boolean data is sorted by '(.*)' column in descending order")]
        public void ThenBooleanDataIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var expectedList = listPageMenu.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<BooleanState>(new List<string>(expectedList), false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"The first cell of the table matches to default sorting ""(.*)"" list")]
        public void ThenTheFirstCellOfTheTableMatchesToDefaultSortingList(string listName)
        {
            var content = _driver.NowAt<BaseGridPage>();

            switch (listName)
            {
                case "Devices":
                    Utils.Verify.AreEqual("001BAQXT6JWFPI", content.GetColumnContentByColumnName("Hostname").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                case "Users":
                    Utils.Verify.AreEqual("Empty", content.GetColumnContentByColumnName("Username").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                case "Applications":
                    Utils.Verify.AreEqual("Empty", content.GetColumnContentByColumnName("Application").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                case "Mailboxes":
                    Utils.Verify.AreEqual("Empty", content.GetColumnContentByColumnName("Email Address").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                default:
                    throw new Exception($"'{listName}' has the incorrect first cell");
            }
        }

        [Then(@"data in the table is sorted by ""(.*)"" column in ascending order by default")]
        public void ThenDataInTheTableIsSortedByColumnInAscendingOrderByDefault(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var originalList = listPageMenu.GetColumnContentByColumnName(columnName).ToList();
            SortingHelper.IsListSorted(originalList);
        }

        [Then(@"Content is present in the newly added column")]
        public void ThenContentIsPresentInTheNewlyAddedColumn(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();

            foreach (var row in table.Rows)
            {
                //Sort newly added column to got only value at first places
                WhenUserClicksOnColumnHeader(row["ColumnName"]);
                var content = page.GetColumnContentByColumnName(row["ColumnName"]);

                //Check that at least 10 cells has some content
                Verify.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 10, "Newly added column is empty");
                //Reset column sorting to default value
                WhenUserClicksOnColumnHeader(row["ColumnName"]);
                WhenUserClicksOnColumnHeader(row["ColumnName"]);
            }
        }

        [Then(@"width of the '(.*)' column is '(.*)' pixels")]
        public void ThenWidthOfTheColumnIsPixels(string columnName, string columnWidth)
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            Utils.Verify.AreEqual(columnWidth, dashboardPage.GetColumnWidthByName(columnName), $"width '{columnName}' column is not '{columnWidth}'");
        }

        [Then(@"Links from ""(.*)"" column is displayed to the user")]
        public void ThenLinksFromColumnIsDisplayedToTheUser(string columnName)
        {
            var content = _driver.NowAt<BaseGridPage>();
            content.GetHrefByColumnName(columnName);
            Utils.Verify.IsTrue(content.GetHrefByColumnName(columnName) != null, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Content is empty in the column")]
        public void ThenContentIsEmptyInTheColumn(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContentByColumnName(row["ColumnName"]);
                Verify.IsFalse(content.Count(x => !string.IsNullOrEmpty(x)) > 20, "Column is empty");
            }
        }

        [When(@"User clicks on '(.*)' column header")]
        public void WhenUserClicksOnColumnHeader(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            listPageMenu.GetColumnHeaderByName(columnName).Click();
            _driver.WaitForDataLoading();
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
            var columnContent = page.GetColumnContentByColumnName(columnName);
            var indexFrom = columnContent.IndexOf(itemFrom);
            var indexTo = columnContent.IndexOf(itemTo);
            _driver.DragAndDrop(page.DragRowElements[indexFrom], page.DragRowElements[indexTo]);
        }

        [When(@"User move '(.*)' column to '(.*)' column")]
        public void WhenUserMoveColumnToColumn(string columnName, string columnNameToMove)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.DragAndDrop(page.GetColumnHeaderByName(columnName),
                page.GetColumnHeaderByName(columnNameToMove));
        }

        [When(@"User moves ""(.*)"" column beyond the Grid")]
        public void WhenUserMovesColumnBeyondTheGrid(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.DragAndDrop(page.GetColumnHeaderByName(columnName), page.RefreshButton);
            page.GetColumnHeaderByName(columnName).Click();
        }

        #endregion

        #region ScrollGrid

        [When(@"User scrolls grid to the bottom")]
        public void WhenUserScrollsGridToTheBottom()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementsToBeDisplayed(By.XPath(page.AllCellsInTheGrid));
            _driver.ScrollGridToTheEnd(page.TableBody);
        }

        #endregion

        #region DataInColumn

        [Then(@"All data is unique in the '(.*)' column")]
        public void ThenAllDataIsUniqueInTheColumn(string columnName)
        {
            var grid = _driver.NowAt<BaseGridPage>();
            var columnData = grid.GetColumnDataByScrolling(columnName);

            //Get all elements that has more than one occurence in the list
            var duplicates = columnData.GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1).ToList();
            if (duplicates.Any())
                throw new Exception($"Some duplicates are spotted in the '{columnName}' column");
        }

        [Then(@"User sees following duplicates counts for columns:")]
        public void ThenUserSeesFollowingDuplicatesCountsForColumns(Table table)
        {
            var grid = _driver.NowAt<BaseGridPage>();
            foreach (var column in table.Rows)
            {
                var columnData = grid.GetColumnDataByScrolling(column["column"]);

                //Get all elements that has more than one occurence in the list
                var duplicates = columnData.GroupBy(x => x)
                    .Select(g => new { Value = g.Key, Count = g.Count() })
                    .Where(x => x.Count > 1).ToList();

                Verify.That(
                    duplicates.Where(x => x.Value.Equals(column["duplicatedValue"])).FirstOrDefault().Count.ToString(),
                    Is.EqualTo(column["duplicateCount"]), "Duplicates counts are not equal");
            }
        }

        #endregion

        #region Sorting

        [When(@"User sort table by multiple columns")]
        public void WhenUserSortTableByMultipleColumns(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
            {
                _driver.MouseHoverByJavascript(page.GetColumnHeaderByName(row["ColumnName"]));
                var shiftClick = new Actions(_driver);
                shiftClick.KeyDown(OpenQA.Selenium.Keys.Shift).Click(page.GetColumnHeaderByName(row["ColumnName"]))
                    .KeyUp(OpenQA.Selenium.Keys.Shift).Perform();
            }
            _driver.WaitForDataLoading();
        }

        #endregion
    }
}