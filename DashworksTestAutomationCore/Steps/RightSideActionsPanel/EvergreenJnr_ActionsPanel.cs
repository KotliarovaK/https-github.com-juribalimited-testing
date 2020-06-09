using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using DashworksTestAutomation.Helpers;

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

        [Then(@"'(.*)' message is displayed on Actions panel to the user")]
        public void ThenMessageIsDisplayedOnActionPanelToTheUser(string textMessage)
        {
            var panel = _driver.NowAt<ActionsPanelElement>();
            Verify.IsTrue(panel.ActionsPanelMessage.GetText().Equals(textMessage),
                $"'{textMessage}' message was not displayed");
        }

        [When(@"User closes Actions panel")]
        public void WhenUserClosesActionsPanel()
        {
            var button = _driver.NowAt<BaseRightSideActionsPanel>();
            button.ClosePanelButton.Click();
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on Action panel")]
        public void ThenWarningMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.WarningMessageText);
            Verify.AreEqual(textMessage, action.WarningMessageText.Text, $"{textMessage} in Warning message is not displayed");
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

        [When(@"User select ""(.*)"" rows in the grid")]
        public void WhenUserSelectRowsInTheGrid(string columnName, Table table)
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var columnContent = dashboardPage.GetColumnContentByColumnName(columnName);
            foreach (var row in table.Rows)
            {
                var rowIndex = columnContent.IndexOf(row["SelectedRowsName"]);
                if (rowIndex < 0)
                    throw new Exception($"'{row["SelectedRowsName"]}' is not found in the '{columnName}' column");
                _driver.WaitForDataLoading();
                dashboardPage.Checkboxes.ElementAt(rowIndex).Click();
            }
        }

        //TODO need to move this somewhere
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
            Verify.IsTrue(dashboardPage.DateTimeColumnValue.Displayed(), "Date column does not shows Date and Time values");
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
                Verify.AreEqual(selectedRowsCount, actionsPanel.GetSelectedRowsCount(),
                    $"Number of rows is not {selectedRowsCount}");
            }
            else
            {
                Thread.Sleep(5000);//wait after deselecting All check-box. Currently uncheck runs immediately and no loading indicators appear
                Verify.AreEqual(selectedRowsCount, actionsPanel.GetSelectedRowsCount(),
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
            Verify.AreEqual(numberOfRowsInTable, numberOfRowsInActions,
                "Number of rows are not equal in table and in Actions");
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
            var createButton = page.GetButton("CREATE");

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
            page.GetButton("CREATE");

            var listElement = _driver.NowAt<ActionsElement>();
            listElement.ListNameTextBox.SendKeys(listName);
        }
    }
}