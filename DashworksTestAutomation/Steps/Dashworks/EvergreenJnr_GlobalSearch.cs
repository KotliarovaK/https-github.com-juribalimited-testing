﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_GlobalSearch
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
        
        [Then(@"""(.*)"" message is displayed below Global Search field")]
        public void ThenMessageIsDisplayedBelowGlobalSearchField(string text)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            Assert.AreEqual(text, searchElement.NoResultFound.Text);
        }
        
        [Then(@"Search results are displayed below Global Search field")]
        public void ThenSearchResultsAreDisplayedBelowGlobalSearchField()
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            Assert.IsTrue(searchElement.SearchResults.Displayed(), "Search Result are not displayed");
        }
    }
}
