﻿using System.Linq;
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

        public EvergreenJnr_ItemDetailsPage_Navigation (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Details page for ""(.*)"" item is displayed to the user")]
        public void ThenDetailsPageForItemIsDisplayedToTheUser(string pageName)
        {
            _driver.WaitForDataLoading();

            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.GroupIcon.Displayed());

            var page = _driver.NowAt<NavigationPage>();
            Assert.IsTrue(page.GetItemDetailsPageByName(pageName).Displayed(), $"{pageName} page is not loaded!");
        }

        [When(@"User navigates to the ""(.*)"" tab-menu on the Details page")]
        public void WhenUserNavigatesToTheTab_MenuOnTheDetailsPage(string tabMenuName)
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

        [Then(@"User sees following tabs on left menu on the Details page:")]
        public void ThenUserSeesFollowingTabsOnLeftMenuOnTheDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = detailsPage.MainTabsOnDetailsPageList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Tabs for the details page are incorrect");
        }

        [Then(@"""(.*)"" tab-menu on the Details page contains following sub-menu:")]
        public void ThenTab_MenuOnTheDetailsPageContainsFollowingSub_Menu(string tabMenuName, Table table)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();

            detailsPage.GetTabMenuByName(tabMenuName).Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = detailsPage.SubTabsOnDetailsPageList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Tabs for the details page are incorrect");
        }
    }
}
