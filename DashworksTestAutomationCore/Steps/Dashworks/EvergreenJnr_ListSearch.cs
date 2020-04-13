using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ListSearch : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ListSearch(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User perform search by ""(.*)""")]
        public void WhenUserPerformSearchBy(string searchTerm)
        {
            _driver.WaitForDataLoading();
            PerformSearch(searchTerm);
            _driver.WaitForDataLoading();
        }

        [Then(@"User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned")]
        public void ThenUserEntersSearchCriteriaIntoTheAgGridSearchBoxAndTheCorrectNumberOfRowsAreReturned(Table table)
        {
            foreach (var row in table.Rows)
            {
                PerformSearch(row["SearchCriteria"]);

                ThenRowsAreDisplayedInTheAgGrid(row["NumberOfRows"]);
            }
        }

        [Then(@"User enters invalid SearchCriteria into the agGrid Search Box and ""(.*)"" message is displayed")]
        public void ThenUserEntersInvalidSearchCriteriaIntoTheAgGridSearchBoxAndMessageIsDisplayed(string message,
            Table table)
        {
            foreach (var row in table.Rows)
            {
                PerformSearch(row["SearchCriteria"]);

                var page = _driver.NowAt<BaseDashboardPage>();
                _driver.WaitForDataLoading();
                _driver.WaitForElementToBeDisplayed(page.NoResultsFoundMessage);
                Verify.IsTrue(page.NoResultsFoundMessage.Displayed(), $"{message} is not displayed");
                _driver.WaitForDataLoading();
            }
        }

        [Then(@"Clearing the agGrid Search Box")]
        public void ThenClearingTheAgGridSearchBox()
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();

            var inputLength = listPageElement.TableSearchTextBox.GetAttribute("value").Length;
            for (var i = 0; i < inputLength; i++)
                listPageElement.TableSearchTextBox.SendKeys(OpenQA.Selenium.Keys.Backspace);

            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" rows are displayed in the agGrid")]
        public void ThenRowsAreDisplayedInTheAgGrid(string numberOfRows)
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();
            if (!string.IsNullOrWhiteSpace(numberOfRows))
            {
                Thread.Sleep(1000);

                _driver.WaitForElementToBeDisplayed(listPageElement.ResultsOnPageCount);

                Verify.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                    listPageElement.ResultsOnPageCount.Text,
                    "Incorrect rows count");

                Logger.Write(
                    $"Evergreen agGrid Search returned the correct number of rows for: {numberOfRows}  search");
            }
            else
            {
                _driver.IsElementDisplayed(listPageElement.NoResultsFoundMessage);
                _driver.WaitForElementToBeNotDisplayed(listPageElement.ResultsOnPageCount);
                Verify.IsFalse(listPageElement.ResultsOnPageCount.Displayed(), "Rows count is displayed");
                _driver.WaitForElementToBeDisplayed(listPageElement.NoResultsFoundMessage);
                Verify.IsTrue(listPageElement.NoResultsFoundMessage.Displayed(),
                    "'No Results Found' message not displayed");
                Logger.Write(
                    $"Evergreen agGrid Search returned '{listPageElement.NoResultsFoundMessage.Text}' message");
            }
        }

        [Then(@"Search field is empty")]
        public void ThenSearchFieldIsEmpty()
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();

            _driver.WaitForElementToBeDisplayed(listPageElement.ResultsOnPageCount);
            if (listPageElement.TableSearchTextBox.Displayed())
            {
                Verify.IsEmpty(listPageElement.TableSearchTextBox.GetAttribute("value"), "Search textbox is not empty");
            }
            else
            {
                listPageElement.TableSearchButton.Click();
                Verify.IsEmpty(listPageElement.TableSearchTextBox.GetAttribute("value"), "Search textbox is not empty");
            }
        }

        [When(@"User click content from ""(.*)"" column")]
        public void WhenUserClickContentFromColumn(string columnName)
        {
            var tableElement = _driver.NowAtWithoutWait<BaseGridPage>();
            _driver.WaitForDataLoading();
            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks content from first row of Hostname column")]
        public void UserClickContentFromFirstRowOfHostnameColumn()
        {
            var tableElement = _driver.NowAtWithoutWait<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            tableElement.EmptyColumnDataRows.First().Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks content from first row of Device Key column")]
        public void UserClickContentFromFirstRowOfDeviceKeyColumn()
        {
            var tableElement = _driver.NowAtWithoutWait<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            tableElement.DeviceKeyColumnDataRows.First().Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"reset button in Table Search field is displayed")]
        public void ThenResetButtonInTableSearchFieldIsDisplayed()
        {
            var resetButton = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(resetButton.SearchTextBoxResetButton);
            Verify.IsTrue(resetButton.SearchTextBoxResetButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [When(@"User clicks cross icon in Table search field")]
        public void WhenUserClicksCrossIconInTableSearchField()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            button.SearchTextBoxResetButton.Click();
        }

        [Then(@"reset button in Search field at selected Panel is displayed")]
        public void ThenResetButtonInSearchFieldOnSelectedPanelIsDisplayed()
        {
            var resetButton = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(resetButton.SearchTextBoxResetButtonInPanel);

            Verify.IsTrue(resetButton.SearchTextBoxResetButtonInPanel.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [When(@"User apply ""(.*)"" filter to lists panel")]
        public void WhenUserApplyFilterToListsPanel(string filterListName)
        {
            var listsFilter = _driver.NowAt<CustomListElement>();
            listsFilter.DropdownFilterList.Click();
            listsFilter.GetFilterForListsByName(filterListName).Click();
        }

        [Then(@"List filter DDL displays the next options")]
        public void ThenListFilterDDLDisplaysTheNextOptions(Table table)
        {
            var listsFilter = _driver.NowAt<CustomListElement>();
            listsFilter.DropdownFilterList.Click();

            var expectedItems = table.Rows.SelectMany(row => row.Values).ToList();
            var actualItems = listsFilter.GetFilterForListsItemsFromExpandedList().Select(x=>x.Text).ToList();

            Verify.That(expectedItems, Is.EqualTo(actualItems), "Items are different");
            Logger.Write("Items are the same");
        }

        private void PerformSearch(string searchTerm)
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();
            
            if (listPageElement.TableSearchTextBox.Displayed())
            {
                listPageElement.TableSearchTextBox.Clear();
                Thread.Sleep(3000);
                _driver.WaitForDataLoading();
                listPageElement.TableSearchTextBox.SendKeys(searchTerm);
                Thread.Sleep(3000);
                _driver.WaitForDataLoading();
            }
            else
            {
                _driver.WaitForElementToBeDisplayed(listPageElement.TableSearchButton);
                listPageElement.TableSearchButton.Click();
                listPageElement.TableSearchTextBox.Clear();
                Thread.Sleep(3000);
                _driver.WaitForDataLoading();
                listPageElement.TableSearchTextBox.SendKeys(searchTerm);
                Thread.Sleep(5000);
                _driver.WaitForDataLoading();
            }
        }
    }
}