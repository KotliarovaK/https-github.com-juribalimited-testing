using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ColumnsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ColumnsPanel(RemoteWebDriver driver)
        {
            _driver = driver;
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
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();
            listpageMenu.ColumnButton.Click();
        }

        [Then(@"ColumnName is added to the list")]
        public void ThenColumnNameIsAddedToTheList(Table table)
        {
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(listpageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' is not exists in the table");
            }
        }

        [When(@"User click on '(.*)' column header")]
        public void WhenUserClickOnColumnHeader(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();
            listpageMenu.GetColumnHeaderByName(columnName).Click();
        }

        [Then(@"data in table is sorted by '(.*)' column in descenting order")]
        public void ThenDataInTableIsSortedByColumnInDescentingOrder(string columnName)
        {
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();

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
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();

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

        [Then(@"Content is present in the newly added column")]
        public void ThenContentIsPresentInTheNewlyAddedColumn(Table table)
        {
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();

            foreach (var row in table.Rows)
            {
                var content = listpageMenu.GetColumnContent(row["ColumnName"]);
                //Check that at least 10 cells has some content
                Assert.IsTrue(content.Select(string.IsNullOrEmpty).Count() > 10);
            }
        }
    }
}