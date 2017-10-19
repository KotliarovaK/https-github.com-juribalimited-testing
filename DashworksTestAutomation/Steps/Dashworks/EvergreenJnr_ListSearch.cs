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
            var listPageElement = _driver.NowAt<BaseDashbordPage>();

            listPageElement.SearchTextbox.Clear();
            _driver.WaitForDataLoading();
            listPageElement.SearchTextbox.SendKeys(searchTerm);
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
        public void ThenUserEntersInvalidSearchCriteriaIntoTheAgGridSearchBoxAndMessageIsDisplayed(string message, Table table)
        {
            foreach (var row in table.Rows)
            {
                PerformSearch(row["SearchCriteria"]);

                var page = _driver.NowAt<BaseDashbordPage>();

                Assert.AreEqual(message, page.NoResultsFoundMessage.Text);
            }
        }

        [Then(@"Clearing the agGrid Search Box")]
        public void ThenClearingTheAgGridSearchBox()
        {
            var listPageElement = _driver.NowAt<BaseDashbordPage>();

            var inputLength = listPageElement.SearchTextbox.GetAttribute("value").Length;
            for (int i = 0; i < inputLength; i++)
            {
                listPageElement.SearchTextbox.SendKeys(OpenQA.Selenium.Keys.Backspace);
            }
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" rows are displayed in the agGrid")]
        public void ThenRowsAreDisplayedInTheAgGrid(string numberOfRows)
        {
            var listPageElement = _driver.NowAt<BaseDashbordPage>();

            _driver.WaitWhileControlIsNotDisplayed<BaseDashbordPage>(()=> listPageElement.ResultsOnPageCount);

            StringAssert.AreEqualIgnoringCase($"{numberOfRows} rows", listPageElement.ResultsOnPageCount.Text);
            Logger.Write($"Evergreen agGrid Search returned the correct number of rows for: {numberOfRows}  search");
        }
    }
}
