using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    public class BaseDashboardPage : SeleniumBasePage
    {
        private string NamedDropdownSelector = ".//mat-select[@aria-label='{0}' or @automation='{0}']";

        public const string ColorItem = ".//div[@class='status']";

        public const string ImageItem = ".//div[contains(@class, 'ag-body-container')]//img[contains(@src,'png')]";

        public const string GridCell = ".//div[@role='gridcell']";

        public const string OptionsDllOnActionsPanel = "//mat-option[@role='option']//span";

        public const string ColumnSubcategory = "//div[@class='selected-column-name']//span";

        public const string FilterSubcategory = "//div[contains(@class, 'sub-categories')]//div//div";

        public const string SelectedFiltersSubcategory = "//div[contains(@class, 'sub-categories')]//div";

        public const string SelectedColumnSubcategory = "//div[contains(@class, 'sub-categories')]//div//span";

        public const string OptionOnActionsPanel = ".//mat-option[@role='option']";

        public const string ColumnWithEvergreenIconSelector = ".//div[@col-id='projectName'][@role='gridcell']";

        public const string ImageSelector = ".//i";

        [FindsBy(How = How.XPath, Using = ".//h2")]
        public IWebElement SubHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container")]
        public IWebElement PopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='content']//i[@class='material-icons mat-menu']")]
        public IWebElement ExpandSideNavPanelIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//admin-header//span[@class='ng-star-inserted']")]
        public IWebElement FoundRowsLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'active')]//i[contains(@class, 'static-list')]")]
        public IWebElement ActiveActionsButton { get; set; }

        //TODO move this to separate component
        #region Action Panel

        [FindsBy(How = How.XPath, Using = "//i[contains(@class, 'static-list')]/ancestor::button")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'actions-container-row')]")]
        public IWebElement ActionsRowsCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Action']")]
        public IWebElement ActionsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[@role='listbox']//span[text()='Bulk Update Type']")]
        public IWebElement BulkUpdateTypeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@placeholder='Project']")]
        public IWebElement ProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Project or Evergreen']")]
        public IWebElement ProjectOrEvergreenField { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-option[@role='option']")]
        public IList<IWebElement> ActionsProjectOrEvergreenOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-option[@role='option']")]
        public IWebElement ProjectSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Stage']")]
        public IWebElement StageField { get; set; }

        //TODO Remove this step
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Capacity Unit']")]
        public IWebElement CapacityUnitField { get; set; }

        //TODO should be replaced by AutocompleteSelect
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Ring']")]
        public IWebElement RingField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Also Move Mailboxes')]/parent::span//preceding-sibling::mat-select")]
        public IWebElement AlsoMoveMailboxesField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@placeholder='Task']")]
        public IWebElement TaskField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Value']")]
        public IWebElement ValueDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@placeholder='Value']")]
        public IWebElement ValueField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[contains(@class, 'mat-select')]//span[text()='Update Value']")]
        public IWebElement UpdateValueDropdown { get; set; }

        //TODO delete this webelement
        [FindsBy(How = How.XPath, Using = ".//mat-select[contains(@class, 'mat-select')]//span[text()='Update Date']")]
        public IWebElement UpdateDateDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[contains(@class, 'mat-select')]//span[text()='Update Owner']")]
        public IWebElement UpdateOwnerDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Team']")]
        public IWebElement TeamField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Owner']")]
        public IWebElement OwnerField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Open calendar']")]
        public IWebElement DatePickerIcon { get; set; }

        //TODO Remove this step
        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Date']")]
        public IWebElement DateField { get; set; }

        //TODO should be replaced by AutocompleteSelect
        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Path']")]
        public IWebElement PathDropdown { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'listDtlBtn')]")]
        public IWebElement ListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'clmnBtn')]")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'fltrBtn')]")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-header']//button[@aria-label='filters']")]
        public IWebElement FilterExpressionIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-panel']//div[@class='context-tools-filters ng-star-inserted']")]
        public IWebElement FiltersExpression { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'pull-left context-toggle')]//i[@class='material-icons mat-clear']")]
        public IWebElement ClosePanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']/span[contains(@class,'checkbox-unchecked')]/../*[not(contains(@class,'ag-hidden'))][1]")]
        public IList<IWebElement> SelectRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-close')]")]
        public IWebElement SearchTextBoxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[contains(@class,'searchPanel')]/button")]
        public IWebElement SearchTextBoxResetButtonInPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='search']")]
        public IWebElement TableSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Search Table']")]
        public IWebElement TableSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'tools-item')]//button[@aria-label='close']")]
        public IWebElement CloseToolsPanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'top-tools')]//button[@aria-label='reload']")]
        public IWebElement RefreshTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container//button[contains(@class, 'mat-primary')]")]
        public IWebElement DeleteButtonInPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container//button[@class='mat-raised-button']")]
        public IWebElement CancelButtonInPopUp { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'notification')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButtonOnAmberMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'edit-action')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'UPDATE')]")]
        public IWebElement UpdateAssociationButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'notification')]//button[contains(@class, 'transparent')]//span[text()='CANCEL']/ancestor::button")]
        public IWebElement CancelButtonOnAmberMessage { get; set; }

        #region All Lists dropdown

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'DropdownActionsLists')]")]
        public IWebElement DropdownLists { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'mat-star')]/..//following-sibling::span[text()='Favourites']")]
        public IWebElement FavoritesIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'person')]/..//following-sibling::span[text()='My lists']")]
        public IWebElement MyListsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'share')]/..//following-sibling::span[text()='Shared with me']")]
        public IWebElement SharedWithMeIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'mat-filter_list')]/..//following-sibling::span[text()='Dynamic lists']")]
        public IWebElement DynamicListsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'done')]/..//following-sibling::span[text()='Static lists']")]
        public IWebElement StaticListsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'mat-list')]/..//following-sibling::span[text()='All lists']")]
        public IWebElement AllListsIcon { get; set; }

        //TODO should be replaced by AutocompleteSelect
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Owner']")]
        public IWebElement OwnerDropDown { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'rowCount')]")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'checkbox-styled')]//mat-checkbox")]
        public IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'checkbox-styled')]//mat-checkbox//input")]
        public IWebElement SelectAllCheckboxState { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IWebElement Checkbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]//div[@class='ag-center-cols-container']")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option//div[contains(@class, 'text-container')]//span")]
        public IList<IWebElement> StringFilterValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-center-cols-viewport']//div[@role='row']")]
        public IList<IWebElement> TableRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='status-text'][text()='RED']")]
        public IList<IWebElement> ContentColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']/span")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'save')]//button")]
        public IWebElement SaveCustomListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='filters']")]
        public IWebElement FilterContainerButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'context-header')]//div[@role='group']")]
        public IWebElement FilterOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'sectionAddObjects wrapper-disabled')]")]
        public IWebElement DisabledObjectsToAddPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='sectionAddObjects']")]
        public IWebElement ActiveObjectsToAddPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']//span[@class='checkbox-unchecked']")]
        public IWebElement UncheckedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IWebElement SelectOneRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error ng-star-inserted']")]
        public IWebElement ErrorMessage { get; set; }

        //TODO should be removed. The same webElement on BaseGridPage
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-tip')]")]
        public IWebElement WarningMessage { get; set; }

        //TODO more to the BaseGrid
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-tip')]//div[@class='inline-box-text']")]
        public IWebElement WarningMessageText { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-close')]")]
        public IWebElement CloseButtonInSuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement DoesNotExistListMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-menu']")]
        public IWebElement AgMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-menu')]//span[@ref='eName']")]
        public IList<IWebElement> AgMenuOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@name='createActions']/div[@class='mat-select-trigger']/ancestor::mat-select")]
        public IWebElement CreateActionButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'active-list')]//span[contains(@class,'name')]")]
        public IWebElement ActiveCustomList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]//div[@class='ag-center-cols-viewport']//div[@role='row']")]
        public IList<IWebElement> GridRows { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[contains(@class, 'ag-body-container')]/div[@role='row']/div[@col-id='groupName']")]
        public IList<IWebElement> GridBucketsNames { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'list-selected-save')]//span[@class='list-selected-name']")]
        public IWebElement ActiveCustomListEdited { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'transformPanel')]//span[text()='Project']")]
        public IWebElement CreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option[@aria-disabled='true']//span[text()='Project']")]
        public IWebElement DisabledCreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='top-tools-item top-tools-left-side']")]
        public IWebElement OutsideGridPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'sub-categories-item')]")]
        public IList<IWebElement> ColumnSubcategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='menu-settings']/li[@class='ng-star-inserted']")]
        public IList<IWebElement> CogMenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'DateTime')]/span[contains(text(), ':')]")]
        public IWebElement DateTimeColumnValue { get; set; }

        [FindsBy(How = How.XPath, Using = OptionsDllOnActionsPanel)]
        public IList<IWebElement> OptionsDll { get; set; }

        [FindsBy(How = How.XPath, Using = ColumnSubcategory)]
        public IList<IWebElement> ColumnSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = FilterSubcategory)]
        public IList<IWebElement> FilterSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedFiltersSubcategory)]
        public IList<IWebElement> SelectedFiltersSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedColumnSubcategory)]
        public IList<IWebElement> SelectedColumnsSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = OptionOnActionsPanel)]
        public IList<IWebElement> OptionListOnActionsPanel { get; set; }

        #region TableColumns

        [FindsBy(How = How.XPath, Using = ".//div[@colid='lastLogonDate'][@role='gridcell']")]
        public IList<IWebElement> LastLogonColumnData { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@col-id='hostname' and @role='gridcell']//*[contains(text(),'Empty')]")]
        public IList<IWebElement> EmptyColumnDataRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@col-id='computerKey' and @role='gridcell']//span")]
        public IList<IWebElement> DeviceKeyColumnDataRows { get; set; }

        #endregion TableColumns

        private static string NamedTextboxSelector = "(.//textarea[@placeholder='{0}'] | .//input[@placeholder='{0}'])";

        private static string AutocompleteOptionsSelector = ".//mat-option";

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'mat-autocomplete-panel')]")]
        public IWebElement AutocompleteDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By> { };
        }

        //Null value can be returned
        public IWebElement GetGridCell(int rowIndex, int columnNumber)
        {
            return (IWebElement)Driver.ExecuteScript(
                $"return document.querySelector(\"div[row-index = '{rowIndex}']>div:nth-of-type({columnNumber})\")");
        }

        public string GetHeaderFontWeight()
        {
            return Driver.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).GetCssValue("font-weight");
        }

        public bool IsColumnPresent(string columnName)
        {
            Driver.WaitForDataLoading();

            string selector;
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

        public IWebElement GetGridCellByText(string cellText)
        {
            var allCellsWithExpectedText = Driver.FindElements(By.XPath(GridCell))
                .Where(x => x.GetAttribute("innerHTML").Contains(cellText)).ToList();

            if (allCellsWithExpectedText.Any())
            {
                return allCellsWithExpectedText.FirstOrDefault();
            }
            else
            {
                throw new Exception($"Unable to find cell with '{cellText}' text");
            }
        }

        public void ContextClickOnCell(string cellText)
        {
            Driver.WaitForDataLoading();
            Driver.ContextClick(GetGridCellByText(cellText));
        }

        public void DoubleClickOnCell(string cellText)
        {
            Driver.WaitForDataLoading();
            Driver.DoubleClick(GetGridCellByText(cellText));
        }

        public void ClearInput(IWebElement input)
        {
            int attempt = 0;

            Driver.WaitForDataLoading();

            while (!input.GetAttribute("value").Equals(string.Empty) && attempt < 10)
            {
                input.Clear();
                Thread.Sleep(500);
                attempt++;
            }
        }

        #region Dropdown

        public IWebElement GetDropdownByName(string dropdownName)
        {
            var selector = By.XPath(string.Format(NamedDropdownSelector, dropdownName));
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        //Index starts from 1
        public IWebElement GetDropdownByName(string dropdownName, int index)
        {
            index--;
            var selector = By.XPath(string.Format(NamedDropdownSelector, dropdownName));
            Driver.WaitFor(() => Driver.FindElements(selector).Count >= index);
            Driver.WaitForElementToBeDisplayed(Driver.FindElements(selector)[index]);
            return Driver.FindElement(selector);
        }

        //Get all span with text
        private string _dropdownOptions = ".//mat-option//span[string-length(text())>0]";

        public IWebElement GetDropdownValueByName(string dropdownName)
        {
            var text = dropdownName.Split('\'').Aggregate(string.Empty, (current, s) => current + $"[contains(text(),'{s}')]");
            var selector = By.XPath($"{_dropdownOptions}{text}");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<string> GetDropdownValues()
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(_dropdownOptions));
            var optionsList = Driver.FindElements(By.XPath(_dropdownOptions));
            if (!optionsList.Any())
                throw new Exception($"Unable to get dropdown values");
            var values = optionsList.Select(x => x.Text).ToList();
            return values;
        }

        #endregion

        public IWebElement GetNamedTextbox(string placeholder)
        {
            var by = By.XPath(string.Format(NamedTextboxSelector, placeholder));
            if (!Driver.IsElementDisplayed(by, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"Textbox with '{placeholder}' placeholder is not displayed");
            return Driver.FindElement(by);
        }

        public IWebElement GetAutocompleteDropdownByText(string text)
        {
            var selector = By.XPath($"//*[contains(text(), '{text}')]/ancestor::mat-option");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetInputAddButton(string placeholder)
        {
            var selector = GetNamedTextbox(placeholder).FindElement(By.XPath(".//../ancestor::mat-form-field//button"));
            Driver.WaitForElementToBeDisplayed(selector);
            return selector;
        }

        public IWebElement GetNamedTextboxErrorMessageElement(string placeholder)
        {
            var namedTextbox = GetNamedTextbox(placeholder);
            var elementAttributes = Driver.GetElementAttributes(namedTextbox);
            if (!elementAttributes.Any(x => x.Contains("_ngcontent")))
                throw new Exception($"'{placeholder}' doesn't have _ngcontent attribute");
            var attribute = elementAttributes.First(x => x.Contains("_ngcontent"));
            //Selector when mat-error inside webElement
            var errorSelector1 = By.XPath($".//ancestor::*[@{attribute}][position() = 1]//mat-error");
            //When on the same level
            var errorSelector2 = By.XPath($".//mat-error[@{attribute}]");
            if (Driver.IsElementInElementDisplayed(namedTextbox, errorSelector1, WebDriverExtensions.WaitTime.Short))
                return namedTextbox.FindElement(errorSelector1);
            else if (Driver.IsElementDisplayed(errorSelector2, WebDriverExtensions.WaitTime.Short))
                return Driver.FindElement(errorSelector2);
            else
                throw new Exception($"Error message was not displayed for '{placeholder}' textbox");
        }

        public IWebElement GetNamedDropdownErrorMessageElement(string placeholder)
        {
            var namedTextbox = GetDropdownByName(placeholder);
            var elementAttributes = Driver.GetElementAttributes(namedTextbox);
            if (!elementAttributes.Any(x => x.Contains("_ngcontent")))
                throw new Exception($"'{placeholder}' doesn't have _ngcontent attribute");
            var attribute = elementAttributes.First(x => x.Contains("_ngcontent"));
            var errorSelector = By.XPath($".//mat-error[@{attribute}]");
            if (!Driver.IsElementDisplayed(errorSelector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"Error message was not displayed for '{placeholder}' textbox");
            return Driver.FindElement(errorSelector);
        }

        public string GetNamedTextboxErrorMessage(string placeholder)
        {
            var error = GetNamedTextboxErrorMessageElement(placeholder).FindElement(By.XPath("./span[1]"));
            return error.Text;
        }

        public string GetNamedDropdownErrorMessage(string placeholder)
        {
            var error = GetNamedDropdownErrorMessageElement(placeholder).FindElement(By.XPath("./span[1]"));
            return error.Text;
        }

        public IWebElement GetNamedTextboxErrorMessageExclamationIcon(string placeholder)
        {
            var exclamationIcon = GetNamedTextboxErrorMessageElement(placeholder).FindElement(By.XPath("./span[2]"));
            return exclamationIcon;
        }

        public IWebElement GetNamedDropdownErrorMessageExclamationIcon(string placeholder)
        {
            var exclamationIcon = GetNamedDropdownErrorMessageElement(placeholder).FindElement(By.XPath("./span[2]"));
            return exclamationIcon;
        }

        public void PopulateNamedTextbox(string placeholder, string value, bool clear = true)
        {
            if (clear)
                GetNamedTextbox(placeholder).Clear();

            if (!string.IsNullOrEmpty(value))
                GetNamedTextbox(placeholder).SendKeys(value);
        }

        public void IsAutocompleteOptionsSorted(string placeholder)
        {
            var list = GetAllAutocompleteOptions(placeholder).ToList();
            SortingHelper.IsListSorted(list);
        }

        public List<string> GetAllAutocompleteOptions(string placeholder)
        {
            GetNamedTextbox(placeholder).Click();

            if (!Driver.IsElementDisplayed(By.XPath(AutocompleteOptionsSelector), WebDriverExtensions.WaitTime.Short))
                throw new Exception($"Options are not displayed for '{placeholder}' autocomplete");

            var foundOptions = AutocompleteDropdown.FindElements(By.XPath(AutocompleteOptionsSelector)).Select(x => x.Text).ToList();

            return foundOptions;
        }

        public void AutocompleteSelect(string placeholder, string option, bool withSearch = false, bool containsOption = false)
        {
            GetNamedTextbox(placeholder).ClearWithBackspaces();
            GetNamedTextbox(placeholder).Click();

            if (withSearch)
            {
                GetNamedTextbox(placeholder).ClearWithBackspaces();
                GetNamedTextbox(placeholder).SendKeys(option);
                if (!Driver.IsElementDisplayed(By.XPath(AutocompleteOptionsSelector),
                    WebDriverExtensions.WaitTime.Short))
                    throw new Exception($"Options are not displayed for '{placeholder}' autocomplete");
            }

            var foundOptions = AutocompleteDropdown.FindElements(By.XPath(AutocompleteOptionsSelector));
            if (foundOptions.Any())
            {
                if (containsOption)
                {
                    if (foundOptions.Any(x => x.Text.Contains(option)))
                        foundOptions.First(x => x.Text.Contains(option)).Click();
                    else
                        throw new Exception(
                            $"There are no option that contains '{option}' text in the '{placeholder}' autocomplete");
                }
                else
                {
                    if (foundOptions.Any(x => x.Text.Equals(option)))
                        foundOptions.First(x => x.Text.Equals(option)).Click();
                    else
                        throw new Exception(
                            $"There are no option that equals '{option}' text in the '{placeholder}' autocomplete");
                }
            }
            else
                throw new Exception($"'{option}' was not found in the '{placeholder}' autocomplete");
        }

        public void InputWithAddButton(string placeholder, string option)
        {
            var button = GetNamedTextbox(placeholder);
            button.Click();
            button.ClearWithBackspaces();
            button.SendKeys(option);
            GetInputAddButton(placeholder).Click();
        }

        public int GetElementTopYCoordinate(IWebElement element)
        {
            return element.Location.Y;
        }

        public int GetElementBottomYCoordinate(IWebElement element)
        {
            return element.Location.Y + element.Size.Height;
        }

        public int GetElementLeftXCoordinate(IWebElement element)
        {
            return element.Location.X;
        }

        public int GetElementRightXCoordinate(IWebElement element)
        {
            return element.Location.X + element.Size.Width;
        }

        public IWebElement GetCorrectApplicationVersion(string versionNumber)
        {
            var selector = By.XPath(
                $".//div[@class='topnav-footer']//span[contains(text(),'{versionNumber}')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubcategoryByCategoryName(string categoryName)
        {
            var selector = By.XPath(
                $"//div[text()='{categoryName}']/../following-sibling::div[contains(@class, 'sub-categories')]//div//span");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
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

        public IWebElement GetColorByName(string colorName)
        {
            var selector = By.XPath(
                $".//span[@class='status-text'][text()='{colorName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonByNameOnPopup(string button)
        {
            return GetButtonByName(button, this.GetStringByFor(() => this.PopupElement));
        }

        public IWebElement GetButtonByName(string button, string parentElementSelector = "")
        {
            var selector = By.XPath(
                $"{parentElementSelector}//span[text()='{button}']/ancestor::button");
            Driver.WaitForDataLoading();
            Driver.WaitForElementsToBeDisplayed(selector, 30, false);
            return Driver.FindElements(selector).First(x => x.Displayed());
        }

        public void ClickButtonByName(string buttonName)
        {
            var button = GetButtonByName(buttonName);
            Driver.WaitForElementToBeEnabled(button);
            button.Click();
            Driver.WaitForDataLoading(50);
        }

        public IWebElement GetButtonOnMessageBoxByNameOnActionPanel(string button)
        {
            var selector = By.XPath($"//div[contains(@class, 'notification')]//span[text()='{button}']/ancestor::button");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public int GetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//div[@class='ag-header-container']//div[@col-id]");
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

        //TODO Should be moved to BaseGrid
        public List<string> GetColumnContent(string columnName)
        {
            var by = By.XPath($".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public List<string> GetColumnTooltips(string columnName)
        {
            var by = By.XPath($".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']");
            return Driver.FindElements(by).Select(x => x.GetAttribute("title")).ToList();
        }

        public List<string> GetColumnColors(string columnName)
        {
            var by = By.XPath($".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']//div[@class='status']");
            return Driver.FindElements(by).Select(x => x.GetAttribute("style")).ToList();
        }

        private string GetColIdByColumnName(string columnName)
        {
            var by = By.XPath($".//span[text()=\"{columnName}\"]/ancestor::div[@col-id]");
            return Driver.FindElement(by).GetAttribute("col-id");
        }

        public string GetColumnWidthByName(string columnName)
        {
            var by = By.XPath($".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']");
            return Driver.FindElement(by).GetCssValue("width");
        }

        public string GetColumnContentByColumnName(string columnName)
        {
            var by = By.XPath($".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']");
            return Driver.FindElement(by).Text;
        }

        public string GetRowContentByColumnName(string columnName)
        {
            var by = By.XPath(
                $".//div[@role='gridcell'][{GetColumnNumberByName(columnName)}]");
            return Driver.FindElement(by).Text;
        }

        public IWebElement GetItalicContentByColumnName(string text)
        {
            var selector = By.XPath($"//span[@class='agEmptyValue'][text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public string ActiveCustomListName()
        {
            var by = By.XPath(
                ".//div[contains(@class, 'active-list')]//span[contains(@class,'name')]");
            Driver.WaitForElement(by);
            return Driver.FindElement(by).Text;
        }

        public void ClickContentByColumnName(string columnName)
        {
            var byControl = By.XPath($".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']//a");

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

        /// <summary>
        /// Get just data from first row
        /// </summary>
        /// <param name="columnName">Column name in the grid</param>
        /// <returns></returns>
        public IWebElement GetContentByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[contains(@class, 'ag-body-container')]/div[1]/div[{GetColumnNumberByName(columnName)}]");

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetHrefByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']//a");

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).GetAttribute("href");
            return Driver.FindElement(byControl);
        }

        public IWebElement GetListElementByName(string listName)
        {
            var selector = By.XPath($".//div[@id='submenuBlock']//*[text()='{listName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            var columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            Driver.WaitForDataLoading();
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitForElementToBeDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public IWebElement GetSettingButtonByName(string settingName)
        {
            Driver.WaitForElementToBeDisplayed(By.XPath($".//span[@ref='eName'][text()='{settingName}']"));
            return Driver.FindElement(By.XPath($".//span[@ref='eName'][text()='{settingName}']"));
        }

        public IWebElement GetSettingOptionByName(string optionName)
        {
            Driver.WaitForElementToBeDisplayed(By.XPath($".//ul[@class='menu-settings']//span[contains(text(), '{optionName}')]"));
            return Driver.FindElement(
                By.XPath($".//ul[@class='menu-settings']//span[contains(text(), '{optionName}')]"));
        }

        public IWebElement GetSettingIconByRowName(string rowName)
        {
            Driver.WaitForElementToBeDisplayed(By.XPath(
                $".//div[@role='row']//a[text()='{rowName}']//ancestor::div[@role='row']//div[@col-id='settings']"));
            return Driver.FindElement(By.XPath(
                $".//div[@role='row']//a[text()='{rowName}']//ancestor::div[@role='row']//div[@col-id='settings']"));
        }

        public IWebElement GetOptionByName(string optionName)
        {
            var selector = By.XPath($".//span[text()='{optionName}']/ancestor::mat-option");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
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

        public IList<IWebElement> GetAllColumnHeaders()
        {
            var selector = By.XPath(".//span[@role='columnheader']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public IList<IWebElement> GetAllColumnHeadersWithSettingMenuColumn()
        {
            var selector = By.XPath("//div[@class='ag-header-row']/div[@class='ag-header-cell ag-header-cell-sortable']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public void ExpandColumnsSectionByName(string sectionsName)
        {
            if (Driver.IsElementExists(By.XPath(
                $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"))
            )
                try
                {
                    Driver.FindElement(By.XPath(
                            $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"))
                        .Click();
                }
                catch
                {
                    Driver.MouseHover(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"));
                    Driver.FindElement(By.XPath(
                            $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"))
                        .Click();
                }

            if (ColumnSubcategories.Any())
                Driver.MouseHover(ColumnSubcategories.Last());
        }

        public void CloseColumnsSectionByName(string sectionsName)
        {
            try
            {
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'clear')]"))
                    .Click();
            }
            catch
            {
                Driver.MouseHover(By.XPath(
                    $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'clear')]"));
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'clear')]"))
                    .Click();
            }
        }

        public IWebElement GetCreateButtonByName(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/ancestor::mat-option");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownWithSearchByFieldName(string name)
        {
            var selector = By.XPath($"//input[@aria-label='{name}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        //TODO should be replaced by GetDropdownByName
        public IWebElement GetDropdownByFieldName(string name)
        {
            var selector = By.XPath($"//*[text()='{name}']/ancestor::div[@class='mat-form-field-infix']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IList<IWebElement> GetTooltipForDay(string dayNumber)
        {
            var selector = By.XPath($".//td[@role='gridcell']//div[text() = '{dayNumber}']/span/span");
            return Driver.FindElements(selector);
        }

        public IWebElement DayInDatePicker(string dayNumber)
        {
            var selector = By.XPath($".//div[text() = '{dayNumber}']/parent::td[@role='gridcell']");
            return Driver.FindElement(selector);
        }

        public string GetDayColumnNumberByName(string dayName)
        {
            var selector = By.XPath($".//thead[@class='mat-calendar-table-header']//th[@aria-label]");

            IList<IWebElement> headers = Driver.FindElements(selector);

            foreach (var header in headers)
            {
                if (header.GetAttribute("aria-label").ToLower().Equals(dayName.ToLower()))
                {
                    int a = headers.IndexOf(header) + 1;
                    return a.ToString();
                }
            }
            return "day not found";
        }

        public IList<IWebElement> GetListOfDaysInDatePicker(string column)
        {
            var selector = By.XPath($".//tbody/tr[@role='row']/td[{column}]");
            return Driver.FindElements(selector);
        }

        public IWebElement GetFirstGridItemByName(string itemName)
        {
            var selector = By.XPath($".//div[@col-id='application' and @role='gridcell']//a[contains(text(), '{itemName}')]");
            return Driver.FindElements(selector).First();
        }

        //For adding Project Scope items, Buckets and Create Teams page
        public void AddItem(string itemName)
        {
            var selector = $".//div[contains(@class,'scrollbar-helper')]//span[contains(text(), '{itemName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        //For adding Project Scope items, Buckets and Create Teams page
        public void AddItemsToMultiSelect(List<string> items)
        {
            foreach (string itemText in items)
            {
                var search = GetNamedTextbox("Search");
                search.Clear();
                search.SendKeys(itemText);
                AddItem(itemText);
                search.ClearWithHomeButton(Driver);
            }
        }

        public IWebElement GetExpandableMultiselect(string titleText)
        {
            var selector =
                By.XPath($".//div[contains(@class,'panel-expand-inner')]//span[contains(text(),'{titleText}')]/..");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"'{titleText}' multiselect was not found");
            return Driver.FindElement(selector);
        }

        public string GetTitleFomExpandableMultiselect(string partOfTitle)
        {
            var element = GetExpandableMultiselect(partOfTitle);
            var text = element.FindElement(By.XPath(".//span[@class='title']")).Text;
            return text;
        }

        public IWebElement ExpandCollapseMultiselectButton(string titleText)
        {
            var buttonSelector = By.XPath(".//button");

            var element = GetExpandableMultiselect(titleText);

            var button = element.FindElement(buttonSelector);
            return button;
        }

        public IWebElement ExpandMultiselectButton(string titleText)
        {
            var buttonSelector = By.XPath(".//button//i[contains(@class,'add')]");

            var element = GetExpandableMultiselect(titleText);

            try
            {
                return element.FindElement(buttonSelector);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IWebElement CollapseMultiselectButton(string titleText)
        {
            var buttonSelector = By.XPath(".//button//i[contains(@class,'clear')]");

            var element = GetExpandableMultiselect(titleText);

            try
            {
                return element.FindElement(buttonSelector);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}