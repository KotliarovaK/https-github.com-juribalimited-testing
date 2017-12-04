using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class BaseDashboardPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-text']/descendant::h1")]
        public IWebElement Heading { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_staticListModeBtn']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_clmnBtn']")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_fltrBtn']")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@role='presentation']//div[@class='ag-header-cell']//header-cell//input")]
        public IWebElement SelectAllRowsAction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IList<IWebElement> SelectRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class,'test-dg-vsbl')]")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='rowCount']")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='checkbox-styled selectBox']/input")]
        public IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']")]
        public IWebElement TableBody { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='save-action-bar']//span[text()='Save']")]
        public IWebElement SaveCustomListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContainer { get; set; }

        #region TableColumns

        [FindsBy(How = How.XPath, Using = ".//div[@colid='lastLogonDate'][@role='gridcell']")]
        public IList<IWebElement> LastLogonColumnData { get; set; }

        #endregion

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

        public bool IsColumnPresent(string columnName)
        {
            var selector = String.Empty;
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

        public int GetColumNumberByName(string columnName)
        {
            var allHeaders = Driver.FindElements(By.XPath(".//div[@class='ag-header-container']/div/div"));
            if (!allHeaders.Any())
                throw new Exception("Table does not contains any columns");
            var columnNumber =
                allHeaders.IndexOf(allHeaders.First(x =>
                    x.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).Text.Equals(columnName))) + 1;

            return columnNumber;
        }

        public List<string> GetColumnContent(string columnName)
        {
            return Driver.FindElements(
                    By.XPath(
                        $".//div[@class='ag-body']//div[@class='ag-body-container']/div/div[{GetColumNumberByName(columnName)}]"))
                .Select(x => x.Text).ToList();
        }

        public string ActiveCustomListName()
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(".//div[@class='active-list-wrapper']//span"));
            return Driver.FindElement(By.XPath(".//div[@class='active-list-wrapper']//span")).Text;
        }

        public void ClickContentByColumnName(string columnName)
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumNumberByName(columnName)}]//a"));
            TableBody.FindElement(By.XPath($"./div[1]/div[{GetColumNumberByName(columnName)}]//a")).Click();
        }

        public IWebElement GetListElementByName(string listName)
        {
            try
            {
                return Driver.FindElement(By.XPath($".//div[@id='submenuBlock']//div[text()='{listName}']"));
            }
            catch (Exception e)
            {
                return Driver.FindElement(By.XPath($".//div[@id='submenuBlock']//span[text()='{listName}']"));
            }
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
            return Driver.FindElements(
                By.XPath(".//div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eText']"));
        }
    }
}