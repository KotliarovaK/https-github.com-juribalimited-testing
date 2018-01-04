using System;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ListSearch : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ListSearch(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        private void PerformSearch(string searchTerm)
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();

            listPageElement.TableSearchTextbox.Clear();
            _driver.WaitForDataLoading();
            listPageElement.TableSearchTextbox.SendKeys(searchTerm);
            _driver.WaitForDataLoading();
        }

        [When(@"User perform search by ""(.*)""")]
        public void WhenUserPerformSearchBy(string searchTerm)
        {
            PerformSearch(searchTerm);
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
                _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.NoResultsFoundMessage);
                Assert.AreEqual(message, page.NoResultsFoundMessage.Text);
            }
        }

        [Then(@"Clearing the agGrid Search Box")]
        public void ThenClearingTheAgGridSearchBox()
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();

            var inputLength = listPageElement.TableSearchTextbox.GetAttribute("value").Length;
            for (int i = 0; i < inputLength; i++)
            {
                listPageElement.TableSearchTextbox.SendKeys(OpenQA.Selenium.Keys.Backspace);
            }
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" rows are displayed in the agGrid")]
        public void ThenRowsAreDisplayedInTheAgGrid(string numberOfRows)
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();
            if (!String.IsNullOrWhiteSpace(numberOfRows))
            {
                Thread.Sleep(1000);

                _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => listPageElement.ResultsOnPageCount);

                StringAssert.AreEqualIgnoringCase($"{numberOfRows} rows", listPageElement.ResultsOnPageCount.Text);
                Logger.Write(
                    $"Evergreen agGrid Search returned the correct number of rows for: {numberOfRows}  search");
            }
            else
            {
                _driver.IsElementDisplayed(listPageElement.NoResultsFoundMessage);
                Logger.Write(
                    $"Evergreen agGrid Search returned '{listPageElement.NoResultsFoundMessage.Text}' message");
            }
        }

        [Then(@"Search field is empty")]
        public void ThenSearchFieldIsEmpty()
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();

            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => listPageElement.ResultsOnPageCount);
            Assert.IsEmpty(listPageElement.TableSearchTextbox.GetAttribute("value"), "Search textbox is not empty");
        }

        [When(@"User click content from ""(.*)"" column")]
        public void WhenUserClickContentFromColumn(string columnName)
        {
            var tableElement = _driver.NowAtWithoutWait<BaseDashboardPage>();

            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
        }

        [Then(@"reset button in Table Search field is displayed")]
        public void ThenResetButtonInTableSearchFieldIsDisplayed()
        {
            var resetbutton = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => resetbutton.SearchTextboxResetButton);
            Assert.IsTrue(resetbutton.SearchTextboxResetButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [Then(@"reset button in Search field at selected Panel is displayed")]
        public void ThenResetButtonInSearchFieldOnSelectedPanelIsDisplayed()
        {
            var resetbutton = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => resetbutton.SearchTextboxResetButtonInPanel);
            Assert.IsTrue(resetbutton.SearchTextboxResetButtonInPanel.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }
    }
}