using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Providers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_FiltersPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listDetails;
        private readonly Filter _filter;

        public EvergreenJnr_FiltersPanel(RemoteWebDriver driver, ListsDetails listsDetails, Filter filter)
        {
            _driver = driver;
            _listDetails = listsDetails;
            _filter = filter;
        }

        [Then(@"Filters panel is displayed to the user")]
        [Then(@"Associations panel is displayed to the user")]
        public void ThenFiltersPanelIsDisplayedToTheUser()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(filterElement.FiltersPanel.Displayed(), "Actions panel was not displayed");
            Logger.Write("Actions Panel panel is visible");
        }

        [Then(@"Filters panel is not displayed to the user")]
        public void ThenFiltersPanelIsNotDisplayedToTheUser()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.FiltersPanel.Displayed(), "Filters panel was displayed");
            Logger.Write("Actions Panel panel is hidden");
        }

        [Then(@"Add New button on Filter panel has tooltip with '(.*)' text")]
        public void ThenAddNewButtonOnFilterPanelHaveTooltipWithText(string text)
        {
            var page = _driver.NowAt<FiltersElement>();
            _driver.MouseHover(page.AddNewFilterButton);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "Tooltip text is not correctly");
        }

        [When(@"User clicks Add New button on the Filter panel")]
        public void WhenUserClicksAddNewButtonOnTheFilterPanel()
        {
            var menu = _driver.NowAt<FiltersElement>();
            _driver.WaitForElementToBeDisplayed(menu.AddNewFilterButton);
            menu.AddNewFilterButton.Click();
            Logger.Write("Add New button was clicked");
        }

        [When(@"User clicks Add And button on the Filter panel")]
        public void WhenUserClicksAddAndButtonOnTheFilterPanel()
        {
            var menu = _driver.NowAt<FiltersElement>();
            _driver.WaitForElementToBeDisplayed(menu.AddAndFilterButton);
            menu.AddAndFilterButton.Click();
            Logger.Write("Add And button was clicked");
        }

        [Then(@"Add And button is displayed on the Filter panel")]
        public void ThenAddAndButtonIsDisplayedOnTheFilterPanel()
        {
            var button = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(button.AddAndFilterButton.Displayed(), "Add And button is not displayed");
        }

        [Then(@"Add And button is not displayed on the Filter panel")]
        public void ThenAddAndButtonIsNotDisplayedOnTheFilterPanel()
        {
            var button = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(button.AddAndFilterButton.Displayed(), "Add And button is displayed");
        }

        [When(@"User moves to the end of categories list")]
        public void WhenUserMovesToTheEndOfCategoriesList()
        {
            var panel = _driver.NowAt<FiltersElement>();
            _driver.MoveToElement(panel.FilterCategories.Last());
            Logger.Write("Filter panel is scrolled down");
        }

        [Then(@"'(.*)' category is placed next to the corresponding project group")]
        public void ThenSpecifiedCategoriesPlacedInParticularProjectGroup(string categoryName)
        {
            var panel = _driver.NowAt<FiltersElement>();

            var allCats = panel.GetCategoriesFromFilterPanelPageByPage();

            foreach (var cat in allCats)
            {
                if (cat.StartsWith(categoryName))
                {
                    string projectName = cat.Split(':').ToList().Last();
                    int curentCategoryIndex = allCats.IndexOf(cat);
                    Verify.That((allCats[curentCategoryIndex - 1].EndsWith(projectName) || allCats[curentCategoryIndex + 1].EndsWith(projectName)), Is.True, $"{cat} category possible appears in wrong place");
                }
            }
        }

        [Then(@"User sees ""(.*)"" section expanded by default in Filters panel")]
        public void ThenUserSeesSectionExpandedByDefaultInFilterPanel(string expectedSection)
        {
            var page = _driver.NowAt<FiltersElement>();
            Verify.That(page.GetExpandedSection(), Is.EqualTo(expectedSection), "Wrong section expanded");
        }

        [When(@"User double clicks Filter Expression text")]
        public void WhenUserDoubleClicksFilterExpressionText()
        {
            var page = _driver.NowAt<FiltersElement>();
            _driver.DoubleClick(page.FilterContent);
        }

        [Then(@"""(.*)"" text is displayed in filter container")]
        public void ThenTextIsDisplayedInFilterContainer(string text)
        {
            var page = _driver.NowAt<BaseRightSideActionsPanel>();
            _driver.MoveToElement(page.PanelHeaderElement);
            _driver.WaitForElementToBeDisplayed(page.PanelHeaderElement);

            var filter = _driver.NowAt<FiltersElement>();
            if (!_driver.IsElementDisplayed(filter.FilterContent))
            {
                filter.FilterExpressionIcon.Click();
            }
            Verify.AreEqual(text, filter.FilterContent.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [Then(@"'(.*)' text is displayed in filter container for (.*)' list")]
        public void ThenTextIsDisplayedInFilterContainerForList(string text, string listName)
        {
            var page = _driver.NowAt<FiltersElement>();
            Verify.AreEqual(text.Replace("{LIST_ID}", _listDetails.GetListIdByName(listName)),
                page.FilterContent.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [When(@"User closes ""(.*)"" filter category")]
        public void ThenUserClosesFilterCategory(string categoryName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.CloseFilterSectionByName(categoryName);
        }

        [When(@"User closes all filters categories")]
        public void WhenUserClosesAllFiltersCategories()
        {
            var columnElement = _driver.NowAt<FiltersElement>();
            foreach (var group in columnElement.GroupTitle)
            {
                group.Click();
            }
        }

        [When(@"User expands ""(.*)"" filter category")]
        public void ThenUserExpandsFilterCategory(string categoryName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.ExpandFilterSectionByName(categoryName);
        }

        [Then(@"Add New button is displayed on the Filter panel")]
        public void ThenAddNewButtonIsDisplayedOnTheFilterPanel()
        {
            var button = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(button.AddNewFilterButton.Displayed(), "Add New button is not displayed");
        }

        [When(@"user select ""(.*)"" filter")]
        public void WhenUserSelectFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AddFilter(filterName);
        }

        [When(@"User clicks Save filter button")]
        public void WhenUserClicksSaveFilterButton()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.UpdateButton.Click();
        }

        [When(@"User selects ""(.*)"" filter from ""(.*)"" category")]
        public void WhenUserSelectsFilterFromCategory(string filterName, string categoryName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AddFilter(filterName, categoryName);
        }

        [Then(@"setting section for ""(.*)"" filter is loaded")]
        public void ThenSettingSectionForFilterIsLoaded(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(filterElement.GetOpenedFilter(filterName).Displayed(),
                "Setting section for selected filter is not loaded");
        }

        [When(@"User clicks in search field for selected Association filter")]
        public void WhenUserClicksInSearchFieldForSelectedAssociationFilter()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.FilterSearchInputs[0].Click();
        }

        [When(@"User clicks in search field in the Filter block")]
        public void WhenUserClicksInSearchFieldInTheFilterBlock()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.LookupFilterSearchTextBox.Click();
        }

        [When(@"User enters ""(.*)"" text in Search field at Filters Panel")]
        public void WhenUserEntersTextInSearchFieldAtFiltersPanel(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.SearchTextBox.Clear();
            filterElement.SearchTextBox.SendKeys(searchedText);
            _driver.WaitForDataLoading();
        }

        [When(@"User clears search textbox in Filters panel")]
        public void WhenUserClearsSearchTextboxInFiltersPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.SearchTextBoxResetButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User enters ""(.*)"" text in Search field at selected Lookup Filter")]
        public void WhenUserEntersTextInSearchFieldAtSelectedLookupFilter(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            if (_driver.IsElementDisplayed(filterElement.LookupFilterSearchTextBox, WebDriverExtensions.WaitTime.Short))
            {
                filterElement.LookupFilterSearchTextBox.Clear();
                filterElement.LookupFilterSearchTextBox.SendKeys(searchedText);
            }
        }

        [Then(@"""(.*)"" value is displayed for selected Lookup Filter")]
        public void ThenValueIsDisplayedForSelectedLookupFilter(string value)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(filterElement.GetValueForLookupFilter(value).Displayed(),
                $"{value} is not displayed for that filter");
        }

        [Then(@"No options are displayed for selected Lookup Filter")]
        public void ThenNoOptionsDisplayedForSelectedLookupFilter()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.IsLookupFilterHasOptionsExpanded(),
                $"Options are displayed for that filter");
        }

        [When(@"User clicks checkbox at selected Lookup Filter")]
        public void WhenUserClicksCheckboxAtSelectedLookupFilter()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            filterElement.LookupFilterCheckbox.Click();
        }

        [When(@"User enters ""(.*)"" text in Search field at selected Filter")]
        public void WhenUserEntersTextInSearchFieldAtSelectedFilter(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            if (!string.IsNullOrWhiteSpace(searchedText))
            {
                _driver.WaitForElementToBeDisplayed(filterElement.FilterSearchTextBox);
                filterElement.FilterSearchTextBox.Clear();
                filterElement.FilterSearchTextBox.SendKeys(searchedText);
            }
        }

        [When(@"User enters '(.*)' text in '(.*)' Search field")]
        public void WhenUserEntersTextInSearchFieldByPlaceholder(string searchedText, string placeholder)
        {
            //should be configured: added search filed only in filter panel
            var baseElement = _driver.NowAt<BaseDashboardPage>();
            baseElement.GetTextbox(placeholder).ClearWithBackspaces();

            baseElement.PopulateTextbox(placeholder, searchedText, false);
        }

        [When(@"User clicks Add button for input filter value")]
        public void WhenUserClicksAddButtonForInputFilterValue()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AddFilterSearchTextBoxValueButton.Click();
        }

        [When(@"User closes ""(.*)"" Chip item in the Filter panel")]
        public void WhenUserClosesChipItemInTheFilterPanel(string chipName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.GetCloseChipButtonByName(chipName).Click();
        }

        [Then(@"Chip box is not displayed in the Filter panel")]
        public void ThenChipBoxIsNotDisplayedInTheFilterPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.FilterChipBox.Displayed(), "Chip box is displayed in the Filter panel");
        }

        [Then(@"Search field in selected Filter is empty")]
        public void ThenSearchFieldInSelectedFilterIsEmpty()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsEmpty(filterElement.FilterSearchTextBox.Text, "Search field in selected Filter is not empty");
        }

        [When(@"User enters ""(.*)"" in Association search field")]
        public void WhenUserEntersInAssociationSearchField(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AssociationSearchTextBox.Click();
            _driver.WaitForElementToBeDisplayed(filterElement.LookupFilterSearchTextBox);
            filterElement.AssociationSearchTextBox.Clear();
            filterElement.AssociationSearchTextBox.SendKeys(searchedText);
        }

        [When(@"User select ""(.*)"" in Association")]
        public void WhenUserSelectInAssociation(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AssociationSearchTextBox.Click();
            _driver.WaitForElementToBeDisplayed(filterElement.LookupFilterSearchTextBox);
            filterElement.AssociationSearchTextBox.Clear();
            filterElement.AssociationSearchTextBox.SendKeys(checkboxName);
            filterElement.GetAssociationCheckbox(checkboxName);
        }

        [Then(@"filter date checkboxes are sorted by desc")]
        public void ThenFilterDateCheckboxesAreSortedByDesc()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var originalList = filterElement.GetCheckboxLabelsOfFilterOptions().Select(x=>x.Text).Where(x => (!x.Equals("")&&!x.Equals("Empty"))).ToList();
                SortingHelper.IsListSortedByDate(originalList, false);
        }

        [When(@"User selects current date checkbox from Filter panel")]
        public void WhenUserSelectsCurrentDateCheckboxFromFilterPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.GetFilterCheckboxByName(DateTime.Now.ToString("dd MMM yyyy")).Click();
        }

        [When(@"User select ""(.*)"" Association for Application filter with Lookup value")]
        public void WhenUserSelectAssociationForApplicationFilterWithLookupValue(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AssociationSearchTextBox.Click();
            _driver.WaitForElementToBeDisplayed(filterElement.LookupFilterSearchTextBox);
            filterElement.AssociationSearchTextBox.Clear();
            filterElement.AssociationSearchTextBox.SendKeys(checkboxName);
            filterElement.GetCheckboxForAssociationLookupFilter(checkboxName);
        }

        [When(@"User is deselect ""(.*)"" in Association")]
        public void WhenUserIsDeselectInAssociation(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AssociationSearchTextBox.Click();
            filterElement.AssociationSearchTextBox.SendKeys(checkboxName);
            filterElement.GetAssociationCheckbox(checkboxName);
            filterElement.AssociationSearchTextBox.Clear();
        }

        [When(@"User is deselect ""(.*)"" Association for Application filter with Lookup value")]
        public void WhenUserIsDeselectAssociationForApplicationFilterWithLookupValue(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AssociationSearchTextBox.Click();
            filterElement.AssociationSearchTextBox.SendKeys(checkboxName);
            filterElement.GetCheckboxForAssociationLookupFilter(checkboxName);
            filterElement.AssociationSearchTextBox.Clear();
        }

        [Then(@"only positive Associations is displayed")]
        public void ThenOnlyPositiveAssociationsIsDisplayed()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AssociationSearchTextBox.Click();
            filterElement.CloseAssociationSearchButton.Click();
            filterElement.AssociationSearchTextBox.Click();
            Verify.AreEqual(5, filterElement.AssociationCheckbox.Count, "PLEASE ADD EXCEPTION MESSAGE");
            foreach (var element in filterElement.Association)
                Verify.DoesNotContain("not", element.Text, "Negative association is displayed");
        }

        [Then(@"only negative Associations is displayed")]
        public void ThenOnlyNegativeAssociationsIsDisplayed()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.CloseAssociationSearchButton.Click();
            filterElement.AssociationSearchTextBox.Click();
            Verify.AreEqual(5, filterElement.AssociationCheckbox.Count, "PLEASE ADD EXCEPTION MESSAGE");
            foreach (var element in filterElement.Association)
                Verify.Contains("not", element.Text.ToLower(), "Positive association is displayed");
        }

        [Then(@"search values in Association section working by specific search criteria")]
        public void ThenSearchValuesInAssociationSectionWorkingBySpecificSearchCriteria()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var searchCriteria = filterElement.LookupFilterSearchTextBox.GetAttribute("value");
            var associationList = filterElement.GetAssociationsList().Select(element => element.Text).ToList();
            foreach (var association in associationList)
                Verify.Contains(searchCriteria.ToLower(), association.ToLower(),
                    $"Search in Associations list is not working for '{searchCriteria}' value");
        }

        [Then(@"""(.*)"" filter is not presented in the filters list")]
        public void ThenFilterIsNotPresentedInTheFiltersList(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.CheckFilterAvailability(filterName),
                $"{filterName} is available in the search");
        }

        [Then(@"""(.*)"" filter is presented in the filters list")]
        public void ThenFilterIsPresentedInTheFiltersList(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(filterElement.CheckFilterAvailability(filterName),
                $"{filterName} is not available in the search");
        }

        [When(@"User select ""(.*)"" Operator value")]
        public void WhenUserSelectOperatorValue(string operatorValue)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.SelectOperator(operatorValue);
        }

        [Then(@"following operator options available:")]
        public void WhenUserSeeOperatorValue(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);

            Verify.That(expectedList, Is.EqualTo(filterElement.SelectOperatorOptions()), "Lists are different");
        }

        [When(@"User have create ""(.*)"" Values filter with column and following options:")]
        public void WhenUserHaveCreateValuesFilterWithColumnAndFollowingOptions(string operatorValue, Table table)
        {
            var filter = new ValueFilter(_driver, operatorValue, true, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and following value:")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndFollowingValue(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var type = new ValueFilter(_driver, operatorValue, true, table);
            type.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with added column and following value:")]
        public void WhenUserAddAndFilterWhereTypeIsWithAddedColumnAndFollowingValue(string filterName, string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var type = new ValueFilter(_driver, operatorValue, true, table);
            type.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" without added column and following value:")]
        public void WhenUserAddFilterWhereTypeIsWithoutAddedColumnAndFollowingValue(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var type = new ValueFilter(_driver, operatorValue, false, table);
            type.Do();
            _driver.WaitForDataLoading();
        }

        [When(@"User have created ""(.*)"" filter with column and following options:")]
        public void WhenUserHaveCreatedFilterWithColumnAndFollowingOptions(string operatorValue,
            Table table)
        {
            CreateFilterWithCheckboxes(operatorValue, true, table);
        }

        [When(@"User have created ""(.*)"" filter without column and following options:")]
        public void WhenUserHaveCreatedFilterWithoutColumnAndFollowingOptions(string operatorValue,
            Table table)
        {
            CreateFilterWithCheckboxes(operatorValue, false, table);
        }

        private void CreateFilterWithCheckboxes(string operatorValue, bool columnOption,
            Table table)
        {
            var filter = new CheckBoxesFilter(_driver, operatorValue, columnOption, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and following checkboxes:")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndFollowingCheckboxes(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new CheckBoxesFilter(_driver, operatorValue, true, table);
            //Save filter in context
            _filter.FilterSettings = filter;
            _filter.FilterName = filterName;
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" without added column and following checkboxes:")]
        public void WhenUserAddFilterWhereTypeIsWithoutAddedColumnAndFollowingCheckboxes(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new CheckBoxesFilter(_driver, operatorValue, false, table);
            filter.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" without added column and following checkboxes:")]
        public void WhenUserAddAndFilterWhereTypeIsWithoutAddedColumnAndFollowingCheckboxes(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new CheckBoxesFilter(_driver, operatorValue, false, table);
            //Save filter in context
            _filter.FilterSettings = filter;
            _filter.FilterName = filterName;
            filter.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with added column and following checkboxes:")]
        public void WhenUserAddAndFilterWhereTypeIsWithAddedColumnAndFollowingCheckboxes(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new CheckBoxesFilter(_driver, operatorValue, true, table);
            //Save filter in context
            _filter.FilterSettings = filter;
            _filter.FilterName = filterName;
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with selected Checkboxes and following Association:")]
        public void WhenUserAddFilterWhereTypeIsWithSelectedCheckboxesAndFollowingAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new CheckboxesAssociationFilter(_driver, operatorValue, true, table);
            filter.Do();
            filtersNames.UpdateButton.Click();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with selected Checkboxes and following Association:")]
        public void WhenUserAddAndFilterWhereTypeIsWithSelectedCheckboxesAndFollowingAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new CheckboxesAssociationFilter(_driver, operatorValue, true, table);
            filter.Do();
            filtersNames.UpdateButton.Click();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with selected Expanded Checkboxes and following Association:")]
        public void WhenUserAddFilterWhereTypeIsWithSelectedExpandedCheckboxesAndFollowingAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new ExpandedCheckboxesAssociationFilter(_driver, operatorValue, true, table);
            filter.Do();
            filtersNames.UpdateButton.Click();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Value and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingValueAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new ValueAssociationFilter(_driver, operatorValue, table);
            filter.Do();
            _driver.WaitForDataLoading();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with following Value and Association:")]
        public void WhenUserAddAndFilterWhereTypeIsWithFollowingValueAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new ValueAssociationFilter(_driver, operatorValue, table);
            filter.Do();
            _driver.WaitForDataLoading();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with Selected Value and following Association:")]
        public void WhenUserAddFilterWhereTypeIsWithSelectedValueAndFollowingAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new ListFilter(_driver, operatorValue, table);
            filter.Do();
            _driver.WaitForDataLoading();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with Selected Value and following Association:")]
        public void WhenUserAddAndFilterWhereTypeIsWithSelectedValueAndFollowingAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new ListFilter(_driver, operatorValue, table);
            filter.Do();
            _driver.WaitForDataLoading();
        }

        [When(@"User have created ""(.*)"" filter with SelectedList list and following Association:")]
        public void WhenUserHaveCreatedFilterWithSelectedListListAndFollowingAssociation(string operatorValue,
            Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new ListFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Lookup Value and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingLookupValueAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupValueAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with following Lookup Value and Association:")]
        public void WhenUserAddAndFilterWhereTypeIsWithFollowingLookupValueAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new LookupValueAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add Advanced ""(.*)"" filter where type is ""(.*)"" with following Lookup Value and Association:")]
        public void WhenUserAddAdvancedFilterWhereTypeIsWithFollowingLookupValueAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupValueAdvancedFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Data and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingDataAndAssociation(string filterName, string operatorValue,
            Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new DataAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with following Data and Association:")]
        public void WhenUserAddAndFilterWhereTypeIsWithFollowingDataAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new DataAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and Date options")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndDateOptions(string filterName, string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new BetweenOperatorFilter(_driver, operatorValue, true, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" without added column and Date options")]
        public void WhenUserAddFilterWhereTypeIsWithoutAddedColumnAndDateOptions(string filterName, string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new BetweenOperatorFilter(_driver, operatorValue, false, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Date options and Associations:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingDateOptionsAndAssociations(string filterName, string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new BetweenDataAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with following Number and Association:")]
        public void WhenUserAddAndFilterWhereTypeIsWithFollowingNumberAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new NumberAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Number and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingNumberAndAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new NumberAssociationFilter(_driver, operatorValue, table);
            filter.Do();
            _driver.WaitForDataLoading();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and ""(.*)"" Date filter")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndDateFilter(string filterName, string operatorValue,
            string filterValue)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new DateFilter(_driver, operatorValue, true, filterValue);
            filter.Do();
        }

        [When(@"User have created ""(.*)"" Date filter with column and ""(.*)"" option")]
        public void WhenUserHaveCreatedDateFilterWithColumnAndOption(string operatorValue, string filterValue)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new DateFilter(_driver, operatorValue, true, filterValue);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and ""(.*)"" Tree List option")]
        public void WhenUserAddFilterWhereTypeIsWithoutAddedColumnAndTreeListOption(string filterName,
            string operatorValue,
            string filterValue)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new TreeList(_driver, operatorValue, true, filterValue);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Tree List option and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingTreeListOptionAndAssociation(string filterName, string operatorValue,
            Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new TreeAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and ""(.*)"" Lookup option")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndLookupOption(string filterName, string operatorValue,
            string filterValue)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupFilter(_driver, operatorValue, true, filterValue);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" without added column and ""(.*)"" Lookup option")]
        public void WhenUserAddFilterWhereTypeIsWithoutAddedColumnAndLookupOption(string filterName,
            string operatorValue, string filterValue)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupFilter(_driver, operatorValue, false, filterValue);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and Lookup option")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndLookupOption(string filterName, string operatorValue,
            Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupFilterTable(_driver, operatorValue, true, table);
            filter.Do();
        }

        [When(@"User Add And ""(.*)"" filter where type is ""(.*)"" with added column and Lookup option")]
        public void WhenUserAddAndFilterWhereTypeIsWithAddedColumnAndLookupOption(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new LookupFilterTable(_driver, operatorValue, true, table);
            filter.Do();
        }

        [When(@"User selects And ""(.*)"" filter where type is ""(.*)"" with added column and Lookup option:")]
        public void WhenUserSelectsAndFilterWhereTypeIsWithAddedColumnAndLookupOption(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddAndFilter(filterName);
            var filter = new LookupFilterTableWithoutSave(_driver, operatorValue, true, table);
            filter.Do();
        }

        [When(@"User have created ""(.*)"" Lookup filter with column and ""(.*)"" option")]
        public void WhenUserHaveCreatedLookupFilterWithColumnAndOption(string operatorValue, string filterValue)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new LookupFilter(_driver, operatorValue, true, filterValue);
            filter.Do();
        }

        [Then(@"""(.*)"" filter is added to the list")]
        public void ThenFilterIsAddedToTheList(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.That(filterElement.GetFiltersNamesFromFilterPanel(filterName), Does.Contain(filterName));
        }

        [Then(@"table data is filtered correctly")]
        public void ThenTableDataIsFilteredCorrectly()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var basePage = _driver.NowAt<BaseGridPage>();
            var filtersNames = filterElement.GetFiltersNames();
            var allColumns = filtersNames.Select(filtersName =>
                new KeyValuePair<string, List<string>>(filtersName, basePage.GetColumnContentByColumnName(filtersName)));
            for (var i = 0; i < allColumns.First().Value.Count; i++)
            {
                var result = false;

                //Check that all values in the row are empty
                //This happens after 22 row when data is not loading
                var allValuesAreEmpty = allColumns.Select(column => column.Value[i])
                    .All(rowValue => string.IsNullOrEmpty(rowValue));
                if (allValuesAreEmpty)
                {
                    result = true;
                    continue;
                }

                foreach (var filtersName in filtersNames)
                {
                    foreach (var filterValue in filterElement.GetFilterValuesByFilterName(filtersName))
                    {
                        if (string.IsNullOrEmpty(allColumns.First(x => x.Key.Equals(filtersName)).Value[i].ToLower()))
                            continue;

                        if (filterValue.ToLower()
                            .Contains(allColumns.First(x => x.Key.Equals(filtersName)).Value[i].ToLower()))
                        {
                            result = true;
                            break;
                        }
                    }

                    if (result) break;
                }

                Verify.IsTrue(result, "Table data is filtered incorrectly");
            }
        }

        [Then(@"table data in column is filtered correctly")]
        public void ThenTableDataInColumnIsFilteredCorrectly()
        {
            _filter.CheckFilterDate();
        }

        [When(@"User have removed ""(.*)"" filter")]
        public void WhenUserHaveRemovedFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();

            filterElement.GetEditFilterButton(filterName).Click();
            _driver.WaitForElementToBeDisplayed(filterElement.RemoveFilterButton);
            filterElement.RemoveFilterButton.Click();
        }

        [When(@"User deletes filter and agGrid does not reload")]
        public void WhenUserDeletesFilterAndAgGridDoesNotReload()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.RemoveFilterButton.Click();
            Verify.IsTrue(filterElement.ResultsOnPageCount.Displayed(), "agGrid is reload");
        }

        [When(@"User cancels filter and agGrid does not reload")]
        public void WhenUserCancelsFilterAndAgGridDoesNotReload()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.CancelButton.Click();
            Verify.IsTrue(filterElement.ResultsOnPageCount.Displayed(), "agGrid is reload");
        }

        [When(@"User click Edit button for ""(.*)"" filter")]
        public void WhenUserClickEditButtonForFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            filterElement.GetEditFilterButton(filterName).Click();
        }

        [When(@"User navigate to Edit button for ""(.*)"" filter")]
        public void WhenUserNavigateToEditButtonForFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.MouseHover(filterElement.GetEditFilterButton(filterName));
        }

        [Then(@"Edit button is displayed correctly for ""(.*)"" filter")]
        public void ThenEditButtonIsDisplayedCorrectlyForFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(filterElement.GetEditFilterButton(filterName).Displayed(),
                $"Edit button is not displayed for '{filterName}' filter");
        }

        [Then(@"There are no any expanded blocks in Filter panel")]
        public void ThenThereAreNoAnyExpandedBlocksInFilterPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();

            Verify.That(_driver.IsElementDisplayed(filterElement.ExpandedFilterBlock), Is.False,
                $"Looks like there is an expanded block in Filter panel");
        }

        [Then(@"""(.*)"" value is displayed in the filter info")]
        public void ThenValueIsDisplayedInTheFilterInfo(string value)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.GetFilterValue(value);
        }

        [Then(@"User Description field is not displayed")]
        public void ThenUserDescriptionFieldIsNotDisplayed()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.UserDescriptionField.Displayed(), "User Description field is visible");
        }

        [When(@"User deletes the selected lookup filter ""(.*)"" value")]
        public void WhenUserDeletesTheSelectedLookupFilterValue(string filterValue)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.CloseFiltersLookupValue(filterValue).Click();
        }

        [Then(@"User changes filter type to ""(.*)""")]
        public void ThenUserChangesFilterTypeTo(string filterType)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.FilterTypeDropdown.Click();
            filterElement.SelectFilterType(filterType);
            filterElement.UpdateButton.Click();
        }

        [When(@"User selects ""(.*)"" list for Saved List")]
        public void WhenUserSelectsListForSavedList(string listName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.SelectSavedListByName(listName);
        }

        [Then(@"""(.*)"" list is displayed for Saved List filter")]
        public void ThenListIsDisplayedForSavedListFilter(string listName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.FilterSearchInputs.FirstOrDefault().Click();
            Verify.IsTrue(filterElement.ListNameForSavedListFilter(listName),
                $"{listName} is not displayed for Saved List filter");
        }

        [Then(@"""(.*)"" list is not displayed for Saved List filter")]
        public void ThenListIsNotDisplayedForSavedListFilter(string listName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.ListNameForSavedListFilter(listName),
                $"{listName} is displayed for Saved List filter");
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for edit filter button")]
        public void ThenTooltipIsDisplayedWithTextForEditFilterButton(string text)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.MouseHover(filterElement.EditFilterButton);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" filter is removed from filters")]
        public void ThenFilterIsRemovedFromFilters(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.CheckThatFilterIsRemoved(filterName),
                $"{filterName} filter is not removed from filters");
        }

        [When(@"User have reset all columns")]
        [When(@"User have reset all filters")]
        public void WhenUserHaveResetAllFiltersOrColumns()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForElementToBeDisplayed(filterElement.ResetFiltersButton);
            _driver.MouseHover(filterElement.ResetFiltersButton);
            filterElement.ResetFiltersButton.Click();
        }

        #region Checkboxes on Filter panel

        [When(@"User adds column for the selected filter")]
        public void WhenUserAddsColumnForTheSelectedFilter()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AddFiltersColumnName.Click();
        }

        [Then(@"""(.*)"" checkbox is checked")]
        public void ThenCheckboxIsChecked(string addColumn)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(filterElement.AddCategoryColumnCheckbox.Selected, $"{addColumn} Checkbox is not checked");
        }

        [Then(@"Add ""(.*)"" column checkbox is displayed to the user")]
        public void ThenAddColumnCheckboxIsDisplayedToTheUser(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.CheckboxNameForFilter(checkboxName);
        }

        [Then(@"""(.*)""checkbox is checked and cannot be unchecked")]
        public void ThenCheckboxIsCheckedAndCannotBeUnchecked(string addColumn)
        {
            AssertAddColumnCheckboxEnabledState(true, addColumn);
            AssertAddColumnCheckboxChekedState(true, addColumn);
        }

        [Then(@"""(.*)"" checkbox is unchecked")]
        public void ThenCheckboxIsUnchecked(string addColumn)
        {
            AssertAddColumnCheckboxChekedState(false, addColumn);
        }

        [Then(@"""(.*)"" checkbox is disabled")]
        public void ThenCheckboxIsDisabled(string addColumn)
        {
            AssertAddColumnCheckboxEnabledState(true, addColumn);
        }

        [Then(@"""(.*)"" checkbox is not disabled")]
        public void ThenCheckboxIsNotDisabled(string addColumn)
        {
            AssertAddColumnCheckboxEnabledState(false, addColumn);
        }

        private void AssertAddColumnCheckboxChekedState(bool expectedCondition, string addColumn)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.AreEqual(expectedCondition, filterElement.AddCategoryColumnCheckbox.Selected,
                $"{addColumn} Cheked state is incorrect");
        }

        private void AssertAddColumnCheckboxEnabledState(bool expectedCondition, string addColumn)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.AreEqual(expectedCondition,
                Convert.ToBoolean(filterElement.AddCategoryColumnCheckbox.GetAttribute("disabled")),
                $"{addColumn} Checkbox state is incorrect");
        }

        [Then(@"""(.*)"" checkbox is not displayed")]
        public void ThenCheckboxIsNotDisplayed(string checkbox)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.AddCategoryColumnCheckbox.Displayed(),
                $"{checkbox} checkbox is not displayed");
            Logger.Write($"{checkbox} checkbox is displayed");
        }

        [Then(@"checkboxes are displayed to the User:")]
        public void ThenCheckboxesAreDisplayedToTheUser(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.AddCategoryColumnName.Select(value => value.Text);
            Verify.AreEqual(expectedList, actualList, "Filter settings values are different");
        }

        #endregion

        [Then(@"""(.*)"" option is available at first place")]
        public void ThenOptionIsAvailableAtFirstPlace(string optionName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.AreEqual(optionName, filterElement.GetSelectBoxes().First().Text,
                $"{optionName} is not available at first place");
        }

        [Then(@"Values is displayed in added filter info")]
        public void ThenValuesIsDisplayedInAddedFilterInfo(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterValues.Select(value => value.Text);
            Verify.AreEqual(expectedList, actualList, "Filter settings values are different");
        }

        [Then(@"""(.*)"" filter is displayed in the Filters panel")]
        public void ThenFilterIsDisplayedInTheFiltersPanel(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.FilterNameInThePanel(filterName);
        }

        [Then(@"correct true and false options are displayed in filter settings")]
        public void ThenCorrectTrueAndFalseOptionsAreDisplayedInFilterSettings()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.AreEqual($"{UrlProvider.Url}evergreen/assets/img/tick.png",
                filterElement.GetBooleanCheckboxImg("TRUE").GetAttribute("src"), "Incorrect image for True value");
            Verify.AreEqual($"{UrlProvider.Url}evergreen/assets/img/cross.png",
                filterElement.GetBooleanCheckboxImg("FALSE").GetAttribute("src"), "Incorrect image for False value");
            //TODO: Yurii 10oct2019 - remove below check per Kristina's answer about UNKNOWN option and img, it was changed to Empty
            //Verify.AreEqual($"{UrlProvider.Url}evergreen/assets/img/unknown.png",
            //filterElement.GetBooleanCheckboxImg("UNKNOWN").GetAttribute("src"),
            //"Incorrect image for Unknown value");
        }

        [Then(@"""(.*)"" option is available for this filter")]
        public void ThenOptionIsAvailableForThisFilter(string optionName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.OperatorDropdown.Click();
            _driver.WaitForElementsToBeDisplayed(filterElement.OperatorOptions);
            var availableOptions = filterElement.OperatorOptions.Select(value => value.Text).ToList();
            Verify.AreEqual(optionName.Split(',').Select(x => x.TrimStart(' ').TrimEnd(' ')).ToList(),
                availableOptions, "Some options are not available for selected filter");
            filterElement.BodyContainer.Click();
        }

        [Then(@"""(.*)"" checkbox is available for this filter")]
        public void ThenCheckboxIsAvailableForThisFilter(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var availableOptions = filterElement.FilterCheckboxOptions.Select(value => value.Text).ToList();
            Verify.AreEqual(checkboxName.Split(',').Select(x => x.TrimStart(' ').TrimEnd(' ')).ToList(),
                availableOptions, "Some checkbox are not available for selected filter");
            filterElement.BodyContainer.Click();
        }

        [Then(@"""(.*)"" checkbox is not available for current opened filter")]
        public void ThenCheckboxIsNotAvailableForCurrentOpenedFilter(string checkboxName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var availableOptions = filterElement.FilterCheckboxOptionsLabels.Select(value => value.GetAttribute("textContent")).ToList();

            Verify.That(availableOptions, Does.Not.Contain(checkboxName), "Checkbox available for current opened filter");
        }

        [Then(@"Following checkboxes are available for current opened filter:")]
        public void ThenCheckboxIsNotAvailableForCurrentOpenedFilter(Table checkboxes)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var availableOptions = filterElement.FilterCheckboxOptionsLabels
                .Select(value => value.GetAttribute("textContent")).ToList();

            foreach (var row in checkboxes.Rows)
            {
                Verify.That(availableOptions, Does.Contain(row.Values.FirstOrDefault()), "Checkbox available for current opened filter");
            }
        }

        [When(@"User deletes one character from the Search field")]
        public void WhenUserDeletesOneCharacterFromTheSearchField()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.LookupFilterSearchTextBox.SendKeys(OpenQA.Selenium.Keys.Backspace);
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" results are displayed in the Filter panel")]
        public void ThenResultsAreDisplayedInTheFilterPanel(string showedResultsCount)
        {
            var filtersPanel = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            Verify.AreEqual(showedResultsCount, filtersPanel.GetShowedResultsCount(),
                $"Number of rows is not {showedResultsCount}");
        }

        [Then(@"""(.*)"" of all shown label displays in the Filter panel")]
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

            page.BodyContainer.Click();
        }

        #region Filter URL

        [When(@"User is remove filter by URL")]
        public void WhenUserIsRemoveFilterByURL()
        {
            _driver.WaitForDataLoading();
            var currentUrl = _driver.Url;
            const string pattern = @"\$filter=(.*)\&";
            var originalPart = Regex.Match(currentUrl, pattern).Value;
            var urlToNavigate = currentUrl.Replace(originalPart, string.Empty);
            _driver.NavigateToUrl(urlToNavigate);

            var page = _driver.NowAt<BaseDashboardPage>();
            if (page.StatusCodeLabel.Displayed()) throw new Exception("500 error was returned");
        }

        [When(@"User is remove part of filter URL")]
        public void WhenUserIsRemovePartOfFilterURL()
        {
            _driver.WaitForDataLoading();
            var currentUrl = _driver.Url;
            const string pattern = @"\$filter=(.*)\&";
            var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
            var urlToNavigate = currentUrl.Replace(originalPart, string.Empty);
            _driver.NavigateToUrl(urlToNavigate);

            var page = _driver.NowAt<BaseDashboardPage>();
            if (page.StatusCodeLabel.Displayed()) throw new Exception("500 error was returned");
        }

        [Then(@"""(.*)"" filter with ""(.*)"" values is added to URL on ""(.*)"" page")]
        public void ThenFilterWithValuesIsAddedToUrlOnPage(string filterName, string values, string pageName)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"filter=(.*)";
            var urlPartToCheck = Regex.Match(currentUrl, pattern).Groups[1].Value;
            var valuesList = values.Split(',');
            foreach (var value in valuesList)
                Verify.Contains(value.TrimStart(' ').TrimEnd(' ').ToLower(), urlPartToCheck.ToLower(),
                    $"{value} is not added to URL for {filterName} filter");

            Verify.Contains(ColumnNameToUrlConvertor.Convert(pageName, filterName).ToLower(),
                urlPartToCheck.ToLower(),
                $"{filterName} is not added to URL");
        }
        #endregion

        [Then(@"Options is displayed in added filter info")]
        public void ThenOptionsIsDisplayedInAddedFilterInfo(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterOperators.Select(value => value.Text);
            Verify.AreEqual(expectedList, actualList, "Filter settings options are different");
        }

        [Then(@"Associations is displayed in the filter")]
        public void ThenAssociationsIsDisplayedInTheFilter(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            foreach (var row in table.Rows)
                filterElement.GetAssociationsList().Select(value => value.Text).ToList().Contains(row.Values.First());
        }

        [Then(@"Associations panel is displayed in the filter")]
        public void ThenAssociationsPanelIsDisplayedInTheFilter()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(filterElement.AssociationSearchTextBox.Displayed(), "Associations panel is not displayed");
        }

        [Then(@"Associations panel is not displayed to the user")]
        public void ThenAssociationsPanelIsNotDisplayedToTheUser()
        {
            var rightSideActionsPanel = _driver.NowAt<BaseRightSideActionsPanel>();
            Verify.IsFalse(rightSideActionsPanel.IsPanelOpened("Associations"), "Associations panel is displayed");
        }

        [Then(@"""(.*)"" is displayed in added filter info")]
        public void ThenIsDisplayedInAddedFilterInfo(string text)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filterLabels = filterElement.AddedFilterLabels.Select(element => element.Text).ToList();
            Verify.Contains(text, filterLabels, $"Filter with {text} not found in the list");
        }

        [Then(@"Filter name is colored in the added filter info")]
        public void ThenFilterNameIsColoredInTheAddedFilterInfo()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.AreEqual("rgba(242, 88, 49, 1)", filterElement.GetFilterFontColor(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Filter value is shown in bold in the added filter info")]
        public void ThenFilterValueIsShownInBoldInTheAddedFilterInfo()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.AreEqual("700", filterElement.GetFilterFontWeight(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        #region Sections

        [Then(@"""(.*)"" with ""(.*)"" category is displayed on Filters panel")]
        public void ThenWithCategoryIsDisplayedOnFiltersPanel(string filterName, string categoryCount)
        {
            var page = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(page.GetFilterCategory(filterName, categoryCount).Displayed(),
                "Incorrect subcategories count for selected category");
        }

        [Then(@"""(.*)"" section is not displayed in the Filter panel")]
        public void ThenSectionIsNotDisplayedInTheFilterPanel(string categoryName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsFalse(filterElement.CategoryIsDisplayed(categoryName),
                $"{categoryName} category still displayed in Filter Panel");
        }

        [Then(@"Category with counter is displayed on Filter panel")]
        public void ThenCounterWithCategoryIsDisplayedOnColumnsPanel(Table table)
        {
            var page = _driver.NowAt<FiltersElement>();

            foreach (var row in table.Rows)
                Verify.That(page.GetSubcategoriesCountByCategoryName(row["Category"]).ToString(), Is.EqualTo(row["Number"]),
                    $"Check {row["Category"]} category");
        }

        [Then(@"Category is not displayed in the Filter panel")]
        public void ThenCategoryIsNotDisplayedInTheColumnsPanel(Table table)
        {
            var page = _driver.NowAt<FiltersElement>();

            foreach (var row in table.Rows)
                Verify.That(page.CategoryIsDisplayed(row["Category"]), Is.False,
                    $"Check {row["Category"]} category");
        }

        [Then(@"""(.*)"" section is displayed in the Filter panel")]
        public void ThenSectionIsDisplayedInTheFilterPanel(string categoryName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Verify.IsTrue(filterElement.CategoryIsDisplayed(categoryName),
                $"{categoryName} category is not displayed in Filter Panel");
        }

        [Then(@"Minimize buttons are displayed for all category in Filters panel")]
        public void ThenMinimizeButtonsAreDisplayedForAllCategoryInFiltersPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            var groupCount = filterElement.GroupTitle.Count;
            Verify.AreEqual(groupCount, filterElement.MinimizeGroupButton.Count, "Minimize buttons are not displayed");
        }

        [Then(@"Maximize buttons are displayed for all category in Filters panel")]
        public void ThenMaximizeButtonsAreDisplayedForAllCategoryInFiltersPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            var groupCount = filterElement.GroupTitle.Count - 1;
            Verify.AreEqual(groupCount, filterElement.MaximizeGroupButton.Count, "Maximize buttons are not displayed");
        }

        [Then(@"the following Filters subcategories are displayed for open category:")]
        public void ThenTheFollowingFiltersSubcategoriesAreDisplayedForOpenCategory(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.SelectedFiltersSubcategoryList.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList, "Subcategory values are different");
        }

        [Then(@"the following Filters subcategories are presented for open category:")]
        public void ThenTheFollowingFiltersSubcategoriesArePresentedForOpenCategory(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.SelectedFiltersSubcategoryList.Select(value => value.Text).ToList();

            foreach (var item in expectedList)
            {
                Verify.That(actualList, Does.Contain(item), $"{item} value is missing");
            }
        }

        [Then(@"the following Column subcategories are displayed for open category:")]
        public void ThenTheFollowingColumnSubcategoriesAreDisplayedForOpenCategory(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.SelectedColumnsSubcategoryList.Select(value => value.Text).Where(x => !string.IsNullOrEmpty(x)).ToList();
            Verify.AreEqual(expectedList, actualList, "Subcategory values are different");
        }

        [Then(@"the following subcategories are displayed for Selected Columns category:")]
        public void ThenTheFollowingSubcategoriesAreDisplayedForSelectedColumnsCategory(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.ColumnSubcategoryList.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList, "Subcategory values are different");
        }

        [Then(@"the following subcategories are NOT displayed for Selected Columns category:")]
        public void ThenTheFollowingSubcategoriesAreNotDisplayedForSelectedColumnsCategory(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.SelectedColumnsSubcategoryList.Select(value => value.Text).ToList();
            foreach (var value in expectedList)
                Verify.IsTrue(!actualList.Contains(value), $"{value} is displayed for that category");
        }

        [Then(@"the following subcategories are NOT displayed for Filters categories:")]
        public void ThenTheFollowingSubcategoriesAreNotDisplayedForFiltersCategories(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.SelectedFiltersSubcategoryList.Select(value => value.Text).ToList();
            foreach (var value in expectedList)
                Verify.IsTrue(!actualList.Contains(value), $"{value} is displayed for that category");
        }

        [Then(@"the following subcategories are displayed for Selected Filters category:")]
        public void ThenTheFollowingSubcategoriesAreDisplayedForSelectedFiltersCategory(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.FilterSubcategoryList.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList, "Subcategory values are different");
        }

        [Then(@"the subcategories are displayed for open category in alphabetical order")]
        public void ThenTheSubcategoriesAreDisplayedForOpenCategoryInAlphabeticalOrder()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var list = page.SelectedFiltersSubcategoryList.Select(x => x.Text).ToList();
            Verify.AreEqual(list.OrderBy(s => s), list, "Subcategories are not in alphabetical order");
        }

        [Then(@"the subcategories are displayed for open category in alphabetical order on Filters panel")]
        public void ThenTheSubcategoriesAreDisplayedForOpenCategoryInAlphabeticalOrderOnFiltersPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var list = page.FilterSubcategoryList.Select(x => x.Text).ToList();
            Verify.AreEqual(list.OrderBy(s => s), list, "Subcategories are not in alphabetical order");
        }

        #endregion

        [Then(@"message '(.*)' is displayed to the user")]
        public void ThenMessageIsDisplayedToTheUser(string message)
        {
            var page = _driver.NowAt<FiltersElement>();
            _driver.WaitForDataLoading();
            Verify.AreEqual(message, page.NoResultsFoundMessage.Text.Replace("\r\n", " "), $"{message} is not displayed");
        }

        [When(@"User change selected checkboxes:")]
        public void WhenUserChangeSelectedCheckboxes(Table table)
        {
            var filter = new ChangeCheckboxesFilter(_driver, table);
            filter.Do();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
        }

        [When(@"User changes filter date to ""(.*)""")]
        public void WhenUserChangesFilterDateDate(string date)
        {
            var page = _driver.NowAt<FiltersElement>();
            _driver.WaitForElementToBeDisplayed(page.InputDate);

            //TODO: clear() method doesn't work for now. Remove code below and use clear() when it works again
            page.InputDate.Click();
            page.InputDate.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            page.InputDate.SendKeys(OpenQA.Selenium.Keys.Delete);
            //page.InputDate.Clear();
            page.InputDate.SendKeys(date);
            page.UpdateButton.Click();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
        }

        [Then(@"User save change in current filter")]
        public void ThenUserSaveChangeInCurrentFilter()
        {
            var filterPanel = _driver.NowAt<FiltersElement>();
            _driver.WaitForElementToBeDisplayed(filterPanel.SaveButton);
            filterPanel.SaveButton.Click();
        }

        [Then(@"reset button in Search field at selected Filter is displayed")]
        public void ThenResetButtonInSearchFieldAtSelectedFilterIsDisplayed()
        {
            var page = _driver.NowAt<FiltersElement>();
            _driver.WaitForElementToBeDisplayed(page.CloseAssociationSearchButton);
            Verify.IsTrue(page.CloseAssociationSearchButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [Then(@"color for following values are displayed correctly:")]
        public void ThenColorForFollowingValuesAreDisplayedCorrectly(Table table)
        {
            var page = _driver.NowAt<FiltersElement>();
            foreach (var row in table.Rows)
            {
                var getColor = page.GetColorForReadinessFilterValue(row["Color"]).GetAttribute("style").Split(';')
                    .First().Split(':').Last().TrimStart(' ').TrimEnd(' ');
                Verify.AreEqual(ColorsConvertor.Convert(row["Color"]), getColor, "Colors are different");
            }
        }

        [Then(@"No ring icon displayed for Empty item in Lookup")]
        public void ThenNoRingIconDisplayedForEmptyItemInLookup()
        {
            var page = _driver.NowAt<FiltersElement>();
            Verify.That(page.IsComplianceOptionHasRingIcon("Empty"), Is.False, "Status icon displayed for current option");
        }

        [Then(@"Category Automations displayed before projects categories")]
        public void SpecifiedCategoryDisplayedBeforeProjectsCategories()
        {
            var page = _driver.NowAt<FiltersElement>();

            var VisibleLabels = page.FilterCategoryLabels.Select(x => x.Text).ToList();

            var getFirstProjectItem = VisibleLabels.Select((Value, Index) => new { Value, Index })
               .FirstOrDefault(p => p.Value.StartsWith("Project"));

            try
            {
                string checkIfEmpty = getFirstProjectItem.Value;
            }
            catch (Exception)
            {
                getFirstProjectItem = new
                {
                    Value = "NOT FOUND",
                    Index = 2000,
                };
            }

            var getFirstAutomationItem = VisibleLabels.Select((Value, Index) => new { Value, Index })
                .Single(p => p.Value.StartsWith("Automation Actions"));

            Verify.That(getFirstAutomationItem.Index, Is.LessThan(getFirstProjectItem.Index), "Looks like projects placed before Automations");
        }

        [Then(@"the following Filters categories are presented in Filter panel:")]
        public void ThenTheFollowingFiltersCategoriesArePresentedInFilterPanel(Table table)
        {
            var page = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var VisibleLabels = page.FilterCategoryLabels.Select(x => x.Text).ToList();

            foreach (var item in expectedList)
            {
                Verify.That(VisibleLabels, Does.Contain(item), $"{item} value is missing");
            }
        }

        [Then(@"Filter Searchfield placeholder is '(.*)'")]
        public void ThenFilterSearchfieldPlaceholderIs(string expectedPlaceholderName)
        {
            var filtersElement = _driver.NowAt<FiltersElement>();
            var actualPlaceholderName = filtersElement.SearchTextBox.GetAttribute("placeholder");
            Verify.AreEqual(expectedPlaceholderName, actualPlaceholderName, "Incorrect Placeholder in the search field");
        }

        [When(@"User selects '(.*)' option in '(.*)' autocomplete of Associations panel")]
        public void WhenUserSelectsOptionInExpandedAutocomplete(string option, string placeholder)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetTextbox(placeholder).ClearSendKeys(option);

            var page = _driver.NowAt<FiltersElement>();
            page.SelectAssociation(placeholder, option);
        }

        [Then(@"User sees options in '(.*)' autocomplete of Associations panel")]
        public void ThenUserSeesOptionsInAutocompleteOnAssociaton(string placeholder, Table table)
        {
            var page = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetAssociationDropdownItemsByPlaceholder(placeholder).Select(x => x.Text).ToList();

            Verify.That(actualList, Is.EqualTo(expectedList), "Wrong items displayed");
        }

        [Then(@"Remove icon displayed in '(.*)' state for '(.*)' association")]
        public void ThenRemoveIconDisplayedInStateForAssociation(string state, string association)
        {
            var filtersElement = _driver.NowAt<FiltersElement>();

            string actualState =
                string.IsNullOrEmpty(filtersElement.RemoveIconForAssociation(association).GetAttribute("disabled"))
                    ? "true"
                    : "false";

            Verify.That(actualState, Is.EqualTo(state), "Wrong Remove icon state");
        }

        [When(@"User removes '(.*)' association in Association panel")]
        public void WhenUserRemovesAssociationInAssociationPanel(string option)
        {
            var page = _driver.NowAt<FiltersElement>();
            page.RemoveIconForAssociation(option).Click();
        }

        [Then(@"Check that filter '(.*)' with option '(.*)' is added")]
        public void ThenAppropriateFilterIsAdded(string expectedFilterName, string expectedFilterOption)
        {
            var filterPanel = _driver.NowAt<FiltersElement>();

            foreach (IWebElement filter in filterPanel.GetAddedFilters())
            {
                var actualFilterName = filter.FindElement(By.XPath(FiltersElement.FilterNameSelector)).Text;
                var actualFilterOption = filter.FindElement(By.XPath(FiltersElement.FilterOptionsSelector)).Text;
                if (actualFilterName.Equals(expectedFilterName))
                {
                    Verify.AreEqual(expectedFilterOption, actualFilterOption, $"Expected filter option wasn't found");
                    return;
                }
            }
            throw new Exception($" Filter '{expectedFilterName}' isn't exist on that page");
        }
    }
}