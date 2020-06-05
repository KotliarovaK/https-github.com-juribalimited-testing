using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
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
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomationCore.DTO.RuntimeVariables;
using DashworksTestAutomationCore.Steps.Dashworks.ActionsPanel.FavouriteBulkUpdate;

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
        private readonly SelfServices _selfServices;
        private readonly FavouriteBulkUpdateObjects _favouriteBulkUpdate;
        private readonly RestWebClient _client;

        public EvergreenJnr_BasePage(RemoteWebDriver driver, AutomationActions automationActions,
            Automations automations, Slots slots, Rings rings, CapacityUnits capacityUnits, DTO.RuntimeVariables.Projects projects,
            Teams teams, Buckets buckets, SelfServices selfServices, FavouriteBulkUpdateObjects favouriteBulkUpdate, RestWebClient client)
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
            _selfServices = selfServices;
            _favouriteBulkUpdate = favouriteBulkUpdate;
            _client = client;
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
            Verify.AreEqual(subHeader, page.SubHeader.Text, "Incorrect page subheader");
        }

        [Then(@"Page with '(.*)' second level subheader is displayed to user")]
        public void ThenPageWithSecondLevelSubheaderIsDisplayedToUser(string secondLevelSubHeader)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(_driver.IsElementDisplayed(page.SecondLevelSubHeader, WebDriverExtensions.WaitTime.Short), $"Page with '{secondLevelSubHeader}' is not displayed");
            Verify.AreEqual(secondLevelSubHeader, page.SecondLevelSubHeader.Text, "Incorrect page second level subheader");
        }

        #endregion

        #region Text Editor

        [When(@"User enters '(.*)' text to the text editor")]
        public void WhenUserEntersTextToTheTextEditor(string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.TextEditorInput.SendKeys(text);
        }

        [When(@"User clears text editor")]
        public void WhenUserClearsTextEditor()
        {
            try
            {
                var page = _driver.NowAt<BaseDashboardPage>();
                page.TextEditorInput.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [Then(@"text editor is displayed")]
        public void ThenTextEditorIsDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(_driver.IsElementExists(page.TextEditor), "Text editor is not displayed on page");
        }

        [Then(@"text editor contains text")]
        public void ThenTextEditorContainsText(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var textEditorContent = page.TextEditorInput.Text;
            foreach (TableRow row in table.Rows)
            {
                var expectedText = row.Values.First();
                Verify.IsTrue(textEditorContent.Contains(expectedText), $"Text editor doesn't contains '{expectedText}' text");
            }
        }

        [Then(@"text editor does not contains text")]
        public void ThenTextEditorDoesNotContainsText(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var textEditorContent = page.TextEditorInput.Text;
            foreach (TableRow row in table.Rows)
            {
                var expectedText = row.Values.First();
                Verify.IsFalse(textEditorContent.Contains(expectedText), $"Text editor contains '{expectedText}' text");
            }
        }

        [Then(@"formatting options are displayed on the text component")]
        public void ThenFormattingOptionsAreDisplayedOnTheTextComponentPage()
        {
            var page = _driver.NowAt<TextComponentElements>();

            Verify.That(page.BoldStyleButton.Displayed(), "Bold style button is not displayed");
            Verify.That(page.ItalicStyleButton.Displayed(), "Italic style button is not displayed");
            Verify.That(page.UnderlineStyleButton.Displayed(), "Underline style button is not displayed");
            Verify.That(page.HeadersPickerButton.Displayed(), "Headers picker button is not displayed");
        }

        [Then(@"header format options are displayed on the text component")]
        public void ThenHeaderFormatOptionsAreDisplayedOnTheTextComponentPage(Table table)
        {
            var page = _driver.NowAt<TextComponentElements>();

            page.HeadersPickerButton.Click();
            _driver.WaitForElementsToBeDisplayed(page.HeaderOptions);

            List<string> expectedOptionNames = table.Rows.SelectMany(row => row.Values).ToList();
            List<string> actualheaderOptionNames = new List<string>();

            for (int i = 0; i < page.HeaderOptions.Count; i++)
            {
                string value = _driver.GetPseudoElementValue(page.HeaderOptions[i], ":before", "content");
                actualheaderOptionNames.Add(value);
            }

            Verify.AreEqual(expectedOptionNames, actualheaderOptionNames, "Header format options does not equals to expecting options");
        }

        #endregion

        #region Autocomplete

        //TODO it is better to no use it and delete at all
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

        [When(@"User checks '(.*)' option after search from '(.*)' autocomplete")]
        public void WhenUserChecksOptionAfterSearchFromAutocomplete(string checkbox, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.AutocompleteSelectCheckboxes(placeholder, checkbox, true, true);
            _driver.ClickByActions(page.BodyContainer);
        }

        [When(@"User unchecks '(.*)' option after search from '(.*)' autocomplete")]
        public void WhenUserUnchecksOptionAfterSearchFromAutocomplete(string checkbox, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.AutocompleteSelectCheckboxes(placeholder, checkbox, false, true);
            _driver.ClickByActions(page.BodyContainer);
        }

        [When(@"User clears '(.*)' autocomplete")]
        public void WhenUserClearsAutocomplete(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClearTextbox(placeholder);
        }

        [When(@"User clears '(.*)' autocomplete with backspaces")]
        public void WhenUserClearsAutocompleteWithBackspaces(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClearTextbox(placeholder, true);
        }

        [Then(@"'(.*)' autocomplete is displayed")]
        public void ThenAutocompleteIsDisplayed(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsTextboxDisplayed(placeholder),
                $"'{placeholder}' autocomplete is not displayed");
        }

        [Then(@"'(.*)' autocomplete is not displayed")]
        public void ThenAutocompleteIsNotDisplayed(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsTextboxDisplayed(placeholder),
                $"'{placeholder}' autocomplete is displayed");
        }

        [Then(@"'(.*)' autocomplete first option is '(.*)'")]
        public void ThenAutocompleteFirstOptionIs(string placeholder, string option)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var options = page.GetAllAutocompleteOptions(placeholder);
            Verify.AreEqual(option, options.First(),
                $"'{option}' option should be first in the '{placeholder}' autocomplete");
            _driver.ClickByActions(page.BodyContainer);
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

        [Then(@"'(.*)' autocomplete does not have following checkbox options")]
        public void ThenAutocompleteDoesNotHaveFollowingCheckboxOptions(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (string value in table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()))
            {
                var textbox = page.GetTextbox(placeholder);
                textbox.Clear();
                textbox.SendKeys(value);
                Verify.IsFalse(page.IsAutocompleteCheckboxDisplayed(value), $"'{value}' checkbox is displayed, but should not");
                _driver.ClickByActions(page.BodyContainer);
            }
        }

        [Then(@"'(.*)' autocomplete have following checkbox options")]
        public void ThenAutocompleteHaveFollowingCheckboxOptions(string placeholder, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (string value in table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()))
            {
                var textbox = page.GetTextbox(placeholder);
                textbox.Clear();
                textbox.SendKeys(value);
                Verify.IsTrue(page.IsAutocompleteCheckboxDisplayed(value), $"'{value}' checkbox is missed");
                _driver.ClickByActions(page.BodyContainer);
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

            _driver.ClickByActions(page.BodyContainer);
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
            _driver.ClickByActions(page.BodyContainer);
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

            _driver.ClickByActions(page.BodyContainer);
        }

        [Then(@"only options having search term '(.*)' are displayed in '(.*)' autocomplete")]
        public void ThenOnlyOptionsHavingSearchTermAreDisplayedInAutocompleteAfterSearchByText(string searchText, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.PopulateTextbox(placeholder, searchText);

            var actualOptions = page.GetAllOptionsFromOpenedAutocomplete();

            Verify.That(actualOptions.All(x => x.Contains(searchText)), Is.True,
                $"Incorrect values are present in the '{placeholder}' autocomplete after search by '{searchText}' text");

            _driver.ClickByActions(page.BodyContainer);
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
            Verify.AreEqual(expectedText, text, $"Incorrect text in the '{placeholder}' autocomplete/textbox");
        }

        [Then(@"All items in the '(.*)' autocomplete have icons")]
        public void AllItemsInTheAutocompleteHaveIcons(string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetTextbox(dropdown).Click();

            Verify.That(page.GetIconsOfDropdownOptions().Count, Is.EqualTo(page.GetDropdownValues().Count), "Incorrect options in lists dropdown");
            _driver.ClickByActions(page.BodyContainer);
        }

        [Then(@"All icon items in the '(.*)' autocomplete have any of tooltip")]
        public void ThenUserSeesAllListsIconDisplayedWithTooltipInTextBox(string dropdown, Table table)
        {
            var expectedTooltips = table.Rows.SelectMany(row => row.Values).ToList();
            var page = _driver.NowAt<BaseDashboardPage>();

            page.GetTextbox(dropdown).Click();
            VerifyTooltipOfDropdownIcons(page, expectedTooltips);
            _driver.ClickByActions(page.BodyContainer);
        }

        [Then(@"'(.*)' icon displayed for '(.*)' option from '(.*)' autocomplete")]
        public void ThenIconDisplayedForOptionFromAutocomplete(string icon, string optionName, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var textbox = page.GetTextbox(placeholder);
            textbox.Click();
            textbox.Clear();
            textbox.SendKeys(optionName);
            Verify.IsTrue(page.IsIconDisplayedFromDropdownOptions(icon), $"'{icon}' is not displayed for '{optionName}'");
        }

        [Then(@"'(.*)' of all shown label is displayed in expanded autocomplete")]
        public void ThenOfAllShownLabelDisplaysInTheFilterPanel(int showedResultsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.AutocompletePagination.Text, Does.Contain($"{showedResultsCount.ToString()} of "),
                $"Shown label doesn't contain {showedResultsCount} found rows");
        }

        [Then(@"shown items label is not displayed for '(.*)' autocomplete")]
        public void ThenShowItemsLabelIsNotShownForAutocomplete(string autocompelte)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            page.GetTextbox(autocompelte).Click();
            _driver.WaitForDataLoading();
            Verify.IsFalse(_driver.IsElementDisplayed(page.AutocompletePagination), $"X of Y items label is displayed for {autocompelte}");

            _driver.ClickByActions(page.BodyContainer);
        }

        #endregion

        #region Textbox

        [When(@"User enters '(.*)' text to '(.*)' textbox")]
        public void WhenUserEntersTextToTextbox(string text, string placeholder)
        {
            switch (placeholder)
            {
                case "Self Service Identifier":
                    _selfServices.Value.Add(new SelfServiceDto() { ServiceIdentifier = text });
                    break;
                case "Action Name":
                    _automationActions.Value.Add(text);
                    break;
                case "Project Name":
                    _projects.Value.Add(text);
                    break;
                case "Team Name":
                    _teams.Value.Add(new TeamDto() { TeamName = text });
                    break;
                case "Bucket Name":
                    _buckets.Value.Add(new BucketDto() { Name = text });
                    break;
                case "Slot Name":
                    _slots.Value.Add(new SlotDto() { SlotName = text });
                    break;
                case "Automation Name":
                    _automations.Value.Add(new AutomationsDto() { name = text });
                    break;
                case "Favourite Bulk Update Name":
                    _favouriteBulkUpdate.Value.Add(new RemoveFbuMethods.Favourit() { Name = text });
                    break;
                case "Ring name":
                    //Get project ID if Ring is inside project
                    if (_driver.Url.Contains("/project/"))
                    {
                        //TODO wrap this in separate method
                        Regex regex = new Regex(@"\/project\/(\d+)");
                        Match m = regex.Match(_driver.Url);
                        var projId = m.Groups[1].ToString();
                        _rings.Value.Add(new RingDto() { Name = text, Project = DatabaseHelper.GetProjectName(projId) });
                    }
                    else
                    {
                        _rings.Value.Add(new RingDto() { Name = text });
                    }
                    break;
                case "Capacity Unit Name":
                    //Get project ID if Capacity Unit is inside project
                    if (_driver.Url.Contains("/project/"))
                    {
                        //TODO wrap this in separate method
                        Regex regex = new Regex(@"\/project\/(\d+)");
                        Match m = regex.Match(_driver.Url);
                        var projId = m.Groups[1].ToString();
                        _capacityUnits.Value.Add(new CapacityUnitDto() { Name = text, Project = DatabaseHelper.GetProjectName(projId) });
                    }
                    else
                    {
                        _capacityUnits.Value.Add(new CapacityUnitDto() { Name = text });
                    }
                    break;
            }

            var page = _driver.NowAt<BaseDashboardPage>();
            var textbox = page.GetTextbox(placeholder);
            textbox.ClearWithBackspaces();
            textbox.SendKeys(text);
            _driver.ClickByActions(page.BodyContainer);
            _driver.WaitForDataLoading();
        }

        [When(@"User enters next '(.*)' day to '(.*)' textbox")]
        public void WhenUserEntersNextDayToTextbox(string dayOfWeek, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var textbox = page.GetTextbox(placeholder);
            textbox.Clear();
            textbox.SendKeys(dayOfWeek.GetNextWeekday().ToString("dd MMM yyyy"));
            _driver.ClickByActions(page.BodyContainer);
        }

        [When(@"User enters random number between '(.*)' and '(.*)' to '(.*)' textbox")]
        public void WhenUserEntersRandomNumberBetweenAndToTextbox(int fromNum, int toNumb, string placeholder)
        {
            var number = new Random().Next(fromNum, toNumb).ToString();
            var page = _driver.NowAt<BaseDashboardPage>();
            var textbox = page.GetTextbox(placeholder);
            _driver.ClearByJavascript(textbox);
            textbox.SendKeys(number);
            _driver.ClickByActions(page.BodyContainer);
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

        [When(@"User clears '(.*)' textbox with backspaces")]
        public void WhenUserClearsTextboxWithBackspaces(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClearTextbox(placeholder, true);
        }

        [When(@"User clicks on '(.*)' textbox")]
        public void WhenUserClicksOnTextbox(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetTextbox(placeholder).Click();
        }

        [When(@"User waits for info message disappears under '(.*)' field")]
        public void WhenUserWaitForInfoMessageDisappearsUnderField(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.WaitForTextboxInfoMessageDisappears(placeholder);
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

        [Then(@"No error message is displayed for '(.*)' field")]
        public void ThenNoErrorMessageIsDisplayedForField(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.ClickByActions(page.BodyContainer);

            Verify.That(page.IsTextboxDisplayedWithError(placeholder), Is.False, $"Error message was displayed for '{placeholder}' textbox");
        }

        [Then(@"'(.*)' message is displayed for '(.*)' field")]
        public void ThenMessageIsDisplayedForField(string message, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.ClickByActions(page.BodyContainer);

            Verify.AreEqual(message, page.GetTextboxErrorMessage(placeholder),
                $"Incorrect message is displayed in the '{placeholder}' field");
        }

        [Then(@"'(.*)' error message is displayed for '(.*)' field")]
        public void ThenErrorMessageIsDisplayedForField(string errorMessage, string placeholder)
        {
            ThenMessageIsDisplayedForField(errorMessage, placeholder);

            var page = _driver.NowAt<BaseDashboardPage>();

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxErrorMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");

            //Need to delete check for Exclamation Icon,  it has to be removed for all objects
            //Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxErrorMessageExclamationIcon(placeholder).GetCssValue("color"),
            //    $"Incorrect error message color for '{placeholder}' field exclamation icon");
        }

        [Then(@"'(.*)' information message is displayed for '(.*)' field")]
        public void ThenInformationMessageIsDisplayedForField(string errorMessage, string placeholder)
        {
            ThenMessageIsDisplayedForField(errorMessage, placeholder);

            var page = _driver.NowAt<BaseDashboardPage>();

            Verify.AreEqual("rgba(49, 122, 193, 1)", page.GetTextboxErrorMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");

            //Need to delete check for Exclamation Icon,  it has to be removed for all objects
            //Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxErrorMessageExclamationIcon(placeholder).GetCssValue("color"),
            //    $"Incorrect error message color for '{placeholder}' field exclamation icon");
        }

        [Then(@"'(.*)' success message for '(.*)' field")]
        public void ThenSuccessMessageForField(string successMessage, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            Verify.AreEqual(successMessage, page.GetTextboxSuccessMessageElement(placeholder).Text,
                $"Incorrect message is displayed in the '{placeholder}' field");
            Verify.AreEqual("rgba(126, 189, 56, 1)", page.GetTextboxSuccessMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect success message color for '{placeholder}' field");
        }

        [Then(@"User sees '(.*)' hint below '(.*)' field")]
        public void ThenUserSeesHintBelowField(string instruction, string fieldName)
        {
            var filterElement = _driver.NowAt<BaseDashboardPage>();
            Verify.That(filterElement.GetFieldHint(fieldName).Text, Is.EqualTo(instruction),
                $"{fieldName} has no or wrong instruction");
        }

        [Then(@"User sees '(.*)' red hint below '(.*)' field")]
        public void ThenUserSeesRedHintBelowField(string instruction, string fieldName)
        {
            var filterElement = _driver.NowAt<BaseDashboardPage>();
            Verify.That(filterElement.GetFieldHint(fieldName).GetCssValue("color"), Is.EqualTo("rgba(242, 88, 49, 1)"),
                $"{fieldName} has incorrect color for hint");
            Verify.That(filterElement.GetFieldHint(fieldName).Text, Is.EqualTo(instruction),
                $"{fieldName} has no or wrong instruction");
        }

        [Then(@"'(.*)' add button tooltip is displayed for '(.*)' textbox")]
        public void ThenAddButtonTooltipIsDisplayedForTextbox(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetTextboxAddButton(fieldName);
            _driver.ClickByActions(page.BodyContainer);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, $"Incorrect tooltip for Add button in the {fieldName} textbox");
        }

        [Then(@"validation message '(.*)' is displayed below '(.*)' field")]
        public void ThenValidationMessageIsDisplayedBelowFiled(string validationMessage, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedValidationMessage = page.GetAutocompleteValidationMessage(fieldName);
            Verify.AreEqual(validationMessage, expectedValidationMessage,
                $"Incorrect error message is displayed in the '{fieldName}' field");
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

        [Then(@"'(.*)' textbox is focused")]
        public void ThenTextboxIsFocused(string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsTextboxFocused(placeholder), $"'{placeholder}' is not focused");
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
            //Vitalii: decreased to 5 seconds. Contact me if you need to increase this number or tests start failing again
            Thread.Sleep(5000);
        }

        [When(@"User focus on '(.*)' dropdown")]
        public void WhenUserFocusOnDropdown(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdown(dropdownName, WebDriverExtensions.WaitTime.Long, true);
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

        [Then(@"dropdown is not opened")]
        public void ThenDropdownIsNotOpened()
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(dropdown.IsDropdownOpened(), "Dropdown is opened");
        }

        //Exact match
        [Then(@"following Values are displayed in the '(.*)' dropdown:")]
        public void ThenFollowingValuesAreDisplayedInTheDropdown(string dropDownName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetDropdownValues();
            _driver.ClickByActions(page.BodyContainer);
            Verify.AreEqual(expectedList, actualList, $"Value for '{dropDownName}' are different");
        }

        //Contains
        [Then(@"User sees that '(.*)' dropdown contains following options:")]
        public void ThenUserSeesThatDropdownContainsFollowingOptions(string dropDownName, Table options)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            List<string> actualOptions = page.GetDropdownValues();
            _driver.ClickByActions(page.BodyContainer);
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
            _driver.ClickByActions(page.BodyContainer);
        }

        [Then(@"following items have '(.*)' icon in the '(.*)' dropdown:")]
        public void ThenFollowingItemsHaveIconInTheDropdown(string dropdown, string iconName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropdown).Click();
            var expectedStarIconsValue = table.Rows.SelectMany(row => row.Values).ToList();

            foreach (var row in table.Rows)
            {
                page.GetMatIconsOfDropdownOptionsByName(row["Items"], iconName);
            }
            page.BodyContainer.Click();
        } 

        [Then(@"All icon items in the '(.*)' dropdown have any of tooltip")]
        public void ThenUserSeesAllListsIconDisplayedWithTooltipInDropdown(string dropdown, Table table)
        {
            var expectedTooltips = table.Rows.SelectMany(row => row.Values).ToList();
            var page = _driver.NowAt<BaseDashboardPage>();

            page.GetDropdown(dropdown).Click();
            VerifyTooltipOfDropdownIcons(page, expectedTooltips);
            _driver.ClickByActions(page.BodyContainer);
        }

        [Then(@"items with '(.*)' icon for '(.*)' dropdown are displayed in ascending order")]
        public void ThenItemsWithIconForDropdownAreDisplayedInAscendingOrder(string icon, string dropdownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropdownName).Click();
            var fbuList = page.GetItemsWithIconInDropdownOptions(icon).Select(x => x.Text).ToList();
            SortingHelper.IsListSorted(fbuList);
        }

        [Then(@"'(.*)' option is first in the '(.*)' dropdown")]
        public void ThenOptionIsFirstInTheDropdown(string option, string dropDownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            List<string> actualOptions = page.GetDropdownValues();
            _driver.ClickByActions(page.BodyContainer);
            Verify.AreEqual(option, actualOptions.First(),
                $"First option in the '{dropDownName}' dropdown should be '{option}'");
        }

        [Then(@"options are sorted in alphabetical order in the '(.*)' dropdown")]
        public void ThenOptionsAreSortedInAlphabeticalOrderInTheDropdown(string dropDownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            List<string> actualOptions = page.GetDropdownValues(true);
            _driver.ClickByActions(page.BodyContainer);

            if (!actualOptions.Any())
            {
                throw new Exception($"There are no options in the '{dropDownName}' dropdown");
            }

            Verify.AreEqual(actualOptions.Where(x => !string.IsNullOrEmpty(x)).OrderBy(s => s),
                actualOptions.Where(x => !string.IsNullOrEmpty(x)),
                $"Options are displayed in not in alphabetical order in the '{dropDownName}' dropdown");
        }

        //This is not dropdown but autocomplete
        [Then(@"'(.*)' error message is displayed for '(.*)' dropdown")]
        public void ThenErrorMessageIsDisplayedForDropdown(string errorMassage, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(errorMassage, page.GetDropdownErrorMessage(dropdown),
                $"Incorrect error message for '{dropdown}' dropdown is displayed");
        }

        [Then(@"'(.*)' success message for '(.*)' dropdown")]
        public void ThenSuccessMessageForDropdown(string successMessage, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            Verify.AreEqual(successMessage, page.GetDropdownSuccessMessage(dropdown),
                $"Incorrect succcess message for '{dropdown}' dropdown is displayed");
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

                Verify.That(tooltips, Does.Contain(toolTipText), "Unexpected/missing tooltip");

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

        //| Value |
        [Then(@"following Values are displayed in the dropdown for the '(.*)' field:")]
        public void ThenFollowingValuesAreDisplayedInTheDropdownForTheField(string fieldName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdownForField(fieldName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetDropdownValues();
            _driver.ClickByActions(page.BodyContainer);
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

            _driver.ClickByActions(page.BodyContainer);
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
            action.ClickButton(buttonName);
        }

        [When(@"User double clicks '(.*)' button")]
        public void WhenUserDoubleClicksButton(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.DoubleClick(action.GetButton(buttonName));
        }

        [Then(@"'(.*)' button is displayed")]
        public void ThenButtonIsDisplayed(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsButtonDisplayed(buttonName),
                $"'{buttonName}' button is not displayed");
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
            Verify.IsTrue(page.GetButton(buttonName, "", WebDriverExtensions.WaitTime.Medium).Disabled(),
                $"'{buttonName}' button is enabled");
        }

        [Then(@"'(.*)' button is not disabled")]
        public void ThenButtonIsNotDisabled(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButton(buttonName, "", WebDriverExtensions.WaitTime.Short);
            Verify.IsTrue(button.Displayed(),
                $"'{buttonName}' button is not displayed");
            Verify.IsFalse(button.Disabled(),
                $"'{buttonName}' button is displayed");
        }

        [Then(@"tooltip is not displayed for '(.*)' button")]
        public void ThenTooltipIsNotDisplayedForButton(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButton(buttonName);

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
            var button = page.GetButton(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText,
                $"'{buttonName}' button tooltip is incorrect");
        }

        [Then(@"'(.*)' button is displayed in high contrast")]
        public void ThenButtonIsDisplayedInHighContrast(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButton(buttonName);

            Verify.That(button.GetCssValue("background-color").Equals("rgba(21, 40, 69, 1)"), Is.True, "Button has wrong background");
            Verify.That(button.GetCssValue("color").Equals("rgba(255, 255, 255, 1)"), Is.True, "Button has wrong color");
        }

        #endregion

        #region Button with aria label

        [When(@"User clicks button with '(.*)' aria label")]
        public void WhenUserClicksButtonWithAriaLabel(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ClickButtonWithAriaLabel(buttonName);
        }

        [Then(@"'(.*)' button with aria label is displayed")]
        public void ThenButtonWithAriaLabelIsDisplayed(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsButtonDisplayedWithAriaLabel(buttonName),
                $"Button with '{buttonName}' aria label is not displayed");
        }

        [Then(@"'(.*)' button with aria label is disabled")]
        public void ThenButtonWithAriaLabelIsDisabled(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.GetButtonWithAriaLabel(buttonName).Disabled(),
                $"'{buttonName}' button is not disabled");
        }

        [Then(@"'(.*)' button with aria label is not disabled")]
        public void ThenButtonWithAriaLabelIsNotDisabled(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.GetButtonWithAriaLabel(buttonName).Disabled(),
                $"'{buttonName}' button is disabled");
        }

        #endregion

        #region Menu button

        [When(@"User clicks '(.*)' button and select '(.*)' menu button")]
        public void WhenUserClicksButtonAndSelectMenuButton(string buttonName, string menuButtonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClickButton(buttonName);

            page.GetMenuButtonByName(menuButtonName).Click();
        }

        [Then(@"'(.*)' menu button is displayed for '(.*)' button")]
        public void ThenMenuButtonIsDisplayedForButton(string menuButtonName, string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClickButton(buttonName);
            Verify.IsTrue(page.IsMenuButtonDisplayed(menuButtonName),
                $"'{menuButtonName}' menu button is not displayed for '{buttonName}' button");
            _driver.ClickByActions(page.BodyContainer);
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
            page.SetCheckboxState(checkboxName, true);
        }

        [When(@"User unchecks '(.*)' checkbox")]
        public void WhenUserUnchecksCheckbox(string checkboxName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SetCheckboxState(checkboxName, false);
        }

        [When(@"User checks following checkboxes:")]
        public void WhenUserChecksFollowingCheckboxes(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                page.SetCheckboxState(row.Values.FirstOrDefault(), true);
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

        [Then(@"'(.*)' checkbox is enabled")]
        public void ThenCheckboxIsEnabled(string checkbox)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsCheckboxEnabled(checkbox),
                $"'{checkbox}' checkbox is disabled");
        }

        [Then(@"'(.*)' checkbox is displayed")]
        public void ThenCheckboxIsDisplayed(string checkbox)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsCheckboxDisplayed(checkbox), $"'{checkbox}' checkbox is not displayed");
        }

        [Then(@"'(.*)' checkbox is not displayed")]
        public void ThenCheckboxIsNotDisplayed(string checkbox)
        {

            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsCheckboxDisplayed(checkbox), $"'{checkbox}' checkbox is displayed");
        }

        #endregion

        #region Radio button

        [When(@"User checks '(.*)' radio button")]
        public void WhenUserChecksRadiobutton(string radioButtonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SetRadioButtonState(radioButtonName, true);
        }

        [Then(@"'(.*)' radio button is disabled")]
        public void ThenRadioButtonIsDisabled(string radioButtonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.IsRadioButtonEnabled(radioButtonName), $"'{radioButtonName}' radio button is not disabled");
        }

        [Then(@"'(.*)' radio button is enabled")]
        public void ThenRadioButtonIsEnabled(string radioButtonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsRadioButtonEnabled(radioButtonName), $"'{radioButtonName}' radio button is not enabled");
        }

        [Then(@"'(.*)' radio button is checked")]
        public void ThenRadioButtonIsChecked(string radioButtonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.IsRadioButtonChecked(radioButtonName),
                $"'{radioButtonName}' radio button is not checked");
        }

        #endregion

        #region Chips

        [When(@"User removes following chips of '(.*)' button with '(.*)' index")]
        public void WhenUserRemovesFollowingChipsOfButtonWithIndex(string button, int index, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                page.GetChipsForButton(button, index).First(x => x.Text.Equals(row["Chips"])).FindElement(By.XPath(".//button")).Click();
            }
        }

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
            Verify.AreEqual(expectedChipList, chipsValueList, "Chips value are different");
        }

        [Then(@"following chips value displayed in the '(.*)' textbox")]
        public void ThenFollowingChipsValueDisplayedInTheTextbox(string field, Table table)
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();
            var expectedChipList = table.Rows.SelectMany(row => row.Values).ToList();
            var chipsValueList = baseActionItem.GetChipsInTheTextbox(field).Select(value => value.Text);
            Verify.AreEqual(expectedChipList, chipsValueList, "Chips value are different");
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

        #region Chips related to the button

        [When(@"User removes following chips of '(.*)' button")]
        public void WhenUserRemovesFollowingChipsOfButton(string button, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                page.GetChipsForButton(button).First(x => x.Text.Equals(row["Chips"])).FindElement(By.XPath(".//button")).Click();
            }
        }

        [Then(@"following chips of '(.*)' button are displayed")]
        public void ThenFollowingChipsOfButtonAreDisplayed(string button, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(page.GetChipsForButton(button).Any(x => x.Text.Equals(row["Chips"])),
                    $"There is no '{row["Chips"]}' chips for '{button}' button");
            }
        }

        [Then(@"following chips of '(.*)' button with '(.*)' index are displayed")]
        public void ThenFollowingChipsOfButtonWithIndexAreDisplayed(string button, int index, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(page.GetChipsForButton(button, index).Any(x => x.Text.Equals(row["Chips"])),
                    $"There is no '{row["Chips"]}' chips for '{button}' button with '{index}' index");
            }
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

        #region Menu panel

        [Then(@"'(.*)' options are checked in the '(.*)' menu panel")]
        public void ThenOptionsAreCheckedInTheMenuPanel(int expectedCount, string buttonAriaLabel)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClickButtonWithAriaLabel(buttonAriaLabel);
            var selectedCount = page.GetAllOptionsFromMenuPanel().Select(x => x.Value).Count(x => x.Equals(true));
            Verify.AreEqual(expectedCount, selectedCount,
                $"Incorrect number of checked values in the '{buttonAriaLabel}' menu");
            _driver.ClickByActions(page.BodyContainer);
        }

        #endregion

        #region Slide toggle

        [When(@"User checks '(.*)' slide toggle")]
        public void WhenUserChecksSlideToggle(string slideToggleName)
        {
            var slide = _driver.NowAt<BaseDashboardPage>();
            slide.SetSlideToggleCondition(slideToggleName, true);
        }

        [When(@"User unchecks '(.*)' slide toggle")]
        public void WhenUserUnchecksSlideToggle(string slideToggleName)
        {
            var slide = _driver.NowAt<BaseDashboardPage>();
            slide.SetSlideToggleCondition(slideToggleName, false);
        }

        [Then(@"'(.*)' slide toggle is not displayed")]
        public void ThenSlideToggleIsNotDisplayed(string slideToggleName)
        {
            var slide = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(slide.GetDisplayStateForSlideToggle(slideToggleName), $"'{slideToggleName}' slide toggle should not be displayed");
        }

        #endregion

        #region Icons

        [When(@"User clicks '(.*)' icon")]
        public void WhenUserClicksIcon(string iconTextInDom)
        {
            var icon = _driver.NowAt<BaseDashboardPage>();
            icon.GetIcon(iconTextInDom).Click();
        }

        [When(@"User clicks '(.*)' mat icon")]
        public void WhenUserClicksMatIcon(string matIconName)
        {
            var icon = _driver.NowAt<BaseDashboardPage>();
            icon.GetMatIconByClassContent(matIconName).Click();
        }

        [Then(@"'(.*)' mat icon is disabled")]
        public void ThenMatIconIsDisabled(string matIconName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(true, page.GetMatIconByClassContent(matIconName).Disabled(),
                $"{matIconName} mat icon is enabled");
        }

        [Then(@"'(.*)' mat icon is not disabled")]
        public void ThenMatIconIsNotDisabled(string matIconName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(false, page.GetMatIconByClassContent(matIconName).Disabled(),
                $"{matIconName} mat icon is disabled");
        }

        [Then(@"'(.*)' mat icon has tooltip with '(.*)' text")]
        public void ThenMatIconHasTooltipWithText(string matIconName, string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.MouseHover(page.GetMatIconByClassContent(matIconName));
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, $"'{matIconName}' mat icon tooltip is incorrect");
        }

        #endregion
    }
}