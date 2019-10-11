using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ActionsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ActionsPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Actions panel is displayed to the user")]
        public void ThenActionsPanelIsDisplayedToTheUser()
        {
            var panel = _driver.NowAt<ActionsPanelElement>();
            Verify.IsTrue(panel.ActionsPanel.Displayed(),
                "Actions panel was not displayed");

            Verify.IsTrue(panel.IsPanelOpened("Actions"),
                "Action panel is not opened");

            var button = _driver.NowAt<BaseHeaderElement>();
            Verify.IsTrue(button.ActionsButton.IsElementActive(),
                "Action button is not active");
        }

        [Then(@"Actions panel is not displayed to the user")]
        public void ThenActionsPanelIsNotDisplayedToTheUser()
        {
            var button = _driver.NowAt<BaseHeaderElement>();
            Verify.IsFalse(button.ActionsButton.IsElementActive(),
                "Action button is active");

            var panel = _driver.NowAt<BaseRightSideActionsPanel>();
            Verify.IsFalse(panel.IsPanelOpened("Actions"),
                "Action panel is opened");
        }

        [Then(@"Actions message container is displayed to the user")]
        public void ThenActionsMessageContainerIsDisplayedToTheUser()
        {
            var columnElement = _driver.NowAt<ActionsElement>();
            Verify.IsTrue(columnElement.ActionsContainerMessage.Displayed(),
                "Actions message container was not displayed");
            Logger.Write("Actions message container is visible");
        }

        [When(@"User is deselect all rows")]
        [When(@"User select all rows")]
        public void WhenUserSelectAllRows()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            dashboardPage.SelectAllCheckbox.Click();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
        }

        [When(@"User selects ""(.*)"" option in ""(.*)"" drop-down on Action panel")]
        public void WhenUserSelectsOptionInDrop_DownOnActionPanel(string option, string fieldName)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetDropdownOnActionPanelByName(fieldName).Click();
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetDropdownValueByName(option).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"following values are displayed in ""(.*)"" drop-down on Action panel:")]
        public void ThenFollowingValuesAreDisplayedInDrop_DownOnActionPanel(string fieldName, Table table)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetDropdownOnActionPanelByName(fieldName).Click();
            var action = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, $"Values in {fieldName} drop-down are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"following values are presented in ""(.*)"" drop-down on Action panel:")]
        public void ThenFollowingValuesArePresentedInDrop_DownOnActionPanel(string fieldName, Table table)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetDropdownOnActionPanelByName(fieldName).Click();
            var action = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();

            foreach (var expectedIem in expectedList)
            {
                Assert.That(actualList.Contains(expectedIem), Is.True, $"Values in {fieldName} drop-down is missing");
            }

            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"following values are not presented in ""(.*)"" drop-down on Action panel:")]
        public void ThenFollowingValuesAreNotPresentedInDrop_DownOnActionPanel(string fieldName, Table table)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetDropdownOnActionPanelByName(fieldName).Click();
            var action = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();

            foreach (var expectedIem in expectedList)
            {
                Assert.That(actualList, Does.Not.Contain(expectedIem), $"Values in {fieldName} drop-down is displayed");
            }

            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        //TODO looks like this section should be moved to BaseDashboard
        #region Action button

        [Then(@"""(.*)"" button is displayed without tooltip on Update form")]
        public void ThenUpdateButtonIsDisplayedWithoutTooltipOnUpdateForm(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            var button = action.GetButtonByName(buttonName);

            _driver.MouseHover(button);
            Verify.IsFalse(_driver.IsTooltipDisplayed(), "Tooltip for Update button displayed");
        }

        [When(@"User selects 'Save as new pilot' option")]
        public void WhenUserSelectsSaveAsNewPilotOption()
        {
            var action = _driver.NowAt<PivotElementPage>();
            action.SaveNewListButton.Click();
        }

        [Then(@"""(.*)"" Action button is displayed")]
        public void ThenActionButtonIsDisplayed(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(button.GetButtonByName(buttonName).Displayed(), $"{buttonName} Action button is not displayed");
        }

        [Then(@"""(.*)"" Action button is not displayed")]
        public void ThenActionButtonIsNotDisplayed(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(button.GetButtonByName(buttonName).Displayed(), $"{buttonName} Action button is displayed");
        }

        [Then(@"""(.*)"" Action button is disabled")]
        public void ThenActionButtonIsDisabled(string buttonName)
        {
            Verify.IsTrue(IsButtonDisabled(buttonName), $"{buttonName} Button state is not disabled");
        }

        [Then(@"""(.*)"" Action button is enabled")]
        public void ThenActionButtonIsEnabled(string buttonName)
        {
            Utils.Verify.IsFalse(IsButtonDisabled(buttonName), $"{buttonName} Button state is not enabled");
        }

        private bool IsButtonDisabled(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetButtonByName(buttonName).GetAttribute("disabled");
            if (buttonState == null)
                return false;
            else
                return bool.Parse(buttonState);
        }

        [Then(@"""(.*)"" Action button is active")]
        public void ThenActionButtonIsActive(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetButtonByName(buttonName).GetAttribute("disabled");
            Verify.AreNotEqual(buttonState, "true", $"{buttonName} Button state is incorrect");
        }

        [Then(@"'(.*)' Action button has tooltip with '(.*)' text")]
        public void ThenActionButtonHasTooltipWithText(string buttonName, string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetButtonByName(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.AreEqual(text, toolTipText, "Tooltip is incorrect");
        }

        #endregion

        [Then(@"""(.*)"" button is not displayed")]
        public void ThenButtonIsNotDisplayed(string buttonName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(page.GetButtonByName(buttonName).Disabled(), $"{buttonName} is displayed");
        }

        //TODO move this this actionPanel
        [Then(@"Actions menu is not displayed to the user")]
        public void ThenActionsMenuIsNotDisplayedToTheUser()
        {
            var action = _driver.NowAt<ActionPanelPage>();
            Verify.IsFalse(action.ActionsDropDown.Displayed(), "Actions menu is displayed");
        }

        [Then(@"Objects to add panel is disabled")]
        public void ThenObjectsToAddPanelIsDisabled()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(component.DisabledObjectsToAddPanel.Displayed(), "Objects to add panel is active");
        }

        [Then(@"Objects to add panel is active")]
        public void ThenObjectsToAddPanelIsActive()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(component.ActiveObjectsToAddPanel.Displayed(), "Objects to add panel is active");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on Action panel")]
        public void ThenWarningMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.WarningMessageText);
            Verify.AreEqual(textMessage, action.WarningMessageText.Text, $"{textMessage} in Warning message is not displayed");
        }

        //TODO this method should be replaced by more generic
        [Then(@"the amber message is displayed correctly")]
        public void ThenTheAmberMessageIsDisplayedCorrectly()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(action.WarningMessage.Displayed(), "Amber message is not displayed");
            Verify.IsTrue(action.UpdateButtonOnAmberMessage.Displayed(), "Update Button is not displayed");
            Verify.IsTrue(action.CancelButtonOnAmberMessage.Displayed(), "Cancel Button is not displayed");
        }

        //TODO this method should be replaced by more generic
        [Then(@"the amber message is not displayed")]
        public void ThenTheAmberMessageIsNotDisplayed()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsFalse(action.WarningMessage.Displayed(), "Amber message is displayed");
        }

        [Then(@"Success message with ""(.*)"" text is displayed on Action panel")]
        public void ThenSuccessMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.SuccessMessage);
            Verify.AreEqual(textMessage, action.SuccessMessage.Text, $"{textMessage} are not equal");
            //Verify.IsTrue(action.CloseButtonInSuccessMessage.Displayed(),
            //"Close button in Success message is not displayed");
        }

        [Then(@"Success message is hidden after five seconds")]
        public void ThenSuccessMessageIsHiddenAfterFiveSeconds()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(action.SuccessMessage.Displayed(), "Success message is not displayed");
            Thread.Sleep(7000);
            Verify.IsFalse(action.SuccessMessage.Displayed(), "Success message is displayed for more than 5 seconds");
        }

        [Then(@"Checkboxes are not displayed")]
        public void ThenCheckboxesAreNotDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(dashboardPage.Checkbox.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Verify.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [When(@"User select ""(.*)"" rows in the grid")]
        public void WhenUserSelectRowsInTheGrid(string columnName, Table table)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var columnContent = dashboardPage.GetColumnContent(columnName);
            foreach (var row in table.Rows)
            {
                var rowIndex = columnContent.IndexOf(row["SelectedRowsName"]);
                if (rowIndex < 0)
                    throw new Exception($"'{row["SelectedRowsName"]}' is not found in the '{columnName}' column");
                _driver.WaitForDataLoading();
                _driver.ClickByJavascript(dashboardPage.SelectRowsCheckboxes.ElementAt(rowIndex));
            }
        }

        [Then(@"User removes selected rows")]
        public void WhenUserIsRemovedSelectedRows()
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            _driver.SelectCustomSelectbox(actionsElement.DropdownBox, "Remove from static list");
            actionsElement.RemoveButton.Click();
        }

        [Then(@"Date column shows Date and Time values")]
        public void ThenDateColumnShowsDateAndTimeValues()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(dashboardPage.DateTimeColumnValue.Displayed(), "Date column does not shows Date and Time values");
        }

        [Then(@"User add selected rows in ""(.*)"" list")]
        public void ThenUserAddSelectedRowsInList(string listName)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            _driver.SelectCustomSelectbox(actionsElement.DropdownBox, "Add to static list");
            actionsElement.SelectList(listName);
            actionsElement.AddButton.Click();
        }

        [Then(@"User selects ""(.*)"" List in Saved List dropdown")]
        public void ThenUserSelectsListInSavedListDropdown(string listName)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            actionsElement.SelectList(listName);
        }

        [Then(@"Select All selectbox is checked")]
        public void ThenSelectAllSelectboxIsChecked()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            //_driver.WaitToBeSelected(dashboardPage.SelectAllCheckbox, true);
            Utils.Verify.IsTrue(dashboardPage.SelectAllCheckboxState.GetAttribute("aria-checked").Equals("true"), "Select All checkbox is unchecked");
        }

        [Then(@"Select All selectbox is unchecked")]
        public void ThenSelectAllSelectboxIsUnchecked()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.WhatForElementToBeSelected(dashboardPage.SelectAllCheckbox, false);
            Utils.Verify.IsTrue(dashboardPage.SelectAllCheckboxState.GetAttribute("aria-checked").Equals("false"), "Select All checkbox is checked");
        }

        [Then(@"""(.*)"" selected rows are displayed in the Actions panel")]
        public void ThenSelectedRowsAreDisplayedInTheActionsPanel(string selectedRowsCount)
        {
            var actionsPanel = _driver.NowAt<ActionsElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
            //Delete 'if' after the row selection will be faster
            if (actionsPanel.ActionsSpinner.Displayed())
            {
                Thread.Sleep(3000);
                Utils.Verify.AreEqual(selectedRowsCount, actionsPanel.GetSelectedRowsCount(),
                    $"Number of rows is not {selectedRowsCount}");
            }
            else
            {
                Thread.Sleep(5000);//wait after deselecting All check-box. Currently uncheck runs immediately and no loading indicators appear
                Utils.Verify.AreEqual(selectedRowsCount, actionsPanel.GetSelectedRowsCount(),
                    $"Number of rows is not {selectedRowsCount}");
            }
        }

        [Then(@"The number of rows selected matches the number of rows of the main object list")]
        public void ThenTheNumberOfRowsSelectedMatchesTheNumberOfRowsOfTheMainObjectList()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(dashboardPage.ResultsOnPageCount);
            if (!dashboardPage.ResultsOnPageCount.Text.Split(' ').Any() &&
                string.IsNullOrEmpty(dashboardPage.ResultsOnPageCount.Text.Split(' ').First()))
                throw new Exception("Rows count in table is missed");
            var numberOfRowsInTable =
                dashboardPage.ResultsOnPageCount.Text.Split(' ').First().Replace(",", string.Empty);
            var actionsPanel = _driver.NowAt<ActionsElement>();
            //Wait for Selected Rows are displayed in the Action panel
            Thread.Sleep(1300);
            var numberOfRowsInActions = actionsPanel.GetSelectedRowsCount();
            Utils.Verify.AreEqual(numberOfRowsInTable, numberOfRowsInActions,
                "Number of rows are not equal in table and in Actions");
        }

        [Then(@"Select all checkbox is not displayed")]
        public void ThenSelectAllCheckboxIsNotDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(), "Select All checkbox is displayed");
        }

        [When(@"User types ""(.*)"" static list name")]
        public void WhenUserTypesStaticListName(string listName)
        {
            var listElement = _driver.NowAt<ActionsElement>();
            listElement.ListNameTextBox.SendKeys(listName);
        }

        [When(@"User create static list with ""(.*)"" name")]
        public void WhenUserCreateStaticListWithName(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var createButton = page.GetButtonByName("CREATE");

            var listElement = _driver.NowAt<ActionsElement>();
            listElement.ListNameTextBox.SendKeys(listName);
            createButton.Click();
            _driver.WaitForDataLoadingInActionsPanel();

            //Small wait for message display
            var customListElement = _driver.NowAt<CustomListElement>();
            Thread.Sleep(300);
            _driver.WaitForElementToBeNotDisplayed(customListElement.SuccessCreateMessage);
        }

        [Then(@"User type ""(.*)"" into Static list name field")]
        public void ThenUserTypeIntoStaticListNameField(string listName)
        {
            //Just to wait Create button
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetButtonByName("CREATE");

            var listElement = _driver.NowAt<ActionsElement>();
            listElement.ListNameTextBox.SendKeys(listName);
        }

        [Then(@"All checkboxes are checked in the table")]
        public void ThenAllCheckboxesAreCheckedInTheTable()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            //Wait for All checkboxes are checked
            Thread.Sleep(1000);
            Verify.IsFalse(dashboardPage.UncheckedCheckbox.Displayed(), "Not all checkboxes are checked in the table");
        }
    }
}