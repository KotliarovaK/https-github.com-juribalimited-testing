using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_AggridHeaderCounter : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_AggridHeaderCounter (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Group By button on the Details page and selects ""(.*)"" value")]
        public void WhenUserClicksGroupByButtonOnTheDetailsPageAndSelectsValue(string value)
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            page.GroupByButton.Click();
            _driver.MouseHover(page.GetValueInGroupByFilterOnDetailsPage(value));
            page.GetValueInGroupByFilterOnDetailsPage(value).Click();
            var body = _driver.NowAt<BaseGridPage>();
            body.BodyContainer.Click();
        }

        [When(@"User clicks Reset Filters button on the Item Details page")]
        public void WhenUserClicksResetFiltersButtonOnTheDetailsPage()
        {
            var body = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            body.BodyContainer.Click();
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            _driver.WaitForElementToBeDisplayed(page.ResetFiltersButton);
            page.ResetFiltersButton.Click();
        }

        [Then(@"Reset Filters button on the Item Details page is disable")]
        public void ThenResetFiltersButtonOnTheItemDetailsPageIsDisable()
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            Assert.IsTrue(page.GetDisplayStateOfFilterButton(), "Reset Filters button on the Item Details page is active");
        }

        [Then(@"Reset Filters button on the Item Details page is available")]
        public void ThenResetFiltersButtonOnTheItemDetailsPageIsAvailable()
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            Assert.IsFalse(page.GetDisplayStateOfFilterButton(), "Reset Filters button on the Item Details page is inactive");
        }

        [Then(@"'Reset Filters' button is displayed on the Item Details page")]
        public void ThenResetFiltersButtonIsDisplayedOnTheItemDetailsPage()
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            Assert.IsTrue(page.ResetFiltersButton.Displayed(), "'Reset Filters' button is not displayed on the Item Details page!");
        }

        [Then(@"'Refresh' button is displayed on the Item Details page")]
        public void ThenRefreshButtonIsDisplayedOnTheItemDetailsPage()
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            Assert.IsTrue(page.RefreshButton.Displayed(), "'Refresh' button is not displayed on the Item Details page!");
        }

        [Then(@"'Export' button is displayed on the Item Details page")]
        public void ThenExportButtonIsDisplayedOnTheItemDetailsPage()
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            Assert.IsTrue(page.ExportButton.Displayed(), "'Export' button is not displayed on the Item Details page!");
        }

        [Then(@"'Group By' button is displayed on the Item Details page")]
        public void ThenGroupByButtonIsDisplayedOnTheItemDetailsPage()
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            Assert.IsTrue(page.GroupByButton.Displayed(), "'Group By' button is not displayed on the Item Details page!");
        }
    }
}
