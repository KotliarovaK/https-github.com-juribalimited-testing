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
using DashworksTestAutomation.Pages.Evergreen.Base;
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

            OpenItemDetailsById(listName, id);
        }

        [When(@"User navigates to the '(.*)' details page for the item with '(.*)' ID")]
        public void WhenUserNavigatesToTheDetailsPageForItemWithId(string listName, string id)
        {
            listName = listName.ToLower();

            OpenItemDetailsById(listName, id);
        }

        private void OpenItemDetailsById(string listName, string id)
        {
            _driver.NowAt<BaseHeaderElement>();
            var url = $"{UrlProvider.EvergreenUrl}#/{listName}/{id}/details/{listName}";

            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
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
            List<string> actualList = new List<string>();
            //TODO temporary workaround
            try
            {
                actualList = detailsPage.GetParentMenuByName().Select(value => value.Text).ToList();
            }
            catch (StaleElementReferenceException e)
            {
                Logger.Write($"StaleElementReferenceException during retrieving of parent menu items: {e}");
                actualList = detailsPage.GetParentMenuByName().Select(value => value.Text).ToList();
            }
            Verify.AreEqual(expectedList, actualList, "Tabs for the details page are incorrect");
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
    }
}