using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
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

        [When(@"User click ""(.*)"" link on the Admin page")]
        public void WhenUserClickLinkOnTheAdminPage(string adminLinks)
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
        public void ThenPageShouldBeDisplayedToTheUser(string adminLinks)
        {
            switch (adminLinks)
            {
                case "Projects":
                    var projectsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(projectsPage.ProjectsPage.Text.ToLower(), adminLinks.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Teams":
                    var teamsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(teamsPage.TeamsPage.Text.ToLower(), adminLinks.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Buckets":
                    var bucketsPage = _driver.NowAt<AdminLeftHandMenu>();
                    StringAssert.Contains(bucketsPage.BucketsPage.Text.ToLower(), adminLinks.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                default:
                    throw new Exception($"'{adminLinks}' menu item is not valid ");
            }

            Logger.Write($"'{adminLinks}' page is visible");
        }

        [When(@"User clicks ""(.*)"" Project name")]
        public void WhenUserClicksProjectName(string projectName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.SelectProjectByName(projectName);
        }

        [Then(@"Project ""(.*)"" is displayed to user")]
        public void ThenProjectIsDisplayedToUser(string projectName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.ActiveProjectByName(projectName), $"{projectName} is not displayed on the Project page");
        }

        [When(@"User opens Scope section on the Project details page")]
        public void WhenUserOpensScopeSectionOnTheProjectDetailsPage()
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.ScopeSection.Click();
        }

        [When(@"User select ""(.*)"" tab on the Project details page")]
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

        [When(@"User select ""(.*)"" checkbox on the Project details page")]
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

        [When(@"User clicks Make Changes button on the Projects page")]
        public void WhenUserClicksMakeChangesButtonOnTheProjectsPage()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.MakeChangesButton);
            button.MakeChangesButton.Click();
        }

        [Then(@"Update Project button is disabled")]
        public void ThenUpdateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.UpdateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.UpdateProjectButton.GetAttribute("disabled")),
                "Update Project button is active");
        }

        [When(@"User clicks Cancel button")]
        public void WhenUserClicksCancelButton()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => page.CancelButton);
            page.CancelButton.Click();
            Logger.Write("Cancel button was clicked");
        }


        [When(@"User clicks Create Team button")]
        public void WhenUserClicksCreateTeamButton()
        {
            var page = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => page.CreateTeamButton);
            page.CreateTeamButton.Click();
            Logger.Write("Create Team button was clicked");
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

        [Then(@"Create Team page should be displayed to the user")]
        public void ThenCreateTeamPageShouldBeDisplayedToTheUser()
        {
            var page = _driver.NowAt<TeamsPage>();
            Assert.IsTrue(page.TeamNameField.Displayed(), "Create Team page was not displayed");
            Logger.Write("Create Team page is visible");
        }

        [Then(@"User enters ""(.*)"" in the Team Name field")]
        public void ThenUserEntersInTheTeamNameField(string teamName)
        {
            var teamPage = _driver.NowAt<TeamsPage>();
            teamPage.TeamNameField.SendKeys(teamName);
            _teamName.Value.Add(teamName);
        }

        [When(@"User enters ""(.*)"" in the Team Description field")]
        public void WhenUserEntersInTheTeamDescriptionField(string descriptionText)
        {
            var teamName = _driver.NowAt<TeamsPage>();
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
            var page = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => page.CreateTeamButton);
            page.CreateTeamButton.Click();
            Logger.Write("Create Team button was clicked");
        }

        [Then(@"Success message is displayed and contains ""(.*)"" text on the Teams page")]
        public void ThenSuccessMessageIsDisplayedAndContainsTextOnTheTeamsPage(string text)
        {
            var page = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => page.SuccessMessageTeamPage);
            StringAssert.Contains(text, page.SuccessMessageTeamPage.Text, "Success Message is not displayed");
        }

        [Then(@"Error message with ""(.*)"" text is displayed on the Teams page")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheAdminPage(string text)
        {
            var page = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => page.ErrorMessageTeamPage);
            Assert.AreEqual(text, page.ErrorMessageTeamPage.Text, "Error Message is not displayed");
        }

        [When(@"User have opened Column Settings for ""(.*)"" column on the Teams Page")]
        public void WhenUserHaveOpenedColumnSettingsForColumnOnTheTeamsPage(string columnName)
        {
            var page = _driver.NowAt<TeamsPage>();
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

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column on the Teams page")]
        public void WhenUserEntersTextInTheSearchFieldForColumnOnTheTeamsPage(string text, string columnName)
        {
            var filterElement = _driver.NowAt<TeamsPage>();
            filterElement.GetSearchFieldByColumnName(columnName, text);
        }

        [Then(@"""(.*)"" rows are displayed on the Teams page")]
        public void ThenRowsAreDisplayedOnTheTeamsPage(string numberOfRows)
        {
            var listPageElement = _driver.NowAt<TeamsPage>();
            if (!string.IsNullOrWhiteSpace(numberOfRows))
            {
                Thread.Sleep(1000);

                _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => listPageElement.ResultsOnPageCount);

                if (numberOfRows == "1")
                {
                    StringAssert.AreEqualIgnoringCase($"{numberOfRows} row", listPageElement.ResultsOnPageCount.Text,
                        "Incorrect rows count");
                }
                else
                {
                    StringAssert.AreEqualIgnoringCase($"{numberOfRows} rows", listPageElement.ResultsOnPageCount.Text,
                        "Incorrect rows count");
                }
                Logger.Write(
                    $"Evergreen agGrid Search returned the correct number of rows for: {numberOfRows}  search");
            }
            //User clears filters
            listPageElement.ResetFiltersButton.Click();
        }

        [When(@"User selects all rows on the Teams page")]
        public void WhenUserSelectsAllRowsOnTheTeamsPage()
        {
            var checkbox = _driver.NowAt<TeamsPage>();
            checkbox.SelectAllProjectsCheckbox.Click();
        }

        [Then(@"User clicks on Actions button on the Teams page")]
        public void ThenUserClicksOnActionsButtonOnTheTeamsPage()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.ActionsButton);
            button.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [Then(@"User select ""(.*)"" in the Actions dropdown on the Teams page")]
        public void ThenUserSelectInTheActionsDropdownOnTheTeamsPage(string actionName)
        {
            var action = _driver.NowAt<TeamsPage>();
            action.SelectActions(actionName);
        }

        [When(@"User clicks content from ""(.*)"" column on the Teams page")]
        public void WhenUserClicksContentFromColumnOnTheTeamsPage(string columnName)
        {
            var tableElement = _driver.NowAtWithoutWait<TeamsPage>();
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

        [Then(@"User clicks ""(.*)"" tab on the Teams page")]
        public void ThenUserClicksTabOnTheTeamsPage(string tabName)
        {
            var page = _driver.NowAt<TeamsPage>();
            page.SelectTabByName(tabName);
        }

        [Then(@"Create Team button is disabled")]
        public void ThenCreateTeamButtonIsDisabled()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.CreateTeamButtonOnCreateTeamPage);
            Assert.IsTrue(Convert.ToBoolean(button.CreateTeamButtonOnCreateTeamPage.GetAttribute("disabled")),
                "Create Team button is active");
        }

        [When(@"User clicks Delete button on the Teams page")]
        public void WhenUserClicksDeleteButtonOnTheTeamsPage()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.ActionsButton);
            button.DeleteButtonOnPage.Click();
            Logger.Write("Delete button was clicked");
        }

        [Then(@"Reassign Objects is displayed on the Teams page")]
        public void ThenReassignObjectsIsDisplayedOnTheTeamsPage()
        {
            var page = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => page.ReassignObjectsSummary);
            Assert.IsTrue(page.ReassignObjectsSummary.Displayed(), "Reassign Objects was not displayed");
        }

        [When(@"User clicks Create Bucket button")]
        public void WhenUserClicksCreateBucketButton()
        {
            var page = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => page.CreateBucketButton);
            page.CreateBucketButton.Click();
            Logger.Write("Create Bucket button was clicked");
        }

        [Then(@"Create Bucket page should be displayed to the user")]
        public void ThenCreateBucketPageShouldBeDisplayedToTheUser()
        {
            var page = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(page.BucketNameField.Displayed(), "Create Bucket page was not displayed");
            Logger.Write("Create Bucket page is visible");
        }

        [Then(@"User enters ""(.*)"" in the Bucket Name field")]
        public void ThenUserEntersInTheBucketNameField(string bucketText)
        {
            var bucketName = _driver.NowAt<BucketsPage>();
            bucketName.BucketNameField.SendKeys(bucketText);
        }

        [Then(@"User select ""(.*)"" team in the Team dropdown on the Buckets page")]
        public void ThenUserSelectTeamInTheTeamDropdownOnTheBucketsPage(string teamName)
        {
            var createBucketElement = _driver.NowAt<BucketsPage>();
            createBucketElement.TeamsNameField.SendKeys(teamName);
            createBucketElement.SelectTeam(teamName);
        }

        [When(@"User clicks Create button on the Create Bucket page")]
        public void WhenUserClicksCreateButtonOnTheCreateBucketPage()
        {
            var page = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => page.CreateButton);
            page.CreateButton.Click();
            Logger.Write("Create Team button was clicked");
        }

        [Then(@"Success message is displayed and contains ""(.*)"" text on the Buckets page")]
        public void ThenSuccessMessageIsDisplayedAndContainsTextOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => page.SuccessMessageBucketsPage);
            StringAssert.Contains(text, page.SuccessMessageBucketsPage.Text, "Success Message is not displayed");
        }

        [Then(@"Success message The ""(.*)"" bucket has been updated is displayed on the Buckets page")]
        public void ThenSuccessMessageTheBucketHasBeenUpdatedIsDisplayedOnTheBucketsPage(string bucketName)
        {
            var page = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => page.SuccessMessageBucketsPage);
            Assert.IsTrue(page.SuccessUpdatedMessageBucketsPage(bucketName),
                $"Success Message is not displayed for {bucketName}");
        }

        [Then(@"Error message with ""(.*)"" text is displayed on the Buckets page")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => page.ErrorMessageBucketsPage);
            Assert.AreEqual(text, page.ErrorMessageBucketsPage.Text, "Error Message is not displayed");
        }

        [When(@"User have opened Column Settings for ""(.*)"" column on the Buckets Page")]
        public void WhenUserHaveOpenedColumnSettingsForColumnOnTheBucketsPage(string columnName)
        {
            var page = _driver.NowAt<BucketsPage>();
            page.OpenColumnSettingsByName(columnName);
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column on the Buckets page")]
        public void WhenUserEntersTextInTheSearchFieldForColumnOnTheBucketsPage(string text, string columnName)
        {
            var filterElement = _driver.NowAt<BucketsPage>();
            filterElement.GetSearchFieldByColumnName(columnName, text);
        }

        [Then(@"""(.*)"" rows are displayed on the Buckets page")]
        public void ThenRowsAreDisplayedOnTheBucketsPage(string numberOfRows)
        {
            var listPageElement = _driver.NowAt<BucketsPage>();
            if (!string.IsNullOrWhiteSpace(numberOfRows))
            {
                Thread.Sleep(1000);

                _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => listPageElement.ResultsOnPageCount);

                if (numberOfRows == "1")
                {
                    StringAssert.AreEqualIgnoringCase($"{numberOfRows} row", listPageElement.ResultsOnPageCount.Text,
                        "Incorrect rows count");
                }
                else
                {
                    StringAssert.AreEqualIgnoringCase($"{numberOfRows} rows", listPageElement.ResultsOnPageCount.Text,
                        "Incorrect rows count");
                }
                Logger.Write(
                    $"Evergreen agGrid Search returned the correct number of rows for: {numberOfRows}  search");
            }
            //User clears filters
            listPageElement.ResetFiltersButton.Click();
        }

        [When(@"User clicks content from ""(.*)"" column on the Buckets page")]
        public void WhenUserClicksContentFromColumnOnTheBucketsPage(string columnName)
        {
            var tableElement = _driver.NowAtWithoutWait<BucketsPage>();
            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" bucket details is displayed to the user")]
        public void ThenBucketDetailsIsDisplayedToTheUser(string bucketName)
        {
            var teamElement = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(teamElement.AppropriateBucketName(bucketName),
                $"{bucketName} is not displayed on the Bucket page");
        }

        [When(@"User selects all rows on the Buckets page")]
        public void WhenUserSelectsAllRowsOnTheBucketsPage()
        {
            var checkbox = _driver.NowAt<BucketsPage>();
            checkbox.SelectAllProjectsCheckbox.Click();
        }

        [Then(@"User clicks on Actions button on the Buckets page")]
        public void ThenUserClicksOnActionsButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => button.ActionsButton);
            button.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [Then(@"User select ""(.*)"" in the Actions dropdown on the Buckets page")]
        public void ThenUserSelectInTheActionsDropdownOnTheBucketsPage(string actionName)
        {
            var action = _driver.NowAt<BucketsPage>();
            action.SelectActions(actionName);
        }

        [When(@"User clicks Delete button on the Buckets page")]
        public void WhenUserClicksDeleteButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => button.ActionsButton);
            button.DeleteButtonOnPage.Click();
            Logger.Write("Delete button was clicked");
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
            var button = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => button.CreateButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateButton.GetAttribute("disabled")),
                "Create Bucket button is active");
        }

        [When(@"User clicks ""(.*)"" Bucket name")]
        public void WhenUserClicksBucketName(string bucketName)
        {
            var page = _driver.NowAt<BucketsPage>();
            page.SelectBucketByName(bucketName);
        }

        [Then(@"Bucket ""(.*)"" is displayed to user")]
        public void ThenBucketIsDisplayedToUser(string bucketName)
        {
            var page = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(page.ActiveBucketByName(bucketName), $"{bucketName} is not displayed on the Buckets page");
        }

        [When(@"User clicks Add Device button on the Buckets page")]
        public void WhenUserClicksAddDeviceButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            button.AddDeviceButton.Click();
        }

        [When(@"User clicks Add Mailbox button on the Buckets page")]
        public void WhenUserClicksAddMailboxButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            button.AddMailboxButton.Click();
        }

        [When(@"User clicks Add User button on the Buckets page")]
        public void WhenUserClicksAddUserButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            button.AddUserButton.Click();
        }

        [Then(@"No items text is displayed on the Buckets page")]
        public void ThenNoItemsTextIsDisplayedOnTheBucketsPage()
        {
            var text = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(text.NoItesMessage.Displayed, "No items text is not displayed");
        }

        [Then(@"User clicks ""(.*)"" tab on the Buckets page")]
        public void ThenUserClicksTabOnTheBucketsPage(string tabName)
        {
            var page = _driver.NowAt<BucketsPage>();
            page.SelectTabByName(tabName);
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

        [Then(@"User add following devices to the Bucket")]
        public void ThenUserAddFollowingDevicesToTheBucket(Table table)
        {
            var bucketElement = _driver.NowAt<BucketsPage>();

            foreach (var row in table.Rows)
            {
                bucketElement.AddBucket(row["DeviceName"]);
                bucketElement.SearchTextbox.ClearWithHomeButton(_driver);
            }

            bucketElement.AddDevicesButton.Click();
        }

        [Then(@"User add following users to the Bucket")]
        public void ThenUserAddFollowingUsersToTheBucket(Table table)
        {
            var bucketElement = _driver.NowAt<BucketsPage>();

            foreach (var row in table.Rows)
            {
                bucketElement.AddUser(row["UserName"]);
                bucketElement.SearchTextbox.ClearWithHomeButton(_driver);
            }

            bucketElement.AddUsersButton.Click();
        }

        [Then(@"User add following mailboxes to the Bucket")]
        public void ThenUserAddFollowingMailboxesToTheBucket(Table table)
        {
            var bucketElement = _driver.NowAt<BucketsPage>();

            foreach (var row in table.Rows)
            {
                bucketElement.AddMailbox(row["MailboxName"]);
                bucketElement.SearchTextbox.ClearWithHomeButton(_driver);
            }

            bucketElement.AddMailboxesButton.Click();
        }

        [When(@"User clicks Create Project button")]
        public void WhenUserClicksCreateProjectButton()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => page.CreateProjectButton);
            page.CreateProjectButton.Click();
            Logger.Write("Create Project button was clicked");
        }

        [Then(@"Create Project page should be displayed to the user")]
        public void ThenCreateProjectPageShouldBeDisplayedToTheUser()
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.ProjectNameField.Displayed(), "Create Project page was not displayed");
            Logger.Write("Create Project page is visible");
        }

        [Then(@"User enters ""(.*)"" in the Project Name field")]
        public void ThenUserEntersInTheProjectNameField(string projectText)
        {
            var projectName = _driver.NowAt<ProjectsPage>();
            projectName.ProjectNameField.SendKeys(projectText);
        }

        [Then(@"User select ""(.*)"" in the Scope Project dropdown")]
        public void ThenUserSelectInTheScopeProjectDropdown(string listName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.SelectListForProjectCreation(listName);
        }

        [Then(@"Create Project button is disabled")]
        public void ThenCreateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.CreateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateProjectButtonOnCreateProjectPage.GetAttribute("disabled")),
                "Create Project button is active");
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column on the Projects page")]
        public void WhenUserEntersTextInTheSearchFieldForColumnOnTheProjectsPage(string text, string columnName)
        {
            var searchElement = _driver.NowAt<ProjectsPage>();
            searchElement.GetSearchFieldByColumnName(columnName, text);
        }

        [When(@"User selects all rows on the Projects page")]
        public void WhenUserSelectsAllRowsOnTheProjectsPage()
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectAllProjectsCheckbox.Click();
        }

        [When(@"User cancels the selection of all rows on the Projects page")]
        public void WhenUserCancelsTheSelectionOfAllRowsOnTheProjectsPage()
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectAllProjectsCheckbox.Click();
        }

        [When(@"User clicks Actions button on the Projects page")]
        public void WhenUserClicksActionsButtonOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ActionsButton.Click();
        }

        [When(@"User clicks Delete Project button on the Projects page")]
        public void WhenUserClicksDeleteProjectButtonOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.DeleteProjectButtonInActions.Click();
        }

        [When(@"User removes selected Project")]
        public void WhenUserRemovesSelectedProject()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ActionsButton.Click();
            _driver.WaitForDataLoading();
            projectElement.DeleteProjectButtonInActions.Click();
            projectElement.DeleteButtonOnPage.Click();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.DeleteWarningMessage);
            projectElement.DeleteButtonInWarningMessage.Click();
        }

        [Then(@"Delete button is displayed to the User on the Projects page")]
        public void ThenDeleteButtonIsDisplayedToTheUserOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectElement.DeleteProjectValueInActions.Displayed(), "Delete Project Value is not displayed");
            Assert.IsTrue(projectElement.DeleteButtonOnPage.Displayed(), "Delete button is not displayed");
        }

        [Then(@"Delete button is not displayed to the User on the Projects page")]
        public void ThenDeleteButtonIsNotDisplayedToTheUserOnTheProjectsPage()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(projectElement.ActionsInDropdown.Displayed(), "Actions is not displayed in the dropdown");
            Assert.IsFalse(projectElement.DeleteButtonOnPage.Displayed(), "Delete button is displayed");
        }

        [Then(@"Success message with ""(.*)"" text is displayed on the Projects page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnTheProjectsPage(string textMessage)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.SuccessDeletingMessage);
            Assert.IsTrue(projectElement.SuccessTextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
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