using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public EvergreenJnr_BasePage(RemoteWebDriver driver, AutomationActions automationActions)
        {
            _driver = driver;
            _automationActions = automationActions;
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

        [Then(@"'(.*)' autocomplete does NOT have option")]
        public void ThenAutocompleteDoesNotHaveOption(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var options = page.GetAllAutocompleteOptions(placeholder);

            foreach (TableRow tableRow in table.Rows)
            {
                Verify.IsFalse(options.Contains(tableRow["Option"]), $"'{placeholder}' autocomplete have '{tableRow["Option"]}' option");
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

        #endregion

        #region Named Textbox

        [When(@"User enters '(.*)' text to '(.*)' textbox")]
        public void WhenUserEntersTextToTextbox(string text, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetNamedTextbox(placeholder).Clear();
            page.GetNamedTextbox(placeholder).SendKeys(text);

            if (placeholder.Equals("Action Name"))
                _automationActions.Value.Add(text);
        }

        #endregion

        #region Dropdown

        [Then(@"""(.*)"" content is displayed in ""(.*)"" dropdown")]
        public void ThenContentIsDisplayedInDropdown(string text, string dropdown)
        {
            //TODO why grid page is used
            var page = _driver.NowAt<BaseGridPage>();
            var dropdownContent = page.GetDropdownByName(dropdown).Text;
            Verify.AreEqual(dropdownContent, text, $"Text in '{dropdown}' drop-down is different");
        }

        [Then(@"""(.*)"" text value is displayed in the ""(.*)"" dropdown")]
        public void ThenTextValueIsDisplayedInTheDropdown(string value, string dropdownName)
        {
            //TODO why grid page is used
            var dropdown = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(dropdown.GetDropdownByTextValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
        }

        [Then(@"""(.*)"" value is displayed in the ""(.*)"" dropdown")]
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

        #endregion
    }
}
