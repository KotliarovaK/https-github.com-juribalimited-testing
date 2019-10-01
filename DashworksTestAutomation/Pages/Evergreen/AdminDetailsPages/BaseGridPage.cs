﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    public class BaseGridPage : SeleniumBasePage
    {
        public const string ProjectInFilterDropdown =
            "//mat-option[@class='mat-option mat-option-multiple ng-star-inserted']";

        public const string TeamInFilterDropdown =
            "//mat-option[@class='mat-option mat-option-multiple ng-star-inserted mat-selected']";

        public const string ObjectsToAdd = "//div[@class='mat-list-text']/span";

        public const string Row = "//div[@col-id='name']//a";

        public const string FirstColumnTableContent = ".//div[@role='gridcell']//a[@href]";

        #region Inline Edit. Appears on double click on cell

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-cell-inline-editing')]//i[contains(@class,'mat-done')]")]
        public IWebElement SaveInlineButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-cell-inline-editing')]//i[contains(@class,'mat-clear')]")]
        public IWebElement CancelInlineButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-cell-inline-editing')]//input[contains(@id,'mat-input')]")]
        public IWebElement InputInlineTextbox { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-text']/descendant::h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@href]/img")]
        public IWebElement DashworksLogo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'das-mat-tree-node-collapsed')]/following-sibling::ul/*[@mattreenodetoggle]")]
        public IList<IWebElement> MenuTabOptionListOnAdminPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li//label//span[@class='mat-checkbox-label']")]
        public IList<IWebElement> DropdownTaskItemsList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='actions']")]
        public IWebElement ActionsSelectBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='aggrid-container']//div[@col-id='dragColumn']")]
        public IList<IWebElement> DragRowElements { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container//h1[text()='Warning']")]
        public IWebElement WarningPopUpPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='error-box clearfix default ng-star-inserted']//span[text()='403']")]
        public IWebElement ErrorBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@ref='eBodyContainer']//div[@row-index]")]
        public IWebElement TableString { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-right')]//*/button")]
        public IWebElement ImportProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-list')]//*/mat-select")]
        public IWebElement ActionsList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@col-id='onboardAction']/span[contains(text(), 'Re-Onboard')]")]
        public IWebElement ReonboardedItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='box-counter ng-star-inserted']/span")]
        public IWebElement RowsCounter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='rowCount ng-star-inserted']")]
        public IWebElement ListRowsCounter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CONTINUE']")]
        public IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-expand']")]
        public IWebElement AddObjectsPanelCollapsed { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'empty-message')]")]
        public IWebElement NoFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='inline-link ng-star-inserted']/a")]
        public IWebElement NewProjectLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@ref='eBodyViewport']//div//span[text()='Evergreen']")]
        public IWebElement EvergreenUnit { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-right-button')]/button[@aria-label='ResetFilters']")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-right-button')]//button[@aria-label='GroupBy']")]
        public IWebElement GroupByButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-right-button')]/button[@aria-label='Export']")]
        public IWebElement ExportButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-right-button')]/button[@aria-label='reload']")]
        public IWebElement RefreshButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'checkbox-styled')]//mat-checkbox")]
        public IWebElement SelectAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']/ancestor::mat-checkbox[contains(@class, 'checkbox-checked')]")]
        public IWebElement SelectAllCheckboxWithFullCheckedState { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']/ancestor::mat-checkbox[contains(@class, 'checkbox-indeterminate')]")]
        public IWebElement SelectAllCheckboxWithIndeterminateCheckedState { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Date']")]
        public IWebElement DateSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'mat-select-placeholder')]")]
        public IWebElement ActionsInDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ObjectsToAdd)]
        public IList<IWebElement> ObjectsList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-checkbox-inner-container']")]
        public IWebElement AllItemCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]/div[@ref='eCenterColsClipper']")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(@class,'header-back-link')]")]
        public IWebElement BackToTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'mat-select-value-text')]//span[text()='Capacity Units']")]
        public IWebElement DefaultCapacityMode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]")]
        public IWebElement TableBody { get; set; }

        [FindsBy(How = How.XPath, Using = ProjectInFilterDropdown)]
        public IList<IWebElement> ProjectListInFilterDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ProjectInFilterDropdown)]
        public IList<IWebElement> ProjectsTypeListInFilterDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = TeamInFilterDropdown)]
        public IList<IWebElement> TeamListInFilterDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = Row)]
        public IList<IWebElement> RowsList { get; set; }

        #region Messages

        [FindsBy(How = How.XPath, Using = ".//admin-header/div[@id='messageAdmin' and @role='alert']")]
        public IWebElement Banner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'empty-message')]")]
        public IWebElement NoObjectsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]//span[@class='ng-star-inserted']")]
        public IWebElement SuccessMessageThirdPart { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-info')]")]
        public IWebElement BlueBanner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error')]")]
        public IWebElement ErrorMessage { get; set; }

        //TODO all baners should be moved to separate element
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-tip')]")]
        public IWebElement WarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'btn-close-wrap')]//button")]
        public IWebElement CloseMessageButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'messageAction')]/span[contains(text(), 'DELETE')]")]
        public IWebElement DeleteButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'messageAction')]/span[contains(text(), 'CANCEL')]")]
        public IWebElement CancelButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted'][text()='No items']")]
        public IWebElement NoItemsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div//span[text()='403']//ancestor::div//div[@class='error-message-box']")]
        public IWebElement Error403 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-error/span/i[@class='material-icons mat-warning']")]
        public IWebElement UnderFieldWarningIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-error[@role='alert']//span")]
        public IWebElement FieldWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'message-error')]")]
        public IWebElement ScopeChangesError { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.DashworksLogo)
            };
        }

        public int GetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//div[@class='ag-header-container']/div/div");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            List<string> allHeadersWithText =
                allHeaders.Where(x => x.FindElements(By.XPath(".//span[@class='ag-header-cell-text']")).Count > 0).Select(x => x.Text).ToList();
            if (!allHeadersWithText.Any())
                throw new Exception("Table does not contains any columns");

            if (!allHeadersWithText.Contains(columnName))
                throw new Exception($"Table doesn't have '{columnName}' column");

            var columnNumber =
                allHeadersWithText.IndexOf(allHeadersWithText.First(x => x.Equals(columnName))) + 1;

            return columnNumber;
        }

        public void GetSearchFieldByColumnName(string columnName, string text)
        {
            var byControl =
                By.XPath(
                    $".//div[@role='presentation']//div[@class='ag-header-row'][2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(text);
        }

        public IWebElement GetFilterByColumnName(string columnName)
        {
            var allFilters =
                Driver.FindElements(By.XPath(".//div[@class='aggrid-input-styled']"));
            return allFilters[GetColumnNumberByName(columnName) - 1];
        }

        public IWebElement GetSearchFieldTextByColumnName(string columnName)
        {
            var selector =
                By.XPath(
                    $".//div[@role='presentation']//div[@class='ag-header-row'][2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input[@placeholder='Search']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownFilterTextByColumnName(string columnName, string text)
        {
            var selector =
                By.XPath($".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//mat-placeholder[text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            var columnSettingsSelector =
                $".//div[@role='presentation']//span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            var columnHeaderSelector = $".//span[@class='ag-header-cell-text'][text()='{columnName}']";
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(By.XPath(columnHeaderSelector));
            Driver.MouseHover(By.XPath(columnHeaderSelector));
            Driver.WaitForElementToBeDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        //TODO should be moved because this is something on Action panel
        public void SelectActions(string actionName)
        {
            //Nothing to do if action selectBox disabled
            if (ActionsSelectBox.GetAttribute("class").Contains("disabled"))
                return;

            var selectedActionName =
                $"//span[text()='{actionName}']/ancestor::mat-option";
            Driver.WaitForElementToBeDisplayed(By.XPath(selectedActionName));
            Driver.FindElement(By.XPath(selectedActionName)).Click();
        }

        public IWebElement QueueOnboardedObjectDisplayed(string objectName)
        {
            var selector = By.XPath($"//span[text()='{objectName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool HistoryOnboardedObjectDisplayed(string objectName)
        {
            var selector = By.XPath($".//a[text()='{objectName}']");
            return Driver.IsElementDisplayed(selector);
        }

        public bool WaitForHistoryOnboardedObject(string item, int seconds)
        {
            var attempts = 5;
            var waitTime = (seconds * 1000) / attempts;

            try
            {
                for (int i = 0; i < attempts; i++)
                {
                    if (HistoryOnboardedObjectDisplayed(item))
                        return true;
                    Thread.Sleep(waitTime);
                    Driver.Navigate().Refresh();
                    Driver.WaitForDataLoading();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Error waiting History Onboarded object: {e}");
            }

            return false;
        }

        public IWebElement DropdownItemDisplayed(string itemName)
        {
            var selector = By.XPath($"//li//label//span[contains(text(), '{itemName}')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public string GetTableStringRowNumber(string itemName)
        {
            return Driver.FindElement(By.XPath($".//div[@ref='eBodyViewport']//div//div[@title='{itemName}']//parent::div")).GetAttribute("row-index");
        }

        public bool OnboardedObjectNumber(string objectsNumber)
        {
            Driver.WaitForElement(By.XPath(".//div[@id='agGridTable']"));
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@role='presentation']/div/div[@title='{objectsNumber}']"));
        }

        public bool TextMessage(string textMessage)
        {
            return Driver.IsElementDisplayed(By.XPath($".//*[text()='{textMessage}']"));
        }

        public bool GetTabHeaderInTheScopeChangesSection(string text)
        {
            By locator = By.XPath($".//div[@class='detail-label ng-star-inserted']//span[text()='{text}']");
            Driver.WaitForElementToBeDisplayed(locator);
            return Driver.IsElementDisplayed(locator);
        }

        public IWebElement GetColumnHeaderByName(string columnName)
        {
            string selector;
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

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public List<string> GetColumnContent(string columnName)
        {
            var by = By.XPath(
                $".//div[contains(@class, 'ag-body-viewport')]//div[contains(@class, 'ag-body-container')]/div/div[{GetColumnNumberByName(columnName)}]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public bool GetStringFilterByName(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($"//div[@class='ng-star-inserted']/span[(text()='{filterName}')]"));
        }

        public void GetBooleanStringFilterByName(string filterName)
        {
            var filterSelector = $".//span[contains(@class,'boolean-text')][text()='{filterName}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(filterSelector));
            Driver.FindElement(By.XPath(filterSelector)).Click();
        }

        public IWebElement GetCheckedFilterByCheckboxName(string filterName)
        {
            var selector = By.XPath($"//mat-option[contains(@class, 'mat-active')]//div/span[text()='{filterName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetCheckedCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox[contains(@class, 'mat-checkbox-checked')]//span[text()='{checkboxName}']");
            return Driver.IsElementExists(selector);
        }

        public IWebElement GetUnCheckedCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox[contains(@class, 'ng-untouched ng-pristine ng-valid')]//span[text()='{checkboxName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetGreyedOutCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox[contains(@class, 'mat-checkbox-disabled')]//span[text()='{checkboxName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        //TODO probably should be removed
        private static string ProjectSelector = ".//div[@col-id='projectName']//a[text()='{0}']";

        public bool GetCreatedProjectName(string projectName, bool wait = false)
        {
            var by = By.XPath(string.Format(ProjectSelector, projectName));
            if (wait)
                Driver.WaitForElementToBeDisplayedAfterRefresh(by);
            return Driver.IsElementDisplayed(by);
        }

        public void GetStringFilterByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[@role='presentation']//div[@class='ag-header-row'][2]/div[{GetColumnNumberByName(columnName)}]");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        //TODO this hsould be removed
        public string GetMessageColor()
        {
            return Driver.FindElement(By.XPath(".//div[@id='messageAdmin']")).GetCssValue("background-color");
        }

        public string GetErrorMessageColor()
        {
            return Driver.FindElement(By.XPath(".//div[contains(@class,'inline-error')]")).GetCssValue("background-color");
        }

        public IWebElement GetTextInSearchFieldByColumnName(string columnName)
        {
            var selector =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetMissingDropdownByName(string dropdownName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//mat-select[@aria-label='{dropdownName}']"));
        }

        public bool GetMissingDropdownOnSettingsScreenByName(string dropdownName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@class='mat-form-field-infix']//label[text()='{dropdownName}']"));
        }

        public IWebElement GetDropdownByTextValueByName(string value, string dropdownName)
        {
            var selector = By.XPath($".//label[contains(@class,'field-label')][text()='{dropdownName}']/../../mat-select//span[text()='{value}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownByValueByName(string value, string dropdownName)
        {
            var selector = By.XPath($".//mat-form-field//label[text()='{dropdownName}']//ancestor::div//span[text()='{value}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonInWarningPopUp(string buttonName)
        {
            var selector = By.XPath($".//mat-dialog-container//button/span[text()='{buttonName}']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetDisabledTabByName(string tabName)
        {
            var selector = By.XPath($".//*[contains(@class,'mat-tree-node')][contains(@class,'disabled')]//a[text()='{tabName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetLinkByText(string text)
        {
            var selector = By.XPath($".//span[contains(@class, 'inline-link')]//a[text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetExpandedSubMenuSection(string section)
        {
            var selector = By.XPath($".//mat-nested-tree-node[@aria-expanded='true']//a[text()='{section}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetOpenedPageByName(string pageName)
        {
            var selector = By.XPath($".//div[contains(@class, 'wrapper-container')]//h2[text()='{pageName}']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetEmptyFieldByName(string fieldName)
        {
            var selector = By.XPath($".//mat-form-field[contains(@class, 'invalid')]//label[text()='{fieldName}']");
            return Driver.FindElement(selector);
        }

        public List<string> GetSumOfObjectsContent(string columnName)
        {
            var by = By.XPath(
                $".//div[@role='gridcell'][{GetColumnNumberByName(columnName)}]//a");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public IWebElement GetValueInGroupByFilterOnAdminPAge(string value)
        {
            var selector = By.XPath($".//*[text()='{value}']/ancestor::label[contains(@class, 'checkbox')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<KeyValuePair<string, bool>> GetAllOptionsInGroupByFilter()
        {
            var selector = By.XPath($".//div[@class='mat-menu-content']/mat-checkbox");
            Driver.WaitForElementToBeDisplayed(selector);
            var allOptions = Driver.FindElements(selector);
            List<KeyValuePair<string, bool>> result = new List<KeyValuePair<string, bool>>();
            foreach (IWebElement option in allOptions)
            {
                var text = option.FindElement(By.XPath(".//span[@class='mat-checkbox-label']")).Text.TrimStart(' ');
                var selected = option.FindElement(By.XPath(".//input[@type='checkbox']")).Selected;
                result.Add(new KeyValuePair<string, bool>(text, selected));
            }
            return result;
        }

        public bool IsGridGrouped()
        {
            return Driver.IsElementDisplayed(By.XPath(".//div[@role='row'][@row-index]//span[@class='ag-group-value']"),
                WebDriverExtensions.WaitTime.Short);
        }

        public IWebElement GetGroupedRowByContent(string groupedValue)
        {
            var selector = By.XPath($".//div[@role='row'][@row-index]//span[@class='ag-group-value'][text()='{groupedValue}']/..");
            if (Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                return Driver.FindElement(selector);
            else
                throw new Exception($"There are not row grouped by '{groupedValue}' value");
        }

        public string GetGroupedCountByContent(string groupedValue)
        {
            var number = GetGroupedRowByContent(groupedValue).FindElement(By.XPath(".//span[@ref='eChildCount']")).Text;
            number = number.TrimStart('(').TrimEnd(')');
            return number;
        }

        public void ExpandGroupedRowByContent(string groupedValue)
        {
            try
            {
                var row = GetGroupedRowByContent(groupedValue);
                var expand = row.FindElement(By.XPath("./span[contains(@class,'contracted')]/span"));
                expand.Click();
            }
            catch (NoSuchElementException e)
            {
                throw new Exception($"Unable to expand '{groupedValue}' row: {e}");
            }
        }

        public void CollapseGroupedRowByContent(string groupedValue)
        {
            try
            {
                var row = GetGroupedRowByContent(groupedValue);
                var expand = row.FindElement(By.XPath("./span[contains(@class,'expanded')]/span"));
                expand.Click();
            }
            catch (NoSuchElementException e)
            {
                throw new Exception($"Unable to collapse '{groupedValue}' row: {e}");
            }
        }

        public IList<IWebElement> GetColumnContentByColumnName(string columnName)
        {
            var selector = By.XPath($".//div[@class='ag-center-cols-clipper']//div[contains(@class, 'ag-row')]/div[{GetColumnNumberByName(columnName)}]//*[not(*)]");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector).ToList();
        }

        public IWebElement GetCellFromColumn(string columnName, string cellText)
        {
            var allData = GetColumnContentByColumnName(columnName);
            if (allData.Any(x => x.Text.Contains(cellText)))
                return allData.First(x => x.Text.Contains(cellText));
            else
                throw new Exception($"There is no cell with '{cellText}' text in the '{columnName}' column");
        }
    }
}