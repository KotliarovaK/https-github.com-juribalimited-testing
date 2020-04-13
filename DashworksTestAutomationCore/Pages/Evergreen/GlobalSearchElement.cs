using System;
using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class GlobalSearchElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Search everything']")]
        public IWebElement SearchEverythingField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'result-table')]")]
        public IWebElement SearchResults { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]")]
        public IWebElement TableOfSearchResults { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]//div[@ref='eCenterViewport']")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'no-result')]")]
        public IWebElement NoResultFound { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//span[@class='global-show-all-text']")]
        public IWebElement ShowAllResultsLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='content']//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsRowsCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn input-toggle mat-icon-button ')]")]
        public IWebElement GlobalSearchTextBoxResetButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-tab-labels']//div[@cdkmonitorelementfocus][2]//div[@class='mat-tab-label-content']")]
        public IWebElement SearchResultsSecondTab { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.SearchEverythingField)
            };
        }

        public IWebElement SearchResult(string searchText)
        {
            var selector = By.XPath($".//div[contains(@class, 'result-table')]//a[contains(text(), '{searchText}')]");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"'{searchText}' was not found");
            return Driver.FindElement(selector);
        }

        public IWebElement SearchResultName(string searchText)
        {
            return Driver.FindElement(
                By.XPath($".//div[@id='pagetitle-text']//h1[text()='{searchText}']"));
        }

        public IList<IWebElement> GetVersionColumnDataOfSearchResult()
        {
            var selector = By.XPath(".//div[@col-id='version' and @role='gridcell']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElements(selector);
        }

        public IList<IWebElement> GetPackageVersionColumnDataOfGrid()
        {
            var selector = By.XPath(".//div[@col-id='packageVersion' and @role='gridcell']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElements(selector);
        }
    }
}