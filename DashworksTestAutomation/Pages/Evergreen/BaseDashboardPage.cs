using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class BaseDashboardPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-text']/descendant::h1")]
        public IWebElement Heading { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_staticListModeBtn']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_listDtlBtn']")]
        public IWebElement ListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_clmnBtn']")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_fltrBtn']")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@role='presentation']//div[@class='ag-header-cell']//header-cell//input")]
        public IWebElement SelectAllRowsAction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IList<IWebElement> SelectRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn input-toggle mat-icon-button ng-star-inserted']")]
        public IWebElement SearchTextboxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[@class='btn btn-default input-toggle mat-icon-button ng-star-inserted']")]
        public IWebElement SearchTextboxResetButtonInPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Search table']")]
        public IWebElement TableSearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='reload']")]
        public IWebElement RefreshTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='rowCount ng-star-inserted']")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='checkbox-styled selectBox']/input")]
        public IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']")]
        public IWebElement TableBody { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body']")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']")]
        public IList<IWebElement> TableRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='content']//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='save-action-bar ng-star-inserted']//span[text()='Save']")]
        public IWebElement SaveCustomListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i")]
        public IWebElement ItemImage { get; set; }

        #region TableColumns

        [FindsBy(How = How.XPath, Using = ".//div[@colid='lastLogonDate'][@role='gridcell']")]
        public IList<IWebElement> LastLogonColumnData { get; set; }

        #endregion TableColumns

        public bool SelectAllCheckboxState => SelectAllCheckbox.Selected;

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.Heading),
                SelectorFor(this, p => p.List)
            };
        }

        public string GetHeaderFontWeight()
        {
            return Driver.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).GetCssValue("font-weight");
        }

        public bool IsColumnPresent(string columnName)
        {
            Driver.WaitForDataLoading();

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

        public IWebElement GetColumnHeaderByName(string columnName)
        {
            var selector = String.Empty;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector =
                    $".//div[@role='presentation']/span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]/..";
            }
            else
            {
                selector = $".//div[@role='presentation']/span[text()='{columnName}']/..";
            }

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
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

        public List<string> GetColumnContent(string columnName)
        {
            By by = By.XPath(
                $".//div[@class='ag-body']//div[@class='ag-body-container']/div/div[{GetColumnNumberByName(columnName)}]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public string ActiveCustomListName()
        {
            By by = By.XPath(
                ".//*[@id='submenuBlock']/div[contains(@class, 'active-list-wrapper')]/ul/li/span[@class='submenu-actions-list-name']");
            Driver.WaitWhileControlContainingTextIsNotDisplayed(by);
            return Driver.FindElement(by).Text;
        }

        public void ClickContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]//a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public IWebElement GetContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]");
             
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetListElementByName(string listName)
        {
            var selector = By.XPath($".//div[@id='submenuBlock']//*[text()='{listName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']/ancestor::div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eMenu']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public IWebElement GetSettingButtonByName(string settingName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//span[@id='eName'][text()='{settingName}']"));
            return Driver.FindElement(By.XPath($".//span[@id='eName'][text()='{settingName}']"));
        }

        public string GetPinnedColumnName(string pinStatus)
        {
            switch (pinStatus)
            {
                case "Left":
                    return Driver.FindElement(By.XPath(".//div[@class='ag-pinned-left-header']//span[@ref='eText']"))
                        .Text;

                case "Right":
                    return Driver.FindElement(By.XPath(".//div[@class='ag-pinned-right-header']//span[@ref='eText']"))
                        .Text;

                default: throw new Exception($"{pinStatus} is not valid Pin Value");
            }
        }

        public IList<IWebElement> GetAllColumnHeaders()
        {
            var selector = By.XPath(".//span[@role='columnheader']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }
    }
}