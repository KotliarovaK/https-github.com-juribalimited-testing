using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using DashworksTestAutomation.Providers;
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

        public EvergreenJnr_BaseDashboardPage(RemoteWebDriver driver, ListsDetails listsDetails)
        {
            _driver = driver;
            _listDetails = listsDetails;
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
            Assert.AreEqual(columnName, page.GetPinnedColumnName(pinStatus), "Column is pinned incorrectly");
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
            _driver.DragAndDrop(page.ActionsScrollBar, page.UpdateButton);
            Thread.Sleep(2000);
        }

        [When(@"User navigate to the top of the Action panel")]
        public void WhenUserNavigateToTheTopOfTheActionPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.DragAndDrop(page.ActionsScrollBar, page.ActionsRowsCount);
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

            var cellTopYCoordinte = page.GetElementTopYCoordinate(page.GetGridCellByText(columnName));
            var cellBottomYCoordinte = page.GetElementBottomYCoordinate(page.GetGridCellByText(columnName));
            var cellLeftXCoordinte = page.GetElementLeftXCoordinate(page.GetGridCellByText(columnName));
            var cellRightXCoordinte = page.GetElementRightXCoordinate(page.GetGridCellByText(columnName));

            var menuTopYCoordinate = page.GetElementTopYCoordinate(page.AgMenu);
            var manuLeftXCoordinate = page.GetElementLeftXCoordinate(page.AgMenu);

            Assert.That(menuTopYCoordinate, Is.GreaterThan(cellTopYCoordinte));
            Assert.That(menuTopYCoordinate, Is.LessThan(cellBottomYCoordinte));
            Assert.That(manuLeftXCoordinate, Is.GreaterThan(cellLeftXCoordinte));
            Assert.That(manuLeftXCoordinate, Is.LessThan(cellRightXCoordinte));
        }

        [Then(@"User sees context menu with next options")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            List<string> options = page.AgMenuOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Assert.That(options.FindAll(x => x.Equals(row["OptionsName"])).Count == 1);
            }
            Assert.That(options.Count, Is.EqualTo(table.Rows.Count));
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

            new Actions(_driver)
                .Click(searchElement.SearchEverythingField)
                .SendKeys(OpenQA.Selenium.Keys.LeftControl + "v")
                .KeyUp(OpenQA.Selenium.Keys.LeftControl)
                .Perform();

            Assert.That(searchElement.SearchEverythingField.GetAttribute("value").Replace("\t", "   "),
                Is.EqualTo(data.Replace(@"\t", "   ")));
        }


        [When(@"User click on '(.*)' column header")]
        public void WhenUserClickOnColumnHeader(string columnName)
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
                var shiftClick = new Actions(_driver);
                shiftClick.KeyDown(OpenQA.Selenium.Keys.Shift).Click(page.GetColumnHeaderByName(row["ColumnName"]))
                    .KeyUp(OpenQA.Selenium.Keys.Shift).Perform();
            }
        }

        [Then(@"data in table is sorted by '(.*)' column in descending order")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"data in table is sorted by '(.*)' column in ascending order")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by '(.*)' column in descending order")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by '(.*)' column in ascending order")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList);
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in ascending order")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in descending order")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
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
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
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
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"boolean data is sorted by '(.*)' column in ascending order")]
        public void ThenBooleanDataIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<BooleanState>(new List<string>(expectedList));
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"boolean data is sorted by '(.*)' column in descending order")]
        public void ThenBooleanDataIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<BooleanState>(new List<string>(expectedList), false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"The first cell of the table matches to default sorting ""(.*)"" list")]
        public void ThenTheFirstCellOfTheTableMatchesToDefaultSortingList(string listName)
        {
            var content = _driver.NowAt<BaseDashboardPage>();

            switch (listName)
            {
                case "Devices":
                    Assert.AreEqual("001BAQXT6JWFPI", content.GetColumnContent("Hostname").First());
                    break;

                case "Users":
                    Assert.AreEqual("Empty", content.GetColumnContent("Username").First());
                    break;

                case "Applications":
                    Assert.AreEqual("Empty", content.GetColumnContent("Application").First());
                    break;

                case "Mailboxes":
                    Assert.AreEqual("Empty", content.GetColumnContent("Email Address").First());
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

        [Then(@"""(.*)"" content is displayed in the ""(.*)"" column")]
        public void ThenContentIsDisplayedInTheColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var contentId = page.GetListContentByColumnName(columnName).ToList();
            var contentList = contentId.Select(x => x.Text).ToList();
            Assert.Contains(textContent, contentList, $"{textContent} is not displayed");
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" column")]
        public void ThenContentIsDisplayedInColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var originalList = page.GetRowContentByColumnName(columnName);
            Assert.AreEqual(textContent, originalList, "Content is not displayed correctly");
        }

        [Then(@"""(.*)"" text is displayed in the ""(.*)"" column")]
        public void ThenTextIsDisplayedInTheColumn(string text, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var originalList = page.GetColumnContentByColumnNameForCapacity(columnName);
            Assert.AreEqual(text, originalList, "Content is not displayed correctly");
        }

        [Then(@"""(.*)"" content is displayed for ""(.*)"" column")]
        public void ThenContentIsDisplayedForColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var originalList = page.GetColumnContentByColumnName(columnName);
            Assert.AreEqual(textContent, originalList, "Content is not displayed correctly");
        }

        [Then(@"""(.*)"" italic content is displayed")]
        public void ThenItalicContentIsDisplayed(string textContent)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetItalicContentByColumnName(textContent).Displayed, "Content is not styled in italic or not displayed");
        }

        [Then(@"full list content is displayed to the user")]
        public void ThenFullListContentIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.TableContent);
            Assert.IsTrue(page.TableRows.Count > 5, "Table is empty");
        }

        [Then(@"User sees ""(.*)"" rows in grid")]
        public void ThenUserSeesRowsInGrid(int rowsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.TableContent);
            Assert.That(page.TableRows.Count, Is.EqualTo(rowsCount));
        }

        [Then(@"Content is present in the newly added column")]
        public void ThenContentIsPresentInTheNewlyAddedColumn(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                //Sort newly added column to got only value at first places
                WhenUserClickOnColumnHeader(row["ColumnName"]);
                var content = page.GetColumnContent(row["ColumnName"]);

                //Check that at least 10 cells has some content
                Assert.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 10, "Newly added column is empty");
                //Reset column sorting to default value
                WhenUserClickOnColumnHeader(row["ColumnName"]);
                WhenUserClickOnColumnHeader(row["ColumnName"]);
            }
        }

        [Then(@"""(.*)"" text is displayed in the table content")]
        public void ThenTextIsDisplayedInTheTableContent(string text)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            dashboardPage.CheckColumnContent(text);
        }

        [Then(@"Evergreen Icon is displayed to the user")]
        public void ThenEvergreenIconIsDisplayedToTheUser()
        {
            _driver.WaitForDataLoading();
            var content = _driver.FindElements(By.XPath(BaseDashboardPage.ColumnWithEvergreenIconSelector));
            foreach (var element in content)
            {
                var evergreenIcon = element.FindElement(By.XPath(BaseDashboardPage.ImageSelector));
                Assert.IsTrue(_driver.IsElementExists(evergreenIcon), "Evergreen Icon is not found");
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
                Assert.That(row.FindElement(By.XPath(BaseDashboardPage.GridCell)).Displayed, Is.True);
            }
        }

        [Then(@"Appropriate header font weight is displayed")]
        public void ThenAppropriateHeaderFontWeightIsDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual("400", dashboardPage.GetHeaderFontWeight());
        }

        [Then(@"Column is displayed in following order:")]
        public void ThenColumnIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var columnNames = page.GetAllColumnHeaders().Select(column => column.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();
            Assert.AreEqual(expectedList, columnNames, "Columns order is incorrect");
        }

        [Then(@"URL is ""(.*)""")]
        public void ThenURLIs(string urlPart)
        {
            var expectedUrl = $"{UrlProvider.Url}{urlPart}";
            Assert.AreEqual(expectedUrl, _driver.Url, $"URL is not {expectedUrl}");
        }

        [Then(@"URL contains ""(.*)""")]
        public void ThenURLContains(string url)
        {
            StringAssert.Contains(url, _driver.Url, $"URL is not contains {url}");
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
                    StringAssert.Contains(urlFilterExpected, filter, $"URL is not contains {filter}");
                }
            }
        }

        [Then(@"""(.*)"" text is displayed in filter container")]
        public void ThenTextIsDisplayedInFilterContainer(string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.FilterContainerButton.Click();
            Assert.AreEqual(text, page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

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
            Assert.IsTrue(content.GetHrefByColumnName(columnName) != null);
        }

        [Then(@"""(.*)"" text is displayed in filter container for ""(.*)"" list name")]
        public void ThenTextIsDisplayedInFilterContainerForListName(string text, string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual(text.Replace("{LIST_ID}", _listDetails.GetListIdByName(listName)),
                page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [Then(@"""(.*)"" Application version is displayed")]
        public void ThenApplicationVersionIsDisplayed(string versionNumber)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetCorrectApplicationVersion(versionNumber);
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

                Assert.That(
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

                Assert.That(cell.GetCssValue("text-overflow"), Is.EqualTo("ellipsis"), "Data in cell not truncated");
                Assert.That(cell.GetCssValue("overflow"), Is.EqualTo("hidden"), "Data in cell not truncated");
            }
        }

        [Then(@"Content is empty in the column")]
        public void ThenContentIsEmptyInTheColumn(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContent(row["ColumnName"]);
                Assert.IsFalse(content.Count(x => !string.IsNullOrEmpty(x)) > 20, "Column is empty");
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
            page.Storage.SessionStorage.SetItem("column_value", page.GetRowContentByColumnName(columnName));
        }

        [Then(@"Rows counter number equals to remembered value")]
        public void ThenUserRememberedValueEqualsToGridCounter()
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(foundRowsCounter.ListRowsCounter);

            string rememberedNumber = foundRowsCounter.Storage.SessionStorage.GetItem("column_value");

            StringAssert.AreEqualIgnoringCase(rememberedNumber == "1" ? $"{rememberedNumber} row" : $"{rememberedNumber} rows",
                foundRowsCounter.ListRowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"Error is displayed to the User")]
        public void ThenErrorIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.ErrorBox.Displayed(), "Error is displayed");
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

        [Then(@"Error page is displayed correctly")]
        public void ThenErrorPageIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.Error403.Displayed());
            Assert.IsFalse(page.PageTitle.Displayed(), "Error page is not displayed correctly");
        }
    }
}