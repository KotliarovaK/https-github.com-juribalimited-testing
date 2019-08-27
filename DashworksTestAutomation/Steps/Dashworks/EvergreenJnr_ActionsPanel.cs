using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
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
            var columnElement = _driver.NowAt<ActionsElement>();
            Utils.Verify.IsTrue(columnElement.ActionsPanel.Displayed(), "Actions panel was not displayed");
            Logger.Write("Actions panel is visible");
        }

        [Then(@"Actions panel is not displayed to the user")]
        public void ThenActionsPanelIsNotDisplayedToTheUser()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsFalse(button.ActiveActionsButton.Displayed(), "Actions panel was displayed");
        }

        [Then(@"Actions message container is displayed to the user")]
        public void ThenActionsMessageContainerIsDisplayedToTheUser()
        {
            var columnElement = _driver.NowAt<ActionsElement>();
            Utils.Verify.IsTrue(columnElement.ActionsContainerMessage.Displayed(),
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
            //Wait until all rows are selected
            Thread.Sleep(3000);
            _driver.WaitForElementToBeDisplayed(action.ActionsDropdown);
            action.ActionsDropdown.Click();
            action.GetOptionByName(actionsName).Click();
        }

        [When(@"User selects ""(.*)"" Bulk Update Type on Action panel")]
        public void WhenUserSelectsBulkUpdateTypeOnActionPanel(string typeName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            action.BulkUpdateTypeDropdown.Click();
            _driver.WaitForDataLoading();
            action.GetOptionByName(typeName).Click();
        }

        [Then(@"Bulk Update Type dropdown is displayed on Action panel")]
        public void ThenBulkUpdateTypeDropdownIsDisplayedOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(action.BulkUpdateTypeDropdown.Displayed(),
                "Bulk Update Type dropdown is not displayed on Action panel");
        }

        [When(@"User selects ""(.*)"" Project or Evergreen on Action panel")]
        public void WhenUserSelectsProjectOrEvergreenOnActionPanel(string projectName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectOrEvergreenField.Click();
            _driver.WaitForElementToBeDisplayed(action.ProjectSection);
            action.ActionsProjectOrEvergreenOptions.Where(x => x.Text.Equals(projectName)).FirstOrDefault().Click();
        }

        [When(@"User selects ""(.*)"" Project on Action panel")]
        public void WhenUserSelectsProjectOnActionPanel(string projectName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Clear();
            action.ProjectField.SendKeys(projectName);
            _driver.WaitForElementToBeDisplayed(action.ProjectSection);
            action.ProjectSection.Click();
        }

        [Then(@"Projects are displayed in alphabetical order on Action panel")]
        public void ThenProjectsAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ProjectField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Projects are not in alphabetical order");
        }

        [Then(@"""(.*)"" Project is displayed on Action panel")]
        public void ThenProjectIsDisplayedOnActionPanel(string projectName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.AreEqual(projectName, action.ProjectField.GetAttribute("value"), "Project is not displayed");
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
            Utils.Verify.AreEqual(expectedList, actualList, "Project lists are different");
        }

        [When(@"User selects ""(.*)"" Path on Action panel")]
        public void WhenUserSelectsPathOnActionPanel(string requestType)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.PathDropdown);
            action.PathDropdown.Clear();
            action.PathDropdown.SendKeys(requestType);
            action.GetOptionByName(requestType).Click();
        }

        [When(@"User selects ""(.*)"" Stage on Action panel")]
        public void WhenUserSelectsStageOnActionPanel(string stageValue)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.StageField);
            action.StageField.Clear();
            action.StageField.SendKeys(stageValue);
            action.GetOptionByName(stageValue).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" Capacity Unit on Action panel")]
        public void WhenUserSelectsCapacityUnitOnActionPanel(string capacityUnit)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.CapacityUnitField);
            action.CapacityUnitField.Clear();
            action.CapacityUnitField.SendKeys(capacityUnit);
            action.GetOptionByName(capacityUnit).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" Ring on Action panel")]
        public void WhenUserSelectsRingOnActionPanel(string ringValue)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.RingField);
            action.RingField.Clear();
            action.RingField.SendKeys(ringValue);
            action.GetOptionByName(ringValue).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" option in ""(.*)"" field on Action panel")]
        public void WhenUserSelectsOptionInFieldOnActionPanel(string option, string fieldName)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetFieldOnActionPanelByName(fieldName).Clear();
            field.GetFieldOnActionPanelByName(fieldName).SendKeys(option);
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" option in ""(.*)"" drop-down on Action panel")]
        public void WhenUserSelectsOptionInDrop_DownOnActionPanel(string option, string fieldName)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetDropdownOnActionPanelByName(fieldName).Click();
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"following Move Mailboxes are displayed in drop-down:")]
        public void ThenFollowingMoveMailboxesAreDisplayedInDrop_Down(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.AlsoMoveMailboxesField.Click();
            _driver.WaitForElementsToBeDisplayed(action.OptionListOnActionsPanel);
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Move Mailboxes lists are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"following Stage are displayed in drop-down:")]
        public void ThenFollowingStageAreDisplayedInDrop_Down(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.StageField.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Stage lists are different");
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
            Utils.Verify.AreEqual(expectedList, actualList, "Tasks value are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
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

        [Then(@"following values are displayed in ""(.*)"" drop-down with searchfield on Action panel:")]
        public void ThenFollowingValuesAreDisplayedInDrop_DownWithSearchfieldOnActionPanel(string fieldName, Table table)
        {
            var field = _driver.NowAt<ActionsElement>();
            field.GetSearchDropDownOnActionPanelByName(fieldName).Click();

            var action = _driver.NowAt<BaseDashboardPage>(); ;
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            foreach (var row in table.Rows)
            {
                Utils.Verify.Contains(row["Options"], actualList, $"This {fieldName} project in drop-down with search field not found");
            }

            field.BodyContainer.Click();
        }

        [Then(@"Stages are displayed in alphabetical order on Action panel")]
        public void ThenStagesAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.StageField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Stages are not in alphabetical order");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" Task on Action panel")]
        public void WhenUserSelectsTaskOnActionPanel(string taskNAme)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TaskField.Click();
            action.TaskField.Clear();
            action.TaskField.SendKeys(taskNAme);
            action.GetOptionByName(taskNAme).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User types ""(.*)"" Value on Action panel")]
        public void WhenUserTypesValueOnActionPanel(string value)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ValueField.Clear();
            action.ValueField.SendKeys(value);
            action.BodyContainer.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Tasks are displayed in alphabetical order on Action panel")]
        public void ThenTasksAreDisplayedInAlphabeticalOrderOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.TaskField.Click();
            var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
            Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Tasks are not in alphabetical order");
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
            Utils.Verify.IsFalse(action.ValueDropdown.Displayed(), "Value field is displayed");
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
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();

            action.UpdateValueDropdown.Click();
            _driver.WaitForElementsToBeDisplayed(action.OptionListOnActionsPanel);
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Update Value options are different");
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

        [When(@"User selects ""(.*)"" day selection")]
        public void WhenUserConfirmsDateSelectionOnActionPanel(string day)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.DayInDatePicker(day));
            action.DayInDatePicker(day).Click();
        }

        [When(@"User clicks datepicker for Action panel")]
        public void WhenUserClicksDatePicker()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.DatePickerIcon.Click();
        }

        [Then(@"Datepicker has tooltip with ""(.*)"" rows for value ""(.*)""")]
        public void ThenTooltipForSpecificDayHasCorrectRowNumber(string rowNumber, string dayNumber)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Assert.That(action.GetTooltipForDay(dayNumber).Count().Equals(Convert.ToInt32(rowNumber)), Is.True, "Wrong tooltips");
        }

        [Then(@"Day with ""(.*)"" number displayed green in Datepicker")]
        public void ThenDayInDatePickerDisplayedGreen(string dayNumber)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(action.DayInDatePicker(dayNumber));
            Assert.That(action.DayInDatePicker(dayNumber).GetCssValue("background-color"), Is.EqualTo("rgba(126, 189, 56, 1)"), "Day color is wrong");
        }

        [Then(@"Column ""(.*)"" displayed green in Datepicker")]
        public void ThenColumnWithSpecifiedDayDisplayedGreenInDatePicker(string dayName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            string col = action.GetDayColumnNumberByName(dayName);

            Utils.Verify.IsTrue(action.GetListOfDaysInDatePicker(col).All(x => x.GetCssValue("background-color").Equals("rgba(126, 189, 56, 1)")), "Wrong cell color");
        }

        [When(@"User selects ""(.*)"" Date on Action panel")]
        public void WhenUserSelectsDateOnActionPanel(string dateValue)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.MoveToElement(action.DateField);
            action.DateField.Click();
            action.DateField.Clear();
            action.DateField.SendKeys(dateValue);
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [When(@"User selects next Tuesday Date on Action panel")]
        public void WhenUserSelectsNextTuesdayDateOnActionPanel()
        {
            DateTime today = DateTime.Today;
            int daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextTuesday = today.AddDays(daysUntilTuesday);

            string dateValue = nextTuesday.ToString("dd MMM yyyy");

            var action = _driver.NowAt<BaseDashboardPage>();
            action.DateField.Click();
            action.DateField.Clear();
            action.DateField.SendKeys(dateValue);
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"the Update Date options are displayed in following order:")]
        public void ThenTheUpdateDateOptionsAreDisplayedInFollowingOrder(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();

            action.UpdateDateDropdown.Click();
            _driver.WaitForElementsToBeDisplayed(action.OptionListOnActionsPanel);
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Update Date options are different");
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
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();

            action.UpdateOwnerDropdown.Click();
            _driver.WaitForElementsToBeDisplayed(action.OptionListOnActionsPanel);
            var actualList = action.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Update Owner options are different");
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
            Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Teams are not in alphabetical order");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"options for ""(.*)"" field are displayed in alphabetical order on Action panel")]
        public void ThenOptionsForFieldAreDisplayedInAlphabeticalOrderOnActionPanel(string field)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            if (field.Equals("Bucket") || field.Equals("Capacity Unit") || field.Equals("Ring"))
            {
                action.GetDropdownByFieldName(field).Click();
                var listWithoutUnassigned = action.OptionListOnActionsPanel.Select(x => x.Text).Where(x => !x.Contains("Unassigned")).ToList();
                Utils.Verify.AreEqual(listWithoutUnassigned.OrderBy(s => s), listWithoutUnassigned, $"{field} are not in alphabetical order");
            }
            else
            {
                action.GetDropdownByFieldName(field).Click();
                var list = action.OptionListOnActionsPanel.Select(x => x.Text).ToList();
                Utils.Verify.AreEqual(list.OrderBy(s => s), list, $"{field} are not in alphabetical order");
            }
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
            Utils.Verify.IsFalse(action.OwnerField.Displayed(), "Owner Field is displayed");
        }

        [Then(@"Owner field is displayed on Action panel")]
        public void ThenOwnerFieldIsDisplayedOnActionPanel()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(action.OwnerField.Displayed(), "Owner Field is not displayed");
        }

        [Then(@"the following Update Value are displayed in opened DLL on Action panel:")]
        public void ThenTheFollowingUpdateValueAreDisplayedInOpenedDLLOnActionPanel(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.UpdateValueDropdown.Click();
            _driver.WaitForElementsToBeDisplayed(action.OptionsDll);
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.OptionsDll.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Project list are different");
        }

        #region  Action button

        [When(@"User clicks the ""(.*)"" Action button")]
        public void WhenUserClicksTheActionButton(string buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            var button = action.GetActionsButtonByName(buttonName);
            _driver.WaitForElementToBeEnabled(button);
            button.Click();
            _driver.WaitForDataLoading(50);
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
            Utils.Verify.IsTrue(button.GetActionsButtonByName(buttonName).Displayed(), $"{buttonName} Action button is not displayed");
        }

        [Then(@"""(.*)"" Action button is not displayed")]
        public void ThenActionButtonIsNotDisplayed(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsFalse(button.GetActionsButtonByName(buttonName).Displayed(), $"{buttonName} Action button is displayed");
        }

        [Then(@"""(.*)"" Action button is disabled")]
        public void ThenActionButtonIsDisabled(string buttonName)
        {
            Utils.Verify.IsTrue(IsButtonDisabled(buttonName), $"{buttonName} Button state is not disabled");
        }

        [Then(@"""(.*)"" Action button is enabled")]
        public void ThenActionButtonIsEnabled(string buttonName)
        {
            Utils.Verify.IsFalse(IsButtonDisabled(buttonName), $"{buttonName} Button state is not enabled");
        }

        private bool IsButtonDisabled(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetActionsButtonByName(buttonName).GetAttribute("disabled");
            if (buttonState == null)
                return false;
            else
                return bool.Parse(buttonState);
        }

        [Then(@"""(.*)"" Action button is active")]
        public void ThenActionButtonIsActive(string buttonName)
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            var buttonState = button.GetActionsButtonByName(buttonName).GetAttribute("disabled");
            Utils.Verify.AreNotEqual(buttonState, "true", $"{buttonName} Button state is incorrect");
        }

        [Then(@"""(.*)"" Action button have tooltip with ""(.*)"" text")]
        public void ThenActionButtonHaveTooltipWithText(string buttonName, string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var button = page.GetActionsButtonByName(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
        }

        #endregion

        [Then(@"""(.*)"" button is not displayed")]
        public void ThenButtonIsNotDisplayed(string buttonName)
        {
            var action = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsFalse(action.GetButtonByName(buttonName), $"{buttonName} is displayed");
        }

        [Then(@"Actions menu is not displayed to the user")]
        public void ThenActionsMenuIsNotDisplayedToTheUser()
        {
            var action = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsFalse(action.ActionsButton.Displayed(), "Actions menu is displayed");
        }

        [Then(@"Objects to add panel is disabled")]
        public void ThenObjectsToAddPanelIsDisabled()
        {
            var component = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(component.DisabledObjectsToAddPanel.Displayed(), "Objects to add panel is active");
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
            Utils.Verify.AreEqual(textMessage, action.WarningMessageText.Text, $"{textMessage} in Warning message is not displayed");
        }

        //TODO this method should be replaced by more generic
        [Then(@"the amber message is displayed correctly")]
        public void ThenTheAmberMessageIsDisplayedCorrectly()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(action.WarningMessage.Displayed(), "Amber message is not displayed");
            Utils.Verify.IsTrue(action.UpdateButtonOnAmberMessage.Displayed(), "Update Button is not displayed");
            Utils.Verify.IsTrue(action.CancelButtonOnAmberMessage.Displayed(), "Cancel Button is not displayed");
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
            Utils.Verify.AreEqual(textMessage, action.SuccessMessage.Text, $"{textMessage} are not equal");
            Utils.Verify.IsTrue(action.CloseButtonInSuccessMessage.Displayed(),
                "Close button in Success message is not displayed");
        }

        [Then(@"Success message is hidden after five seconds")]
        public void ThenSuccessMessageIsHiddenAfterFiveSeconds()
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(action.SuccessMessage.Displayed(), "Success message is not displayed");
            Thread.Sleep(7000);
            Utils.Verify.IsFalse(action.SuccessMessage.Displayed(), "Success message is displayed for more than 5 seconds");
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
            Utils.Verify.IsFalse(dashboardPage.Checkbox.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsFalse(dashboardPage.SelectAllCheckbox.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
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
            _driver.WaitForElementToBeDisplayed(listElement.CreateButton);
            listElement.ListNameTextBox.SendKeys(listName);
            _driver.WaitForElementToBeDisplayed(listElement.CreateButton);
            listElement.CreateButton.Click();

            //Small wait for message display
            var customListElement = _driver.NowAt<CustomListElement>();
            Thread.Sleep(300);
            _driver.WaitForElementToBeNotDisplayed(customListElement.SuccessCreateMessage);
        }

        [Then(@"User type ""(.*)"" into Static list name field")]
        public void ThenUserTypeIntoStaticListNameField(string listName)
        {
            var listElement = _driver.NowAt<ActionsElement>();
            _driver.WaitForElementToBeDisplayed(listElement.CreateButton);
            listElement.ListNameTextBox.SendKeys(listName);
        }

        [Then(@"All checkboxes are checked in the table")]
        public void ThenAllCheckboxesAreCheckedInTheTable()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            //Wait for All checkboxes are checked
            Thread.Sleep(1000);
            Utils.Verify.IsFalse(dashboardPage.UncheckedCheckbox.Displayed(), "Not all checkboxes are checked in the table");
        }

        [Then(@"Following options are available in lists dropdown:")]
        public void ThenFollowingOptionsAreAvailableInListsDropdown(Table table)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            actionsElement.ListsDropdown.Click();
            Utils.Verify.AreEqual(table.Rows.SelectMany(row => row.Values).ToList(),
                actionsElement.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"following Values are displayed in Action drop-down:")]
        public void ThenFollowingValuesAreDisplayedInActionDrop_Down(Table table)
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = actionsElement.ActionValues.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Action values are different");
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
        }
    }
}