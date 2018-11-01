using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
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
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly TeamName _teamName;
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly Buckets _buckets;
        private readonly RestWebClient _client;
        private readonly LastUsedBucket _lastUsedBucket;
        private readonly AddedObjects _addedObjects;

        public EvergreenJnr_AdminPage(RemoteWebDriver driver, TeamName teamName, DTO.RuntimeVariables.Projects projects,
            RestWebClient client, Buckets buckets, LastUsedBucket lastUsedBucket, AddedObjects addedObjects)
        {
            _driver = driver;
            _teamName = teamName;
            _projects = projects;
            _client = client;
            _buckets = buckets;
            _lastUsedBucket = lastUsedBucket;
            _addedObjects = addedObjects;
        }

        [When(@"User clicks ""(.*)"" link on the Admin page")]
        public void WhenUserClicksLinkOnTheAdminPage(string adminLinks)
        {
            var menu = _driver.NowAt<AdminLeftHandMenu>();

            switch (adminLinks)
            {
                case "Projects":
                    menu.Projects.Click();
                    break;

                case "Teams":
                    menu.Teams.Click();
                    break;

                case "Buckets":
                    menu.Buckets.Click();
                    break;

                case "Capacity Units":
                    menu.CapacityUnits.Click();
                    break;

                default:
                    throw new Exception($"'{adminLinks}' link is not valid menu item and can not be opened");
            }

            Logger.Write($"{adminLinks} left-hand menu was clicked");
        }

        [Then(@"""(.*)"" page should be displayed to the user")]
        public void ThenPageShouldBeDisplayedToTheUser(string pageTitle)
        {
            switch (pageTitle)
            {
                case "Projects":
                    var projectsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(projectsPage.ProjectsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Teams":
                    var teamsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(teamsPage.TeamsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Buckets":
                    var bucketsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(bucketsPage.BucketsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Team":
                    var createTeamPage = _driver.NowAt<CreateTeamPage>();
                    StringAssert.Contains(createTeamPage.CreateTeamFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Bucket":
                    var createBucketPage = _driver.NowAt<CreateBucketPage>();
                    StringAssert.Contains(createBucketPage.CreateBucketFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Project":
                    var createProjectPage = _driver.NowAt<CreateProjectPage>();
                    StringAssert.Contains(createProjectPage.CreateProjectFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Import Project":
                    var importProjectPage = _driver.NowAt<ImportProjectPage>();
                    StringAssert.Contains(importProjectPage.ImportProjectFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Capacity Units":
                    var capacityUnitsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(capacityUnitsPage.CapacityUnitsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                default:
                    throw new Exception($"'{pageTitle}' menu item is not valid ");
            }

            Logger.Write($"'{pageTitle}' page is visible");
        }

        [When(@"User clicks ""(.*)"" navigation link on the Admin page")]
        public void WhenUserClicksNavigationLinkOnTheAdminPage(string linkName)
        {
            var link = _driver.NowAt<ProjectsPage>();
            link.GetNavigationLinkByName(linkName).Click();
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
            bucketName.GetFieldNameByPage(fieldName).Clear();
            bucketName.GetFieldNameByPage(fieldName).SendKeys(name);

            if (!string.IsNullOrEmpty(name))
                switch (fieldName)
                {
                    case "Project Name":
                        _projects.Value.Add(name);
                        break;
                    case "Team Name":
                        _teamName.Value.Add(name);
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

        [Then(@"Scope field is automatically populated")]
        public void ThenScopeFieldIsAutomaticallyPopulated()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            Assert.IsFalse(page.EmptyScopeField.Displayed(), "Scope field is empty");
        }

        [When(@"User enters ""(.*)"" value in the ""(.*)"" field")]
        public void WhenUserEntersValueInTheField(string name, string fieldName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetFieldNameByPage(fieldName).Clear();
            page.GetFieldNameByPage(fieldName).SendKeys(name);
        }

        [When(@"User selects ""(.*)"" tab on the Project details page")]
        public void WhenUserSelectTabOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.NavigateToProjectTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" tab is selected on the Admin page")]
        public void ThenTabIsSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectTabs.GetsSelectedTabByName(tabName).Displayed(), "Selected tab is not active");
        }

        [When(@"User selects ""(.*)"" tab on the Capacity Units page")]
        public void WhenUserSelectsTabOnTheCapacityUnitsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.GetTabByNameOnCapacityUnits(tabName).Click();
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

        [When(@"User click on ""(.*)"" column header on the Admin page")]
        public void WhenUserClickOnColumnHeaderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            adminTable.GetColumnHeaderByName(columnName).Click();
        }

        [Then(@"data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();

            var actualList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
            Assert.IsTrue(adminTable.AscendingSortingIcon.Displayed);
        }

        [Then(@"data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Assert.IsTrue(adminTable.DescendingSortingIcon.Displayed);
        }

        [Then(@"data in table is sorted by ""(.*)"" column in ascending order by default on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();

            var actualList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
        }

        [Then(@"data in table is sorted by ""(.*)"" column in descending order by default on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
        }

        [Then(@"numeric data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();

            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"numeric data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"color data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenColorDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<Colors>(new List<string>(expectedList));
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"color data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenColorDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<Colors>(new List<string>(expectedList), false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseGridPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"Project ""(.*)"" is displayed to user")]
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

        [When(@"User clicks ""(.*)"" checkbox from String Filter on the Admin page")]
        public void WhenUserClicksCheckboxFromStringFilterOnTheAdminPage(string filterName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.GetBooleanStringFilterByName(filterName);
            page.BodyContainer.Click();
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
            filter.ResetFiltersButton.Click();
            foreach (var row in table.Rows) filter.DateFilterValue.SendKeys(row["FilterData"]);

            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" checkbox from String Filter on the Admin page")]
        public void WhenUserSelectsCheckboxFromStringFilterOnTheAdminPage(string filterName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetCheckboxStringFilterByName(filterName);
            page.BodyContainer.Click();
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
        public void WhenUserSelectsAllRowsOnTheGrid()
        {
            var checkbox = _driver.NowAt<BaseGridPage>();
            checkbox.BodyContainer.Click();
            checkbox.SelectAllCheckBox.Click();
        }

        [Then(@"Select All selectbox is checked on the Admin page")]
        public void ThenSelectAllSelectBoxIsCheckedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.SelectAllCheckboxChecked.Displayed(), "Select All checkbox is unchecked");
        }

        [Then(@"Select All selectbox is unchecked on the Admin page")]
        public void ThenSelectAllSelectBoxIsUncheckedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.SelectAllCheckboxChecked.Displayed(), "Select All checkbox is checked");
        }

        [When(@"User selects ""(.*)"" checkbox on the Project details page")]
        public void WhenUserSelectCheckboxOnTheProjectDetailsPage(string radioButtonName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectRadioButtonByName(radioButtonName).Click();
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

        [When(@"User selects incorrect file to upload on Import Project page")]
        public void WhenUserSelectsIncorrectFileToUploadOnImportProjectPage()
        {
            var page = _driver.NowAt<ImportProjectPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            var file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                       ResourceFilesNamesProvider.IncorrectFile;
            page.ButtonChooseFile.SendKeys(file);
        }

        [When(@"User selects correct file to upload on Import Project page")]
        public void WhenUserSelectsCorrectFileToUploadOnImportProjectPage()
        {
            var page = _driver.NowAt<ImportProjectPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            var file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                       ResourceFilesNamesProvider.CorrectFileDas12370;
            page.ButtonChooseFile.SendKeys(file);
        }

        [When(@"User enters ""(.*)"" in the Project Name field on Import Project page")]
        public void ThenUserEntersInTheProjectNameFieldOnImportProjectPage(string projectName)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            page.ProjectNameField.SendKeys(projectName);
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

        [Then(@"User sees folloing options in ""(.*)"" dropdown on Import Projects page:")]
        public void ThenUserSeesFollowingOptionsInDropdownOnImportProjectPage(string dropdownName, Table options)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            List<string> actualBucketsOptions = page.GetDropdownOptions(dropdownName);

            for (int i = 0; i < options.RowCount; i++)
            {
                Assert.That(actualBucketsOptions[i], Is.EqualTo(options.Rows[i].Values.FirstOrDefault()), "Options do not match!");
            }
        }

        [When(@"User selects ""(.*)"" option in the ""(.*)"" dropdown on the Import Project Page")]
        public void ThenUserSelectsInTheImportDropdownOnTheImportProjectPage(string optionName, string dropdownName)
        {
            var importProjectPage = _driver.NowAt<ImportProjectPage>();
            importProjectPage.SelectDropdownOption(dropdownName, optionName);
        }

        [Then(@"Delete ""(.*)"" Team in the Administration")]
        public void ThenDeleteTeamInTheAdministration(string teamName)
        {
            DeleteTeam(teamName);
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

        [When(@"User selects ""(.*)"" in the ""(.*)"" dropdown")]
        public void WhenUserSelectsInTheDropdown(string value, string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            dropdown.GetDropdownByName(dropdownName).Click();
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

        [When(@"User clicks Default unit checkbox")]
        public void WhenUserClicksDefaultUnitCheckbox()
        {
            var capacityElement = _driver.NowAt<Capacity_UnitsPage>();
            capacityElement.DefaultCapacityUnitCheckbox.Click();
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
            Assert.IsTrue(page.PageTitle.Displayed(), "Reassign Buckets page is not displayed");
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

        #region Table content

        [Then(@"Content is present in the table on the Admin page")]
        public void ThenContentIsPresentInTheTableOnTheAdminPage()
        {
            var tableElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => tableElement.TableContent);
            Assert.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
        }

        [When(@"User clicks content from ""(.*)"" column")]
        public void WhenUserClicksContentFromColumn(string columnName)
        {
            var tableElement = _driver.NowAtWithoutWait<BaseGridPage>();
            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
        }

        #endregion

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
            objects.SelectObjectByName(objectName);
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

        #region Message

        [Then(@"Blue banner with ""(.*)"" text is displayed")]
        public void ThenBlueBannerWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.BlueBanner);
            StringAssert.Contains(text, page.BlueBanner.Text, "Blue banner is not displayed correctly");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on the Admin page")]
        public void ThenWarningMessageWithTextIsDisplayedOnTheAdminPage(string text)
        {
            BaseGridPage message;
            try
            {
                message = _driver.NowAt<BaseGridPage>();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    message = _driver.NowAt<BaseGridPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    message = _driver.NowAt<BaseGridPage>();
                }
            }

            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => message.WarningMessage);
            Assert.AreEqual("rgba(235, 175, 37, 1)", message.GetMessageColor()); //Amber color
            Assert.IsTrue(message.TextMessage(text),
                $"{text} is not displayed on the Project page");
        }

        [Then(@"Warning message is not displayed on the Admin page")]
        public void ThenWarningMessageIsNotDisplayedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.WarningMessage.Displayed());
        }

        [Then(@"""(.*)"" warning message is not displayed on the Buckets page")]
        public void ThenWarningMessageIsNotDisplayedOnTheBucketsPage(string warningText)
        {
            var message = _driver.NowAt<BucketsPage>();
            Assert.IsFalse(message.WarningDeleteBucketMessage(warningText),
                $"{warningText} warning message is displayed on the Buckets page");
        }

        [When(@"User clicks Cancel button in the warning message on the Admin page")]
        public void WhenUserClicksCancelButtonInTheWarningMessageOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.CancelButtonInWarning.Click();
        }

        [When(@"User clicks Delete button in the warning message")]
        public void WhenUserClicksDeleteButtonInTheWarningMessage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.WarningMessage);
            button.DeleteButtonInWarningMessage.Click();
            Logger.Write("Delete button was clicked");
        }

        [When(@"User clicks ""(.*)"" button in the warning message on Admin page")]
        public void WhenUserClicksButtonInTheWarningMessageOnAdminPage(string buttonName)
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.WarningMessage);
            button.GetButtonInWarningMessage(buttonName).Click();
            Logger.Write($"{buttonName} button was clicked");
        }

        [Then(@"Info message is displayed and contains ""(.*)"" text")]
        public void ThenInfoMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.BlueBanner);
            Assert.AreEqual("rgba(49, 122, 193, 1)", page.GetMessageColor()); //Blue color
            Assert.AreEqual("1530px", page.GetMessageWidthOnAdminPage());
            StringAssert.Contains(text, page.BlueBanner.Text, "Success Message is not displayed");
        }

        [Then(@"""(.*)"" message is displayed on the Admin Page")]
        public void ThenMessageIsDisplayedOnTheAdminPage(string message)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.NoFoundMessage);
            Assert.AreEqual(message, page.NoFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"User sees banner at the top of work area")]
        public void ThenUserSeesBannerAtTheTopOfWorkArea()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.Banner);
            Assert.That(page.Banner.Displayed, Is.True, "Banner is not displayed");
        }

        [Then(@"Success message is displayed and contains ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.SuccessMessage);
            Assert.AreEqual("rgba(126, 189, 56, 1)", page.GetMessageColor()); //Green color
            StringAssert.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Success message is displayed correctly")]
        public void ThenSuccessMessageIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.SuccessMessage);
            Assert.AreEqual("rgba(126, 189, 56, 1)", page.GetMessageColor()); //Green color
            Assert.AreEqual("1530px", page.GetMessageWidthOnAdminPage());
            Assert.AreEqual("34px", page.GetMessageHeightOnAdminPage());
        }

        [Then(@"Success message The ""(.*)"" bucket has been updated is displayed on the Buckets page")]
        public void ThenSuccessMessageTheBucketHasBeenUpdatedIsDisplayedOnTheBucketsPage(string bucketName)
        {
            var pageBase = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => pageBase.SuccessMessage);
            var pageBuckets = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(pageBuckets.SuccessUpdatedMessageBucketsPage(bucketName),
                $"Success Message is not displayed for {bucketName}");
        }

        [Then(@"Success message with ""(.*)"" text is displayed on the Projects page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnTheProjectsPage(string textMessage)
        {
            BaseGridPage projectElement;
            try
            {
                projectElement = _driver.NowAt<BaseGridPage>();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    projectElement = _driver.NowAt<BaseGridPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    projectElement = _driver.NowAt<BaseGridPage>();
                }
            }

            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => projectElement.SuccessMessage);
            Thread.Sleep(10000);
            Assert.IsTrue(projectElement.TextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
        }

        [Then(@"Success message is not displayed on the Projects page")]
        public void ThenSuccessMessageIsNotDisplayedOnTheProjectsPage()
        {
            var message = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(message.SuccessMessage.Displayed());
        }

        [When(@"User clicks newly created object link")]
        public void WhenUserClicksNewlyCreatedObjectLink()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            projectElement.NewProjectLink.Click();
        }

        [Then(@"Success message is displayed and contains ""(.*)"" link")]
        public void ThenSuccessMessageIsDisplayedAndContainsLink(string text)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.GetLinkByText(text).Displayed(), $"Message with {text} link is not displayed");
        }

        [Then(@"Error message with ""(.*)"" text is displayed")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.ErrorMessage);
            Assert.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"Error message is not displayed on the Capacity Slots page")]
        [Then(@"Error message is not displayed on the Projects page")]
        public void ThenErrorMessageIsNotDisplayedOnTheProjectsPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.ErrorMessage.Displayed(), "Error Message is displayed");
        }

        [When(@"User close message on the Admin page")]
        public void WhenUserCloseMessageOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.CloseMessageButton.Click();
        }

        #endregion

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
            Assert.IsTrue(button.CorrectActionsButton.Displayed(), "Actions dropdown is not displayed correctly");
        }

        [When(@"User clicks on Actions button")]
        public void ThenUserClicksOnActionsButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.ActionsButton);
            button.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [When(@"User selects ""(.*)"" in the Actions")]
        public void ThenUserSelectInTheActions(string actionName)
        {
            var action = _driver.NowAt<BaseGridPage>();
            action.SelectActions(actionName);
        }

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

        [When(@"User searches and selects following rows in the grid:")]
        public void WhenUserSearchesAndSelectsFollowingRowsInTheGrid(Table table)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            dashboardPage.TableSearchButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => dashboardPage.TableSearchTextBox);
            foreach (var row in table.Rows)
            {
                dashboardPage.TableSearchTextBox.Clear();
                dashboardPage.TableSearchTextBox.SendKeys(row["SelectedRowsName"]);
                Thread.Sleep(5000);
                _driver.WaitForDataLoading();
                dashboardPage.SelectOneRowsCheckboxes.Click();
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
        public void ThenFollowingItemsAreDisplayedInTheHistoryTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
                if (!projectElement.OnboardedObjectsTable.Displayed())
                    try
                    {
                        Thread.Sleep(20000);
                        _driver.Navigate().Refresh();
                        Assert.IsTrue(projectElement.HistoryOnboardedObjectDisplayed(row["Items"]).Displayed);
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(40000);
                        _driver.Navigate().Refresh();
                        Assert.IsTrue(projectElement.HistoryOnboardedObjectDisplayed(row["Items"]).Displayed);
                    }
                else
                    Assert.IsTrue(projectElement.HistoryOnboardedObjectDisplayed(row["Items"]).Displayed);
        }

        [Then(@"additional onboarded Items are displayed in the History table")]
        public void ThenAdditionalOnboardedItemsAreDisplayedInTheHistoryTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
                try
                {
                    Thread.Sleep(20000);
                    _driver.Navigate().Refresh();
                    Assert.IsTrue(projectElement.HistoryOnboardedObjectDisplayed(row["Items"]).Displayed,
                        $"{row["Items"]} is not displayed in History table");
                }
                catch (Exception)
                {
                    Thread.Sleep(30000);
                    _driver.Navigate().Refresh();
                    Assert.IsTrue(projectElement.HistoryOnboardedObjectDisplayed(row["Items"]).Displayed,
                        $"{row["Items"]} is not displayed in History table");
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
            page.CreateProjectButton.Click();
            _driver.WaitForDataLoading();
            Logger.Write("Create Project button was clicked");
        }

        [Then(@"created Project with ""(.*)"" name is displayed correctly")]
        public void ThenCreatedProjectWithNameIsDisplayedCorrectly(string projectName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetCreatedProjectName(projectName), "Created Project is not found");
        }

        [Then(@"Import Project button is not displayed")]
        public void ThenImportProjectButtonIsNotDisplayed()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(button.ImportProjectButton.Displayed(), "Import Project button is displayed");
        }

        [When(@"User selects ""(.*)"" in the Scope Project dropdown")]
        public void ThenUserSelectsInTheScopeProjectDropdown(string objectName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.SelectObjectForProjectCreation(objectName);
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

        [Then(@"User selects ""(.*)"" option for selected language")]
        public void ThenUserSelectsOptionForSelectedLanguage(string optionName)
        {
            var projectPage = _driver.NowAt<ProjectsPage>();
            projectPage.GetLanguageMenuOptionByName(optionName).Click();
        }

        [When(@"User changes Name to ""(.*)"" in the ""(.*)"" field on the Project details page")]
        [When(@"User type ""(.*)"" Name in the ""(.*)"" field on the Project details page")]
        public void WhenUserTypeNameInTheFieldOnTheProjectDetailsPage(string name, string fieldName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.GetFieldByName(fieldName).Clear();
            projectElement.GetFieldByName(fieldName).SendKeys(name);
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
            Thread.Sleep(10000);
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

        [When(@"User enters ""(.*)"" date in the ""(.*)"" field")]
        public void WhenUserEntersDateInTheField(string date, string fieldName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.AddDateByFieldName(fieldName, date);
        }

        [Then(@"""(.*)"" text in search field is displayed correctly for ""(.*)"" column")]
        public void ThenTextInSearchFieldIsDisplayedCorrectlyForColumn(string searchText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.AreEqual(page.GetTextInSearchFieldByColumnName(columnName).GetAttribute("value"), searchText,
                "Text in search field is different");
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" field")]
        public void ThenContentIsDisplayedInField(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.AreEqual(page.GetTextInFieldByFieldName(fieldName).GetAttribute("value"), text,
                $"Text in {fieldName} field is different");
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" drop-down field")]
        public void ThenContentIsDisplayedInDrop_DownField(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            //TODO Check GetAttribute for drop-down field (does not work)
            Assert.AreEqual(page.GetTextInDropDownByFieldName(fieldName).GetAttribute("value"), text,
                $"Text for {fieldName} field is not correctly");
        }

        [Then(@"Capacity Units value is displayed for Capacity Mode field")]
        public void ThenCapacityUnitsValueIsDisplayedForCapacityModeField()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.DefaultCapacityMode.Displayed, "Default value is not displayed for Capacity Mode");
        }

        [Then(@"Menu options are displayed in the following order on the Admin page:")]
        public void ThenMenuOptionsAreDisplayedInTheFollowingOrderOnTheAdminPage(Table table)
        {
            var action = _driver.NowAt<BaseGridPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.MenuTabOptionListOnAdminPage.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Menu options are different");
        }

        [Then(@"column content is displayed in the following order:")]
        public void ThenColumnContentIsDisplayedInTheFollowingOrder(Table table)
        {
            var action = _driver.NowAt<BaseGridPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = action.TableContentList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Column content is different");
        }

        [Then(@"""(.*)"" dropdown is not displayed")]
        public void ThenDropdownIsNotDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(dropdown.GetMissingDropdownByName(dropdownName), $"{dropdownName} is displayed");
        }

        [Then(@"""(.*)"" dropdown is displayed")]
        public void ThenDropdownIsDisplayed(string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(dropdown.GetDropdownByName(dropdownName).Displayed(), $"{dropdownName} is not displayed");
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
            var dropdown = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(dropdown.GetDropdownByValueByName(value, dropdownName).Displayed(), $"{value} is not displayed in the {dropdownName}");
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
            Assert.IsFalse(filterElement.CheckStringFilterByName(filterName));
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
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => foundRowsCounter.RowsCounter);
            StringAssert.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
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

        [Then(@"User sees Buckets in next default sort order:")]
        public void ThenUserSeesBuketsInNextDefaultSortOrder(Table buckets)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < buckets.RowCount; i++)
                Assert.That(page.GridBucketsNames[i].Text, Is.EqualTo(buckets.Rows[i].Values.FirstOrDefault()),
                    "Buckets are not the same");
        }

        [When(@"User creates following buckets in Administration:")]
        public void WhenUserCreatesFollowingBucketsInAdministration(Table buckets)
        {
            foreach (var bucket in buckets.Rows)
            {
                var action = _driver.NowAt<BaseDashboardPage>();
                action.GetActionsButtonByName("CREATE BUCKET").Click();
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

        [AfterScenario("Delete_Newly_Created_Team")]
        public void DeleteAllTeamsAfterScenarioRun()
        {
            try
            {
                if (!_teamName.Value.Any())
                    return;

                foreach (var name in _teamName.Value)
                    try
                    {
                        DeleteTeam(name);
                    }
                    catch
                    {
                    }
            }
            catch
            {
            }
        }

        [AfterScenario("Delete_Newly_Created_Project")]
        public void DeleteNewlyCreatedProject()
        {
            try
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/deleteProjects";

                foreach (var projectName in _projects.Value)
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
                        throw new Exception($"Unable to execute request. URI: {requestUri}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [AfterScenario("Delete_Newly_Created_Bucket")]
        public void DeleteAllBucketAfterScenarioRun()
        {
            try
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/bucket/deleteBuckets";

                foreach (var bucketName in _buckets.Value)
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
                        throw new Exception($"Unable to execute request. URI: {requestUri}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DeleteTeam(string teamName)
        {
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[Teams] where [TeamName] = '{teamName}'");
        }

        private string GetProjectId(string projectName)
        {
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectID] FROM [PM].[dbo].[Projects] where [ProjectName] = '{projectName}' AND [IsDeleted] = 0",
                    0).LastOrDefault();
            return projectId;
        }
    }
}