﻿using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ColumnsPanel : SpecFlowContext
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

        [When(@"User enters ""(.*)"" text in Search field at Columns Panel")]
        public void WhenUserEntersTextInSearchFieldAtColumnsPanel(string searchedText)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.SearchTextbox.Clear();
            columnElement.SearchTextbox.SendKeys(searchedText);
        }

        [When(@"User clears search textbox in Columns panel")]
        public void WhenUserClearsSearchTextboxInColumnsPanel()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.SearchTextboxResetButton.Click();
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
            //columnElement.MinimizeGroupButton.Click();
            //_driver.WaitWhileControlIsDisplayed<ColumnsElement>(() => columnElement.MinimizeGroupButton);
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
                _driver.WaitForDataLoading();
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

        [When(@"User removes ""(.*)"" column by Column panel")]
        public void WhenUserRemovesColumnByColumnPanel(string columnName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.ExpandColumnsSectionByName("Selected Columns");
            columnElement.GetDeleteColumnButton(columnName).Click();
        }

        [When(@"User have reset all columns")]
        public void WhenUserHaveResetAllColumns()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ColumnsElement>(() => columnElement.ResetColumnsButton);
            _driver.MouseHover(columnElement.ResetColumnsButton);
            columnElement.ResetColumnsButton.Click();
        }

        [When(@"User removes column by URL")]
        public void WhenUserRemovesColumnByUrl(Table table)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"select=(.*)";
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

        [When(@"User removes sorted column by URL")]
        public void WhenUserRemovesSortedColumnByUrl(Table table)
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

        [When(@"User removes all columns by URL")]
        public void WhenUserRemovesAllColumnsByURL()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"select=(.*)";

            var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
            _driver.NagigateToURL(currentUrl.Replace(originalPart, String.Empty));

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
            {
                throw new Exception($"500 error was returned after removing all columns from URL");
            }
        }

        [When(@"User removes all filters and columns by url")]
        public void WhenUserRemovesAllFiltersAndColumnsByUrl()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\&(.*)";

            var originalPart = Regex.Match(currentUrl, pattern).Value;
            _driver.NagigateToURL(currentUrl.Replace(originalPart, String.Empty));

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
            {
                throw new Exception($"500 error was returned after removing all columns from URL");
            }
        }

        [When(@"User removes all filters and columns and custom list by url")]
        public void WhenUserRemovesAllFiltersAndColumnsAndCustomListByUrl()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\?(.*)";

            var originalPart = Regex.Match(currentUrl, pattern).Value;
            _driver.NagigateToURL(currentUrl.Replace(originalPart, String.Empty));

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
            {
                throw new Exception($"500 error was returned after removing all columns from URL");
            }
        }

        [Then(@"""(.*)"" subcategories is displayed for ""(.*)"" category")]
        public void ThenSubcategoriesIsDisplayedForCategory(int subCategoriesCount, string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            var resetButton = columnElement.SearchTextboxResetButton;
            if (resetButton.Displayed())
            {
                resetButton.Click();
            }
            Assert.AreEqual(subCategoriesCount, columnElement.GetSubcategoriesCountByCategoryName(categoryName));
        }

        [Then(@"""(.*)"" subcategory is selected in Column panel")]
        public void ThenSubcategoryIsSelectedInColumnPanel(string subCategoriesName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsTrue(columnElement.SubcategoryIsSelected(subCategoriesName));
        }

        [Then(@"Minimize buttons are displayed for all category in Columns panel")]
        public void ThenMinimizeButtonsAreDisplayedForAllCategoryInColumnsPanel()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            var groupCount = columnElement.GroupTitle.Count;
            Assert.AreEqual(groupCount, columnElement.MinimizeGroupButton.Count, "Minimize buttons are not displayed");
        }

        [Then(@"Maximize buttons are displayed for all category in Columns panel")]
        public void ThenMaximizeButtonsAreDisplayedForAllCategoryInColumnsPanel()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            var groupCount = columnElement.GroupTitle.Count - 1;
            Assert.AreEqual(groupCount, columnElement.MaximizeGroupButton.Count, "Maximize buttons are not displayed");
        }

        [Then(@"Maximize or Minimize button is not displayed for ""(.*)"" category")]
        public void ThenMaximizeOrMinimizeButtonIsNotDisplayedForCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsFalse(columnElement.MaximizeOrMinimizeButtonByCategory(categoryName).Displayed(),
                $"Maximize/Minimize button is displayed for empty {categoryName} category");
        }

        [Then(@"""(.*)"" section is not displayed in the Columns panel")]
        public void ThenSectionIsNotDisplayedInTheColumnsPanel(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsFalse(columnElement.CategoryIsDisplayed(categoryName),
                $"{categoryName} category stil displayed in Column Panel");
        }

        [Then(@"User is expand ""(.*)"" columns category")]
        public void ThenUserIsExpandColumnsCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.ExpandColumnsSectionByName(categoryName);
        }

        [Then(@"""(.*)"" column is added to URL")]
        public void ThenColumnIsAddedToURL(string coolumnName)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\$select=(.*)";
            var urlPartToCheck = Regex.Match(currentUrl, pattern).Groups[1].Value;
            StringAssert.Contains(_convertor.Convert(coolumnName).ToLower(), urlPartToCheck.ToLower());
        }
    }
}