using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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

        [When(@"User have selected following options and clicks save button")]
        public void WhenUserHaveSelectedFollowingOptionsAndClicksSaveButton(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();

            foreach (var row in table.Rows)
            {
                filterElement.SelectOption(row["SelectedOptionName"]);
            }
            filterElement.SaveButton.Click();
            _driver.WaitWhileControlIsDisplayed<FiltersElement>(() => filterElement.SaveButton);
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
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(listpageMenu.IsColumnPresent(row["FilterName"]),
                    $"Column '{row["FilterName"]}' is not exists in the table");
            }
        }

        [Then(@"FilterData is displayed for apropriate column")]
        public void ThenFilterDataIsDisplayedForApropriateColumn(Table table)
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            var valuesList = new List<string>();
            foreach (var row in table.Rows)
            {
                valuesList.Add(row.Values.ToList().First());
            }
            Assert.AreEqual(valuesList, filterElement.GetFilterColumData());
        }

        [When(@"User have removed ""(.*)"" filter")]
        public void WhenUserHaveRemovedFilter(string filterName)
        {
            var filterElement = _driver.NowAt<FiltersElement>();

            filterElement.GetEditFilterButton(filterName).Click();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.RemoveFilterButton);
            filterElement.RemoveFilterButton.Click();
        }

        [When(@"User have reset all filters")]
        public void WhenUserHaveResetAllFilters()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            _driver.WaitWhileControlIsNotDisplayed<FiltersElement>(() => filterElement.ResetFiltersButton);
            filterElement.ResetFiltersButton.Click();
        }
    }
}