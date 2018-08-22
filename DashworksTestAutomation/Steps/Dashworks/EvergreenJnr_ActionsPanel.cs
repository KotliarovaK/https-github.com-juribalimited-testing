using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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
            var columnElement = _driver.NowAt<ActionsElement>();
            Assert.IsTrue(columnElement.ActionsPanel.Displayed(), "Actions panel was not displayed");
            Logger.Write("Actions panel is visible");
        }

        [Then(@"Actions panel is not displayed to the user")]
        public void ThenActionsPanelIsNotDisplayedToTheUser()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(button.ActiveActionsButton.Displayed(), "Actions panel was displayed");
        }

        [Then(@"Actions message container is displayed to the user")]
        public void ThenActionsMessageContainerIsDisplayedToTheUser()
        {
            var columnElement = _driver.NowAt<ActionsElement>();
            Assert.IsTrue(columnElement.ActionsContainerMessage.Displayed(),
                "Actions message container was not displayed");
            Logger.Write("Actions message container is visible");
        }

        [When(@"User is deselect all rows")]
        [When(@"User select all rows")]
        public void WhenUserSelectAllRows()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            dashboardPage.SelectAllCheckbox.Click();
        }

        [When(@"User clicks on Action drop-down")]
        public void WhenUserClicksOnActionDrop_Down()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ActionsDropdown.Click();
        }

        [When(@"User selects ""(.*)"" in the Actions dropdown")]
        public void WhenUserSelectsInTheActionsDropdown(string actionsName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ActionsDropdown.Click();
            action.GetOptionOnActionsPanelByName(actionsName).Click();
        }

        [When(@"User selects ""(.*)"" Bulk Update Type on Action panel")]
        public void WhenUserSelectsBulkUpdateTypeOnActionPanel(string typeName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.RequestTypeDropdown.Click();
            action.GetOptionOnActionsPanelByName(typeName).Click();
        }

        [When(@"User selects ""(.*)"" Project on Action panel")]
        public void WhenUserSelectsProjectOnActionPanel(string projectName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Clear();
            action.ProjectField.SendKeys(projectName);
            action.GetOptionOnActionsPanelByName(projectName).Click();
        }

        [When(@"User selects ""(.*)"" Request Type on Action panel")]
        public void WhenUserSelectsRequestTypeOnActionPanel(string requestType)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.RequestTypeField.Clear();
            action.RequestTypeField.SendKeys(requestType);
            action.GetOptionOnActionsPanelByName(requestType).Click();
        }

        [When(@"User selects ""(.*)"" Stage on Action panel")]
        public void WhenUserSelectsStageOnActionPanel(string stageValue)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.StageField.Clear();
            action.StageField.SendKeys(stageValue);
            action.GetOptionOnActionsPanelByName(stageValue).Click();
        }

        [When(@"User selects ""(.*)"" Task on Action panel")]
        public void WhenUserSelectsTaskOnActionPanel(string taskNAme)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TaskField.Clear();
            action.TaskField.SendKeys(taskNAme);
            action.GetOptionOnActionsPanelByName(taskNAme).Click();
        }

        [When(@"User selects ""(.*)"" Value on Action panel")]
        public void WhenUserSelectsValueOnActionPanel(string value)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ValueDropdown.Click();
            action.GetOptionOnActionsPanelByName(value).Click();
        }

        [When(@"User clicks the ""(.*)"" Action button")]
        public void WhenUserClicksTheActionButton(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetActionsButtonByName(buttonName).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" Action button is disabled")]
        public void ThenActionButtonIsDisabled(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetActionsButtonByName(buttonName).GetAttribute("disabled");
            Assert.AreEqual(buttonState, "true", $"{buttonName} Button state is incorrect");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on Action panel")]
        public void ThenWarningMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(action.WarningMessageActionPanel(textMessage), "Warning Message is not displayed");
        }

        [Then(@"Success message with ""(.*)"" text is displayed on Action panel")]
        public void ThenSuccessMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(action.SuccessMessageActionPanel(textMessage), "Success Message is not displayed");
        }

        [Then(@"User clicks ""(.*)"" button on message box")]
        public void ThenUserClicksButtonOnMessageBox(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetButtonOnMessageBoxByNameOnActionPanel(buttonName).Click();
        }

        [Then(@"Checkboxes are not displayed")]
        public void ThenCheckboxesAreNotDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(dashboardPage.Checkbox.Displayed());
            Assert.IsFalse(dashboardPage.SelectAllCheckbox.Displayed());
        }

        [When(@"User select ""(.*)"" rows in the grid")]
        public void WhenUserSelectRowsInTheGrid(string columnName, Table table)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            var columnContent = dashboardPage.GetColumnContent(columnName);
            foreach (var row in table.Rows)
            {
                var rowIndex = columnContent.IndexOf(row["SelectedRowsName"]);
                if (rowIndex < 0)
                    throw new Exception($"'{row["SelectedRowsName"]}' is not found in the '{columnName}' column");
                dashboardPage.SelectRowsCheckboxes[rowIndex].Click();
            }
        }

        [Then(@"User removes selected rows")]
        public void WhenUserIsRemovedSelectedRows()
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            _driver.SelectCustomSelectbox(actionsElement.DropdownBox, "Remove from static list");
            actionsElement.RemoveButton.Click();
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
            _driver.WaitToBeSelected(dashboardPage.SelectAllCheckbox, true);
            Assert.IsTrue(dashboardPage.SelectAllCheckboxState, "Select All checkbox is unchecked");
        }

        [Then(@"Select All selectbox is unchecked")]
        public void ThenSelectAllSelectboxIsUnchecked()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitToBeSelected(dashboardPage.SelectAllCheckbox, false);
            Assert.IsFalse(dashboardPage.SelectAllCheckboxState, "Select All checkbox is checked");
        }

        [Then(@"""(.*)"" selected rows are displayed in the Actions panel")]
        public void ThenSelectedRowsAreDisplayedInTheActionsPanel(string selectedRowsCount)
        {
            var actionsPanel = _driver.NowAt<ActionsElement>();
            Assert.AreEqual(selectedRowsCount, actionsPanel.GetSelectedRowsCount(),
                $"Number of rows is not {selectedRowsCount}");
        }

        [Then(@"The number of rows selected matches the number of rows of the main object list")]
        public void ThenTheNumberOfRowsSelectedMatchesTheNumberOfRowsOfTheMainObjectList()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => dashboardPage.ResultsOnPageCount);
            if (!dashboardPage.ResultsOnPageCount.Text.Split(' ').Any() &&
                string.IsNullOrEmpty(dashboardPage.ResultsOnPageCount.Text.Split(' ').First()))
                throw new Exception("Rows count in table is missed");
            var numberoOfRowsInTable =
                dashboardPage.ResultsOnPageCount.Text.Split(' ').First().Replace(",", string.Empty);
            var actionsPanel = _driver.NowAt<ActionsElement>();
            var numberOfRowsInActions = actionsPanel.GetSelectedRowsCount();
            Assert.AreEqual(numberoOfRowsInTable, numberOfRowsInActions,
                "Number of rows are not equal in table and in Actions");
        }

        [Then(@"Select all checkbox is not displayed")]
        public void ThenSelectAllCheckboxIsNotDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(), "Select All checkbox is displayed");
        }

        [When(@"User types ""(.*)"" static list name")]
        public void WhenUserTypesStaticListName(string listName)
        {
            var listElement = _driver.NowAt<ActionsElement>();
            listElement.ListNameTextbox.SendKeys(listName);
        }

        [When(@"User clicks Cancel button on the Actions panel")]
        public void WhenUserClicksCancelButtonOnTheActionsPanel()
        {
            var listElement = _driver.NowAt<ActionsElement>();
            listElement.CancelButton.Click();
        }

        [When(@"User create static list with ""(.*)"" name")]
        public void WhenUserCreateStaticListWithName(string listName)
        {
            var listElement = _driver.NowAt<ActionsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ActionsElement>(() => listElement.CreateButton);
            listElement.ListNameTextbox.SendKeys(listName);
            _driver.WaitWhileControlIsNotDisplayed<ActionsElement>(() => listElement.CreateButton);
            listElement.CreateButton.Click();

            //Small wait for message display
            var customListElement = _driver.NowAt<CustomListElement>();
            Thread.Sleep(300);
            _driver.WaitWhileControlIsDisplayed<CustomListElement>(() => customListElement.SuccessCreateMessage);
        }

        [Then(@"User type ""(.*)"" into Static list name field")]
        public void ThenUserTypeIntoStaticListNameField(string listName)
        {
            var listElement = _driver.NowAt<ActionsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ActionsElement>(() => listElement.CreateButton);
            listElement.ListNameTextbox.SendKeys(listName);
        }

        [When(@"User select ""(.*)"" option in Actions panel")]
        public void WhenUserSelectOptionInActionsPanel(string option)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            _driver.SelectCustomSelectbox(actionsElement.DropdownBox, "Add to static list");
        }

        [Then(@"All checkboxes are checked in the table")]
        public void ThenAllCheckboxesAreCheckedInTheTable()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(dashboardPage.UncheckedCheckbox.Displayed(), "Not all checkboxes are checked in the table");
        }

        [Then(@"Following options are available in lists dropdown:")]
        public void ThenFollowingOptionsAreAvailableInListsDropdown(Table table)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            _driver.FindElement(By.XPath(actionsElement.listsDropdown)).Click();
            Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(),
                actionsElement.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"following Values are displayed in Action drop-down:")]
        public void ThenFollowingValuesAreDisplayedInActionDrop_Down(Table table)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = actionsElement.ActionValues.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Action values are different");
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
        }
    }
}