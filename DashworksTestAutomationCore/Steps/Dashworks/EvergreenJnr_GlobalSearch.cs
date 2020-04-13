using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

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

        [When(@"User presses Enter key in in Global Search Field")]
        public void WhenUserPressesEnterInGlobalSearchField()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
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

                _driver.WaitForElementToBeDisplayed(listPageElement.ResultsRowsCount);

                Verify.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                    listPageElement.ResultsRowsCount.Text, "Incorrect rows count");
                Logger.Write(
                    $"Evergreen Global Search returned the correct number of rows for: {numberOfRows}  search");
            }
            else
            {
                _driver.IsElementDisplayed(listPageElement.ResultsRowsCount);
                _driver.WaitForElementToBeNotDisplayed(listPageElement.ResultsRowsCount);
                Verify.IsFalse(listPageElement.ResultsRowsCount.Displayed(), "Rows count is displayed");
                _driver.WaitForElementToBeDisplayed(listPageElement.ResultsRowsCount);
                Verify.IsTrue(listPageElement.ResultsRowsCount.Displayed(),
                    "'No Results Found' message not displayed");
                Logger.Write(
                    $"Evergreen agGrid Search returned '{listPageElement.ResultsRowsCount.Text}' message");
            }
        }

        //TODO Remove this
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
            _driver.WaitForElementToBeDisplayed(searchElement.NoResultFound);
            Verify.AreEqual(text, searchElement.NoResultFound.Text, $"{text} is not displayed");
        }

        [Then(@"'(.*)' label is displayed below Global Search field")]
        public void ThenSeeAllResultsLabelIsDisplayedBelowGlobalSearchField(string label)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForElementToBeDisplayed(searchElement.ShowAllResultsLabel);

            Verify.AreEqual(label, searchElement.ShowAllResultsLabel.Text, $"{label} is not displayed");
        }

        [Then(@"""(.*)"" message is not displayed below Global Search field")]
        public void ThenMessageIsNotDisplayedBelowGlobalSearchField(string text)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            Verify.IsFalse(searchElement.NoResultFound.Displayed(), $"{text} is not displayed");
        }

        [Then(@"message ""(.*)"" is displayed to the user below Search results")]
        public void ThenMessageIsDisplayedToTheUserBelowSearchResults(string message)
        {
            var page = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForDataLoading();
            Verify.AreEqual(message, page.NoResultsFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Search results are displayed below Global Search field")]
        public void ThenSearchResultsAreDisplayedBelowGlobalSearchField()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForElementToBeDisplayed(searchElement.SearchResults);
            Verify.IsTrue(searchElement.SearchResults.Displayed(), "Search Result are not displayed");
        }

        [Then(@"list of results is displayed to the user")]
        public void ThenListOfResultsIsDisplayedToTheUser()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForElementToBeDisplayed(searchElement.TableOfSearchResults);
            Verify.IsTrue(searchElement.TableOfSearchResults.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Verify.IsTrue(searchElement.TableContent.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"reset button in Global Search field is displayed")]
        public void ThenResetButtonInGlobalSearchFieldIsDisplayed()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForElementToBeDisplayed(searchElement.GlobalSearchTextBoxResetButton);
            Verify.IsTrue(searchElement.GlobalSearchTextBoxResetButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [When(@"User navigates to second tab of Search Results")]
        public void UserNavigatesToSecondTabOfSearchResults()
        {
            var searchResult = _driver.NowAt<GlobalSearchElement>();
            searchResult.SearchResultsSecondTab.Click();
            _driver.WaitForDataLoading();
        }
        
        [Then(@"Version column of Search Results has no Unknown item")]
        public void ThenVersionColumnOfSearchResultsHasNoUnknownItem()
        {
            var page = _driver.NowAt<GlobalSearchElement>();

            var listOfValues = page.GetVersionColumnDataOfSearchResult().Select(x => x.Text).ToList();

            Verify.That(listOfValues, Does.Not.Contain("Unknown"), "Unknown item displayed in column");
            Verify.That(listOfValues, Does.Not.Contain("[9999999]"), "[9999999] item displayed in column");
        }

        [Then(@"Package Version column of Search Results has no Unknown item")]
        public void ThenPackageVersionColumnOfSearchResultsHasNoUnknownItem()
        {
            var page = _driver.NowAt<GlobalSearchElement>();

            var listOfValues = page.GetPackageVersionColumnDataOfGrid().Select(x => x.Text).ToList();

            Verify.That(listOfValues, Does.Not.Contain("Unknown"), "Unknown item displayed in column");
            Verify.That(listOfValues, Does.Not.Contain("[9999999]"), "[9999999] item displayed in column");
        }

        
    }
}