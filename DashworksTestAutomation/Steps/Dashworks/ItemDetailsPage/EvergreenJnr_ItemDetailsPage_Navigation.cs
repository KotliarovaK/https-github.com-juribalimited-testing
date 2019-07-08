using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_Navigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_Navigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks on ""(.*)"" navigation link")]
        public void WhenUserClicksOnNavigationLink(string linkName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            detailsPage.GetNavigationLinkByName(linkName).Click();
        }

        [When(@"User navigates to the ""(.*)"" main-menu on the Details page")]
        public void WhenUserNavigatesToTheMain_MenuOnTheDetailsPage(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            detailsPage.GetTabMenuByName(tabMenuName).Click();
        }

        [When(@"User navigates to the ""(.*)"" sub-menu on the Details page")]
        public void WhenUserNavigatesToTheSub_MenuOnTheDetailsPage(string subMenuName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            detailsPage.GetSubMenuByName(subMenuName).Click();
        }

        [Then(@"""(.*)"" tab-menu on the Admin page is expanded")]
        [Then(@"""(.*)"" tab-menu on the Details page is expanded")]
        public void ThenTab_MenuOnTheDetailsPageIsExpanded(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(detailsPage.GetExpandedTabByName(tabMenuName), $"{tabMenuName} tab-menu is not expanded!");
        }

        [Then(@"""(.*)"" tab-menu on the Details page is not expanded")]
        public void ThenTab_MenuOnTheDetailsPageIsNotExpanded(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsFalse(detailsPage.GetExpandedTabByName(tabMenuName), $"{tabMenuName} tab-menu is expanded!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPage(string tabName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(detailsPage.GetTabByName(tabName), $"{tabName} tab is not displayed!");
        }

        [Then(@"""(.*)"" tab is not displayed on left menu on the Details page")]
        public void ThenTabIsNotDisplayedOnLeftMenuOnTheDetailsPage(string tabName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsFalse(detailsPage.GetTabByName(tabName), $"{tabName} tab is displayed!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page with ""(.*)"" count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageWithCountOfItems(string tabName, string countOfItems)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(detailsPage.GetDisplayStatusOfTabWithCountOfItemsByName(tabName, countOfItems), $"{tabName} tab is displayed incorrectly!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page and contains count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageAndContainsCountOfItems(string tabName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(detailsPage.GetCountOfItemsDisplayStatusByTabName(tabName), $"Tab {tabName} must contain the number of elements!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page and NOT contains count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageAndNotContainsCountOfItems(string tabName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsFalse(detailsPage.GetCountOfItemsDisplayStatusByTabName(tabName), $"Tab {tabName} must contain the number of elements!");
        }

        [Then(@"""(.*)"" sub-tab is displayed with disabled state on left menu on the Details page")]
        public void ThenSub_TabIsDisplayedWithDisabledStateOnLeftMenuOnTheDetailsPage (string tabName)
        {
            _driver.WaitForDataLoading();
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(detailsPage.GetDisplayStatusForDisabledSubTabByName(tabName), $"{tabName} Tab must be disabled!");
        }

        [Then(@"""(.*)"" main-tab is displayed with disabled state on left menu on the Details page")]
        public void ThenMain_TabIsDisplayedWithDisabledStateOnLeftMenuOnTheDetailsPage(string tabName)
        {
            _driver.WaitForDataLoading();
            var detailsPage = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(detailsPage.GetDisplayStatusForDisabledMainTabByName(tabName), $"{tabName} Tab must be disabled!");
        }

        [Then(@"User sees following main-tabs on left menu on the Details page:")]
        public void ThenUserSeesFollowingMain_TabsOnLeftMenuOnTheDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = detailsPage.MainTabsOnDetailsPageList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Tabs for the details page are incorrect");
        }

        [Then(@"""(.*)"" main-menu on the Details page contains following sub-menu:")]
        public void ThenMain_MenuOnTheDetailsPageContainsFollowingSub_Menu(string tabMenuName, Table table)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();

            //opens main-menu 
            detailsPage.GetTabMenuByName(tabMenuName).Click();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
                Assert.IsTrue(detailsPage.GetDisplayStatusSubTabByName(row["SubTabName"]), $"'{row["SubTabName"]}' tab is not displayed!");
        }

        [Then(@"""(.*)"" main-menu on the Details page contains following sub-menu with count of items:")]
        public void ThenMain_MenuOnTheDetailsPageContainsFollowingSub_MenuWithCountOfItems(string tabMenuName, Table table)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();

            detailsPage.GetTabMenuByName(tabMenuName).Click();
            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["CountOfItems"]))
                    Assert.IsTrue(detailsPage.GetDisplayStatusOfTabWithCountOfItemsByName(row["SubTabName"], row["CountOfItems"]), "Some subcategory is not displayed correctly!");
                else
                    Assert.IsTrue(detailsPage.GetTabByName(row["SubTabName"]), "Subcategory is not displayed correctly!");
            }
        }
    }
}
