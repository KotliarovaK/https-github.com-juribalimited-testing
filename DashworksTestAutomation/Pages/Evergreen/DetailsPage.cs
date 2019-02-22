﻿using System;
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

        public const string ColumnWithImageAndLinkSelector = ".//div[@col-id='userName'][@role='gridcell']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='tabContainer ng-star-inserted']")]
        public IWebElement TabContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='object-icon']//i")]
        public IWebElement GroupIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='box-counter ng-star-inserted']//span[@class='ng-star-inserted']")]
        public IWebElement RowsLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoFoundContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-tab-body-content ng-trigger ng-trigger-translateTab']")]
        public IWebElement ItemDetailsContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='category-content ng-star-inserted']")]
        public IWebElement SectionContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='fld-value']//span[@class='ng-star-inserted']")]
        public IList<IWebElement> TableRowDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-tab-body//div[contains(@class, 'collapsed')]")]
        public IWebElement OpenedSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']")]
        public IWebElement GraphicInOpenedSection { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@id='aggridHeaderCounter']//span[@class='ng-star-inserted' and count(*)=0]")]
        [FindsBy(How = How.XPath,
            Using =
                ".//table[@class='table projectDetails']/*//span[text()='Evergreen Bucket']/ancestor::tr/td[@class='fld-value']")]
        public IWebElement ProjectSummaryBucketValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-tab-body[contains(@class, 'mat-tab-body')]")]
        public IWebElement PopupChangesPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ag-header-select-all']")]
        public IWebElement SelectAllCheckBox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TabContainer)
            };
        }

        public string GetInstalledBucketWindowWidth()
        {
            return Driver.FindElement(By.XPath("//mat-dialog-container[contains(@class, 'mat-dialog-container')]"))
                .GetCssValue("width");
        }

        public IWebElement NavigateToSectionByName(string sectionName)
        {
            var selector = By.XPath($"//div//span[contains(@class, 'filter-category')][text()='{sectionName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetExpandedSectionByName(string sectionName)
        {
            return Driver.FindElement(
                By.XPath($"//mat-tab-body//div[contains(@class, 'collapsed')]//span[text()='{sectionName}']"));
        }

        public IWebElement GetTextInExpandedSection(string text)
        {
            return Driver.FindElement(
                By.XPath($"//mat-tab-body//div[contains(@class, 'collapsed')]//tr//span[text()='{text}']"));
        }

        public IWebElement GetCellByTextFromKeyValueGrid(string text)
        {
            return Driver.FindElement(By.XPath($".//tbody/*/td/*/span[text()='{text}']"));
        }

        public string GetSelectedText()
        {
            return ((IJavaScriptExecutor) Driver).ExecuteScript("return window.getSelection().toString()").ToString();
        }

        public void ExpandAllSections()
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath(".//i[@class='material-icons mat-item_add mat-18']/ancestor::button"));
            var expandButtons =
                Driver.FindElements(By.XPath(".//i[@class='material-icons mat-item_add mat-18']/ancestor::button"));

            if (!expandButtons.Any()) return;
            foreach (var button in expandButtons)
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

            if (!closeButtons.Any()) return;
            foreach (var button in closeButtons)
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
            var allHeaders = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[1]"))
                .Select(x => x.Text).ToList();
            var allContent = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[2]"))
                .Select(x => x.Text).ToList();

            return allHeaders.Select((t, i) => new KeyValuePair<string, string>(t, allContent[i])).ToList();
        }

        public void CheckThatAllContentIsNotEmpty()
        {
            var allFieldsContent = Driver.FindElements(By.XPath(".//tbody/tr/td[2]"));

            foreach (var element in allFieldsContent) Assert.IsFalse(string.IsNullOrEmpty(element.Text));
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

        public void GetSearchFieldByColumnName(string columnName, string text)
        {
            var byControl =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(text);
        }

        public IWebElement GetContentByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[contains(@class, 'ag-body-container')]/div[1]/div[{GetColumnNumberByName(columnName)}]");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetLinkByName(string linkName)
        {
            var byControl =
                By.XPath($".//a[@href][text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetIconByName(string detailsIconName)
        {
            var byControl =
                By.XPath($".//i[@class='{detailsIconName}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public string GetHrefByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']//a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            var attribute = Driver.FindElement(byControl).GetAttribute("href");
            return attribute;
        }

        private string GetColIdByColumnName(string columnName)
        {
            var by = By.XPath($".//span[text()=\"{columnName}\"]/ancestor::div[@col-id]");
            return Driver.FindElement(by).GetAttribute("col-id");
        }

        public bool IsFieldPresent(string fieldName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ng-star-inserted']//td[@class='fld-label']//span[text()='{fieldName}']"));
        }

        public IWebElement GetValueByName(string value)
        {
            var selector = By.XPath($"//mat-option[@role='option']//span[text()='{value}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetBucketLinkByName(string bucketName)
        {
            var selector = By.XPath($"//div[@class='editText']//span[text()='{bucketName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetUnassignedLinkByFieldName(string fieldName)
        {
            var selector = By.XPath($"//span[text()='{fieldName}']//ancestor::tr//span[text()='Unassigned']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetLinkOnTheDetailsPageByName(string linkName)
        {
            var selector = By.XPath($"//span[text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetChangeValueInPopUpByName(string value)
        {
            var selector = By.XPath($".//label[text()='{value}']/ancestor::mat-form-field");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}