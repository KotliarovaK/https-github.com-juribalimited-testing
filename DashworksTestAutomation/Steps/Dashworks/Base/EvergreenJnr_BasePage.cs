using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Buckets;
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
using OpenQA.Selenium;
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
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly Teams _teams;
        private readonly Buckets _buckets;

        public EvergreenJnr_BasePage(RemoteWebDriver driver, AutomationActions automationActions,
            Automations automations, Slots slots, Rings rings, CapacityUnits capacityUnits, DTO.RuntimeVariables.Projects projects,
            Teams teams, Buckets buckets)
        {
            _driver = driver;
            _automationActions = automationActions;
            _automations = automations;
            _slots = slots;
            _rings = rings;
            _capacityUnits = capacityUnits;
            _projects = projects;
            _teams = teams;
            _buckets = buckets;
        }

        #region Page Header/SubHeader

        [Then(@"'(.*)' page subheader is displayed to user")]
        public void ThenPageSubheaderIsDisplayedToUser(string subheader)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.SubHeader);
            Verify.AreEqual(subheader, page.SubHeader.Text, "Incorrect page subheader");
        }

        [Then(@"Page with '(.*)' subheader is displayed to user")]
        public void ThenPageWithSubheaderIsDisplayedToUser(string subHeader)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(_driver.IsElementDisplayed(page.SubHeader, WebDriverExtensions.WaitTime.Short), $"Page with '{subHeader}' is not displayed");
            Verify.AreEqual(subHeader, page.SubHeader.Text, "Incorrect page header");
        }

        #endregion

        #region Autocomplete

        [When(@"User expands '(.*)' autocomplete")]
        public void WhenUserExpandsAutocomplete(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetTextbox(placeholder).Click();
        }

        [When(@"User selects '(.*)' option from '(.*)' autocomplete")]
        public void WhenUserSelectsOptionFromAutocomplete(string option, string placeholder)
        {
            UserSelectsOptionFromAutocomplete(option, placeholder, true);
        }

        [When(@"User selects '(.*)' option from '(.*)' autocomplete without search")]
        public void WhenUserSelectsOptionFromAutocompleteWithoutSearch(string option, string placeholder)
        {
            UserSelectsOptionFromAutocomplete(option, placeholder, false);
        }

        [When(@"User enters '(.*)' in the '(.*)' autocomplete field and selects '(.*)' value")]
        public void WhenUserEntersInTheAutocompleteFieldAndSelectsValue(string text, string placeholder, string value)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateTextbox(placeholder, text);
            page.AutocompleteSelect(placeholder, text, true, true, new[] { value });
        }

        [When(@"User selects '(.*)' option after search from '(.*)' autocomplete")]
        public void WhenUserSelectsOptionAfterSearchFromAutocomplete(string option, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.AutocompleteSelect(placeholder, option, true);
        }

        [When(@"User clears '(.*)' autocomplete")]
        public void WhenUserClearsAutocomplete(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClearTextbox(placeholder);
        }

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
                page.GetTextbox(field).Click();
                var listWithoutUnassigned = page.GetAllAutocompleteOptions(field).Where(x => !x.Contains("Unassigned")).ToList();
                Verify.AreEqual(listWithoutUnassigned.OrderBy(s => s), listWithoutUnassigned,
                    $"Options in the '{field}' autocomplete are not in alphabetical order");
            }
            else
            {
                page.GetTextbox(field).Click();
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

            Verify.AreEqual(expectedOptions, actualOptions, $"Value for '{placeholder}' are different");
        }

        [Then(@"'(.*)' autocomplete contains following options:")]
        public void ThenAutocompleteContainsFollowingOptions(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var actualOptions = page.GetAllAutocompleteOptions(placeholder);

            Verify.That(actualOptions,
                Is.SupersetOf(table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault())),
                "Some options are missing!");
        }

        [Then(@"'(.*)' content is displayed in '(.*)' autocomplete")]
        public void ThenContentIsDisplayedInAutocomplete(string expectedText, string placeholder)
        {
            CheckAutocompletAndTextboxText(placeholder, expectedText, true);
        }

        //TODO this step verify just that some results were found. Rework to verify found results
        [Then(@"'(.*)' content is not displayed in '(.*)' autocomplete after search")]
        public void ThenContentIsNotDisplayedInAutocompleteAfterSearch(string content, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateTextbox(placeholder, content);
            Verify.IsFalse(page.AutocompleteDropdown.Displayed(), $"{content} text is displayed in the {placeholder} autocomplete");
        }

        [Then(@"only below options are displayed in '(.*)' autocomplete after search by '(.*)' text")]
        public void ThenOnlyBelowOptionsAreDisplayedInAutocompleteAfterSearchByText(string placeholder, string searchText, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateTextbox(placeholder, searchText);

            var actualOptions = page.GetAllOptionsFromOpenedAutocomplete();

            Verify.AreEqual(table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()),
                actualOptions,
                $"Incorrect values are present in the '{placeholder}' autocomplete after search by '{searchText}' text");

            page.BodyContainer.Click();
        }

        [Then(@"only options having search term '(.*)' are displayed in '(.*)' autocomplete")]
        public void ThenOnlyOptionsHavingSearchTermAreDisplayedInAutocompleteAfterSearchByText(string searchText, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateTextbox(placeholder, searchText);

            var actualOptions = page.GetAllOptionsFromOpenedAutocomplete();

            Verify.That(actualOptions.All(x => x.Contains(searchText)), Is.True,
                $"Incorrect values are present in the '{placeholder}' autocomplete after search by '{searchText}' text");

            page.BodyContainer.Click();
        }

        [Then(@"only below options are selected in the '(.*)' autocomplete")]
        public void ThenOnlyBelowOptionsAreSelectedInTheAutocomplete(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var textbox = page.GetTextbox(placeholder);
            //Expand if more than 3 items are selected
            if (_driver.IsElementInElementDisplayed(textbox, By.XPath(page.ExpandNamedTextboxSelector),
                WebDriverExtensions.WaitTime.Short))
            {
                textbox.FindElement(By.XPath(page.ExpandNamedTextboxSelector)).Click();
            }

            var selectedOptions = textbox.FindElements(By.XPath(page.SelectedValuesForNamedTextboxSelector));

            Verify.AreEqual(table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()),
                selectedOptions.Select(x => x.Text),
                $"Incorrect values are selected in the '{placeholder}' autocomplete");
        }

        private void UserSelectsOptionFromAutocomplete(string option, string placeholder, bool withSearch)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.AutocompleteSelect(placeholder, option, withSearch);
            _driver.WaitForDataLoadingInActionsPanel();
        }

        private void CheckAutocompletAndTextboxText(string placeholder, string expectedText, bool expectedCondition)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var text = page.GetTextbox(placeholder).GetAttribute("value");
            Verify.That(expectedText.Equals(text), Is.EqualTo(expectedCondition),
                $"Incorrect text in the '{placeholder}' autocomplete/textbox");
        }

        [Then(@"All items in the '(.*)' autocomplete have icons")]
        public void AllItemsInTheAutocompleteHaveIcons(string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetTextbox(dropdown).Click();

            Verify.That(page.GetIconsOfDropdownOptions().Count, Is.EqualTo(page.GetDropdownValues().Count), "Incorrect options in lists dropdown");
            page.BodyContainer.Click();
        }

        [Then(@"All icon items in the '(.*)' autocomplete have any of tooltip")]
        public void ThenUserSeesAllListsIconDisplayedWithTooltipInTextBox(string dropdown, Table table)
        {
            var expectedTooltips = table.Rows.SelectMany(row => row.Values).ToList();
            var page = _driver.NowAt<BaseDashboardPage>();

            page.GetTextbox(dropdown).Click();
            VerifyTooltipOfDropdownIcons(page, expectedTooltips);
            page.BodyContainer.Click();
        }


        #endregion

        #region Textbox

        [When(@"User enters '(.*)' text to '(.*)' textbox")]
        public void WhenUserEntersTextToTextbox(string text, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetTextbox(placeholder).ClearWithBackspaces();
            page.GetTextbox(placeholder).SendKeys(text);
            page.BodyContainer.Click();

            //TODO rework to use switch
            if (placeholder.Equals("Action Name"))
                _automationActions.Value.Add(text);

            if (placeholder.Equals("Project Name"))
                _projects.Value.Add(text);

            if (placeholder.Equals("Team Name"))
            {
                TeamDto teamDto = new TeamDto();
                teamDto.TeamName = text;
                _teams.Value.Add(teamDto);
            }

            if (placeholder.Equals("Bucket Name"))
                _buckets.Value.Add(new BucketDto() { Name = text });

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

        [When(@"User enters next '(.*)' day to '(.*)' textbox")]
        public void WhenUserEntersNextDayToTextbox(string dayOfWeek, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetTextbox(placeholder).Clear();
            page.GetTextbox(placeholder).
                SendKeys(dayOfWeek.GetNextWeekday().ToString("dd MMM yyyy"));
            page.BodyContainer.Click();
        }

        [When(@"User adds '(.*)' value from '(.*)' textbox")]
        public void WhenUserAddsValueFromTextbox(string option, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateTextboxWithAddButton(fieldName, option);
        }

        [When(@"User clears '(.*)' textbox")]
        public void WhenUserClearsTextbox(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClearTextbox(placeholder);
        }

        [Then(@"'(.*)' content is displayed in '(.*)' textbox")]
        public void ThenContentIsDisplayedInTextbox(string expectedText, string placeholder)
        {
            CheckAutocompletAndTextboxText(placeholder, expectedText, true);
        }

        [Then(@"'(.*)' textbox content is not equal to '(.*)' text")]
        public void ThenTextboxContentIsNotEqualToText(string placeholder, string expectedText)
        {
            CheckAutocompletAndTextboxText(placeholder, expectedText, false);
        }

        [Then(@"'(.*)' error message is displayed for '(.*)' field")]
        public void ThenErrorMessageIsDisplayedForField(string errorMessage, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.BodyContainer.Click();

            Verify.AreEqual(errorMessage, page.GetTextboxErrorMessage(placeholder),
                $"Incorrect error message is displayed in the '{placeholder}' field");

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxErrorMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxErrorMessageExclamationIcon(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field exclamation icon");
        }

        [Then(@"'(.*)' add button tooltip is displayed for '(.*)' textbox")]
        public void ThenAddButtonTooltipIsDisplayedForTextbox(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetTextboxAddButton(fieldName);
            page.BodyContainer.Click();
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, $"Incorrect tooltip for Add button in the {fieldName} textbox");
        }

        [Then(@"Add button for '(.*)' textbox is disabled")]
        public void ThenAddButtonForTextboxIsDisabled(string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(Convert.ToBoolean(page.GetTextboxAddButton(fieldName).Disabled()), $"Add button for {fieldName} textbox is active");
        }

        [Then(@"Add button for '(.*)' textbox is not disabled")]
        public void ThenAddButtonForTextboxIsNotDisabled(string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(Convert.ToBoolean(page.GetTextboxAddButton(fieldName).Disabled()), $"Add button for {fieldName} textbox is active");
        }

        [Then(@"'(.*)' textbox is displayed")]
        public void ThenTextboxIsDisplayed(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsTextboxDisplayed(placeholder),
                $"'{placeholder}' textbox is not displayed");
        }

        [Then(@"'(.*)' textbox is not displayed")]
        public void ThenTextboxIsNotDisplayed(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsTextboxDisplayed(placeholder),
                $"'{placeholder}' textbox is displayed");
        }

        [Then(@"'(.*)' textbox is disabled")]
        public void ThenTextboxIsDisabled(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsTextboxDisabled(placeholder),
                $"'{placeholder}' textbox is not disabled");
        }

        [Then(@"'(.*)' textbox is not disabled")]
        public void ThenTextboxIsNotDisabled(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsTextboxDisabled(placeholder),
                $"'{placeholder}' textbox is disabled");
        }
        #endregion

        #region Dropdown

        [When(@"User clicks '(.*)' dropdown")]
        public void WhenUserClicksDropdown(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdown(dropdownName).Click();
        }

        [When(@"User selects '(.*)' in the '(.*)' dropdown")]
        public void WhenUserSelectsInTheDropdown(string value, string dropdownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SelectDropdown(value, dropdownName);
        }

        [When(@"User selects '(.*)' in the '(.*)' dropdown with wait")]
        public void WhenUserSelectsInTheDropdownWithWait(string value, string dropdownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SelectDropdown(value, dropdownName);
            //Used for Projects Scope to wait for changes to be applied
            //TODO: 21.11.2019 Oleksandr - increased sleep from 3 to 7 seconds to make sure that change list operation is applied
            Thread.Sleep(7000);
        }

        [Then(@"'(.*)' content is displayed in '(.*)' dropdown")]
        public void ThenContentIsDisplayedInDropdown(string text, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var dropdownContent = page.GetDropdown(dropdown).Text;
            Verify.AreEqual(dropdownContent, text, $"Text in '{dropdown}' drop-down is different");
        }

        //TODO looks like the same as ThenContentIsDisplayedInDropdown
        [Then(@"'(.*)' value is displayed in the '(.*)' dropdown")]
        public void ThenValueIsDisplayedInTheDropdown(string value, string dropdownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(value, page.GetDropdown(dropdownName).Text,
                $"Incorrect value is displayed in the '{dropdownName}' dropdown");
        }

        [Then(@"'(.*)' dropdown is displayed")]
        public void ThenDropdownIsDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(dropdown.IsDropdownDisplayed(dropdownName),
                $"{dropdownName} dropdown is not displayed");
        }

        [Then(@"'(.*)' dropdown is not displayed")]
        public void ThenDropdownIsNotDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(dropdown.IsDropdownDisplayed(dropdownName),
                $"'{dropdownName}' dropdown' is not displayed");
        }

        [Then(@"'(.*)' dropdown is disabled")]
        public void ThenDropdownIsDisabled(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(dropdown.IsDropdownDisabled(dropdownName),
                $"{dropdownName} dropdown is not displayed");
        }

        [Then(@"'(.*)' dropdown is not disabled")]
        public void ThenDropdownIsNotDisabled(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(dropdown.IsDropdownDisabled(dropdownName),
                $"'{dropdownName}' dropdown' is not displayed");
        }

        //Exact match
        [Then(@"following Values are displayed in the '(.*)' dropdown:")]
        public void ThenFollowingValuesAreDisplayedInTheDropdown(string dropDownName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetDropdownValues();
            page.BodyContainer.Click();
            Verify.AreEqual(expectedList, actualList, $"Value for '{dropDownName}' are different");
        }

        //Contains
        [Then(@"User sees that '(.*)' dropdown contains following options:")]
        public void ThenUserSeesThatDropdownContainsFollowingOptions(string dropDownName, Table options)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            List<string> actualOptions = page.GetDropdownValues();
            page.BodyContainer.Click();
            Verify.That(actualOptions,
                Is.SupersetOf(options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault())),
                "Some options are missing!");
        }

        [Then(@"following Values are not displayed in the '(.*)' dropdown:")]
        public void ThenFollowingValuesAreNotDisplayedInTheDropdown(string dropDownName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetDropdownValues();

            foreach (var expectedIem in expectedList)
            {
                Assert.That(actualList, Does.Not.Contain(expectedIem), $"Values in {dropDownName} drop-down is displayed");
            }
        }

        [Then(@"All items in the '(.*)' dropdown have icons")]
        public void AllItemsInTheDropdownHaveIcons(string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropdown).Click();

            Verify.That(page.GetIconsOfDropdownOptions().Count, Is.EqualTo(page.GetDropdownValues().Count), "Incorrect options in lists dropdown");
            page.BodyContainer.Click();
        }

        [Then(@"All icon items in the '(.*)' dropdown have any of tooltip")]
        public void ThenUserSeesAllListsIconDisplayedWithTooltipInDropdown(string dropdown, Table table)
        {
            var expectedTooltips = table.Rows.SelectMany(row => row.Values).ToList();
            var page = _driver.NowAt<BaseDashboardPage>();

            page.GetDropdown(dropdown).Click();
            VerifyTooltipOfDropdownIcons(page, expectedTooltips);
            page.BodyContainer.Click();
        }

        [Then(@"'(.*)' error message is displayed for '(.*)' dropdown")]
        public void ThenErrorMessageIsDisplayedForDropdown(string errorMassage, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(errorMassage, page.GetDropdownErrorMessage(dropdown),
                $"Incorrect error message for '{dropdown}' dropdown is displayed");
        }

        private void VerifyTooltipOfDropdownIcons(BaseDashboardPage page, List<string> tooltips)
        {
            var icons = page.GetIconsOfDropdownOptions();
            int attempts = 0;

            foreach (var icon in icons)
            {
                //check for first three
                if (attempts == 5)
                    break;

                _driver.MouseHover(icon);
                var toolTipText = _driver.GetTooltipText();

                Utils.Verify.That(tooltips, Does.Contain(toolTipText), "Unexpected/missing tooltip");

                attempts++;
            }
        }

        #endregion

        #region Dropdown for field

        [When(@"User selects '(.*)' in the dropdown for the '(.*)' field")]
        public void WhenUserSelectsInTheDropdownForTheField(string value, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SelectDropdownForField(value, fieldName);
        }

        [Then(@"following Values are displayed in the dropdown for the '(.*)' field:")]
        public void ThenFollowingValuesAreDisplayedInTheDropdownForTheField(string fieldName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdownForField(fieldName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetDropdownValues();
            page.BodyContainer.Click();
            Verify.AreEqual(expectedList, actualList, $"Value in the dropdown for the '{fieldName}' field are different");
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
            var datepicker = page.GetTextbox(placeholder);
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

        [Then(@"multiselect is not disabled")]
        public void ThenMultiselectIsNotDisabled()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(component.GetExpandableMultiselectElement("").Disabled(),
                "First multiselect on page is disabled");
        }

        [Then(@"'(.*)' multiselect is not disabled")]
        public void ThenMultiselectIsNotDisabled(string multiselectTitle)
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(component.GetExpandableMultiselectElement(multiselectTitle).Disabled(),
                $"''{multiselectTitle}'' multiselect on page is disabled");
        }

        [Then(@"multiselect is disabled")]
        public void ThenMultiselectIsDisabled()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(component.GetExpandableMultiselectElement("").Displayed(),
                "First multiselect on page is not disabled");
        }

        [Then(@"'(.*)' multiselect is disabled")]
        public void ThenMultiselectIsDisabled(string multiselectTitle)
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(component.GetExpandableMultiselectElement(multiselectTitle).Displayed(),
                $"''{multiselectTitle}'' multiselect on page is not disabled");
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

        [Then(@"'(.*)' button is displayed")]
        public void ThenButtonIsDisplayed(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsButtonDisplayed(buttonName),
                $"'{buttonName}' button is displayed");
        }

        [Then(@"'(.*)' button is not displayed")]
        public void ThenButtonIsNotDisplayed(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsButtonDisplayed(buttonName),
                $"'{buttonName}' button is displayed");
        }

        [Then(@"'(.*)' button is disabled")]
        public void ThenButtonIsDisabled(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.GetButtonByName(buttonName, "", WebDriverExtensions.WaitTime.Medium).Disabled(),
                $"'{buttonName}' button is displayed");
        }

        [Then(@"'(.*)' button is not disabled")]
        public void ThenButtonIsNotDisabled(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButtonByName(buttonName, "", WebDriverExtensions.WaitTime.Short);
            Verify.IsTrue(button.Displayed(),
                $"'{buttonName}' button is not displayed");
            Verify.IsFalse(button.Disabled(),
                $"'{buttonName}' button is displayed");
        }

        [Then(@"tooltip is not displayed for '(.*)' button")]
        public void ThenTooltipIsNotDisplayedForButton(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButtonByName(buttonName);

            _driver.MouseHover(button);
            //For tooltip display
            Thread.Sleep(300);
            Verify.IsFalse(_driver.IsTooltipDisplayed(),
                $"Tooltip for '{buttonName}' button is displayed");
        }

        [Then(@"'(.*)' button has tooltip with '(.*)' text")]
        public void ThenButtonHasTooltipWithText(string buttonName, string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButtonByName(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText,
                $"'{buttonName}' button tooltip is incorrect");
        }

        #endregion

        #region Menu button

        [When(@"User clicks '(.*)' button and select '(.*)' menu button")]
        public void WhenUserClicksButtonAndSelectMenuButton(string buttonName, string menuButtonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClickButtonByName(buttonName);

            page.GetMenuButtonByName(menuButtonName).Click();
        }

        #endregion

        #region Checkbox on Grid - TBR

        //TODO This is for BaseGrid but method can be changed to generic
        [Then(@"Select All checkbox have full checked state")]
        public void ThenSelectAllCheckboxHaveFullCheckedState()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.AreEqual(2, _driver.GetEvergreenCheckboxTripleState(page.SelectAllCheckbox),
                "'Select all' checkbox is not fully selected");
        }

        //TODO This is for BaseGrid but method can be changed to generic
        [Then(@"Select All checkbox have indeterminate checked state")]
        public void ThenSelectAllCheckboxHaveIndeterminateCheckedState()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.AreEqual(1, _driver.GetEvergreenCheckboxTripleState(page.SelectAllCheckbox),
                "'Select all' checkbox is not in the indeterminate state");
        }

        //TODO This is for BaseGrid but method can be changed to generic
        [Then(@"Select All checkbox have unchecked state")]
        public void ThenSelectAllCheckboxHaveUncheckedState()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.AreEqual(0, _driver.GetEvergreenCheckboxTripleState(page.SelectAllCheckbox),
                "'Select all' checkbox is not unchecked");
        }

        #endregion

        #region Checkbox

        [When(@"User checks '(.*)' checkbox")]
        public void WhenUserChecksCheckbox(string checkboxName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            //page.GetCheckbox(checkboxName).SetCheckboxState(true);
            if (!page.GetCheckbox(checkboxName).Selected)
            {
                //We must click by text to check or uncheck element
                _driver.ClickElementLeftCenter(page.GetCheckbox(checkboxName));
            }
        }

        [When(@"User unchecks '(.*)' checkbox")]
        public void WhenUserUnchecksCheckbox(string checkboxName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            //page.GetCheckbox(checkboxName).SetCheckboxState(false);
            if (page.GetCheckbox(checkboxName).Selected)
            {
                //We must click by text to check or uncheck element
                _driver.ClickElementLeftCenter(page.GetCheckbox(checkboxName));
            }
        }

        [When(@"User selects state '(.*)' for '(.*)' checkbox")]
        public void ThenUserSelectsStateForCheckbox(bool checkboxState, string checkboxName)
        {
            var dialogContainer = _driver.NowAt<BaseDashboardPage>();
            dialogContainer.GetCheckbox(checkboxName).SetCheckboxState(checkboxState);
        }

        [Then(@"'(.*)' checkbox is checked")]
        public void ThenCheckboxIsChecked(string checkbox)
        {
            var dialogContainer = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(dialogContainer.GetCheckbox(checkbox).Selected(),
                $"'{checkbox}' checkbox is not checked");
        }

        [Then(@"'(.*)' checkbox is unchecked")]
        public void ThenCheckboxIsUnChecked(string checkbox)
        {
            var dialogContainer = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(dialogContainer.GetCheckbox(checkbox).Selected(),
                $"'{checkbox}' checkbox is checked");
        }

        [Then(@"'(.*)' checkbox is disabled")]
        public void ThenCheckboxIsDisabled(string checkbox)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsCheckboxEnabled(checkbox),
                $"'{checkbox}' checkbox is not disabled");
        }

        [Then(@"'(.*)' checkbox is not disabled")]
        public void ThenCheckboxIsNotDisabled(string checkbox)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsCheckboxEnabled(checkbox),
                $"'{checkbox}' checkbox is disabled");
        }

        #endregion

        #region Chips

        [Then(@"Chips for '(.*)' field are not displayed")]
        public void ThenChipBoxIsNotDisplayedOnThePage(string field)
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(baseActionItem.GetChipsOfTextbox(field).Count == 0, "Chip box is displayed on the page");
        }

        [Then(@"following chips value displayed for '(.*)' textbox")]
        public void ThenFollowingChipsValueDisplayedForTextbox(string field, Table table)
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();
            var expectedChipList = table.Rows.SelectMany(row => row.Values).ToList();
            var chipsValueList = baseActionItem.GetChipsOfTextbox(field).Select(value => value.Text);
            Utils.Verify.AreEqual(expectedChipList, chipsValueList, "Chips value are different");
        }

        [Then(@"tooltip is not displayed for '(.*)' chip of '(.*)' textbox")]
        public void ThenTooltipIsNotDisplayedForChip(string chipName, string textbox)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var chip = page.GetChipsOfTextbox(textbox).First(value => value.Text.Equals(chipName));

            _driver.MouseHover(chip);
            //For tooltip display
            Thread.Sleep(300);
            Verify.IsFalse(_driver.IsTooltipDisplayed(),
                $"Tooltip for '{chipName}' chip is displayed");
        }

        #endregion

        #region Links

        [Then(@"'(.*)' link is displayed")]
        public void ThenLinkIsDisplayed(string text)
        {
            var projectElement = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(projectElement.IsLinkDisplayed(text),
                $"Link with '{text}' text was not displayed");
        }

        #endregion

        #region Collapse/Expand Category

        [When(@"User collapses '(.*)' category")]
        public void WhenUserCollapsesCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<BaseDashboardPage>();
            columnElement.CollapseExpandCategory(categoryName, false);
        }

        [When(@"User expands '(.*)' category")]
        public void WhenUserExpandsCategory(string categoryName)
        {
            var columnElement = _driver.NowAt<BaseDashboardPage>();
            columnElement.CollapseExpandCategory(categoryName, true);
        }

        #endregion
    }
}