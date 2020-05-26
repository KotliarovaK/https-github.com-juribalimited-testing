using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.Dashboards;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_DashboardsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Dashboards _dashboard;
        private readonly SectionsAndWidgetsCount _sectionsAndWidgets;
        private readonly UserDto _user;

        public EvergreenJnr_DashboardsPage(RemoteWebDriver driver, DTO.RuntimeVariables.Dashboards dashboard, SectionsAndWidgetsCount sectionsAndWidgets,
            UserDto user)
        {
            _driver = driver;
            _dashboard = dashboard;
            _sectionsAndWidgets = sectionsAndWidgets;
            _user = user;
        }

        #region Top row

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
            _driver.WaitForDataLoading();

            if (_driver.IsElementDisplayed(page.ExpandSideNavPanelIcon))
            {
                page.ExpandSideNavPanelIcon.Click();
            }
        }

        [Then(@"There is no breadcrumbs displayed on Dashboard page")]
        public void ThereIsNoBreadcrumbsDisplayedOnDashboardPage()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            Verify.That(page.PrintBreadcrumbs.Displayed(), Is.False, "Print Preview displayed with breadcrumbs");
        }

        //TODO does it make sense to make this step more generic?
        [When(@"User clicks '(.*)' button on the Dashboards page")]
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

        #endregion

        #region Dashboards panel

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

        [Then(@"User sees Dashboards sub menu on Dashboards page")]
        public void ThenUserSeesDashboardsSubMenuOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.DashboardsPanel.Displayed(), Is.True);
        }

        [Then(@"Dashboards sub menu is hidden on Dashboards page")]
        public void ThenDashboardsSubMenuIsHiddenOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.DashboardsPanel.Displayed(), Is.False);
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

        #endregion

        #region Details panel

        [When(@"User changes dashboard name to '(.*)'")]
        public void WhenUserChangesDashboardNameTo(string dashboardName)
        {
            var dashboardDetailsElement = _driver.NowAt<EvergreenDashboardsPage>();
            dashboardDetailsElement.DetailsDashboardName.Clear();
            dashboardDetailsElement.DetailsDashboardName.SendKeys(dashboardName);

            //Wait for auto save action, no indicators available
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitFor(()=> listElement.GetAllListNames().Select(title => title).ToList().Contains(dashboardName));
        }

        [When(@"User expands the list of shared lists")]
        public void UserExpandsTheListOfSharedLists()
        {
            var dash = _driver.NowAt<EvergreenDashboardsPage>();
            dash.DetailsExpandListsButton.Click();
            _driver.WaitForElementsToBeDisplayed(dash.DetailsSharedListTableHeaders);
        }

        [Then(@"User sees table headers as '(.*)' and '(.*)'")]
        public void UserSeesTableHeadersAs(string a, string b)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementsToBeDisplayed(page.DetailsSharedListTableHeaders);
            Verify.That(page.DetailsSharedListTableHeaders.Select(x => x.Text).ToList(), Is.EqualTo(new List<string> { a, b }), "Headers are different");
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

        #endregion

        #region WidgetArea Management

        [When(@"Dashboard page loaded")]
        public void ThenUserSeesDashboardPageOpened()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForElementToBeDisplayed(page.EditModeOnOffTrigger);
            _driver.WaitForDataLoading();
        }

        [Then(@"User sees '(.*)' widget placed in '(.*)' section")]
        public void ThenUserSeesWidgetPlacedInCorrectSection(string widgetName, string sectionNumber)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            ThenUserSeesDashboardPageOpened();
            var currentNumber = int.Parse(page.GetSectionNumberByWidgetName(widgetName)) + 1;
            Verify.That(sectionNumber, Is.EqualTo(currentNumber.ToString()), "Wrong section number");
        }

        [When(@"User clicks menu for section with '(.*)' widget")]
        public void ClickSectionMenuByWidgetName(string widgetName)
        {
            var dash = _driver.NowAt<EvergreenDashboardsPage>();
            ThenUserSeesDashboardPageOpened();
            dash.GetSectionMenuByWidgetName(widgetName).Click();
        }

        [When(@"User clicks menu for '(.*)' widget")]
        public void ClickWidgetMenuByWidgetName(string widgetName)
        {
            var dash = _driver.NowAt<EvergreenDashboardsPage>();
            ThenUserSeesDashboardPageOpened();
            dash.GetEllipsisMenuForWidget(widgetName).Click();
        }

        
        [When(@"User clicks '(.*)' menu option for section with '(.*)' widget")]
        public void WhenUserClicksMenuOptionForSectionWithWidget(string menuOption, string widgetName)
        {
            ClickSectionMenuByWidgetName(widgetName);

            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetMenuButtonByName(menuOption).Click();
        }

        [When(@"User clicks '(.*)' menu option for '(.*)' widget")]
        public void WhenUserClicksMenuOptionForWidget(string menuOption, string widgetName)
        {
            ClickWidgetMenuByWidgetName(widgetName);

            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetMenuButtonByName(menuOption).Click();
        }

        [Then(@"'(.*)' menu item for '(.*)' widget is disabled and has '(.*)' tooltip")]
        public void WidgetMenuItemIsDisabledAndHasTooltip(string menuItem, string widgetName, string tooltip)
        {
            ClickWidgetMenuByWidgetName(widgetName);
            DisabledMenuItemHasNextTooltip(menuItem, tooltip);
        }

        private void DisabledMenuItemHasNextTooltip(string menuItem, string tooltip)
        {
            var dash = _driver.NowAt<EvergreenDashboardsPage>();
            var item = dash.GetDisabledMenuItemByName(menuItem);
            Verify.IsTrue(item.Displayed(), $"{menuItem} menu item is enabled");

            _driver.MouseHover(item);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(tooltip, toolTipText, "Tooltip text is not correctly");

            var body = _driver.NowAt<BaseGridPage>();
            _driver.ClickByActions(body.BodyContainer);
        }

        [Then(@"User sees following items for expanded menu:")]
        public void WhenUserSeesFollowingMenuItemsOnPage(Table items)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            for (var i = 0; i < items.RowCount; i++)
                Verify.That(page.EllipsisMenuItems[i].Text, Is.EqualTo(items.Rows[i].Values.FirstOrDefault()),
                    "Items are not the same");
        }

        [When(@"User sets expand status to '(.*)' for '(.*)' section")]
        public void WhenUserExpandsOrCollapseSectionByName(string status, string sectionName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.SetSectionExpandStatusTo(sectionName, status);
        }

        [Then(@"User sees '(.*)' description for '(.*)' section")]
        public void ThenUserSeesSectionDescriptionBySectionName(string description, string section)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.SectionDescriptionByName(section), Is.EqualTo(description), "Description are not the same");
        }

        [When(@"User clicks '(.*)' link in description for '(.*)' section")]
        public void WhenUserSeesLinkDescriptionBySectionName(string link, string section)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.SectionDescriptionLinkByName(section, link).Click();
        }

        //works for 3 widgets only
        [Then(@"Listed widgets are placed by '(.*)' in line:")]
        public void ThenListedWidgetsArePlacedOnTheSameLine(string nPerLine, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            List<int> y_coordinates = new List<int>();

            var widgets = table.Rows.SelectMany(row => row.Values).ToList();

            foreach (var widget in widgets)
            {
                y_coordinates.Add(page.GetWidget(widget).Location.Y);
            }

            switch (nPerLine)
            {
                case ("3"):
                {
                    Verify.That(y_coordinates.Any(o => o != y_coordinates[0]), Is.False, "Y coordinates are different");
                    break;
                }

                case ("1"):
                {
                    Verify.That(y_coordinates.Distinct().ToList().Count.Equals(y_coordinates.Count), Is.True, "some of Y coordinates are same");
                    break;
                }

                default:
                    throw new Exception($"'{nPerLine}' is not one of expected");
            }
        }

        //TODO TEMPORARY SOLUTION
        [When(@"User clicks Hide section checkbox on Edit Section page")]
        public void WhenUserClicksHideSectionCheckboxOnEditSection()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.SectionHideSectionCheckbox.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"User sees Ellipsis icon enabled for '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconEnabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.GetEllipsisMenuForWidget(widgetName).Displayed(), Is.True);
        }

        [Then(@"User sees Ellipsis icon disabled for '(.*)' Widget on Dashboards page")]
        public void ThenUserSeesEllipsisIconDisabledForWidgetOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetEllipsisMenuForWidget(widgetName), Is.Null);
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

            Verify.That(page.GetExpandCollapseIconsForSectionsHavingWidget(widgetName).FirstOrDefault().Displayed(),
                Is.True);
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


        [When(@"User remembers number of Sections and Widgets on Dashboards page")]
        public void WhenUserRemembersNumberOfSectionsAndWidgetsOnDashboardsPage()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _sectionsAndWidgets.SectionsCount = page.AllSections.Count;
            _sectionsAndWidgets.WidgetsCount = page.AllWidgetsTitles.Count;
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

        [When(@"User clicks ADD WIDGET button for '(.*)' Section on Dashboards page")]
        public void WhenUserClicksButtonForSectionOnDashboardsPage(int section)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            page.GetAddWidgetButtons().ElementAt(section - 1).Click();
        }

        [Then(@"Widget with the name '(.*)' is missing")]
        public void ThenUserCantSeeWidgetWithTheNextNameOnDashboardsPage(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.AllWidgetsTitles.Select(x => x.Text).ToList(), Does.Not.Contain(widgetName),
                "Widget name is missing");
        }

        [Then(@"User sees '(.*)' widgets with '(.*)' name on Dashboards page")]
        public void WhenUserSeesOnlyNumberWidgetsWithNameOnDashboardsPage(int numberOfWidgets, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.AllWidgetsTitles.Select(x => x.Text.Equals(widgetName)).ToList().Count, Is.EqualTo(numberOfWidgets), $"More than {numberOfWidgets} widgets were displayed.");
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

        [Then(@"User sees '(.*)' text in warning message of '(.*)' widget on Dashboards page")]
        public void ThenUserSeesTextInWarningMessageOfWidgetOnDashboardsPage(string message, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.AreEqual(message, page.TextInDeleteAlert(widgetName).Text, "Delete confirmation text is different");
        }

        [Then(@"'(.*)' message is displayed in '(.*)' widget")]
        public void ThenEmptyMessageTextDisplayedForWidget(string message, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetWidgetEmptyMessageByName(widgetName).Text, Is.EqualTo(message), "Widget message is different.");
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
            Verify.AreEqual(text, page.DashboardsAlert.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        #endregion

        #region WidgetItem

        [Then(@"User sees Widget square colored in amber")]
        public void ThenWidgetDeleteSquareColoredInAmber()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetDeleteWidgetAreaColor(), Is.EqualTo("rgba(235, 175, 37, 1)"),
                "Wrong widget delete message color");
        }

        [Then(@"User sees '(.*)' Widgets with Legend on Dashboards page")]
        public void WhenUserRemembersNumberOfWidgetsWithLegendOnDashboardsPage(string expected)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            Verify.That(page.NumberOfWidgetLegends.Count.ToString(), Is.EqualTo(expected),
                "Number of Widgets with Legend is different");
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
            _driver.WaitForElementToBeDisplayed(page.GetWidget(widgetName));
            Verify.IsTrue(page.GetWidget(widgetName).Displayed(), $"{widgetName} Widget is not displayed");
        }

        [Then(@"Label '(.*)' displayed for '(.*)' widget")]
        public void ThenWidgetLabelContainsLabel(string label, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.GetWidgetLabels(widgetName).Select(x => x.Text).ToList(),
                Does.Contain(label), $"'{label}' label is not found");
        }

        [Then(@"Data Legends values are displayed in '(.*)' widget on the Dashboard page")]
        public void ThenDataLegendsValuesAreDisplayedInWidgetOnThePreviewPage(string widgetName, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var expectedLabels = table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault());
            var actualLabels = page.GetWidgetLabels(widgetName).Select(x => x.Text).ToList();

            Verify.AreEqual(expectedLabels, actualLabels, $"The label(s) was not found in '{widgetName}'");
        }

        [Then(@"'(.*)' Widget has no duplicates in Data Legends")]
        public void ThenDataLegendsValuesHasNoDuplicates(string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var actualLabels = page.GetWidgetLabels(widgetName).Select(x => x.Text).ToList();

            //Get all elements that has more than one occurence in the list
            var duplicates = page.GetWidgetLabels(widgetName).GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1).ToList();

            Verify.That(duplicates.Any(), Is.False, $"Legends has duplicates");
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
                Verify.AreEqual(tableContent, originalList, "Unexpected column");
            }
        }

        [Then(@"'(.*)' color is displayed for Card Widget")]
        public void ThenColorIsDisplayedForCardWidget(string color)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            var getColor = page.GetWidgetText().GetCssValue("color");
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
            var headers = page.GetTableWidgetHorizontalHeaders(widget);

            Verify.That(headers.Select(x => x.Text).ToList().FindAll(x => x.ToLower().Contains(column.ToLower())).Count(), Is.EqualTo(0), $"Table contains {column} header");
        }

        [Then(@"Headers of '(.*)' table widget with '(.*)' orientation are placed in the next order:")]
        public void ThenHeadersOfTableWidgetArePlacedInNextOrder(string widget, string orientation, Table table)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();
            List<string> headers;

            switch (orientation.ToLower())
            {
                case ("horizontal"):
                    headers = page.GetTableWidgetHorizontalHeaders(widget).Select(column => column.Text).ToList();
                    break;

                case ("vertical"):
                    headers = page.GetTableWidgetVerticalHeaders(widget).Select(column => column.Text).ToList();
                    break;

                default:
                    throw new Exception($"'{orientation}' is not defined orientation");
            }


            var expectedTable = table.Rows.SelectMany(row => row.Values);

            Verify.That(headers, Is.EqualTo(expectedTable), $"Table orders is wrong");
        }

        [When(@"User clicks data in card '(.*)' widget")]
        public void WhenUserClicksDataInCardWidget(string widgetTitle)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetCardWidgetContent(widgetTitle).Click();
        }

        [When(@"User clicks text in card widget")]
        public void WhenUserClicksTextInCardWidget()
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetWidgetText().Click();
        }

        [Then(@"Value '(.*)' is displayed in the card '(.*)' widget")]
        public void ValueIsDisplayedInCardWidget(string value, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            Verify.That(page.GetCardWidgetContent(widgetName).Text, Is.EqualTo(value), "Card value is different.");
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

        [Then(@"'(.*)' value displayed without color in table '(.*)' widget")]
        public void ThenNextColorDisplayedForValueInWidget(string value, string widget)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.IsComplianceValueHasColorPoint(widget, value), Is.False, $"Color point is displayed for {value}");
        }

        [Then(@"User sees color code '(.*)' on the '(.*)' widget")]
        public void ThenNextColorDisplayedForWidget(string colorCode, string widget)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            _driver.WaitForDataLoading();

            Verify.That(page.IsChartHasSpecifiedColor(widget, ColorsConvertor.ConvertToHex(colorCode)), Is.True, "Color is missing");
        }

        [When(@"User clicks on '(.*)' data label of '(.*)' widget")]
        public void ThenUserClicksOnDataLabelOfWidget(string label, string widget)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.GetDataLabel(widget, label).Click();
        }

        #endregion

        #region Permission popup

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

        #endregion

        #region Print

        [Then(@"Print Preview is displayed to the User")]
        public void ThenPrintPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            Verify.IsTrue(page.PrintPreviewSettingsPopUp.Displayed(), "Print Preview is not Displayed");
            Verify.IsTrue(page.DashWorksPrintLogo.Displayed(), "Dashworks logo isn't displayed");
            Verify.IsTrue(page.PrintPreviewWidgets.Displayed, "Print preview widgets aren't displayed");
        }

        [When(@"User selects '(.*)' option in the '(.*)' dropdown for Print Preview Settings")]
        public void WhenUserSelectsOptionInTheDropdownForPrintPreviewSettings(string option, string dropdown)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SelectDropdown(option, dropdown);
        }

        [Then(@"Print Preview is displayed in '(.*)' format and '(.*)' layout view")]
        public void ThenPrintPreviewIsDisplayedInFormatView(string format, string layout)
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.PrintPreview(format, layout).Displayed, Is.True, $"Print preview in {format} {layout} not displayed");
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

        [When(@"User clicks Cancel button on the Print Preview Settings pop-up")]
        public void WhenUserClicksCancelButtonOnThePrintPreviewSettingsPop_Up()
        {
            var page = _driver.NowAt<PrintDashboardsPage>();
            page.CancelButton.Click();
        }

        #endregion
    }
}