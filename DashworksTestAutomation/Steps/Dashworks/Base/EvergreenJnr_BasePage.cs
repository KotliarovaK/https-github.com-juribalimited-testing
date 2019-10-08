using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables.Rings;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails.CustomFields;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    //ONLY actions with BaseDashboardPage !!!
    [Binding]
    class EvergreenJnr_BasePage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly AutomationActions _automationActions;
        private readonly Slots _slots;
        private readonly Rings _rings;
        private readonly Automations _automations;
        private readonly CapacityUnits _capacityUnits;

        public EvergreenJnr_BasePage(RemoteWebDriver driver, AutomationActions automationActions, Automations automations,
            Slots slots, Rings rings, CapacityUnits capacityUnits)
        {
            _driver = driver;
            _automationActions = automationActions;
            _automations = automations;
            _slots = slots;
            _rings = rings;
            _capacityUnits = capacityUnits;
        }

        #region Page Header/SubHeader

        [Then(@"'(.*)' page subheader is displayed to user")]
        public void ThenPageSubheaderIsDisplayedToUser(string subheader)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.SubHeader);
            Verify.AreEqual(subheader, page.SubHeader.Text, "Incorrect page subheader");
        }

        #endregion

        #region Named Autocomplete

        [Then(@"'(.*)' autocomplete last option is '(.*)'")]
        public void ThenAutocompleteLastOptionIs(string placeholder, string option)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var options = page.GetAllAutocompleteOptions(placeholder);
            Verify.AreEqual(option, options.Last(),
                $"'{option}' option should be in the bottom of the '{placeholder}' autocomplete");
        }

        [Then(@"'(.*)' autocomplete does NOT have options")]
        public void ThenAutocompleteDoesNotHaveOptions(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var options = page.GetAllAutocompleteOptions(placeholder);

            foreach (TableRow tableRow in table.Rows)
            {
                Verify.IsFalse(options.Contains(tableRow["Options"]), $"'{placeholder}' autocomplete have '{tableRow["Options"]}' option");
            }
        }

        [Then(@"'(.*)' autocomplete options are sorted in the alphabetical order")]
        public void ThenAutocompleteOptionsAreSortedInTheAlphabeticalOrder(string field)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            if (field.Equals("Bucket") || field.Equals("Capacity Unit") || field.Equals("Ring"))
            {
                page.GetNamedTextbox(field).Click();
                var listWithoutUnassigned = page.GetAllAutocompleteOptions(field).Where(x => !x.Contains("Unassigned")).ToList();
                Verify.AreEqual(listWithoutUnassigned.OrderBy(s => s), listWithoutUnassigned,
                    $"Options in the '{field}' autocomplete are not in alphabetical order");
            }
            else
            {
                page.GetNamedTextbox(field).Click();
                var list = page.GetAllAutocompleteOptions(field).ToList();
                Verify.AreEqual(list.OrderBy(s => s), list,
                    $"Options in the '{field}' autocomplete are not in alphabetical order");
            }

            page.BodyContainer.Click();
        }

        [Then(@"only below options are displayed in the '(.*)' autocomplete")]
        public void ThenOnlyBelowOptionsAreDisplayedInTheAutocomplete(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedOptions = table.Rows.SelectMany(row => row.Values).ToList();
            var actualOptions = page.GetAllAutocompleteOptions(placeholder);
            
            Verify.AreEqual(expectedOptions, actualOptions, $"Value for {placeholder} are different");
        }

        [Then(@"'(.*)' autocomplete contains following options:")]
        public void ThenAutocompleteContainsFollowingOptions(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var actualOptions = page.GetAllAutocompleteOptions(placeholder);

            Utils.Verify.That(actualOptions,
                Is.SupersetOf(table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault())),
                "Some options are missing!");
        }

        [When(@"User selects '(.*)' option from '(.*)' autocomplete")]
        public void WhenUserSelectsOptionFromAutocomplete(string option, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.AutocompleteSelect(placeholder, option);
        }

        [When(@"User selects '(.*)' option after search from '(.*)' autocomplete")]
        public void WhenUserSelectsOptionAfterSearchFromAutocomplete(string option, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.AutocompleteSelect(placeholder, option, true);
        }

        [Then(@"'(.*)' content is displayed in '(.*)' autocomplete")]
        public void ThenContentIsDisplayedInAutocomplete(string expectedText, string placeholder)
        {
            CheckAutocompletAndTextboxText(placeholder, expectedText);
        }

        [Then(@"'(.*)' content is not displayed in '(.*)' autocomplete after search")]
        public void ThenContentIsNotDisplayedInAutocompleteAfterSearch(string content, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateNamedTextbox(placeholder, content);
            Utils.Verify.IsFalse(page.AutocompleteDropdown.Displayed(), $"{content} text is displayed in the {placeholder} autocomplete");
        }

        private void CheckAutocompletAndTextboxText(string placeholder, string expectedText)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var text = page.GetNamedTextbox(placeholder).GetAttribute("value");
            Verify.AreEqual(expectedText, text, "Incorrect text in the autocomplete");
        }

        #endregion

        #region Named Textbox

        [When(@"User enters '(.*)' text to '(.*)' textbox")]
        public void WhenUserEntersTextToTextbox(string text, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetNamedTextbox(placeholder).Clear();
            page.GetNamedTextbox(placeholder).SendKeys(text);
            page.BodyContainer.Click();

            if (placeholder.Equals("Action Name"))
                _automationActions.Value.Add(text);

            if (placeholder.Equals("Slot Name"))
                _slots.Value.Add(new SlotDto() { SlotName = text });

            if (placeholder.Equals("Automation Name"))
                _automations.Value.Add(new AutomationsDto() { automationName = text });

            if (placeholder.Equals("Ring name"))
                _rings.Value.Add(new RingDto() { Name = text });

            if (placeholder.Equals("Capacity Unit Name"))
                _capacityUnits.Value.Add(new CapacityUnitDto() { Name = text });

            _driver.WaitForDataLoading();
        }

        [Then(@"'(.*)' content is displayed in '(.*)' textbox")]
        public void ThenContentIsDisplayedInTextbox(string expectedText, string placeholder)
        {
            CheckAutocompletAndTextboxText(placeholder, expectedText);
        }

        [Then(@"'(.*)' error message is displayed for '(.*)' field")]
        public void ThenErrorMessageIsDisplayedForField(string errorMessage, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.BodyContainer.Click();

            Verify.AreEqual(errorMessage, page.GetNamedTextboxErrorMessage(placeholder),
                $"Incorrect error message is displayed in the '{placeholder}' field");

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetNamedTextboxErrorMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetNamedTextboxErrorMessageExclamationIcon(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field exclamation icon");
        }

        [When(@"User adds '(.*)' value from '(.*)' textbox")]
        public void WhenUserAddsValueFromTextbox(string option, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.InputWithAddButton(fieldName, option);
        }

        [Then(@"'(.*)' add button tooltip is displayed for '(.*)' textbox")]
        public void ThenAddButtonTooltipIsDisplayedForTextbox(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetInputAddButton(fieldName);
            page.BodyContainer.Click();
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.AreEqual(text, toolTipText, $"Incorrect tooltip for Add button in the {fieldName} textbox");
        }

        [Then(@"Add button for '(.*)' textbox is disabled")]
        public void ThenAddButtonForTextboxIsDisabled(string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(Convert.ToBoolean(page.GetInputAddButton(fieldName).Disabled()), $"Add button for {fieldName} textbox is active");
        }

        #endregion

        #region Dropdown

        [Then(@"'(.*)' error message is displayed for '(.*)' dropdown")]
        public void ThenErrorMessageIsDisplayedForDropdown(string errorMessage, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.BodyContainer.Click();

            Verify.AreEqual(errorMessage, page.GetNamedDropdownErrorMessage(placeholder),
                $"Incorrect error message is displayed in the '{placeholder}' field");

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetNamedDropdownErrorMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetNamedDropdownErrorMessageExclamationIcon(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field exclamation icon");
        }

        [When(@"User selects '(.*)' in the '(.*)' dropdown")]
        public void WhenUserSelectsInTheDropdown(string value, string dropdownName)
        {
            SelectDropdown(value, dropdownName);
        }

        [When(@"User selects '(.*)' in the '(.*)' dropdown with wait")]
        public void WhenUserSelectsInTheDropdownWithWait(string value, string dropdownName)
        {
            SelectDropdown(value, dropdownName);
            //Used for Projects Scope to wait for changes to be applied
            Thread.Sleep(3000);
        }

        private void SelectDropdown(string value, string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdownByName(dropdownName).Click();
            dropdown.GetDropdownValueByName(value).Click();
        }

        [Then(@"'(.*)' content is displayed in '(.*)' dropdown")]
        public void ThenContentIsDisplayedInDropdown(string text, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var dropdownContent = page.GetDropdownByName(dropdown).Text;
            Verify.AreEqual(dropdownContent, text, $"Text in '{dropdown}' drop-down is different");
        }

        [Then(@"'(.*)' value is displayed in the '(.*)' dropdown")]
        public void ThenValueIsDisplayedInTheDropdown(string value, string dropdownName)
        {
            //TODO why Capacity SlotsPage used and BaseGrid
            var page = _driver.NowAt<Capacity_SlotsPage>();
            var dropdown = _driver.NowAt<BaseGridPage>();
            if (page.ExpandItemsButton.Displayed())
            {
                page.ExpandItemsButton.Click();
                Verify.IsTrue(dropdown.GetDropdownByValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
            }
            else
                Verify.IsTrue(dropdown.GetDropdownByValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
        }

        [Then(@"'(.*)' dropdown is displayed")]
        public void ThenDropdownIsDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(dropdown.GetDropdownByName(dropdownName).Displayed(), $"{dropdownName} is not displayed");
        }

        //Exact much
        [Then(@"following Values are displayed in the '(.*)' dropdown:")]
        public void ThenFollowingValuesAreDisplayedInTheDropdown(string dropDownName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdownByName(dropDownName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetDropdownValues();
            page.BodyContainer.Click();
            Verify.AreEqual(expectedList, actualList, $"Value for {dropDownName} are different");
        }

        //Contains
        [Then(@"User sees that '(.*)' dropdown contains following options:")]
        public void ThenUserSeesThatDropdownContainsFollowingOptions(string dropDownName,
            Table options)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdownByName(dropDownName).Click();
            List<string> actualOptions = page.GetDropdownValues();
            page.BodyContainer.Click();
            Utils.Verify.That(actualOptions,
                Is.SupersetOf(options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault())),
                "Some options are missing!");
        }

        #endregion

        #region Datepicker textbox

        [When(@"User clicks datepicker icon")]
        public void WhenUserClicksDatepickerIcon()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.DatePickerIcon.Click();
        }

        [When(@"User enters '(.*)' text to '(.*)' datepicker")]
        public void WhenUserEntersTextToDatepicker(string text, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var datepicker = page.GetNamedTextbox(placeholder);
            //Just clear is not working for some reason
            datepicker.Click();
            datepicker.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            datepicker.SendKeys(OpenQA.Selenium.Keys.Delete);
            datepicker.SendKeys(text);

            page.BodyContainer.Click();
        }

        #endregion

        #region Datepicker

        [Then(@"All '(.*)' days are green in the Datepicker")]
        public void ThenAllDaysAreGreenInTheDatepicker(string dayOfWeek)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            var allDaysForSpecifiedDayOfWeek = action.GetDaysForWeekDay(dayOfWeek);
            Verify.IsTrue(allDaysForSpecifiedDayOfWeek.All(x => x.GetCssValue("background-color").
                    Equals("rgba(126, 189, 56, 1)")),
                "Some days are not green");
        }

        [When(@"User selects '(.*)' day in the Datepicker")]
        public void WhenUserSelectsDayInTheDatepicker(int day)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.DayInDatePicker(day));
            action.DayInDatePicker(day).Click();
        }

        [Then(@"'(.*)' day is displayed green in the Datepicker")]
        public void ThenDayIsDisplayedGreenInTheDatepicker(int dayNumber)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.DayInDatePicker(dayNumber));
            Assert.That(action.DayInDatePicker(dayNumber).GetCssValue("background-color"),
                Is.EqualTo("rgba(126, 189, 56, 1)"),
                "Day color is wrong");
        }

        [Then(@"Datepicker has tooltip with '(.*)' rows for '(.*)' day")]
        public void ThenDatepickerHasTooltipWithRowsForDay(int rowNumber, int dayNumber)
        {
            _driver.WaitForDataLoading();
            Verify.IsTrue(_driver.GetDatepickerTooltipElements(dayNumber).Count().Equals(Convert.ToInt32(rowNumber)),
                "Wrong number of tooltip lines");
        }

        #endregion

        #region Expandable multiselect

        [When(@"User expands multiselect to add objects")]
        public void WhenUserExpandsMultiselectToAddObjects()
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            basePage.ExpandCollapseMultiselectButton("").Click();
        }

        [When(@"User selects following Objects from the expandable multiselect")]
        public void WhenUserSelectsFollowingObjectsFromTheExpandableMultiselect(Table table)
        {
            var itemsToAdd = table.Rows.Select(x => x["Objects"]).ToList();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            basePage.AddItemsToMultiSelect(itemsToAdd);
        }

        [When(@"User expands multiselect and selects following Objects")]
        public void WhenUserExpandsMultiselectAndSelectsFollowingObjects(Table table)
        {
            var itemsToAdd = table.Rows.Select(x => x["Objects"]).ToList();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            if (basePage.ExpandMultiselectButton("") != null && basePage.ExpandMultiselectButton("").Displayed())
            {
                basePage.ExpandCollapseMultiselectButton("").Click();
            }
            basePage.AddItemsToMultiSelect(itemsToAdd);
        }

        [When(@"User expands '(.*)' multiselect and selects following Objects")]
        public void WhenUserExpandsMultiselectAndSelectsFollowingObjects(string multiselectTitle, Table table)
        {
            var itemsToAdd = table.Rows.Select(x => x["Objects"]).ToList();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            basePage.ExpandCollapseMultiselectButton(multiselectTitle).Click();
            basePage.AddItemsToMultiSelect(itemsToAdd);
        }

        #endregion

        #region Checkbox

        [Then(@"'(.*)' checkbox is checked")]
        public void ThenCheckboxIsChecked(string checkbox)
        {
            var dialogContainer = _driver.NowAt<BasePage>();
            Verify.IsTrue(dialogContainer.GetCheckboxStateByName(checkbox).Selected, $"'{checkbox}' checkbox is not checked");
        }

        [Then(@"User selects state '(.*)' for '(.*)' checkbox")]
        public void ThenUserSelectsStateForCheckbox(bool checkboxState, string checkboxName)
        {
            var dialogContainer = _driver.NowAt<BasePage>();
            dialogContainer.GetCheckboxByName(checkboxName).SetCheckboxState(checkboxState);
            Logger.Write("Checkbox successfully pressed");
        }

        #endregion

        #region Button

        [When(@"User clicks '(.*)' button")]
        public void WhenUserClicksButton(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ClickButtonByName(buttonName);
        }

        [When(@"User double clicks '(.*)' button")]
        public void WhenUserDoubleClicksButton(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.DoubleClick(action.GetButtonByName(buttonName));
        }

        #endregion
    }
}