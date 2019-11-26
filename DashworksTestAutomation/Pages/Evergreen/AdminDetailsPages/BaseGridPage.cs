using System;
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
        public const string AllHeadersSelector = ".//div[@class='ag-header-container']/div[1]/div"; //.//span[@role='columnheader']

        public const string AllHeadersTextSelector = ".//span[@class='ag-header-cell-text']";

        //Text that displayed near expand (plus) button for grouped values in the grid
        public const string GroupedValue =
            ".//div[@role='row'][@row-index]//span[@class='ag-group-value']";

        public const string ProjectInFilterDropdown =
            "//mat-option[@class='mat-option mat-option-multiple ng-star-inserted']";

        public const string TeamInFilterDropdown =
            "//mat-option[@class='mat-option mat-option-multiple ng-star-inserted mat-selected']";

        public const string ObjectsToAdd = "//div[@class='mat-list-text']/span";

        public const string Row = "//div[@col-id='name']//a";

        public string AllCellsInTheGrid = ".//div[@ref='eBodyViewport']//div[@role='gridcell']";

        private string GridCellByColumnName = ".//div[@col-id='{0}' and @role='gridcell']";

        //TODO I think there should be some duplicated webElement simillar to this one
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-menu')]")]
        public IWebElement AgMenu { get; set; }

        //TODO probably can be changed to something more generic
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'checkbox-styled')]//mat-checkbox//input")]
        public IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IList<IWebElement> Checkboxes { get; set; }

        #region Inline Edit. Appears on double click on cell

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-cell-inline-editing')]//i[contains(@class,'mat-done')]")]
        public IWebElement SaveInlineButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-cell-inline-editing')]//i[contains(@class,'mat-clear')]")]
        public IWebElement CancelInlineButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-cell-inline-editing')]//input[contains(@id,'mat-input')]")]
        public IWebElement InputInlineTextbox { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//li//label//span[@class='mat-checkbox-label']")]
        public IList<IWebElement> DropdownTaskItemsList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='actions']")]
        public IWebElement ActionsSelectBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='aggrid-container']//div[@col-id='dragColumn']")]
        public IList<IWebElement> DragRowElements { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container//div[@class='dialog-warning-title']")]
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

        [FindsBy(How = How.XPath, Using = ".//div[@class='action-container']//button[@automation = 'grid bar export']")]
        public IWebElement ExportButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'action')][not(contains(@class,'edit'))]//button[@aria-label='reload']")]
        public IWebElement RefreshButton { get; set; }

        #region Lists Action Bar Old version

        [FindsBy(How = How.XPath, Using = "//i[contains(@class, 'icon-export')]/ancestor::button")]
        public IWebElement ExportListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[contains(@class, 'material-icons restore')]/ancestor::button")]
        public IWebElement ArchivedDevicesIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(), 'Archived devices not included')]")]
        public IWebElement ArchivedDevicesNotIncludedTooltip { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(), 'Archived devices included')]")]
        public IWebElement ArchivedDevicesIncludedTooltip { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'checkbox-styled')]//mat-checkbox")]
        public IWebElement SelectAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Date']")]
        public IWebElement DateSearchField { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']/div[@col-id='displayOrder' and @role='gridcell']")]
        public IList<IWebElement> DisplayOrderValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        #region Messages

        [FindsBy(How = How.XPath, Using = ".//admin-header/div[@id='messageAdmin' and @role='alert']")]
        public IWebElement Banner { get; set; }

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
            return new List<By> { };
        }

        public int GetColumnNumberByName(string columnName)
        {
            List<string> allHeadersWithText = GetAllHeadersText();
            if (!allHeadersWithText.Any())
                throw new Exception("Table does not contains any columns");

            if (!allHeadersWithText.Contains(columnName))
                throw new Exception($"Table doesn't have '{columnName}' column");

            var columnNumber =
                allHeadersWithText.IndexOf(allHeadersWithText.First(x => x.Equals(columnName))) + 1;

            return columnNumber;
        }

        #region Headers

        public IList<IWebElement> GetAllHeaders()
        {
            var allHeadersSelector = By.XPath(AllHeadersSelector);
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            return allHeaders;
        }

        public List<string> GetAllHeadersText()
        {
            var allHeaders = GetAllHeaders()/*.Where(x => x.FindElements(By.XPath(AllHeadersTextSelector)).Count > 0)*/.Select(x => x.Text).ToList();
            return allHeaders;
        }

        public List<IWebElement> GetAllHeadersTextElements()
        {
            var allHeaders = GetAllHeaders().Select(x => x.FindElement(By.XPath(AllHeadersTextSelector))).ToList();
            return allHeaders;
        }

        #endregion

        //Selector to the Action element below Column header
        //This can be textbox filter or other
        private string ActionElementSelector(string columnName)
        {
            var results =
                $".//div[@role='presentation']//div[@class='ag-header-row'][2]/div[{GetColumnNumberByName(columnName)}]//div[contains(@ref,'eFloatingFilterBody')]";
            return results;
        }

        #region Search field

        public IWebElement GetSearchFieldTextByColumnName(string columnName)
        {
            var selector =
                By.XPath(
                    $"{ActionElementSelector(columnName)}//input");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void PopulateSearchFieldByColumnName(string columnName, string text)
        {
            var input = GetSearchFieldTextByColumnName(columnName);
            input.Click();
            input.Clear();
            input.SendKeys(text);
            BodyContainer.Click();
        }

        #endregion

        #region Datepicker

        public IWebElement GetDatepickerByColumnName(string columnName)
        {
            var selector =
                By.XPath(
                    $"{ActionElementSelector(columnName)}//input[@aria-label='Date']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void PopulateDatepickerByColumnName(string columnName, string text)
        {
            var input = GetDatepickerByColumnName(columnName);
            input.Clear();
            input.SendKeys(text);
            BodyContainer.Click();
        }

        #endregion

        #region Dropdown

        public IWebElement GetDropdownFilterTextByColumnName(string columnName, string text)
        {
            var selector =
                By.XPath($"{ActionElementSelector(columnName)}//mat-placeholder[text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #endregion

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
            return Driver.FindElement(By.XPath($"{AllCellsInTheGrid}//span[text()='{itemName}']/ancestor::div[@role='row']"))
                .GetAttribute("row-index");
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

        public bool GetDisplayStateForStringFilterByName(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($"//div[@class='ng-star-inserted']/span[(text()='{filterName}')]"));
        }

        public void GetStringFilterByName(string filterName)
        {
            var filterSelector = $".//div[@class='ng-star-inserted']/span[(text()='{filterName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(filterSelector));
            Driver.FindElement(By.XPath(filterSelector)).Click();
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

        public IWebElement GetGreyedOutCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox[contains(@class, 'mat-checkbox-disabled')]//span[text()='{checkboxName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
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

        //TODO probably should be separate control or moved to GridHeaderElement 
        public IWebElement GetValueInGroupByFilterOnAdminPage(string value)
        {
            var selector = By.XPath($".//*[text()='{value}']/ancestor::label[contains(@class, 'checkbox')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        //TODO probably should be separate control or moved to GridHeaderElement 
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

        #region Column Settings

        public void OpenColumnSettings(string columnName)
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

        public IWebElement GetColumnSettingButton(string settingName)
        {
            Driver.WaitForElementToBeDisplayed(By.XPath($".//span[@ref='eName'][text()='{settingName}']"));
            return Driver.FindElement(By.XPath($".//span[@ref='eName'][text()='{settingName}']"));
        }

        #endregion

        #region GroupBy

        public bool IsGridGrouped()
        {
            return Driver.IsElementDisplayed(By.XPath(GroupedValue),
                WebDriverExtensions.WaitTime.Short);
        }

        public IWebElement GetGroupedRowByContent(string groupedValue)
        {
            var selector = By.XPath($"{GroupedValue}[text()='{groupedValue}']/..");
            if (Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                return Driver.FindElement(selector);
            else
                throw new Exception($"There are not row grouped by '{groupedValue}' value");
        }

        public string GetGroupedCountByContent(string groupedValue)
        {
            var number = GetGroupedRowByContent(groupedValue).
                FindElement(By.XPath(".//span[@ref='eChildCount']")).Text;
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

        #endregion

        #region Column content

        private string GetColIdByColumnName(string columnName)
        {
            var text = columnName.Contains('\'') ?
                columnName.Split('\'').Aggregate(string.Empty, (current, s) => current + $"[contains(text(),'{s}')]") :
                $"[text()='{columnName}']";
            var by = By.XPath($".//span{text}/ancestor::div[@col-id]");
            if (!Driver.IsElementDisplayed(by, WebDriverExtensions.WaitTime.Short))
                throw new Exception($"'{columnName}' column was not displayed");
            return Driver.FindElement(by).GetAttribute("col-id");
        }

        public IList<IWebElement> GetColumnElementsByColumnName(string columnName)
        {
            //Used for some columns on Projects->Capacity->Override Dates table
            var firstPartSelector = $".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']";

            By selector;
            //This is for Colors, Paths and other stuff
            if (Driver.FindElements(By.XPath("./child-cell")).Any())
            {
                selector =
                    By.XPath($"{firstPartSelector}//*[not(*)][last()]");
            }
            else
            {
                selector =
                    By.XPath($"{firstPartSelector}//*[string-length(text())>0]");
            }
            Driver.WaitForDataLoading();
            IList<IWebElement> elements = new List<IWebElement>();
            if (!Driver.FindElements(selector).Any())
            {
                elements = Driver.FindElements(By.XPath(firstPartSelector));
            }
            else
            {
                elements = Driver.FindElements(selector);
            }
            return elements;
        }

        public List<string> GetColumnContentByColumnName(string columnName)
        {
            return GetColumnElementsByColumnName(columnName).Select(x => x.Text).ToList();
        }

        #region Get Specific cell content

        public List<string> GetPathsColumnContent(string columnName)
        {
            var firstPartSelector = $".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']";
            var result = Driver.FindElements(By.XPath($"{firstPartSelector}//img"))
                .Select(x => x.GetAttribute("src")).Select(ConvertImageContainerSrc).ToList();
            return result;
        }

        public List<string> GetColorColumnContent(string columnName)
        {
            var firstPartSelector = $".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']";
            var result = Driver.FindElements(By.XPath($"{firstPartSelector}//div[@class='status']"))
                .Select(x => x.GetAttribute("style")).Select(GetColorContainer).ToList();
            return result;
        }

        private string ConvertImageContainerSrc(string styleImageItem)
        {
            styleImageItem = styleImageItem.Split('/').Last();
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

        private string GetColorContainer(string styleColorItem)
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

        #endregion

        public IWebElement GetCellFromColumn(string columnName, string cellText)
        {
            var allData = GetColumnElementsByColumnName(columnName);
            if (allData.Any(x => x.Text.Contains(cellText)))
                return allData.First(x => x.Text.Contains(cellText));
            else
                throw new Exception($"There is no cell with '{cellText}' text in the '{columnName}' column");
        }

        //Null value can be returned
        public IWebElement GetGridCell(int rowIndex, int columnNumber)
        {
            return (IWebElement)Driver.ExecuteScript(
                $"return document.querySelector(\"div[row-index = '{rowIndex}']>div:nth-of-type({columnNumber})\")");
        }

        public List<string> GetColumnDataByScrolling(string columnName)
        {
            var columnData = new List<string>();
            var columnNumber = GetColumnNumberByName(columnName);
            var iter = 0;
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
                    Thread.Sleep(5000);
                    element = GetGridCell(iter, columnNumber);
                    Driver.MouseHoverByJavascript(element);
                }

                //Data loading
                if (element == null)
                {
                    Thread.Sleep(3000);
                    element = GetGridCell(iter, columnNumber);
                }

                try
                {
                    columnData.Add(element.Text);
                }
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(3000);
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

        public List<string> GetColumnColors(string columnName)
        {
            var firstPartSelector = string.Format(GridCellByColumnName, GetColIdByColumnName(columnName));

            return Driver.FindElements(By.XPath($"{firstPartSelector}//div[@class='status']"))
                .Select(x => x.GetAttribute("style")).ToList();
        }

        public string GetColumnWidthByName(string columnName)
        {
            return Driver.FindElement(By.XPath(string.Format(GridCellByColumnName,
                GetColIdByColumnName(columnName)))).GetCssValue("width");
        }

        public void ClickContentByColumnName(string columnName)
        {
            var byControl = By.XPath(string.Concat(string.Format(GridCellByColumnName,
                GetColIdByColumnName(columnName)), "//a"));

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            try
            {
                Driver.FindElement(byControl).Click();
            }
            catch (StaleElementReferenceException)
            {
                if (Driver.IsElementDisplayed(byControl, WebDriverExtensions.WaitTime.Short))
                    Driver.FindElement(byControl).Click();
            }
        }

        public IWebElement GetHrefByColumnName(string columnName)
        {
            var byControl = By.XPath(string.Concat(string.Format(GridCellByColumnName,
                    GetColIdByColumnName(columnName)), "//a"));

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).GetAttribute("href");
            return Driver.FindElement(byControl);
        }

        #endregion

        #region Pinned column

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

        #endregion

        #region Column Header

        public IWebElement GetColumnHeaderByName(string columnName, WebDriverExtensions.WaitTime timeout = WebDriverExtensions.WaitTime.Long)
        {
            var colId = GetColIdByColumnName(columnName);
            var headerSelector = By.XPath($".//div[contains(@class,'ag-header')][@col-id='{colId}']");
            if (!Driver.IsElementDisplayed(headerSelector, timeout))
                throw new Exception($"'{columnName}' header was not displayed");
            return Driver.FindElement(headerSelector);
        }

        public bool IsColumnPresent(string columnName)
        {
            try
            {
                return GetColumnHeaderByName(columnName, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}