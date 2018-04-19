﻿using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage(RemoteWebDriver driver)
        {
            _driver = driver;
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

        [When(@"User navigates to the ""(.*)"" tab on the Project details page")]
        public void WhenUserNavigatesToTheTabOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.NavigateToProjectTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks ""(.*)"" tab in the Project Scope Changes section")]
        public void WhenUserClicksTabInTheProjectScopeChangesSection(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.ClickToTabByNameProjectScopeChanges(tabName);
        }

        [Then(@"""(.*)"" is displayed to the user in the Project Scope Changes section")]
        public void ThenIsDisplayedToTheUserInTheProjectScopeChangesSection(string text)
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.SelectedItemInProjectScopeChangesSection(text), $"{text} is not displayed in the Project Scope Changes section");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on the Project details page")]
        public void ThenWarningMessageWithTextIsDisplayedOnTheProjectDetailsPage(string text)
        {
            var page = _driver.NowAt<ProjectsPage>();
            Assert.IsTrue(page.WarningMessageProjectPage(text), "Warning Message is not displayed");
        }

        [When(@"User select ""(.*)"" checkbox on the Project details page")]
        public void WhenUserSelectCheckboxOnTheProjectDetailsPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectCheckboxByName(checkboxName);
        }

        [Then(@"Update Project button is disabled")]
        public void ThenUpdateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.UpdateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.UpdateProjectButton.GetAttribute("disabled")), "Update Project button is active");
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
        public void ThenUserEntersInTheTeamNameField(string teamText)
        {
            var teamName = _driver.NowAt<TeamsPage>();
            teamName.TeamNameField.SendKeys(teamText);
        }

        [Then(@"User enters ""(.*)"" in the Team Description field")]
        public void ThenUserEntersInTheTeamDescriptionField(string descriptionText)
        {
            var teamName = _driver.NowAt<TeamsPage>();
            teamName.TeamDescriptionField.SendKeys(descriptionText);
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

        [Then(@"User select ""(.*)"" team in the Team dropdown")]
        public void ThenUserSelectTeamInTheTeamDropdown(string teamName)
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

        [Then(@"Error message with ""(.*)"" text is displayed on the Buckets page")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => page.ErrorMessageBucketsPage);
            Assert.AreEqual(text, page.ErrorMessageBucketsPage.Text, "Error Message is not displayed");
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
            var bucketName = _driver.NowAt<ProjectsPage>();
            bucketName.ProjectNameField.SendKeys(projectText);
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
            Assert.IsTrue(Convert.ToBoolean(button.CreateProjectButtonOnCreateProjectPage.GetAttribute("disabled")), "Create Project button is active");
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column")]
        public void WhenUserEntersTextInTheSearchFieldForColumn(string text, string columnName)
        {
            var searchElement = _driver.NowAt<ProjectsPage>();
            searchElement.GetSearchFieldByColumnName((columnName), text);
        }

        [When(@"User selects all rows on the Projects page")]
        public void WhenUserSelectsAllRowsOnTheProjectsPage()
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectAllProjectsCheckbox.Click();
        }

        [When(@"User removes selected Project")]
        public void WhenUserRemovesSelectedProject()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ActionsButton.Click();
            projectElement.DeleteProjectButtonInActions.Click();
            projectElement.DeleteButtonOnPage.Click();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.DeleteWarningMessage);
            projectElement.DeleteButtonInWarningMessage.Click();
        }

        [Then(@"Success message with ""(.*)"" text is displayed on the Projects page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnTheProjectsPage(string textMessage)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => projectElement.SuccessDeleteMessage);
            Assert.IsTrue(projectElement.SuccessDeletingMessage(textMessage), $"{textMessage} is not displayed on the Project page");
        }

        [Then(@"Create Bucket button is disabled")]
        public void ThenCreateBucketButtonIsDisabled()
        {
            var button = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => button.CreateButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateButton.GetAttribute("disabled")), "Create Bucket button is active");
        }

        [Then(@"Create Team button is disabled")]
        public void ThenCreateTeamButtonIsDisabled()
        {
            var button = _driver.NowAt<TeamsPage>();
            _driver.WaitWhileControlIsNotDisplayed<TeamsPage>(() => button.CreateTeamButtonOnCreateTeamPage);
            Assert.IsTrue(Convert.ToBoolean(button.CreateTeamButtonOnCreateTeamPage.GetAttribute("disabled")), "Create Team button is active");
        }

        [Then(@"Delete ""(.*)"" Project in the Administration")]
        public void ThenDeleteProjectInTheAdministration(string projectName)
        {
            var projectId = DatabaseHelper.ExecuteReader($"SELECT [ProjectID] FROM[PM].[dbo].[Projects] where[ProjectName] = '{projectName}'", 0)[0];
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[EvergreenProjects] where[ProjectId] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[ProjectGroups] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[SelfServiceScreenValueLanguage] where[ProjectId] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[SelfService] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[SelfServiceScreenValues] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Projects] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Projects] where[ProjectID] = '{projectId}'");
        }

        [Then(@"Delete ""(.*)"" Bucket in the Administration")]
        public void ThenDeleteBucketInTheAdministration(string bucketName)
        {
            //var projectId = DatabaseHelper.ExecuteReader($"SELECT [ProjectID] FROM[PM].[dbo].[Projects] where[ProjectName] = '{projectName}'", 0)[0];
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[ProjectGroups] where[GroupName] = '{bucketName}'");
        }
    }
}