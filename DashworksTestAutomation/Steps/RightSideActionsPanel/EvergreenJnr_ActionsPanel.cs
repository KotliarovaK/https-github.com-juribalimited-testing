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
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.RightSideActionsPanel
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

            Verify.IsTrue(panel.IsPanelOpened("ACTIONS"),
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
            Verify.IsFalse(panel.IsPanelOpened("ACTIONS"),
                "Action panel is opened");
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
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(dashboardPage.Checkbox.Displayed(),
                "Checkbox is displayed for content in the grid");
            Verify.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(),
                "Select all checkbox is displayed");
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
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            //_driver.WaitToBeSelected(dashboardPage.SelectAllCheckbox, true);
            Utils.Verify.IsTrue(_driver.GetEvergreenCheckboxState(dashboardPage.SelectAllCheckbox),
                "Select All checkbox is unchecked");
        }

        [Then(@"Select All selectbox is unchecked")]
        public void ThenSelectAllSelectboxIsUnchecked()
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            _driver.WhatForElementToBeSelected(dashboardPage.SelectAllCheckbox, false);
            Verify.IsTrue(_driver.GetEvergreenCheckboxState(dashboardPage.SelectAllCheckbox),
                "Select All checkbox is checked");
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
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(),
                "Select All checkbox is displayed");
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