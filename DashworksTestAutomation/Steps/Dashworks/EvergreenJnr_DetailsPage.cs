using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_DetailsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_DetailsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to the ""(.*)"" tab")]
        public void WhenUserNavigatesToTheTab(string tabName)
        {
            var tabs = _driver.NowAt<BaseDetailsTabsMenu>();

            tabs.NavigateToTabByName(tabName);
        }

        [Then(@"User closes ""(.*)"" section on the Details Page")]
        public void ThenUserClosesSectionOnTheDetailsPage(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.NavigateToSectionByName(sectionName);
        }

        [When(@"User open ""(.*)"" section")]
        public void WhenUserOpenSection(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.NavigateToSectionByName(sectionName);
        }

        [Then(@"Item content is displayed to the User")]
        public void ThenItemContentIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.ItemDetailsContainer.Displayed(), "Item content is not displayed");
        }

        [Then(@"expanded section is displayed to the User")]
        public void ThenExpandedSectionIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.SectionContainer.Displayed(), "Section is not displayed");
        }

        [Then(@"""(.*)"" column is not displayed to the user")]
        public void ThenColumnIsNotDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsFalse(columnHeader.ColumnIsDisplayed(columnName),
                   $"{columnName} category stil displayed in Column Panel");
        }

        [When(@"User have opened Column Settings for ""(.*)"" column in the Details Page table")]
        public void WhenUserHaveOpenedColumnSettingsForColumnInTheDetailsPageTable(string columnName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.OpenColumnSettingsByName(columnName);
        }

        [When(@"User click Column button on the Column Settings panel")]
        public void WhenUserClickColumnButtonOnTheColumnSettingsPanel()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.WaitWhileControlIsNotDisplayed<ApplicationsDetailsTabsMenu>(() => menu.ColumnButton);
            menu.ColumnButton.Click();
        }

        [When(@"User select ""(.*)"" checkbox on the Column Settings panel")]
        public void WhenUserSelectCheckboxOnTheColumnSettingsPanel(string checkboxName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.GetCheckboxByName(checkboxName);
        }

        [Then(@"Checkboxes are checked on the Column Settings panel for ""(.*)"" Column Settings panel:")]
        public void ThenCheckboxesAreCheckedOnTheColumnSettingsPanelForColumnSettingsPanel(string columnName, Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            page.OpenColumnSettingsByName(columnName);
            Assert.AreEqual(expectedList, page.GetCheckedElementsText(), "Checkbox is not selected");
        }

        [Then(@"Checkboxes are checked on the Column Settings panel :")]
        public void ThenCheckboxesAreCheckedOnTheColumnSettingsPanel(Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            //var actualList = page.ColumnCheckboxName.Select(value => value.Text);
            //Assert.AreEqual(expectedList, actualList, "Selected Checkbox are different");
            Assert.AreEqual(expectedList, page.GetCheckedElementsText(), "Checkbox is not selected");
        }

        [Then(@"ColumnName is added to the list in the Details Page table")]
        public void ThenColumnNameIsAddedToTheListInTheDetailsPageTable(Table table)

        {
            CheckColumnDisplayedState(table, true);
        }

        [Then(@"ColumnName is displayed in following order on the Details page:")]
        public void ThenColumnNameIsDisplayedInFollowingOrderOnTheDetailsPage(Table table)
        {
            {
                var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();

                List<string> columnNames = page.GetAllColumnHeadersOnTheDetailsPage().Select(column => column.Text).ToList();
                var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
                Assert.AreEqual(expectedList, columnNames, "Columns order is incorrect");
            }
        }

        private void CheckColumnDisplayedState(Table table, bool displayedState)
        {
            var listpageMenu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            foreach (var row in table.Rows)
            {
                _driver.WaitForDataLoading();
                Assert.AreEqual(displayedState, listpageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' displayed state should be {displayedState}");
            }
        }

        [Then(@"Content is present in the newly added column in the Details Page table")]
        public void ThenContentIsPresentInTheNewlyAddedColumnInTheDetailsPageTable(Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContent(row["ColumnName"]);


                //Check that at least 1 cells has some content
                Assert.IsTrue(content.Select(string.IsNullOrEmpty).Count() > 0, "Newly added column is empty");
            }
        }

        [Then(@"Content is present in the column of the Details Page table")]
        public void ThenContentIsPresentInTheColumnOfTheDetailsPageTable(Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContent(row["ColumnName"]);


                //Check that at least 1 cell has some content
                Assert.IsTrue(content.Select(string.IsNullOrEmpty).Count() > 0, "Column is empty");
            }
        }

        [Then(@"Fields with empty information are displayed")]
        public void ThenFieldsWithEmptyInformationAreDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.ExpandAllSections();
            detailsPage.CheckThatAllContentIsNotEmpty();
        }

        [Then(@"Unknown text is displayed for empty fields for ""(.*)"" section")]
        public void ThenUnknownTextIsDisplayedForEmptyFieldsForSection(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.ExpandAllSections();
            var table = detailsPage.GetFieldsWithContent(sectionName);
            foreach (KeyValuePair<string, string> pair in table)
            {
                if (pair.Key.Equals("Address 2") || pair.Key.Equals("Address 3") || pair.Key.Equals("Address 4"))
                    continue;

                Assert.IsTrue(!string.IsNullOrEmpty(pair.Value),
                    $"'Unknown' text is not displayed for {pair.Key} field ");
            }
        }

        [Then(@"Group Icon for Group Details page is displayed")]
        public void ThenGroupIconForPageIsDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.GroupIcon.Displayed());
        }

        [Then(@"""(.*)"" text is displayed for ""(.*)"" section")]
        public void ThenTextIsDisplayedForSection(string textMessage, string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.CloseAllSections();
            detailsPage.NavigateToSectionByName(sectionName);
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.NoMailboxOwnerFoundMessage);
            Assert.AreEqual(textMessage, detailsPage.NoMailboxOwnerFoundMessage.Text,
                $"{textMessage} is not displayed");
        }

        [Then(@"string filter is displayed for ""(.*)"" column on the Details Page")]
        public void ThenStringFilterIsDisplayedForColumnOnTheDetailsPage(string columnName)
        {
            var detailsPage = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsFalse(Convert.ToBoolean(detailsPage.GetFilterByColumnName(columnName).GetAttribute("readonly")));
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab")]
        public void ThenFieldDisplayStateIsOnDetailsTab(string fieldName, bool state)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.AreEqual(state, detailsPage.IsFieldPresent(fieldName), $"Incorrect display state for {fieldName}");
        }
    }
}