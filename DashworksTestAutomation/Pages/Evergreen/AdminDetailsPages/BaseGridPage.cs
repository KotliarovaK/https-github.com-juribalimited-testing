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
        public const string ProjectInFilterDropdown =
            "//mat-option[@class='mat-option mat-option-multiple ng-star-inserted']";

        public const string ProjectsTypeInFilterDropdown =
            "//mat-option[contains(@class, 'mat-option mat-option-multiple ng-star-inserted mat')]";

        public const string TeamInFilterDropdown =
            "//mat-option[@class='mat-option mat-option-multiple ng-star-inserted mat-selected']";

        public const string ObjectsToAdd = "//div[@class='mat-list-text']/span";

        public const string Row = "//div[@col-id='name']//a";

        public const string OptionTabsOnAdminPage = "//li/a[@mattooltipshowdelay]";

        public const string FirstColumnTableContent = "//div[@role='gridcell']//a[@href]";

        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = OptionTabsOnAdminPage)]
        public IList<IWebElement> MenuTabOptionListOnAdminPage { get; set; }

        [FindsBy(How = How.XPath, Using = FirstColumnTableContent)]
        public IList<IWebElement> TableContentList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='actions']")]
        public IWebElement ActionsSelectBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Evergreen')]")]
        public IWebElement EvergreenLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//body")]
        public IWebElement BodyContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@ref='eBodyContainer']//div[@row-index]")]
        public IWebElement TableString { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-right')]//*/button")]
        public IWebElement ImportProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'actions-list')]//*/mat-select")]
        public IWebElement ActionsList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@col-id='onboardAction']/span[contains(text(), 'Re-Onboard')]")]
        public IWebElement ReonboardedItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='box-counter']/span")]
        public IWebElement RowsCounter { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CONTINUE']")]
        public IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-expand']")]
        public IWebElement AddObjectsPanelCollapsed { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='inline-link ng-star-inserted']/a")]
        public IWebElement NewProjectLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@ref='eBodyContainer']//div//span[text()='Evergreen']")]
        public IWebElement EvergreenUnit { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button//span[contains(text(), 'RESET FILTERS')]")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-header-cell']/span[contains(@class,'select-all')]")]
        public IWebElement SelectAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-select-all']//span[@class='ag-checkbox-checked']")]
        public IWebElement SelectAllCheckboxChecked { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Date']")]
        public IWebElement DateSearchField { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@class='ag-header-container']/div[@class='ag-header-row']/div[@col-id]")]
        public IList<IWebElement> GridColumns { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(text(), 'Delete')]")]
        public IWebElement DeleteValueInActions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'mat-select-placeholder')]")]
        public IWebElement ActionsInDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ObjectsToAdd)]
        public IList<IWebElement> ObjectsList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']")]
        public IWebElement CorrectActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-option-text']")]
        public IWebElement DeleteButtonInActions { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'button-small mat-raised-button')]/span[text()='DELETE']")]
        public IWebElement DeleteButtonOnPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Search']")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button/span[contains(text(), 'ADD')]")]
        public IWebElement AddItemButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@title,'Update')]")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-checkbox-inner-container']")]
        public IWebElement AllItemCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[contains(@class, 'mat-checkbox-checked')]")]
        public IWebElement CheckedAllItemCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[contains(@class, 'checkbox-partial')]")]
        public IWebElement CheckedSomeItemCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-container')]/div")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Toggle panel']")]
        public IWebElement PlusButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@mattooltip='Back']")]
        public IWebElement BackToTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']")]
        public IWebElement CancelButtonInWarning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-container')]")]
        public IWebElement OnboardedObjectsTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'mat-select-value-text')]//span[text()='Capacity Units']")]
        public IWebElement DefaultCapacityMode { get; set; }

        [FindsBy(How = How.XPath, Using = ProjectInFilterDropdown)]
        public IList<IWebElement> ProjectListInFilterDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ProjectInFilterDropdown)]
        public IList<IWebElement> ProjectsTypeListInFilterDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = TeamInFilterDropdown)]
        public IList<IWebElement> TeamListInFilterDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = Row)]
        public IList<IWebElement> RowsList { get; set; }

        private By AgIconMenu = By.XPath(".//span[contains(@class,'ag-icon-menu')]");

        #region Messages

        [FindsBy(How = How.XPath, Using = "//admin-header/div[@id='messageAdmin' and @role='alert']")]
        public IWebElement Banner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'empty-message')]")]
        public IWebElement NoObjectsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='No projects found']")]
        public IWebElement NoProjectsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-info')]")]
        public IWebElement BlueBanner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-tip')]")]
        public IWebElement WarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'btn-close-wrap')]//button")]
        public IWebElement CloseMessageButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'messageAction')]/span[contains(text(), 'DELETE')]")]
        public IWebElement DeleteButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted'][text()='No items']")]
        public IWebElement NoItemsMessage { get; set; }

        #endregion

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
                return GridColumns.First(x => x.Text.Equals(columnName));
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
            var recordNameSelector = $".//a[text()='{recordName}']";
            Driver.FindElement(By.XPath(recordNameSelector)).Click();
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

        public IWebElement GetFilterByColumnName(string columnName)
        {
            var allFilters =
                Driver.FindElements(By.XPath(".//div[@class='aggrid-input-styled']"));
            return allFilters[GetColumnNumberByName(columnName) - 1];
        }

        public void AddDateByFieldName(string fieldName, string date)
        {
            var byControl =
                By.XPath(
                    $"//input[@aria-label='Date'][@placeholder='{fieldName}']");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(date);
        }

        public void GetObjectField(string text)
        {
            var byControl =
                By.XPath(".//div[@class='mat-form-field-infix']/input");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(text);
        }

        public IWebElement GetSearchFieldTextByColumnName(string columnName)
        {
            var selector =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input[@placeholder='Search']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownFilterTextByColumnName(string columnName, string text)
        {
            var selector =
                By.XPath($".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//mat-placeholder[text()='{text}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void ClickContentByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[contains(@class, 'ag-body-container')]/div[1]/div[{GetColumnNumberByName(columnName)}]//a");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            var columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            var columnHeaderSelector = $".//span[@class='ag-header-cell-text'][text()='{columnName}']";
            Driver.MouseHover(By.XPath(columnHeaderSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public void SelectActions(string actionName)
        {
            //Nothing to do if action selectBox disabled
            if (ActionsSelectBox.GetAttribute("class").Contains("disabled"))
                return;

            var selectedActionName =
                $".//div[@class='mat-select-content ng-trigger ng-trigger-fadeInContent']//span[text()='{actionName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selectedActionName));
            Driver.FindElement(By.XPath(selectedActionName)).Click();
        }

        public void SelectTabByName(string tabName)
        {
            var tabNameSelector = $".//li[@class='ng-star-inserted']//span[text()='{tabName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(tabNameSelector));
            Driver.FindElement(By.XPath(tabNameSelector)).Click();
        }

        public void AddItem(string itemName)
        {
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(itemName);
            var selector = $".//span[contains(text(), '{itemName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void CheckItemDisplay(string itemName)
        {
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(itemName);
        }

        public IWebElement QueueOnboardedObjectDisplayed(string objectName)
        {
            var selector = By.XPath($"//span[text()='{objectName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement HistoryOnboardedObjectDisplayed(string objectName)
        {
            var selector = By.XPath($"//a[text()='{objectName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement DropdownItemDisplayed(string itemName)
        {
            var selector = By.XPath($"//li//label//span[contains(text(), '{itemName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public string GetTableStringRowNumber(string itemName)
        {
            return Driver.FindElement(By.XPath($".//div[@ref='eBodyContainer']//div//div[@title='{itemName}']//parent::div")).GetAttribute("row-index");
        }

        public bool OnboardedObjectNumber(string objectsNumber)
        {
            Driver.WaitForElement(By.XPath(".//div[@id='agGridTable']"));
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@role='presentation']/div/div[@title='{objectsNumber}']"));
        }

        public bool TextMessage(string textMessage)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[text()='{textMessage}']"));
        }


        public bool GetTabHeaderInTheScopeChangesSection(string text)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='detail-label ng-star-inserted']//span[text()='{text}']"));
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

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public List<string> GetColumnContent(string columnName)
        {
            var by = By.XPath(
                $".//div[contains(@class, 'ag-body-viewport')]//div[contains(@class, 'ag-body-container')]/div/div[{GetColumnNumberByName(columnName)}]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public IWebElement GetStringFilterByName(string filterName)
        {
            var selector = By.XPath($"//div[@class='ag-filter']/span[(text()='{filterName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GetBooleanStringFilterByName(string filterName)
        {
            var filterSelector = $"//mat-option//span[text()='{filterName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(filterSelector));
            Driver.FindElement(By.XPath(filterSelector)).Click();
        }

        public IWebElement GetCheckedFilterByCheckboxName(string filterName)
        {
            var selector = By.XPath($"//mat-option[contains(@class, 'mat-active')]//div/span[text()='{filterName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetCreatedProjectName(string projectName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{projectName}']"));
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

        public string GetMessageColor()
        {
            return Driver.FindElement(By.XPath("//div[@id='messageAdmin']")).GetCssValue("background-color");
        }

        public string GetMessageHeightOnAdminPage()
        {
            return Driver.FindElement(By.XPath("//div[@id='messageAdmin']")).GetCssValue("Height");
        }

        public string GetMessageWidthOnAdminPage()
        {
            return Driver.FindElement(By.XPath("//div[@id='messageAdmin']")).GetCssValue("width");
        }

        public bool GetDefaultColumnValue(string defaultValue)
        {
            return Driver.IsElementDisplayed(By.XPath($"//span[contains(@class, 'boolean')][text()='{defaultValue}']"));
        }

        public IWebElement GetTextInSearchFieldByColumnName(string columnName)
        {
            var selector =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTextInFieldByFieldName(string fieldName)
        {
            var selector = By.XPath($".//input[@placeholder='{fieldName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownByName(string dropdownName)
        {
            var selector = By.XPath($".//mat-select[@aria-label='{dropdownName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownValueByName(string dropdownName)
        {
            var selector = By.XPath($".//mat-option/span[text()='{dropdownName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetMissingDropdownByName(string dropdownName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//mat-select[@aria-label='{dropdownName}']"));
        }

        public IWebElement GetDropdownByTextValueByName(string value, string dropdownName)
        {
            var selector = By.XPath($"//mat-form-field//mat-select[@aria-label='{dropdownName}']//span/span[text()='{value}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownByValueByName(string value, string dropdownName)
        {
            var selector = By.XPath($"//mat-form-field//label[text()='{dropdownName}']//ancestor::div//span[text()='{value}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDisabledTabByName(string tabName)
        {
            var selector = By.XPath($"//li[contains(@class, 'disabled')]//span[text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetLinkByText(string text)
        {
            var selector = By.XPath($"//span[contains(@class, 'inline-link')]//a[text()='{text}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}