using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BaseDashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listDetails;
        private readonly ColumnValue _columnValue;

        public EvergreenJnr_BaseDashboardPage(RemoteWebDriver driver, ListsDetails listsDetails, ColumnValue columnValue)
        {
            _driver = driver;
            _listDetails = listsDetails;
            _columnValue = columnValue;
        }

        [When(@"User have opened column settings for ""(.*)"" column")]
        public void WhenUserHaveOpenedColumnSettingsForColumn(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.OpenColumnSettingsByName(columnName);
        }

        [When(@"User have select ""(.*)"" option from column settings")]
        public void WhenUserHaveSelectOptionFromColumnSettings(string settingName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetSettingButtonByName(settingName).Click();
        }

        [Then(@"""(.*)"" column is ""(.*)"" Pinned")]
        public void ThenColumnIsPinned(string columnName, string pinStatus)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(columnName, page.GetPinnedColumnName(pinStatus), "Column is pinned incorrectly");
        }

        [When(@"User opens settings for ""(.*)"" row")]
        public void WhenUserOpensSettingsForRow(string rowName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetSettingIconByRowName(rowName).Click();
        }

        [When(@"User selects ""(.*)"" option from settings menu")]
        public void WhenUserSelectsOptionFromSettingsMenu(string optionName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetSettingOptionByName(optionName).Click();
        }

        [When(@"User move '(.*)' column to '(.*)' column")]
        public void WhenUserMoveColumnToColumn(string columnName, string columnNameToMove)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.DragAndDrop(page.GetColumnHeaderByName(columnName),
                page.GetColumnHeaderByName(columnNameToMove));
        }

        [When(@"User navigate to the bottom of the Action panel")]
        public void WhenUserNavigateToTheBottomOfTheActionPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            //TODO: 27Aug2019 Yurii: changed to moveTo
            //_driver.DragAndDrop(page.ActionsScrollBar, page.UpdateButton);
            _driver.MoveToElement(page.UpdateButton);
            Thread.Sleep(2000);
        }

        [When(@"User navigate to the top of the Action panel")]
        public void WhenUserNavigateToTheTopOfTheActionPanel()
        {
            var page = _driver.NowAt<ActionsPanelElement>();
            //TODO: 27Aug2019 replaced drag and drop to moveTo
            //_driver.DragAndDrop(page.ActionsScrollBar, page.ActionsRowsCount);
            _driver.MoveToElement(page.RowsCount);
            Thread.Sleep(2000);
        }

        [When(@"User moves ""(.*)"" column beyond the Grid")]
        public void WhenUserMovesColumnBeyondTheGrid(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.DragAndDrop(page.GetColumnHeaderByName(columnName), page.RefreshTableButton);
            page.GetColumnHeaderByName(columnName).Click();
        }

        [When(@"User performs right-click on ""(.*)"" cell in the grid")]
        public void WhenUserPerformsRightClickOnCellInTheGrid(string cellText)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            page.ContextClickOnCell(cellText);
        }

        [Then(@"User sees context menu placed near ""(.*)"" cell in the grid")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var cellTopYCoordinte = page.GetGridCellByText(columnName).Location.Y;
            var cellBottomYCoordinte = page.GetGridCellByText(columnName).BottomLocation().Y;
            var cellLeftXCoordinte = page.GetGridCellByText(columnName).BottomLocation().X;
            var cellRightXCoordinte = page.GetGridCellByText(columnName).RightTopLocation().X;

            var menuTopYCoordinate = page.AgMenu.Location.Y;
            var manuLeftXCoordinate = page.AgMenu.Location.X;

            Verify.That(menuTopYCoordinate, Is.GreaterThan(cellTopYCoordinte));
            Verify.That(menuTopYCoordinate, Is.LessThan(cellBottomYCoordinte));
            Verify.That(manuLeftXCoordinate, Is.GreaterThan(cellLeftXCoordinte));
            Verify.That(manuLeftXCoordinate, Is.LessThan(cellRightXCoordinte));
        }

        [Then(@"User sees context menu with next options")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            List<string> options = page.AgMenuOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Verify.That(options.FindAll(x => x.Equals(row["OptionsName"])).Count == 1, "PLEASE ADD EXCEPTION MESSAGE");
            }
            Verify.That(options.Count, Is.EqualTo(table.Rows.Count));
        }

        [When(@"User selects '(.*)' option in context menu")]
        public void WhenUserClickOptionInContextMenu(string option)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            page.AgMenuOptions.FirstOrDefault(x => x.Text.Equals(option))?.Click();
        }

        [Then(@"Next data '(.*)' is copied")]
        public void ThenUserCopiedNextDataToClipboard(string data)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForDataLoading();

            _driver.InsertFromClipboard(searchElement.SearchEverythingField);

            Verify.That(searchElement.SearchEverythingField.GetAttribute("value").Replace("\t", "   "),
                Is.EqualTo(data.Replace(@"\t", "   ")));
        }

        [When(@"User clicks on '(.*)' column header")]
        public void WhenUserClicksOnColumnHeader(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            listPageMenu.GetColumnHeaderByName(columnName).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User sort table by multiple columns")]
        public void WhenUserSortTableByMultipleColumns(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                _driver.MouseHoverByJavascript(page.GetColumnHeaderByName(row["ColumnName"]));
                var shiftClick = new Actions(_driver);
                shiftClick.KeyDown(OpenQA.Selenium.Keys.Shift).Click(page.GetColumnHeaderByName(row["ColumnName"]))
                    .KeyUp(OpenQA.Selenium.Keys.Shift).Perform();
            }
            _driver.WaitForDataLoading();
        }

        [Then(@"data in table is sorted by '(.*)' column in descending order")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"data in table is sorted by '(.*)' column in ascending order")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"date in table is sorted by '(.*)' column in descending order")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"date in table is sorted by '(.*)' column in ascending order")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList);
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in ascending order")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in descending order")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"color data is sorted by '(.*)' column in ascending order")]
        public void ThenColorDataIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
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
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
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
            var page = _driver.NowAt<BaseDashboardPage>();

            var ColumnValues = page.GetColumnContent(column).Where(x => !x.Equals("")).ToList();
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
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<BooleanState>(new List<string>(expectedList));
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"boolean data is sorted by '(.*)' column in descending order")]
        public void ThenBooleanDataIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<BooleanState>(new List<string>(expectedList), false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"The first cell of the table matches to default sorting ""(.*)"" list")]
        public void ThenTheFirstCellOfTheTableMatchesToDefaultSortingList(string listName)
        {
            var content = _driver.NowAt<BaseDashboardPage>();

            switch (listName)
            {
                case "Devices":
                    Utils.Verify.AreEqual("001BAQXT6JWFPI", content.GetColumnContent("Hostname").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                case "Users":
                    Utils.Verify.AreEqual("Empty", content.GetColumnContent("Username").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                case "Applications":
                    Utils.Verify.AreEqual("Empty", content.GetColumnContent("Application").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                case "Mailboxes":
                    Utils.Verify.AreEqual("Empty", content.GetColumnContent("Email Address").First(), "PLEASE ADD EXCEPTION MESSAGE");
                    break;

                default:
                    throw new Exception($"'{listName}' has the incorrect first cell");
            }
        }

        [Then(@"data in the table is sorted by ""(.*)"" column in ascending order by default")]
        public void ThenDataInTheTableIsSortedByColumnInAscendingOrderByDefault(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).ToList();
            SortingHelper.IsListSorted(originalList);
        }

        //TODO this should be deleted. Use ThenContentIsDisplayedInTheColumn or ThenContentIsDisplayedInTheColumn instead
        [Then(@"""(.*)"" content is displayed in ""(.*)"" column")]
        public void ThenContentIsDisplayedInColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var originalList = page.GetRowContentByColumnName(columnName);
            Verify.AreEqual(textContent, originalList, "Content is not displayed correctly");
        }

        [Then(@"""(.*)"" tooltip displayed in ""(.*)"" column")]
        public void ThenTooltipIsDisplayedInColumn(string textTooltip, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var cellElement = page.GetGridCellByText(textTooltip);
            _driver.MouseHover(cellElement);
            var tooltip = _driver.GetTooltipBubbleText();
            Verify.AreEqual(textTooltip, tooltip, "Tooltip is not displayed correctly");
        }

        [Then(@"""(.*)"" content is displayed for ""(.*)"" column")]
        public void ThenContentIsDisplayedForColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var originalList = page.GetColumnContentByColumnName(columnName);
            Verify.AreEqual(textContent, originalList, "Content is not displayed correctly");
        }

        [Then(@"""(.*)"" italic content is displayed")]
        public void ThenItalicContentIsDisplayed(string textContent)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.GetItalicContentByColumnName(textContent).Displayed, "Content is not styled in italic or not displayed");
        }

        [Then(@"full list content is displayed to the user")]
        public void ThenFullListContentIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.TableContent);
            Utils.Verify.IsTrue(page.TableRows.Count > 5, "Table is empty");
        }

        [Then(@"User sees ""(.*)"" rows in grid")]
        public void ThenUserSeesRowsInGrid(int rowsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.TableContent);
            Verify.That(page.TableRows.Count, Is.EqualTo(rowsCount));
        }

        [Then(@"Content is present in the newly added column")]
        public void ThenContentIsPresentInTheNewlyAddedColumn(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                //Sort newly added column to got only value at first places
                WhenUserClicksOnColumnHeader(row["ColumnName"]);
                var content = page.GetColumnContent(row["ColumnName"]);

                //Check that at least 10 cells has some content
                Verify.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 10, "Newly added column is empty");
                //Reset column sorting to default value
                WhenUserClicksOnColumnHeader(row["ColumnName"]);
                WhenUserClicksOnColumnHeader(row["ColumnName"]);
            }
        }

        [Then(@"Evergreen Icon is displayed to the user")]
        public void ThenEvergreenIconIsDisplayedToTheUser()
        {
            _driver.WaitForDataLoading();
            var content = _driver.FindElements(By.XPath(BaseDashboardPage.ColumnWithEvergreenIconSelector));
            foreach (var element in content)
            {
                var evergreenIcon = element.FindElement(By.XPath(BaseDashboardPage.ImageSelector));
                Verify.IsTrue(_driver.IsElementExists(evergreenIcon), "Evergreen Icon is not found");
            }
        }

        [Then(@"table content is present")]
        public void ThenTableContentIsPresent()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var rows = page.TableRows;
            foreach (var row in rows)
            {
                Utils.Verify.That(row.FindElement(By.XPath(BaseDashboardPage.GridCell)).Displayed, Is.True);
            }
        }

        [Then(@"width of the '(.*)' column is '(.*)' pixels")]
        public void ThenWidthOfTheColumnIsPixels(string columnName, string columnWidth)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.AreEqual(columnWidth, dashboardPage.GetColumnWidthByName(columnName), $"width '{columnName}' column is not '{columnWidth}'");
        }

        [Then(@"Appropriate header font weight is displayed")]
        public void ThenAppropriateHeaderFontWeightIsDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.AreEqual("400", dashboardPage.GetHeaderFontWeight(), "Header font weight is incorrect");
        }

        [Then(@"Column is displayed in following order:")]
        public void ThenColumnIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var columnNames = page.GetAllColumnHeaders().Select(column => column.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();
            Utils.Verify.AreEqual(expectedList, columnNames, "Columns order is incorrect");
        }

        [Then(@"URL is ""(.*)""")]
        public void ThenURLIs(string urlPart)
        {
            var expectedUrl = $"{UrlProvider.Url}{urlPart}";
            Utils.Verify.AreEqual(expectedUrl, _driver.Url, $"URL is not {expectedUrl}");
        }

        [Then(@"URL contains ""(.*)""")]
        public void ThenURLContains(string url)
        {
            Utils.Verify.Contains(url, _driver.Url, $"URL is not contains {url}");
        }

        [Then(@"URL contains only ""(.*)"" filter")]
        public void ThenURLContainsOnly(string urlFilterExpected)
        {
            string url = _driver.Url;
            url = url.Substring(url.IndexOf("?") + 1);
            string[] filterInUrl = url.Split('$');

            foreach (var filter in filterInUrl)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    Utils.Verify.Contains(urlFilterExpected, filter, $"URL is not contains {filter}");
                }
            }
        }

        [Then(@"""(.*)"" text is displayed in filter container")]
        public void ThenTextIsDisplayedInFilterContainer(string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.MoveToElement(page.FilterOptions);
            _driver.WaitForElementToBeDisplayed(page.FilterOptions);
            if (!_driver.IsElementDisplayed(page.FilterContainer)) page.FilterContainerButton.Click();
            Utils.Verify.AreEqual(text, page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [When(@"User closes filter container")]
        [When(@"User opens filter container")]
        public void WhenUserOpensFilterContainer()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.FilterContainerButton.Click();
        }

        [Then(@"Links from ""(.*)"" column is displayed to the user")]
        public void ThenLinksFromColumnIsDisplayedToTheUser(string columnName)
        {
            var content = _driver.NowAt<BaseDashboardPage>();
            content.GetHrefByColumnName(columnName);
            Utils.Verify.IsTrue(content.GetHrefByColumnName(columnName) != null, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" text is displayed in filter container for ""(.*)"" list name")]
        public void ThenTextIsDisplayedInFilterContainerForListName(string text, string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.AreEqual(text.Replace("{LIST_ID}", _listDetails.GetListIdByName(listName)),
                page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [Then(@"String filter values are not duplicated")]
        public void ThenStringFilterValuesAreNotDuplicated()
        {
            var grid = _driver.NowAt<BaseDashboardPage>();
            var filtersValue = grid.StringFilterValues.Select(x => x.Text).ToList();
            Verify.AreEqual(filtersValue.Distinct().Count(), filtersValue.Count(), "String filters value are duplicated");
        }

        [Then(@"All data is unique in the '(.*)' column")]
        public void ThenAllDataIsUniqueInTheColumn(string columnName)
        {
            var grid = _driver.NowAt<BaseDashboardPage>();
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
            var grid = _driver.NowAt<BaseDashboardPage>();
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

        [Then(@"User sees following text in cell truncated with ellipsis:")]
        public void ThenUserSeesFollowingTextInCellTruncatedWithEllipsis(Table table)
        {
            var grid = _driver.NowAt<BaseDashboardPage>();
            foreach (var column in table.Rows)
            {
                var cell = grid.GetGridCellByText(column["cellText"]);

                Verify.That(cell.GetCssValue("text-overflow"), Is.EqualTo("ellipsis"), "Data in cell not truncated");
                Verify.That(cell.GetCssValue("overflow"), Is.EqualTo("hidden"), "Data in cell not truncated");
            }
        }

        [Then(@"Content is empty in the column")]
        public void ThenContentIsEmptyInTheColumn(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContent(row["ColumnName"]);
                Verify.IsFalse(content.Count(x => !string.IsNullOrEmpty(x)) > 20, "Column is empty");
            }
        }

        [When(@"User clicks Close panel button")]
        public void WhenUserClicksClosePanelButton()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            button.ClosePanelButton.Click();
        }

        [When(@"User remembers value in ""(.*)"" column")]
        public void WhenUserRemembersValueInSpecificColumn(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _columnValue.Value = page.GetRowContentByColumnName(columnName);
        }

        [Then(@"Rows counter number equals to remembered value")]
        public void ThenUserRememberedValueEqualsToGridCounter()
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            //We need this wait for grid to be updated
            //TODO replace my something more smart
            Thread.Sleep(1000);
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(foundRowsCounter.ListRowsCounter);

            string rememberedNumber = _columnValue.Value;

            Verify.AreEqualIgnoringCase(rememberedNumber == "1" ? $"{rememberedNumber} row" : $"{rememberedNumber} rows",
                foundRowsCounter.ListRowsCounter.Text.Replace(",", ""), "Incorrect rows count");
        }

        [Then(@"Error is displayed to the User")]
        public void ThenErrorIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(page.ErrorBox.Displayed(), "Error is displayed");
        }

        [When(@"User navigates to ""(.*)"" URL in a new tab")]
        public void WhenUserNavigatesToURLInANewTab(string urlParameters)
        {
            _driver.OpenInNewTab($"{UrlProvider.Url}{urlParameters}");
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }

        [When(@"User switches to previous tab")]
        public void WhenUserSwitchesToPreviousTab()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.First());
        }

        [Then(@"Warning Pop-up is displayed to the User")]
        public void ThenWarningPop_UpIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(page.WarningPopUpPanel.Displayed(), "Warning Pop-up is not displayed");
        }

        [When(@"User clicks ""(.*)"" button in the Warning Pop-up message")]
        public void WhenUserClicksButtonInTheWarningPop_UpMessage(string buttonName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.GetButtonInWarningPopUp(buttonName).Click();
        }
    }
}