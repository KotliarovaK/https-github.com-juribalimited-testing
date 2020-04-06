using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseDashboardPage : SeleniumBasePage
    {
        public const string CategoryCollapseExpandSelector = ".//*[contains(@class, 'filter-category-label')][text()='{0}']//ancestor::div[contains(@class, 'category-title')]//i";

        public const string DatepickerSelector = ".//tbody[@class='mat-calendar-body']";

        public const string DatepickerCellSelector = "//td[contains(@class,'cell')]";

        private string NamedDropdownSelector = ".//mat-select[@aria-label='{0}' or @automation='{0}']|//*[text()='{0}']/ancestor::span[contains(@class,'label')]//preceding-sibling::mat-select";

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

        [FindsBy(How = How.XPath, Using = ".//h3")]
        public IWebElement SecondLevelSubHeader { get; set; }

        private const string TextEditorSelector = ".//quill-editor/..";

        [FindsBy(How = How.XPath, Using = TextEditorSelector)]
        public IWebElement TextEditor { get; set; }

        [FindsBy(How = How.XPath, Using = TextEditorSelector + "//div[contains(@class,'ql-editor')]")]
        public IWebElement TextEditorInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='content']//i[@class='material-icons mat-menu']")]
        public IWebElement ExpandSideNavPanelIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Open calendar']")]
        public IWebElement DatePickerIcon { get; set; }

        private const string MenuPanelSelector = ".//div[@class='mat-menu-content']";
        [FindsBy(How = How.XPath, Using = MenuPanelSelector)]
        public IWebElement MenuPanelElement { get; set; }

        //TODO revisit this 
        [FindsBy(How = How.XPath, Using = ".//admin-header//span[@class='ng-star-inserted']")]
        public IWebElement FoundRowsLabel { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'edit-action')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IWebElement SelectOneRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error ng-star-inserted']")]
        public IWebElement ErrorMessage { get; set; }

        //TODO more to the BaseGrid
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-tip')]//div[@class='inline-box-text']")]
        public IWebElement WarningMessageText { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement DoesNotExistListMessage { get; set; }

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

        private static string NamedTextboxSelector = "(.//textarea[@placeholder='{0}'] | .//input[@placeholder='{0}'] | .//input[@automation='{0}'])";

        //For cases when more than 4 items are selected they are collapsed to '1 more'
        public string ExpandNamedTextboxSelector = "//preceding-sibling::button[contains(@class,'chips-expand')]";

        //For cases when more than 4 items are selected they are collapsed to '1 more'
        public string SelectedValuesForNamedTextboxSelector = ".//preceding-sibling::mat-chip/span";

        private static string AutocompleteOptionsSelector = ".//mat-option[@tabindex!='-1']";

        private static string AutocompleteSelectOptionsSelector = ".//ul//mat-checkbox";

        private static string AutocompleteValidationMessageSelector = ".//mat-option[@tabindex='-1']//span";
        private static string AutocompleteResultsMessageSelector = ".//div[@aria-live='assertive']";

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'mat-autocomplete-panel')]")]
        public IWebElement AutocompleteDropdown { get; set; }

        //For dropdown with checkboxes
        private const string AutocompleteSelectDropdownSelector = ".//div[contains(@class,'dropdown-select')]";
        [FindsBy(How = How.XPath, Using = AutocompleteSelectDropdownSelector)]
        public IWebElement AutocompleteSelectDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By> { };
        }

        //TODO Find out what this method is doing and remove ti from BDP, for now test is marked as Not_Run and it is not possible to execute it
        public IWebElement GetItalicContentByColumnName(string text)
        {
            var selector = By.XPath($"//span[@class='agEmptyValue'][text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCustomListPrefix() =>
            ActiveCustomListEdited.FindElement(By.XPath("./preceding-sibling::span"));

        #region Link

        public IWebElement GetLinkByText(string text, string parentElementSelector = "", WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            var selector = By.XPath($"{parentElementSelector}//span[contains(@class, 'inline-link')]//a[text()='{text}']");
            if (!Driver.IsElementDisplayed(selector, waitTime))
            {
                throw new Exception($"Link with text '{text}' was not displayed");
            }

            return Driver.FindElement(selector);
        }

        public bool IsLinkDisplayed(string text, string parentElementSelector = "")
        {
            try
            {
                return GetLinkByText(text, parentElementSelector, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Autocomplete

        //For dropdown with checkboxes
        public List<string> GetAllAutocompleteSelectOptions(string placeholder)
        {
            GetTextbox(placeholder).Click();

            var foundOptions = GetAllSelectOptionsFromOpenedAutocomplete();

            return foundOptions;
        }

        public List<string> GetAllAutocompleteOptions(string placeholder)
        {
            GetTextbox(placeholder).Click();

            var foundOptions = GetAllOptionsFromOpenedAutocomplete();

            return foundOptions;
        }

        public List<string> GetAllOptionsFromOpenedAutocomplete()
        {
            if (!Driver.IsElementInElementDisplayed(AutocompleteDropdown, By.XPath(AutocompleteOptionsSelector), WebDriverExtensions.WaitTime.Short))
                throw new Exception($"Options are not displayed for autocomplete");

            var foundOptions =
                AutocompleteDropdown.FindElements(By.XPath(AutocompleteOptionsSelector)).Select(x => x.Text).ToList();

            return foundOptions;
        }

        public List<string> GetAllSelectOptionsFromOpenedAutocomplete()
        {
            if (!Driver.IsElementInElementDisplayed(AutocompleteSelectDropdown, By.XPath(AutocompleteSelectOptionsSelector), WebDriverExtensions.WaitTime.Short))
                throw new Exception($"Select options are not displayed for autocomplete");

            var foundOptions =
                AutocompleteSelectDropdown.FindElements(By.XPath(AutocompleteSelectOptionsSelector)).Select(x => x.Text).ToList();

            return foundOptions;
        }

        public string GetAutocompleteValidationMessage(string placeholder)
        {
            GetTextbox(placeholder).Click();
            Driver.WaitForElementInElementToBeDisplayed(AutocompleteDropdown, By.XPath(AutocompleteValidationMessageSelector));
            var validationMessage =
                AutocompleteDropdown.FindElements(By.XPath(AutocompleteValidationMessageSelector)).First().Text;
            return validationMessage;
        }

        private IWebElement GetAutocompleteResultsCountElement()
        {
            Driver.WaitForElementInElementToBeDisplayed(AutocompleteSelectDropdown, By.XPath(AutocompleteResultsMessageSelector), 5);
            return AutocompleteSelectDropdown.FindElement(By.XPath(AutocompleteResultsMessageSelector));
        }

        public bool IsAutocompleteResultsCountMessageDisplayed()
        {
            try
            {
                return GetAutocompleteResultsCountElement().Displayed();
            }
            catch
            {
                return false;
            }
        }

        public string GetAutocompleteResultsCountMessage()
        {
            var message =
                GetAutocompleteResultsCountElement().Text;
            return message;
        }

        public void AutocompleteSelect(string placeholder, string searchText, bool withSearch = false, bool containsOption = false, params string[] optionsToSelect)
        {
            var textbox = GetTextbox(placeholder);
            textbox.ClearWithBackspaces();
            textbox.Click();

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
                textbox.ClearWithBackspaces();
                textbox.SendKeys(searchText);
                if (!Driver.IsElementDisplayed(By.XPath(AutocompleteOptionsSelector),
                    WebDriverExtensions.WaitTime.Short))
                {
                    throw new Exception($"Options are not displayed for '{placeholder}' autocomplete");
                }
            }

            Driver.WaitForElementInElementToBeDisplayed(AutocompleteDropdown, By.XPath(AutocompleteOptionsSelector));
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

        public void AutocompleteSelectCheckboxes(string placeholder, string searchText, bool state, bool withSearch = false, params string[] optionsToSelect)
        {
            var textbox = GetTextbox(placeholder);
            textbox.Click();

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
                textbox.ClearWithBackspaces();
                textbox.SendKeys(searchText);
            }

            Driver.WaitForElementInElementToBeDisplayed(AutocompleteSelectDropdown, By.XPath(AutocompleteSelectOptionsSelector));
            var foundOptions = AutocompleteSelectDropdown.FindElements(By.XPath(AutocompleteSelectOptionsSelector));
            if (foundOptions.Any())
            {
                foreach (string option in options)
                {
                    SetCheckboxState(option, state, AutocompleteSelectDropdownSelector);
                }
            }
            else
                throw new Exception($"'{searchText}' was not found in the '{placeholder}' autocomplete");
        }

        public bool IsAutocompleteCheckboxDisplayed(string checkbox)
        {
            var resutls = IsCheckboxDisplayed(checkbox, AutocompleteSelectDropdownSelector);
            return resutls;
        }

        #endregion

        #region Textbox

        public IWebElement GetTextbox(string placeholder, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Medium)
        {
            var by = By.XPath(string.Format(NamedTextboxSelector, placeholder));
            if (!Driver.IsElementDisplayed(by, wait))
            {
                throw new Exception($"Textbox with '{placeholder}' placeholder is not displayed");
            }
            return Driver.FindElement(by);
        }

        public void ClearTextbox(string placeholder, bool withBackspaces = false)
        {
            var element = GetTextbox(placeholder);
            if (withBackspaces)
            {
                element.ClearWithBackspaces();
            }
            else
            {
                element.Clear();
            }
        }

        public void PopulateTextbox(string placeholder, string value, bool clear = true)
        {
            if (clear)
            {
                GetTextbox(placeholder).Clear();
            }

            if (!string.IsNullOrEmpty(value))
            {
                GetTextbox(placeholder).SendKeys(value);
            }
        }

        public void PopulateTextboxWithAddButton(string placeholder, string option)
        {
            var button = GetTextbox(placeholder);
            button.Click();
            button.ClearWithBackspaces();
            button.SendKeys(option);
            GetTextboxAddButton(placeholder).Click();
        }

        public IWebElement GetFieldHint(string placeholder)
        {
            var hitSelector = By.XPath("./ancestor::div[@class='mat-form-field-wrapper']//mat-hint");
            Driver.WaitForElementInElementToBeDisplayed(GetTextbox(placeholder), hitSelector);
            return GetTextbox(placeholder).FindElement(hitSelector);
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

        private By textboxInfoSelector = By.XPath("./span[contains(@class,'info-text')]");

        public string GetTextboxInfoMessage(string placeholder)
        {
            var error = GetTextboxErrorMessageElement(placeholder).FindElement(textboxInfoSelector);
            return error.Text;
        }

        public void WaitForTextboxInfoMessageDisappears(string placeholder)
        {
            try
            {
                Driver.WaitForElementToBeNotDisplayed(GetTextboxErrorMessageElement(placeholder), textboxInfoSelector);
            }
            catch
            {
                //No error/info message located. Nothing to wait
            }
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

        public bool IsTextboxDisplayedWithError(string name)
        {
            try
            {
                return GetTextboxErrorMessageElement(name).Displayed();
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

        public bool IsTextboxFocused(string placeholder)
        {
            return GetTextbox(placeholder, WebDriverExtensions.WaitTime.Short)
                .FindElement(By.XPath(".//ancestor::mat-form-field")).IsElementFocused();
        }

        #endregion

        #region Button

        public List<IWebElement> GetButtons(string button, string parentElementSelector = "",
            WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            var time = int.Parse(waitTime.GetValue());
            var selector = By.XPath(
                $"{parentElementSelector}//span[text()='{button}']/ancestor::button");
            Driver.WaitForDataLoading();
            Driver.WaitForElementsToBeDisplayed(selector, time, false);
            return Driver.FindElements(selector).ToList();
        }

        public IWebElement GetButton(string button, string parentElementSelector = "", WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            return GetButtons(button, parentElementSelector, waitTime).First(x => x.Displayed());
        }

        public void ClickButton(string buttonName)
        {
            var button = GetButton(buttonName);
            Driver.WaitForElementToBeEnabled(button);
            button.Click();
            Driver.WaitForDataLoading(50);
        }

        //index starts from zero
        public void ClickButton(string buttonName, int index)
        {
            var buttons = GetButtons(buttonName);
            Driver.WaitForElementsToBeDisplayed(buttons);
            if (buttons.Count < index + 1)
            {
                throw new Exception($"Unable to click '{buttonName}' button with {index} index");
            }
            buttons[index].Click();
        }

        public bool IsButtonDisplayed(string name)
        {
            try
            {
                return GetButton(name, string.Empty, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Button with aria-label

        public IWebElement GetButtonWithAriaLabel(string ariaLabel, string parentElementSelector = "", WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            var time = int.Parse(waitTime.GetValue());
            var selector = By.XPath(
                $"{parentElementSelector}//button[contains(@aria-label,'{ariaLabel}')]");
            Driver.WaitForElementsToBeDisplayed(selector, time, false);
            return Driver.FindElements(selector).First(x => x.Displayed());
        }

        public void ClickButtonWithAriaLabel(string buttonName)
        {
            var button = GetButtonWithAriaLabel(buttonName);
            Driver.WaitForElementToBeEnabled(button);
            button.Click();
        }

        public bool IsButtonDisplayedWithAriaLabel(string name)
        {
            try
            {
                return GetButtonWithAriaLabel(name, string.Empty, WebDriverExtensions.WaitTime.Short).Displayed();
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

        public bool IsMenuButtonDisplayed(string button)
        {
            try
            {
                return GetMenuButtonByName(button, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Dropdown

        public IWebElement GetDropdown(string dropdownName, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Long, bool focusOnDropDown = false)
        {
            var selector = By.XPath(string.Format(NamedDropdownSelector, dropdownName));
            if (!Driver.IsElementExists(selector, wait))
            {
                throw new Exception($"'{dropdownName}' dropdown is not exists");
            }
            if (focusOnDropDown)
            {
                Driver.MouseHover(selector);
            }

            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Short))
            {
                throw new Exception($"'{dropdownName}' dropdown is not displayed");
            }

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
            var ddValue = GetDropdownValueByName(value);
            Driver.MouseHover(ddValue);
            ddValue.Click();
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
        private static string _dropdownOptionsBase = ".//mat-option{0}//span[string-length(text())>0]";

        private string DropdownOptionsSelector(bool withoutSelected)
        {
            return withoutSelected
                ? string.Format(_dropdownOptionsBase, "[not(@aria-selected)]")
                : string.Format(_dropdownOptionsBase, string.Empty);
        }

        public IWebElement GetDropdownValueByName(string dropdownName, bool withoutSelected = false)
        {
            var text = dropdownName.Contains('\'') ?
                dropdownName.Split('\'').Aggregate(string.Empty, (current, s) => current + $"[contains(text(),'{s}')]") :
                $"[text()='{dropdownName}']";
            var selector = By.XPath($"{DropdownOptionsSelector(withoutSelected)}{text}");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<string> GetDropdownValues(bool withoutSelected = false)
        {
            var selector = DropdownOptionsSelector(withoutSelected);
            Driver.WhatForElementToBeExists(By.XPath(selector));
            var optionsList = Driver.FindElements(By.XPath(selector));
            Driver.WaitForElementsToHaveText(optionsList, false);
            if (!optionsList.Any())
            {
                throw new Exception($"Unable to get dropdown values");
            }
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

        public IList<IWebElement> GetIconsOfDropdownOptions(bool withoutSelected = false)
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(DropdownOptionsSelector(withoutSelected)));
            return Driver.FindElements(By.XPath($"{DropdownOptionsSelector(withoutSelected)}/preceding-sibling::i[contains(@class, 'material-icons')]"));
        }

        public bool IsIconDisplayedFromDropdownOptions(string iconName, bool withoutSelected = false)
        {
            var selector = By.XPath($"{DropdownOptionsSelector(withoutSelected)}/parent::div//i[contains(@class, '{iconName}')]");
            return Driver.IsElementDisplayed(selector);
        }

        public bool IsDropdownOpened(bool withoutSelected = false)
        {
            return Driver.FindElements(By.XPath(DropdownOptionsSelector(withoutSelected))).Any();
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

        public IWebElement GetCheckbox(string ariaLabel, string parentElementSelector = "", WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Long)
        {
            //TODO mb first selector in the or statement should be deleted
            var selector = By.XPath($"{parentElementSelector}//mat-checkbox[@aria-label='{ariaLabel}']|.//input[@aria-label='{ariaLabel}']//ancestor::mat-checkbox|.//span[text()='{ariaLabel}']//ancestor::mat-checkbox");
            if (!Driver.IsElementDisplayed(selector, wait))
            {
                throw new Exception($"'{ariaLabel}' checkbox was not displayed");
            }

            return Driver.FindElement(selector);
        }

        public void SetCheckboxState(string ariaLabel, bool expectedCondition, string parentElementSelector = "")
        {
            if (!GetCheckbox(ariaLabel, parentElementSelector).Equals(expectedCondition))
            {
                //We must click by text to check or uncheck element
                Driver.ClickElementLeftCenter(GetCheckbox(ariaLabel));
            }
        }

        public bool IsCheckboxEnabled(string ariaLabel)
        {
            var enabled = GetCheckbox(ariaLabel, string.Empty, WebDriverExtensions.WaitTime.Medium)
                .FindElement(By.XPath(".//input")).Enabled;
            return enabled;
        }

        public bool IsCheckboxDisplayed(string ariaLabel, string parentElementSelector = "")
        {
            try
            {
                return GetCheckbox(ariaLabel, parentElementSelector, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Checkbox mat-option

        public List<IWebElement> GetMatOptionCheckboxes(string parentElementSelector = "", WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Long)
        {
            var checkboxes = By.XPath($"{parentElementSelector}//mat-option[contains(@class,'mat-option')]");
            Driver.WaitForElementsToBeDisplayed(checkboxes);
            return Driver.FindElements(checkboxes).ToList();
        }

        public IWebElement GetMatOptionCheckbox(string checkbox, string parentElementSelector = "", WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Long)
        {
            foreach (IWebElement element in GetMatOptionCheckboxes(parentElementSelector, wait))
            {
                try
                {
                    var text = element.Text;
                }
                catch (Exception e)
                {
                    var t = e;
                }
            }
            if (GetMatOptionCheckboxes(parentElementSelector, wait)
                .Any(x => x.Text.Equals(checkbox)))
            {
                return GetMatOptionCheckboxes(parentElementSelector, wait)
                    .First(x => x.Text.Equals(checkbox));
            }
            else
            {
                throw new Exception($"Unable to get '{checkbox}' mat-option checkbox");
            }
        }

        public bool IsMatOptionCheckboxDisplayed(string checkbox, string parentElementSelector = "")
        {
            try
            {
                return GetMatOptionCheckbox(checkbox, parentElementSelector, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        public bool GetMatOptionCheckboxState(string checkbox, string parentElementSelector = "")
        {
            var cb = GetMatOptionCheckbox(checkbox, parentElementSelector);
            var state = bool.Parse(cb.GetAttribute("aria-selected"));
            return state;
        }

        public void SetMatOptionCheckboxState(string checkbox, bool expectedCondition, string parentElementSelector = "")
        {
            if (!GetMatOptionCheckboxState(checkbox, parentElementSelector).Equals(expectedCondition))
            {
                //We must click by text to check or uncheck element
                GetMatOptionCheckbox(checkbox, parentElementSelector).Click();
            }
        }

        #endregion

        #region Radio Button

        public IWebElement GetRadioButton(string ariaLabel, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Long)
        {
            var selector = By.XPath($".//div[contains(@class, 'radio-label') and text()='{ariaLabel}']/ancestor::mat-radio-button");
            if (!Driver.IsElementDisplayed(selector, wait))
            {
                throw new Exception($"'{ariaLabel}' radio button was not displayed");
            }
            return Driver.FindElement(selector);
        }

        public void SetRadioButtonState(string ariaLabel, bool state)
        {
            if (!IsRadioButtonChecked(ariaLabel).Equals(state))
            {
                GetRadioButton(ariaLabel).Click();
            }
        }

        public bool IsRadioButtonChecked(string ariaLabel)
        {
            var classValue = GetRadioButton(ariaLabel).GetAttribute("class");
            return classValue.Contains("mat-radio-checked");
        }

        public bool IsRadioButtonEnabled(string ariaLabel)
        {
            var classValue = GetRadioButton(ariaLabel).GetAttribute("class");
            return !classValue.Contains("mat-radio-disabled");
        }

        #endregion

        #region Chips

        public IList<IWebElement> GetChipsInTheTextbox(string textbox)
        {
            var chipsSelector = By.XPath("./ancestor::*[contains(@id,'mat-chip-list')]/div");
            return GetTextbox(textbox).FindElements(chipsSelector);
        }

        public IList<IWebElement> GetChipsOfTextbox(string textbox)
        {
            var chipsSelector = By.XPath("./ancestor::div//span[contains(@class, 'chips-item')]");
            return GetTextbox(textbox).FindElements(chipsSelector);
        }

        public IList<IWebElement> GetChipsForButton(string button, int index = 0)
        {
            var chipsSelector = By.XPath(".//ancestor::li[contains(@class,'chips-btn')]//preceding-sibling::li");
            var buttonElement = GetButtons(button)[index];
            return buttonElement.FindElements(chipsSelector);
        }

        #endregion

        #region Collapse/Expand Category

        public IWebElement CategoryCollapseExpandButton(string name)
        {
            var selector = By.XPath(string.Format(CategoryCollapseExpandSelector, name));
            try
            {
                Driver.MouseHover(selector);
                if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
                {
                    throw new Exception($"Collapse/Expand button was not displayed for '{name}' category");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Driver.FindElement(selector);
        }

        //true for Expanded
        public bool IsCategoryExpanded(string name)
        {
            return CategoryCollapseExpandButton(name).GetAttribute("class").Contains("clear");
        }

        //true to Expand
        public void CollapseExpandCategory(string name, bool condition)
        {
            if (!IsCategoryExpanded(name).Equals(condition))
            {
                try
                {
                    CategoryCollapseExpandButton(name).Click();
                }
                catch
                {
                    Driver.MouseHover(CategoryCollapseExpandButton(name));
                    CategoryCollapseExpandButton(name).Click();
                }
            }
        }

        #endregion

        #region Menu Panel

        //This menu appears for example by click on Group By on agGrid
        //mat-menu-panel > mat-menu-content

        public List<KeyValuePair<string, bool>> GetAllOptionsFromMenuPanel()
        {
            Driver.WaitForElementToBeDisplayed(MenuPanelElement);
            var allOptions = MenuPanelElement.FindElements(By.XPath("./mat-checkbox"));
            List<KeyValuePair<string, bool>> result = new List<KeyValuePair<string, bool>>();
            foreach (IWebElement option in allOptions)
            {
                //TODO rework to use Checkbox methods
                var text = option.FindElement(By.XPath(".//span[@class='mat-checkbox-label']")).Text.TrimStart(' ');
                var selected = option.FindElement(By.XPath(".//input[@type='checkbox']")).Selected;
                result.Add(new KeyValuePair<string, bool>(text, selected));
            }
            return result;
        }

        public IWebElement GetCheckboxFromMenuPanel(string checkbox)
        {
            return GetCheckbox(checkbox, MenuPanelSelector);
        }

        public void SetCheckboxStateFromMenuPanel(string ariaLabel, bool expectedCondition)
        {
            SetCheckboxState(ariaLabel, expectedCondition, MenuPanelSelector);
        }

        #endregion

        #region Slide toggle

        public IWebElement GetSlideToggle(string slideToggle)
        {
            return Driver.FindElement(By.XPath($".//mat-slide-toggle//span[text()='{slideToggle}']"));
        }

        public bool GetDisplayStateForSlideToggle(string slideToggle)
        {
            return Driver.IsElementDisplayed(By.XPath($".//mat-slide-toggle//span[text()='{slideToggle}']"));
        }

        public bool GetSlideToggleCondition(string slideToggle)
        {
            return GetSlideToggle(slideToggle).GetAttribute("class").Contains("checked");
        }

        public void SetSlideToggleCondition(string slideToggle, bool expectedCondition)
        {
            if (!GetSlideToggleCondition(slideToggle).Equals(expectedCondition))
                GetSlideToggle(slideToggle).Click();
        }

        #endregion

        #region Icons

        public IWebElement GetIcon(string iconTextInDom)
        {
            return Driver.FindElement(By.XPath($".//i[@class='material-icons'][text()='{iconTextInDom}']"));
        }

        #endregion
    }
}