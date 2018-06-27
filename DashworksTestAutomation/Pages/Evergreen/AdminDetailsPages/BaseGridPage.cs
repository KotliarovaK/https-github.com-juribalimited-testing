using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    public class BaseGridPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'actions-create')]/button")]
        public IWebElement CreateItemButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'actions-right')]//*/button")]
        public IWebElement ImportProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'actions-list')]//*/mat-select")]
        public IWebElement ActionsList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'mat-select-panel')]//*/mat-option")]
        public IList<IWebElement> ActionsListItems { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='box-counter']/span")]
        public IWebElement RowsCounter { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='edit-action']/button")]
        public IWebElement ResetFiltersButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='ag-header-cell']/span[contains(@class,'select-all')]")]
        public IWebElement SelectAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ag-header-select-all']//span[@class='ag-checkbox-checked']")]
        public IWebElement SelectAllCheckboxChecked { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ag-header-select-all']//span[@class='ag-checkbox-unchecked']")]
        public IWebElement Unchecked { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IList<IWebElement> SelectRowsCheckboxesOnAdminPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ag-header-container']/div[@class='ag-header-row']/div[@col-id]")]
        public IList<IWebElement> GridColumns { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(text(), 'Delete')]")]
        public IWebElement DeleteValueInActions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'mat-select-placeholder')]")]
        public IWebElement ActionsInDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-option-text']")]
        public IWebElement DeleteButtonInActions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'button-small mat-raised-button')]/span[text()='DELETE']")]
        public IWebElement DeleteButtonOnPage { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//div[@id='messageAdmin']")]
        public IWebElement DeleteWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'messageAction')]/span[text()='DELETE']")]
        public IWebElement DeleteButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@mattooltip='Move']")]
        public IWebElement AddItemButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@title,'Update')]")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Toggle panel']")]
        public IWebElement AddItemCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted'][text()='No items']")]
        public IWebElement NoItemsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Toggle panel']")]
        public IWebElement PlusButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Toggle panel']")]
        public IWebElement SelectedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mattooltip='Back']")]
        public IWebElement BackToTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']")]
        public IWebElement CancelButtonInWarning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']")]
        public IWebElement OnboardedObjectsTable { get; set; }

        private By AgIconMenu = By.XPath("//span[contains(@class,'ag-icon-menu')]");

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        private IWebElement GetColumnByName(string columnName)
        {
            try
            {
                return GridColumns.Where(x => x.Text.Equals(columnName)).First();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private IWebElement GetAgIconMenuByColumnName(string columnName)
        {
            return GetColumnByName(columnName).FindElement(AgIconMenu);
        }

        public void SelectRecordByName(string recordName)
        {
            string recordNameSelector = $".//a[text()='{recordName}']";
            Driver.FindElement(By.XPath(recordNameSelector)).Click();
        }

        public List<string> GetCheckboxByColumnName(string columnName)
        {
            By by = By.XPath(
                $".//div[@class='ag-body-viewport']//div[@class='ag-body-container']/div/div[{GetColumnNumberByName(columnName)}]");
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

        public void GetSearchFieldByColumnName(string columnName, string text)
        {
            By byControl =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(text);
        }

        public void ClickContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]//a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public bool WarningMessageAdminPage(string text)
        {
            Driver.WaitForElement(By.XPath(".//div[@id='messageAdmin']"));
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@id='messageAdmin'][text()='{text}']"));
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            var columnHeaderSelector = $".//span[@class='ag-header-cell-text'][text()='{columnName}']";
            Driver.MouseHover(By.XPath(columnHeaderSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public void SelectActions(string actionName)
        {
            var selectedActionName =
                $".//div[@class='mat-select-content ng-trigger ng-trigger-fadeInContent']//span[text()='{actionName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selectedActionName));
            Driver.FindElement(By.XPath(selectedActionName)).Click();
        }

        public void SelectTabByName(string tabName)
        {
            string tabNameSelector = $".//li[@class='ng-star-inserted']//span[text()='{tabName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(tabNameSelector));
            Driver.FindElement(By.XPath(tabNameSelector)).Click();
        }

        public void AddItem(string itemName)
        {
            SearchTextbox.SendKeys(itemName);
            var selector = $".//span[text()='{itemName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public bool OnboardedObjectDisplayed(string objectName)
        {
            Driver.WaitForElement(By.XPath(".//div[@id='agGridTable']"));
            return Driver.IsElementDisplayed(
                By.XPath($"//a[text()='{objectName}']"));
        }

        public bool OnboardedObjectNumber(string objectsNumber)
        {
            Driver.WaitForElement(By.XPath(".//div[@id='agGridTable']"));
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@role='presentation']/div/div[@title='{objectsNumber}']"));
        }

        public IWebElement GetCreatedProjectName(string projectName)
        {
            var selector = By.XPath($"//a[text()='{projectName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}