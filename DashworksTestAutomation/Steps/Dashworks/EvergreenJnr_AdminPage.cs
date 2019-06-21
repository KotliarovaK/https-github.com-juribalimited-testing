﻿using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly Team _team;
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly Buckets _buckets;
        private readonly RestWebClient _client;
        private readonly LastUsedBucket _lastUsedBucket;
        private readonly AddedObjects _addedObjects;
        private readonly CapacityUnit _capacityUnit;
        private readonly UserDto _user;

        public EvergreenJnr_AdminPage(RemoteWebDriver driver, Team team, DTO.RuntimeVariables.Projects projects,
            RestWebClient client, Buckets buckets, LastUsedBucket lastUsedBucket, AddedObjects addedObjects, CapacityUnit capacityUnit, UserDto user)
        {
            _driver = driver;
            _team = team;
            _projects = projects;
            _client = client;
            _buckets = buckets;
            _lastUsedBucket = lastUsedBucket;
            _addedObjects = addedObjects;
            _capacityUnit = capacityUnit;
            _user = user;
        }

        #region Check button state

        [Then(@"Update Project buttons is disabled")]
        public void ThenUpdateProjectButtonsIsDisabled()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.UpdateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.UpdateProjectButton.GetAttribute("disabled")),
                "Update Project button is active");
            Assert.IsTrue(Convert.ToBoolean(button.UpdateAllChangesButton.GetAttribute("disabled")),
                "Update All Changes button is active");
        }

        [Then(@"Create Project button is disabled")]
        public void ThenCreateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => button.CreateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateProjectButton.GetAttribute("disabled")),
                "Create Project button is active");
        }

        [Then(@"Create Project button is enabled")]
        public void ThenCreateProjectButtonIsEnabled()
        {
            var button = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => button.CreateProjectButton);
            Assert.IsFalse(Convert.ToBoolean(button.CreateProjectButton.GetAttribute("disabled")),
                "Create Project button is active");
        }

        [Then(@"Update Project button is active")]
        public void ThenUpdateProjectButtonIsActive()
        {
            var button = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(Convert.ToBoolean(button.UpdateProjectButton.GetAttribute("disabled")),
                "Update Project button is disabled");
            Assert.IsFalse(Convert.ToBoolean(button.UpdateAllChangesButton.GetAttribute("disabled")),
                "Update All Changes button is disabled");
        }

        [Then(@"Import Project button is enabled")]
        public void ThenImportProjectButtonIsEnabled()
        {
            var button = _driver.NowAt<ImportProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<ImportProjectPage>(() => button.ImportProjectButton);
            Assert.IsFalse(Convert.ToBoolean(button.ImportProjectButton.GetAttribute("disabled")),
                "Import button is disabled");
        }

        #endregion

        [When(@"User enters ""(.*)"" in the ""(.*)"" field")]
        public void WhenUserEntersInTheField(string name, string fieldName)
        {
            var bucketName = _driver.NowAt<ProjectsPage>();
            bucketName.GetFieldByName(fieldName).Clear();
            bucketName.GetFieldByName(fieldName).SendKeys(name);
            bucketName.BodyContainer.Click();

            if (!string.IsNullOrEmpty(name))
                switch (fieldName)
                {
                    case "Project Name":
                        _projects.Value.Add(name);
                        break;
                    case "Team Name":
                        TeamDto teamDto = new TeamDto();
                        teamDto.TeamName = name;
                        _team.Value.Add(teamDto);
                        break;
                    case "Bucket Name":
                        _buckets.Value.Add(name);
                        break;
                    //case "Capacity Unit Name":
                    //    break;
                    default:
                        throw new Exception($"{fieldName} not found");
                }
        }

        [When(@"User enters ""(.*)"" value in the ""(.*)"" field")]
        public void WhenUserEntersValueInTheField(string name, string fieldName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetFieldByName(fieldName).Clear();
            page.GetFieldByName(fieldName).SendKeys(name);
            page.BodyContainer.Click();
        }

        [Then(@"Scope field is automatically populated")]
        public void ThenScopeFieldIsAutomaticallyPopulated()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            Assert.IsFalse(page.EmptyScopeField.Displayed(), "Scope field is empty");
        }

        [Then(@"""(.*)"" content is not displayed in the grid on the Project details page")]
        public void ThenContentIsNotDisplayedInTheGridOnTheProjectDetailsPage(string text)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectTabs.CheckContentDisplay(text));
        }

        [When(@"User clicks on the Unlimited field on the Capacity Slots page")]
        public void WhenUserClicksOnTheUnlimitedFieldOnTheOnTheCapacitySlotsPage()
        {
            var projectElement = _driver.NowAt<CreateCapacitySlotPage>();
            projectElement.UnlimitedField.Click();
        }

        [Then(@"Unlimited text disappears from column")]
        public void ThenUnlimitedTextDisappearsFromColumn()
        {
            var projectElement = _driver.NowAt<CreateCapacitySlotPage>();
            Assert.IsTrue(projectElement.EmptyUnlimitedField.Displayed());
        }

        [Then(@"Bucket dropdown is not displayed on the Project details page")]
        public void ThenBucketDropdownIsNotDisplayedOnTheProjectDetailsPage()
        {
            var projectPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectPage.BucketDropdown.Displayed(), "Bucket dropdown is displayed");
        }

        [Then(@"Evergreen Unit is displayed to the user")]
        public void ThenEvergreenUnitIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.EvergreenUnit.Displayed(), "Evergreen Unit is not displayed");
        }

        [Then(@"string filter is displayed for ""(.*)"" column on the Admin Page")]
        public void ThenStringFilterIsDisplayedForColumnOnTheAdminPage(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(Convert.ToBoolean(page.GetFilterByColumnName(columnName).GetAttribute("readonly")));
        }

        [When(@"User navigates to the ""(.*)"" tab in the Scope section on the Project details page")]
        public void WhenUserNavigatesToTheTabInTheScopeSectionOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.NavigateToProjectTabInScopeSectionByName(tabName);
            _driver.WaitForDataLoading();
        }

        [Then(@"following Values are displayed in ""(.*)"" drop-down on the Admin page:")]
        public void ThenFollowingValuesAreDisplayedInDrop_DownOnTheAdminPage(string dropDownName, Table table)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetDropDownByName(dropDownName).Click();
            var element = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = element.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, $"Value for {dropDownName} are different");
            var body = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            body.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" color in the Application Scope tab on the Project details page")]
        public void WhenUserSelectsColorInTheApplicationScopeTabOnTheProjectDetailsPage(string colorName)
        {
            var applicationTab = _driver.NowAt<ProjectsPage>();
            applicationTab.DefaultReadinessDropdown.Click();
            applicationTab.GetReadinessOptionByName(colorName).Click();
        }

        [When(@"User clicks ""(.*)"" associated checkbox on the Project details page")]
        public void WhenUserClicksAssociatedCheckboxOnTheProjectDetailsPage(string checkboxName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.ClickAssociatedCheckbox(checkboxName);
        }

        [When(@"User selects following Mailbox permissions")]
        public void WhenUserSelectsFollowingMailboxPermissions(Table table)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            foreach (var row in table.Rows)
            {
                projectsPage.AddMailboxPermissionsButton.Click();
                _driver.WaitForDataLoading();
                projectsPage.PermissionsDropdown.Click();
                _driver.WaitForDataLoading();
                projectsPage.SelectPermissionsByName(row["Permissions"]);
                projectsPage.AddPermissionsButtonInTab.Click();
            }
        }

        [When(@"User selects following Mailbox folder permissions")]
        public void WhenUserSelectsFollowingMailboxFolderPermissions(Table table)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            foreach (var row in table.Rows)
            {
                projectsPage.AddMailboxFolderPermissionsButton.Click();
                projectsPage.PermissionsDropdown.Click();
                projectsPage.SelectPermissionsByName(row["Permissions"]);
                projectsPage.AddPermissionsButtonInTab.Click();
                _driver.WaitForDataLoading();
            }
        }

        [When(@"User removes following Mailbox permissions")]
        public void WhenUserRemovesFollowingMailboxPermissions(Table table)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectsPage.AddMailboxPermissionsButton);
            foreach (var row in table.Rows) projectsPage.RemovePermissionsByName(row["Permissions"]);
        }

        [Then(@"following Mailbox permissions are displayed to the user")]
        public void ThenFollowingMailboxPermissionsAreDisplayedToTheUser(Table table)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
                Assert.IsTrue(projectsPage.PermissionsDisplay(row["Permissions"]),
                    $"'{row["Permissions"]}' are not displayed");
        }

        [Then(@"following checkboxes are checked in the Scope section")]
        public void ThenFollowingCheckboxesAreCheckedInTheScopeSection(Table table)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
                Assert.IsTrue(projectsPage.CheckboxesDisplay(row["Checkboxes"]),
                    $"'{row["Checkboxes"]}' are not displayed");
        }

        [Then(@"following associations are disabled:")]
        public void ThenFollowingAssociationsAreDisabled(Table table)
        {
            var associations = _driver.NowAt<ProjectsPage>();
            foreach (var row in table.Rows)
            {
                _driver.WaitForDataLoading();
                Assert.IsTrue(associations.GetDisabledAssociationName(row["AssociationName"]),
                    $"Following '{row["AssociationName"]}' are active");
            }
        }

        [Then(@"All Associations are available")]
        public void ThenAllAssociationsAreAvailable()
        {
            var associations = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(associations.DisabledAssociation.Displayed(), "Some Associations are disabled");
        }

        [When(@"User clicks ""(.*)"" tab in the Project Scope Changes section")]
        public void WhenUserClicksTabInTheProjectScopeChangesSection(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
            ProjectsPage page;
            try
            {
                page = _driver.NowAt<ProjectsPage>();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    page = _driver.NowAt<ProjectsPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    page = _driver.NowAt<ProjectsPage>();
                }
            }

            Assert.IsTrue(page.SelectedTabInProjectScopeChangesSection(tabName),
                $"{tabName} is not displayed in the Project Scope Changes section");
        }

        [Then(@"open tab in the Project Scope Changes section is active")]
        public void ThenOpenTabInTheProjectScopeChangesSectionIsActive()
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            var tabState = projectTabs.ActiveTabOnScopeChangesSection.GetAttribute("aria-selected");
            Assert.AreEqual("true", tabState, "Tab state is incorrect");
        }

        [Then(@"User sees next Units on the Capacity Units page:")]
        public void ThenUserSeesNextUnitsOnTheCapacityUnitsPage(Table slots)
        {
            var page = _driver.NowAt<Capacity_UnitsPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < slots.RowCount; i++)
                Assert.That(page.GridUnitsNames[i].Text, Is.EqualTo(slots.Rows[i].Values.FirstOrDefault()),
                    "Units are not the same");
        }

        [Then(@"sum of objects in ""(.*)"" list is ""(.*)"" on the Admin page")]
        public void ThenSumOfObjectsInListIsOnTheAdminPage(string columnName, int sumOfObjects)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var numbers = page.GetSumOfObjectsContent(columnName);
            var total = numbers.Sum(x => Convert.ToInt32(x));
            Assert.That(total, Is.EqualTo(sumOfObjects), $"Sum of objects in {columnName} list is incorrect!");
        }

        [Then(@"User sees next Slots on the Capacity Slots page:")]
        public void ThenUserSeesNextSlotsOnTheCapacitySlotsPage(Table slots)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < slots.RowCount; i++)
                Assert.That(page.GridSlotsNames[i].Text, Is.EqualTo(slots.Rows[i].Values.FirstOrDefault()),
                    "Slots are not the same");
        }

        [Then(@"Project ""(.*)"" is displayed to user")]
        [Then(@"Automation ""(.*)"" is displayed to user")]
        public void ThenProjectIsDisplayedToUser(string projectName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.ActiveProjectByName(projectName), $"{projectName} is not displayed on the Project page");
        }

        [When(@"User clicks ""(.*)"" record in the grid")]
        public void WhenUserClicksRecordInThenGrid(string recordName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.SelectRecordByName(recordName);
        }

        [Then(@"field for Date column is empty")]
        public void ThenFieldForDateColumnIsEmpty()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsEmpty(page.DateSearchField.GetAttribute("value"), "Date Search textbox is not empty");
        }

        [When(@"User selects following date filter on the Projects page")]
        public void WhenUserSelectsFollowingDateFilterOnTheProjectsPage(Table table)
        {
            var filter = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            //filter.ResetFiltersButton.Click();
            foreach (var row in table.Rows)
            {
                filter.DateFilterValue.SendKeys(row["FilterData"]);
                filter.DateFilterValue.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
        }

        [When(@"User selects ""(.*)"" checkbox from String Filter on the Admin page")]
        public void WhenUserSelectsCheckboxFromStringFilterOnTheAdminPage(string filterName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetCheckboxStringFilterByName(filterName);
            page.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" checkbox from String Filter with item list on the Admin page")]
        public void WhenUserSelectsCheckboxFromStringFilterWithItemListOnTheAdminPage(string filterName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetCheckboxStringFilterWithItemListByName(filterName);
            page.BodyContainer.Click();
        }

        [When(@"User clicks ""(.*)"" checkbox from boolean filter on the Admin page")]
        public void WhenUserClicksCheckboxFromBooleanFilterOnTheAdminPage(string filterName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.GetBooleanStringFilterByName(filterName);
            page.BodyContainer.Click();
        }

        [Then(@"""(.*)"" checkbox is checked on the Admin page")]
        public void ThenCheckboxIsCheckedOnTheAdminPage(string checkbox)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.GetCheckedCheckboxByName(checkbox), "checkbox is unchecked");
        }

        [Then(@"""(.*)"" checkbox is unchecked on the Admin page")]
        public void ThenCheckboxIsUncheckedOnTheAdminPage(string checkbox)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.GetCheckedCheckboxByName(checkbox), "checkbox is checked");
        }

        [Then(@"""(.*)"" checkbox is greyed out on the Admin page")]
        public void ThenCheckboxIsGreyedOutOnTheAdminPage(string checkbox)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.GetGreyedOutCheckboxByName(checkbox).Displayed(), "checkbox is available");
        }

        [Then(@"""(.*)"" is displayed in the dropdown filter for ""(.*)"" column")]
        public void ThenIsDisplayedInTheDropdownFilterForColumn(string text, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.GetDropdownFilterTextByColumnName(columnName, text).Displayed(), $"{text} is not displayed in the dropdown filter for {columnName}");
        }

        [Then(@"All Associations are selected by default")]
        public void ThenAllAssociationsAreSelectedByDefault()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectsPage.UncheckedCheckbox.Displayed(), "Not all checkboxes are selected");
        }

        [Then(@"All Associations are disabled")]
        public void ThenAllAssociationsAreDisabled()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectsPage.DisabledAllAssociations.Displayed(), "All Associations is active");
        }

        [Then(@"User Scope checkboxes are disabled")]
        public void ThenUserScopeCheckboxesAreDisabled()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectsPage.UserScopeCheckboxes.Displayed(), "User Scope checkboxes are active");
        }

        [Then(@"User Scope checkboxes are active")]
        public void ThenUserScopeCheckboxesAreActive()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectsPage.UserScopeCheckboxes.Displayed(), "User Scope checkboxes are disabled");
        }

        [Then(@"Application Scope checkboxes are disabled")]
        public void ThenApplicationScopeCheckboxesAreDisabled()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectsPage.ApplicationScopeCheckboxes.Displayed(),
                "Application Scope checkboxes are active");
        }

        [Then(@"""(.*)"" tab is disabled")]
        public void ThenTabIsDisabled(string tabName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.GetDisabledTabByName(tabName).Displayed(), $"{tabName} is active");
        }

        [Then(@"Application Scope checkboxes are active")]
        public void ThenApplicationScopeCheckboxesAreActive()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectsPage.ApplicationScopeCheckboxes.Displayed(),
                "Application Scope checkboxes are disabled");
        }

        [Then(@"""(.*)"" checkbox is not displayed on the Admin page")]
        public void ThenCheckboxIsNotDisplayedOnTheAdminPage(string checkboxName)
        {
            var filterElement = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(filterElement.GetCheckboxByName(checkboxName));
            Logger.Write($"{checkboxName} checkbox is displayed");
        }

        [Then(@"""(.*)"" checkbox is displayed on the Admin page")]
        public void ThenCheckboxIsDisplayedOnTheAdminPage(string checkboxName)
        {
            var filterElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(filterElement.GetCheckboxByName(checkboxName), $"{checkboxName} checkbox is not displayed");
        }

        [Then(@"Application Scope tab is hidden")]
        public void ThenApplicationScopeTabIsHidden()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectsPage.ApplicationScopeTab.Displayed(), "Application Scope tab is displayed");
        }

        [Then(@"Application Scope tab is displayed")]
        public void ThenApplicationScopeTabIsDisplayed()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectsPage.ApplicationScopeTab.Displayed(), "Application Scope tab is not displayed");
        }

        [When(@"User changes Request Type to ""(.*)""")]
        public void WhenUserChangesRequestTypeTo(string requestTypeName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            projectsPage.RequestTypeDropdown.Click();
            projectsPage.SelectRequestTypeByName(requestTypeName).Click();
        }

        [When(@"User changes Category to ""(.*)""")]
        public void WhenUserChangesCategoryTo(string CategoryName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            projectsPage.CategoryDropdown.Click();
            projectsPage.SelectCategoryByName(CategoryName).Click();
        }

        [Then(@"""(.*)"" Request Type is displayed to the user")]
        public void ThenRequestTypeIsDisplayedToTheUser(string requestTypeName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectsPage.GetRequestTypeOrCategory(requestTypeName).Displayed(),
                "Incorrect Request Type is displayed");
        }

        [Then(@"""(.*)"" Category is displayed to the user")]
        public void ThenCategoryIsDisplayedToTheUser(string categoryName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectsPage.GetRequestTypeOrCategory(categoryName).Displayed(),
                "Incorrect Category is displayed");
        }

        [Then(@"""(.*)"" is displayed to the user in the Project Scope Changes section")]
        public void ThenIsDisplayedToTheUserInTheProjectScopeChangesSection(string text)
        {
            ProjectsPage page;
            try
            {
                page = _driver.NowAt<ProjectsPage>();
            }
            catch (WebDriverTimeoutException)
            {
                page = _driver.NowAt<ProjectsPage>();
            }

            _driver.WaitForDataLoading();
            Assert.IsTrue(page.SelectedItemInProjectScopeChangesSection(text),
                $"{text} is not displayed in the Project Scope Changes section");
        }

        [Then(@"""(.*)"" is displayed in the tab header on the Admin page")]
        public void ThenIsDisplayedInTheTabHeaderOnTheAdminPage(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetTabHeaderInTheScopeChangesSection(text),
                $"{text} is not displayed in the Project Scope Changes section");
        }

        [When(@"User deselect all rows on the grid")]
        [When(@"User selects all rows on the grid")]
        [When(@"User clicks Select All checkbox on the grid")]
        public void WhenUserSelectsAllRowsOnTheGrid()
        {
            var checkbox = _driver.NowAt<BaseGridPage>();
            checkbox.BodyContainer.Click();
            checkbox.SelectAllCheckBox.Click();
        }

        [Then(@"'Select All' checkbox have full checked state on the Admin page")]
        public void ThenSelectAllCheckboxHaveFullCheckedStateOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.SelectAllCheckboxWithFullCheckedState.Displayed(), "State for 'Select All' checkbox is displayed incorrectly");
        }

        [Then(@"'Select All' checkbox have indeterminate checked state on the Admin page")]
        public void ThenSelectAllCheckboxHaveIndeterminateCheckedStateOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.SelectAllCheckboxWithIndeterminateCheckedState.Displayed(), "State for 'Select All' checkbox is displayed incorrectly");
        }

        [When(@"User selects ""(.*)"" checkbox on the Project details page")]
        public void WhenUserSelectCheckboxOnTheProjectDetailsPage(string radioButtonName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectRadioButtonByName(radioButtonName).Click();
        }

        [Then(@"""(.*)"" checkbox is disabled on the Admin page")]
        public void ThenCheckboxIsDisabledOnTheAdminPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(checkbox.GetdisabledCheckboxByName(checkboxName).Displayed(), $"{checkboxName} is active");
        }

        [Then(@"""(.*)"" checkbox is checked and cannot be unchecked")]
        [Then(@"""(.*)"" associated checkbox is checked and cannot be unchecked")]
        public void ThenAssociatedCheckboxIsCheckedAndCannotBeUnchecked(string radioButtonName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            var checkbox = page.GetAssociatedCheckboxByName(radioButtonName);
            Assert.AreEqual(true, page.GetAssociatedCheckboxByName(radioButtonName).Selected,
                "Checkbox state is incorrect");
            Assert.AreEqual(true, Convert.ToBoolean(checkbox.GetAttribute("disabled")), "Checkbox state is incorrect");
        }

        [Then(@"""(.*)"" associated checkbox is checked")]
        public void ThenAssociatedCheckboxIsChecked(string radioButtonName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            Assert.AreEqual(true, checkbox.GetAssociatedCheckboxByName(radioButtonName).Selected,
                "Checkbox state is incorrect");
        }

        [When(@"User clicks ""(.*)"" checkbox on the Project details page")]
        public void WhenUserClicksCheckboxOnTheProjectDetailsPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectCheckboxByName(checkboxName);
        }

        [When(@"User clicks following checkboxes on the Project details page:")]
        public void WhenUserClicksFollowingCheckboxesOnTheProjectDetailsPage(Table table)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();

            foreach (var row in table.Rows) checkbox.SelectCheckboxByName(row.Values.FirstOrDefault());
        }

        [When(@"User selects ""(.*)"" file to upload on Import Project page")]
        public void WhenUserSelectsFileToUploadOnImportProjectPage(string fileNameAndExtension)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();

            try
            {
                var file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                           ResourceFilesNamesProvider.ResourcesFolderRoot + $"{fileNameAndExtension}";
                page.ButtonChooseFile.SendKeys(file);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to locate file in Resources folder: {e}");
            }
        }

        [When(@"User enters ""(.*)"" in the Project Name field on Import Project page")]
        public void ThenUserEntersInTheProjectNameFieldOnImportProjectPage(string projectName)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            page.ProjectNameField.SendKeys(projectName);
            _projects.Value.Add(projectName);
        }

        [When(@"User clicks Import Project button on the Import Project page")]
        public void WhenUserClicksImportButtonOnTheImportProjectPage()
        {
            var page = _driver.NowAt<ImportProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<ImportProjectPage>(() => page.ImportProjectButton);
            page.ImportProjectButton.Click();
            _driver.WaitForDataLoading();
            Logger.Write("Import Project button was clicked");
        }

        [Then(@"User sees following options in ""(.*)"" dropdown on Import Projects page:")]
        public void ThenUserSeesFollowingOptionsInDropdownOnImportProjectPage(string dropdownName, Table options)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            List<string> actualBucketsOptions = page.GetDropdownOptions(dropdownName);

            for (int i = 0; i < options.RowCount; i++)
            {
                Assert.That(actualBucketsOptions[i], Is.EqualTo(options.Rows[i].Values.FirstOrDefault()), "Options do not match!");
            }
        }

        [Then(@"User sees that ""(.*)"" dropdown contains following options on Import Projects page:")]
        public void ThenUserSeesThatDropdownContainsFollowingOptionsOnImportProjectPage(string dropdownName,
            Table options)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            List<string> actualBucketsOptions = page.GetDropdownOptions(dropdownName);

            Assert.That(actualBucketsOptions,
                Is.SupersetOf(options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault())),
                "Some options are missing!");
        }

        [When(@"User selects ""(.*)"" option in the ""(.*)"" dropdown on the Import Project Page")]
        public void ThenUserSelectsInTheImportDropdownOnTheImportProjectPage(string optionName, string dropdownName)
        {
            var importProjectPage = _driver.NowAt<ImportProjectPage>();
            importProjectPage.SelectDropdownOption(dropdownName, optionName);
        }

        [When(@"User enters ""(.*)"" in the Team Description field")]
        public void WhenUserEntersInTheTeamDescriptionField(string descriptionText)
        {
            var teamName = _driver.NowAt<CreateTeamPage>();
            teamName.TeamDescriptionField.Clear();
            teamName.TeamDescriptionField.SendKeys(descriptionText);
        }

        [When(@"User selects ""(.*)"" in the Add Members dropdown")]
        public void WhenUserSelectsInTheAddMembersDropdown(string optionName)
        {
            var createProjectElement = _driver.NowAt<CreateTeamPage>();
            createProjectElement.AddMembersCheckbox.Click();
            createProjectElement.SelectObjectForTeamCreation(optionName);
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" field")]
        public void ThenContentIsDisplayedInField(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.GetTextInFieldByFieldName(fieldName).GetAttribute("value").Contains(text),
                $"Text in {fieldName} field is different");
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" dropdown")]
        public void ThenContentIsDisplayedInDropdown(string text, string dropdown)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var dropdownContent = page.GetDropdownByName(dropdown).Text;
            Assert.AreEqual(dropdownContent, text, $"Text in '{dropdown}' drop-down is different");
        }

        [Then(@"""(.*)"" text value is displayed in the ""(.*)"" dropdown")]
        public void ThenTextValueIsDisplayedInTheDropdown(string value, string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(dropdown.GetDropdownByTextValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
        }

        [Then(@"""(.*)"" value is displayed in the ""(.*)"" dropdown")]
        public void ThenValueIsDisplayedInTheDropdown(string value, string dropdownName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            var dropdown = _driver.NowAt<BaseGridPage>();
            if (page.ExpandItemsButton.Displayed())
            {
                page.ExpandItemsButton.Click();
                Assert.IsTrue(dropdown.GetDropdownByValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
            }
            else
                Assert.IsTrue(dropdown.GetDropdownByValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
        }

        [Then(@"Capacity Units value is displayed for Capacity Mode field")]
        public void ThenCapacityUnitsValueIsDisplayedForCapacityModeField()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.DefaultCapacityMode.Displayed, "Default value is not displayed for Capacity Mode");
        }

        [Then(@"User selects ""(.*)"" option in ""(.*)"" dropdown")]
        public void ThenUserSelectsOptionInDropdown(string option, string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            dropdown.GetDropdownByName(dropdownName).Click();
            var searchElement = _driver.NowAt<BaseDashboardPage>();
            searchElement.GetOptionByName(option).Click();
        }

        [When(@"User selects ""(.*)"" in the ""(.*)"" dropdown")]
        public void WhenUserSelectsInTheDropdown(string value, string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            dropdown.GetDropdownByName(dropdownName).Click();
            dropdown.GetDropdownValueByName(value).Click();
        }

        //Update step after changing Project dropdown selector
        [When(@"User selects ""(.*)"" in the Project dropdown")]
        public void WhenUserSelectsInTheProjectDropdown(string value)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            dropdown.ProjectDropdown.Click();
            dropdown.GetDropdownValueByName(value).Click();
        }

        //Update step after changing Project dropdown selector
        [When(@"User selects ""(.*)"" in the Path dropdown")]
        public void WhenUserSelectsInThePathDropdown(string value)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            dropdown.PathtDropdown.Click();
            dropdown.GetDropdownValueByName(value).Click();
        }

        [When(@"User clicks Update Team button")]
        public void WhenUserClicksUpdateTeamButton()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.UpdateTeamButton);
            button.UpdateTeamButton.Click();
            Logger.Write("Update Team button was clicked");
        }

        [Then(@"Update Team button is disabled")]
        public void ThenUpdateTeamButtonIsDisabled()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.UpdateTeamButton);
            Assert.IsTrue(Convert.ToBoolean(button.UpdateTeamButton.GetAttribute("disabled")),
                "Update Team button is active");
        }

        [When(@"User clicks Default Team checkbox")]
        public void WhenUserClicksDefaultTeamCheckbox()
        {
            var teamElement = _driver.NowAt<TeamsPage>();
            teamElement.DefaultTeamCheckbox.Click();
        }

        [When(@"User changes Percentage to reach before showing amber to ""(.*)""")]
        public void WhenUserChangesPercentageToReachBeforeShowingAmberTo(string value)
        {
            var capacityElement = _driver.NowAt<Capacity_DetailsPage>();
            capacityElement.CapacityToReachBeforeShowAmber.Clear();
            capacityElement.CapacityToReachBeforeShowAmber.SendKeys(value);
        }

        [Then(@"Default Team checkbox is not active")]
        public void ThenDefaultTeamCheckboxIsNotActive()
        {
            var teamElement = _driver.NowAt<TeamsPage>();
            Assert.IsTrue(teamElement.DefaultTeamCheckbox.Displayed(), "Default Team checkbox is active");
        }

        [When(@"User selects ""(.*)"" tab on the Team details page")]
        public void WhenUserSelectsTabOnTheTeamDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<TeamsPage>();
            projectTabs.NavigateToTeamTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        [When(@"User removes selected members")]
        public void WhenUserRemovesSelectedMembers()
        {
            var teamElement = _driver.NowAt<TeamsPage>();
            teamElement.ActionsButton.Click();
            teamElement.RemoveButtonInActions.Click();
            teamElement.RemoveButtonOnPage.Click();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => teamElement.WarningMessage);
            _driver.WaitForDataLoading();
            teamElement.RemoveButtonInWarningMessage.Click();
        }

        [When(@"User selects ""(.*)"" team to add")]
        public void WhenUserSelectsTeamToAdd(string teamName)
        {
            var teamElement = _driver.NowAt<AddToAnotherTeamPage>();
            teamElement.AddUsersToAnotherTeam(teamName);
        }

        [When(@"User type ""(.*)"" search criteria in Select a new Team field")]
        public void WhenUserTypeSearchCriteriaInSelectANewTeamField(string text)
        {
            var teamPage = _driver.NowAt<AddToAnotherTeamPage>();
            teamPage.TeamSelectBox.Click();
            teamPage.TeamSelectBox.Clear();
            teamPage.TeamSelectBox.SendKeys(text);
        }

        [Then(@"following Team are displayed in Select a new Team drop-down:")]
        public void ThenFollowingTeamAreDisplayedInSelectANewTeamDrop_Down(Table table)
        {
            var teamPage = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = teamPage.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Teams in Select a new Team drop-down are different");
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.BodyContainer.Click();
        }

        [Then(@"Add Buckets page is displayed to the user")]
        public void ThenAddBucketsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddBucketToTeamPage>();
            Assert.IsTrue(page.PageTitle.Displayed(), "Add Buckets page is not displayed");
        }

        [Then(@"Reassign Buckets page is displayed to the user")]
        public void ThenReassignBucketsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ReassignBucketsPage>();
            Assert.IsTrue(page.PageReassignBucketsTitle.Displayed(), "Reassign Buckets page is not displayed");
        }

        [Then(@"Change Team page is displayed to the user")]
        public void ThenChangeTeamPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ChangeTeamPage>();
            Assert.IsTrue(page.PageTitle.Displayed(), "Change Team page is not displayed");
        }

        [When(@"User selects ""(.*)"" in the Select a team dropdown")]
        public void WhenUserSelectsInTheSelectATeamDropdown(string teamName)
        {
            var page = _driver.NowAt<ReassignBucketsPage>();
            page.SelectTeamDropdown.Click();
            _driver.WaitForDataLoading();
            page.SelectTeamToReassign(teamName);
        }

        [When(@"User selects ""(.*)"" in the Team dropdown")]
        public void WhenUserSelectsInTheTeamDropdown(string teamName)
        {
            var page = _driver.NowAt<ChangeTeamPage>();
            page.SelectTeamDropdown.Click();
            _driver.WaitForDataLoading();
            page.SelectTeamToChange(teamName);
        }

        [When(@"User expands ""(.*)"" project to add bucket")]
        public void WhenUserExpandsProjectToAddBucket(string projectName)
        {
            var teamElement = _driver.NowAt<AddBucketToTeamPage>();
            teamElement.ExpandProjectByName(projectName).Click();
        }

        #region Column Settings

        [When(@"User have opened Column Settings for ""(.*)"" column")]
        public void WhenUserHaveOpenedColumnSettingsForColumn(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.OpenColumnSettingsByName(columnName);
        }

        [When(@"User clicks Filter button in the Column Settings panel on the Teams Page")]
        public void WhenUserClicksFilterButtonInTheColumnSettingsPanelOnTheTeamsPage()
        {
            var menu = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => menu.FilterButton);
            menu.FilterButton.Click();
        }

        #endregion

        [Then(@"Content is present in the table on the Admin page")]
        public void ThenContentIsPresentInTheTableOnTheAdminPage()
        {
            var tableElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => tableElement.TableContent);
            Assert.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
        }

        [When(@"User clicks Add Members button on the Teams page")]
        public void WhenUserClicksAddMembersButtonOnTheTeamsPage()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.AddMembersButton);
            button.AddMembersButton.Click();
            Logger.Write("Add Members button was clicked");
        }

        [Then(@"Panel of available members is displayed to the user")]
        public void ThenPanelOfAvailableMembersIsDisplayedToTheUser()
        {
            var panel = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => panel.TeamMembersPanel);
            Assert.IsTrue(panel.TeamMembersPanel.Displayed(), "Team Members Panel is not displayed on the Teams page");
        }

        [Then(@"""(.*)"" team details is displayed to the user")]
        public void ThenTeamDetailsIsDisplayedToTheUser(string teamName)
        {
            var teamElement = _driver.NowAt<TeamsPage>();
            Assert.IsTrue(teamElement.AppropriateTeamName(teamName), $"{teamName} is not displayed on the Teams page");
        }

        [When(@"User clicks ""(.*)"" tab")]
        public void ThenUserClicksTab(string tabName)
        {
            var page = _driver.NowAt<TeamsPage>();
            page.SelectTabByName(tabName);
        }

        [Then(@"Default Bucket checkbox is selected")]
        public void ThenDefaultBucketCheckboxIsSelected()
        {
            var page = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(page.SelectedDefaultBucketCheckbox.Displayed(), "Default Bucket checkbox is not selected");
        }

        [When(@"User clicks ""(.*)"" tab on the Buckets page")]
        public void WhenUserClicksTabOnTheBucketsPage(string tabName)
        {
            var tab = _driver.NowAt<BucketsPage>();
            tab.ClickTabByName(tabName);
        }

        [When(@"User adds ""(.*)"" objects to bucket")]
        public void WhenUserAddsObjectsToBucket(string objectName)
        {
            var objects = _driver.NowAt<BucketsPage>();
            objects.SearchFieldForBucketsPage.SendKeys(objectName);
            objects.SelectObjectByName(objectName).Click();
        }

        [Then(@"Create Team button is disabled")]
        public void ThenCreateTeamButtonIsDisabled()
        {
            var button = _driver.NowAt<CreateTeamPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateTeamPage>(() => button.CreateTeamButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateTeamButton.GetAttribute("disabled")),
                "Create Team button is active");
        }

        [When(@"User clicks Delete button")]
        public void WhenUserClicksDeleteButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.DeleteButtonOnPage);
            button.DeleteButtonOnPage.Click();
            Logger.Write("Delete button was clicked");
        }

        [When(@"User clicks Delete button in Actions")]
        public void WhenUserClicksDeleteButtonInActions()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.DeleteButtonInActions);
            button.DeleteButtonInActions.Click();
            Logger.Write("Delete button was clicked");
        }

        [Then(@"Reassign Objects is displayed on the Teams page")]
        public void ThenReassignObjectsIsDisplayedOnTheTeamsPage()
        {
            var page = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => page.ReassignObjectsSummary);
            Assert.IsTrue(page.ReassignObjectsSummary.Displayed(), "Reassign Objects was not displayed");
        }

        [When(@"User selects ""(.*)"" team in the Team dropdown on the Buckets page")]
        public void ThenUserSelectTeamInTheTeamDropdownOnTheBucketsPage(string teamName)
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.TeamsNameField.Clear();
            _driver.WaitForDataLoading();
            createBucketElement.TeamsNameField.SendKeys(teamName);
            createBucketElement.SelectTeam(teamName);
        }

        [When(@"User updates the ""(.*)"" checkbox state")]
        public void WhenUserUpdatesTheCheckboxState(string checkbox)
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.GetDefaultCheckboxByName(checkbox).Click();
        }

        [Then(@"""(.*)"" bucket details is displayed to the user")]
        public void ThenBucketDetailsIsDisplayedToTheUser(string bucketName)
        {
            var teamElement = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(teamElement.AppropriateBucketName(bucketName),
                $"{bucketName} is not displayed on the Bucket page");
        }

        [Then(@"Move To Another Bucket Page is displayed to the user")]
        public void ThenMoveToAnotherBucketPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<MoveToAnotherBucketPage>();
            Assert.IsTrue(page.MoveToSelectBox.Displayed, "Move To Another Bucket Page is not displayed to the user");
        }

        [When(@"User moves selected objects to ""(.*)"" Capacity Unit")]
        [When(@"User moves selected objects to ""(.*)"" bucket")]
        public void WhenUserMovesSelectedObjectsToBucket(string bucketName)
        {
            var page = _driver.NowAt<MoveToAnotherBucketPage>();
            page.MoveToBucketByName(bucketName);
        }

        [Then(@"""(.*)"" is displayed on the Admin page")]
        public void ThenIsDisplayedOnTheAdminPage(string name)
        {
            var page = _driver.NowAt<Capacity_CapacityUnitsPage>();
            Assert.IsTrue(page.GetMovingElementByName(name).Displayed(), $"{name} Page is not displayed to the user");
        }

        [Then(@"Actions dropdown is displayed correctly")]
        public void ThenActionsDropdownIsDisplayedCorrectly()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.ActionsButton);
            Assert.IsTrue(button.ActionsButton.Displayed(), "Actions dropdown is not displayed correctly");
        }

        [Then(@"Actions dropdown is disabled")]
        public void ThenActionsDropdownIsDisabled()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(button.ActionsSelectBox.GetAttribute("class").Contains("disabled"), "Actions dropdown is active");
        }

        [When(@"User clicks on Actions button")]
        public void ThenUserClicksOnActionsButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.ActionsButton);
            button.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [Then(@"following items are displayed in the Actions dropdown:")]
        public void ThenFollowingItemsAreDisplayedInTheActionsDropdown(Table table)
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.ActionsButton);
            button.ActionsButton.Click();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = button.ActionsInDropdownList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Actions items are different");
            button.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" in the Actions")]
        public void ThenUserSelectInTheActions(string actionName)
        {
            var action = _driver.NowAt<BaseGridPage>();
            action.SelectActions(actionName);
        }

        [Then(@"Create Capacity Unit button is disabled")]
        [Then(@"Create Bucket button is disabled")]
        public void ThenCreateBucketButtonIsDisabled()
        {
            var button = _driver.NowAt<CreateBucketPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateBucketPage>(() => button.CreateBucketButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateBucketButton.GetAttribute("disabled")),
                "Create Bucket button is active");
        }

        [Then(@"Bucket ""(.*)"" is displayed to user")]
        public void ThenBucketIsDisplayedToUser(string bucketName)
        {
            var page = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(page.ActiveBucketByName(bucketName), $"{bucketName} is not displayed on the Buckets page");
        }

        [Then(@"No items text is displayed")]
        public void ThenNoItemsTextIsDisplayed()
        {
            var text = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(text.NoItemsMessage.Displayed, "No items text is not displayed");
        }

        [When(@"User clicks Update Bucket button on the Buckets page")]
        public void WhenUserClicksUpdateBucketButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            button.UpdateBucketButton.Click();
        }

        [When(@"User expands the object to add")]
        public void WhenUserExpandsTheObjectToAdd()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.PlusButton.Click();
        }

        [When(@"User expands the object to remove on ""(.*)"" tab")]
        public void WhenUserExpandsTheObjectToRemoveOnTab(string tabName)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            try
            {
                projectElement.PlusButton.Click();
            }
            catch (Exception)
            {
                Thread.Sleep(5000);
                _driver.Navigate().Refresh();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                projectElement.PlusButton.Click();
            }
        }

        [When(@"User waits and expands the ""(.*)"" panel to remove")]
        public void WhenUserWaitsAndExpandsThePanelToRemove(string tabName)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            try
            {
                projectElement.PlusButton.Click();
            }
            catch (Exception)
            {
                Thread.Sleep(60000);
                _driver.Navigate().Refresh();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                projectElement.PlusButton.Click();
            }
        }

        [When(@"User enters ""(.*)"" in the Search Object field")]
        public void WhenUserEntersInTheSearchObjectField(string text)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.SearchTextBox.Clear();
            projectElement.SearchTextBox.SendKeys(text);
            _driver.WaitForDataLoading();
        }

        [When(@"User selects all objects to the Project")]
        [When(@"User cancels the selection objects in the Project")]
        public void WhenUserSelectsAllObjects()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.AllItemCheckbox.Click();
            _driver.WaitForDataLoading();
        }

        #region Adding Objects

        [When(@"User adds following Objects from list")]
        public void ThenUserAddFollowingObjectsFromList(Table table)
        {
            var bucketElement = _driver.NowAt<BaseGridPage>();

            foreach (var row in table.Rows)
            {
                var text = row["Objects"];
                bucketElement.AddItem(text);
                bucketElement.SearchTextBox.ClearWithHomeButton(_driver);
                //Save added objects to remove it from the bucket
                _addedObjects.Value.Add(text, _lastUsedBucket.Value);
            }

            bucketElement.AddItemButton.Click();
        }

        [Then(@"following Objects are displayed in Buckets table:")]
        public void ThenFollowingObjectsAreDisplayedInBuckets(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualRowList = page.RowsList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedRowList, actualRowList, "Buckets lists are different");
        }

        [Then(@"following Objects are displayed in ""(.*)"" tab on the Capacity Units page:")]
        public void ThenFollowingObjectsAreDisplayedInTabOnTheCapacityUnitsPage(string tabName, Table table)
        {
            try
            {
                if (tabName.Equals("Applications"))
                {
                    var page = _driver.NowAt<Capacity_CapacityUnitsPage>();

                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.ApplicationsRowsList.Select(value => value.Text).ToList();
                    Assert.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
                else
                {
                    var page = _driver.NowAt<BaseGridPage>();

                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.RowsList.Select(value => value.Text).ToList();
                    Assert.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
            }
            catch (Exception)
            {
                if (tabName.Equals("Applications"))
                {
                    var page = _driver.NowAt<Capacity_CapacityUnitsPage>();
                    _driver.Navigate().Refresh();
                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.ApplicationsRowsList.Select(value => value.Text).ToList();
                    Assert.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
                else
                {
                    var page = _driver.NowAt<BaseGridPage>();
                    _driver.Navigate().Refresh();
                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.RowsList.Select(value => value.Text).ToList();
                    Assert.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
            }
        }

        [When(@"User searches by ""(.*)"" column and selects following rows in the grid:")]
        public void WhenUserSearchesByColumnAndSelectsFollowingRowsInTheGrid(string columnName, Table table)
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            int iteration = 0;
            foreach (var row in table.Rows)
            {
                dashboardPage.GetSearchFieldByColumnName(columnName, row.Values.FirstOrDefault());
                _driver.WaitForDataLoading();
                dashboardPage.SelectAllCheckBox.Click();
                if (iteration != 0)
                {
                    dashboardPage.SelectAllCheckBox.Click();
                }
                iteration++;
            }
        }

        [When(@"User closes Tools panel")]
        public void WhenUserClosesToolsPanel()
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();
            listPageElement.CloseToolsPanelButton.Click();
        }

        [When(@"User clicks Search button and opens Search panel for agGrid")]
        public void WhenUserClicksSearchButtonAndOpensSearchPanelForAgGrid()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.MouseHover(dashboardPage.TableSearchButton);
            dashboardPage.TableSearchButton.Click();
        }

        [When(@"User searches and selects following rows in the grid on Details page:")]
        public void WhenUserSearchesAndSelectsFollowingRowsInTheGridOnDetails(Table table)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            if (dashboardPage.TableSearchTextBox.Displayed())
            {
                foreach (var row in table.Rows)
                {
                    dashboardPage.TableSearchTextBox.SendKeys(row["SelectedRowsName"]);
                    Thread.Sleep(5000);
                    _driver.WaitForDataLoading();
                    dashboardPage.SelectOneRowsCheckboxes.Click();
                    dashboardPage.TableSearchTextBox.Clear();
                }
            }
            else
            {
                dashboardPage.TableSearchButton.Click();
                _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => dashboardPage.TableSearchTextBox);
                foreach (var row in table.Rows)
                {
                    dashboardPage.TableSearchTextBox.SendKeys(row["SelectedRowsName"]);
                    Thread.Sleep(5000);
                    _driver.WaitForDataLoading();
                    dashboardPage.SelectOneRowsCheckboxes.Click();
                    dashboardPage.TableSearchTextBox.Clear();
                }
            }
        }

        [Then(@"Objects are displayed in alphabetical order on the Admin page")]
        public void ThenObjectsAreDisplayedInAlphabeticalOrderOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var originalList = page.ObjectsList.Select(x => x.Text).ToList();
            SortingHelper.IsListSorted(originalList);
        }

        [Then(@"Objects for Buckets are displayed in alphabetical order on the Admin page")]
        public void ThenObjectsForBucketsAreDisplayedInAlphabeticalOrderOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var originalList = page.ObjectsBucketsList.Select(x => x.Text).ToList();
            SortingHelper.IsListSorted(originalList);
        }

        [When(@"User adds following Objects to the Project")]
        public void WhenUserAddsFollowingObjectsToTheProject(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.PlusButton.Click();
            foreach (var row in table.Rows)
            {
                projectElement.AddItem(row["Objects"]);
                projectElement.SearchTextBox.ClearWithHomeButton(_driver);
            }

            projectElement.UpdateButton.Click();
        }

        [When(@"User adds following Objects to the Project on ""(.*)"" tab")]
        public void WhenUserAddsFollowingObjectsToTheProjectOnTab(string tabName, Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            try
            {
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                projectElement.PlusButton.Click();
                foreach (var row in table.Rows)
                {
                    projectElement.AddItem(row["Objects"]);
                    projectElement.SearchTextBox.ClearWithHomeButton(_driver);
                }
            }
            catch (Exception)
            {
                Thread.Sleep(60000);
                _driver.Navigate().Refresh();
                _driver.WaitForDataLoading();
                var projectTabs = _driver.NowAt<ProjectsPage>();
                projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
                _driver.WaitForDataLoading();
                projectElement.PlusButton.Click();
                foreach (var row in table.Rows)
                {
                    projectElement.AddItem(row["Objects"]);
                    projectElement.SearchTextBox.ClearWithHomeButton(_driver);
                }
            }

            projectElement.UpdateButton.Click();
        }

        [When(@"User selects following Objects to the Project")]
        public void WhenUserSelectsFollowingObjectsToTheProject(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.PlusButton.Click();
            foreach (var row in table.Rows)
            {
                projectElement.AddItem(row["Objects"]);
                projectElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
        }

        [When(@"User selects following Objects")]
        public void WhenUserSelectsFollowingObjects(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
            {
                projectElement.AddItem(row["Objects"]);
                projectElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
        }

        [Then(@"following Items are displayed in the History table")]
        [Then(@"additional onboarded Items are displayed in the History table")]
        public void ThenFollowingItemsAreDisplayedInTheHistoryTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            var secondsToWait = 80;
            foreach (var row in table.Rows)
            {
                Assert.True(projectElement.WaitForHistoryOnboardedObject(row["Items"], secondsToWait),
                    $"History onboarded object with '{row["Items"]}' text was not appears in the grid in {secondsToWait} seconds");
            }
        }

        [Then(@"Following items displayed in the History table")]
        public void ThenFollowingItemsDisplayedInTheHistoryTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(projectElement.WaitForHistoryOnboardedObject(row["Items"], 30),
                    $"History table doesn't contains '{row["Items"]}' item");
            }
        }

        [Then(@"following Items are displayed in the Queue table")]
        public void ThenFollowingItemsAreDisplayedInTheQueueTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(projectElement.QueueOnboardedObjectDisplayed(row["Items"]).Displayed,
                    $"{row["Items"]} is not displayed in Queue table");
            }
        }

        [When(@"User waits until Queue disappears")]
        public void WhenUserWaitsForQueueDisappears()
        {
            var refresh_icon = ".//i[@class='material-icons' and contains(text(),'refresh')]";
            var filter_label = ".//div[@class='top-tools-inner']//span[contains(text(),'row')]";

            var projectElement = _driver.NowAt<BaseGridPage>();

            for (int i = 0; i < 30; i++)
            {
                if (i == 29)
                {
                    throw new Exception("Queue processing took too much time: 60 sec");
                }

                if (!_driver.FindElement(By.XPath(filter_label)).Text.Equals("0 rows"))
                {
                    Thread.Sleep(2000);
                    _driver.FindElement(By.XPath(refresh_icon)).Click();
                    _driver.WaitForDataLoading();
                }
                else
                {
                    break;
                }

            }
        }

        [Then(@"following Items are displayed at the top of the list")]
        public void ThenFollowingItemsAreDisplayedAtTheTopOfTheList(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();

            for (var i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows.ElementAt(i);
                Assert.AreEqual(projectElement.GetTableStringRowNumber(row["Items"]), i.ToString(),
                    $"{row["Items"]} is not displayed in History table");
            }
        }

        [Then(@"following objects were not found")]
        public void ThenFollowingObjectsWereNotFound(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.PlusButton.Click();
            foreach (var row in table.Rows)
            {
                projectElement.CheckItemDisplay(row["Objects"]);
                Assert.IsTrue(projectElement.CheckedAllItemCheckbox.Displayed(), "Some object is present");
                projectElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
        }

        [Then(@"onboarded objects are displayed in the dropdown")]
        public void ThenOnboardedObjectsAreDisplayedInTheDropdown()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(projectElement.ReonboardedItem.Displayed(), "Re-onboarded objects are displayed");
        }

        [Then(@"Add Objects panel is collapsed")]
        public void ThenAddObjectsPanelIsCollapsed()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.AddObjectsPanelCollapsed.Displayed(), "Panel is expanded");
        }

        #endregion

        [When(@"User enters ""(.*)"" text in the Object Search field")]
        public void WhenUserEntersTextInTheObjectSearchField(string text)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.GetObjectField(text);
        }

        [Then(@"following items are still selected")]
        public void ThenFollowingItemsAreStillSelected()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.PlusButton.Displayed(), "Items are not selected");
            Assert.IsTrue(projectElement.CheckedSomeItemCheckbox.Displayed(), "Item checkbox is not checked");
        }

        [Then(@"no items are selected")]
        public void ThenNoItemsAreSelected()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(projectElement.CheckedAllItemCheckbox.Displayed(), "Some Item is selected");
        }

        [When(@"User clicks Create button on the Create Project page")]
        public void WhenUserClicksCreateButtonOnTheCreateProjectPage()
        {
            var page = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => page.CreateProjectButton);
            _driver.ClickByJavascript(page.CreateProjectButton);
            _driver.WaitForDataLoading();
            Logger.Write("Create Project button was clicked");
        }

        [When(@"User clicks Create button on the Create Ring page")]
        public void WhenUserClicksCreateButtonOnTheCreateRingPage()
        {
            var page = _driver.NowAt<CreateRingPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateRingPage>(() => page.CreateRingButton);
            page.CreateRingButton.Click();
            Thread.Sleep(2000);
            _driver.WaitForDataLoading();
            Logger.Write("Create Ring button was clicked");
        }

        [When(@"User sets ""(.*)"" value in Maps to evergreen ring field")]
        public void WhenUserSetsMapsToEvergreenRingValue(string option)
        {
            var page = _driver.NowAt<CreateRingPage>();
            page.MapsToEvergreenField.Clear();
            page.MapsToEvergreenField.SendKeys(option);
            page.SelectOptionInMapsToEvergreenRingDropdown(option);
            Logger.Write("Create Ring button was clicked");
        }

        [Then(@"Ring settings Maps to evergreen ring is displayed as ""(.*)""")]
        public void ThenRingSettingsMapsToEvergreenIsDisplayedCorrectly(string ringName)
        {
            var page = _driver.NowAt<CreateRingPage>();
            Assert.AreEqual(ringName, page.MapsToEvergreenField.GetAttribute("value"), $"'{ringName}' text is not displayed in Maps to Evergreen Ring field");
        }

        [When(@"User doubleclicks Create button on Create Ring page")]
        public void WhenUserDoubleclicksCreateButtonOnTheCreateRingPage()
        {
            var page = _driver.NowAt<CreateRingPage>();
            page.Actions.Click(page.CreateRingButton).DoubleClick().Build().Perform();
        }

        [When(@"User tries to open same page with ""(.*)"" item id")]
        public void WhenUserOpensSamePageForNotExistingItem(string Id)
        {
            string current = _driver.Url;
            int index = current.LastIndexOf("/");

            if (index > 0)
                current = current.Substring(0, index) + "/" + Id;
            _driver.Navigate().GoToUrl(current);
        }

        [When(@"User tries to open not existing page")]
        public void WhenUserOpensNotExistingPage()
        {
            string current = _driver.Url;
            int index = current.LastIndexOf("/");

            if (index > 0)
                current = current.Substring(0, index) + "/project/52/scope";
            _driver.Navigate().GoToUrl(current);
        }

        [Then(@"Page not found displayed for the user")]
        public void ThenPageNotFoundDisplayedForRingDetailsPage()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => page.DetailsPageWasNotFound);
            Assert.That(page.DetailsPageWasNotFound.Text, Is.EqualTo("404"), "Page 404 was not opened");
        }

        [Then(@"created Project with ""(.*)"" name is displayed correctly")]
        public void ThenCreatedProjectWithNameIsDisplayedCorrectly(string projectName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            try
            {
                _driver.WaitForDataLoading();
                Assert.IsTrue(page.GetCreatedProjectName(projectName), $"The {projectName} Project is not found");
            }
            catch (Exception)
            {
                Thread.Sleep(60000);
                _driver.Navigate().Refresh();
                _driver.WaitForDataLoading();
                Assert.IsTrue(page.GetCreatedProjectName(projectName), $"The {projectName} Project is not found");
            }
        }

        [Then(@"Import Project button is not displayed")]
        public void ThenImportProjectButtonIsNotDisplayed()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(button.ImportProjectButton.Displayed(), "Import Project button is displayed");
        }

        [When(@"User selects ""(.*)"" in the Scope Project dropdown")]
        [When(@"User selects ""(.*)"" in the Scope Automation dropdown")]
        public void ThenUserSelectsInTheScopeProjectDropdown(string objectName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.SelectObjectForProjectCreation(objectName);
        }

        [Then(@"""(.*)"" content is displayed in the Scope Automation dropdown")]
        public void ThenContentIsDisplayedInTheScopeAutomationDropdown(string dropdownValue)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            StringAssert.Contains(dropdownValue, createProjectElement.ScopeProjectField.GetAttribute("value"), $"{dropdownValue} is not displayed in the Scope Automation dropdown");
        }

        [Then(@"Main lists are displayed correctly in the Scope dropdown")]
        public void ThenMainListsAreDisplayedCorrectlyInTheScopeDropdown(Table table)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.ScopeProjectField.SendKeys("All");
            var sectionName = createProjectElement.ScopeDropdownSection.Select(x => x.Text).ToList();
            var listName = createProjectElement.ScopeDropdownSectionList.Select(x => x.Text).ToList();
            foreach (var row in table.Rows)
            {
                for (var i = 0; i < createProjectElement.ScopeDropdownSection.Count; i++)
                    if (sectionName[i].Equals(row["Section"]))
                    {
                        Assert.AreEqual(listName[i], row["ListName"]);
                    }
            }
        }

        [When(@"User selects ""(.*)"" in the Scope Project details")]
        public void WhenUserSelectsInTheScopeProjectDetails(string listName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ScopeListDropdown.Click();
            projectElement.SelectObjectForProjectCreation(listName);
            Thread.Sleep(5000);
        }

        [Then(@"Scope List dropdown is disabled")]
        public void ThenScopeListDropdownIsDisabled()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectElement.DisabledScopeListDropdown.Displayed());
        }

        [Then(@"""(.*)"" is displayed in the disabled Project Type field")]
        public void ThenIsDisplayedInTheDisabledProjectTypeField(string projectType)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(Convert.ToBoolean(projectElement.ProjectType.GetAttribute("disabled")),
                "Project Type field is active");
            Assert.AreEqual(projectType, projectElement.ProjectType.GetAttribute("value"), "Project Type is incorrect");
        }

        [Then(@"Scope List dropdown is active")]
        public void ThenScopeListDropdownIsActive()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectElement.ActiveScopeListDropdown.Displayed());
        }

        [When(@"User clicks in the Scope field on the Admin page")]
        public void WhenUserClicksInTheScopeFieldOnTheAdminPage()
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
        }

        [Then(@"Scope DDL have the ""(.*)"" Width")]
        public void ThenScopeDDLHaveTheWidth(string width)
        {
            var panelSize = _driver.NowAt<ProjectsPage>();
            Assert.AreEqual(width, panelSize.GetDllPanelWidth().Split('.').First());
        }

        [When(@"User selects ""(.*)"" in the Buckets Project dropdown")]
        public void WhenUserSelectsInTheBucketsProjectDropdown(string objectName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.BucketsProjectField.Click();
            createProjectElement.SelectObjectForProjectCreation(objectName);
            //Waiting for bucket change
            Thread.Sleep(3000);
        }

        [When(@"User selects ""(.*)"" in the Mode Project dropdown")]
        public void WhenUserSelectsInTheModeProjectDropdown(string optionName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ModeProjectField.Click();
            createProjectElement.SelectProjectsMode(optionName);
            //Waiting for option change
            Thread.Sleep(3000);
        }

        [When(@"user selects ""(.*)"" in the Bucket dropdown")]
        public void WhenUserSelectsInTheBucketDropdown(string objectName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.BucketDropdown.Click();
            projectElement.SelectObjectForProjectCreation(objectName);
        }

        [Then(@"""(.*)"" is displayed in the Bucket dropdown")]
        public void ThenIsDisplayedInTheBucketDropdown(string textBucket)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectElement.BucketDropdownDisplay(textBucket),
                "Incorrect text is displayed in the Bucket dropdown");
        }

        [When(@"User changes Project Name to ""(.*)""")]
        public void WhenUserChangesProjectNameTo(string projectName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ProjectName.Clear();
            projectElement.ProjectName.SendKeys(projectName);
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" language on the Project details page")]
        public void WhenUserSelectsLanguageOnTheProjectDetailsPage(string language)
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.LanguageDropDown.Click();
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetOptionByName(language).Click();
            projectPage.CheckLanguageButton.Click();
        }

        [When(@"User opens menu for selected language")]
        public void WhenUserOpensMenuForSelectedLanguage()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            _driver.WaitForDataLoading();
            projectPage.LanguageMenu.Click();
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on the Project Details Page")]
        public void ThenWarningMessageWithTextIsDisplayedOnTheProjectDetailsPage(string text)
        {
            var message = _driver.NowAt<BaseGridPage>();
            StringAssert.Contains(text, message.WarningMessage.Text, $"{text} is not displayed in Warning message");
        }

        [Then(@"No warning message displayed on the Project Details Page")]
        public void ThenNoWarningMessageIsDisplayedOnTheProjectDetailsPage()
        {
            var message = _driver.NowAt<BaseGridPage>();
            Assert.That(_driver.IsElementDisplayed(message.WarningMessage), Is.False, $"Warning message is displayed");
        }


        [Then(@"User selects ""(.*)"" option for selected language")]
        public void ThenUserSelectsOptionForSelectedLanguage(string optionName)
        {
            var projectPage = _driver.NowAt<ProjectsPage>();
            projectPage.GetLanguageMenuOptionByName(optionName).Click();
        }

        [When(@"User converts project to evergreen project")]
        public void WhenUserConvertsProjectOnTheProjectDetailsPage()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.ConvertToEvergreen.Click();
            _driver.WaitWhileControlIsNotDisplayed<ProjectDetailsPage>(() => projectPage.ConfirmConvertToEvergreenButton);
            projectPage.ConfirmConvertToEvergreenButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks Converts to Evergreen button")]
        public void WhenUserClicksConvertsToEvergreenButtonOnDetailsPage()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.ConvertToEvergreen.Click();
            _driver.WaitWhileControlIsNotDisplayed<ProjectDetailsPage>(() => projectPage.ConfirmConvertToEvergreenButton);
        }

        [Then(@"Cancel button is displayed in warning message")]
        public void ThenCancelButtonIsDisplayedInWarning()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            Assert.IsTrue(projectPage.CancelConvertToEvergreenButton.Displayed(),
                "Cancel button is not displayed in warning");
        }

        [When(@"User confirms converting to Evergreen process")]
        public void WhenUserConfirmsConvertingToEvergreenProcess()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.ConfirmConvertToEvergreenButton.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Success converting message appears with the next ""(.*)"" text")]
        public void ThenSuccessConvertingMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<ProjectDetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectDetailsPage>(() => page.SuccessConvertMessage);
            Assert.AreEqual("rgba(126, 189, 56, 1)", page.GetMessageColor()); //Green color
            StringAssert.Contains(text, page.SuccessConvertMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Convert to Evergreen button is not displayed")]
        public void ThenConvertsToEvergreenButtonIsNotDisplayed()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            Assert.IsFalse(projectPage.ConvertToEvergreen.Displayed(),
                "Convert to Evergreen button is displayed");
        }

        [When(@"User changes Name to ""(.*)"" in the ""(.*)"" field on the Project details page")]
        [When(@"User type ""(.*)"" Name in the ""(.*)"" field on the Project details page")]
        [When(@"User type ""(.*)"" Name in the ""(.*)"" field on the Automation details page")]
        public void WhenUserTypeNameInTheFieldOnTheProjectDetailsPage(string name, string fieldName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.GetFieldByName(fieldName).Clear();
            projectElement.GetFieldByName(fieldName).SendKeys(name);
            _capacityUnit.Value.Add(new CapacityUnitDto() { Name = name });
        }

        [When(@"User selects ""(.*)"" checkbox in the ""(.*)"" field on the Project details page")]
        public void WhenUserSelectsCheckboxInTheFieldOnTheProjectDetailsPage(string checkbox, string fieldName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.GetFieldByName(fieldName).SendKeys(checkbox);
            var slot = _driver.NowAt<Capacity_SlotsPage>();
            slot.GetCheckboxByName(checkbox).Click();
            var filterElement = _driver.NowAt<BaseGridPage>();
            filterElement.BodyContainer.Click();
        }

        [When(@"User removes ""(.*)"" on the Project details page")]
        public void WhenUserRemovesTaskFromCapacityEditPage(string taskName)
        {
            var slot = _driver.NowAt<Capacity_SlotsPage>();
            slot.RemoveTaskIcon(taskName).Click();
        }

        [Then(@"CapacityEnabled flag is equal to ""(.*)""")]
        public void ThenCapacityEnabledFlagIsEqualTo(string flagState)
        {
            var slot = _driver.NowAt<Capacity_SlotsPage>();

            Assert.That(GetTaskCapacityEnabledFlag(slot.Storage.SessionStorage.GetItem("task_id")),
                Is.EqualTo(flagState), $"Flag state is in different state");
        }

        [When(@"User changes Project Short Name to ""(.*)""")]
        public void WhenUserChangesProjectShortNameTo(string shortProjectName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ProjectShortName.Clear();
            projectElement.ProjectShortName.SendKeys(shortProjectName);
        }

        [When(@"User changes Project Description to ""(.*)""")]
        public void WhenUserChangesProjectDescriptionTo(string descriptionName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ProjectDescription.Clear();
            projectElement.ProjectDescription.SendKeys(descriptionName);
        }

        [When(@"User changes project language to ""(.*)""")]
        public void WhenUserChangesProjectLanguageTo(string language)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.DefaultLanguage.Click();
            page.SelectProjectLanguage(language);
        }

        [When(@"User click on Back button")]
        public void WhenUserClickOnBackButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Thread.Sleep(20000);
            button.BackToTableButton.Click();
        }

        [When(@"User resets Search fields for columns")]
        public void WhenUserResetsSearchFieldsForColumns()
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            searchElement.ResetFiltersButton.Click();
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column")]
        public void WhenUserEntersTextInTheSearchFieldForColumn(string text, string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.GetSearchFieldByColumnName(columnName, text);
            //Store bucket name for further usage
            if (columnName.Equals("Bucket"))
                _lastUsedBucket.Value = text;
        }

        [When(@"User changes value to ""(.*)"" for ""(.*)"" column")]
        public void WhenUserChangesValueToForColumn(string value, string columnName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.EnterValueByColumnName(value, columnName);
        }

        [When(@"User changes value to ""(.*)"" for ""(.*)"" day column")]
        public void WhenUserChangesValueToForDayColumn(string value, string columnName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.EnterValueByDayName(value, columnName);
            var body = _driver.NowAt<BaseGridPage>();
            body.BodyContainer.Click();
        }

        [When(@"User clicks on ""(.*)"" dropdown on the Capacity Slots page")]
        public void WhenUserClicksOnDropdownOnTheCapacitySlotsPage(string dropdownName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.ClickDropdownByName(dropdownName);
        }

        [Then(@"following items are displayed in the dropdown:")]
        public void ThenFollowingItemsAreDisplayedInTheDropdown(Table items)
        {
            var page = _driver.NowAt<BaseGridPage>();
            foreach (var row in items.Rows)
            {
                Assert.IsTrue(page.DropdownItemDisplayed(row["Items"]).Displayed,
                    $"{row["Items"]} is not displayed in the dropdown");
            }
        }

        [Then(@"Tasks are displayed in the following order on Action panel:")]
        public void ThenTasksAreDisplayedInTheFollowingOrderOnActionPanel(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.DropdownTaskItemsList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Tasks are different");
        }

        [When(@"User selects next items in the ""(.*)"" dropdown:")]
        public void WhenUserSelectsNextItemsInTheDropdown(string dropdownName, Table items)
        {
            WhenUserClicksOnDropdownOnTheCapacitySlotsPage(dropdownName);

            var page = _driver.NowAt<BaseGridPage>();
            foreach (var row in items.Rows)
            {
                page.DropdownItemDisplayed(row["Items"]).Click();
            }
        }

        [When(@"User enters ""(.*)"" value to ""(.*)"" date field on Capacity Slot form page")]
        public void WhenUserEntersValueToDateFieldOnCapacitySlotFormPage(string value, string field)
        {
            var page = _driver.NowAt<CreateCapacitySlotPage>();
            page.EnterValueToTheDateByPlaceholder(value, field);
        }

        [Then(@"User sees ""(.*)"" value in the ""(.*)"" date field on Capacity Slot form page")]
        public void ThenUserSeesValueInTheDateFieldOnCapacitySlotFormPage(string valueExpected, string field)
        {
            var page = _driver.NowAt<CreateCapacitySlotPage>();

            Assert.That(page.GetValueFromDateByPlaceholder(field), Is.EqualTo(valueExpected));
        }

        [When(@"User clicks ""(.*)"" link on the Capacity Slot page")]
        public void WhenUserClicksLinkOnTheCapacitySlotPage(string linkName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.GetLanguageLinkByName(linkName).Click();
        }

        [Then(@"See Translations link on the Capacity Slot page is not displayed")]
        public void ThenSeeTranslationsLinkOnTheCapacitySlotPageIsNotDisplayed()
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Assert.IsFalse(page.LanguageTranslationsLink.Displayed(), "See Translations link is displayed");
        }

        [Then(@"""(.*)"" Language is displayed in Translations table on the Capacity Slot page")]
        public void ThenLanguageIsDisplayedInTranslationsTableOnTheCapacitySlotPage(string language)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Assert.IsTrue(page.GetLanguageInTranslationsTableByName(language).Displayed, $"{language} is not displayed in Translations table");
        }

        [When(@"User types ""(.*)"" in Display Name field for ""(.*)"" Language in Translations table on the Capacity Slot page")]
        public void WhenUserTypesInDisplayNameFieldForLanguageInTranslationsTableOnTheCapacitySlotPage(string text, string language)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.GetDisplayNameFieldByLanguage(language).Clear();
            page.GetDisplayNameFieldByLanguage(language).SendKeys(text);
        }

        [Then(@"""(.*)"" is displayed in Display Name field for ""(.*)"" Language in Translations table on the Capacity Slot page")]
        public void ThenIsDisplayedInDisplayNameFieldForLanguageInTranslationsTableOnTheCapacitySlotPage(string text, string language)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Assert.AreEqual(text, page.GetDisplayNameFieldByLanguage(language).GetAttribute("value"), $"'{text}' text is not displayed in Display Name field");
        }

        [When(@"User enters ""(.*)"" value in Move to position dialog")]
        public void WhenUserEntersValueInMoveToPositionDialog(string value)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.MoveToPositionInput.Clear();
            page.MoveToPositionInput.SendKeys(value);
        }

        [When(@"User remembers the Move to position dialog size")]
        public void WhenUserRemembersMoveToPositionDialogSize()
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.Storage.SessionStorage.SetItem("dialog_Height", page.MoveToPositionDialog.Size.Height.ToString());
            page.Storage.SessionStorage.SetItem("dialog_Width", page.MoveToPositionDialog.Size.Width.ToString());
        }

        [Then(@"User checks that Move to position dialog has the same size")]
        public void ThenUserChecksThatMoveToPositionDialogHasTheSameSize()
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            int height = Int32.Parse(page.Storage.SessionStorage.GetItem("dialog_Height"));
            int width = Int32.Parse(page.Storage.SessionStorage.GetItem("dialog_Width"));

            Assert.That(page.MoveToPositionDialog.Size.Height, Is.InRange(height, height + 5)); // 5pxls is max height allowed scaling
            Assert.That(page.MoveToPositionDialog.Size.Width, Is.EqualTo(width));
        }

        [Then(@"Button ""(.*)"" in Move to position dialog is displayed disabled")]
        public void ThenButtonInMoveToPositionDialogIsDisplayedDisabled(string buttonName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            var actionBtn = page.GetMoveToPositionDialogButtonByText(buttonName);
            Assert.IsFalse(actionBtn.Enabled, "Specified button is in Enabled state");
        }

        [When(@"User moves ""(.*)"" slot to ""(.*)"" slot")]
        public void WhenUserMovesSlotToSlot(string slot, string moveToSlot)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            var slotFrom = page.GetMoveButtonBySlotName(slot);
            var slotTo = page.GetMoveButtonBySlotName(moveToSlot);
            _driver.DragAndDrop(slotFrom, slotTo);
        }

        [When(@"User moves ""(.*)"" automation to ""(.*)"" automation")]
        public void WhenUserMovesAutomationToAutomation(string automation, string moveToautomation)
        {
            var page = _driver.NowAt<AutomationsPage>();
            var slotFrom = page.GetMoveButtonBySlotName(automation);
            var slotTo = page.GetMoveButtonBySlotName(moveToautomation);
            _driver.DragAndDrop(slotFrom, slotTo);
        }

        [Then(@"Alert message is displayed and contains ""(.*)"" text")]
        public void ThenAlertMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _driver.WaitWhileControlIsNotDisplayed<Capacity_SlotsPage>(() => page.MoveToPositionAlert);
            StringAssert.Contains(text, page.MoveToPositionAlert.Text, "Alert Message is not displayed");
        }

        [When(@"User enters ""(.*)"" date in the ""(.*)"" field")]
        public void WhenUserEntersDateInTheField(string date, string fieldName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.AddDateByFieldName(fieldName, date);
            page.BodyContainer.Click();
        }

        [Then(@"Create Override Date is displayed correctly")]
        public void ThenCreateOverrideDateIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<Capacity_OverrideDatesPage>();
            Assert.IsTrue(page.CreateOverrideDatePageTitle.Displayed, "Create Override Date title is not displayed");
        }

        [Then(@"""(.*)"" text in search field is displayed correctly for ""(.*)"" column")]
        public void ThenTextInSearchFieldIsDisplayedCorrectlyForColumn(string searchText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.AreEqual(page.GetTextInSearchFieldByColumnName(columnName).GetAttribute("value"), searchText,
                "Text in search field is different");
        }

        [Then(@"Menu options are displayed in the following order on the Admin page:")]
        public void ThenMenuOptionsAreDisplayedInTheFollowingOrderOnTheAdminPage(Table table)
        {
            var action = _driver.NowAt<BaseGridPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.MenuTabOptionListOnAdminPage.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Menu options are different");
        }

        [Then(@"""(.*)"" column content is displayed in the following order:")]
        public void ThenColumnContentIsDisplayedInTheFollowingOrder(string columnName, Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.GetColumnContent(columnName);
            Assert.AreEqual(expectedList, actualList, "Column content is different");
        }

        [Then(@"""(.*)"" dropdown is not displayed")]
        public void ThenDropdownIsNotDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(dropdown.GetMissingDropdownByName(dropdownName), $"{dropdownName} is displayed");
        }
        [Then(@"""(.*)"" dropdown is not displayed on the Admin Settings screen")]
        public void ThenDropdownIsNotDisplayedOnTheAdminSettingsScreen(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(dropdown.GetMissingDropdownOnSettingsScreenByName(dropdownName), $"{dropdownName} is displayed");
        }

        [Then(@"""(.*)"" dropdown is displayed")]
        public void ThenDropdownIsDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(dropdown.GetDropdownByName(dropdownName).Displayed(), $"{dropdownName} is not displayed");
        }

        [Then(@"Next values are selected for the ""(.*)"" field:")]
        public void ThenNextValuesAreSelectedForTheField(string dropdownName, Table table)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            if (page.ExpandItemsButton.Displayed())
            {
                page.ExpandItemsButton.Click();
                var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
                var actualList = page.SelectedValuesList.Select(value => value.Text).ToList();
                Assert.AreEqual(expectedList, actualList, "The list of task values ​​is different");
            }
            else
            {
                var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
                var actualList = page.SelectedValuesList.Select(value => value.Text).ToList();
                Assert.AreEqual(expectedList, actualList, "The list of task values ​​is different");
            }
        }

        [Then(@"""(.*)"" checkbox in the ""(.*)"" field are not available to select")]
        public void ThenCheckboxInTheFieldAreNotAvailableToSelect(string checkbox, string fieldName)
        {
            var field = _driver.NowAt<ProjectsPage>();
            field.GetFieldByName(fieldName).SendKeys(checkbox);
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Assert.IsTrue(page.NoValuesAvailableInDropDown.Displayed(), $"'{checkbox}' is available for select");
        }

        [Then(@"""(.*)"" checkbox in the ""(.*)"" field are available to select")]
        public void ThenCheckboxInTheFieldAreAvailableToSelect(string checkbox, string fieldName)
        {
            var field = _driver.NowAt<ProjectsPage>();
            field.GetFieldByName(fieldName).Clear();
            field.GetFieldByName(fieldName).SendKeys(checkbox);
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Assert.IsFalse(page.NoValuesAvailableInDropDown.Displayed(), $"'{checkbox}' is not available for select");
            Assert.IsTrue(page.GetCheckboxByName(checkbox).Displayed(), $"'{checkbox}' is available for '{fieldName}' field");
        }

        [Then(@"Next checkboxes in the ""(.*)"" dropdown are not available to select:")]
        public void ThenNextCheckboxesInTheDropdownAreNotAvailableToSelect(string dropdownName, Table table)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
            {
                var projectElement = _driver.NowAt<ProjectsPage>();
                projectElement.GetFieldByName(dropdownName).Clear();
                projectElement.GetFieldByName(dropdownName).SendKeys(row["Value"]);
                Assert.IsTrue(page.NoValuesAvailableInDropDown.Displayed(), $"{row["Value"]} is not displayed in {dropdownName} dropdown");
            }
        }

        [When(@"User clicks String Filter button for ""(.*)"" column on the Admin page")]
        public void WhenUserClicksStringFilterButtonForColumnOnTheAdminPage(string columnName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
            filterElement.BodyContainer.Click();
            filterElement.GetStringFilterByColumnName(columnName);
        }

        [Then(@"""(.*)"" checkbox is checked in the filter dropdown")]
        public void ThenCheckboxIsCheckedInTheFilterDropdown(string filterName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(filterElement.GetCheckedFilterByCheckboxName(filterName).Displayed(),
                $"{filterName} checkbox is not checked");
        }

        [Then(@"""(.*)"" is not displayed in the filter dropdown")]
        public void ThenIsNotDisplayedInTheFilterDropdown(string filterName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(filterElement.GetStringFilterByName(filterName));
        }

        [Then(@"Projects in filter dropdown are displayed in alphabetical order")]
        public void ThenProjectsInFilterDropdownAreDisplayedInAlphabeticalOrder()
        {
            var page = _driver.NowAt<BaseGridPage>();
            var list = page.ProjectListInFilterDropdown.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Projects are not in alphabetical order");
            page.BodyContainer.Click();
        }

        [Then(@"Teams in filter dropdown are displayed in alphabetical order")]
        public void ThenTeamsInFilterDropdownAreDisplayedInAlphabeticalOrder()
        {
            var page = _driver.NowAt<BaseGridPage>();
            var list = page.TeamListInFilterDropdown.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s, StringComparer.Ordinal), list, "Teams are not in alphabetical order");
            page.BodyContainer.Click();
        }

        [Then(@"Type of Projects in filter dropdown are displayed in alphabetical order")]
        public void ThenTypeOfProjectsInFilterDropdownAreDisplayedInAlphabeticalOrder()
        {
            var page = _driver.NowAt<BaseGridPage>();
            var list = page.ProjectsTypeListInFilterDropdown.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Projects Type are not in alphabetical order");
            page.BodyContainer.Click();
        }

        [Then(@"""(.*)"" value is displayed for Default column")]
        public void ThenValueIsDisplayedForDefaultColumn(string defaultValue)
        {
            var column = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(column.GetDefaultColumnValue(defaultValue),
                "Incorrect value is displayed for Default column");
        }

        [Then(@"Search fields for ""(.*)"" column contain correctly value")]
        public void ThenSearchFieldsForColumnContainCorrectlyValue(string columnName)
        {
            var searchField = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(searchField.GetSearchFieldTextByColumnName(columnName).Displayed(),
                "Incorrect contain value for search field");
        }

        [When(@"User clicks Reset Filters button on the Admin page")]
        public void WhenUserClicksResetFiltersButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Thread.Sleep(1000);
            _driver.WaitForDataLoading();
            button.ResetFiltersButton.Click();
        }

        [When(@"User clicks Group By button on the Admin page")]
        public void WhenUserClicksGroupByButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            button.GroupByButton.Click();
        }

        [When(@"User clicks Group By button on the Admin page and selects ""(.*)"" value")]
        public void WhenUserClicksGroupByButtonOnTheAdminPageAndSelectsValue(string value)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.GroupByButton.Click();
            _driver.MouseHover(page.GetValueInGroupByFilterOnAdminPAge(value));
            page.GetValueInGroupByFilterOnAdminPAge(value).Click();
            page.BodyContainer.Click();
        }

        [When(@"User clicks Refresh button on the Admin page")]
        public void WhenUserClicksRefreshButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Thread.Sleep(10000);
            _driver.WaitForDataLoading();
            button.RefreshButton.Click();
        }

        [Then(@"""(.*)"" Onboarded objects are displayed")]
        public void ThenOnboardedObjectsAreDisplayed(string objectsNumber)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.OnboardedObjectNumber(objectsNumber);
        }

        [When(@"User clicks Actions button on the Projects page")]
        public void WhenUserClicksActionsButtonOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ActionsButton.Click();
        }

        [Then(@"Actions button on the Projects page is active")]
        public void ThenActionsButtonOnTheProjectsPageIsActive()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            StringAssert.Contains("false", projectElement.ActionsButton.GetAttribute("aria-disabled"), "Actions button is inactive");
        }

        [Then(@"Actions button on the Projects page is not active")]
        public void ThenActionsButtonOnTheProjectsPageIsNotActive()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            StringAssert.Contains("true", projectElement.ActionsButton.GetAttribute("aria-disabled"), "Actions button is inactive");
        }

        [When(@"User clicks Delete Project button")]
        public void WhenUserClicksDeleteProjectButton()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.DeleteProjectInActions.Click();
        }

        [When(@"User removes selected item")]
        public void WhenUserRemovesSelectedItem()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.ActionsButton.Click();
            projectElement.DeleteButtonInActions.Click();
            projectElement.DeleteButtonOnPage.Click();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => projectElement.WarningMessage);
            _driver.WaitForDataLoading();
            projectElement.DeleteButtonInWarningMessage.Click();
        }

        [Then(@"""(.*)"" item was removed")]
        public void ThenItemWasRemoved(string itemName)
        {
            var item = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(item.GetCreatedProjectName(itemName), "Selected item was not removed");
        }

        [When(@"User cancels the selection of all rows on the Projects page")]
        public void WhenUserCancelsTheSelectionOfAllRowsOnTheProjectsPage()
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectAllCheckBox.Click();
        }

        [Then(@"Delete button is displayed to the User on the Projects page")]
        public void ThenDeleteButtonIsDisplayedToTheUserOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.DeleteValueInActions.Displayed(), "Delete Project Value is not displayed");
            Assert.IsTrue(projectElement.DeleteButtonOnPage.Displayed(), "Delete button is not displayed");
        }

        [Then(@"Delete button is not displayed to the User on the Projects page")]
        public void ThenDeleteButtonIsNotDisplayedToTheUserOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.ActionsInDropdown.Displayed(), "Actions is not displayed in the dropdown");
            Assert.IsFalse(projectElement.DeleteButtonOnPage.Displayed(), "Delete button is displayed");
        }

        [Then(@"Counter shows ""(.*)"" found rows")]
        public void ThenRowsAreDisplayedInTheAgGrid(string numberOfRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => foundRowsCounter.RowsCounter);
            StringAssert.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"Rows counter shows ""(.*)"" of ""(.*)"" rows")]
        public void ThenRowsCounterShowsOfRows(int selectedRows, int ofRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => foundRowsCounter.RowsCounter);
            StringAssert.AreEqualIgnoringCase(
                ofRows == 1 ? $"{selectedRows} of {ofRows} row" : $"{selectedRows} of {ofRows} rows",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"Rows counter contains ""(.*)"" found row of all rows")]
        [Then(@"Rows counter contains ""(.*)"" found rows of all rows")]
        public void ThenRowsCounterContainsFoundRowsOfAllRows(int foundRows)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.RowsCounter);
            Assert.That(page.RowsCounter.Text, Does.Contain(foundRows + " of "),
                $"Found rows counter doesn't contain {foundRows} found rows");
        }

        [Then(@"Rows counter shows more than ""(.*)"" found rows of all rows")]
        public void ThenRowsCounterShowsMoreThanFoundRowsOfAllRows(int foundRows)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.RowsCounter);
            var foundRowsOfAllRowsLabel = page.RowsCounter.Text;
            var foundRowsInt = Int32.Parse(foundRowsOfAllRowsLabel.Substring(0, foundRowsOfAllRowsLabel.IndexOf("of")));
            Assert.That(foundRowsInt, Is.GreaterThanOrEqualTo(foundRows),
                $"Found rows counter {foundRowsInt} is not greater or equal to expected {foundRows}");
        }

        [Then(@"User sees ""(.*)"" of ""(.*)"" rows selected label")]
        public void ThenUserSeesRowsSelectedLabel(int selectedRows, int ofRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => foundRowsCounter.RowsCounter);
            StringAssert.AreEqualIgnoringCase($"{selectedRows} of {ofRows} selected",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"User sees following tiles selected in the ""(.*)"" field:")]
        public void ThenUserSeesFollowingTilesSelectedInTheField(string dropdownName, Table items)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in items.Rows)
            {
                Assert.IsTrue(page.GetTilesByDropdownName(row["Items"]).Displayed,
                    $"{row["Items"]} is not displayed in {dropdownName} dropdown");
            }
        }

        [Then(@"User sees Buckets in next default sort order:")]
        public void ThenUserSeesBuketsInNextDefaultSortOrder(Table buckets)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < buckets.RowCount; i++)
                Assert.That(page.GridBucketsNames[i].Text, Is.EqualTo(buckets.Rows[i].Values.FirstOrDefault()),
                    "Buckets are not the same");
        }

        [Then(@"Columns on Admin page is displayed in following order:")]
        public void ThenColumnsOnAdminPageIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var columnNames = page.GetAllColumnHeaders().Select(column => column.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(expectedList, columnNames, "Columns order on Admin page is incorrect");
        }

        [Then(@"table with Setting menu column on Admin page is displayed in following order:")]
        public void ThenTableWithSettingMenuColumnOnAdminPageIsDisplayedInFollowingOrder(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var columnNames = page.GetAllColumnHeadersWithSettingMenuColumn().Select(column => column.Text).ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(expectedList, columnNames, "Columns order on Admin page with Setting menu column is incorrect");
        }

        [When(@"User creates following buckets in Administration:")]
        public void WhenUserCreatesFollowingBucketsInAdministration(Table buckets)
        {
            foreach (var bucket in buckets.Rows)
            {
                var action = _driver.NowAt<BaseDashboardPage>();
                action.GetActionsButtonByName("CREATE EVERGREEN BUCKET").Click();
                _driver.WaitForDataLoading();

                var page = _driver.NowAt<CreateBucketPage>();
                page.BucketNameField.Clear();
                page.BucketNameField.SendKeys(bucket.Values.FirstOrDefault());

                if (!string.IsNullOrEmpty(bucket.Values.FirstOrDefault()))
                    _buckets.Value.Add(bucket.Values.FirstOrDefault());

                page.TeamsNameField.Clear();
                _driver.WaitForDataLoading();
                page.TeamsNameField.SendKeys(bucket.Values.ElementAt(1));
                page.SelectTeam(bucket.Values.ElementAt(1));

                page.CreateBucketButton.Click();
                Logger.Write("Create Team button was clicked");
            }
        }

        [When(@"User clicks Default Ring checkbox")]
        public void WhenUserClicksDefaultRingCheckbox()
        {
            var page = _driver.NowAt<CreateRingPage>();
            page.DefaultRingCheckbox.Click();
        }

        [Then(@"Delete ""(.*)"" Project in the Administration")]
        public void ThenDeleteProjectInTheAdministration(string projectName)
        {
            var projectId = GetProjectId(projectName);
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[EvergreenProjects] where[ProjectId] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[ProjectGroups] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery(
                $"delete from[PM].[dbo].[SelfServiceScreenValueLanguage] where[ProjectId] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[SelfService] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery(
                $"delete from[PM].[dbo].[SelfServiceScreenValues] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Projects] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Projects] where[ProjectID] = '{projectId}'");
        }

        [Then(@"Delete ""(.*)"" Bucket in the Administration")]
        [When(@"User deletes ""(.*)"" Bucket in the Administration")]
        public void ThenDeleteBucketInTheAdministration(string bucketName)
        {
            //var projectId = DatabaseHelper.ExecuteReader($"SELECT [ProjectID] FROM[PM].[dbo].[Projects] where[ProjectName] = '{projectName}'", 0)[0];
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucketName}'");
        }

        [Then(@"Delete following Buckets in the Administration:")]
        public void ThenDeleteFollowingBucketsInTheAdministration(Table buckets)
        {
            foreach (var bucket in buckets.Rows)
                DatabaseHelper.ExecuteQuery(
                    $"delete from [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucket.Values.FirstOrDefault()}'");
        }


        [When(@"User updates readiness properties on Edit Readiness")]
        public void WhenUpdatesReadinessPropertiesOnEditPage(Table table)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["Readiness"]))
                {
                    createReadiness.ReadinessField.Clear();
                    createReadiness.ReadinessField.SendKeys(row["Readiness"]);
                }

                if (!string.IsNullOrEmpty(row["Tooltip"]))
                {
                    createReadiness.TooltipField.Clear();
                    createReadiness.TooltipField.SendKeys(row["Tooltip"]);
                }

                if (!string.IsNullOrEmpty(row["Ready"]))
                {
                    if (row["Ready"].ToLower().Equals("true"))
                    {
                        if (!createReadiness.ReadyCheckboxState.Selected)
                            createReadiness.ReadyCheckbox.Click();
                    }
                    if (row["Ready"].ToLower().Equals("false"))
                    {
                        if (createReadiness.ReadyCheckboxState.Selected)
                            createReadiness.ReadyCheckbox.Click();
                    }
                }

                if (!string.IsNullOrEmpty(row["DefaultForApplications"]))
                {
                    if (row["DefaultForApplications"].ToLower().Equals("true"))
                    {
                        if (!createReadiness.DefaultCheckBoxState.Selected)
                            createReadiness.DefaultForAppCheckBox.Click();
                    }
                    if (row["DefaultForApplications"].ToLower().Equals("false"))
                    {
                        if (createReadiness.DefaultCheckBoxState.Selected)
                            createReadiness.DefaultForAppCheckBox.Click();
                    }
                }

                if (!string.IsNullOrEmpty(row["ColourTemplate"]))
                {
                    createReadiness.ColourDropbox.Click();
                    createReadiness.SelectObjectForReadinessCreation(row["ColourTemplate"]);
                }
            }
        }


        [When(@"User enters ""(.*)"" in Readiness input on Edit Readiness")]
        public void WhenUpdatesReadinessNameFieldOnEditPage(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (!string.IsNullOrEmpty(text))
            {
                createReadiness.ReadinessField.Clear();
                createReadiness.ReadinessField.SendKeys(text);
            }
        }

        [Then(@"User sees ""(.*)"" in Readiness input on Edit Readiness")]
        public void ThenUserSeesReadinessNameOnEditPage(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            Assert.That(createReadiness.ReadinessField.GetAttribute("value"), Is.EqualTo(text));
        }

        [Then(@"Readiness input displayed disabled on Edit Readiness")]
        public void ThenUserSeesReadinessInputDisabledInEditPage()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Assert.That(createReadiness.ReadinessField.Enabled,
                Is.EqualTo(false), "Readiness input is in different state");
        }


        [When(@"User enters ""(.*)"" in Tooltip input on Edit Readiness")]
        public void WhenUpdatesTooltipNameOnEditPage(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (!string.IsNullOrEmpty(text))
            {
                createReadiness.TooltipField.Clear();
                createReadiness.TooltipField.SendKeys(text);
            }
        }

        [Then(@"User sees ""(.*)"" in Tooltip input on Edit Readiness")]
        public void ThenUserSeesTooltipNameOnEditPage(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            Assert.That(createReadiness.TooltipField.GetAttribute("value"), Is.EqualTo(text));
        }

        [Then(@"User sees Tooltip field not equal to ""(.*)"" on Edit Readiness")]
        public void ThenUserSeesTooltipNameNotEqualToOnEditPage(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            Assert.That(createReadiness.TooltipField.GetAttribute("value"), Is.Not.EqualTo(text));
        }


        [When(@"User sets Ready checkbox in ""(.*)"" on Edit Readiness")]
        public void WhenUpdatesReadinessReadyPropertiesOnEditPage(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (state.ToLower().Equals("true"))
            {
                if (!createReadiness.ReadyCheckboxState.Selected)
                    createReadiness.ReadyCheckbox.Click();
            }
            if (state.ToLower().Equals("false"))
            {
                if (createReadiness.ReadyCheckboxState.Selected)
                    createReadiness.ReadyCheckbox.Click();
            }
        }

        [Then(@"User sees Ready checkbox in ""(.*)"" state on Edit Readiness")]
        public void ThenUserSeesReadinessReadyCheckboxInEditPage(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Assert.That(createReadiness.ReadyCheckboxState.Selected.ToString().ToLower(),
                Is.EqualTo(state.ToLower()), "Readiness ready state is different");
        }


        [When(@"User sets Default for Applications checkbox in ""(.*)"" on Edit Readiness")]
        public void WhenUpdatesReadinessDefaultForPropertiesOnEditPage(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (state.ToLower().Equals("true"))
            {
                if (!createReadiness.DefaultCheckBoxState.Selected)
                    createReadiness.DefaultForAppCheckBox.Click();
            }
            if (state.ToLower().Equals("false"))
            {
                if (createReadiness.DefaultCheckBoxState.Selected)
                    createReadiness.DefaultForAppCheckBox.Click();
            }
        }

        [When(@"User clicks Default for Applications checkbox on Edit Readiness")]
        public void WhenUpdatesReadinessDefaultPropertiesOnEditPage()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            createReadiness.DefaultForAppCheckBox.Click();
        }

        [Then(@"User sees Default for Applications checkbox in ""(.*)"" state on Edit Readiness")]
        public void ThenUserSeesReadinessDefaultStateInEditPage(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Assert.That(createReadiness.DefaultCheckBoxState.Selected.ToString().ToLower(),
                Is.EqualTo(state.ToLower()), "Readiness default state is different");
        }

        [Then(@"User sees Default for Applications checkbox disabled on Edit Readiness")]
        public void ThenUserSeesReadinessDefaultStateDisabledInEditPage()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Assert.That(createReadiness.DefaultCheckBoxState.Enabled, Is.EqualTo(false), "Readiness default state is enabled");
        }


        [When(@"User clicks Colour Template field on Edit Readiness")]
        public void WhenClicksColourTemplateFieldOnEditPage()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            createReadiness.ColourDropbox.Click();
        }

        [Then(@"List of available colours displayed to user on Edit Readiness")]
        public void ThenUserSeesDropListExpandedOnEditPage()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Assert.That(createReadiness.GetColourStatusNumber(), Is.GreaterThan(0));
            Assert.That(createReadiness.GetColourStatusTextNumber(), Is.GreaterThan(0));
            Assert.That(createReadiness.GetColourStatusTextNumber(), Is.EqualTo(createReadiness.GetColourStatusTextNumber()));
        }

        [Then(@"List of available colours is not displayed to user on Edit Readiness")]
        public void ThenUserCantSeeDropListExpandedOnEditPage()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Assert.That(createReadiness.GetColourStatusTextNumber(), Is.EqualTo(0));
        }

        [When(@"User remembers opened Readiness data on Edit Readiness")]
        public void WhenUserRemembersReadinessName()
        {
            var page = _driver.NowAt<CreateReadinessPage>();
            page.Storage.SessionStorage.SetItem("readinessName", page.ReadinessField.GetAttribute("value"));
            page.Storage.SessionStorage.SetItem("readinessToolTip", page.TooltipField.GetAttribute("value"));
            page.Storage.SessionStorage.SetItem("readinessReady", page.ReadyCheckboxState.Selected.ToString().ToLower());
            page.Storage.SessionStorage.SetItem("readinessDefault", page.DefaultCheckBoxState.Selected.ToString().ToLower());
        }

        [When(@"User enters stored readiness name in Search field for ""(.*)"" column")]
        public void WhenUserEntersStoredTextInTheSearchFieldForColumn(string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.GetSearchFieldByColumnName(columnName, searchElement.Storage.SessionStorage.GetItem("readinessName"));
        }

        [Then(@"User checks that opened readiness name is the same as stored one")]
        public void ThenUserChecksThatReadinessNameIsDifferent()
        {
            var page = _driver.NowAt<CreateReadinessPage>();
            Assert.That(page.Storage.SessionStorage.GetItem("readinessName"), Is.EqualTo(page.ReadinessField.GetAttribute("value")), "Name is different from stored one");
        }

        [Then(@"Filtered readiness item equals to stored one")]
        public void ThenUserChecksThatStoredReadinessEqualsToDisplayedOne()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            var tooltip = page.GetRowContentByColumnName("Tooltip");
            var defaultFor = page.GetRowContentByColumnName("Default for Applications");

            Assert.That(page.Storage.SessionStorage.GetItem("readinessToolTip"), Is.EqualTo(tooltip), "Tooltip is different from stored one");
            Assert.That(page.Storage.SessionStorage.GetItem("readinessDefault"), Is.EqualTo(defaultFor.ToLower()), "Default For state different from stored one");
        }

        [Then(@"Readiness ""(.*)"" displayed before None")]
        public void ThenUserSeesJustCreatedReadinessBeforeNoneItem(string title)
        {
            var readiness = _driver.NowAt<ReadinessPage>();
            List<string> labels = readiness.GetListOfReadinessLabel();

            Assert.That(labels.FindIndex(x => x.Equals(title)) + 1, Is.EqualTo(labels.FindIndex(x => x.Equals("NONE"))));
        }

        [When(@"User clicks ""(.*)"" button in the Readiness dialog screen")]
        public void WhenUserClicksButtonInTheReadinessDialogScreen(string buttonName)
        {
            var button = _driver.NowAt<ReadinessPage>();
            button.GetReadinessDialogContainerButtonByName(buttonName).Click();
        }

        [Then(@"""(.*)"" text is displayed in the Readiness Dialog Container")]
        public void ThenTextIsDisplayedInTheReadinessDialogContainer(string text)
        {
            var page = _driver.NowAt<ReadinessPage>();
            Assert.IsTrue(page.GetReadinessDialogContainerText(text).Displayed(), $"{text} title is not displayed in the Readiness Dialog Container");
        }

        [Then(@"""(.*)"" button is displayed in the warning message")]
        public void ThenButtonIsDisplayedInTheWarningMessageOnProjectPage(string text)
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.GetButtonOnWarningContainerByName(text).Displayed(), $"{text} button is not displayed in the Warning message");
        }

        [Then(@"""(.*)"" text is displayed in the warning message")]
        public void ThenTextIsDisplayedInTheWarningMessageOnProjectPage(string text)
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.WarningMessageText(text).Displayed(), $"{text} text is not displayed in the Warning message");
        }

        [Then(@"""(.*)"" title is displayed in the Readiness Dialog Container")]
        public void ThenTitleIsDisplayedInTheReadinessDialogContainer(string text)
        {
            var page = _driver.NowAt<ReadinessPage>();
            Assert.IsTrue(page.GetReadinessDialogContainerTitle(text).Displayed(), $"{text} title is not displayed in the Readiness Dialog Container");
        }

        [Then(@"Readiness Dialog Container is displayed to the User")]
        public void ThenReadinessDialogContainerIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ReadinessPage>();
            Assert.IsTrue(page.ReadinessDialogContainer.Displayed(), "Readiness Dialog Container is displayed");
        }

        [Then(@"User sees following Processing order on the Automation page")]
        public void ThenUserSeesFollowingProcessingOrderOnTheAutomationPage(Table processingOrder)
        {
            var page = _driver.NowAt<AutomationsPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < processingOrder.RowCount; i++)
                Assert.That(page.ProcessingOrderValues[i].Text, Is.EqualTo(processingOrder.Rows[i].Values.FirstOrDefault()),
                    "Processing order values are not the same");
        }

        [Then(@"User sees following Display order on the Automation page")]
        public void ThenUserSeesFollowingDisplayOrderOnTheAutomationPage(Table displaygOrder)
        {
            var page = _driver.NowAt<RingsPage>();
            _driver.WaitForDataLoading();
            for (var i = 0; i < displaygOrder.RowCount; i++)
                Assert.That(page.DisplayOrderValues[i].Text, Is.EqualTo(displaygOrder.Rows[i].Values.FirstOrDefault()),
                    "Display order values are displayed in the wrong order");
        }

        [When(@"User navigates to ""(.*)"" project details")]
        public void WhenUserNavigatesToProjectDetails(string projectName)
        {
            var projectId = GetProjectId(projectName);
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{projectId}/details");

            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.ActiveProjectByName(projectName), $"{projectName} is not displayed on the Project page");
        }

        // table example
        // | ProjectName | Scope | ProjectTemplate | Mode |
        [When(@"Project created via API and opened")]
        public void WhenUserCreateNewDashboardViaApi(Table table)
        {
            string pName = "";
            string pScope = "";
            string pTemplate = "";
            int pMode = 0;

            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["ProjectName"]))
                    pName = row["ProjectName"];

                if (!string.IsNullOrEmpty(row["Scope"]))
                    pScope = row["Scope"];

                if (row["ProjectTemplate"].Equals("None"))
                    pTemplate = "-1";

                pMode = row["Mode"].Equals("Standalone Project") ? 1 : 3;
            }

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/createProject";
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);
            request.AddParameter("Accept", "application/json");
            request.AddParameter("Content-Type", "application/json");

            request.AddParameter("modeId", pMode);
            request.AddParameter(GetCreateProjectRequestScopeProperty(pScope), GetObjectType(pScope));

            request.AddParameter("projectName", pName);
            request.AddParameter("template", pTemplate);

            var response = _client.Value.Post(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(
                    $"Unable to execute request. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["message"]}");

            var responseContent = JsonConvert.DeserializeObject<JObject>(response.Content);
            string projectId = responseContent["id"].ToString();

            _projects.Value.Add(pName);

            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{projectId}/details");

            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.ActiveProjectByName(pName), $"{pName} is not displayed on the Project page");
        }

        [AfterScenario("Delete_Newly_Created_Project")]
        public void DeleteNewlyCreatedProject()
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/deleteProjects";

            foreach (var projectName in _projects.Value)
            {
                try
                {
                    if (string.IsNullOrEmpty(projectName))
                        continue;

                    var projectId = GetProjectId(projectName);

                    var request = new RestRequest(requestUri);

                    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                    request.AddParameter("selectedObjectsList", projectId);

                    var response = _client.Value.Post(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                        Logger.Write($"Unable to execute request. URI: {requestUri}");
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during removing '{projectName}' Project: {e}");
                }
            }
        }

        [AfterScenario("Delete_Newly_Created_Bucket")]
        public void DeleteAllBucketAfterScenarioRun()
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/bucket/deleteBuckets";

            foreach (var bucketName in _buckets.Value)
            {
                try
                {
                    if (string.IsNullOrEmpty(bucketName))
                        continue;

                    var bucketId = DatabaseHelper.ExecuteReader(
                        $"SELECT [GroupID] FROM [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucketName}'", 0)[0];

                    var request = new RestRequest(requestUri);

                    request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                    request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                    request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                    request.AddParameter("objectId", null);
                    request.AddParameter("selectedObjectsList", bucketId);

                    var response = _client.Value.Put(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                        Logger.Write($"Unable to execute request. URI: {requestUri}");
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during '{bucketName}' Bucket removing: {e}");
                }
            }
        }

        private string GetProjectId(string projectName)
        {
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectID] FROM [PM].[dbo].[Projects] where [ProjectName] = '{projectName}' AND [IsDeleted] = 0",
                    0).LastOrDefault();
            return projectId;
        }

        private string GetTaskCapacityEnabledFlag(string taskId)
        {
            var flagState =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [CapacityEnabled] FROM [PM].[dbo].[ProjectTasks] where [TaskID] = '{taskId}'", 0).LastOrDefault();
            return flagState;
        }


        private string GetCreateProjectRequestScopeProperty(string scope)
        {
            return new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(scope) ? "objectType" : "listId";
        }

        private string GetObjectType(string scope)
        {
            return new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(scope) ? GetProjectObjectTypeScope(scope) : GetProjectListIdScope(scope);
        }

        private string GetProjectObjectTypeScope(string scope)
        {
            if (scope.Equals("All Devices"))
                return "Devices";
            if (scope.Equals("All Users"))
                return "Users";
            if (scope.Equals("All Mailboxes"))
                return "Mailboxes";
            return "NOT FOUND";
        }

        private string GetProjectListIdScope(string listName)
        {
            //string userId =
            //    DatabaseHelper.ExecuteReader(
            //        $"SELECT [aspnetdb].[dbo].[aspnet_Users].[UserId] FROM[aspnetdb].[dbo].[aspnet_Users] where UserName = '{_user.UserName}'", 0).LastOrDefault();

            return DatabaseHelper.ExecuteReader(
                    $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0).LastOrDefault();
        }
    }
}