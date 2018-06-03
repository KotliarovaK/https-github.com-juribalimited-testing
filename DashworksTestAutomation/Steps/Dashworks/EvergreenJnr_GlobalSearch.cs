using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_GlobalSearch
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
            searchElement.SearchEverythingField.SendKeys(Keys.Enter);
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
            var searchElement = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => searchElement.SearchTextboxResetButton);
            Assert.IsTrue(searchElement.SearchTextboxResetButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }
    }
}