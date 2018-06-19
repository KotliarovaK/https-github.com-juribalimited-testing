using System;
using System.Text.RegularExpressions;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ColumnsPanel : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly RemoteWebDriver _driver;
        private readonly PageToUrlConvertor _page;

        public EvergreenJnr_ColumnsPanel(RemoteWebDriver driver, RestWebClient client, PageToUrlConvertor page)
        {
            _driver = driver;
            _client = client;
            _page = page;
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
                columnElement.SearchTextbox.ClearWithHomeButton(_driver);
            }

            //Minimise the Selected Columns
            //columnElement.MinimizeGroupButton.Click();
            //_driver.WaitWhileControlIsDisplayed<ColumnsElement>(() => columnElement.MinimizeGroupButton);
            //Close the Columns Panel
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            listpageMenu.ColumnButton.Click();
        }

        [When(@"'(.*)' Column Name is entered into the search box and the selection is clicked")]
        public void WhenColumnNameIsEnteredIntoTheSearchBoxAndTheSelectionIsClicked(string columnName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();

            columnElement.AddColumn(columnName);

            //Clear the textbox after adding a column, so it is reset for the next loop
            columnElement.SearchTextbox.ClearWithHomeButton(_driver);

            //Minimise the Selected Columns
            //columnElement.MinimizeGroupButton.Click();
            //_driver.WaitWhileControlIsDisplayed<ColumnsElement>(() => columnElement.MinimizeGroupButton);
            //Close the Columns Panel
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            listpageMenu.ColumnButton.Click();
        }

        [When(@"User adds columns to the list")]
        public void WhenUserAddsColumnsToTheList(Table table)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();

            foreach (var row in table.Rows)
            {
                columnElement.AddColumn(row["ColumnName"]);

                //Clear the textbox after adding a column, so it is reset for the next loop
                columnElement.SearchTextbox.ClearWithHomeButton(_driver);
            }
        }

        [When(@"User add following columns using URL to the ""(.*)"" page:")]
        public void WhenUserAddFollowingColumnsUsingUrlToThePage(string pageName, Table table)
        {
            var requestUri =
                $"{UrlProvider.EvergreenUrl}#/{pageName.ToLower()}?{RestWebClient.GetDefaultColumnsUrlByPageName(pageName)}";
            foreach (var row in table.Rows)
                requestUri += $",{ColumnNameToUrlConvertor.Convert(pageName, row["ColumnName"])}";
            _driver.NavigateToUrl(requestUri);
            _driver.WaitForDataLoading();
            CheckColumnDisplayedState(table, true);
        }

        [When(@"User add following columns using current URL on ""(.*)"" page:")]
        public void WhenUserAddFollowingColumnsUsingCurrentUrlOnPage(string pageName, Table table)
        {
            var currentUrl = _driver.Url;
            var pattern = currentUrl.Contains("&$orderby=") ? @"select=(.*)&" : @"select=(.*)";

            var originalPart = string.Empty;
            var changedPart = string.Empty;
            foreach (var row in table.Rows)
            {
                originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
                changedPart = originalPart + $",{ColumnNameToUrlConvertor.Convert(pageName, row["ColumnName"])}";
            }

            _driver.NavigateToUrl(currentUrl.Replace(originalPart, changedPart));
            _driver.WaitForDataLoading();
            CheckColumnDisplayedState(table, true);
        }

        [Then(@"ColumnName is added to the list")]
        public void ThenColumnNameIsAddedToTheList(Table table)
        {
            _driver.WaitForDataLoading();
            CheckColumnDisplayedState(table, true);
        }

        [Then(@"ColumnName is removed from the list")]
        public void ThenColumnNameIsRemovedFromTheList(Table table)
        {
            _driver.WaitForDataLoading();
            CheckColumnDisplayedState(table, false);
        }

        private void CheckColumnDisplayedState(Table table, bool displayedState)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            listpageMenu.RefreshTableButton.Click();
            _driver.WaitForDataLoading();
            Thread.Sleep(1000);
            foreach (var row in table.Rows)
                Assert.AreEqual(displayedState, listpageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' displayed state should be {displayedState}");
        }

        [When(@"User add all Columns from specific category")]
        public void WhenUserAddAllColumnsFromSpecificCategory(Table table)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();

            foreach (var row in table.Rows) columnElement.AddAllColumnsFromCategory(row["CategoryName"]);
        }

        [When(@"User add ""(.*)"" Column from expanded category")]
        public void WhenUserAddColumnFromExpandedCategory(string columnName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.AddColumnFromExpandedSection(columnName);
        }

        [When(@"User removes ""(.*)"" column by Column panel")]
        public void WhenUserRemovesColumnByColumnPanel(string columnName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.ExpandColumnsSectionByName("Selected Columns");
            columnElement.GetDeleteColumnButton(columnName).Click();
        }

        [When(@"User removes ColumnName column by Column panel")]
        public void WhenUserRemovesColumnNameColumnByColumnPanel(Table table)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            columnElement.ExpandColumnsSectionByName("Selected Columns");
            foreach (var row in table.Rows) columnElement.GetDeleteColumnButton(row["ColumnName"]).Click();
        }

        [When(@"User have reset all columns")]
        public void WhenUserHaveResetAllColumns()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ColumnsElement>(() => columnElement.ResetColumnsButton);
            _driver.MouseHover(columnElement.ResetColumnsButton);
            columnElement.ResetColumnsButton.Click();
        }

        [When(@"User remove column on ""(.*)"" page by URL")]
        public void WhenUserRemoveColumnOnPageByURL(string pageName, Table table)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"select=(.*)";
            foreach (var row in table.Rows)
            {
                var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
                var changedPart =
                    originalPart.Replace($",{ColumnNameToUrlConvertor.Convert(pageName, row["ColumnName"])}",
                        string.Empty);
                _driver.NavigateToUrl(currentUrl.Replace(originalPart, changedPart));

                var page = _driver.NowAt<EvergreenDashboardsPage>();
                if (page.StatusCodeLabel.Displayed())
                    throw new Exception($"500 error was returned for: {row["ColumnName"]} column");
            }
        }

        [Then(@"Ascending order sorted on ""(.*)"" column is displayed in URL")]
        public void ThenAscendingOrderSortedOnColumnIsDisplayedInURL(string columnName)
        {
            var currentUrl = _driver.Url;
            var sorting = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(sorting.AscendingSortingIcon.Displayed(), "Ascending icon is not displayed");
            StringAssert.Contains("%20asc", currentUrl, columnName);
        }

        [Then(@"default URL is displayed on ""(.*)"" page")]
        public void ThenDefaultURLIsDisplayedOnPage(string pageName)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"evergreen\/#\/(.*)";
            var currentPageName = Regex.Match(currentUrl, pattern).Groups[1].Value;
            Assert.AreEqual(currentPageName, pageName.ToLower(), "Incorrect Page Name in URL");
        }

        [When(@"User remove sorted column on ""(.*)"" page by URL")]
        public void WhenUserRemoveSortedColumnOnPageByUrl(string pageName, Table table)
        {
            _driver.WaitForDataLoading();
            var currentUrl = _driver.Url;
            const string pattern = @"select=(.*)\&\$orderby";
            foreach (var row in table.Rows)
            {
                var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
                var changedPart =
                    originalPart.Replace($",{ColumnNameToUrlConvertor.Convert(pageName, row["ColumnName"])}",
                        string.Empty);
                _driver.NavigateToUrl(currentUrl.Replace(originalPart, changedPart));

                var page = _driver.NowAt<EvergreenDashboardsPage>();
                if (page.StatusCodeLabel.Displayed())
                    throw new Exception($"500 error was returned for: {row["ColumnName"]} column");
            }
        }

        [When(@"User removes all columns by URL")]
        public void WhenUserRemovesAllColumnsByUrl()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"select=(.*)";

            var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
            _driver.NavigateToUrl(currentUrl.Replace(originalPart, string.Empty));

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
                throw new Exception("500 error was returned after removing all columns from URL");
        }

        [When(@"User removes all filters and columns by url")]
        public void WhenUserRemovesAllFiltersAndColumnsByUrl()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\&(.*)";

            var originalPart = Regex.Match(currentUrl, pattern).Value;
            _driver.NavigateToUrl(currentUrl.Replace(originalPart, string.Empty));

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
                throw new Exception("500 error was returned after removing all columns from URL");
        }

        [When(@"User removes all filters and columns and custom list by url")]
        public void WhenUserRemovesAllFiltersAndColumnsAndCustomListByUrl()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\?(.*)";

            var originalPart = Regex.Match(currentUrl, pattern).Value;
            _driver.NavigateToUrl(currentUrl.Replace(originalPart, string.Empty));

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
                throw new Exception("500 error was returned after removing all columns from URL");
        }

        [Then(@"""(.*)"" subcategories is displayed for ""(.*)"" category")]
        public void ThenSubcategoriesIsDisplayedForCategory(int subCategoriesCount, string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            var resetButton = columnElement.SearchTextboxResetButton;
            if (resetButton.Displayed()) resetButton.Click();

            Assert.AreEqual(subCategoriesCount, columnElement.GetSubcategoriesCountByCategoryName(categoryName),
                $"Incorrect subcategories count for {categoryName} category");
        }

        [Then(@"""(.*)"" subcategory is selected in Column panel")]
        public void ThenSubcategoryIsSelectedInColumnPanel(string subCategoriesName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsTrue(columnElement.SubcategoryIsSelected(subCategoriesName),
                $"{subCategoriesName} is not selected");
        }

        [Then(@"Minimize buttons are displayed for all category in Columns panel")]
        public void ThenMinimizeButtonsAreDisplayedForAllCategoryInColumnsPanel()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            var groupCount = columnElement.GroupTitle.Count;
            Assert.AreEqual(groupCount, columnElement.MinimizeGroupButton.Count, "Minimize buttons are not displayed");
        }

        [When(@"User close all columns categories")]
        public void WhenUserCloseAllColumnsCategories()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var group in columnElement.GroupTitle)
            {
                if (group.Text.Contains("Selected Columns"))
                    continue;
                group.Click();
            }
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

        [Then(@"Minimize button is displayed for ""(.*)"" category")]
        public void ThenMinimizeButtonIsDisplayedForCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsTrue(columnElement.MinimizeButtonByCategory(categoryName).Displayed(),
                $"Minimize button is not displayed for {categoryName} category");
        }

        [Then(@"Maximize button is displayed for ""(.*)"" category")]
        public void ThenMaximizeButtonIsDisplayedForCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsTrue(columnElement.MaximizeButtonByCategory(categoryName).Displayed(),
                $"Maximize button is not displayed for {categoryName} category");
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

        [Then(@"Lowest value of ""(.*)"" column is null")]
        public void ThenLowestValueOfColumnIsNull(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var content = page.GetColumnContent(columnName);
            Assert.IsFalse(content.Contains("-1"), "The Lowest value is not null");
        }

        [Then(@"""(.*)"" column is added to URL on ""(.*)"" page")]
        public void ThenColumnIsAddedToURLOnPage(string columnName, string pageName)
        {
            _driver.WaitForDataLoading();
            var currentUrl = _driver.Url;
            const string pattern = @"\$select=(.*)";
            var urlPartToCheck = Regex.Match(currentUrl, pattern).Groups[1].Value;
            StringAssert.Contains(ColumnNameToUrlConvertor.Convert(pageName, columnName).ToLower(),
                urlPartToCheck.ToLower(),
                $"{columnName} is not added to URL");
        }
    }
}