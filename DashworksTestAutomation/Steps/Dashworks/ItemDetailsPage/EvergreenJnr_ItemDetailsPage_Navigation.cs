using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
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

        [When(@"User navigates to the '(.*)' details page for '(.*)' item")]
        public void WhenUserNavigatesToTheDetailsPageForItem(string listName, string itemName)
        {
            listName = listName.ToLower();
            var id = string.Empty;

            switch (listName)
            {
                case "device":
                    id = DatabaseHelper.GetDeviceDetailsIdByName(itemName);
                    break;
                case "user":
                    id = DatabaseHelper.GetUserDetailsIdByName(itemName);
                    break;
                case "application":
                    id = DatabaseHelper.GetApplicationDetailsIdByName(itemName);
                    break;
                case "mailbox":
                    id = DatabaseHelper.GetMailboxDetailsIdByName(itemName);
                    break;
                default:
                    throw new Exception($"Unknown list type: {listName}");
            }

            _driver.NowAt<BaseHeaderElement>();
            var url = $"{UrlProvider.EvergreenUrl}#/{listName}/{id}/details/{listName}";
            
            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks on ""(.*)"" navigation link")]
        public void WhenUserClicksOnNavigationLink(string linkName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetNavigationLinkByName(linkName).Click());
        }

        [Then(@"Loading indicator appears in the same place when switching between main-menu")]
        public void LoadingIndicatorAppearsInTheSamePlaceWhenSwitchingBetweenMainMenu()
        {
            List<Point> loader = new List<Point>();

            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.WaitForDataLoading();

            loader = detailsPage.LoadingIndicatorCoordinates();

            Utils.Verify.That(loader.First(), Is.EqualTo(loader.Last()), "Wrong point loading position");
        }

        //TODO rename to something generic
        [When(@"User navigates to the ""(.*)"" sub-menu on the Details page")]
        public void WhenUserNavigatesToTheSub_MenuOnTheDetailsPage(string subMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            _driver.ExecuteAction(() => detailsPage.GetSubMenuByName(subMenuName).Click());
        }

        [Then(@"""(.*)"" tab-menu on the Admin page is expanded")]
        [Then(@"""(.*)"" tab-menu on the Details page is expanded")]
        public void ThenTab_MenuOnTheDetailsPageIsExpanded(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(detailsPage.GetExpandedTabByName(tabMenuName), $"{tabMenuName} tab-menu is not expanded!");
        }

        [Then(@"""(.*)"" tab-menu on the Details page is not expanded")]
        public void ThenTab_MenuOnTheDetailsPageIsNotExpanded(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Utils.Verify.IsFalse(detailsPage.GetExpandedTabByName(tabMenuName), $"{tabMenuName} tab-menu is expanded!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPage(string tabName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Utils.Verify.IsTrue(detailsPage.GetTabByName(tabName), $"{tabName} tab is not displayed!");
        }

        [Then(@"""(.*)"" tab is not displayed on left menu on the Details page")]
        public void ThenTabIsNotDisplayedOnLeftMenuOnTheDetailsPage(string tabName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Utils.Verify.IsFalse(detailsPage.GetTabByName(tabName), $"{tabName} tab is displayed!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page with ""(.*)"" count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageWithCountOfItems(string tabName, string countOfItems)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(detailsPage.GetDisplayStatusOfTabWithCountOfItemsByName(tabName, countOfItems), $"{tabName} tab is displayed incorrectly!");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page and contains count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageAndContainsCountOfItems(string tabName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Verify.IsTrue(detailsPage.GetCountOfItemsDisplayStatusByTabName(tabName), $"Tab {tabName} must contain the number of elements!");
        }

        [Then(@"'(.*)' tab is displayed on left menu on the Details page and contains '(.*)' count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageAndContainsCountOfItems(string tabName, int count)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            //Try to check content several times because it is updating not immediately
            if (count != detailsPage.GetCountOfItemsByTabName(tabName))
            {
                //JS update count every 3 seconds
                Thread.Sleep(3000);
            }
            Verify.AreEqual(count, detailsPage.GetCountOfItemsByTabName(tabName), $"Incorrect count for '{tabName}' tab");
        }

        [Then(@"""(.*)"" tab is displayed on left menu on the Details page and NOT contains count of items")]
        public void ThenTabIsDisplayedOnLeftMenuOnTheDetailsPageAndNotContainsCountOfItems(string tabName)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Verify.IsFalse(detailsPage.GetCountOfItemsDisplayStatusByTabName(tabName), $"Tab {tabName} must contain the number of elements!");
        }

        [Then(@"""(.*)"" sub-tab is displayed with disabled state on left menu on the Details page")]
        public void ThenSub_TabIsDisplayedWithDisabledStateOnLeftMenuOnTheDetailsPage(string tabName)
        {
            _driver.WaitForDataLoading();
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Utils.Verify.IsTrue(detailsPage.GetDisplayStatusForDisabledSubTabByName(tabName), $"{tabName} Tab must be disabled!");
        }

        [Then(@"""(.*)"" main-tab is displayed with disabled state on left menu on the Details page")]
        public void ThenMain_TabIsDisplayedWithDisabledStateOnLeftMenuOnTheDetailsPage(string tabName)
        {
            _driver.WaitForDataLoading();
            var detailsPage = _driver.NowAt<BaseNavigationElements>();
            Utils.Verify.IsTrue(detailsPage.GetDisplayStatusForDisabledMainTabByName(tabName), $"{tabName} Tab must be disabled!");
        }

        [Then(@"User sees following main-tabs on left menu on the Details page:")]
        public void ThenUserSeesFollowingMain_TabsOnLeftMenuOnTheDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = detailsPage.MainTabsOnDetailsPageList.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Tabs for the details page are incorrect");
        }

        //TODO should be moved to Navigation
        [Then(@"""(.*)"" main-menu on the Details page contains following sub-menu:")]
        public void ThenMain_MenuOnTheDetailsPageContainsFollowingSub_Menu(string tabMenuName, Table table)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();

            //opens main-menu 
            //_driver.ExecuteAction(() => detailsPage.GetLeftMenuByName(tabMenuName).Click());
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
                Verify.IsTrue(detailsPage.GetDisplayStatusSubTabByName(row["SubTabName"]), $"'{row["SubTabName"]}' tab is not displayed!");
        }

        [Then(@"""(.*)"" main-menu on the Details page contains following sub-menu with count of items:")]
        public void ThenMain_MenuOnTheDetailsPageContainsFollowingSub_MenuWithCountOfItems(string tabMenuName, Table table)
        {
            var detailsPage = _driver.NowAt<BaseNavigationElements>();

            _driver.ExecuteAction(() => detailsPage.GetLeftMenuByName(tabMenuName).Click());
            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["CountOfItems"]))
                    Verify.IsTrue(detailsPage.GetDisplayStatusOfTabWithCountOfItemsByName(row["SubTabName"], row["CountOfItems"]), "Some subcategory is not displayed correctly!");
                else
                    Verify.IsTrue(detailsPage.GetTabByName(row["SubTabName"]), "Subcategory is not displayed correctly!");
            }
        }
    }
}