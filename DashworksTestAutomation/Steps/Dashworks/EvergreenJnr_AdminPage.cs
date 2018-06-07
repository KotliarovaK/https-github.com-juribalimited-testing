using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly TeamName _teamName;
        private readonly UsedUsers _usedUsers;

        public EvergreenJnr_AdminPage(RemoteWebDriver driver, UsedUsers usedUsers, TeamName teamName)
        {
            _driver = driver;
            _usedUsers = usedUsers;
            _teamName = teamName;
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

                default:
                    throw new Exception($"'{pageTitle}' menu item is not valid ");
            }

            Logger.Write($"'{pageTitle}' page is visible");
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

        [When(@"User opens Scope section on the Project details page")]
        public void WhenUserOpensScopeSectionOnTheProjectDetailsPage()
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.ScopeSection.Click();
        }

        [When(@"User selects ""(.*)"" tab on the Project details page")]
        public void WhenUserSelectTabOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.NavigateToProjectTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        [When(@"User navigates to the ""(.*)"" tab in the Scope section on the Project details page")]
        public void WhenUserNavigatesToTheTabInTheScopeSectionOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.NavigateToProjectTabInScopSectionByName(tabName);
            _driver.WaitForDataLoading();
        }

        [Then(@"All Association are selected by default")]
        public void ThenAllAssociationAreSelectedByDefault()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectsPage.UncheckedCheckbox.Displayed(), "Not all checkboxes are selected");
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
                page = _driver.NowAt<ProjectsPage>();
            }

            Assert.IsTrue(page.SelectedTabInProjectScopeChangesSection(tabName),
                $"{tabName} is not displayed in the Project Scope Changes section");
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

            Assert.IsTrue(page.SelectedItemInProjectScopeChangesSection(text),
                $"{text} is not displayed in the Project Scope Changes section");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on the Project details page")]
        public void ThenWarningMessageWithTextIsDisplayedOnTheProjectDetailsPage(string text)
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.WarningMessageProjectPage(text), "Warning Message is not displayed");
        }

        [When(@"User selects ""(.*)"" checkbox on the Project details page")]
        public void WhenUserSelectCheckboxOnTheProjectDetailsPage(string radioButtonName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectRadioButtonByName(radioButtonName);
        }

        [When(@"User clicks ""(.*)"" checkbox on the Project details page")]
        public void WhenUserClicksCheckboxOnTheProjectDetailsPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectCheckboxByName(checkboxName);
        }

        [When(@"User clicks ""(.*)"" button on the Projects page")]
        public void WhenUserClicksButtonOnTheProjectsPage(string buttonName)
        {
            var button = _driver.NowAt<ProjectsPage>();
            button.ClickUpdateButtonByName(buttonName);
        }

        [When(@"User clicks Update Project button on the Projects page")]
        public void WhenUserClicksUpdateProjectButtonOnTheProjectsPage()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.UpdateProjectInTheWarning);
            button.UpdateProjectInTheWarning.Click();
        }

        [Then(@"Update Project button is disabled")]
        public void ThenUpdateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => button.UpdateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.UpdateProjectButton.GetAttribute("disabled")),
                "Update Project button is active");
        }

        [When(@"User clicks Cancel button")]
        public void WhenUserClicksCancelButton()
        {
            var page = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => page.CancelButton);
            page.CancelButton.Click();
            Logger.Write("Cancel button was clicked");
        }

        [When(@"User clicks Create New Item button")]
        public void WhenUserClicksCreateNewItemButton()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.CreateItemButton);
            page.CreateItemButton.Click();
            Logger.Write("Create New Item button was clicked");
        }

        [Then(@"Delete ""(.*)"" Team in the Administration")]
        public void ThenDeleteTeamInTheAdministration(string teamName)
        {
            DeleteTeam(teamName);
        }

        [AfterScenario("Delete_Newly_Created_Team")]
        public void DeleteAllTeamsAfterScenarioRun()
        {
            try
            {
                if (!_teamName.Value.Any())
                    return;

                foreach (string name in _teamName.Value)
                    try
                    {
                        DeleteTeam(name);
                    }
                    catch { }
            }
            catch {}
        }

        private void DeleteTeam(string teamName)
        {
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Teams] where[TeamName] = '{teamName}'");
        }

        [When(@"User enters ""(.*)"" in the Team Name field")]
        public void ThenUserEntersInTheTeamNameField(string teamName)
        {
            var teamPage = _driver.NowAt<CreateTeamPage>();
            teamPage.TeamNameField.SendKeys(teamName);
            _teamName.Value.Add(teamName);
        }

        [When(@"User enters ""(.*)"" in the Team Description field")]
        public void WhenUserEntersInTheTeamDescriptionField(string descriptionText)
        {
            var teamName = _driver.NowAt<CreateTeamPage>();
            teamName.TeamDescriptionField.Clear();
            teamName.TeamDescriptionField.SendKeys(descriptionText);
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

        [When(@"User clicks Create Team button on the Create Team page")]
        public void ThenUserClicksCreateTeamButtonOnTheCreateTeamPage()
        {
            var page = _driver.NowAt<CreateTeamPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateTeamPage>(() => page.CreateTeamButton);
            page.CreateTeamButton.Click();
            Logger.Write("Create Team button was clicked");
        }

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

        [Then(@"Content is present in the table on the Teams Page")]
        public void ThenContentIsPresentInTheTableOnTheTeamsPage()
        {
            var tableElement = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => tableElement.TableContent);
            Assert.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
        }

        [When(@"User clicks content from ""(.*)"" column")]
        public void WhenUserClicksContentFromColumn(string columnName)
        {
            var tableElement = _driver.NowAtWithoutWait<BaseGridPage>();
            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
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

        [When(@"User enters ""(.*)"" in the Bucket Name field")]
        public void ThenUserEntersInTheBucketNameField(string bucketText)
        {
            var bucketName = _driver.NowAt<CreateBucketPage>();
            bucketName.BucketNameField.SendKeys(bucketText);
        }

        [When(@"User selects ""(.*)"" team in the Team dropdown on the Buckets page")]
        public void ThenUserSelectTeamInTheTeamDropdownOnTheBucketsPage(string teamName)
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.TeamsNameField.SendKeys(teamName);
            createBucketElement.SelectTeam(teamName);
        }

        [When(@"User clicks Create button on the Create Bucket page")]
        public void WhenUserClicksCreateButtonOnTheCreateBucketPage()
        {
            var page = _driver.NowAt<CreateBucketPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateBucketPage>(() => page.CreateBucketButton);
            page.CreateBucketButton.Click();
            Logger.Write("Create Team button was clicked");
        }

        [Then(@"Success message is displayed and contains ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.SuccessMessage);
            StringAssert.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
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

        [Then(@"Error message with ""(.*)"" text is displayed")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.ErrorMessage);
            Assert.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"""(.*)"" bucket details is displayed to the user")]
        public void ThenBucketDetailsIsDisplayedToTheUser(string bucketName)
        {
            var teamElement = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(teamElement.AppropriateBucketName(bucketName),
                $"{bucketName} is not displayed on the Bucket page");
        }

        [When(@"User selects all rows on the grid")]
        public void WhenUserSelectsAllRowsOnTheGrid()
        {
            var checkbox = _driver.NowAt<BaseGridPage>();
            checkbox.SelectAllCheckBox.Click();
        }

        [When(@"User clicks on Actions button")]
        public void ThenUserClicksOnActionsButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.ActionsButton);
            button.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [When(@"User selects ""(.*)"" in the Actions dropdown")]
        public void ThenUserSelectInTheActionsDropdown(string actionName)
        {
            var action = _driver.NowAt<BaseGridPage>();
            action.SelectActions(actionName);
        }

        [Then(@"""(.*)"" warning message is not displayed on the Buckets page")]
        public void ThenWarningMessageIsNotDisplayedOnTheBucketsPage(string warningText)
        {
            var message = _driver.NowAt<BucketsPage>();
            Assert.IsFalse(message.WarningDeleteBucketMessage(warningText),
                $"{warningText} warning message is displayed on the Buckets page");
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

        [When(@"User clicks Default Bucket checkbox on the Buckets page")]
        public void WhenUserClicksDefaultBucketCheckboxOnTheBucketsPage()
        {
            var ckeckbox = _driver.NowAt<BucketsPage>();
            ckeckbox.DefaultBucketCheckbox.Click();
        }

        [When(@"User clicks Update Bucket button on the Buckets page")]
        public void WhenUserClicksUpdateBucketButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            button.UpdateBucketButton.Click();
        }

        [When(@"User adds following items from list")]
        public void ThenUserAddFollowingItemsFromList(Table table)
        {
            var bucketElement = _driver.NowAt<BaseGridPage>();

            foreach (var row in table.Rows)
            {
                bucketElement.AddItem(row["Item"]);
                bucketElement.SearchTextbox.ClearWithHomeButton(_driver);
            }

            bucketElement.AddItemButton.Click();
        }

        [When(@"User clicks Create button on the Create Project page")]
        public void WhenUserClicksCreateButtonOnTheCreateProjectPage()
        {
            var page = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => page.CreateProjectButton);
            page.CreateProjectButton.Click();
            Logger.Write("Create Project button was clicked");
        }

        [When(@"User enters ""(.*)"" in the Project Name field")]
        public void ThenUserEntersInTheProjectNameField(string projectText)
        {
            var projectName = _driver.NowAt<CreateProjectPage>();
            projectName.ProjectNameField.SendKeys(projectText);
        }

        [When(@"User selects ""(.*)"" in the Scope Project dropdown")]
        public void ThenUserSelectsInTheScopeProjectDropdown(string listName)
        {
            var createProjectElement = _driver.NowAt<CreateProjectPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.SelectListForProjectCreation(listName);
        }

        [Then(@"Create Project button is disabled")]
        public void ThenCreateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => button.CreateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateProjectButton.GetAttribute("disabled")),
                "Create Project button is active");
        }

        [Then(@"selecting device owners is disabled")]
        public void ThenSelectingDeviceOwnersIsDisabled()
        {
            var dropDown = _driver.NowAt<ProjectsPage>();
            //_driver.WaitWhileControlIsDisplayed<ProjectsPage>(() => dropDown.DisabledOwnerDropDown);
            Assert.IsTrue(dropDown.DisabledOwnerDropDown.Displayed, "Drop down menu is available");
        }

        [When(@"User click on Back button")]
        public void WhenUserClickOnBackButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            button.BackToTableButton.Click();
        }

        [When(@"User clears Search field for ""(.*)"" column")]
        public void WhenUserClearsSearchFieldForColumn(string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.ResetFiltersButton.Click();
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column")]
        public void WhenUserEntersTextInTheSearchFieldForColumn(string text, string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.GetSearchFieldByColumnName(columnName, text);
        }

        [When(@"User clicks Actions button on the Projects page")]
        public void WhenUserClicksActionsButtonOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ActionsButton.Click();
        }

        [When(@"User removes selected item")]
        public void WhenUserRemovesSelectedItem()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.ActionsButton.Click();
            projectElement.DeleteButtonInActions.Click();
            projectElement.DeleteButtonOnPage.Click();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => projectElement.DeleteWarningMessage);
            projectElement.DeleteButtonInWarningMessage.Click();
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

        [Then(@"Success message with ""(.*)"" text is displayed on the Projects page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnTheProjectsPage(string textMessage)
        {
            ProjectsPage projectElement;
            try
            {
                projectElement = _driver.NowAt<ProjectsPage>();
            }
            catch (WebDriverTimeoutException)
            {
                projectElement = _driver.NowAt<ProjectsPage>();
            }
            try
            {
                projectElement = _driver.NowAt<ProjectsPage>();
            }
            catch (WebDriverTimeoutException)
            {
                projectElement = _driver.NowAt<ProjectsPage>();
            }
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.SuccessMessage);
            Assert.IsTrue(projectElement.SuccessTextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
        }

        [Then(@"Counter shows ""(.*)"" found rows")]
        public void ThenRowsAreDisplayedInTheAgGrid(string numberOfRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();

            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => foundRowsCounter.RowsCounter);

            StringAssert.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                foundRowsCounter.RowsCounter.Text,
                "Incorrect rows count");
        }

        [Then(@"Delete ""(.*)"" Project in the Administration")]
        public void ThenDeleteProjectInTheAdministration(string projectName)
        {
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectID] FROM[PM].[dbo].[Projects] where[ProjectName] = '{projectName}'", 0)[0];
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
        public void ThenDeleteBucketInTheAdministration(string bucketName)
        {
            //var projectId = DatabaseHelper.ExecuteReader($"SELECT [ProjectID] FROM[PM].[dbo].[Projects] where[ProjectName] = '{projectName}'", 0)[0];
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucketName}'");
        }
    }
}