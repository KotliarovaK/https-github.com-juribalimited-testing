﻿using System;
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
        private readonly DTO.RuntimeVariables.Dashboard _dashboard;

        public EvergreenJnr_DashboardsPage(RemoteWebDriver driver, DTO.RuntimeVariables.Dashboard dashboard)
        {
            _driver = driver;
            _dashboard = dashboard;
        }

        [Then(@"Dashboard with ""(.*)"" title displayed in All Dashboards")]
        public void ThenFollowingDashboardDisplayedInAllDashboardList(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var currentList = page.AllDashboardsInPanel.Select(title => title.Text).ToList();

            Utils.Verify.That(page.AllDashboardsInPanel.Select(title => title.Text).ToList().Contains(dashboardName), Is.True, $"Dashboard name is missing");
        }

        [When(@"User clicks Settings button for ""(.*)"" dashboard")]
        public void WhenUserClicksSettingsButtonForDashboard(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.OpenSettingsByDashboardName(dashboardName).Click();
        }

        [When(@"User sets ""(.*)"" as favorite state in dashboard details for ""(.*)"" dashboard")]
        public void WhenUserSetsDashboardFavoriteState(string state, string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            if (Convert.ToBoolean(state))
            {
                if (!page.GetFavoriteStateInDashboardDetailsPane())
                {
                    page.MarkFavoriteInDashboardDetails();
                    _driver.WaitFor(() => page.IsDashboardMarkedAsFavoriteInList(dashboardName));
                }
            }

            if (!Convert.ToBoolean(state))
            {
                if (page.GetFavoriteStateInDashboardDetailsPane())
                {
                    page.UnMarkFavoriteInDashboardDetails();
                    _driver.WaitFor(() => !page.IsDashboardMarkedAsFavoriteInList(dashboardName));
                }
            }
        }

        [When(@"User opens manage pane for dashboard with ""(.*)"" name")]
        public void WhenUserManagePaneForListName(string dashboardName)
        {
            var dashboardElement = _driver.NowAt<EvergreenDashboardsPage>();

            dashboardElement.ClickSettingsButtonByDashboardName(dashboardName);
            _driver.WaitForElementToBeDisplayed(dashboardElement.ManageContextMenuItem);
            dashboardElement.ManageContextMenuItem.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User makes dashboard with ""(.*)"" name favorite via context menu")]
        public void WhenUserMakesDashboardFavoriteViaContextMenu(string dashboardName)
        {
            var dashboardElement = _driver.NowAt<EvergreenDashboardsPage>();

            dashboardElement.ClickSettingsButtonByDashboardName(dashboardName);
            _driver.WaitForElementToBeDisplayed(dashboardElement.MakeFavoriteContextMenuItem);
            dashboardElement.MakeFavoriteContextMenuItem.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User unfavorites ""(.*)"" dashboard via context menu")]
        public void WhenUserUnfavoritesDashboardViaContextMenu(string dashboardName)
        {
            var dashboardElement = _driver.NowAt<EvergreenDashboardsPage>();

            dashboardElement.ClickSettingsButtonByDashboardName(dashboardName);
            _driver.WaitForElementToBeDisplayed(dashboardElement.UnfavoriteContextMenuItem);
            dashboardElement.UnfavoriteContextMenuItem.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User makes dashboard with ""(.*)"" name default via context menu")]
        public void WhenUserMakesDashboardDefaultViaContextMenu(string dashboardName)
        {
            var dashboardElement = _driver.NowAt<EvergreenDashboardsPage>();

            dashboardElement.ClickSettingsButtonByDashboardName(dashboardName);
            _driver.WaitForElementToBeDisplayed(dashboardElement.MakeDefaultContextMenuItem);
            dashboardElement.MakeDefaultContextMenuItem.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Dashboard with name ""(.*)"" marked as favorite")]
        public void ThenUserSeesDashboardsMarkedAsFavorite(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.IsDashboardMarkedAsFavoriteInList(dashboardName), Is.True);
        }

        [Then(@"Dashboard with name ""(.*)"" marked as default")]
        public void ThenUserSeesDashboardsMarkedAsDefault(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.IsDashboardMarkedAsDefaultInList(dashboardName), Is.True);
        }

        [Then(@"Dashboard with name ""(.*)"" not marked as favorite")]
        public void ThenUserSeesDashboardsNotMarkedAsFavorite(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.IsDashboardMarkedAsFavoriteInList(dashboardName), Is.False);
        }

        [Then(@"Dashboard with name ""(.*)"" not marked as default")]
        public void ThenUserSeesDashboardsNotMarkedAsDefault(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.IsDashboardMarkedAsDefaultInList(dashboardName), Is.False);
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
            _driver.WaitForDataLoading();
            var ellipsisMenu = page.GetEllipsisMenuForWidget(widgetName);

            if (ellipsisMenu != null)
            {
                page.GetEllipsisMenuForWidget(widgetName).Click();
                _driver.WaitForElementToBeDisplayed(page.EllipsisMenu);
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
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.DashboardsDetailsIcon);
            page.DashboardsDetailsIcon.Click();
            _driver.WaitForElementToBeDisplayed(page.DashboardsContextMenu);
        }

        [Then(@"User sees Ellipsis icon enabled for ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetEllipsisMenuForWidget(widgetName).Displayed(), Is.True);
        }

        [Then(@"User sees Dashboards context menu on Dashboards page")]
        public void ThenUserSeesDashboardsContextMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.DashboardsContextMenu.Displayed(), Is.True);
        }

        [Then(@"Dashboards context menu is hidden on Dashboards page")]
        public void ThenDashboardsContextMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.DashboardsContextMenu.Displayed(), Is.False);
        }

        [Then(@"User sees Dashboards sub menu on Dashboards page")]
        public void ThenUserSeesDashboardsSubMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.DashboardsSubmenu.Displayed(), Is.True);
        }

        [Then(@"Dashboards sub menu is hidden on Dashboards page")]
        public void ThenDashboardsSubMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.DashboardsSubmenu.Displayed(), Is.False);
        }

        [Then(@"User sees Ellipsis icon disabled for ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetEllipsisMenuForWidget(widgetName), Is.Null);
        }

        [When(@"User clicks Ellipsis menu for Section having ""(.*)"" Widget on Dashboards page")]
        public void WhenUserClicksEllipsisMenuForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Click();
            _driver.WaitForElementToBeDisplayed(page.EllipsisMenu);
        }

        [Then(@"User sees Ellipsis icon enabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(), Is.True);
        }

        [Then(@"User sees Ellipsis icon disabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(), Is.False);
        }

        [Then(@"User sees Collapse/Expand icon enabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesCollapseExpandIconEnabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            var aa = page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault();
            Utils.Verify.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
                Is.True);
        }

        [Then(@"User sees Collapse/Expand icon disabled for Section having ""(.*)"" Widget on Dashboards page")]
        public void ThenUserSeesCollapseExpandIconDisabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
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
                Utils.Verify.That(page.EllipsisMenuItems[i].Text, Is.EqualTo(items.Rows[i].Values.FirstOrDefault()),
                    "Items are not the same");
        }

        [Then(@"""(.*)"" Ellipsis menu item is disabled on Dashboards page")]
        public void ThenEllipsisMenuItemIsDisabledOnDashboardsPage(string itemName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.GetDisabledEllipsisItemByName(itemName).Displayed(), "Ellipsis menu item is enabled");
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

        [Then(@"User sees Widget square colored in amber")]
        public void ThenWidgetDeleteSquareColoredInAmber()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.GetDeleteWidgetSquareColor(), Is.EqualTo("rgba(235, 175, 37, 1)"),
                "Wrong widget delete message color");
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
            Utils.Verify.That(page.NumberOfWidgetLegends.Count, Is.EqualTo(expectedCount),
                "Number of Widgets with Legend is different");
        }

        [Then(@"User sees number of Sections increased by ""(.*)"" on Dashboards page")]
        public void WhenUserSeesNumberOfSectionsIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            int expectedCount = Int32.Parse(page.Storage.SessionStorage.GetItem("numberOfSections")) + increasedBy;
            Utils.Verify.That(page.AllSections.Count, Is.EqualTo(expectedCount), "Number of Sections is different");
        }

        [Then(@"User sees number of Widgets increased by ""(.*)"" on Dashboards page")]
        public void WhenUserSeesNumberOfWidgetsIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            int expectedCount = Int32.Parse(page.Storage.SessionStorage.GetItem("numberOfWidgets")) + increasedBy;
            Utils.Verify.That(page.AllWidgetsTitles.Count, Is.EqualTo(expectedCount), "Number of Widgets is different");
        }

        [Then(@"User sees following Widgets on Dashboards page:")]
        public void WhenUserSeesFollowingWidgetsOnDashboardsPage(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> expectedWidgetsNames =
                table.Rows.Select(x => x.Values).Select(c => c.FirstOrDefault()).ToList();

            Utils.Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Is.EqualTo(expectedWidgetsNames),
                "Names of Widgets are different");
        }

        [Then(@"User sees following Widgets in one Section on Dashboards page:")]
        public void WhenUserSeesFollowingWidgetsInOneSectionOnDashboardsPage(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> expectedWidgetsNames =
                table.Rows.Select(x => x.Values).Select(c => c.FirstOrDefault()).ToList();

            Utils.Verify.That(page.GetWidgetsNamesInSections(), Does.Contain(expectedWidgetsNames),
                "Names of Widgets are different");
        }

        [When(@"User clicks ""(.*)"" button for ""(.*)"" Section on Dashboards page")]
        public void WhenUserClicksButtonForSectionOnDashboardsPage(string buttonLabel, int section)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetButtonsByName(buttonLabel).ElementAt(section - 1).Click();
        }

        [When(@"User clicks the ""(.*)"" button on Dashboard Details")]
        public void WhenUserClicksTheButtonOnDashboardDetails(string buttonName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetDashboardDetailsButtonsByName(buttonName).Click();
        }

        [Then(@"Team/User section in not displayed on Dashboard Details")]
        public void ThenTeamUserSectionInNotDisplayedOnDashboardDetails()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsFalse(page.UserTeamSectionOnDashboardDetails.Displayed(), "Team/User section in not displayed");
        }

        [Then(@"User sees widget with the next name ""(.*)"" on Dashboards page")]
        public void ThenUserSeesWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Does.Contain(widgetName),
                "Widget name is missing");
        }

        [Then(@"User cant see widget with the next name ""(.*)"" on Dashboards page")]
        public void ThenUserCantSeeWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Does.Not.Contain(widgetName),
                "Widget name is missing");
        }

        [Then(@"User sees Edit mode trigger is in the On position on Dashboards page")]
        public void ThenUserSeesEditModeTriggerIsInTheOnPositionOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.GetEditModeState(), Is.True, "Trigger is in the OFF position");
        }

        [Then(@"User sees Edit mode trigger is in the Off position on Dashboards page")]
        public void ThenUserSeesEditModeTriggerIsInTheOffPositionOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.GetEditModeState(), Is.False, "Trigger is in the ON position");
        }

        [Then(@"User sees Edit mode trigger has blue style on Dashboards page")]
        public void ThenUserSeesEditModeTriggerHasBlueStyleOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.GetEditModeSlideBarColor(), Is.EqualTo("rgba(49, 122, 193, 0.54)"),
                "Edit mode slider is not blue");
            Utils.Verify.That(page.GetEditModeSlideToggleColor(), Is.EqualTo("rgba(49, 122, 193, 1)"),
                "Edit mode trigger is not blue");
        }

        [Then(@"User sees Edit mode trigger has grey style on Dashboards page")]
        public void ThenUserSeesEditModeTriggerHasGreyStyleOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.GetEditModeSlideBarColor(), Is.EqualTo("rgba(0, 0, 0, 0.38)"),
                "Edit mode slider is not grey");
            Utils.Verify.That(page.GetEditModeSlideToggleColor(), Is.EqualTo("rgba(250, 250, 250, 1)"),
                "Edit mode trigger is not grey");
        }

        [Then(@"Widget name ""(.*)"" has word break style on Dashboards page")]
        public void WhenUserSeesWordBreakAttributesForNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            try
            {
                var widget = page.AllWidgetsTitles.FirstOrDefault(x => x.Text.Equals(widgetName));
                Utils.Verify.That(widget.GetCssValue("word-break"), Is.EqualTo("break-word"),
                    "Word break formatting is missing");
                Utils.Verify.That(widget.GetCssValue("word-wrap"), Is.EqualTo("break-word"),
                    "Word break formatting is missing");
            }
            catch (NullReferenceException)
            {
                Utils.Verify.IsFalse(true, "Widget not found");
            }
        }

        [Then(@"User sees Widget with ""(.*)"" name on Dashboards page")]
        public void WhenUserSeesWidgetWithNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Utils.Verify.That(page.IsWidgetExists(widgetName), Is.True, $"Widget with name {widgetName} doesn't exist");
        }

        [When(@"User deletes ""(.*)"" Widget on Dashboards page")]
        public void WhenUserDeletesWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisMenuForWidget(widgetName).Click();
            page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals("Delete")).FirstOrDefault().Click();
            page.DeleteButtonInAlert.Click();
        }

        [When(@"User clicks edit option for broken widget on Dashboards page")]
        public void WhenUserClicksEditWidgetOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.EditButtonInAlert);
            page.EditButtonInAlert.Click();
        }

        [When(@"User confirms item deleting on Dashboards page")]
        public void WhenUserConfirmItemDeletingDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.DeleteButtonInAlert.Click();
            _driver.WaitForDataLoading();
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

            _driver.WaitForElementToBeDisplayed(page.CancelButtonInAlert);
            page.CancelButtonInAlert.Click();
        }

        [When(@"User creates new Dashboard with ""(.*)"" name")]
        public void WhenUserCreatesNewDashboardWithName(string dashboardName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Utils.Verify.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.DashboardNameTextBox.SendKeys(dashboardName);
            listElement.SaveButton.Click();
            _driver.WaitForElementToBeNotDisplayed(listElement.SaveButton);
            _driver.WaitForDataLoading();
            _dashboard.Value.dashboardId = DatabaseHelper.GetDashboardId(dashboardName);
        }

        [When(@"User types ""(.*)"" as dashboard title")]
        public void WhenEnterDashboardTitle(string dashboardName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Utils.Verify.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.DashboardNameTextBox.SendKeys(dashboardName);
        }

        [Then(@"Red Dashboard should be unique error displayed to user")]
        public void DashboardUniqueErrorDisplayed()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.DashboardUniqueError);
            Utils.Verify.IsTrue(page.DashboardUniqueError.Displayed(), "Dashboard should be unique error is not displayed");
            Utils.Verify.That(page.DashboardUniqueError.GetCssValue("background-color"), Is.EqualTo("rgba(242, 88, 49, 1)"), "Wrong message color");

            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"Red Dashboard should be unique error disappears")]
        public void DashboardUniqueErrorDisappears()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeNotDisplayed(page.DashboardUniqueError);
            Utils.Verify.IsFalse(page.DashboardUniqueError.Displayed(), "Dashboard should be unique error is still displayed");

            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsFalse(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"Text Only is displayed for Card widget")]
        public void ThenTextOnlyIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.TextOnlyCardWidget.Displayed(), "Text Only is not displayed for Card widget");
        }

        [Then(@"Icon and Text is displayed for Card widget")]
        public void ThenIconAndTextIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.IconAndTextCardWidget.Displayed(), "Icon and Text is not displayed for Card widget");
        }

        [Then(@"Icon Only is displayed for Card widget")]
        public void ThenIconOnlyIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.IconOnlyCardWidget.Displayed(), "Icon Only is not displayed for Card widget");
        }

        [Then(@"User sees ""(.*)"" text in warning message on Dashboards page")]
        public void ThenUserSeesTextInWarningMessageOnDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.AreEqual(text, page.TextInDeleteAlert.First().Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"User sees ""(.*)"" text in ""(.*)"" warning messages on Dashboards page")]
        public void ThenUserSeesTextInWarningMessageOnDashboardsPage(string text, string number)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.AreEqual(text, page.TextInDeleteAlert[Convert.ToInt32(number) - 1].Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" link is displayed in warning message on Dashboards page")]
        public void ThenLinkIsDisplayedInWarningMessageOnDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.AreEqual(text, page.LinkInWarningMessage.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"User sees ""(.*)"" text in warning message on Dashboards submenu pane")]
        public void ThenUserSeesTextInWarningMessageOnSubmenuDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.AreEqual(text, page.SubmenuAlertMessage.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Widget Preview is displayed to the user")]
        public void ThenWidgetPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.WidgetPreview.Displayed(), "Widget Preview is not displayed");
        }

        [Then(@"Card widget displayed inside preview pane")]
        public void ThenCardWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<EvergreenDashboardsPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;
            int prevX = preview.WidgetPreview.Location.X;
            int prevY = preview.WidgetPreview.Location.Y;

            var widget = _driver.NowAt<EvergreenDashboardsPage>();
            int widgetWidth = widget.GetCardWidgetPreviewText().Size.Width;
            int widgetX = widget.GetCardWidgetPreviewText().Location.X;
            int widgetY = widget.GetCardWidgetPreviewText().Location.Y;

            Utils.Verify.That(prevX < widgetX && prevY < widgetY, Is.True, "Widget XY coordinate displayed outside preview box");
            Utils.Verify.That(prevWidth > widgetWidth, Is.True, "Widget width displayed outside preview box");
        }


        [Then(@"content in the Widget is displayed in following order:")]
        public void ThenContentInTheWidgetIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var contentList = page.TableWidgetContent.Select(x => x.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Utils.Verify.AreEqual(contentList, expectedList, "content in the Widget is displayed in the incorrect order");
        }

        [Then(@"""(.*)"" Widget is displayed to the user")]
        public void ThenWidgetIsDisplayedToTheUser(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.GetWidgetByName(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"Label ""(.*)"" displayed for ""(.*)"" widget")]
        public void ThenWidgetLabelContainsLabel(string label, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Utils.Verify.That(page.GetWidgetLabels(widgetName).Select(x => x.Text).ToList(), Does.Contain(label), $"{label} label is not found");
        }

        [Then(@"Label icon displayed gray for ""(.*)"" widget")]
        public void ThenWidgetLabelContainsImageColoredInGray(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Utils.Verify.That(page.GetLegendColor(widgetName), Does.Contain("#C6CBD2"), $"#C6CBD2 color is not found");
        }

        [Then(@"link is not displayed for the ""(.*)"" value in the Widget")]
        public void ThenLinkIsNotDisplayedForTheValueInTheWidget(string content)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.GetTableWidgetContentWithoutLink(content).Displayed(), $"link is displayed for the {content} value");
            Utils.Verify.AreEqual("rgba(0, 0, 0, 0.87)",
                page.GetTableWidgetContentWithoutLink(content).GetCssValue("color"), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"following content is displayed in the ""(.*)"" column")]
        public void ThenFollowingContentIsDisplayedInTheColumn(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var originalList = page.GetColumnContentByColumnName(columnName).Select(column => column.Text).ToList();
            var tableContent = table.Rows.SelectMany(row => row.Values);
            Utils.Verify.AreEqual(originalList, tableContent, $"Incorrect content is displayed in the {columnName}");
        }

        [Then(@"Column ""(.*)"" with no data displayed")]
        public void ThenFollowingColumnDisplayedWithoutNoData(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var originalList = page.GetColumnContentByColumnName(columnName).Select(column => column.Text).ToList();

            foreach (var item in originalList)
            {
                Utils.Verify.That(item, Is.EqualTo(""), $"Incorrect content is displayed in the {columnName}");
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
                Utils.Verify.AreEqual(originalList, tableContent, "PLEASE ADD EXCEPTION MESSAGE");
            }
        }

        [Then(@"Card ""(.*)"" Widget is displayed to the user")]
        public void ThenCardWidgetIsDisplayedToTheUser(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.GetCardWidgetByName(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"""(.*)"" color is displayed for widget")]
        public void ThenColorIsDisplayedForWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var getColor = page.GetCardWidgetPreviewText().GetCssValue("color");
            Utils.Verify.AreEqual(ColorWidgetConvertor.Convert(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"""(.*)"" color is displayed for Card Widget")]
        public void ThenColorIsDisplayedForCardWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var getColor = page.GetCardWidgetPreviewText().GetCssValue("color");
            Utils.Verify.AreEqual(ColorWidgetConvertor.ConvertComplianceColorWidget(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"""(.*)"" count is displayed for ""(.*)"" in the table Widget")]
        public void ThenCountIsDisplayedForInTheTableWidget(string boolean, string count)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.GetCountForTableWidget(count, boolean).Displayed(), $"{count} is not display for {boolean}");
        }

        [When(@"User clicks ""(.*)"" value for ""(.*)"" column")]
        public void WhenUserClicksValueFromColumn(string value, string column)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetCountForTableWidget(column, value).Click();
        }




        [Then(@"Permission panel is displayed to the user")]
        public void ThenPermissionPanelIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.PermissionPanel.Displayed(), "Actions panel was not displayed");
        }

        [When(@"User changes sharing type from ""(.*)"" to ""(.*)""")]
        public void WhenUserSelectsSharingType(string from, string to)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.ChangePermissionSharingFieldFromTo(from, to);
        }

        [When(@"User adds user to list of shared person")]
        public void WhenUserAddsNewPersonToSharingList(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.PermissionAddUserButton);
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
                Thread.Sleep(2000);
            }
        }

        [Then(@"User ""(.*)"" was added to shared list with ""(.*)"" permission")]
        public void ThenUserWasAddedToSharedList(string username, string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.PermissionNameOfAddedUser.Text, Is.EqualTo(username), "Username is not one that expected");
            Utils.Verify.That(page.PermissionAccessTypeOfAddedUser.Text, Is.EqualTo(permission), "Permission is not one that expected");
        }

        [Then(@"There is no user in shared list")]
        public void ThenNoUserFoundInSharedList()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeNotDisplayed(page.PermissionNameOfAddedUser);
            Utils.Verify.That(page.PermissionNameOfAddedUser.Displayed(), Is.False, "Username found in shared list");
        }

        [When(@"User expands the list of shared lists")]
        public void UserExpandsTheListOfSharedLists()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.DetailsPanelExpandListsIcon.Click();
        }

        [Then(@"User sees table headers as ""(.*)"" and ""(.*)""")]
        public void UserSeesTableHeadersAs(string a, string b)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementsToBeDisplayed(page.DetailsPanelSharedListsTableHeaders);
            Utils.Verify.That(page.DetailsPanelSharedListsTableHeaders.Select(x=>x.Text).ToList(), Is.EqualTo(new List<string>{a, b}), "Headers are different");
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
        
        [Then(@"Tooltip is displayed for the point of Line widget")]
        public void ThenTooltipIsDisplayedForThePoint(Table items)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            foreach (var row in items.Rows)
            {
                //action has to be performed twice, I don't know why
                _driver.MouseHover(page.GetPointOfLineWidgetByName(row["WidgetName"], row["NumberOfPoint"]));
                _driver.MouseHover(page.GetPointOfLineWidgetByName(row["WidgetName"], row["NumberOfPoint"]));

                Utils.Verify.That(page.GetFocusedPointHover(row["WidgetName"]), Is.EqualTo(row["Tooltip"]));
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

            Utils.Verify.That(page.IsLineWidgetPointsAreDisplayed(widgetName), Is.True, "Points are not displayed");
        }

        [Then(@"Line X labels of ""(.*)"" widget is displayed in following order:")]
        public void ThenLineLabelsIsDisplayedInFollowingOrder(string widgetName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            List<string> labelList = page.GetPointOfLineWidgetByName(widgetName);
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();

            Utils.Verify.AreEqual(expectedList, labelList, "Label order is incorrect");
        }

        [Then(@"Line X labels of ""(.*)"" column widget is displayed in following order:")]
        public void ThenLineXLabelsOfColumnWidgetIsDisplayedInFollowingOrder(string widgetName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            List<string> labelList = page.GetPointOfColumnWidgetByName(widgetName);
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();

            Utils.Verify.AreEqual(expectedList, labelList, "Label order is incorrect");
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
            Utils.Verify.IsTrue(page.PrintPreviewSettingsPopUp.Displayed(), "Print Preview is not Displayed");
            Utils.Verify.IsTrue(page.DashWorksPrintLogo.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsTrue(page.PrintPreviewWidgets.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
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
            Utils.Verify.IsTrue(page.A4PrintPreviewView.Displayed, "Print Preview is not displayed in A4 format view");
        }

        [Then(@"Print Preview is displayed in Letter format view")]
        public void ThenPrintPreviewIsDisplayedInLetterFormatView()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Utils.Verify.IsTrue(page.LetterPrintPreviewView.Displayed, "Print Preview is not displayed in Letter format view");
        }

        [Then(@"Print Preview is displayed in Portrait orientation")]
        public void ThenPrintPreviewIsDisplayedInPortraitOrientation()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Utils.Verify.IsTrue(page.PortraitPrintPreviewOrientation.Displayed, "Print Preview is not displayed in Portrait orientation");
        }

        [Then(@"Print Preview is displayed in Landscape orientation")]
        public void ThenPrintPreviewIsDisplayedInLandscapeOrientation()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Utils.Verify.IsTrue(page.LandscapePrintPreviewOrientation.Displayed, "Print Preview is not displayed in Landscape orientation");
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
            Utils.Verify.IsTrue(page.DataLabels.Displayed(), "Data Labels are not displayed");
        }

        [Then(@"""(.*)"" data label is displayed on the Dashboards page")]
        public void ThenDataLabelIsDisplayedOnTheDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.DataLabels.Text, Is.EqualTo(text), $"{text} data label is not displayed");
        }


        [Then(@"Move to Section pop up is displayed to the User")]
        public void ThenMoveToSectionPopUpIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.MoveToSectionPopUp.Displayed(), "Move to Section pop up is not displayed");
        }

        [Then(@"Move to Section pop up is not displayed to the User")]
        public void ThenMoveToSectionPopUpIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsFalse(page.MoveToSectionPopUp.Displayed(), "Move to Section pop up is displayed");
        }

        [When(@"User selects ""(.*)"" section on the Move to Section pop up")]
        public void WhenUserSelectsSectionOnTheMoveToSectionPopUp(string sectionName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.SelectSectionToMove(sectionName);
        }

        [When(@"User clicks ""(.*)"" button on the Move to Section Pop up")]
        public void WhenUserClicksButtonOnTheMoveToSectionPopUp(string buttonName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.ClickMoveToSectionPopUpButton(buttonName);
        }

        [Then(@"Widget Preview shows ""(.*)"" as First Cell value")]
        public void ThenWidgetPreviewShowsAsFirstCellValue(string option)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.GetCardWidgetPreviewText().Text, Is.EqualTo(option), "Widget Preview shown different value");
        }



        #region Dashboards details

        [When(@"User changes dashboard name to ""(.*)""")]
        public void WhenUserChangesDashboardNameTo(string dashboardName)
        {
            var dashboardDetailsElement = _driver.NowAt<EvergreenDashboardsPage>();
            dashboardDetailsElement.DashboardDetailsNameInput.Clear();
            dashboardDetailsElement.DashboardDetailsNameInput.SendkeysWithDelay(dashboardName);
            Thread.Sleep(3000);//Wait for autosave action, no indicators available
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks Default dashboard checkbox in Dashboard details")]
        public void WhenUserClicksDefaultDashboardCheckboxInDashboardDetails()
        {
            var dashboardDetailsElement = _driver.NowAt<EvergreenDashboardsPage>();
            dashboardDetailsElement.DefaultDashboardCheckboxLabel.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Default dashboard checkbox becomes disabled in Dashboard details")]
        public void ThenDefaultDashboardCheckboxBecomesDisabled()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.DefaultDashboardCheckbox.GetAttribute("disabled"), Is.EqualTo("true"), $"Default dashboard displayed enabled");
        }

        [Then(@"Default dashboard checkbox displayed checked in Dashboard details")]
        public void ThenDefaultDashboardCheckboxDisplayedChecked()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.DefaultDashboardCheckbox.Selected, Is.EqualTo(true), $"Default dashboard displayed deselected");
        }

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
            Utils.Verify.That(page.SharingDropdownPermissionValue.Text, Is.EqualTo(permission), $"Permission {permission} was not the same in Dashboard Details");
        }


        [Then(@"Review Widget List Permissions is displayed to the User")]
        public void ThenReviewWidgetListPermissionsIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsTrue(page.ReviewWidgetListPermissionsPopUp.Displayed(), "Review Widget List Permissions is not displayed");
        }

        [Then(@"Review Widget List Permissions is not displayed to the User")]
        public void ThenReviewWidgetListPermissionsIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.IsFalse(page.ReviewWidgetListPermissionsPopUp.Displayed(), "Review Widget List Permissions is displayed");
        }


        [Then(@"Widget ""(.*)"" displayed for ""(.*)"" list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsWidgetNameToTheUser(string widget, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.WidgetValueForList(listName).Text, Is.EqualTo(widget), $"Widget name {widget} was not found in Review Permissions popup");
        }

        [Then(@"Current user displayed for ""(.*)"" list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsCurrentUserNameToTheUser(string listName)
        {
            var header = _driver.NowAt<HeaderElement>();
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.OwnerValueForList(listName).Text,
                Is.EqualTo(header.UserNameDropdown.Text), $"Owner name was not found in Review Permissions popup");
        }

        [Then(@"User ""(.*)"" displayed for ""(.*)"" list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsUserNameToTheUser(string user, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.OwnerValueForList(listName).Text,
                Is.EqualTo(user), $"User name was not found in Review Permissions popup");
        }

        [Then(@"Current permission ""(.*)"" displayed for ""(.*)"" list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsCurrentPermissionToTheUser(string permission, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.CurrentPermissionValueForList(listName).Text,
                Is.EqualTo(permission), $"Current permission {permission} was not found in Review Permissions popup");
        }

        [Then(@"New Permission ""(.*)"" displayed for ""(.*)"" list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsNewPermissionToTheUser(string permission, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Utils.Verify.That(page.NewPermissionsValueForList(listName).Text, Is.EqualTo(permission), $"New permission {permission} was not found in Review Permissions popup");
        }

        [Then(@"User sees next options of New Permission field for ""(.*)"" list on Permissions Pop-up")]
        public void ThenUserSeesNexPermissionOptionsInWidgetListPermissions(string listName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.NewPermissionsDropdownForList(listName).Click();

            List<string> options = page.ReviewWidgetListPermissionExpandedOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Assert.That(options.FindAll(x => x.Equals(row["Options"])).Count == 1, "PLEASE ADD EXCEPTION MESSAGE");
            }
            Utils.Verify.That(options.Count, Is.EqualTo(table.Rows.Count));

            //hide menu
            page.SelectDoNotChangeReviewPermission();
        }

        [When(@"User selects ""(.*)"" permission for ""(.*)"" list on Permissions Pop-up")]
        public void WhenUserSelectsPermissionOnTheListPermissionsPopup(string option, string list)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _driver.WaitForDataLoading();
            _driver.SelectCustomSelectbox(page.NewPermissionsDropdownForList(list), option);
            _driver.WaitForDataLoading();
        }

        [Then(@"New Permission dropdown has disabled property ""(.*)"" for ""(.*)"" list on Permissions Pop-up")]
        public void ThenUserSeesNewPermissionDropdownInNextStateForListOnListPermissionsPopup(string state, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetDropdownStateOfReviewWidgetPermissionsPopup(listName),
                Is.EqualTo(state.ToUpper()), $"New permission {state} states is different");
        }

        [Then(@"New Permission dropdown has ""(.*)"" tooltip for ""(.*)"" list on Permissions Pop-up")]
        public void ThenTooltipIsDisplayedWithTextForPermissionDropdown(string tooltip, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(page.NewPermissionsDropdownForList(listName));
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.That(tooltip, Is.EqualTo(toolTipText), "Tooltip is different");
        }

        [Then(@"Button ""(.*)"" has enabled property ""(.*)"" on Permissions Pop-up")]
        public void ThenUserSeesButtonInTheNextStateForListOnListPermissionsPopup(string buttonCapture, string buttonState)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Utils.Verify.That(page.GetButtonStateOfReviewWidgetPermissionsPopup(buttonCapture),
                Is.EqualTo(buttonState.ToUpper()), $"Button {buttonCapture} states is different");
        }

        [Then(@"Button ""(.*)"" has ""(.*)"" tooltip on Permissions Pop-up")]
        public void ThenTooltipIsDisplayedWithTextForForButtonOnListPermissionsPopup(string buttonCapture, string tooltip)
        {
            var button = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(button.ReviewPermissionsPopupsButton(buttonCapture));
            _driver.WaitForDataLoading();
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.That(tooltip, Is.EqualTo(toolTipText), "Tooltip is different");
        }

        [When(@"User clicks the ""(.*)"" button on Permissions Pop-up")]
        public void WhenUserClicksTheActionButtonOnListPermissionsPopup(string buttonName)
        {
            var action = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            action.ReviewPermissionsPopupsButton(buttonName).Click();
        }

        [Then(@"User sees dashboard menu with next options")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> options = page.DashboardMenuOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Utils.Verify.That(options.FindAll(x => x.Equals(row["OptionsName"])).Count == 1,
                    "PLEASE ADD EXCEPTION MESSAGE");
            }
            Utils.Verify.That(options.Count, Is.EqualTo(table.Rows.Count));
        }

        [When(@"Dashboard page loaded")]
        public void ThenUserSeesDashboardPageOpened()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.EditModeOnOffTrigger);
            _driver.WaitForDataLoading();
        }

        #endregion

        
    }
}