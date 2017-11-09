using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using System.Text.RegularExpressions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Interactions;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ColumnsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ColumnNameToUrlConvertor _convertor;

        public EvergreenJnr_ColumnsPanel(RemoteWebDriver driver, ColumnNameToUrlConvertor convertor)
        {
            _driver = driver;
            _convertor = convertor;
        }

        [Then(@"Columns panel is displayed to the user")]
        public void ThenColumnsPanelIsDisplayedToTheUser()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsTrue(columnElement.ColumnsPanel.Displayed(), "Columns panel is not displayed");
            Logger.Write("Columns panel is visible");
        }

        [When(@"ColumnName is entered into the search box and the selection is clicked")]
        public void WhenColumnNameIsEnteredIntoTheSearchBoxAndTheSelectionIsClicked(Table table)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();

            foreach (var row in table.Rows)
            {
                columnElement.AddColumn(row["ColumnName"]);
                //Clear the textbox after adding a column, so it is reset for the next loop
                columnElement.SearchTextbox.Clear();
            }
            //Minimise the Selected Columns
            columnElement.MinimizeGroupButton.Click();
            _driver.WaitWhileControlIsDisplayed<ColumnsElement>(() => columnElement.MinimizeGroupButton);
            //Close the Columns Panel
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            listpageMenu.ColumnButton.Click();
        }

        [Then(@"ColumnName is added to the list")]
        public void ThenColumnNameIsAddedToTheList(Table table)
        {
            CheckColumnDisplayedState(table, true);
        }

        [Then(@"ColumnName is removed from the list")]
        public void ThenColumnNameIsRemovedFromTheList(Table table)
        {
            CheckColumnDisplayedState(table, false);
        }

        private void CheckColumnDisplayedState(Table table, bool displayedState)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                Assert.AreEqual(displayedState, listpageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' displayed state should be {displayedState}");
            }
        }

        [When(@"User add all Columns from specific category")]
        public void WhenUserAddAllColumnsFromSpecificCategory(Table table)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();

            foreach (var row in table.Rows)
            {
                columnElement.AddAllColumnsFromCategory(row["CategoryName"]);
            }
        }

        [When(@"User click on '(.*)' column header")]
        public void WhenUserClickOnColumnHeader(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
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

        [Then(@"data in table is sorted by '(.*)' column in descenting order")]
        public void ThenDataInTableIsSortedByColumnInDescentingOrder(string columnName)
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
                Assert.AreEqual(unsortedList.OrderByDescending(x => x.Key).Select(x => x.Value), expectedList);
            }
            catch (Exception e)
            {
                for (int i = 0; i < expectedList.Count; i++)
                {
                    Assert.AreEqual(unsortedList.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray()[i],
                        expectedList[i]);
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
            foreach (var date in expectedList)
            {
                var unconvertedDate = DateTime.TryParse(date, out datevalue);
                unsortedList.Add(unconvertedDate
                    ? new KeyValuePair<DateTime, string>(datevalue, date)
                    : new KeyValuePair<DateTime, string>(DateTime.MinValue, date));
            }
            try
            {
                Assert.AreEqual(unsortedList.OrderBy(x => x.Key).Select(x => x.Value), expectedList);
            }
            catch (Exception e)
            {
                for (int i = 0; i < expectedList.Count; i++)
                {
                    Assert.AreEqual(unsortedList.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray()[i],
                        expectedList[i]);
                }
            }
        }

        [When(@"User is removed ""(.*)"" column by Column panel")]
        public void WhenUserIsRemovedColumnByColumnPanel(string columnName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.ExpandColumnsSectionByName("Selected Columns");
            columnElement.GetDeleteColumnButton(columnName).Click();
        }

        [When(@"User is removed column by URL")]
        public void WhenUserIsRemovedColumnByURL(Table table)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"select=(.*)\&\$orderby";
            foreach (var row in table.Rows)
            {
                var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
                var changedPart = originalPart.Replace($",{_convertor.Convert(row["ColumnName"])}", string.Empty);
                _driver.NagigateToURL(currentUrl.Replace(originalPart, changedPart));

                var page = _driver.NowAt<EvergreenDashboardsPage>();
                if (page.StatusCodeLabel.Displayed())
                {
                    throw new Exception($"500 error was returned for: {row["ColumnName"]} column");
                }
            }
        }

        [Then(@"Content is present in the newly added column")]
        public void ThenContentIsPresentInTheNewlyAddedColumn(Table table)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                var content = listpageMenu.GetColumnContent(row["ColumnName"]);
                //Check that at least 10 cells has some content
                Assert.IsTrue(content.Select(string.IsNullOrEmpty).Count() > 10);
            }
        }

        [Then(@"""(.*)"" subcategories is displayed for ""(.*)"" category")]
        public void ThenSubcategoriesIsDisplayedForCategory(int subCategoriesCount, string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            var t = columnElement.GetSubcategoriesCountByCategoryName(categoryName);
            Assert.AreEqual(subCategoriesCount, columnElement.GetSubcategoriesCountByCategoryName(categoryName));
        }

        [Then(@"Maximize or Minimize button is not displayed for ""(.*)"" category")]
        public void ThenMaximizeOrMinimizeButtonIsNotDisplayedForCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsFalse(columnElement.MaximizeOrMinimizeButtonByCategory(categoryName).Displayed(),
                $"Maximize/Minimize button is displayed for empty {categoryName} category");
        }

        [Then(@"User is expand ""(.*)"" columns category")]
        public void ThenUserIsExpandColumnsCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.ExpandColumnsSectionByName(categoryName);
        }
    }
}