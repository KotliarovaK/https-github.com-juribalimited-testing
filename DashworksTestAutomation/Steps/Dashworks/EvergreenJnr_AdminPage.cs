using System;
using System.IO;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Providers;
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

                case "Import Project":
                    var importProjectPage = _driver.NowAt<ImportProjectPage>();
                    StringAssert.Contains(importProjectPage.ImportProjectFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                default:
                    throw new Exception($"'{pageTitle}' menu item is not valid ");
            }

            Logger.Write($"'{pageTitle}' page is visible");
        }

        [When(@"User clicks Create New Item button")]
        public void WhenUserClicksCreateNewItemButton()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.CreateItemButton);
            page.CreateItemButton.Click();
            Logger.Write("Create New Item button was clicked");
        }

        [When(@"User clicks Update Project button on the Projects page")]
        public void WhenUserClicksUpdateProjectButtonOnTheProjectsPage()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.UpdateProjectInTheWarning);
            button.UpdateProjectInTheWarning.Click();
        }

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

        [Then(@"Update Project button is active")]
        public void ThenUpdateProjectButtonIsActive()
        {
            var button = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(Convert.ToBoolean(button.UpdateProjectButton.GetAttribute("disabled")),
                "Update Project button is disabled");
            Assert.IsFalse(Convert.ToBoolean(button.UpdateAllChangesButton.GetAttribute("disabled")),
                "Update All Changes button is disabled");
        }

        [When(@"User clicks Cancel button")]
        public void WhenUserClicksCancelButton()
        {
            var page = _driver.NowAt<CreateProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateProjectPage>(() => page.CancelButton);
            page.CancelButton.Click();
            Logger.Write("Cancel button was clicked");
        }

        [When(@"User clicks ""(.*)"" button on the Projects page")]
        public void WhenUserClicksButtonOnTheProjectsPage(string buttonName)
        {
            var button = _driver.NowAt<ProjectsPage>();
            button.ClickUpdateButtonByName(buttonName);
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

        [Then(@"All Association are selected by default")]
        public void ThenAllAssociationAreSelectedByDefault()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectsPage.UncheckedCheckbox.Displayed(), "Not all checkboxes are selected");
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

        [When(@"User deselect all rows on the grid")]
        [When(@"User selects all rows on the grid")]
        public void WhenUserSelectsAllRowsOnTheGrid()
        {
            var checkbox = _driver.NowAt<BaseGridPage>();
            checkbox.SelectAllCheckBox.Click();
        }

        [Then(@"Select All selectbox is checked on the Admin page")]
        public void ThenSelectAllSelectboxIsCheckedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.SelectAllCheckboxChecked.Displayed(), "Select All checkbox is unchecked");
        }

        [Then(@"Select All selectbox is unchecked on the Admin page")]
        public void ThenSelectAllSelectboxIsUncheckedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.SelectAllCheckboxChecked.Displayed(), "Select All checkbox is checked");
        }

        [When(@"User select ""(.*)"" rows in the grid on the Admin page")]
        public void WhenUserSelectRowsInTheGridOnTheAdminPage(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var columnContent = page.GetCheckboxByColumnName(columnName);
            foreach (var row in table.Rows)
            {
                var rowIndex = columnContent.IndexOf(row["SelectedRowsName"]);
                if (rowIndex < 0)
                    throw new Exception($"'{row["SelectedRowsName"]}' is not found in the '{columnName}' column");
                page.SelectRowsCheckboxesOnAdminPage[rowIndex].Click();
            }
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

        [When(@"User clicks Import Project button")]
        public void WhenUserClicksImportProjectButton()
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.ImportProjectButton.Click();
            Logger.Write("Import Project button was clicked");
        }

        [When(@"User selects incorrect file to upload on Import Project page")]
        public void WhenUserSelectsIncorrectFileToUploadOnImportProjectPage()
        {
            var page = _driver.NowAt<ImportProjectPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            string file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                          ResourceFilesNamesProvider.IncorrectFile;
            page.ButtonChooseFile.SendKeys(file);
        }

        [When(@"User selects correct file to upload on Import Project page")]
        public void WhenUserSelectsCorrectFileToUploadOnImportProjectPage()
        {
            var page = _driver.NowAt<ImportProjectPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            string file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                          ResourceFilesNamesProvider.CorrectFileDas12370;
            page.ButtonChooseFile.SendKeys(file);
        }

        [Then(@"Import Project button is enabled")]
        public void ThenImportProjectButtonIsEnabled()
        {
            var button = _driver.NowAt<ImportProjectPage>();
            _driver.WaitWhileControlIsNotDisplayed<ImportProjectPage>(() => button.ImportProjectButton);
            Assert.IsFalse(Convert.ToBoolean(button.ImportProjectButton.GetAttribute("disabled")),
                "Import button is disabled");
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

        [When(@"User selects ""(.*)"" in the Import dropdown on the Import Project Page")]
        public void ThenUserSelectsInTheImportDropdownOnTheImportProjectPage(string optionName)
        {
            var importProjectPage = _driver.NowAt<ImportProjectPage>();
            importProjectPage.SelectImportOption(optionName);
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

        [When(@"User clicks Default bucket checkbox")]
        public void WhenUserClicksDefaultBucketCheckbox()
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.DefaulBucketCheckbox.Click();
        }

        [When(@"User clicks Create button on the Create Bucket page")]
        public void WhenUserClicksCreateButtonOnTheCreateBucketPage()
        {
            var page = _driver.NowAt<CreateBucketPage>();
            _driver.WaitWhileControlIsNotDisplayed<CreateBucketPage>(() => page.CreateBucketButton);
            page.CreateBucketButton.Click();
            Logger.Write("Create Team button was clicked");
        }

        #region Message


        [Then(@"Warning message with ""(.*)"" text is displayed on the Admin page")]
        public void ThenWarningMessageWithTextIsDisplayedOnTheAdminPage(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(page.WarningMessageAdminPage(text), "Warning Message is not displayed");
        }

        [Then(@"Warning message is not displayed on the Admin page")]
        public void ThenWarningMessageIsNotDisplayedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.DeleteWarningMessage.Displayed());
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
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.DeleteWarningMessage);
            button.DeleteButtonInWarningMessage.Click();
            Logger.Write("Delete button was clicked");
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
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.ErrorMessage);
            Assert.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"""(.*)"" warning message is not displayed on the Buckets page")]
        public void ThenWarningMessageIsNotDisplayedOnTheBucketsPage(string warningText)
        {
            var message = _driver.NowAt<BucketsPage>();
            Assert.IsFalse(message.WarningDeleteBucketMessage(warningText),
                $"{warningText} warning message is displayed on the Buckets page");
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
                try
                {
                    projectElement = _driver.NowAt<ProjectsPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    projectElement = _driver.NowAt<ProjectsPage>();
                }
            }
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.SuccessMessage);
            Thread.Sleep(15000);
            Assert.IsTrue(projectElement.SuccessTextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
        }

        [Then(@"message with ""(.*)"" text is displayed on the Projects page")]
        public void ThenMessageWithTextIsDisplayedOnTheProjectsPage(string textMessage)
        {
            ProjectsPage projectElement;
            try
            {
                projectElement = _driver.NowAt<ProjectsPage>();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    projectElement = _driver.NowAt<ProjectsPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    projectElement = _driver.NowAt<ProjectsPage>();
                }
            }
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.DeleteWarningMessage);
            Assert.IsTrue(projectElement.SuccessTextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
        }

        [Then(@"Success message is not displayed on the Projects page")]
        public void ThenSuccessMessageIsNotDisplayedOnTheProjectsPage()
        {
            var message = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(message.SuccessMessage.Displayed());
        }
  
        #endregion

        [Then(@"""(.*)"" bucket details is displayed to the user")]
        public void ThenBucketDetailsIsDisplayedToTheUser(string bucketName)
        {
            var teamElement = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(teamElement.AppropriateBucketName(bucketName),
                $"{bucketName} is not displayed on the Bucket page");
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

        [When(@"User clicks Delete Bucket button")]
        public void WhenUserClicksDeleteBucketButton()
        {
            var projectElement = _driver.NowAt<BucketsPage>();
            projectElement.DeleteBucketInActions.Click();
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

        [When(@"User expands the object to add")]
        public void WhenUserExpandsTheObjectToAdd()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.PlusButton.Click();
        }

        [When(@"User selects following items to the Project")]
        public void WhenUserSelectsFollowingItemsToTheProject(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
            {
                projectElement.AddItem(row["Item"]);
                projectElement.SearchTextbox.ClearWithHomeButton(_driver);
            }
        }

        [Then(@"following objects are onboarded")]
        public void ThenFollowingObjectsAreOnboarded(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Thread.Sleep(15000);
            foreach (var row in table.Rows)
            {
                if (projectElement.OnboardedObjectsTable.Displayed())
                {
                    projectElement.OnboardedObjectDisplayed(row["Object"]);
                }
                else
                {
                    _driver.Navigate().Refresh();
                    projectElement.OnboardedObjectDisplayed(row["Object"]);
                }
            }
        }

        [Then(@"following items are still selected")]
        public void ThenFollowingItemsAreStillSelected()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.SelectedCheckbox.Displayed(), "Items are not selected");
            Assert.IsTrue(projectElement.AddItemCheckbox.Displayed(), "Item checkbox is not checked");
        }

        [When(@"User adds following items to the Project")]
        public void WhenUserAddsFollowingItemsToTheProject(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.PlusButton.Click();
            foreach (var row in table.Rows)
            {
                projectElement.AddItem(row["Item"]);
                projectElement.SearchTextbox.ClearWithHomeButton(_driver);
            }

            projectElement.UpdateButton.Click();
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
            Assert.IsTrue(page.GetCreatedProjectName(projectName).Displayed(), "Created Project is not found");
        }

        [Then(@"Import Project button is not displayed")]
        public void ThenImportProjectButtonIsNotDisplayed()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(button.ImportProjectButton.Displayed());
        }

        [When(@"User enters ""(.*)"" in the Project Name field")]
        public void ThenUserEntersInTheProjectNameField(string projectText)
        {
            var projectName = _driver.NowAt<CreateProjectPage>();
            projectName.ProjectNameField.SendKeys(projectText);
        }

        [When(@"User selects ""(.*)"" in the Scope Project dropdown")]
        public void ThenUserSelectsInTheScopeProjectDropdown(string objectName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.SelectObjectForProjectCreation(objectName);
        }

        [When(@"User selects ""(.*)"" in the Buckets Project dropdown")]
        public void WhenUserSelectsInTheBucketsProjectDropdown(string objectName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.BucketsProjectField.Click();
            createProjectElement.SelectObjectForProjectCreation(objectName);
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
            Thread.Sleep(10000);
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

        [Then(@"Search fields for ""(.*)"" column contain correctly value")]
        public void ThenSearchFieldsForColumnContainCorrectlyValue(string columnName)
        {
            var searchFild = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(searchFild.GetSearchFieldTextByColumnName(columnName).Displayed(), "Incorrect contain value for search field");
        }

        [When(@"User clicks Reset Filters button on the Admin page")]
        public void WhenUserClicksResetFiltersButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
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
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => projectElement.DeleteWarningMessage);
            _driver.WaitForDataLoading();
            projectElement.DeleteButtonInWarningMessage.Click();
        }

        [Then(@"""(.*)"" item was removed")]
        public void ThenItemWasRemoved(string itemName)
        {
            var item = _driver.NowAt<BaseGridPage>();
            if (item.OnboardedObjectsTable.Displayed())
            {
                Assert.IsFalse(item.GetCreatedProjectName(itemName).Displayed(), "Selected item was not removed");
            }
            else
            {
                Assert.IsTrue(item.NoProjectsMessage.Displayed(), "'No projects found' message is not displayed");
            }
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

        [When(@"User moves '(.*)' device to '(.*)' bucket")]
        public void WhenUserMovesDeviceToBucket(string deviceName, string bucketName)
        {
            var bucketId = DatabaseHelper.ExecuteReader($"SELECT [GroupID] FROM [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucketName}'", 0)[0];
        }

        [When(@"User moves '(.*)' user to '(.*)' bucket")]
        public void WhenUserMovesUserToBucket(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}