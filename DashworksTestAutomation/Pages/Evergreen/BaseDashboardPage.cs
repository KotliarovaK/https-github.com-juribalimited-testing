using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class BaseDashboardPage : SeleniumBasePage
    {
        public const string ColorItem = ".//div[@class='status']";

        public const string ImageItem = ".//div[@class='ag-body-container']//img[contains(@src,'png')]";

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-text']/descendant::h1")]
        public IWebElement Heading { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_staticListModeBtn']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_listDtlBtn'][@disabled]")]
        public IWebElement DisabledListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn btn-default mat-icon-button _mat-animation-noopable']")]
        public IWebElement InactiveActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Actions']")]
        public IWebElement ActionsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn btn-default mat-icon-button _mat-animation-noopable'][@id='_listDtlBtn']")]
        public IWebElement ListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'clmnBtn')]")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_fltrBtn']")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'pull-left context-toggle')]//i[@class='material-icons mat-clear']")]
        public IWebElement ClosePanelButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@role='presentation']//div[@class='ag-header-cell']//header-cell//input")]
        public IWebElement SelectAllRowsAction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IList<IWebElement> SelectRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn input-toggle')]")]
        public IWebElement SearchTextboxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'resetButton mat-button')]")]
        public IWebElement SearchTextboxResetButtonInPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Search Table']")]
        public IWebElement TableSearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='reload']")]
        public IWebElement RefreshTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'rowCount')]")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='checkbox-styled selectBox']/input")]
        public IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IWebElement Checkbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']")]
        public IWebElement TableBody { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-viewport']")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']")]
        public IList<IWebElement> TableRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='status-text'][text()='RED']")]
        public IList<IWebElement> ContentColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted'][text()='No devices found']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='action-item']//span[text()='Save']")]
        public IWebElement SaveCustomListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']//span[@class='checkbox-unchecked']")]
        public IWebElement UncheckedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error ng-star-inserted']")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement WarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement DoesNotExistListMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@tabindex='-1']//span//a")]
        public IWebElement FirstDevicesCell { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@tabindex='-1']//span//a[@href='#/user/71622/']")]
        public IWebElement FirstUsersCell { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@tabindex='-1']//span//a[@href='#/application/4249/']")]
        public IWebElement FirstApplicationsCell { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@tabindex='-1']//span//a[@href='#/mailbox/49258/']")]
        public IWebElement FirstMailboxesCell { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@name='createActions']/div[@class='mat-select-trigger']")]
        public IWebElement CreateActionButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='active-list-wrapper ng-star-inserted']/ul/li/span")]
        public IWebElement ActiveCustomList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Project']")]
        public IWebElement CreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option[@aria-disabled='true']//span[text()='Project']")]
        public IWebElement DisabledCreateProjectButton { get; set; }

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

        //Null value can be returned
        public IWebElement GetGridCell(int rowIndex, int columnNumber)
        {
            return (IWebElement)Driver.ExecuteScript($"return document.querySelector(\"div[row-index = '{rowIndex}']>div:nth-of-type({columnNumber})\")");
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
            var selector = string.Empty;
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

        public IWebElement GetCorrectApplicationVersion(string versionNumber)
        {
            var selector = By.XPath(
                $".//div[@class='topnav-footer']//span[contains(text(),'{versionNumber}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<string> GetColumnDataByScrolling(string columnName)
        {
            List<string> columnData = new List<string>();
            var columnNumber = GetColumnNumberByName(columnName);
            int iter = 0;
            var element = GetGridCell(iter, columnNumber);
            columnData.Add(element.Text);
            do
            {
                iter++;
                try
                {
                    Driver.MouseHoverByJavascript(element);
                    element = GetGridCell(iter, columnNumber);
                }
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(2000);
                    element = GetGridCell(iter, columnNumber);
                    Driver.MouseHoverByJavascript(element);
                }

                //Data loading
                if (element == null)
                {
                    Thread.Sleep(2000);
                    element = GetGridCell(iter, columnNumber);
                }
                try
                {
                    columnData.Add(element.Text);
                }
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(2000);
                    element = GetGridCell(iter, columnNumber);
                    columnData.Add(element.Text);
                }
                catch (NullReferenceException)
                {
                    break;
                }

                if (iter > 2002)
                    break;
            } while (element != null);

            return columnData;
        }

        public IWebElement GetColorByName(string colorName)
        {
            var selector = By.XPath(
                $".//span[@class='status-text'][text()='{colorName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
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
                $".//div[@class='ag-body-viewport']//div[@class='ag-body-container']/div/div[{GetColumnNumberByName(columnName)}]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public string ActiveCustomListName()
        {
            By by = By.XPath(
                ".//div[@class='active-list-wrapper ng-star-inserted']/ul/li/span");
            Driver.WaitForElement(by);
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

        /// <summary>
        /// Get just data from first row
        /// </summary>
        /// <param name="columnName">Column name in the grid</param>
        /// <returns></returns>
        public IWebElement GetContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public string CheckColumnContent(string columnContent)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div/div[@title='{columnContent}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl).Text;
        }

        public IWebElement GetHrefByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]/span/a[@href]");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).GetAttribute("href");
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
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            Driver.WaitForDataLoading();
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

        public string GetColorContainer(string styleColorItem)
        {
            switch (styleColorItem)
            {
                case "background-color: rgba(245, 96, 86, 0.5); border: 2px solid rgb(245, 96, 86);":
                    return "RED";
                case "background-color: rgba(47, 133, 184, 0.5); border: 2px solid rgb(47, 133, 184);":
                    return "BLUE";
                case "background-color: rgba(55, 61, 69, 0.5); border: 2px solid rgb(55, 61, 69);":
                    return "OUT OF SCOPE";
                case "background-color: rgba(71, 209, 209, 0.5); border: 2px solid rgb(71, 209, 209);":
                    return "LIGHT BLUE";
                case "background-color: rgba(153, 118, 84, 0.5); border: 2px solid rgb(153, 118, 84);":
                    return "BROWN";
                case "background-color: rgba(235, 175, 37, 0.5); border: 2px solid rgb(235, 175, 37);":
                    return "AMBER";
                case "background-color: rgba(226, 123, 54, 0.5); border: 2px solid rgb(226, 123, 54);":
                    return "REALLY EXTREMELY ORANGE";
                case "background-color: rgba(186, 94, 186, 0.5); border: 2px solid rgb(186, 94, 186);":
                    return "PURPLE";
                case "background-color: rgba(126, 189, 56, 0.5); border: 2px solid rgb(126, 189, 56);":
                    return "GREEN";
                case "background-color: rgba(128, 139, 153, 0.5); border: 2px solid rgb(128, 139, 153);":
                    return "GREY";
                default: throw new Exception($"{styleColorItem} is not valid Color");
            }
        }

        public string GetImageContainer(string styleImageItem)
        {
            switch (styleImageItem)
            {
                case "forwardPath.png":
                    return "FORWARD PATH";
                case "tick.png":
                    return "KEEP";
                case "cross.png":
                    return "RETIRE";
                case "unknown.png":
                    return "UNCATEGORISED";
                default: throw new Exception($"{styleImageItem} is not valid Image path");
            }
        }

        public void SelectActions(string actionsName)
        {
            var selectedActionsName =
                $".//mat-option[@role='option']/span[text()='{actionsName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selectedActionsName));
            Driver.FindElement(By.XPath(selectedActionsName)).Click();
        }

        public IList<IWebElement> GetAllColumnHeaders()
        {
            var selector = By.XPath(".//span[@role='columnheader']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }
    }
}