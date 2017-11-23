using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_FiltersPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_FiltersPanel(RemoteWebDriver driver)
        {
            _driver = driver;
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

        [Then(@"""(.*)"" filter is not presented in the filters list")]
        public void ThenFilterIsNotPresentedInTheFiltersList(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsFalse(filterElement.CheckFilterAvailability(filterName),
                $"{filterName} is available in the search");
        }

        [When(@"User have created ""(.*)"" filter without column and following options:")]
        public void WhenUserHaveCreatedFilterWithoutColumnAndFollowingOptions(string filterType,
            Table table)
        {
            CreateFilterWithCheckboxes(filterType, false, table);
        }

        [When(@"User have created ""(.*)"" filter with column and following options:")]
        public void WhenUserHaveCreatedFilterWithColumnAndFollowingOptions(string filterType,
            Table table)
        {
            CreateFilterWithCheckboxes(filterType, true, table);
        }

        private void CreateFilterWithCheckboxes(string filterType, bool columnOption,
            Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new CheckBoxesFilter(_driver, filterType, columnOption, table);
            filter.Do();
        }

        [When(@"User have create ""(.*)"" Values filter with column and following options:")]
        public void WhenUserHaveCreateValuesFilterWithColumnAndFollowingOptions(string filterType, Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new ValueFilter(_driver, filterType, true, table);
            filter.Do();
        }

        [When(@"User have created ""(.*)"" filter with SelectedList list and following Association:")]
        public void WhenUserHaveCreatedFilterWithSelectedListListAndFollowingAssociation(string filterType, Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var filter = new ListFilter(_driver, table);
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

        [Then(@"FilterData is displayed for FilterName column")]
        public void ThenFilterDataIsDisplayedForFilterNameColumn(Table table)
        {
            var listpageMenu = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(listpageMenu.IsColumnPresent(row["FilterName"]),
                    $"Column '{row["FilterName"]}' is not exists in the table");
            }
        }

        [Then(@"table data is filtred correctly")]
        public void ThenTableDataIsFiltredCorrectly()
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

        [Then(@"""(.*)"" checkbox is displayed")]
        public void ThenCheckboxIsDisplayed(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsTrue(filterElement.AddCategoryColumnCheckbox.Displayed(),
                $"{filterName} tick box is not displayed");
            Logger.Write($"{filterName} tick box is displayed");
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
            foreach (string option in optionName.Split(','))
            {
                if (string.IsNullOrEmpty(option))
                    continue;
                try
                {
                    filterElement.OperatorDropdown.Click();
                }
                catch (Exception e)
                {
                }
                var actualOptionsList = filterElement.OperatorOptions.Select(value => value.Text).ToList();
                Assert.Contains(option.TrimStart(' ').TrimEnd(' '), actualOptionsList, $"{optionName} is not found in Filter Options");
                filterElement.OperatorOptions.First().Click();
            }
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

        [When(@"User is remove part of filter by URL")]
        public void WhenUserIsRemovePartOfFilterByURL()
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

        [Then(@"""(.*)"" is displayed in added filter info")]
        public void ThenIsDisplayedInAddedFilterInfo(string text)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
           Assert.AreEqual(text, string.Concat(filterElement.GetFiltersNames().First()+' ', filterElement.FilterOptions.First().Text+' ', filterElement.FilterValues.First().Text), "Text is incorrect");
        }
    }
}