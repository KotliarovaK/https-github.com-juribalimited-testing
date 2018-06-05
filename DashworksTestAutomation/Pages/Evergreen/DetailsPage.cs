using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class DetailsPage : SeleniumBasePage
    {
        public const string ItemImageSelector = ".//i";

        public const string LinkSelector = ".//a";

        public const string ColumnWithImageAndLinkSelector = ".//div[@col-id='userName'][@role='gridcell']";

        public const string TableContent = ".//div[@class='ag-cell ag-cell-not-inline-editing ag-cell-with-height ag-cell-no-focus ag-cell-value']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='tabContainer ng-star-inserted']")]
        public IWebElement TabContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']/div/div/span/a[@href]")]
        public IWebElement ColumnWithLinkSelector { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='object-icon']//i")]
        public IWebElement GroupIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoFoundContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-tab-body-content ng-trigger ng-trigger-translateTab']")]
        public IWebElement ItemDetailsContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='category-content ng-star-inserted']")]
        public IWebElement SectionContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-person']")]
        public IWebElement ColumnItemImage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='category-content ng-star-inserted']")]
        public IWebElement TableContentDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='fld-value']//span[@class='ng-star-inserted']")]
        public IWebElement UnknownTextField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='fld-value']//span[@class='ng-star-inserted']")]
        public IList<IWebElement> TableRowDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='agGridTable']")]
        public IWebElement OpenedSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']")]
        public IWebElement GraphicInOpenedSection { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TabContainer)
            };
        }

        public void NavigateToSectionByName(string sectionName)
        {
            var section = Driver.FindElement(
                By.XPath(
                    $".//div[@class='ng-star-inserted']//span[@class='filter-category-label blue-color bold-text'][text()='{sectionName}']"));
            section.Click();
        }

        public IWebElement NavigateToFieldByName(string fieldName)
        {
            return Driver.FindElement(
                By.XPath($".//div[@class='ng-star-inserted']//td[@class='fld-label']//span[text()='{fieldName}']"));
        }

        public void ExpandAllSections()
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath(".//i[@class='material-icons mat-item_add mat-18']/ancestor::button"));
            var expandButtons =
                Driver.FindElements(By.XPath(".//i[@class='material-icons mat-item_add mat-18']/ancestor::button"));

            if (expandButtons.Any())
                foreach (IWebElement button in expandButtons)
                {
                    //Driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => button);
                    Driver.MouseHover(button);
                    button.Click();
                    Driver.WaitForDataLoading();
                }
        }

        public void CloseAllSections()
        {
            var closeButtons =
                Driver.FindElements(By.XPath(".//button[@aria-describedby='cdk-describedby-message-25']"));

            if (closeButtons.Any())
                foreach (IWebElement button in closeButtons)
                {
                    Driver.MouseHover(button);
                    button.Click();
                    Driver.WaitForDataLoading();
                }
        }

        public List<KeyValuePair<string, string>> GetFieldsWithContent(string categoryName)
        {
            //Hover on header to be able to see all table with all values
            //In other case elements outside the bounds of the screen will have empty text
            Driver.MouseHover(By.XPath(
                $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']"));
            List<string> allHeaders = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[1]"))
                .Select(x => x.Text).ToList();
            List<string> allContent = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[2]"))
                .Select(x => x.Text).ToList();

            return allHeaders.Select((t, i) => new KeyValuePair<string, string>(t, allContent[i])).ToList();
        }

        public void CheckThatAllContentIsNotEmpty()
        {
            var allFieldsContent = Driver.FindElements(By.XPath(".//tbody/tr/td[2]"));

            foreach (IWebElement element in allFieldsContent) Assert.IsFalse(string.IsNullOrEmpty(element.Text));
        }

        public int GetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//div[@class='ag-header-container']/div/div");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            if (!allHeaders.Any())
                throw new Exception("Table does not contains any columns");
            var columnNumber =
                allHeaders.IndexOf(allHeaders.First(x =>
                    x.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).Text.Equals(columnName))) + 1;

            return columnNumber;
        }

        public IWebElement GetContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetLinkByName(string linkName)
        {
            By byControl =
                By.XPath($".//a[@href][text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetIconByName(string detailsIconName)
        {
            By byControl =
                By.XPath($".//i[@class='{detailsIconName}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public string GetHrefByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]/span/div/a[@href]");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            var attribute = Driver.FindElement(byControl).GetAttribute("href");
            return attribute;
        }

        public bool IsFieldPresent(string fieldName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ng-star-inserted']//td[@class='fld-label']//span[text()='{fieldName}']"));
        }
    }
}