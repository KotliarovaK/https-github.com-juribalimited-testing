using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BaseDashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseDashboardPage(RemoteWebDriver driver)
        {
            _driver = driver;
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
            List<KeyValuePair<DateTime, string>> unsortedList = new List<KeyValuePair<DateTime, string>>();
            DateTime datevalue;
            Assert.IsTrue(listpageMenu.DescendingSortingIcon.Displayed(), "Descending icon is not displayed");
            foreach (var date in expectedList)
            {
                var unconvertedDate = DateTime.TryParse(date, out datevalue);
                unsortedList.Add(unconvertedDate
                    ? new KeyValuePair<DateTime, string>(datevalue, date)
                    : new KeyValuePair<DateTime, string>(DateTime.MinValue, date));
            }

            try
            {
                Assert.AreEqual(expectedList.OrderByDescending(s => s).ToList(), expectedList,
                    "Incorrect sorting order");
            }
            catch (Exception)
            {
                for (int i = 0; i < expectedList.Count; i++)
                {
                    Assert.AreEqual(unsortedList.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray()[i],
                        expectedList[i], "Incorrect sorting order");
                }
            }
        }

        [Then(@"data in table is sorted by '(.*)' column in ascending order")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> expectedList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            List<KeyValuePair<DateTime, string>> unsortedList = new List<KeyValuePair<DateTime, string>>();
            DateTime datevalue;
            Assert.IsTrue(listpageMenu.AscendingSortingIcon.Displayed(), "Ascending icon is not displayed");
            foreach (var date in expectedList)
            {
                var unconvertedDate = DateTime.TryParse(date, out datevalue);
                unsortedList.Add(unconvertedDate
                    ? new KeyValuePair<DateTime, string>(datevalue, date)
                    : new KeyValuePair<DateTime, string>(DateTime.MinValue, date));
            }

            try
            {
                Assert.AreEqual(expectedList.OrderBy(s => s).ToList(), expectedList, "Incorrect sorting order");
            }
            catch (Exception)
            {
                for (int i = 0; i < expectedList.Count; i++)
                {
                    Assert.AreEqual(unsortedList.OrderBy(x => x.Key).Select(x => x.Value).ToArray()[i],
                        expectedList[i], "Incorrect sorting order");
                }
            }
        }

        [Then(@"data in the table is sorted by ""(.*)"" column in ascending order by default")]
        public void ThenDataInTheTableIsSortedByColumnInAscendingOrderByDefault(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            List<string> expectedList = listpageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            List<KeyValuePair<DateTime, string>> unsortedList = new List<KeyValuePair<DateTime, string>>();
            DateTime datevalue;
            foreach (var date in expectedList)
            {
                var unconvertedDate = DateTime.TryParse(date, out datevalue);
                unsortedList.Add(unconvertedDate
                    ? new KeyValuePair<DateTime, string>(datevalue, date)
                    : new KeyValuePair<DateTime, string>(DateTime.MinValue, date));
            }

            try
            {
                Assert.AreEqual(expectedList.OrderBy(s => s).ToList(), expectedList, "Incorrect sorting order");
            }
            catch (Exception)
            {
                for (int i = 0; i < expectedList.Count; i++)
                {
                    Assert.AreEqual(unsortedList.OrderBy(x => x.Key).Select(x => x.Value).ToArray()[i],
                        expectedList[i], "Incorrect sorting order");
                }
            }
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
                var content = page.GetColumnContent(row["ColumnName"]);

                //Check that at least 10 cells has some content
                Assert.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 10, "Newly added column is empty");
                //Assert.IsTrue(content.Select(string.IsNullOrEmpty).Count() > 10, "Newly added column is empty");
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