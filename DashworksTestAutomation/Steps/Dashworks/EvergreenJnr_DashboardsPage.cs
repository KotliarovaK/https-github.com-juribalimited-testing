using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
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
    }
   
}