﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class ApplicationsDetailsTabsMenu : SeleniumBasePage
    {
        public const string FilterCheckboxValuesSelector = ".//div[@class='boolean-icon ng-star-inserted']";

        public const string FilterTypeOnTheColumnPanel = "//div//select[@id='filterType']//option";

        public const string Checkboxes = ".//mat-pseudo-checkbox";

        [FindsBy(How = How.XPath,
            Using =
                ".//span[text()='Application Summary']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationSummarySection { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//span[text()='Application Detail']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationDetailSection { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//span[text()='Advertisements']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement AdvertisementsSection { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//span[text()='Collections']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement CollectionsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-arrow']")]
        public IWebElement StringFilter { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//body")]
        public IWebElement BodyContainer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//select[@id='filterType']")]
        public IWebElement FilterTypeDropdownOnTheColumnPanel { get; set; }

        [FindsBy(How = How.XPath, Using = FilterTypeOnTheColumnPanel)]
        public IList<IWebElement> FilterTypeValues { get; set; }

        [FindsBy(How = How.XPath, Using = FilterCheckboxValuesSelector)]
        public IList<IWebElement> FilterCheckboxValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-icon ag-icon-columns']")]
        public IWebElement ColumnButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateFromPanel']//input[@aria-label='Date']")]
        public IWebElement DateRegularValueFirst { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateFromConditionPanel']//input[@aria-label='Date']")]
        public IWebElement DateRegularValueSecond { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateFromPanel']/input")]
        public IWebElement DateFromValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='filterDateToPanel']/input")]
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
            var columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
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
            Driver.WaitWhileControlIsNotDisplayed(allHeadersSelector);
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

        public void GetStringFilterByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}][@aria-hidden='true']");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public void GetCheckboxStringFilterByName(string filterName)
        {
            var filterSelector = $"//div[@class='ng-star-inserted']/span[(text()='{filterName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(filterSelector));
            Driver.FindElement(By.XPath(filterSelector)).Click();
        }

        public bool GetStringFilterTextByColumnName(string columnName)
        {
            return Driver.IsElementDisplayed(
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//mat-placeholder[@class='ng-star-inserted'][text()='All']"));
        }

        public IWebElement GetFilterByName(string filterName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//div[@class='ag-filter']//span[text()='{filterName}']"));
            return Driver.FindElement(By.XPath($".//div[@class='ag-filter']//span[text()='{filterName}']"));
        }

        public IWebElement GetStringFilterByName(string filterName)
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath($".//div[@class='ng-star-inserted']/span[(text()='{filterName}')]"));
            return Driver.FindElement(By.XPath($".//div[@class='ng-star-inserted']//span[(text()='{filterName}')]"));
        }

        public IWebElement GetBooleanStringFilterByName(string filterName)
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath($".//div[@class='boolean-icon ng-star-inserted']/span[(text()='{filterName}')]"));
            return Driver.FindElement(
                By.XPath($".//div[@class='boolean-icon ng-star-inserted']/span[(text()='{filterName}')]"));
        }

        public string GetInstalledFilterPanelHeight()
        {
            return Driver.FindElement(By.XPath(".//div[contains(@class, 'ag-menu')]")).GetCssValue("height");
        }

        public string CollectionSiteColumnWidth()
        {
            return Driver.FindElement(By.XPath(".//div[@col-id='collectionSite']")).GetCssValue("width");
        }

        public string PackageSiteColumnWidth()
        {
            return Driver.FindElement(By.XPath(".//div[@col-id='packageSite']")).GetCssValue("width");
        }

        public string GetInstalledFilterPanelWidth()
        {
            return Driver.FindElement(By.XPath(".//div[contains(@class, 'ag-menu')]")).GetCssValue("width");
        }

        public List<string> GetColumnIdContent(string columnName)
        {
            var by = By.XPath(
                $".//div[contains(@class, 'ag-body-viewport')]//div[@col-id='{GetColumnIdByColumnName(columnName)}']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public string GetColumnIdByColumnName(string columnName)
        {
            var headerSelector =
                By.XPath($".//div[@class='ag-header-container']//span[text()='{columnName}']//ancestor::div[@col-id]");
            Driver.WaitForDataLoading();
            return Driver.FindElement(headerSelector).GetAttribute("col-id");
        }

        public IWebElement GetSettingByNameDetailsPage(string settingName)
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath($".//span[@class='ag-menu-option-text'][text()='{settingName}']"));
            return Driver.FindElement(By.XPath($".//span[@id='eName'][text()='{settingName}']"));
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

        public void ClosesSectionByName(string sectionName)
        {
            var section = Driver.FindElement(
                By.XPath(
                    $".//button[@class='btn btn-default blue-color mat-icon-button ng-star-inserted'][@aria-label='{sectionName}']"));
            section.Click();
        }

        public void GetCheckboxByName(string checkboxName)
        {
            var checkboxSettingsSelector = $".//div[@class='ag-column-select-panel']//span[text()='{checkboxName}']";
            Driver.MouseHover(By.XPath(checkboxSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(checkboxSettingsSelector));
            Driver.FindElement(By.XPath(checkboxSettingsSelector)).Click();
        }

        public IList<IWebElement> GetAllColumnHeadersOnTheDetailsPage()
        {
            var selector = By.XPath(".//span[@role='columnheader']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public void FilterValuesCheckbox(string checkboxName)
        {
            var filterCheckboxSelector =
                $".//div[@class='boolean-icon ng-star-inserted']/span[text()='{checkboxName}']";
            //Driver.MouseHover(By.XPath(filterCheckboxSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(filterCheckboxSelector));
        }

        public bool ColumnIsDisplayed(string columnName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ag-header-cell-label']/span[text()='{columnName}']"));
        }

        public void SelectValueForDateColumn(string dateValue)
        {
            var selectBox = By.XPath(".//select[@class='ag-filter-select']");
            Driver.WaitWhileControlIsNotDisplayed(selectBox);
            Driver.FindElement(selectBox).Click();
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath($".//select[@class='ag-filter-select']//option[text()='{dateValue}']"));
            var value = By.XPath($".//select[@class='ag-filter-select']//option[text()='{dateValue}']");
            Driver.FindElement(value).Click();
        }

        public void SelectConditionForDateColumn(string filterConditionValue)
        {
            var selectBox = By.XPath(".//select[@id='filterType']");

            Driver.WaitWhileControlIsNotDisplayed(selectBox);
            Driver.FindElement(selectBox).SelectboxSelect(filterConditionValue);
        }

    }
}