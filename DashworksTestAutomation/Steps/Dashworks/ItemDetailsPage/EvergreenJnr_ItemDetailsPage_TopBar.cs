using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_TopBar : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_TopBar (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User switches to the ""(.*)"" project in the Top bar on Item details page")]
        public void WhenUserSwitchesToTheProjectInTheTopBarOnItemDetailsPage(string projectName)
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();
            topBar.ProjectSwitcherDropdownTopBar.Click();

            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetOptionByName(projectName).Click();
        }

        [Then(@"following Compliance items are displayed in Top bar on the Item details page:")]
        public void ThenFollowingComplianceItemsAreDisplayedInTopBarOnTheItemDetailsPage(Table table)
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = topBar.GetComplianceItemsOnTopBar();
            Assert.AreEqual(expectedList, actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"No one Compliance items are displayed for the User in Top bar on the Item details page")]
        public void ThenNoOneComplianceItemsAreDisplayedForTheUserInTopBarOnTheItemDetailsPage()
        {
            var topBar = _driver.NowAt<ItemDetails_TopBarPage>();

            var actualList = topBar.GetComplianceItemsOnTopBar();
            Assert.IsEmpty(actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }
    }
}