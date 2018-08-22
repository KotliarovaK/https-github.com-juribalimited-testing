using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-container')]/div")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'no-result')]")]
        public IWebElement NoResultFound { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsRowsCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn input-toggle mat-icon-button ng-star-inserted']")]
        public IWebElement SearchTextboxResetButton { get; set; }

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
            return Driver.FindElement(
                By.XPath($".//div[contains(@class, 'result-table')]//a[contains(text(), '{searchText}')]"));
        }

        public IWebElement SearchResultName(string searchText)
        {
            return Driver.FindElement(
                By.XPath($".//div[@id='pagetitle-text']/pagetitle-text/h1[text()='{searchText}']"));
        }
    }
}