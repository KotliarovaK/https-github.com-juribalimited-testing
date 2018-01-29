using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
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

        [When(@"User navigates to the ""(.*)"" section")]
        public void WhenUserNavigatesToTheSection(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.NavigateToSectionByName(sectionName);
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
            _driver.WaitWhileControlIsNotDisplayed<ApplicationsDetailsTabsMenu>((System.Linq.Expressions.Expression<System.Func<OpenQA.Selenium.IWebElement>>)(() => menu.ColumnButton));
            menu.ColumnButton.Click();
        }

        [When(@"User select ""(.*)"" checkbox on the Column Settings panel")]
        public void WhenUserSelectCheckboxOnTheColumnSettingsPanel(string checkboxName)
        { 
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.OpenColumnSettingsByName("Application");
            page.GetCheckboxByName(checkboxName);
        }

        [Then(@"""(.*)"" column is added to the list in the Details Page table")]
        public void ThenColumnIsAddedToTheListInTheDetailsPageTable(Table table)
        {
            CheckColumnDisplayedState(table, true);
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

        [Then(@"Group Icon for ""(.*)"" page is displayed")]
        public void ThenGroupIconForPageIsDisplayed(string pageName)
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
            Assert.AreEqual(textMessage, detailsPage.NoMailboxOwnerFoundMessage.Text);
        }

        [Then(@"""(.*)"" field is displayed on Details tab")]
        public void ThenFieldIsDisplayedOnDetailsTab(string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.IsFieldPresent(fieldName), $"{fieldName} is not displayed");
        }

        [Then(@"""(.*)"" field is not displayed on Details tab")]
        public void ThenFieldIsNotDisplayedOnDetailsTab(string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsFalse(detailsPage.IsFieldPresent(fieldName), $"{fieldName} is displayed");
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab")]
        public void ThenFieldDisplayStateIsOnDetailsTab(string fieldName, bool state)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.AreEqual(state, detailsPage.IsFieldPresent(fieldName), $"Incorrect display state for {fieldName}");
        }
    }
}