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
    internal class EvergreenJnr_GlobalSearch : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_GlobalSearch(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User type ""(.*)"" in Global Search Field")]
        public void WhenUserTypeInGlobalSearchField(string searchText)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            searchElement.SearchEverythingField.Clear();
            searchElement.SearchEverythingField.SendKeys(searchText);
            _driver.WaitForDataLoading();
        }

        [When(@"User type ""(.*)"" in Global Search Field and presses Enter key")]
        public void WhenUserTypeInGlobalSearchFieldAndPressesEnterKey(string searchText)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            searchElement.SearchEverythingField.Clear();
            searchElement.SearchEverythingField.SendKeys(searchText);
            _driver.WaitForDataLoading();
            searchElement.SearchEverythingField.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        [Then(@"""(.*)"" is displayed below Global Search field")]
        public void ThenIsDisplayedBelowGlobalSearchField(string searchText)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            searchElement.SearchResultName(searchText);
        }

        [Then(@"""(.*)"" rows are displayed on the Global Search")]
        public void ThenRowsAreDisplayedOnTheGlobalSearch(string numberOfRows)
        {
            var listPageElement = _driver.NowAt<GlobalSearchElement>();
            if (!string.IsNullOrWhiteSpace(numberOfRows))
            {
                Thread.Sleep(1000);

                _driver.WaitWhileControlIsNotDisplayed<GlobalSearchElement>(() => listPageElement.ResultsRowsCount);

                StringAssert.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                    listPageElement.ResultsRowsCount.Text, "Incorrect rows count");
                Logger.Write(
                    $"Evergreen Global Search returned the correct number of rows for: {numberOfRows}  search");
            }
            else
            {
                _driver.IsElementDisplayed(listPageElement.ResultsRowsCount);
                _driver.WaitWhileControlIsDisplayed<GlobalSearchElement>(() => listPageElement.ResultsRowsCount);
                Assert.IsFalse(listPageElement.ResultsRowsCount.Displayed(), "Rows count is displayed");
                _driver.WaitWhileControlIsNotDisplayed<GlobalSearchElement>(() => listPageElement.ResultsRowsCount);
                Assert.IsTrue(listPageElement.ResultsRowsCount.Displayed(),
                    "'No Results Found' message not displayed");
                Logger.Write(
                    $"Evergreen agGrid Search returned '{listPageElement.ResultsRowsCount.Text}' message");
            }
        }

        [Then(@"User clicks on ""(.*)"" search result")]
        public void ThenUserClicksOnSearchResult(string searchText)
        {
            var menu = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForDataLoading();
            menu.SearchResult(searchText).Click();
            Logger.Write("Search Result was clicked");
        }

        [Then(@"""(.*)"" message is displayed below Global Search field")]
        public void ThenMessageIsDisplayedBelowGlobalSearchField(string text)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitWhileControlIsNotDisplayed<GlobalSearchElement>(() => searchElement.NoResultFound);
            Assert.AreEqual(text, searchElement.NoResultFound.Text, $"{text} is not displayed");
        }

        [Then(@"""(.*)"" message is not displayed below Global Search field")]
        public void ThenMessageIsNotDisplayedBelowGlobalSearchField(string text)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            Assert.IsFalse(searchElement.NoResultFound.Displayed(), $"{text} is not displayed");
        }

        [Then(@"message ""(.*)"" is displayed to the user below Search results")]
        public void ThenMessageIsDisplayedToTheUserBelowSearchResults(string message)
        {
            var page = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForDataLoading();
            Assert.AreEqual(message, page.NoResultsFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Search results are displayed below Global Search field")]
        public void ThenSearchResultsAreDisplayedBelowGlobalSearchField()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitWhileControlIsNotDisplayed<GlobalSearchElement>(() => searchElement.SearchResults);
            Assert.IsTrue(searchElement.SearchResults.Displayed(), "Search Result are not displayed");
        }

        [Then(@"list of results is displayed to the user")]
        public void ThenListOfResultsIsDisplayedToTheUser()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitWhileControlIsNotDisplayed<GlobalSearchElement>(() => searchElement.TableOfSearchResults);
            Assert.IsTrue(searchElement.TableOfSearchResults.Displayed());
            Assert.IsTrue(searchElement.TableContent.Displayed());
        }

        [Then(@"reset button in Global Search field is displayed")]
        public void ThenResetButtonInGlobalSearchFieldIsDisplayed()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitWhileControlIsNotDisplayed<GlobalSearchElement>(() =>
                searchElement.GlobalSearchTextBoxResetButton);
            Assert.IsTrue(searchElement.GlobalSearchTextBoxResetButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }
    }
}