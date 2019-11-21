using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseDashboardPage : SeleniumBasePage
    {
        public const string DatepickerSelector = ".//tbody[@class='mat-calendar-body']";

        public const string DatepickerCellSelector = "//td[contains(@class,'cell')]";

        private string NamedDropdownSelector = ".//mat-select[@aria-label='{0}' or @automation='{0}']|//span[text()='{0}']/ancestor::span[contains(@class,'label')]//preceding-sibling::mat-select";

        private string NamedDropdownForFieldSelector = ".//span[text()='{0}']/../ancestor::tr//mat-select";

        public const string GridCell = ".//div[@role='gridcell']";

        public const string ColumnSubcategory = "//div[@class='selected-column-name']//span";

        public const string FilterSubcategory = "//div[contains(@class, 'sub-categories')]//div//div";

        public const string SelectedFiltersSubcategory = "//div[contains(@class, 'sub-categories')]//div";

        public const string SelectedColumnSubcategory = "//div[contains(@class, 'sub-categories')]//div//span";

        public const string ColumnWithEvergreenIconSelector = ".//div[@col-id='projectName'][@role='gridcell']";

        public const string ImageSelector = ".//i";

        [FindsBy(How = How.XPath, Using = ".//h2")]
        public IWebElement SubHeader { get; set; }

        #region Popup

        private const string PopupSelector = ".//mat-dialog-container";

        [FindsBy(How = How.XPath, Using = PopupSelector)]
        public IWebElement PopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = PopupSelector + "//div[@mat-dialog-title]")]
        public IWebElement PopupTitle { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='content']//i[@class='material-icons mat-menu']")]
        public IWebElement ExpandSideNavPanelIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Open calendar']")]
        public IWebElement DatePickerIcon { get; set; }

        //TODO revisit this 
        [FindsBy(How = How.XPath, Using = ".//admin-header//span[@class='ng-star-inserted']")]
        public IWebElement FoundRowsLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-header']//button[@aria-label='filters']")]
        public IWebElement FilterExpressionIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-panel']//div[@class='context-tools-filters ng-star-inserted']")]
        public IWebElement FiltersExpression { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'pull-left context-toggle')]//i[@class='material-icons mat-clear']")]
        public IWebElement ClosePanelButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'notification')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButtonOnAmberMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'edit-action')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]//div[@class='ag-center-cols-container']")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option//div[contains(@class, 'text-container')]//span")]
        public IList<IWebElement> StringFilterValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-center-cols-viewport']//div[@role='row']")]
        public IList<IWebElement> TableRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']/span")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'save')]//button")]
        public IWebElement SaveCustomListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='filters']")]
        public IWebElement FilterContainerButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'context-header')]//div[@role='group']")]
        public IWebElement FilterOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContainer { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement DoesNotExistListMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-menu')]")]
        public IWebElement AgMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'ag-menu')]//span[@ref='eName']")]
        public IList<IWebElement> AgMenuOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@name='createActions']/div[@class='mat-select-trigger']/ancestor::mat-select")]
        public IWebElement CreateActionButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'DateTime')]/span[contains(text(), ':')]")]
        public IWebElement DateTimeColumnValue { get; set; }

        [FindsBy(How = How.XPath, Using = ColumnSubcategory)]
        public IList<IWebElement> ColumnSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = FilterSubcategory)]
        public IList<IWebElement> FilterSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedFiltersSubcategory)]
        public IList<IWebElement> SelectedFiltersSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedColumnSubcategory)]
        public IList<IWebElement> SelectedColumnsSubcategoryList { get; set; }

        #region TableColumns

        [FindsBy(How = How.XPath, Using = ".//div[@col-id='hostname' and @role='gridcell']//*[contains(text(),'Empty')]")]
        public IList<IWebElement> EmptyColumnDataRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@col-id='computerKey' and @role='gridcell']//span")]
        public IList<IWebElement> DeviceKeyColumnDataRows { get; set; }

        #endregion TableColumns

        private static string NamedTextboxSelector = "(.//textarea[@placeholder='{0}'] | .//input[@placeholder='{0}'])";

        //For cases when more than 4 items are selected they are collapsed to '1 more'
        public string ExpandNamedTextboxSelector = "//preceding-sibling::button[contains(@class,'chips-expand')]";

        //For cases when more than 4 items are selected they are collapsed to '1 more'
        public string SelectedValuesForNamedTextboxSelector = ".//preceding-sibling::mat-chip/span";

        private static string AutocompleteOptionsSelector = ".//mat-option";

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'mat-autocomplete-panel')]")]
        public IWebElement AutocompleteDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By> { };
        }

        public string GetHeaderFontWeight()
        {
            return Driver.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).GetCssValue("font-weight");
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

        public IWebElement GetItalicContentByColumnName(string text)
        {
            var selector = By.XPath($"//span[@class='agEmptyValue'][text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #region Autocomplete

        public List<string> GetAllAutocompleteOptions(string placeholder)
        {
            GetTextbox(placeholder).Click();

            var foundOptions = GetAllOptionsFromOpenedAutocomplete();

            return foundOptions;
        }

        public List<string> GetAllOptionsFromOpenedAutocomplete()
        {
            if (!Driver.IsElementDisplayed(By.XPath(AutocompleteOptionsSelector), WebDriverExtensions.WaitTime.Short))
                throw new Exception($"Options are not displayed for autocomplete");

            var foundOptions =
                AutocompleteDropdown.FindElements(By.XPath(AutocompleteOptionsSelector)).Select(x => x.Text).ToList();

            return foundOptions;
        }

        public void AutocompleteSelect(string placeholder, string searchText, bool withSearch = false, bool containsOption = false, params string[] optionsToSelect)
        {
            GetTextbox(placeholder).ClearWithBackspaces();
            GetTextbox(placeholder).Click();

            //Options to select
            //If we do not provide options to select
            //Then just add option equals to the search text
            List<string> options = new List<string>();
            if (optionsToSelect.Any())
            {
                options.AddRange(optionsToSelect);
            }
            else
            {
                options.Add(searchText);
            }

            if (withSearch)
            {
                GetTextbox(placeholder).ClearWithBackspaces();
                GetTextbox(placeholder).SendKeys(searchText);
                if (!Driver.IsElementDisplayed(By.XPath(AutocompleteOptionsSelector),
                    WebDriverExtensions.WaitTime.Short))
                {
                    throw new Exception($"Options are not displayed for '{placeholder}' autocomplete");
                }
            }

            var foundOptions = AutocompleteDropdown.FindElements(By.XPath(AutocompleteOptionsSelector));
            if (foundOptions.Any())
            {
                if (containsOption)
                {
                    if (foundOptions.Any(x => x.Text.Contains(searchText)))
                    {
                        foreach (string option in options)
                        {
                            foundOptions.First(x => x.Text.Contains(option)).Click();
                            Driver.WaitForDataLoading();
                        }
                    }
                    else
                        throw new Exception(
                            $"There are no option that contains '{searchText}' text in the '{placeholder}' autocomplete");
                }
                else
                {
                    if (foundOptions.Any(x => x.Text.Equals(searchText)))
                    {
                        foreach (string option in options)
                        {
                            foundOptions.First(x => x.Text.Equals(option)).Click();
                            Driver.WaitForDataLoading();
                        }
                    }
                    else
                        throw new Exception(
                            $"There are no option that equals '{searchText}' text in the '{placeholder}' autocomplete");
                }
            }
            else
                throw new Exception($"'{searchText}' was not found in the '{placeholder}' autocomplete");
        }

        #endregion

        #region Textbox

        public IWebElement GetTextbox(string placeholder, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Medium)
        {
            var by = By.XPath(string.Format(NamedTextboxSelector, placeholder));
            if (!Driver.IsElementDisplayed(by, wait))
                throw new Exception($"Textbox with '{placeholder}' placeholder is not displayed");
            return Driver.FindElement(by);
        }

        public void ClearTextbox(string placeholder)
        {
            GetTextbox(placeholder).Clear();
        }

        public void PopulateTextbox(string placeholder, string value, bool clear = true)
        {
            if (clear)
                GetTextbox(placeholder).Clear();

            if (!string.IsNullOrEmpty(value))
                GetTextbox(placeholder).SendKeys(value);
        }

        public void PopulateTextboxWithAddButton(string placeholder, string option)
        {
            var button = GetTextbox(placeholder);
            button.Click();
            button.ClearWithBackspaces();
            button.SendKeys(option);
            GetTextboxAddButton(placeholder).Click();
        }

        public IWebElement GetTextboxAddButton(string placeholder)
        {
            var selector = GetTextbox(placeholder).FindElement(By.XPath(".//../ancestor::mat-form-field//button"));
            Driver.WaitForElementToBeDisplayed(selector);
            return selector;
        }

        public IWebElement GetTextboxErrorMessageElement(string placeholder)
        {
            var namedTextbox = GetTextbox(placeholder);
            var elementAttributes = Driver.GetElementAttributes(namedTextbox);
            if (!elementAttributes.Any(x => x.Contains("_ngcontent")))
            {
                throw new Exception($"'{placeholder}' doesn't have _ngcontent attribute");
            }
            var attribute = elementAttributes.First(x => x.Contains("_ngcontent"));
            //Selector when mat-error inside webElement
            var errorSelector1 = By.XPath($".//ancestor::*[@{attribute}][position() = 1]//mat-error");
            //When on the same level
            var errorSelector2 = By.XPath($".//mat-error[@{attribute}]");
            if (Driver.IsElementInElementDisplayed(namedTextbox, errorSelector1, WebDriverExtensions.WaitTime.Short))
            {
                return namedTextbox.FindElement(errorSelector1);
            }
            else if (Driver.IsElementDisplayed(errorSelector2, WebDriverExtensions.WaitTime.Short))
                return Driver.FindElement(errorSelector2);
            else
            {
                throw new Exception($"Error message was not displayed for '{placeholder}' textbox");
            }
        }

        public string GetTextboxErrorMessage(string placeholder)
        {
            var error = GetTextboxErrorMessageElement(placeholder).FindElement(By.XPath("./span[not (@class)]"));
            return error.Text;
        }

        public IWebElement GetTextboxErrorMessageExclamationIcon(string placeholder)
        {
            var exclamationIcon = GetTextboxErrorMessageElement(placeholder).FindElement(By.XPath("./span[@class]"));
            return exclamationIcon;
        }

        public bool IsTextboxDisplayed(string placeholder)
        {
            try
            {
                return GetTextbox(placeholder, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        public bool IsTextboxDisabled(string placeholder)
        {
            return GetTextbox(placeholder, WebDriverExtensions.WaitTime.Short).Disabled();
        }

        #endregion

        #region Button

        public IWebElement GetButtonByNameOnPopup(string button)
        {
            return GetButtonByName(button, this.GetStringByFor(() => this.PopupElement));
        }

        public IWebElement GetButtonByName(string button, string parentElementSelector = "", WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            var time = int.Parse(waitTime.GetValue());
            var selector = By.XPath(
                $"{parentElementSelector}//span[text()='{button}']/ancestor::button");
            Driver.WaitForDataLoading();
            Driver.WaitForElementsToBeDisplayed(selector, time, false);
            return Driver.FindElements(selector).First(x => x.Displayed());
        }

        public void ClickButtonByName(string buttonName)
        {
            var button = GetButtonByName(buttonName);
            Driver.WaitForElementToBeEnabled(button);
            button.Click();
            Driver.WaitForDataLoading(50);
        }

        public bool IsButtonDisplayed(string dropdownName)
        {
            try
            {
                return GetButtonByName(dropdownName, string.Empty, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Menu button

        public IWebElement GetMenuButtonByName(string button, WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            var time = int.Parse(waitTime.GetValue());
            var selector = By.XPath(
                $".//button[contains(@class,'mat-menu-item')][text()='{button}']");
            Driver.WaitForDataLoading();
            Driver.WaitForElementsToBeDisplayed(selector, time, false);
            return Driver.FindElements(selector).First(x => x.Displayed());
        }

        #endregion

        #region Dropdown

        public IWebElement GetDropdown(string dropdownName, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Long)
        {
            var selector = By.XPath(string.Format(NamedDropdownSelector, dropdownName));
            if (!Driver.IsElementDisplayed(selector, wait))
                throw new Exception($"'{dropdownName}' dropdown is not displayed");
            Driver.WaitForElementToBeEnabled(selector);
            return Driver.FindElement(selector);
        }

        //Index starts from 1
        public IWebElement GetDropdown(string dropdownName, int index)
        {
            index--;
            var selector = By.XPath(string.Format(NamedDropdownSelector, dropdownName));
            Driver.WaitFor(() => Driver.FindElements(selector).Count >= index);
            Driver.WaitForElementToBeDisplayed(Driver.FindElements(selector)[index]);
            return Driver.FindElement(selector);
        }

        public void SelectDropdown(string value, string dropdownName)
        {
            GetDropdown(dropdownName).Click();
            GetDropdownValueByName(value).Click();
        }

        public bool IsDropdownDisplayed(string dropdownName)
        {
            try
            {
                return GetDropdown(dropdownName, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        public bool IsDropdownDisabled(string dropdownName)
        {
            try
            {
                return GetDropdown(dropdownName, WebDriverExtensions.WaitTime.Short).Disabled();
            }
            catch
            {
                return false;
            }
        }

        //Get all span with text
        private string _dropdownOptions = ".//mat-option//span[string-length(text())>0]";

        public IWebElement GetDropdownValueByName(string dropdownName)
        {
            var text = dropdownName.Contains('\'') ?
                dropdownName.Split('\'').Aggregate(string.Empty, (current, s) => current + $"[contains(text(),'{s}')]") :
                $"[text()='{dropdownName}']";
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

        public IWebElement GetDropdownErrorMessageElement(string placeholder)
        {
            var namedTextbox = GetDropdown(placeholder);
            var elementAttributes = Driver.GetElementAttributes(namedTextbox);
            if (!elementAttributes.Any(x => x.Contains("_ngcontent")))
                throw new Exception($"'{placeholder}' doesn't have _ngcontent attribute");
            var attribute = elementAttributes.First(x => x.Contains("_ngcontent"));
            var errorSelector = By.XPath($".//mat-error[@{attribute}]");
            if (!Driver.IsElementDisplayed(errorSelector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"Error message was not displayed for '{placeholder}' textbox");
            return Driver.FindElement(errorSelector);
        }

        public string GetDropdownErrorMessage(string placeholder)
        {
            var error = GetDropdownErrorMessageElement(placeholder).FindElement(By.XPath("./span[not (@class)]"));
            return error.Text;
        }

        public IWebElement GetDropdownErrorMessageExclamationIcon(string placeholder)
        {
            var exclamationIcon = GetDropdownErrorMessageElement(placeholder).FindElement(By.XPath("./span[@class]"));
            return exclamationIcon;
        }

        public IList<IWebElement> GetIconsOfDropdownOptions()
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(_dropdownOptions));
            return Driver.FindElements(By.XPath($"{_dropdownOptions}/preceding-sibling::i[contains(@class, 'material-icons')]"));
        }
        #endregion

        #region Dropdown for field

        public IWebElement GetDropdownForField(string dropdownName)
        {
            var selector = By.XPath(string.Format(NamedDropdownForFieldSelector, dropdownName));
            if (!Driver.IsElementDisplayed(selector))
                throw new Exception($"'{dropdownName}' dropdown is not displayed");
            return Driver.FindElement(selector);
        }

        public void SelectDropdownForField(string value, string fieldName)
        {
            GetDropdownForField(fieldName).Click();
            GetDropdownValueByName(value).Click();
        }

        #endregion

        #region Datepicker

        public int GetDayColumnNumberByNameFromDatepicker(string dayName)
        {
            var selector = By.XPath($".//thead[@class='mat-calendar-table-header']//th[@aria-label]");

            IList<IWebElement> headers = Driver.FindElements(selector);

            foreach (var header in headers)
            {
                if (header.GetAttribute("aria-label").ToLower().Equals(dayName.ToLower()))
                {
                    int a = headers.IndexOf(header);
                    return a;
                }
            }

            throw new Exception($"'{dayName}' day was not found in the DatePicker");
        }

        public IList<IWebElement> GetDatepickerRows()
        {
            return Driver.FindElements(By.XPath($"{DatepickerSelector}//tr[not(@aria-hidden)]"));
        }

        public int DatepickerFirstRowShift()
        {
            var shift = Driver.FindElements(By.XPath($"{DatepickerSelector}//td[@colspan]")).Last().GetAttribute("colspan");
            return int.Parse(shift);
        }

        public IList<IWebElement> GetDaysForWeekDay(string dayOfWeek)
        {
            IList<IWebElement> result = new List<IWebElement>();

            var columnNumber = GetDayColumnNumberByNameFromDatepicker(dayOfWeek);
            var shiftForFirstLine = DatepickerFirstRowShift();
            var rows = GetDatepickerRows();

            var cellSelector = By.XPath($".{DatepickerCellSelector}");

            //Exclude last week
            foreach (IWebElement row in rows.ToList().GetRange(0, rows.Count - 1))
            {
                //In this case month starts NOT from Sat
                if (row.FindElements(cellSelector).Count < 7)
                {
                    result.Add(rows.First().FindElements(cellSelector)[columnNumber - shiftForFirstLine]);
                }
                else
                {
                    result.Add(row.FindElements(cellSelector)[columnNumber]);
                }
            }

            //Last week can contains less than 7 days
            try
            {
                result.Add(rows.Last().FindElements(cellSelector)[columnNumber]);
            }
            catch (ArgumentOutOfRangeException) { }

            return result;
        }

        public IWebElement DayInDatePicker(int dayNumber)
        {
            var selector = By.XPath($"{DatepickerSelector}{DatepickerCellSelector}/div[text()='{dayNumber}']/..");
            return Driver.FindElement(selector);
        }

        #endregion

        #region Expandable multiselect

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
                var search = GetTextbox("Search");
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

        //Top level element with search box and all items
        public IWebElement GetExpandableMultiselectElement(string titleText)
        {
            var element = GetExpandableMultiselect(titleText).FindElement(By.XPath("./ancestor::div[contains(@class,'sectionAddObjects')]"));
            return element;
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

        #endregion

        #region Checkbox

        public IWebElement GetCheckbox(string ariaLabel)
        {
            //TODO mb first selector in the or statement should be deleted
            var selector = By.XPath($".//mat-checkbox[@aria-label='{ariaLabel}']|.//input[@aria-label='{ariaLabel}']//ancestor::mat-checkbox|.//span[text()='{ariaLabel}']//ancestor::mat-checkbox");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
            {
                throw new Exception($"'{ariaLabel}' checkbox was not displayed");
            }

            return Driver.FindElement(selector);
        }

        public bool IsCheckboxEnabled(string ariaLabel)
        {
            var enabled = GetCheckbox(ariaLabel).FindElement(By.XPath(".//input")).Enabled;
            return enabled;
        }

        #endregion

        #region Chips

        public IList<IWebElement> GetChipsOfTextbox(string textbox)
        {
            var chipsSelector = By.XPath("./ancestor::div[contains(@class, 'multiselect')]//span[contains(@class, 'chips-item')]");
            return GetTextbox(textbox).FindElements(chipsSelector);
        }

        #endregion
    }
}