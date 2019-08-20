using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Plugins;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_TopBar : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_TopBar(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks by Project Switcher in the Top bar on Item details page")]
        public void WhenUserClicksByProjectSwitcherInTheTopBarOnItemDetailsPage()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();
            topBar.ProjectSwitcherDropdownTopBar.Click();
        }

        [Then(@"Project Switcher in the Top bar on Item details page is open")]
        public void ThenProjectSwitcherInTheTopBarOnItemDetailsPageIsOpen()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();
            Utils.Verify.IsTrue(topBar.GetProjectSwitcherDisplayedState(), "Project Switcher panel should be displayed for User!");
        }

        [Then(@"Project Switcher in the Top bar on Item details page is closed")]
        public void ThenProjectSwitcherInTheTopBarOnItemDetailsPageIsClosed()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();
            Utils.Verify.IsFalse(topBar.GetProjectSwitcherDisplayedState(), "Project Switcher panel should not be displayed for User!");
        }

        [When(@"User switches to the ""(.*)"" project in the Top bar on Item details page")]
        public void WhenUserSwitchesToTheProjectInTheTopBarOnItemDetailsPage(string projectName)
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();
            topBar.ProjectSwitcherDropdownTopBar.Click();

            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetOptionByName(projectName).Click();

            _driver.WaitFor(() => topBar.ProjectsOnSwitcherPanel.Count == 0);

            //TODO: An open question for Vitaly (about sleep) 8/19/19;
            Thread.Sleep(2000);
        }

        [Then(@"""(.*)"" project is selected in the Top bar on Item details page")]
        public void ThenProjectIsSelectedInTheTopBarOnItemDetailsPage(string projectName)
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();
            Utils.Verify.IsTrue(topBar.GetSelectedProjectOnTopBarByName(projectName).Displayed(), $"{projectName} project is not displayed in Top Bar");
        }

        [Then(@"projects on the Project Switcher panel are displayed in alphabetical order")]
        public void ThenProjectsOnTheProjectSwitcherPanelAreDisplayedInAlphabeticalOrder()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            topBar.ProjectSwitcherDropdownTopBar.Click();

            if (topBar.DefaultProjectStatusInProjectSwitcherDropDown.Displayed())
            {
                var list = topBar.ProjectsOnSwitcherPanel.Select(x => x.Text).ToList();
                Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Projects on the Project Switcher panel are not in alphabetical order!");
            }
            else
            {
                var list = topBar.ProjectsOnSwitcherPanel.Select(x => x.Text).Where(x => !x.Contains("Evergreen")).ToList();
                Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Projects on the Project Switcher panel are not in alphabetical order!");
            }

            var filterElement = _driver.NowAt<BaseGridPage>();
            filterElement.BodyContainer.Click();
        }

        [Then(@"following Compliance items are displayed in Top bar on the Item details page:")]
        public void ThenFollowingComplianceItemsAreDisplayedInTopBarOnTheItemDetailsPage(Table table)
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = topBar.GetComplianceItemsOnTopBar();
            Utils.Verify.AreEqual(expectedList, actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"following Compliance items with appropriate colors are displayed in Top bar on the Item details page:")]
        public void ThenFollowingComplianceItemsWithAppropriateColorsAreDisplayedInTopBarOnTheItemDetailsPage(Table table)
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            foreach (var row in table.Rows)
            {
                Utils.Verify.IsTrue(topBar.GetComplianceValueOnTheDetailsPageByComplianceName(row["ComplianceItems"], row["ColorName"]).Displayed(),
                    $"'{row["ComplianceItems"]}' does not match the '{row["ColorName"]}'!");
            }
        }

        [Then(@"No one Compliance items are displayed for the User in Top bar on the Item details page")]
        public void ThenNoOneComplianceItemsAreDisplayedForTheUserInTopBarOnTheItemDetailsPage()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            var actualList = topBar.GetComplianceItemsOnTopBar();
            Utils.Verify.IsEmpty(actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"Top bar on the Item details page is not displayed")]
        public void ThenTopBarOnTheItemDetailsPageIsNotDisplayed()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            Utils.Verify.IsFalse(topBar.TopBarOnItemDetailsPage.Displayed(), "Top bar should not be displayed!");
        }
    }
}