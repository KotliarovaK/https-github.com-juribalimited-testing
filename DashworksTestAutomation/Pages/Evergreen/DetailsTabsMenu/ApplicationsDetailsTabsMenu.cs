﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class ApplicationsDetailsTabsMenu : SeleniumBasePage
    {
        public const string FilterCheckboxBooleanValuesSelector = ".//div[@class='boolean-icon ng-star-inserted']";

        public const string FilterCheckboxStringValuesSelector = ".//span[@class='mat-option-text']//div[@class='ng-star-inserted']";

        public const string FilterTypeOnTheColumnPanel = ".//div[@class='ag-filter']//select[not(contains(@class,'hidden'))]//option";

        [FindsBy(How = How.XPath, Using = ".//div[@class='ng-star-inserted']/span")]
        public IWebElement CheckboxesStringFilter { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//mat-option[@class='selectAllOption mat-option mat-option-multiple ng-star-inserted']")]
        public IWebElement AllCheckboxesSelectedStringFilter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@style= 'opacity: 1;']")]
        public IWebElement StringFilterPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option[contains(@class, 'mat-selected')]")]
        public IWebElement SelectedStringFilters { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='ag-filter-filter']")]
        public IWebElement DateFilterValue { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//mat-option[@class='mat-option mat-option-multiple ng-star-inserted mat-active']")]
        public IWebElement UncheckedStringFilters { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//mat-pseudo-checkbox[@class='mat-option-pseudo-checkbox mat-pseudo-checkbox ng-star-inserted mat-pseudo-checkbox-checked']")]
        public IWebElement SelectedCheckboxStringFilter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='boolean-icon ng-star-inserted']/span")]
        public IWebElement CheckboxesBooleanStringFilter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons pull-right mat-laptop']")]
        public IWebElement DeviceDetailsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[@aria-label='ResetFilters']")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-filter']//select[not(contains(@class,'hidden'))]")]
        public IWebElement FilterTypeDropdownOnTheColumnPanel { get; set; }

        [FindsBy(How = How.XPath, Using = FilterTypeOnTheColumnPanel)]
        public IList<IWebElement> FilterTypeValues { get; set; }

        [FindsBy(How = How.XPath, Using = FilterCheckboxBooleanValuesSelector)]
        public IList<IWebElement> FilterCheckboxBooleanValues { get; set; }

        [FindsBy(How = How.XPath, Using = FilterCheckboxStringValuesSelector)]
        public IList<IWebElement> FilterCheckboxStringValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-icon ag-icon-columns']")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'icon-checkbox')]/ancestor::div[@ref='eSelect']")]
        public IWebElement SelectAllCheckboxOnColumnSettingsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-tab']//span[@class='ag-icon ag-icon-filter']")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-column-select-label']")]
        public IWebElement ColumnCheckboxName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-container')]/div")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-pseudo-checkbox[contains(@class, 'mat-pseudo-checkbox-checked')]")]
        public IWebElement ColumnCheckboxChecked { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-filter-body']//input")]
        public IWebElement FilterSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]//div[@class='ag-center-cols-viewport']//div[@role='row']")]
        public IList<IWebElement> TableRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-filter-body']//input[@aria-label='Date']")]
        public IWebElement DateRegularValueFirst { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateFromConditionPanel']//input[@aria-label='Date']")]
        public IWebElement DateRegularValueSecond { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateFromPanel']//input")]
        public IWebElement DateFromValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateToPanel']//input")]
        public IWebElement DateToValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'ag-menu')]")]
        public IWebElement ColumnSettingsPanel { get; set; }

        public const string SiteColumnSelector = ".//div[@col-id='packageSite']";

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>();
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            var columnSettingsSelector = By.XPath($"//*[text()='{columnName}']/ancestor::div/span[contains(@class, 'cell-menu-button')]");
            Driver.MouseHover(columnSettingsSelector);
            Driver.WaitForElementToBeDisplayed(columnSettingsSelector);
            Driver.FindElement(columnSettingsSelector).Click();
        }

        public bool IsColumnPresent(string columnName)
        {
            var selector = string.Empty;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector =
                    $".//div[@role='presentation']/span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[@role='presentation']/span[text()='{columnName}']";
            }

            return Driver.IsElementDisplayed(By.XPath(selector));
        }

        public int GetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//div[@class='ag-header-container']/div/div");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            if (!allHeaders.Any())
                throw new Exception("Table does not contains any columns");
            var columnNumber =
                allHeaders.IndexOf(allHeaders.First(x =>
                    x.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).Text.Equals(columnName))) + 1;

            return columnNumber;
        }

        public IList<IWebElement> GetCheckboxes()
        {
            var by = By.XPath(".//mat-pseudo-checkbox");
            return Driver.FindElements(by);
        }

        public void GetCheckboxStringFilterByName(string filterName)
        {
            var filterSelector = $"//div[@class='ng-star-inserted']/span[(text()='{filterName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(filterSelector));
            Driver.FindElement(By.XPath(filterSelector)).Click();
        }

        public bool GetStringFilterTextByColumnName(string columnName)
        {
            return Driver.IsElementDisplayed(By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//mat-placeholder[@class='ng-star-inserted'][text()='All']"));
        }

        public IWebElement GetFilterByName(string filterName)
        {
            Driver.WaitForElementToBeDisplayed(By.XPath($".//div[@class='ag-filter']//span[text()='{filterName}']"));
            return Driver.FindElement(By.XPath($".//div[@class='ag-filter']//span[text()='{filterName}']"));
        }

        public IWebElement GetStringFilterByName(string filterName)
        {
            Driver.WaitForElementToBeDisplayed(
                By.XPath($".//div[@class='ng-star-inserted']/span[(text()='{filterName}')]"));
            return Driver.FindElement(By.XPath($".//div[@class='ng-star-inserted']//span[(text()='{filterName}')]"));
        }

        public IWebElement GetBooleanStringFilterByName(string filterName)
        {
            Driver.WaitForElementToBeDisplayed(
                By.XPath($".//div[@class='boolean-icon ng-star-inserted']/span[(text()='{filterName}')]"));
            return Driver.FindElement(
                By.XPath($".//div[@class='boolean-icon ng-star-inserted']/span[(text()='{filterName}')]"));
        }

        public string PackageSiteColumnWidth()
        {
            return Driver.FindElement(By.XPath(".//div[@col-id='packageSite']")).GetCssValue("width");
        }

        public IWebElement GetFilterByColumnName(string columnName)
        {
            var allFilters =
                Driver.FindElements(By.XPath(".//div[@class='aggrid-input-styled']"));
            return allFilters[GetColumnNumberByName(columnName) - 1];
        }

        public List<string> GetCheckedElementsText()
        {
            var by = By.XPath(
                ".//span[@class='ag-checkbox-checked']/parent::*/parent::*");

            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public void GetCheckboxByName(string checkboxName)
        {
            var checkboxSettingsSelector = By.XPath($".//div[@class='ag-column-select-panel']//span[text()='{checkboxName}']");
            Driver.MouseHover(checkboxSettingsSelector);
            Driver.WaitForElementToBeDisplayed(checkboxSettingsSelector);
            Driver.FindElement(checkboxSettingsSelector).Click();
        }

        public IList<IWebElement> GetAllColumnHeadersOnTheDetailsPage()
        {
            var selector = By.XPath(".//span[@role='columnheader']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public bool ColumnIsDisplayed(string columnName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ag-header-cell-label']/span[text()='{columnName}']"));
        }

        public void SelectValueForDateColumn(string dateValue)
        {
            var selectBox = By.XPath(".//select[@class='ag-filter-select']");
            Driver.WaitForElementToBeDisplayed(selectBox);
            Driver.FindElement(selectBox).Click();
            Driver.WaitForElementToBeDisplayed(
                By.XPath($".//select[@class='ag-filter-select']//option[text()='{dateValue}']"));
            var value = By.XPath($".//select[@class='ag-filter-select']//option[text()='{dateValue}']");
            Driver.FindElement(value).Click();
        }

        public void SelectConditionForDateColumn(string filterConditionValue)
        {
            var selectBox = By.XPath(".//select[@class='ag-filter-select']");

            Driver.WaitForElementToBeDisplayed(selectBox);
            Driver.FindElement(selectBox).SelectboxSelect(filterConditionValue);
        }
    }
}