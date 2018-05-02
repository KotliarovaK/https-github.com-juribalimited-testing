using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Helpers;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BaseDashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.ListsDetails _listDetails;

        public EvergreenJnr_BaseDashboardPage(RemoteWebDriver driver, DTO.RuntimeVariables.ListsDetails listsDetails)
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

        [When(@"User move '(.*)' column to '(.*)' column")]
        public void WhenUserMoveColumnToColumn(string columnName, string columnNameToMove)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.DragAndDrop(page.GetColumnHeaderByName(columnName),
                page.GetColumnHeaderByName(columnNameToMove));
        }

        [When(@"User click on '(.*)' column header")]
        public void WhenUserClickOnColumnHeader(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            listpageMenu.GetColumnHeaderByName(columnName).Click();
        }

        [When(@"User sort table by multiple columns")]
        public void WhenUserSortTableByMultipleColumns(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                Actions shiftClick = new Actions(_driver);
                shiftClick.KeyDown(OpenQA.Selenium.Keys.Shift).Click(page.GetColumnHeaderByName(row["ColumnName"]))
                    .KeyUp(OpenQA.Selenium.Keys.Shift).Perform();
            }
        }

        [Then(@"data in table is sorted by '(.*)' column in descending order")]
        public void ThenDataInTableIsSortedByColumnInDescentingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> expectedList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            Assert.IsTrue(listpageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"data in table is sorted by '(.*)' column in ascending order")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> actualList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            Assert.IsTrue(listpageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by '(.*)' column in descending order")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> originalList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList);
            Assert.IsTrue(listpageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by '(.*)' column in ascending order")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> originalList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Assert.IsTrue(listpageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in ascending order")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> actualList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
            Assert.IsTrue(listpageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"numeric data in table is sorted by '(.*)' column in descending order")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            List<string> expectedList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Assert.IsTrue(listpageMenu.DescendingSortingIcon.Displayed);
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
                    Assert.IsEmpty(content.GetColumnContent("Username").First());
                    break;

                case "Applications":
                    Assert.IsEmpty(content.GetColumnContent("Application").First());
                    break;

                case "Mailboxes":
                    Assert.IsEmpty(content.GetColumnContent("Email Address").First());
                    break;

                default:
                    throw new Exception($"'{listName}' has the incorrect first cell");
            }
        }

        [Then(@"data in the table is sorted by ""(.*)"" column in ascending order by default")]
        public void ThenDataInTheTableIsSortedByColumnInAscendingOrderByDefault(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> originalList = listpageMenu.GetColumnContent(columnName).ToList();
            SortingHelper.IsListSorted(originalList);
        }

        [Then(@"full list content is displayed to the user")]
        public void ThenFullListContentIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.TableContent);
            Assert.IsTrue(page.TableRows.Count > 5, "Table is empty");
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

            List<string> columnNames = page.GetAllColumnHeaders().Select(column => column.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(expectedList, columnNames, "Columns order is incorrect");
        }

        [Then(@"URL is ""(.*)""")]
        public void ThenURLIs(string url)
        {
            Assert.AreEqual(url, _driver.Url, $"URL is not {url}");
        }

        [Then(@"URL contains ""(.*)""")]
        public void ThenURLContains(string url)
        {
            StringAssert.Contains(url, _driver.Url, $"URL is not contains {url}");
        }

        [Then(@"""(.*)"" text is displayed in filter container")]
        public void ThenTextIsDisplayedInFilterContainer(string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual(text, page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                $"Filter is created incorrectly");
        }

        [Then(@"""(.*)"" text is displayed in filter container for ""(.*)"" list name")]
        public void ThenTextIsDisplayedInFilterContainerForListName(string text, string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual(text.Replace("{LIST_ID}", _listDetails.GetListIdByName(listName)), page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [Then(@"""(.*)"" Application version is displayed")]
        public void ThenApplicationVersionIsDisplayed(string versionNumber)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetCorrectApplicationVersion(versionNumber);
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
    }
}