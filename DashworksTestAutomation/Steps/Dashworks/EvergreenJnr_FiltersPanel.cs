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
            _driver.WaitWhileControlIsDisplayed<FiltersElement>(() => filterElement.MinimizeGroupButton);
        }


        [Then(@"Filter options are displayed")]
        public void ThenFilterOptionsAreDisplayed()
        {
            var filterElement = _driver.NowAt<FiltersElement>();
            Assert.IsTrue(filterElement.AStarPackegesCheckbox.Displayed(), "A Star Packeges checkbox was not visible");
            Logger.Write("A Star Packeges checkbox is visible");
            Assert.IsTrue(filterElement.NoneCheckbox.Displayed(), "None checkbox was not visible");
            Logger.Write("None Checkbox panel is visible");
            Assert.IsTrue(filterElement.BStarPackegesCheckbox.Displayed(), "B Star Packeges checkbox was not visible");
            Logger.Write("B Star Packeges Panel panel is visible");
            Assert.IsTrue(filterElement.AddCategoryColumnCheckbox.Displayed(),
                "Add category column checkbox was not visible");
            Logger.Write("Add Category Column Checkbox is visible");
            Assert.IsTrue(filterElement.SaveButton.Displayed(), "Save button was not visible");
            Logger.Write("Sve button is visible");
            Assert.IsTrue(filterElement.CancelButton.Displayed(), "Cancel button was not visible");
            Logger.Write("Cancel button is visible");
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
            Assert.Contains(filterName, filterElement.GetFilterName());
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
                valuesList.AddRange(row.Values.ToList());
            }
            Assert.AreEqual(valuesList, filterElement.GetFilterColumData());
        }
    }
}