using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using DashworksTestAutomation.Utils;
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
        private readonly Automations _automations;

        public EvergreenJnr_BasePage(RemoteWebDriver driver, AutomationActions automationActions, Automations automations)
        {
            _driver = driver;
            _automationActions = automationActions;
            _automations = automations;
        }

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

        [Then(@"only below options are displayed in the '(.*)' autocomplete")]
        public void ThenOnlyBelowOptionsAreDisplayedInTheAutocomplete(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var options = page.GetAllAutocompleteOptions(placeholder);

            Verify.AreEqual(options.Count, table.Rows.Count, "Incorrect options count in the autocomplete");

            foreach (TableRow tableRow in table.Rows)
            {
                Verify.IsTrue(options.Contains(tableRow["Options"]), $"Autocomplete doesn't have '{tableRow["Options"]}' option");
            }
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

            if (placeholder.Equals("Automation Name"))
                _automations.Value.Add(new AutomationsDto() { automationName = text });

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
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdownByName(dropdownName).Click();
            dropdown.GetDropdownValueByName(value).Click();
        }

        [Then(@"""(.*)"" text is displayed in ""(.*)"" field")]
        public void ThenTextIsDisplayedInField(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(page.GetFieldByFieldName(fieldName).GetAttribute("value").Contains(text),
                $"Text in {fieldName} field is different");
        }

        [Then(@"'(.*)' content is displayed in '(.*)' dropdown")]
        public void ThenContentIsDisplayedInDropdown(string text, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var dropdownContent = page.GetDropdownByName(dropdown).Text;
            Verify.AreEqual(dropdownContent, text, $"Text in '{dropdown}' drop-down is different");
        }

        [Then(@"'(.*)' text value is displayed in the '(.*)' dropdown")]
        public void ThenTextValueIsDisplayedInTheDropdown(string value, string dropdownName)
        {
            //TODO why grid page is used
            var dropdown = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(dropdown.GetDropdownByTextValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
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

        [Then(@"only following items are displayed in the dropdown:")]
        public void ThenOnlyFollowingItemsAreDisplayedInTheDropdown(Table table)
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = basePage.GetDropdownValues();
            Verify.AreEqual(expectedList, actualList, "Dropdown values are different");
            basePage.BodyContainer.Click();
        }

        #endregion

        #region Datepicker

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
    }
}
