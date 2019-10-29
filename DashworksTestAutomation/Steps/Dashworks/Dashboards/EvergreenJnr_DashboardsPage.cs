﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.Dashboards;
using DashworksTestAutomation.Utils;
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
        private readonly Dashboards _dashboard;
        private readonly SectionsAndWidgetsCount _sectionsAndWidgets;
        private readonly UserDto _user;

        public EvergreenJnr_DashboardsPage(RemoteWebDriver driver, Dashboards dashboard, SectionsAndWidgetsCount sectionsAndWidgets,
            UserDto user)
        {
            _driver = driver;
            _dashboard = dashboard;
            _sectionsAndWidgets = sectionsAndWidgets;
            _user = user;
        }

        [Then(@"Dashboard with '(.*)' title displayed in All Dashboards")]
        public void ThenFollowingDashboardDisplayedInAllDashboardList(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.ListDashboards.Select(title => title.Text).ToList().Contains(dashboardName), Is.True, $"Dashboard name is missing");
        }

        [When(@"User clicks Settings button for '(.*)' dashboard")]
        public void WhenUserClicksSettingsButtonForDashboard(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.DashboardMenuSelector(dashboardName).Click();
        }

        [When(@"User sets '(.*)' as favorite state in dashboard details for '(.*)' dashboard")]
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

        [When(@"User clicks menu for '(.*)' dashboard")]
        public void WhenUserClicksMenuForDashboard(string dashboardName)
        {
            var dashboardElement = _driver.NowAt<EvergreenDashboardsPage>();
            dashboardElement.ClickMenuButtonByDashboardName(dashboardName);
            Thread.Sleep(500);
        }

        [When(@"User selects '(.*)' menu for '(.*)' dashboard")]
        public void WhenUserManagePaneForListName(string menuItem, string dashboardName)
        {
            var dashboardElement = _driver.NowAt<EvergreenDashboardsPage>();

            WhenUserClicksMenuForDashboard(dashboardName);
            _driver.WaitForElementToBeDisplayed(dashboardElement.DashboardMenuItem(menuItem));
            dashboardElement.DashboardMenuItem(menuItem).Click();
            _driver.WaitForDataLoading();

            if (menuItem.Equals("Duplicate"))
            {
                _driver.WaitForElementToBeDisplayed(dashboardElement.SuccessMessage);
                _dashboard.Value.Add(new DashboardDto() { DashboardName = $"{dashboardName}2", User = _user });
            }
        }


        [Then(@"Dashboard with name '(.*)' marked as favorite")]
        public void ThenUserSeesDashboardsMarkedAsFavorite(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.IsDashboardMarkedAsFavoriteInList(dashboardName), Is.True);
        }

        [Then(@"Dashboard with name '(.*)' marked as default")]
        public void ThenUserSeesDashboardsMarkedAsDefault(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.IsDashboardMarkedAsDefaultInList(dashboardName), Is.True);
        }

        [Then(@"Dashboard with name '(.*)' not marked as favorite")]
        public void ThenUserSeesDashboardsNotMarkedAsFavorite(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.IsDashboardMarkedAsFavoriteInList(dashboardName), Is.False);
        }

        [Then(@"Dashboard with name '(.*)' not marked as default")]
        public void ThenUserSeesDashboardsNotMarkedAsDefault(string dashboardName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.IsDashboardMarkedAsDefaultInList(dashboardName), Is.False);
        }

        [Then(@"User sees correct tooltip for Show Dashboards panel")]
        public void WhenUserSeesCorrectTooltipForShowDashboardsPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            _driver.MouseHover(page.ExpandSideNavPanelIcon);
            var toolTipText = _driver.GetTooltipText();
            Verify.That(toolTipText, Is.EqualTo("Open menu"), $"Other tooltip is displayed to user: {toolTipText}");
        }

        [When(@"User clicks Show Dashboards panel icon on Dashboards page")]
        public void WhenUserClicksShowDashboardsPanelOnDashboardsPage()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.ExpandSideNavPanelIcon);
            page.ExpandSideNavPanelIcon.Click();
        }

        [When(@"User clicks Edit mode trigger on Dashboards page")]
        public void WhenUserClicksEditModeTriggerOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            page.EditModeOnOffTrigger.Click();
        }

        [When(@"User clicks Ellipsis menu for '(.*)' Widget on Dashboards page")]
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



        [Then(@"User sees Ellipsis icon enabled for '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetEllipsisMenuForWidget(widgetName).Displayed(), Is.True);
        }

        [Then(@"User sees Dashboards context menu on Dashboards page")]
        public void ThenUserSeesDashboardsContextMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.DashboardsContextMenu.Displayed(), Is.True);
        }

        [Then(@"Dashboards context menu is hidden on Dashboards page")]
        public void ThenDashboardsContextMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.DashboardsContextMenu.Displayed(), Is.False);
        }

        [Then(@"User sees Dashboards sub menu on Dashboards page")]
        public void ThenUserSeesDashboardsSubMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.DashboardsListPanel.Displayed(), Is.True);
        }

        [Then(@"Dashboards sub menu is hidden on Dashboards page")]
        public void ThenDashboardsSubMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.DashboardsListPanel.Displayed(), Is.False);
        }

        [Then(@"User sees Ellipsis icon disabled for '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetEllipsisMenuForWidget(widgetName), Is.Null);
        }

        [When(@"User clicks Ellipsis menu for Section having '(.*)' Widget on Dashboards page")]
        public void WhenUserClicksEllipsisMenuForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Click();
            _driver.WaitForElementToBeDisplayed(page.EllipsisMenu);
        }

        [Then(@"User sees Ellipsis icon enabled for Section having '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(), Is.True);
        }

        [Then(@"User sees Ellipsis icon disabled for Section having '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetEllipsisIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(), Is.False);
        }

        [Then(@"User sees Collapse/Expand icon enabled for Section having '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesCollapseExpandIconEnabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            var aa = page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault();
            Verify.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
                Is.True);
        }

        [Then(@"User sees Collapse/Expand icon disabled for Section having '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesCollapseExpandIconDisabledForSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
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
                Verify.That(page.EllipsisMenuItems[i].Text, Is.EqualTo(items.Rows[i].Values.FirstOrDefault()),
                    "Items are not the same");
        }

        [Then(@"'(.*)' Ellipsis menu item is disabled on Dashboards page")]
        public void ThenEllipsisMenuItemIsDisabledOnDashboardsPage(string itemName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsTrue(page.GetDisabledEllipsisItemByName(itemName).Displayed(), "Ellipsis menu item is enabled");
            var body = _driver.NowAt<BaseGridPage>();
            body.BodyContainer.Click();
        }

        [When(@"User clicks '(.*)' item from Ellipsis menu on Dashboards page")]
        public void WhenUserClicksItemFromEllipsisMenuOnDashboardsPage(string itemName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            try
            {
                page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals(itemName)).FirstOrDefault().Click();
                _driver.WaitForDataLoading();
            }
            catch (Exception e)
            {
                throw new Exception($"'{itemName}' menu item is not valid", e);
            }
        }

        [Then(@"User sees Widget square colored in amber")]
        public void ThenWidgetDeleteSquareColoredInAmber()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetDeleteWidgetAreaColor(), Is.EqualTo("rgba(235, 175, 37, 1)"),
                "Wrong widget delete message color");
        }

        [When(@"User remembers number of Sections and Widgets on Dashboards page")]
        public void WhenUserRemembersNumberOfSectionsAndWidgetsOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _sectionsAndWidgets.SectionsCount = page.AllSections.Count;
            _sectionsAndWidgets.WidgetsCount = page.AllWidgetsTitles.Count;
        }

        [Then(@"User sees '(.*)' Widgets with Legend on Dashboards page")]
        public void WhenUserRemembersNumberOfWidgetsWithLegendOnDashboardsPage(string expected)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.NumberOfWidgetLegends.Count.ToString(), Is.EqualTo(expected),
                "Number of Widgets with Legend is different");
        }

        [Then(@"User sees number of Sections increased by '(.*)' on Dashboards page")]
        public void WhenUserSeesNumberOfSectionsIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            int expectedCount = _sectionsAndWidgets.SectionsCount + increasedBy;
            Verify.That(page.AllSections.Count, Is.EqualTo(expectedCount), "Number of Sections is different");
        }

        [Then(@"User sees number of Widgets increased by '(.*)' on Dashboards page")]
        public void WhenUserSeesNumberOfWidgetsIncreasedByOnDashboardsPage(int increasedBy)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            int expectedCount = _sectionsAndWidgets.WidgetsCount + increasedBy;
            Verify.That(page.AllWidgetsTitles.Count, Is.EqualTo(expectedCount), "Number of Widgets is different");
        }

        [Then(@"User sees following Widgets on Dashboards page:")]
        public void WhenUserSeesFollowingWidgetsOnDashboardsPage(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> expectedWidgetsNames =
                table.Rows.Select(x => x.Values).Select(c => c.FirstOrDefault()).ToList();

            Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Is.EqualTo(expectedWidgetsNames),
                "Names of Widgets are different");
        }

        [Then(@"User sees following Widgets in one Section on Dashboards page:")]
        public void WhenUserSeesFollowingWidgetsInOneSectionOnDashboardsPage(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            List<string> expectedWidgetsNames =
                table.Rows.Select(x => x.Values).Select(c => c.FirstOrDefault()).ToList();

            Verify.That(page.GetWidgetsNamesInSections(), Does.Contain(expectedWidgetsNames),
                "Names of Widgets are different");
        }

        [When(@"User clicks '(.*)' button for '(.*)' Section on Dashboards page")]
        public void WhenUserClicksButtonForSectionOnDashboardsPage(string buttonLabel, int section)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetButtonsByName(buttonLabel).ElementAt(section - 1).Click();
        }

        [Then(@"User sees widget with the next name '(.*)' on Dashboards page")]
        public void ThenUserSeesWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Does.Contain(widgetName),
                "Widget name is missing");
        }

        [Then(@"User cant see widget with the next name '(.*)' on Dashboards page")]
        public void ThenUserCantSeeWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Does.Not.Contain(widgetName),
                "Widget name is missing");
        }

        [Then(@"User sees Edit mode trigger is in the On position on Dashboards page")]
        public void ThenUserSeesEditModeTriggerIsInTheOnPositionOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.GetEditModeState(), Is.True, "Trigger is in the OFF position");
        }

        [Then(@"User sees Edit mode trigger is in the Off position on Dashboards page")]
        public void ThenUserSeesEditModeTriggerIsInTheOffPositionOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.GetEditModeState(), Is.False, "Trigger is in the ON position");
        }

        [Then(@"User sees Edit mode trigger has blue style on Dashboards page")]
        public void ThenUserSeesEditModeTriggerHasBlueStyleOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.GetEditModeSlideBarColor(), Is.EqualTo("rgba(49, 122, 193, 0.54)"),
                "Edit mode slider is not blue");
            Verify.That(page.GetEditModeSlideToggleColor(), Is.EqualTo("rgba(49, 122, 193, 1)"),
                "Edit mode trigger is not blue");
        }

        [Then(@"User sees Edit mode trigger has grey style on Dashboards page")]
        public void ThenUserSeesEditModeTriggerHasGreyStyleOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.GetEditModeSlideBarColor(), Is.EqualTo("rgba(0, 0, 0, 0.38)"),
                "Edit mode slider is not grey");
            Verify.That(page.GetEditModeSlideToggleColor(), Is.EqualTo("rgba(250, 250, 250, 1)"),
                "Edit mode trigger is not grey");
        }

        [Then(@"Widget name '(.*)' has word break style on Dashboards page")]
        public void WhenUserSeesWordBreakAttributesForNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            try
            {
                var widget = page.AllWidgetsTitles.FirstOrDefault(x => x.Text.Equals(widgetName));
                Verify.That(widget.GetCssValue("word-break"), Is.EqualTo("break-word"),
                    "Word break formatting is missing");
                Verify.That(widget.GetCssValue("word-wrap"), Is.EqualTo("break-word"),
                    "Word break formatting is missing");
            }
            catch (NullReferenceException)
            {
                Verify.IsFalse(true, "Widget not found");
            }
        }

        [Then(@"User sees Widget with '(.*)' name on Dashboards page")]
        public void WhenUserSeesWidgetWithNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.IsWidgetExists(widgetName), Is.True, $"Widget with name {widgetName} doesn't exist");
        }

        [Then(@"User sees '(.*)' widgets with '(.*)' name on Dashboards page")]
        public void WhenUserSeesOnlyNumberWidgetsWithNameOnDashboardsPage(int numberOfWidgets, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.IsTrue(page.IsWidgetExists(widgetName), $"Widget with name {widgetName} doesn't exist");
            Verify.IsTrue(page.GetWidgetsNumberByName(widgetName).Equals(numberOfWidgets), $"More than {numberOfWidgets} widgets were displayed.");
        }

        [When(@"User deletes '(.*)' Widget on Dashboards page")]
        public void WhenUserDeletesWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisMenuForWidget(widgetName).Click();
            page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals("Delete")).FirstOrDefault().Click();
            page.AlertButton("DELETE").Click();
        }

        [When(@"User clicks edit option for broken widget on Dashboards page")]
        public void WhenUserClicksEditWidgetOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.AlertButton("EDIT"));
            page.AlertButton("EDIT").Click();
        }

        [When(@"User confirms item deleting on Dashboards page")]
        public void WhenUserConfirmItemDeletingDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.AlertButton("DELETE").Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User deletes duplicated Section having '(.*)' Widget on Dashboards page")]
        public void WhenUserDeletesDuplicatedSectionHavingWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetEllipsisIconsForSectionsHavingWidget(widgetName).LastOrDefault().Click();
            page.EllipsisMenuItems.Select(x => x).Where(c => c.Text.Equals("Delete")).FirstOrDefault().Click();
            page.AlertButton("DELETE").Click();
        }

        [When(@"User clicks Cancel button in Delete Widget warning on Dashboards page")]
        public void WhenUserClicksCancelButtonInDeleteWidgetWarningOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _driver.WaitForElementToBeDisplayed(page.AlertButton("CANCEL"));
            page.AlertButton("CANCEL").Click();
        }

        [When(@"User creates new Dashboard with '(.*)' name")]
        public void WhenUserCreatesNewDashboardWithName(string dashboardName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Verify.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.DashboardNameTextBox.SendKeys(dashboardName);
            listElement.SaveButton.Click();
            _driver.WaitForElementToBeNotDisplayed(listElement.SaveButton);
            _driver.WaitForDataLoading();
            _dashboard.Value.Add(new DashboardDto() { DashboardName = dashboardName, User = _user });
        }

        [When(@"User types '(.*)' as dashboard title")]
        public void WhenEnterDashboardTitle(string dashboardName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Verify.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.DashboardNameTextBox.SendKeys(dashboardName);
        }

        [Then(@"Red Dashboard should be unique error displayed to user")]
        public void DashboardUniqueErrorDisplayed()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.DashboardUniqueError);
            Verify.IsTrue(page.DashboardUniqueError.Displayed(), "Dashboard should be unique error is not displayed");
            Verify.That(page.DashboardUniqueError.GetCssValue("background-color"), Is.EqualTo("rgba(242, 88, 49, 1)"), "Wrong message color");

            var listElement = _driver.NowAt<CustomListElement>();
            Verify.IsTrue(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"Red Dashboard should be unique error disappears")]
        public void DashboardUniqueErrorDisappears()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeNotDisplayed(page.DashboardUniqueError);
            Verify.IsFalse(page.DashboardUniqueError.Displayed(), "Dashboard should be unique error is still displayed");

            var listElement = _driver.NowAt<CustomListElement>();
            Verify.IsFalse(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"Text Only is displayed for Card widget")]
        public void ThenTextOnlyIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.TextOnlyCardWidget.Displayed(), "Text Only is not displayed for Card widget");
        }

        [Then(@"Icon and Text is displayed for Card widget")]
        public void ThenIconAndTextIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.IconAndTextCardWidget.Displayed(), "Icon and Text is not displayed for Card widget");
        }

        [Then(@"Icon Only is displayed for Card widget")]
        public void ThenIconOnlyIsDisplayedForCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.IconOnlyCardWidget.Displayed(), "Icon Only is not displayed for Card widget");
        }

        [Then(@"User sees '(.*)' text in warning message on Dashboards page")]
        public void ThenUserSeesTextInWarningMessageOnDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.AreEqual(text, page.TextInDeleteAlert.First().Text, "Delete confirmation text is different");
        }

        [Then(@"Delete widget warning message is displayed on Dashboards page")]
        public void ThenUserCantSeeWarningMessageOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.TextInDeleteAlert.Count, Is.EqualTo(0), "Delete confirmation is still displayed");
        }

        [Then(@"User sees '(.*)' text in '(.*)' warning messages on Dashboards page")]
        public void ThenUserSeesTextInWarningMessageOnDashboardsPage(string text, string number)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.AreEqual(text, page.TextInDeleteAlert[Convert.ToInt32(number) - 1].Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"'(.*)' link is displayed in warning message on Dashboards page")]
        public void ThenLinkIsDisplayedInWarningMessageOnDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.AreEqual(text, page.LinkInWarningMessage.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"User sees '(.*)' text in warning message on Dashboards submenu pane")]
        public void ThenUserSeesTextInWarningMessageOnSubmenuDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.AreEqual(text, page.DashboardsPanelAlert.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"content in the Widget is displayed in following order:")]
        public void ThenContentInTheWidgetIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var contentList = page.TableWidgetContent.Select(x => x.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Verify.AreEqual(contentList, expectedList, "content in the Widget is displayed in the incorrect order");
        }

        [Then(@"'(.*)' Widget is displayed to the user")]
        public void ThenWidgetIsDisplayedToTheUser(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.GetWidgetByName(widgetName));
            //Verify.IsTrue(page.GetWidgetByName(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"Label '(.*)' displayed for '(.*)' widget")]
        public void ThenWidgetLabelContainsLabel(string label, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.GetWidgetLabels(widgetName).Select(x => x.Text).ToList(), Does.Contain(label), $"{label} label is not found");
        }

        [Then(@"Label icon displayed gray for '(.*)' widget")]
        public void ThenWidgetLabelContainsImageColoredInGray(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.GetLegendColor(widgetName), Does.Contain("#C6CBD2"), $"#C6CBD2 color is not found");
        }

        [Then(@"link is not displayed for the '(.*)' value in the Widget")]
        public void ThenLinkIsNotDisplayedForTheValueInTheWidget(string content)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsTrue(page.GetTableWidgetContentWithoutLink(content).Displayed(), $"link is displayed for the {content} value");
            Verify.AreEqual("rgba(0, 0, 0, 0.87)",
                page.GetTableWidgetContentWithoutLink(content).GetCssValue("color"), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"following content is displayed in the '(.*)' column for Widget")]
        public void ThenFollowingContentIsDisplayedInTheColumnForWidget(string columnName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var originalList = page.GetWidgetRowContentByColumnName(columnName);
            var tableContent = table.Rows.SelectMany(row => row.Values).First();
            foreach (var content in originalList)
            {
                Verify.AreEqual(originalList, tableContent, "Unexpected column");
            }
        }

        [Then(@"Card '(.*)' Widget is displayed to the user")]
        public void ThenCardWidgetIsDisplayedToTheUser(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.GetCardWidgetByName(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"'(.*)' color is displayed for widget")]
        public void ThenColorIsDisplayedForWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var getColor = page.GetCardWidgetPreviewText().GetCssValue("color");
            Verify.AreEqual(ColorWidgetConvertor.Convert(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"'(.*)' color is displayed for Card Widget")]
        public void ThenColorIsDisplayedForCardWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var getColor = page.GetCardWidgetPreviewText().GetCssValue("color");
            Verify.AreEqual(ColorWidgetConvertor.ConvertComplianceColorWidget(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"'(.*)' count is displayed for '(.*)' in the table Widget")]
        public void ThenCountIsDisplayedForInTheTableWidget(string boolean, string count)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsTrue(page.GetCountForTableWidget(count, boolean).Displayed(), $"{count} is not display for {boolean}");
        }

        [When(@"User clicks '(.*)' value for '(.*)' column")]
        public void WhenUserClicksValueFromColumn(string value, string column)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetCountForTableWidget(column, value).Click();
        }

        [Then(@"There is no '(.*)' column for '(.*)' widget")]
        public void ThenThereIsNoSpecifiedColumnForWidget(string column, string widget)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            var headers = page.GetTableWidgetHeaders(widget);

            Verify.That(headers.Select(x => x.Text).ToList().FindAll(x => x.ToLower().Contains(column.ToLower())).Count(), Is.EqualTo(0), $"Table contains {column} header");
        }

        [Then(@"Table columns of '(.*)' widget placed in the next order:")]
        public void ThenThereIsNoSpecifiedColumnForWidget(string widget, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            var headers = page.GetTableWidgetHeaders(widget).Select(column => column.Text).ToList();
            var expectedTable = table.Rows.SelectMany(row => row.Values);

            Verify.That(headers, Is.EqualTo(expectedTable), $"Table orders is wrong");
        }

        [Then(@"Permission panel is displayed to the user")]
        public void ThenPermissionPanelIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsTrue(page.PermissionSection.Displayed(), "Actions panel was not displayed");
        }

        [When(@"User selects '(.*)' dashboard sharing option")]
        public void WhenUserSelectsSharingType(string to)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.SetPermissionSharingFieldTo(to);
            //TODO Section reloads with delay
            Thread.Sleep(1000);
        }

        [When(@"User adds user to list of shared person")]
        public void WhenUserAddsNewPersonToSharingList(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ClickButtonByName("ADD USER");

            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["User"]))
                {
                    action.AutocompleteSelect("User", row["User"], true);
                }

                if (!string.IsNullOrEmpty(row["Permission"]))
                {
                    action.SelectDropdown(row["Permission"], "Select access");
                }
                action.ClickButtonByName("ADD USER");

                //TODO Section reloads with delay
                Thread.Sleep(2000);
            }
        }

        [Then(@"User '(.*)' was added to shared list with '(.*)' permission")]
        public void ThenUserWasAddedToSharedList(string username, string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementsToBeDisplayed(page.PermissionAddedUser);

            Verify.That(page.PermissionAddedUser.Select(x => x.Text).ToList(), Does.Contain(username), "Username is not one that expected");
            Verify.That(page.PermissionTypeOfAccess.Select(x => x.Text).ToList(), Does.Contain(permission), "Permission is not one that expected");
        }

        [Then(@"There is no user in shared list")]
        public void ThenNoUserFoundInSharedList()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            // _driver.WaitForElementToBeNotDisplayed(page.PermissionAddedUser);
            Verify.That(page.PermissionAddedUser.Count, Is.EqualTo(0), "Username found in shared list");
        }

        [When(@"User expands the list of shared lists")]
        public void UserExpandsTheListOfSharedLists()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.DetailsPanelExpandListsIcon.Click();
            _driver.WaitForElementsToBeDisplayed(page.DetailsPanelSharedListsTableHeaders);
        }

        [Then(@"User sees table headers as '(.*)' and '(.*)'")]
        public void UserSeesTableHeadersAs(string a, string b)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementsToBeDisplayed(page.DetailsPanelSharedListsTableHeaders);
            Verify.That(page.DetailsPanelSharedListsTableHeaders.Select(x => x.Text).ToList(), Is.EqualTo(new List<string> { a, b }), "Headers are different");
        }

        [Then(@"User sees list icon displayed for '(.*)' widget in List section of Dashboards Details")]
        public void ThenUserSeesListIconDisplayedForListInListSectionOfDashboardsDetails(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetListIconFromListSectionOfDetailsPanel(widgetName).Displayed, Is.True, "List icon is not displayed");
        }

        [Then(@"User sees list icon displayed with tooltip for '(.*)' widget in List section of Dashboards Details")]
        public void ThenUserSeesListIconDisplayedWithTooltipForListInListSectionOfDashboardsDetails(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(page.GetListIconFromListSectionOfDetailsPanel(widgetName));

            var toolTipText = _driver.GetTooltipText();
            Verify.That(toolTipText, Is.EqualTo("Shared"), "Unexpected/missing tooltip");
        }

        [When(@"User clicks Settings button for '(.*)' shared user")]
        public void WhenUserClickSettingsMenuForSharedUser(string user)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetMenuOfSharedUser(user).Click();
        }

        [When(@"User selects '(.*)' option from Settings")]
        public void WhenUserClicksOptionFromSettingsMenuForSharedUser(string option)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetMenuOption(option).Click();
            //TODO Section reloads with delay
            Thread.Sleep(2000);
        }

        [When(@"User clicks data in card '(.*)' widget")]
        public void WhenUserClicksDataInCardWidget(string widgetTitle)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetCardWidgetContent(widgetTitle).Click();
        }

        [Then(@"Value '(.*)' is displayed in the card '(.*)' widget")]
        public void ValueIsDisplayedInCardWidget(string value, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetCardWidgetContent(widgetName).Text, Is.EqualTo(value), "Card value is different.");
        }

        [Then(@"'(.*)' message is displayed in '(.*)' widget")]
        public void ThenEmptyMessageTextDisplayedForWidget(string message, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetWidgetEmptyMessageByName(widgetName).Text, Is.EqualTo(message), "Widget message is different.");
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

                Verify.That(page.GetFocusedPointHover(row["WidgetName"]), Is.EqualTo(row["Tooltip"]));
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

        [Then(@"Line chart displayed in '(.*)' widget")]
        public void LineChartDisplayedInWidget(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.IsLineWidgetPointsAreDisplayed(widgetName), Is.True, "Points are not displayed");
        }

        [Then(@"Line X labels of '(.*)' widget is displayed in following order:")]
        public void ThenLineLabelsIsDisplayedInFollowingOrder(string widgetName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            List<string> labelList = page.GetPointOfLineWidgetByName(widgetName);
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();

            Verify.AreEqual(expectedList, labelList, "Label order is incorrect");
        }

        [Then(@"Line X labels of '(.*)' column widget is displayed in following order:")]
        public void ThenLineXLabelsOfColumnWidgetIsDisplayedInFollowingOrder(string widgetName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            List<string> labelList = page.GetPointOfColumnWidgetByName(widgetName);
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();

            Verify.AreEqual(expectedList, labelList, "Label order is incorrect");
        }

        //TODO does it make sense to make this step more generic?
        [When(@"User clicks '(.*)'  button on the Dashboards page")]
        public void WhenUserClicksButtonOnTheDashboardsPage(string buttonName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetTopBarActionButton(buttonName).Click();
        }

        //TODO does it make sense to make this step more generic?
        [Then(@"User sees '(.*)' tooltip for '(.*)' on the Dashboard")]
        public void ThenUserSeesTooltipForButtons(string tooltip, string buttonName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(page.GetTopBarActionButton(buttonName));
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(tooltip, toolTipText, "Tooltip is incorrect");
        }

        [Then(@"Print Preview is displayed to the User")]
        public void ThenPrintPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            Verify.IsTrue(page.PrintPreviewSettingsPopUp.Displayed(), "Print Preview is not Displayed");
            Verify.IsTrue(page.DashWorksPrintLogo.Displayed(), "Dashworks logo isn't displayed");
            Verify.IsTrue(page.PrintPreviewWidgets.Displayed, "Print preview widgets aren't displayed");
        }

        [Then(@"There is no breadcrumbs displayed on Dashboard page")]
        public void ThereIsNoBreadcrumbsDisplayedOnDashboardPage()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            Verify.That(page.PrintBreadcrumbs.Displayed(), Is.False, "Print Preview displayed with breadcrumbs");
        }

        [When(@"User selects '(.*)' option in the '(.*)' dropdown for Print Preview Settings")]
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
            Verify.IsTrue(page.A4PrintPreviewView.Displayed, "Print Preview is not displayed in A4 format view");
        }

        [Then(@"Print Preview is displayed in Letter format view")]
        public void ThenPrintPreviewIsDisplayedInLetterFormatView()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Verify.IsTrue(page.LetterPrintPreviewView.Displayed, "Print Preview is not displayed in Letter format view");
        }

        [Then(@"Print Preview is displayed in Portrait orientation")]
        public void ThenPrintPreviewIsDisplayedInPortraitOrientation()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Verify.IsTrue(page.PortraitPrintPreviewOrientation.Displayed, "Print Preview is not displayed in Portrait orientation");
        }

        [Then(@"Print Preview is displayed in Landscape orientation")]
        public void ThenPrintPreviewIsDisplayedInLandscapeOrientation()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            //Wait for style changing
            Thread.Sleep(500);
            Verify.IsTrue(page.LandscapePrintPreviewOrientation.Displayed, "Print Preview is not displayed in Landscape orientation");
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
            Verify.IsTrue(page.DataLabels.Displayed(), "Data Labels are not displayed");
        }

        [Then(@"'(.*)' data label is displayed on the Dashboards page")]
        public void ThenDataLabelIsDisplayedOnTheDashboardsPage(string text)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.DataLabels.Text, Is.EqualTo(text), $"{text} data label is not displayed");
        }

        [Then(@"Move to Section pop up is displayed to the User")]
        public void ThenMoveToSectionPopUpIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsTrue(page.MoveToSectionPopUp.Displayed(), "Move to Section pop up is not displayed");
        }

        [Then(@"Move to Section pop up is not displayed to the User")]
        public void ThenMoveToSectionPopUpIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsFalse(page.MoveToSectionPopUp.Displayed(), "Move to Section pop up is displayed");
        }

        [When(@"User selects '(.*)' section on the Move to Section pop up")]
        public void WhenUserSelectsSectionOnTheMoveToSectionPopUp(string sectionName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.SelectSectionToMove(sectionName);
        }

        [When(@"User clicks '(.*)' button on the Move to Section Pop up")]
        public void WhenUserClicksButtonOnTheMoveToSectionPopUp(string buttonName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.ClickMoveToSectionPopUpButton(buttonName);
        }

        [Then(@"There are no links placed in '(.*)' Widget")]
        public void ThereAreNoLinksPlacedInWidget(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.GetWidgetLinks(widgetName).Count, Is.EqualTo(0), $"Found some links in widget");
        }

        [Then(@"'(.*)' color displayed for '(.*)' value in table '(.*)' widget")]
        public void ThenNextColorDisplayedForValueInWidget(string color, string value, string widget)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.GetTableGridValues(widget)
                .Select(x => x.Text.Equals(value) && x.GetAttribute("style").Contains(ColorsConvertor.ConvertToHex(color))).Count(), Is.GreaterThan(0), $"Wrong color detected");
        }

        #region Dashboards details

        [When(@"User changes dashboard name to '(.*)'")]
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
            Verify.That(page.DefaultDashboardCheckbox.GetAttribute("disabled"), Is.EqualTo("true"), $"Default dashboard displayed enabled");
        }

        [Then(@"Default dashboard checkbox displayed checked in Dashboard details")]
        public void ThenDefaultDashboardCheckboxDisplayedChecked()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.DefaultDashboardCheckbox.Selected, Is.EqualTo(true), $"Default dashboard displayed deselected");
        }

        [When(@"User select '(.*)' sharing option on the Dashboards page")]
        public void WhenUserSelectSharingOptionOnTheDashboardsPage(string option)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            _driver.SelectCustomSelectbox(page.SharingDropdown, option);
        }

        [Then(@"Permission '(.*)' displayed in Dashboard Details")]
        public void ThenDashboardShowsPermissionToTheUser(string permission)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.SharingDropdownPermissionValue.Text, Is.EqualTo(permission), $"Permission {permission} was not the same in Dashboard Details");
        }


        [Then(@"Review Widget List Permissions is displayed to the User")]
        public void ThenReviewWidgetListPermissionsIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsTrue(page.ReviewWidgetListPermissionsPopUp.Displayed(), "Review Widget List Permissions is not displayed");
        }

        [Then(@"Review Widget List Permissions is not displayed to the User")]
        public void ThenReviewWidgetListPermissionsIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.IsFalse(page.ReviewWidgetListPermissionsPopUp.Displayed(), "Review Widget List Permissions is displayed");
        }


        [Then(@"Widget '(.*)' displayed for '(.*)' list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsWidgetNameToTheUser(string widget, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.WidgetValueForList(listName).Text, Is.EqualTo(widget), $"Widget name {widget} was not found in Review Permissions popup");
        }

        [Then(@"Current user displayed for '(.*)' list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsCurrentUserNameToTheUser(string listName)
        {
            var header = _driver.NowAt<HeaderElement>();
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.OwnerValueForList(listName).Text,
                Is.EqualTo(header.UserNameDropdown.Text), $"Owner name was not found in Review Permissions popup");
        }

        [Then(@"User '(.*)' displayed for '(.*)' list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsUserNameToTheUser(string user, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.OwnerValueForList(listName).Text,
                Is.EqualTo(user), $"User name was not found in Review Permissions popup");
        }

        [Then(@"Current permission '(.*)' displayed for '(.*)' list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsCurrentPermissionToTheUser(string permission, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.CurrentPermissionValueForList(listName).Text,
                Is.EqualTo(permission), $"Current permission {permission} was not found in Review Permissions popup");
        }

        [Then(@"New Permission '(.*)' displayed for '(.*)' list on Permissions Pop-up")]
        public void ThenListPermissionsPopupShowsNewPermissionToTheUser(string permission, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.NewPermissionsValueForList(listName).Text, Is.EqualTo(permission), $"New permission {permission} was not found in Review Permissions popup");
        }

        [Then(@"User sees next options of New Permission field for '(.*)' list on Permissions Pop-up")]
        public void ThenUserSeesNexPermissionOptionsInWidgetListPermissions(string listName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.NewPermissionsDropdownForList(listName).Click();

            Thread.Sleep(1000);
            List<string> options = page.ReviewWidgetListPermissionExpandedOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Assert.That(options.FindAll(x => x.Equals(row["Options"])).Count == 1, "PLEASE ADD EXCEPTION MESSAGE");
            }
            Verify.That(options.Count, Is.EqualTo(table.Rows.Count));

            //hide menu
            page.SelectDoNotChangeReviewPermission();
        }

        [When(@"User selects '(.*)' permission for '(.*)' list on Permissions Pop-up")]
        public void WhenUserSelectsPermissionOnTheListPermissionsPopup(string option, string list)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _driver.WaitForDataLoading();
            _driver.SelectCustomSelectbox(page.NewPermissionsDropdownForList(list), option);
            _driver.WaitForDataLoading();
        }

        [Then(@"New Permission dropdown has disabled property '(.*)' for '(.*)' list on Permissions Pop-up")]
        public void ThenUserSeesNewPermissionDropdownInNextStateForListOnListPermissionsPopup(string state, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetDropdownStateOfReviewWidgetPermissionsPopup(listName),
                Is.EqualTo(state.ToUpper()), $"New permission {state} states is different");
        }

        [Then(@"New Permission dropdown has '(.*)' tooltip for '(.*)' list on Permissions Pop-up")]
        public void ThenTooltipIsDisplayedWithTextForPermissionDropdown(string tooltip, string listName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(page.NewPermissionsDropdownForList(listName));
            var toolTipText = _driver.GetTooltipText();
            Verify.That(tooltip, Is.EqualTo(toolTipText), "Tooltip is different");
        }

        [Then(@"Button '(.*)' has enabled property '(.*)' on Permissions Pop-up")]
        public void ThenUserSeesButtonInTheNextStateForListOnListPermissionsPopup(string buttonCapture, string buttonState)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetButtonStateOfReviewWidgetPermissionsPopup(buttonCapture),
                Is.EqualTo(buttonState.ToUpper()), $"Button {buttonCapture} states is different");
        }

        [Then(@"Button '(.*)' has '(.*)' tooltip on Permissions Pop-up")]
        public void ThenTooltipIsDisplayedWithTextForForButtonOnListPermissionsPopup(string buttonCapture, string tooltip)
        {
            var button = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.MouseHover(button.ReviewPermissionsPopupsButton(buttonCapture));
            _driver.WaitForDataLoading();
            var toolTipText = _driver.GetTooltipText();
            Verify.That(tooltip, Is.EqualTo(toolTipText), "Tooltip is different");
        }

        [When(@"User clicks the '(.*)' button on Permissions Pop-up")]
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

            List<string> options = page.DashboardMenuItems.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Verify.That(options.FindAll(x => x.Equals(row["OptionsName"])).Count == 1,
                    "PLEASE ADD EXCEPTION MESSAGE");
            }
            Verify.That(options.Count, Is.EqualTo(table.Rows.Count));
        }

        [When(@"Dashboard page loaded")]
        public void ThenUserSeesDashboardPageOpened()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.EditModeOnOffTrigger);
            _driver.WaitForDataLoading();
        }

        [Then(@"User clicks on Dashworks logo")]
        public void ThenUserClicksOnDashworksLogo()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            try
            {
                page.DashWorksPrintLogo.Click();
            }
            catch (System.Reflection.TargetInvocationException)
            {
                return;
            }
            throw new Exception("Dashworks Logo on Print Preview page is clickable");
        }

        #endregion
    }
}