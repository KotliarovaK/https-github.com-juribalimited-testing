using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
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

        [When(@"User selects ""(.*)"" value for ""(.*)"" dropdown with search on Action panel")]
        public void WhenUserSelectsValueForDropdownWithSearchOnActionPanel(string value, string field)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetDropdownWithSearchByFieldName(field).Click();
            action.GetOptionByName(value).Click();
        }

        [When(@"User selects ""(.*)"" value for ""(.*)"" dropdown on Action panel")]
        public void WhenUserSelectsValueForDropdownOnActionPanel(string value, string field)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetDropdownByFieldName(field).Click();
            action.GetOptionByName(value).Click();
        }

        [When(@"User selects ""(.*)"" in the Actions dropdown")]
        public void WhenUserSelectsInTheActionsDropdown(string actionsName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ActionsDropdown.Click();
            action.GetOptionByName(actionsName).Click();
        }

        [When(@"User selects ""(.*)"" Bulk Update Type on Action panel")]
        public void WhenUserSelectsBulkUpdateTypeOnActionPanel(string typeName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            action.RequestTypeDropdown.Click();
            _driver.WaitForDataLoading();
            action.GetOptionByName(typeName).Click();
        }

        [Then(@"Bulk Update Type dropdown is displayed on Action panel")]
        public void ThenBulkUpdateTypeDropdownIsDisplayedOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(action.RequestTypeDropdown.Displayed(),
                "Bulk Update Type dropdown is not displayed on Action panel");
        }

        [When(@"User selects ""(.*)"" Project on Action panel")]
        public void WhenUserSelectsProjectOnActionPanel(string projectName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Clear();
            action.ProjectField.SendKeys(projectName);
            action.ProjectSection.Click();
        }

        [Then(@"Projects are displayed in alphabetical order on Action panel")]
        public void ThenProjectsAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Projects are not in alphabetical order");
        }

        [Then(@"""(.*)"" Project is displayed on Action panel")]
        public void ThenProjectIsDisplayedOnActionPanel(string projectName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual(projectName, action.ProjectField.GetAttribute("value"), "Project is not displayed");
        }

        [When(@"User clears Project field")]
        public void WhenUserClearsProjectField()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Clear();
        }

        [Then(@"the following Projects are displayed in opened DLL on Action panel:")]
        public void ThenTheFollowingProjectsAreDisplayedInOpenedDLLOnActionPanel(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionsDll.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Project lists are different");
        }

        [When(@"User selects ""(.*)"" Request Type on Action panel")]
        public void WhenUserSelectsRequestTypeOnActionPanel(string requestType)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            action.RequestTypeField.Click();
            action.RequestTypeField.Clear();
            action.RequestTypeField.SendKeys(requestType);
            action.GetOptionByName(requestType).Click();
        }

        [When(@"User selects ""(.*)"" Stage on Action panel")]
        public void WhenUserSelectsStageOnActionPanel(string stageValue)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.StageField.Clear();
            action.StageField.SendKeys(stageValue);
            action.GetOptionByName(stageValue).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"following Stage are displayed in drop-down:")]
        public void ThenFollowingStageAreDisplayedInDrop_Down(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.StageField.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Stage lists are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"Stages are displayed in alphabetical order on Action panel")]
        public void ThenStagesAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.StageField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Stages are not in alphabetical order");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Task on Action panel")]
        public void WhenUserSelectsTaskOnActionPanel(string taskNAme)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TaskField.Clear();
            action.TaskField.SendKeys(taskNAme);
            action.GetOptionByName(taskNAme).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Tasks are displayed in alphabetical order on Action panel")]
        public void ThenTasksAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TaskField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Tasks are not in alphabetical order");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"following Tasks are displayed in drop-down:")]
        public void ThenFollowingTasksAreDisplayedInDrop_Down(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TaskField.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Tasks value are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Value on Action panel")]
        public void WhenUserSelectsValueOnActionPanel(string value)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ValueDropdown.Click();
            action.GetOptionByName(value).Click();
        }

        [Then(@"Value field is not displayed on Action panel")]
        public void ThenValueFieldIsNotDisplayedOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(action.ValueDropdown.Displayed(), "Value field is displayed");
        }

        [When(@"User selects ""(.*)"" Update Value on Action panel")]
        public void WhenUserSelectsUpdateValueOnActionPanel(string value)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateValueDropdown.Click();
            action.GetOptionByName(value).Click();
        }

        [Then(@"the Update Value options are displayed in following order:")]
        public void ThenTheUpdateValueOptionsAreDisplayedInFollowingOrder(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateValueDropdown.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Update Value options are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Update Date on Action panel")]
        public void WhenUserSelectsUpdateDateOnActionPanel(string updateDate)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateDateDropdown.Click();
            action.GetOptionByName(updateDate).Click();
        }

        [When(@"User selects ""(.*)"" Date on Action panel")]
        public void WhenUserSelectsDateOnActionPanel(string dateValue)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.DateField.Click();
            action.DateField.Clear();
            action.DateField.SendKeys(dateValue);
        }

        [Then(@"the Update Date options are displayed in following order:")]
        public void ThenTheUpdateDateOptionsAreDisplayedInFollowingOrder(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateDateDropdown.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Update Date options are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Update Owner on Action panel")]
        public void WhenUserSelectsUpdateOwnerOnActionPanel(string owner)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateOwnerDropdown.Click();
            action.GetOptionByName(owner).Click();
        }

        [Then(@"the Update Owner options are displayed in following order:")]
        public void ThenTheUpdateOwnerOptionsAreDisplayedInFollowingOrder(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateOwnerDropdown.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Update Owner options are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Team on Action panel")]
        public void WhenUserSelectsTeamOnActionPanel(string team)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TeamField.Click();
            action.TeamField.Clear();
            action.TeamField.SendKeys(team);
            action.GetOptionByName(team).Click();
        }

        [Then(@"Teams are displayed in alphabetical order on Action panel")]
        public void ThenTeamsAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TeamField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Teams are not in alphabetical order");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Owner on Action panel")]
        public void WhenUserSelectsOwnerOnActionPanel(string owner)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.OwnerField.Click();
            action.OwnerField.Clear();
            action.OwnerField.SendKeys(owner);
            action.GetOptionByName(owner).Click();
        }

        [Then(@"Owner field is not displayed on Action panel")]
        public void ThenOwnerFieldIsNotDisplayedOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(action.OwnerField.Displayed(), "Owner Field is displayed");
        }

        [Then(@"Owner field is displayed on Action panel")]
        public void ThenOwnerFieldIsDisplayedOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(action.OwnerField.Displayed(), "Owner Field is not displayed");
        }

        [Then(@"the following Update Value are displayed in opened DLL on Action panel:")]
        public void ThenTheFollowingUpdateValueAreDisplayedInOpenedDLLOnActionPanel(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateValueDropdown.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionsDll.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Project list are different");
        }

        [When(@"User clicks the ""(.*)"" Action button")]
        public void WhenUserClicksTheActionButton(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetActionsButtonByName(buttonName).Click();
        }

        [Then(@"""(.*)"" Action button is disabled")]
        public void ThenActionButtonIsDisabled(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetActionsButtonByName(buttonName).GetAttribute("disabled");
            Assert.AreEqual(buttonState, "true", $"{buttonName} Button state is incorrect");
        }

        [Then(@"""(.*)"" Action button is active")]
        public void ThenActionButtonIsActive(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetActionsButtonByName(buttonName).GetAttribute("disabled");
            Assert.AreNotEqual(buttonState, "true", $"{buttonName} Button state is incorrect");
        }

        [Then(@"Objects to add panel is disabled")]
        public void ThenObjectsToAddPanelIsDisabled()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(component.DisabledObjectsToAddPanel.Displayed(), "Objects to add panel is active");
        }

        [Then(@"Objects to add panel is active")]
        public void ThenObjectsToAddPanelIsActive()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(component.ActiveObjectsToAddPanel.Displayed(), "Objects to add panel is active");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on Action panel")]
        public void ThenWarningMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(action.WarningMessageActionPanel(textMessage), "Warning Message is not displayed");
        }

        [Then(@"the amber message is displayed correctly")]
        public void ThenTheAmberMessageIsDisplayedCorrectly()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(action.AmberMessageOnActionPanel.Displayed(), "Amber message is not displayed");
            Assert.IsTrue(action.UpdateButtonOnAmberMessage.Displayed(), "Update Button is not displayed");
            Assert.IsTrue(action.CancelButtonOnAmberMessage.Displayed(), "Cancel Button is not displayed");
        }

        [Then(@"the amber message is not displayed")]
        public void ThenTheAmberMessageIsNotDisplayed()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(action.AmberMessageOnActionPanel.Displayed(), "Amber message is displayed");
        }

        [Then(@"Success message with ""(.*)"" text is displayed on Action panel")]
        public void ThenSuccessMessageWithTextIsDisplayedOnActionPanel(string textMessage)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(action.SuccessMessageActionPanel(textMessage), "Success Message is not displayed");
            Assert.IsTrue(action.CloseButtonInSuccessMessage.Displayed(),
                "Close button in Success message is not displayed");
        }

        [Then(@"Success message is hidden after five seconds")]
        public void ThenSuccessMessageIsHiddenAfterFiveSeconds()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Assert.IsTrue(action.SuccessMessage.Displayed(), "Success message is not displayed");
            Thread.Sleep(7000);
            Assert.IsFalse(action.SuccessMessage.Displayed(), "Success message is displayed for more than 5 seconds");
        }

        [Then(@"User clicks ""(.*)"" button on message box")]
        public void ThenUserClicksButtonOnMessageBox(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
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
                _driver.WaitForDataLoading();
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
            var numberOfRowsInTable =
                dashboardPage.ResultsOnPageCount.Text.Split(' ').First().Replace(",", string.Empty);
            var actionsPanel = _driver.NowAt<ActionsElement>();
            var numberOfRowsInActions = actionsPanel.GetSelectedRowsCount();
            Assert.AreEqual(numberOfRowsInTable, numberOfRowsInActions,
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
            listElement.ListNameTextBox.SendKeys(listName);
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
            listElement.ListNameTextBox.SendKeys(listName);
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
            listElement.ListNameTextBox.SendKeys(listName);
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
            actionsElement.ListsDropdown.Click();
            Assert.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(),
                actionsElement.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"following Values are displayed in Action drop-down:")]
        public void ThenFollowingValuesAreDisplayedInActionDrop_Down(Table table)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = actionsElement.ActionValues.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Action values are different");
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
        }
    }
}