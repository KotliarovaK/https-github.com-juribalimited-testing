using System;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
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

        [Then(@"User sees widget with the next name ""(.*)"" on Dashboards page")]
        public void WhenUserSeesWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.AllWidgetsTitles.Select(x=>x.Text).ToList(), Does.Contain(widgetName), "Widget name is missing");
        }

        [Then(@"Widget name ""(.*)"" has word break style on Dashboards page")]
        public void WhenUserSeesWordBreakAttributesForNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            try
            {
                var widget = page.AllWidgetsTitles.FirstOrDefault(x => x.Text.Equals(widgetName));
                Assert.That(widget.GetCssValue("word-break"), Is.EqualTo("break-word"), "Word break formatting is missing");
                Assert.That(widget.GetCssValue("word-wrap"), Is.EqualTo("break-word"), "Word break formatting is missing");
            }
            catch (NullReferenceException)
            {
               Assert.False(true, "Widget not found");
            }
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

        [When(@"User creates new Dashboard with ""(.*)"" name")]
        public void WhenUserCreatesNewDashboardWithName(string dashboardName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.DashboardNameTextBox.SendKeys(dashboardName);
            listElement.SaveButton.Click();
        }

        [When(@"User creates new Widget")]
        public void WhenUserCreatesNewWidget(Table table)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            foreach (var row in table.Rows)
            {
                createWidgetElement.WidgetType.Click();
                createWidgetElement.SelectObjectForWidgetCreation(row["WidgetType"]);

                if (string.IsNullOrEmpty(row["Title"])) createWidgetElement.Title.SendKeys(" ");

                if (!string.IsNullOrEmpty(row["Title"])) createWidgetElement.Title.SendKeys(row["Title"]);

                if (!string.IsNullOrEmpty(row["List"]))
                {
                    createWidgetElement.List.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["List"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["SplitBy"]))
                {
                    createWidgetElement.SplitBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["SplitBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["AggregateBy"]))
                {
                    createWidgetElement.AggregateBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["AggregateFunction"]))
                {
                    createWidgetElement.AggregateFunction.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateFunction"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["OrderBy"]))
                {
                    createWidgetElement.OrderBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["OrderBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["MaxValues"]))
                {
                    createWidgetElement.MaxValues.Clear();
                    createWidgetElement.MaxValues.SendKeys(row["MaxValues"]);
                }

                if (!string.IsNullOrEmpty(row["ShowLegend"]) && row["ShowLegend"].Equals("true"))
                {
                    createWidgetElement.ShowLegend.Click();
                }

                createWidgetElement.ConfirmCreateWidgetButton.Click();
            }
        }

        [When(@"User selects ""(.*)"" as Widget Type")]
        public void WhenUserSetsWidgetType(string widgetType)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.WidgetType.Click();
            createWidgetElement.SelectObjectForWidgetCreation(widgetType);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User enters ""(.*)"" as Widget Title")]
        public void WhenUserSetsWidgetTitle(string widgetTitle)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.Title.SendKeys(widgetTitle);
        }

        [When(@"User selects ""(.*)"" as Widget List")]
        public void WhenUserSetsWidgetList(string widgetList)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.List.Click();
            createWidgetElement.SelectObjectForWidgetCreation(widgetList);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget SplitBy")]
        public void WhenUserSetsWidgetSplitBy(string splitBy)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.SplitBy.Click();
            createWidgetElement.SelectObjectForWidgetCreation(splitBy);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget AggregateBy")]
        public void WhenUserSetsWidgetAggregateBy(string aggregateBy)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.AggregateBy.Click();
            createWidgetElement.SelectObjectForWidgetCreation(aggregateBy);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget Aggregate Function")]
        public void WhenUserSetsWidgetAggregateFunction(string aggregateFunc)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.AggregateFunction.Click();
            createWidgetElement.SelectObjectForWidgetCreation(aggregateFunc);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget OrderBy")]
        public void WhenUserSetsWidgetOrderBy(string orderBy)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.OrderBy.Click();
            createWidgetElement.SelectObjectForWidgetCreation(orderBy);
            _driver.WaitForDataLoadingOnProjects();
        }

        [Then(@"Widget title ""(.*)"" is displayed on Widget page")]
        public void ThenWidgetTitleDisplayedOnThePage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.AreEqual(text, page.Title.GetAttribute("innerHTML"), "Widget title is not the same");
        }

        [Then(@"Error message with ""(.*)"" text is displayed on Widget page")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<AddWidgetPage>(() => page.ErrorMessage);
            Assert.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }
    }
}