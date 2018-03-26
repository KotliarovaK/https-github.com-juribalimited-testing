using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class ApplicationsDetailsTabsMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using =".//span[text()='Application Summary']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationSummarySection { get; set; }

        [FindsBy(How = How.XPath, Using =".//span[text()='Application Detail']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationDetailSection { get; set; }

        [FindsBy(How = How.XPath, Using =".//span[text()='Advertisements']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement AdvertisementsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Collections']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement CollectionsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-arrow']")]
        public IWebElement StringFilter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-icon ag-icon-columns']")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-tab']//span[@class='ag-icon ag-icon-filter']")]
        public IWebElement FilterButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-column-select-label']")]
        public IWebElement ColumnCheckboxName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-pseudo-checkbox[@class='mat-option-pseudo-checkbox mat-pseudo-checkbox ng-star-inserted mat-pseudo-checkbox-checked']")]
        public IWebElement ColumnCheckboxChecked { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-filter-body']//input")]
        public IWebElement FilterSearchTextbox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                //SelectorFor(this, p => p.ApplicationSummarySection),
                //SelectorFor(this, p => p.ApplicationDetailSection),
                //SelectorFor(this, p => p.AdvertisementsSection),
                //SelectorFor(this, p => p.CollectionsSection),
            };
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector = 
                $".//div[@role='presentation']/span[text()='{columnName}']/ancestor::div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eMenu']";
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
                selector = $".//div[@role='presentation']/span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[@role='presentation']/span[text()='{columnName}']";
            }
            return Driver.IsElementDisplayed(By.XPath(selector));
        }

        public List<string> GetColumnContent(string columnName)
        {
            By by = By.XPath(
                $".//div[@class='ag-body']//div[@class='ag-body-container']/div/div[{GetColumnNumberByName(columnName)}]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
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

        public void GetStringFilterByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}][@aria-hidden='true']");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public IWebElement GetFilterByName(string filterName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//div[@class='ag-filter']//span[text()='{filterName}']"));
            return Driver.FindElement(By.XPath($".//div[@class='ag-filter']//span[text()='{filterName}']"));
        }

        public IWebElement GetStringFilterByName(string filterName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//div[@class='ng-star-inserted']/span[(text()='{filterName}')]"));
            return Driver.FindElement(By.XPath($".//div[@class='ng-star-inserted']/span[(text()='{filterName}')]"));
        }

        public string GetInstalledFilterPanelHeight()
        {
            return Driver.FindElement(By.XPath(".//div[@class='ag-menu']")).GetCssValue("height");
        }

        public string CollectionSiteColumnWidt()
        {
            return Driver.FindElement(By.XPath(".//div[@col-id='collectionSite']")).GetCssValue("width");
        }

        public string PackageSiteColumnWidt()
        {
            return Driver.FindElement(By.XPath(".//div[@col-id='packageSite']")).GetCssValue("width");
        }

        public string GetInstalledFilterPanelWidth()
        {
            return Driver.FindElement(By.XPath(".//div[@class='ag-menu']")).GetCssValue("width");
        }

        public List<string> GetColumnIdContent(string columnName)
        {
            By by = By.XPath(
                $".//div[@class='ag-body']//div[@class='ag-body-container']/div/div[@col-id='{GetColumnIdByColumnName(columnName)}']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public string GetColumnIdByColumnName(string columnName)
        {
            var headerSelector = By.XPath($".//div[@class='ag-header-container']//span[text()='{columnName}']//ancestor::div[@col-id]");
            Driver.WaitForDataLoading();
            return Driver.FindElement(headerSelector).GetAttribute("col-id");
        }

        public IWebElement GetSettingByNameDetailsPage(string settingName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//span[@class='ag-menu-option-text'][text()='{settingName}']"));
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
            By by = By.XPath(
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
            string checkboxSettingsSelector = $".//div[@class='ag-column-select-panel']//span[text()='{checkboxName}']";
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

        public bool ColumnIsDisplayed(string columnName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ag-header-cell-label']/span[text()='{columnName}']"));
        }

    }
}
