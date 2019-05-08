using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Dashboards;
using NUnit.Framework;
using OpenQA.Selenium;
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

        [When(@"User clicks Show Dashboards panel icon on Dashboards page")]
        public void WhenUserClicksShowDashboardsPanelOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.DashboardsPanelIcon.Click();
        }

        [When(@"User clicks Edit mode trigger on Dashboards page")]
        public void WhenUserClicksEditModeTriggerOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            page.EditModeOnOffTrigger.Click();
        }

        [When(@"User clicks Ellipsis menu for ""(.*)"" Widget on Dashboards page")]
        public void WhenUserClicksEllipsisMenuForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var ellipsisMenu = page.GetEllipsisMenuForWidget(widgetName);

            if (ellipsisMenu != null)
            {
                page.GetEllipsisMenuForWidget(widgetName).Click();
                _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.EllipsisMenu);
            }
            else
            {
                throw new Exception($"Ellipsis menu is not available");
            }
        }

        [When(@"User clicks Dashboards Details icon on Dashboards page")]
        public void WhenUserClicksDashboardsDetailsIconOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.DashboardsDetailsIcon.Click();
            _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.DashboardsContextMenu);
        }

        [Then(@"User sees Ellipsis icon enabled for ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetEllipsisMenuForWidget(widgetName).Displayed(), Is.True);
        }

        [Then(@"User sees Dashboards context menu on Dashboards page")]
        public void ThenUserSeesDashboardsContextMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.DashboardsContextMenu.Displayed(), Is.True);
        }

        [Then(@"Dashboards context menu is hidden on Dashboards page")]
        public void ThenDashboardsContextMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.DashboardsContextMenu.Displayed(), Is.False);
        }

        [Then(@"User sees Dashboards sub menu on Dashboards page")]
        public void ThenUserSeesDashboardsSubMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.DashboardsSubmenu.Displayed(), Is.True);
        }

        [Then(@"Dashboards sub menu is hidden on Dashboards page")]
        public void ThenDashboardsSubMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.DashboardsSubmenu.Displayed(), Is.False);
        }

        [Then(@"User sees Ellipsis icon disabled for ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetEllipsisMenuForWidget(widgetName), Is.Null);
        }

        [When(@"User clicks Ellipsis menu for Section having ""(.*)"" Widget on Dashboards page")]
        public void WhenUserClicksEllipsisMenuForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Click();
            _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.EllipsisMenu);
        }

        [Then(@"User sees Ellipsis icon enabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(), Is.True);
        }

        [Then(@"User sees Ellipsis icon disabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(), Is.False);
        }

        [Then(@"User sees Collapse/Expand icon enabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesCollapseExpandIconEnabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
                Is.True);
        }

        [Then(@"User sees Collapse/Expand icon disabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesCollapseExpandIconDisabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
                Is.False);
        }

        [When(@"User collapses all sections on Dashboards page")]
        public void WhenUserCollapsesAllSectionsOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            foreach (var arrow in page.AllCollapseExpandSectionsArrows)
            {
                if (arrow.GetAttribute("class").Contains("arrow_up"))
                {
                    arrow.Click();
                }
            }
        }

        [When(@"User expands all sections on Dashboards page")]
        public void WhenUserExpandsAllSectionsOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            foreach (var arrow in page.AllCollapseExpandSectionsArrows)
            {
                if (arrow.GetAttribute("class").Contains("arrow_down"))
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

        [Then(@"""(.*)"" Ellipsis menu item is disabled on Dashboards page")]
        public void ThenEllipsisMenuItemIsDisabledOnDashboardsPage(string itemName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.GetDisabledEllipsisItemByName(itemName).Displayed(), "Ellipsis menu item is enabled");
            var body = _driver.NowAt<BaseGridPage>();
            body.BodyContainer.Click();
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

        [When(@"User remembers number of Widgets with Legend on Dashboards page")]
        public void WhenUserRemembersNumberOfWidgetsWithLegendOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.Storage.SessionStorage.SetItem("numberOfWidgetsWithLegend",
                page.NumberOfWidgetLegends.Count.ToString());
        }

        [Then(@"User sees number of Widgets with Legend increased by ""(.*)"" on Dashboards page")]
        public void WhenUserSeesNumberOfWidgetsWithLegendIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            int expectedCount = Int32.Parse(page.Storage.SessionStorage.GetItem("numberOfWidgetsWithLegend")) +
                                increasedBy;
            Assert.That(page.NumberOfWidgetLegends.Count, Is.EqualTo(expectedCount),
                "Number of Widgets with Legend is different");
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

        [Then(@"User sees following Widgets on Dashboards page:")]
        public void WhenUserSeesFollowingWidgetsOnDashboardsPage(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> expectedWidgetsNames =
                table.Rows.Select(x => x.Values).Select(c => c.FirstOrDefault()).ToList();

            Assert.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Is.EqualTo(expectedWidgetsNames),
                "Names of Widgets are different");
        }

        [Then(@"User sees following Widgets in one Section on Dashboards page:")]
        public void WhenUserSeesFollowingWidgetsInOneSectionOnDashboardsPage(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> expectedWidgetsNames =
                table.Rows.Select(x => x.Values).Select(c => c.FirstOrDefault()).ToList();

            Assert.That(page.GetWidgetsNamesInSections(), Does.Contain(expectedWidgetsNames),
                "Names of Widgets are different");
        }

        [When(@"User clicks ""(.*)"" button for ""(.*)"" Section on Dashboards page")]
        public void WhenUserClicksButtonForSectionOnDashboardsPage(string buttonLabel, int section)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetButtonsByName(buttonLabel).ElementAt(section - 1).Click();
        }

        [Then(@"User sees widget with the next name ""(.*)"" on Dashboards page")]
        public void ThenUserSeesWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Does.Contain(widgetName),
                "Widget name is missing");
        }

        [Then(@"User sees Edit mode trigger is in the On position on Dashboards page")]
        public void ThenUserSeesEditModeTriggerIsInTheOnPositionOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.That(page.GetEditModeState(), Is.True, "Trigger is in the OFF position");
        }

        [Then(@"User sees Edit mode trigger is in the Off position on Dashboards page")]
        public void ThenUserSeesEditModeTriggerIsInTheOffPositionOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.That(page.GetEditModeState(), Is.False, "Trigger is in the ON position");
        }

        [Then(@"User sees Edit mode trigger has blue style on Dashboards page")]
        public void ThenUserSeesEditModeTriggerHasBlueStyleOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.That(page.GetEditModeSlideBarColor(), Is.EqualTo("rgba(49, 122, 193, 0.54)"),
                "Edit mode slider is not blue");
            Assert.That(page.GetEditModeSlideToggleColor(), Is.EqualTo("rgba(49, 122, 193, 1)"),
                "Edit mode trigger is not blue");
        }

        [Then(@"User sees Edit mode trigger has grey style on Dashboards page")]
        public void ThenUserSeesEditModeTriggerHasGreyStyleOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.That(page.GetEditModeSlideBarColor(), Is.EqualTo("rgba(0, 0, 0, 0.38)"),
                "Edit mode slider is not grey");
            Assert.That(page.GetEditModeSlideToggleColor(), Is.EqualTo("rgba(250, 250, 250, 1)"),
                "Edit mode trigger is not grey");
        }

        [Then(@"Widget name ""(.*)"" has word break style on Dashboards page")]
        public void WhenUserSeesWordBreakAttributesForNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            try
            {
                var widget = page.AllWidgetsTitles.FirstOrDefault(x => x.Text.Equals(widgetName));
                Assert.That(widget.GetCssValue("word-break"), Is.EqualTo("break-word"),
                    "Word break formatting is missing");
                Assert.That(widget.GetCssValue("word-wrap"), Is.EqualTo("break-word"),
                    "Word break formatting is missing");
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

            page.GetEllipsisIconsForSectionsHavingWidget(widgetName).LastOrDefault().Click();
            page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals("Delete")).FirstOrDefault().Click();
            page.DeleteButtonInAlert.Click();
        }

        [When(@"User clicks Cancel button in Delete Widget warning on Dashboards page")]
        public void WhenUserClicksCancelButtonInDeleteWidgetWarningOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.CancelButtonInAlert);
            page.CancelButtonInAlert.Click();
        }

        [When(@"User creates new Dashboard with ""(.*)"" name")]
        public void WhenUserCreatesNewDashboardWithName(string dashboardName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.DashboardNameTextBox.SendKeys(dashboardName);
            listElement.SaveButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User updates Widget with following info:")]
        [When(@"User creates new Widget")]
        public void WhenUserCreatesNewWidget(Table table)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            foreach (var row in table.Rows)
            {
                createWidgetElement.WidgetType.Click();
                createWidgetElement.SelectObjectForWidgetCreation(row["WidgetType"]);

                if (string.IsNullOrEmpty(row["Title"])) createWidgetElement.Title.SendKeys(" ");

                if (createWidgetElement.Title.Displayed() & !string.IsNullOrEmpty(row["Title"]))

                {
                    createWidgetElement.Title.Clear();
                    createWidgetElement.Title.SendKeys(row["Title"]);
                }

                if (createWidgetElement.List.Displayed() && !string.IsNullOrEmpty(row["List"]))
                {
                    createWidgetElement.List.Click();
                    createWidgetElement.SelectListForWidgetCreation(row["List"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.SplitBy.Displayed() && !string.IsNullOrEmpty(row["SplitBy"]))
                {
                    _driver.WaitWhileControlIsNotDisplayed<AddWidgetPage>(() => createWidgetElement.SplitBy);
                    createWidgetElement.SplitBy.Click();
                    _driver.WaitWhileControlIsNotDisplayed<AddWidgetPage>(() => createWidgetElement.DropdownMenu);
                    createWidgetElement.SelectObjectForWidgetCreation(row["SplitBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.AggregateFunction.Displayed() && !string.IsNullOrEmpty(row["AggregateFunction"]))
                {
                    createWidgetElement.AggregateFunction.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateFunction"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.AggregateBy.Displayed() && row.ContainsKey("AggregateBy") && !string.IsNullOrEmpty(row["AggregateBy"]))
                {
                    createWidgetElement.AggregateBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.OrderBy.Displayed() && !string.IsNullOrEmpty(row["OrderBy"]))
                {
                    createWidgetElement.OrderBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["OrderBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.MaxValues.Displayed() && !string.IsNullOrEmpty(row["MaxValues"]))
                {
                    createWidgetElement.MaxValues.Clear();
                    createWidgetElement.MaxValues.SendKeys(row["MaxValues"]);
                }

                if (createWidgetElement.TableOrientation.Displayed())
                {
                    createWidgetElement.TableOrientation.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["TableOrientation"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.MaxRows.Displayed())
                {
                    createWidgetElement.MaxRows.Clear();
                    createWidgetElement.MaxRows.SendKeys(row["MaxRows"]);
                }

                if (createWidgetElement.MaxColumns.Displayed())
                {
                    createWidgetElement.MaxColumns.Clear();
                    createWidgetElement.MaxColumns.SendKeys(row["MaxColumns"]);
                }

                if (createWidgetElement.ShowLegend.Displayed() && !string.IsNullOrEmpty(row["ShowLegend"]))
                {
                    createWidgetElement.ShowLegend.Click();
                }

                createWidgetElement.CreateUpdateWidgetButton.Click();
                _driver.WaitForDataLoading();
            }
        }

        [When(@"User adds new Widget")]
        public void WhenUserAddsNewWidget(Table table)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            foreach (var row in table.Rows)
            {
                createWidgetElement.WidgetType.Click();
                createWidgetElement.SelectObjectForWidgetCreation(row["WidgetType"]);

                if (string.IsNullOrEmpty(row["Title"])) createWidgetElement.Title.SendKeys(" ");

                if (!string.IsNullOrEmpty(row["Title"]))
                {
                    createWidgetElement.Title.Clear();
                    createWidgetElement.Title.SendKeys(row["Title"]);
                }

                if (!string.IsNullOrEmpty(row["List"]))
                {
                    createWidgetElement.List.Click();
                    createWidgetElement.SelectListForWidgetCreation(row["List"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (row.ContainsKey("Type") && !string.IsNullOrEmpty(row["Type"]))
                {
                    createWidgetElement.Type.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["Type"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["SplitBy"]))
                {
                    createWidgetElement.SplitBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["SplitBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["AggregateFunction"]))
                {
                    createWidgetElement.AggregateFunction.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateFunction"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["AggregateBy"]))
                {
                    createWidgetElement.AggregateBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateBy"]);
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

                if (!string.IsNullOrEmpty(row["TableOrientation"]))
                {
                    createWidgetElement.TableOrientation.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["TableOrientation"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["ShowLegend"]) && row["ShowLegend"].Equals("true"))
                {
                    createWidgetElement.ShowLegend.Click();
                }
            }
        }

        [When(@"User selects ""(.*)"" in the ""(.*)"" Widget dropdown")]
        public void WhenUserSelectsInTheWidgetDropdown(string objectName, string dropdownName)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            _driver.ClickByJavascript(createWidgetElement.GetDropdownForWidgetByName(dropdownName));
            createWidgetElement.SelectObjectForWidgetCreation(objectName);
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
            createWidgetElement.SelectListForWidgetCreation(widgetList);
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

        [When(@"User clicks on the Colour Scheme dropdown")]
        public void WhenUserClicksOnTheColourSchemeDropdown()
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            createWidgetElement.ColorScheme.Click();
        }

        [When(@"User selects ""(.*)"" in the Colour Scheme")]
        public void WhenUserSelectsInTheColourScheme(string colorTitle)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            createWidgetElement.ColorScheme.Click();
            createWidgetElement.GetColorFromColorScheme(colorTitle).Click();
        }

        [Then(@"Colour Scheme dropdown is displayed to the user")]
        public void ThenColourSchemeDropdownIsDisplayedToTheUser()
        {
            var dropdownContainer = _driver.FindElements(By.XPath(AddWidgetPage.ColorSchemeDropdownContainer));
            foreach (var element in dropdownContainer)
            {
                var innerColour = element.FindElement(By.XPath(AddWidgetPage.ColorSchemeDropdownContent));
                Assert.IsTrue(_driver.IsElementExists(innerColour), "Colour item is not found");
            }
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
        }

        [Then(@"Colour Scheme dropdown is not displayed to the user")]
        public void ThenColourSchemeDropdownIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.IsFalse(page.ColorScheme.Displayed(), "Colour Scheme dropdown is displayed to the user");
        }

        [Then(@"Text Only is displayed for Card widget")]
        public void ThenTextOnlyIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.TextOnlyCardWidget.Displayed(), "Text Only is not displayed for Card widget");
        }

        [Then(@"Icon and Text is displayed for Card widget")]
        public void ThenIconAndTextIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.IconAndTextCardWidget.Displayed(), "Icon and Text is not displayed for Card widget");
        }

        [Then(@"Icon Only is displayed for Card widget")]
        public void ThenIconOnlyIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.IconOnlyCardWidget.Displayed(), "Icon Only is not displayed for Card widget");
        }

        [Then(@"User sees ""(.*)"" text in warning message on Dashboards page")]
        public void ThenUserSeesTextInWarningMessageOnDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.AreEqual(text, page.TextInDeleteAlert.Text);
        }

        [Then(@"User sees ""(.*)"" text in warning message on Dashboards submenu pane")]
        public void ThenUserSeesTextInWarningMessageOnSubmenuDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.AreEqual(text, page.SubmenuAlertMessage.Text);
        }

        [Then(@"Widget Preview is displayed to the user")]
        public void ThenWidgetPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.WidgetPreview.Displayed(), "Widget Preview is not displayed");
        }
        
        [Then(@"Card widget displayed inside preview pane")]
        public void ThenCardWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<EvergreenDashboardsPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;
            int prevX = preview.WidgetPreview.Location.X;
            int prevY = preview.WidgetPreview.Location.Y;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetCardWidgetPreview().Size.Width;
            int widgetX = widget.GetCardWidgetPreview().Location.X;
            int widgetY = widget.GetCardWidgetPreview().Location.Y;

            Assert.That(prevX < widgetX && prevY < widgetY, Is.True, "Widget XY coordinate displayed outside preview box");
            Assert.That(prevWidth > widgetWidth, Is.True, "Widget width displayed outside preview box");
        }

        [Then(@"Table widget displayed inside preview pane correctly")]
        public void ThenTableWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<EvergreenDashboardsPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetTableWidgetPreview().Size.Width;

            Assert.That(widgetWidth > prevWidth * 0.85 && widgetWidth < prevWidth, Is.True, "Widget preview less than 85 percent preview box");
        }

        [Then(@"content in the Widget is displayed in following order:")]
        public void ThenContentInTheWidgetIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var contentList = page.TableWidgetContent.Select(x => x.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(contentList, expectedList, "content in the Widget is displayed in the incorrect order");
        }

        [Then(@"""(.*)"" Widget is displayed to the user")]
        public void ThenWidgetIsDisplayedToTheUser(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.GetWidgetByName(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"link is not displayed for the ""(.*)"" value in the Widget")]
        public void ThenLinkIsNotDisplayedForTheValueInTheWidget(string content)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.GetTableWidgetContentWithoutLink(content).Displayed(), $"link is displayed for the {content} value");
            Assert.AreEqual("rgba(0, 0, 0, 0.87)", page.GetTableWidgetContentWithoutLink(content).GetCssValue("color"));
        }

        [Then(@"following content is displayed in the ""(.*)"" column")]
        public void ThenFollowingContentIsDisplayedInTheColumn(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var originalList = page.GetListContentByColumnName(columnName).Select(column => column.Text).ToList();
            var tableContent = table.Rows.SelectMany(row => row.Values);
            Assert.AreEqual(originalList, tableContent, $"Incorrect content is displayed in the {columnName}");
        }

        [Then(@"Column ""(.*)"" with no data displayed")]
        public void ThenFollowingColumnDisplayedWithoutNoData(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var originalList = page.GetListContentByColumnName(columnName).Select(column => column.Text).ToList();

            foreach (var item in originalList)
            {
                Assert.That(item, Is.EqualTo(""), $"Incorrect content is displayed in the {columnName}");
            }
        }

        [Then(@"following content is displayed in the ""(.*)"" column for Widget")]
        public void ThenFollowingContentIsDisplayedInTheColumnForWidget(string columnName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var originalList = page.GetWidgwtRowContentByColumnName(columnName);
            var tableContent = table.Rows.SelectMany(row => row.Values).First();
            foreach (var content in originalList)
            {
                Assert.AreEqual(originalList, tableContent);
            }
        }

        [Then(@"Card ""(.*)"" Widget is displayed to the user")]
        public void ThenCardWidgetIsDisplayedToTheUser(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.GetCardWidgetByName(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"""(.*)"" color is displayed for widget")]
        public void ThenColorIsDisplayedForWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var getColor = page.ColorWidgetItem.GetAttribute("style").Split(';')
                .First().Split(':').Last().TrimStart(' ').TrimEnd(' ');
            Assert.AreEqual(ColorWidgetConvertor.Convert(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"""(.*)"" color is displayed for Card Widget")]
        public void ThenColorIsDisplayedForCardWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var getColor = page.ColorWidgetItem.GetCssValue("background-color");
            Assert.AreEqual(ColorWidgetConvertor.ConvertComplianceColorWidget(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"""(.*)"" count is displayed for ""(.*)"" in the table Widget")]
        public void ThenCountIsDisplayedForInTheTableWidget(string boolean, string count)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.GetCountForTableWidget(count, boolean).Displayed(), $"{count} is not display for {boolean}");
        }

        [When(@"User clicks ""(.*)"" value for ""(.*)"" column")]
        public void WhenUserClicksValueFromColumn(string value, string column)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetCountForTableWidget(column,value).Click();
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

        [Then(@"Permission panel is displayed to the user")]
        public void ThenPermissionPanelIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.PermissionPanel.Displayed(), "Actions panel was not displayed");
        }

        [When(@"User changes sharing type from ""(.*)"" to ""(.*)""")]
        public void WhenUserSelectsSharingType(string from, string to)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.ChangePermissionSharingFieldFromTo(from,to);
        }

        [When(@"User adds user to list of shared person")]
        public void WhenUserAddsNewPersonToSharingList(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitWhileControlIsNotDisplayed<EvergreenDashboardsPage>(() => page.PermissionAddUserButton);
            page.PermissionAddUserButton.Click();
            
            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["User"]))
                {
                    page.PermissionUserField.Click();
                    page.PermissionUserField.Clear();
                    page.PermissionUserField.SendKeys(row["User"]);
                    page.SelectOptionFromList(row["User"]);
                }

                if (!string.IsNullOrEmpty(row["Permission"]))
                {
                    page.PermissionTypeField.Click();
                    page.SelectOptionFromList(row["Permission"]);
                }

                page.PermissionAddUserButton.Click();
            }
        }

        [Then(@"User ""(.*)"" was added to shared list with ""(.*)"" permission")]
        public void ThenUserWasAddedToSharedList(string username, string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.PermissionNameOfAddedUser.Text, Is.EqualTo(username), "Username is not one that expected");
            Assert.That(page.PermissionAccessTypeOfAddedUser.Text, Is.EqualTo(permission), "Permission is not one that expected");
        }

        [Then(@"There is no user in shared list")]
        public void ThenNoUserFoundInSharedList()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitWhileControlIsDisplayed<EvergreenDashboardsPage>(()=>page.PermissionNameOfAddedUser);
            Assert.That(page.PermissionNameOfAddedUser.Displayed(), Is.False, "Username found in shared list");
        }
        
        [When(@"User clicks Settings button for ""(.*)"" shared user")]
        public void WhenUserClickSettingsMenuForSharedUser(string user)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetSettingsMenuOfSharedUser(user).Click();
        }

        [When(@"User selects ""(.*)"" option from Settings")]
        public void WhenUserClicksOptionFromSettingsMenuForSharedUser(string option)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetSettingsOption(option).Click();
        }

        [When(@"User clicks data in card ""(.*)"" widget")]
        public void WhenUserClicksDataInCardWidget(string widgetTitle)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetCardWidgetContent(widgetTitle).Click();
        }

        [When(@"User clicks first Dashboard in dashboards list")]
        public void WhenUserClickFirstDashboardInDashboardsList()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetFirstDashboardFromList().Click();
        }

        [Then(@"Unsaved Changes alert not displayed to the user")]
        public void ThenNoUnsavedChangesAlertDisplayedOnEditWidgetPage()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitWhileControlIsDisplayed<AddWidgetPage>(() => page.UnsavedChangesAlert);
            Assert.IsFalse(_driver.IsElementDisplayed(page.UnsavedChangesAlert));
        }

        [Then(@"User sees ""(.*)"" text in alert on Edit Widget page")]
        public void ThenUserSeesTextInAlertOnEditWidgetPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitWhileControlIsNotDisplayed<AddWidgetPage>(() => page.UnsavedChangesAlert);
            Assert.AreEqual(text, page.GetUnsavedChangesAlertText().Text);
        }

        [When(@"User clicks ""(.*)"" button in Unsaved Changes alert")]
        public void WhenUserClickButtonInUnsavedChangesAlert(string buttonTitle)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.UnsavedChangesAlertButton(buttonTitle).Click();
        }

        
        [Then(@"User sees following options for Order By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForOrderBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.OrderBy.Click();

            Assert.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                page.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"Tooltip is displayed for the point of Line widget")]
        public void ThenTooltipIsDisplayedForThePoint(Table items)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            foreach (var row in items.Rows)
            {
                //action has to be performed twice, I don't know why
                _driver.MouseHover(page.GetPointOfLineWidgetByName(row["WidgetName"], row["NumberOfPoint"]));
                _driver.MouseHover(page.GetPointOfLineWidgetByName(row["WidgetName"], row["NumberOfPoint"]));

                Assert.That(page.GetFocusedPointHover(row["WidgetName"]), Is.EqualTo(row["Tooltip"]));
            }
        }

        [When(@"User clicks point of Line widget")]
        public void WhenUserClicksPointInLineWidget(Table items)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            foreach (var row in items.Rows)
            {
                page.GetPointOfLineWidgetByName(row["WidgetName"], row["NumberOfPoint"]).Click();
            }
        }

        [Then(@"Line chart displayed in ""(.*)"" widget")]
        public void LineChartDisplayedInWidget(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.IsLineWidgetPointsAreDisplayed(widgetName), Is.True, "Points are not displayed");
        }

        [When(@"User selects ""(.*)"" checkbox on the Create Widget page")]
        public void WhenUserSelectsCheckboxOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.GetDashboardCheckboxByName(checkboxName).Click();
        }

        [When(@"User clicks ""(.*)""  button on the Dashboards page")]
        public void WhenUserClicksButtonOnTheDashboardsPage(string buttonName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetTopBarActionButton(buttonName).Click();
        }

        [Then(@"Print Preview is displayed to the User")]
        public void ThenPrintPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            Assert.IsTrue(page.PrintPreviewSettingsPopUp.Displayed(), "Print Preview is not Displayed");
            Assert.IsTrue(page.DashWorksPrintLogo.Displayed());
            Assert.IsTrue(page.PrintPreviewWidgets.Displayed);
        }

        [When(@"User selects ""(.*)"" option in the ""(.*)"" dropdown for Print Preview Settings")]
        public void WhenUserSelectsOptionInTheDropdownForPrintPreviewSettings(string option, string dropdown)
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            _driver.ClickByJavascript(page.GetPrintPreviewDropdownByName(dropdown));
            page.SelectPrintPreviewSettings(option);
        }

        [Then(@"Print Preview is displayed in A4 format view")]
        public void ThenPrintPreviewIsDisplayedInA4FormatView()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            _driver.WaitForDataLoading();
            //Wait for style changing
            Thread.Sleep(1000);
            Assert.IsTrue(page.A4PrintPreviewView.Displayed, "Print Preview is not displayed in A4 format view");
        }

        [Then(@"Print Preview is displayed in Letter format view")]
        public void ThenPrintPreviewIsDisplayedInLetterFormatView()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Assert.IsTrue(page.LetterPrintPreviewView.Displayed, "Print Preview is not displayed in Letter format view");
        }

        [Then(@"Print Preview is displayed in Portrait orientation")]
        public void ThenPrintPreviewIsDisplayedInPortraitOrientation()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Assert.IsTrue(page.PortraitPrintPreviewOrientation.Displayed, "Print Preview is not displayed in Portrait orientation");
        }

        [Then(@"Print Preview is displayed in Landscape orientation")]
        public void ThenPrintPreviewIsDisplayedInLandscapeOrientation()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Assert.IsTrue(page.LandscapePrintPreviewOrientation.Displayed, "Print Preview is not displayed in Landscape orientation");
        }

        [When(@"User clicks Cancel button on the Print Preview Settings pop-up")]
        public void WhenUserClicksCancelButtonOnThePrintPreviewSettingsPop_Up()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            page.CancelButton.Click();
        }

        [Then(@"Data Labels are displayed on the Dashboards page")]
        public void ThenDataLabelsAreDisplayedOnTheDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.DataLabels.Displayed(), "Data Labels are not displayed");
        }

        [Then(@"""(.*)"" data label is displayed on the Dashboards page")]
        public void ThenDataLabelIsDisplayedOnTheDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Assert.That(page.DataLabels.Text, Is.EqualTo(text), $"{text} data label is not displayed");
        }

        [Then(@"Card Widget is blank")]
        public void ThenCardWidgetIsBlank()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsEmpty(page.CardWidgetValue.Text);
        }

        [Then(@"""(.*)"" checkbox is checked on the Create Widget page")]
        public void ThenCheckboxIsCheckedOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetDashboardCheckboxByName(checkboxName).GetAttribute("class").Contains("checked"));
        }

        [Then(@"""(.*)"" checkbox is not displayed on the Create Widget page")]
        public void ThenCheckboxIsNotDisplayedOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.IsFalse(page.GetCheckboxByName(checkboxName), $"{checkboxName} checkbox is displayed");
        }

        [Then(@"Move to Section pop up is displayed to the User")]
        public void ThenMoveToSectionPopUpIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.IsTrue(page.MoveToSectionPopUp.Displayed(), "Move to Section pop up is not displayed");
        }

        [Then(@"Move to Section pop up is not displayed to the User")]
        public void ThenMoveToSectionPopUpIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.IsFalse(page.MoveToSectionPopUp.Displayed(), "Move to Section pop up is displayed");
        }

        [When(@"User selects ""(.*)"" section on the Move to Section pop up")]
        public void WhenUserSelectsSectionOnTheMoveToSectionPopUp(string sectionName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.SelectSectionToMove(sectionName);
        }

        [When(@"User clicks ""(.*)"" button on the Move to Section Pop up")]
        public void WhenUserClicksButtonOnTheMoveToSectionPopUp(string buttonName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.ClickMoveToSectionPopUpButton(buttonName);
        }

        [Then(@"Widget Preview shows ""(.*)"" as First Cell value")]
        public void ThenWidgetPreviewShowsAsFirstCellValue(string option)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.That(page.GetPreviewFirstCellValue().Text, Is.EqualTo(option), "Widget Preview shown different value");
        }

        [Then(@"User sees ""(.*)"" warning text below Lists field")]
        public void ThenUserSeesWarningTextBelowListsField(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.AreEqual(text, page.WarningTextUnderField.Text);
        }

        #region Dashboards details

        [When(@"User select ""(.*)"" sharing option on the Dashboards page")]
        public void WhenUserSelectSharingOptionOnTheDashboardsPage(string option)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            _driver.SelectCustomSelectbox(page.SharingDropdown, option);
        }

        [Then(@"Permission ""(.*)"" displayed in Dashboard Details")]
        public void ThenDashboardShowsPermissionToTheUser(string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.SharingDropdownPermissionValue.Text, Is.EqualTo(permission), $"Permission {permission} was not the same in Dashboard Details");
        }

        [Then(@"Review Widget List Permissions is displayed to the User")]
        public void ThenReviewWidgetListPermissionsIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsTrue(page.ReviewWidgetListPermissionsPopUp.Displayed(), "Review Widget List Permissions is not displayed");
        }

        [Then(@"Review Widget List Permissions is not displayed to the User")]
        public void ThenReviewWidgetListPermissionsIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.IsFalse(page.ReviewWidgetListPermissionsPopUp.Displayed(), "Review Widget List Permissions is displayed");
        }

        [Then(@"List ""(.*)"" displayed in Review Widget List Permissions")]
        public void ThenReviewWidgetListPermissionsShowsListNameToTheUser(string list)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.ReviewPermissionsListValue.Text, Is.EqualTo(list), $"List name {list} was not found in Review Permissions popup");
        }

        [Then(@"Widget ""(.*)"" displayed in Review Widget List Permissions")]
        public void ThenReviewWidgetListPermissionsShowsWidgetNameToTheUser(string widget)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.ReviewPermissionsWidgetValue.Text, Is.EqualTo(widget), $"Widget name {widget} was not found in Review Permissions popup");
        }

        [Then(@"Current user displayed in Review Widget List Permissions")]
        public void ThenReviewWidgetListPermissionsShowsCurrentUserNameToTheUser()
        {
            var header = _driver.NowAt<HeaderElement>();
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.ReviewPermissionsOwnerValue.Text, 
                Is.EqualTo(header.UserNameDropdown.Text), $"Owner name was not found in Review Permissions popup");
        }
        
        [Then(@"Current Permission ""(.*)"" displayed in Review Widget List Permissions")]
        public void ThenReviewWidgetListPermissionsShowsCurrentPermissionToTheUser(string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.ReviewPermissionsCurrentPermissionValue.Text, Is.EqualTo(permission), $"Current permission {permission} was not found in Review Permissions popup");
        }

        [Then(@"New Permission ""(.*)"" displayed in Review Widget List Permissions")]
        public void ThenReviewWidgetListPermissionsShowsNewPermissionToTheUser(string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Assert.That(page.ReviewPermissionsNewPermissionsValue.Text, Is.EqualTo(permission), $"New permission {permission} was not found in Review Permissions popup");
        }

        [Then(@"User can see next options in New Permission field of Review Widget List Permissions")]
        public void ThenUserSeesNexPermissionOptionsInWidgetListPermissions(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.NewPermissionsDropdown.Click();

            List<string> options = page.ReviewPermissionsNewPermissionsDropdownOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Assert.That(options.FindAll(x => x.Equals(row["Options"])).Count == 1);
            }
            Assert.That(options.Count, Is.EqualTo(table.Rows.Count));

            //hide menu
            page.SelectDoNotChangeReviewPermission();
        }

        [When(@"User selects ""(.*)"" permission on the Review Widget List Permissions Pop-up")]
        public void WhenUserSelectsPermissionOnTheReviewWidgetListPermissionsPop_Up(string option)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            _driver.SelectCustomSelectbox(page.NewPermissionsDropdown, option);
            _driver.WaitForDataLoading();
        }

        [Then(@"Button ""(.*)"" has enabled property ""(.*)"" in Review Widget List Permissions")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(string buttonCapture, string buttonState)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Assert.That(page.GetButtonStateOfReviewWidgetPermissionsPopup(buttonCapture), 
                Is.EqualTo(buttonState.ToUpper()), $"Button {buttonCapture} states is different");
        }


        [Then(@"Button ""(.*)"" has ""(.*)"" tooltip in Review Widget List Permissions")]
        public void ThenTooltipIsDisplayedWithTextForCreateProjectButton(string buttonCapture, string tooltip)
        {
            var button = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(button.ReviewPermissionsPopupsButton(buttonCapture));
            var toolTipText = _driver.GetTooltipText();
            Assert.That(tooltip, Is.EqualTo(toolTipText), "Tooltip is different");
        }

        [When(@"User clicks the ""(.*)"" button in Review Widget List Permissions")]
        public void WhenUserClicksTheActionButtonInPermissionsPopupsButton(string buttonName)
        {
            var action = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            action.ReviewPermissionsPopupsButton(buttonName).Click();
        }

        #endregion
    }
}