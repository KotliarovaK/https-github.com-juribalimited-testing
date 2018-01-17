﻿using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_FiltersPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ColumnNameToUrlConvertor _convertor;

        public EvergreenJnr_FiltersPanel(RemoteWebDriver driver, ColumnNameToUrlConvertor convertor)
        {
            _driver = driver;
            _convertor = convertor;
        }

        [Then(@"Filters panel is displayed to the user")]
        public void ThenFiltersPanelIsDisplayedToTheUser()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsTrue(filterElement.FiltersPanel.Displayed(), "Actions panel was not displayed");
            Logger.Write("Actions Panel panel is visible");
        }

        [When(@"user select ""(.*)"" filter")]
        public void WhenUserSelectFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AddFilter(filterName);
        }

        [When(@"User enters ""(.*)"" text in Search field at Filters Panel")]
        public void WhenUserEntersTextInSearchFieldAtFiltersPanel(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.AddNewFilterButton.Click();
            filterElement.SearchTextbox.Clear();
            filterElement.SearchTextbox.SendKeys(searchedText);
        }

        [When(@"User enters ""(.*)"" text in Search field at selected Lookup Filter")]
        public void WhenUserEntersTextInSearchFieldAtSelectedLookupFilter(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.LookupFilterSearchTextbox);
            filterElement.LookupFilterSearchTextbox.Clear();
            filterElement.LookupFilterSearchTextbox.SendKeys(searchedText);
        }

        [When(@"User enters ""(.*)"" text in Search field at selected Filter")]
        public void WhenUserEntersTextInSearchFieldAtSelectedFilter(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            if (!String.IsNullOrWhiteSpace(searchedText))
            {
                _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.FilterSearchTextbox);
                filterElement.FilterSearchTextbox.Clear();
                filterElement.FilterSearchTextbox.SendKeys(searchedText);
            }
        }

        [When(@"User enters ""(.*)"" in Association search field")]
        public void WhenUserEntersInAssociationSearchField(string searchedText)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.LookupFilterSearchTextbox);
            filterElement.AssociationSearchTextbox.Clear();
            filterElement.AssociationSearchTextbox.SendKeys(searchedText);
        }

        [Then(@"search values in Association section working by specific search criteria")]
        public void ThenSearchValuesInAssociationSectionWorkingBySpecificSearchCriteria()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var searchCriteria = filterElement.LookupFilterSearchTextbox.GetAttribute("value");
            List<string> associationList = filterElement.GetAssociationsList().Select(element => element.Text).ToList();
            foreach (var association in associationList)
            {
                StringAssert.Contains(searchCriteria.ToLower(), association.ToLower());
            }
        }

        [When(@"User clears search textbox in Filters panel")]
        public void WhenUserClearsSearchTextboxInFiltersPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.SearchTextboxResetButton.Click();
        }

        [Then(@"""(.*)"" filter is not presented in the filters list")]
        public void ThenFilterIsNotPresentedInTheFiltersList(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsFalse(filterElement.CheckFilterAvailability(filterName),
                $"{filterName} is available in the search");
        }

        [When(@"User select ""(.*)"" Operator value")]
        public void WhenUserSelectOperatorValue(string operatorValue)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.SelectOperator(operatorValue);
        }

        [When(@"User have create ""(.*)"" Values filter with column and following options:")]
        public void WhenUserHaveCreateValuesFilterWithColumnAndFollowingOptions(string operatorValue, Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new ValueFilter(_driver, operatorValue, true, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and following value:")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndFollowingValue(string filterName, string operatorValue,
            Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
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
            var filterElement = _driver.NowAt<FiltersElement>();
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

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with SelectedList list and following Association:")]
        public void WhenUserAddFilterWhereTypeIsWithSelectedListListAndFollowingAssociation(string filterName,
            string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new ListFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User have created ""(.*)"" filter with SelectedList list and following Association:")]
        public void WhenUserHaveCreatedFilterWithSelectedListListAndFollowingAssociation(string operatorValue, Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new ListFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Lookup Value and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingLookupValueAndAssociation(string filterName, string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupValueAssociationFilter(_driver, operatorValue, table);
            filter.Do();
        }

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with following Value and Association:")]
        public void WhenUserAddFilterWhereTypeIsWithFollowingValueAndAssociation(string filterName, string operatorValue, Table table)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new ValueAssociationFilter(_driver, operatorValue, table);
            filter.Do();
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

        [When(@"User add ""(.*)"" filter where type is ""(.*)"" with added column and ""(.*)"" Lookup option")]
        public void WhenUserAddFilterWhereTypeIsWithAddedColumnAndLookupOption(string filterName, string operatorValue,
            string filterValue)
        {
            var filtersNames = _driver.NowAt<FiltersElement>();
            filtersNames.AddFilter(filterName);
            var filter = new LookupFilter(_driver, operatorValue, true, filterValue);
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
            Assert.Contains(filterName, filterElement.GetFiltersNames());
        }

        [Then(@"table data is filtered correctly")]
        public void ThenTableDataIsFilteredCorrectly()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            var filtersNames = filterElement.GetFiltersNames();
            var allColumns = filtersNames.Select(filtersName =>
                new KeyValuePair<string, List<string>>(filtersName, basePage.GetColumnContent(filtersName))).ToList();
            for (int i = 0; i < allColumns.First().Value.Count; i++)
            {
                bool result = false;

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
                    if (result)
                    {
                        break;
                    }
                }
                Assert.IsTrue(result, "Table data is filtered incorrectly");
            }
        }

        [When(@"User have removed ""(.*)"" filter")]
        public void WhenUserHaveRemovedFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();

            filterElement.GetEditFilterButton(filterName).Click();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.RemoveFilterButton);
            filterElement.RemoveFilterButton.Click();
        }

        [When(@"User click Edit button for ""(.*)"" filter")]
        public void WhenUserClickEditButtonForFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();

            filterElement.GetEditFilterButton(filterName).Click();
        }

        [Then(@"""(.*)"" checkbox is checked")]
        public void ThenCheckboxIsChecked(string addColumn)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsTrue(filterElement.AddCategoryColumnCheckbox.Selected, $"{addColumn} Checkbox is not selected");
        }

        [Then(@"""(.*)"" checkbox is unchecked")]
        public void ThenCheckboxIsUnchecked(string addColumn)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsFalse(filterElement.AddCategoryColumnCheckbox.Selected, $"{addColumn} Checkbox is selected");
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

        private void AssertAddColumnCheckboxEnabledState(bool expectedCondition, string addColumn)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.AreEqual(expectedCondition, Convert.ToBoolean(filterElement.AddCategoryColumnCheckbox.GetAttribute("disabled")),
                $"{addColumn} Checkbox is selected");
        }

        [Then(@"""(.*)"" filter is removed from filters")]
        public void ThenFilterIsRemovedFromFilters(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsFalse(filterElement.CheckThatFilterIsRemoved(filterName));
        }

        [When(@"User have reset all filters")]
        public void WhenUserHaveResetAllFilters()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.ResetFiltersButton);
            _driver.MouseHover(filterElement.ResetFiltersButton);
            filterElement.ResetFiltersButton.Click();
        }

        [Then(@"""(.*)"" checkbox is not displayed")]
        public void ThenCheckboxIsNotDisplayed(string checkbox)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsFalse(filterElement.AddCategoryColumnCheckbox.Displayed(),
                $"{checkbox} checkbox is not displayed");
            Logger.Write($"{checkbox} checkbox is displayed");
        }

        [Then(@"checkboxes are displayed to the User:")]
        public void ThenCheckboxesAreDisplayedToTheUser(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.AddCategoryColumnName.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Filter settings values are different");
        }

        [Then(@"""(.*)"" option is available at first place")]
        public void ThenOptionIsAvailableAtFirstPlace(string optionName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.AreEqual(optionName, filterElement.GetSelectBoxes().First().Text);
        }

        [Then(@"Values is displayed in added filter info")]
        public void ThenValuesIsDisplayedInAddedFilterInfo(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterValues.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Filter settings values are different");
        }

        [Then(@"correct true and false options are displayed in filter settings")]
        public void ThenCorrectTrueAndFalseOptionsAreDisplayedInFilterSettings()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.AreEqual($"{UrlProvider.Url}evergreen/img/tick.png",
                filterElement.GetBooleanCheckboxImg("TRUE").GetAttribute("src"), "Incorrect image for True value");
            Assert.AreEqual($"{UrlProvider.Url}evergreen/img/cross.png",
                filterElement.GetBooleanCheckboxImg("FALSE").GetAttribute("src"), "Incorrect image for False value");
            Assert.AreEqual($"{UrlProvider.Url}evergreen/img/unknown.png",
                filterElement.GetBooleanCheckboxImg("UNKNOWN").GetAttribute("src"),
                "Incorrect image for Unknown value");
        }

        [Then(@"""(.*)"" option is available for this filter")]
        public void ThenOptionIsAvailableForThisFilter(string optionName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            filterElement.OperatorDropdown.Click();
            var availableOptions = filterElement.OperatorOptions.Select(value => value.Text).ToList();
            Assert.AreEqual(optionName.Split(',').Select(x => x.TrimStart(' ').TrimEnd(' ')).ToList(),
                availableOptions);
            filterElement.OperatorOptions.First().SendKeys(OpenQA.Selenium.Keys.Escape);
        }

        [When(@"User is remove filter by URL")]
        public void WhenUserIsRemoveFilterByURL()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\$filter=(.*)\&";
            var originalPart = Regex.Match(currentUrl, pattern).Value;
            var urlToNavigate = currentUrl.Replace(originalPart, string.Empty);
            _driver.NagigateToURL(urlToNavigate);

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
            {
                throw new Exception("500 error was returned");
            }
        }

        [When(@"User is remove part of filter URL")]
        public void WhenUserIsRemovePartOfFilterURL()
        {
            var currentUrl = _driver.Url;
            const string pattern = @"\$filter=(.*)\&";
            var originalPart = Regex.Match(currentUrl, pattern).Groups[1].Value;
            var urlToNavigate = currentUrl.Replace(originalPart, string.Empty);
            _driver.NagigateToURL(urlToNavigate);

            var page = _driver.NowAt<EvergreenDashboardsPage>();
            if (page.StatusCodeLabel.Displayed())
            {
                throw new Exception("500 error was returned");
            }
        }

        [Then(@"Options is displayed in added filter info")]
        public void ThenOptionsIsDisplayedInAddedFilterInfo(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterOptions.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Filter settings options are different");
        }

        [Then(@"Associations is displayed in the filter")]
        public void ThenAssociationsIsDisplayedInTheFilter(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            foreach (var row in table.Rows)
            {
                filterElement.GetAssociationsList().Select(value => value.Text).ToList().Contains(row.Values.First());
            }
        }

        [Then(@"Associations panel is displayed in the filter")]
        public void ThenAssociationsPanelIsDisplayedInTheFilter()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsTrue(filterElement.AssociationSearchTextbox.Displayed(), "Associations panel is not displayed");
        }

        [Then(@"""(.*)"" is displayed in added filter info")]
        public void ThenIsDisplayedInAddedFilterInfo(string text)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            List<string> filterLabels = filterElement.AddedFilterLabels.Select(element => element.Text).ToList();
            Assert.Contains(text, filterLabels, $"Filter with {text} not found in the list");
        }

        [Then(@"""(.*)"" filter with ""(.*)"" values is added to URL")]
        public void ThenFilterWithValuesIsAddedToURL(string filterName, string values)
        {
            var currentUrl = _driver.Url;
            const string pattern = @"filter=(.*)";
            var urlPartToCheck = Regex.Match(currentUrl, pattern).Groups[1].Value;
            var valuesList = values.Split(',');
            foreach (var value in valuesList)
            {
                StringAssert.Contains(value.TrimStart(' ').TrimEnd(' ').ToLower(), urlPartToCheck.ToLower());
            }
            StringAssert.Contains(_convertor.Convert(filterName).ToLower(), urlPartToCheck.ToLower());
        }

        [Then(@"Minimize buttons are displayed for all category in Filters panel")]
        public void ThenMinimizeButtonsAreDisplayedForAllCategoryInFiltersPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var groupCount = filterElement.GroupTitle.Count;
            Assert.AreEqual(groupCount, filterElement.MinimizeGroupButton.Count, "Minimize buttons are not displayed");
        }

        [Then(@"Maximize buttons are displayed for all category in Filters panel")]
        public void ThenMaximizeButtonsAreDisplayedForAllCategoryInFiltersPanel()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var groupCount = filterElement.GroupTitle.Count;
            Assert.AreEqual(groupCount, filterElement.MaximizeGroupButton.Count, "Maximize buttons are not displayed");
        }

        [Then(@"message '(.*)' is displayed to the user")]
        public void ThenMessageIsDisplayedToTheUser(string message)
        {
            var page = _driver.NowAt<FiltersElement>();
            Assert.AreEqual(message, page.NoResultsFoundMessage.Text);
        }

        [When(@"User change selected checkboxes:")]
        public void WhenUserChangeSelectedCheckboxes(Table table)
        {
            var filter = new ChangeCheckboxesFilter(_driver, table);
            filter.Do();
        }

        [Then(@"reset button in Search field at selected Filter is displayed")]
        public void ThenResetButtonInSearchFieldAtSelectedFilterIsDisplayed()
        {
            var page = _driver.NowAt<FiltersElement>();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => page.SearchTextboxResetButton);
            Assert.IsTrue(page.SearchTextboxResetButton.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }
    }
}