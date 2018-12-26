﻿using System;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_DashboardsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_DashboardsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks ""(.*)"" section from ""(.*)"" circle chart on Dashboards page")]
        public void WhenUserClicksSectionFromChartOnDashboardsPage(string sectionName, string chartName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.ClickSectionFromCircleChart(chartName, sectionName);
        }

        [When(@"User clicks Edit mode trigger on Dashboards page")]
        public void WhenUserClicksEditModeTriggerOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.EditModeOnOffTrigger.Click();
        }

        [When(@"User clicks Ellipsis menu for ""(.*)"" Widget on Dashboards page")]
        public void WhenUserClicksEllipsisMenuForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisMenuForWidget(widgetName).Click();
            _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.EllipsisMenu);
        }

        [When(@"User clicks Ellipsis menu for Section having ""(.*)"" Widget on Dashboards page")]
        public void WhenUserClicksEllipsisMenuForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisMenusForSectionsHavingWidget(widgetName).FirstOrDefault().Click();
            _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.EllipsisMenu);
        }

        [When(@"User collapses all sections on Dashboards page")]
        public void WhenUserCollapsesAllSectionsOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            foreach (var arrow in page.CollapseExpandSectionArrow)
            {
                if (arrow.GetAttribute("class").Contains("arrow_up"))
                {
                    arrow.Click();
                }
            }
        }

        [Then(@"User sees following Ellipsis menu items on Dashboards page:")]
        public void WhenUserSeesFollowingEllipsisMenuItemsOnDashboardsPage(Table items)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            for (var i = 0; i < items.RowCount; i++)
                Assert.That(page.EllipsisMenuItems[i].Text, Is.EqualTo(items.Rows[i].Values.FirstOrDefault()),
                    "Items are not the same");
        }

        [When(@"User clicks ""(.*)"" item from Ellipsis menu on Dashboards page")]
        public void WhenUserClicksitemFromEllipsisMenuOnDashboardsPage(string itemName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            try
            {
                page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals(itemName)).FirstOrDefault().Click();
            }
            catch (Exception e)
            {
                throw new Exception($"'{itemName}' menu item is not valid ", e);
            }
        }

        [When(@"User remembers number of Sections and Widgets on Dashboards page")]
        public void WhenUserRemembersNumberOfSectionsAndWidgetsOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.Storage.SessionStorage.SetItem("numberOfSections", page.AllSections.Count.ToString());
            page.Storage.SessionStorage.SetItem("numberOfWidgets", page.AllWidgetsTitles.Count.ToString());
        }

        [Then(@"User sees number of Sections increased by ""(.*)"" on Dashboards page")]
        public void WhenUserSeesNumberOfSectionsIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            int expectedCount = Int32.Parse(page.Storage.SessionStorage.GetItem("numberOfSections")) + increasedBy;
            Assert.That(page.AllSections.Count, Is.EqualTo(expectedCount), "Number of Sections is different");
        }

        [Then(@"User sees number of Widgets increased by ""(.*)"" on Dashboards page")]
        public void WhenUserSeesNumberOfWidgetsIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            int expectedCount = Int32.Parse(page.Storage.SessionStorage.GetItem("numberOfWidgets")) + increasedBy;
            Assert.That(page.AllWidgetsTitles.Count, Is.EqualTo(expectedCount), "Number of Widgets is different");
        }

        [Then(@"User sees Widget with ""(.*)"" name on Dashboards page")]
        public void WhenUserSeesWidgetWithNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Assert.That(page.IsWidgetExists(widgetName), Is.True, $"Widget with name {widgetName} doesn't exist");
        }

        [When(@"User deletes ""(.*)"" Widget on Dashboards page")]
        public void WhenUserDeletesWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisMenuForWidget(widgetName).Click();
            page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals("Delete")).FirstOrDefault().Click();
            page.DeleteButtonInAlert.Click();
        }

        [When(@"User deletes duplicated Section having ""(.*)"" Widget on Dashboards page")]
        public void WhenUserDeletesDuplicatedSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisMenusForSectionsHavingWidget(widgetName).LastOrDefault().Click();
            page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals("Delete")).FirstOrDefault().Click();
            page.DeleteButtonInAlert.Click();
        }
    }
}