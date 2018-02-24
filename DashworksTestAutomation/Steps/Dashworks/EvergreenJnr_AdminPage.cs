using DashworksTestAutomation.Extensions;
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

        [Then(@"User select ""(.*)"" team in the Select a team dropdown")]
        public void ThenUserSelectTeamInTheSelectATeamDropdown(string userOption)
        {
            var createBucketElement = _driver.NowAt<BucketsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BucketsPage>(() => createBucketElement.SelectTeamDropdown);
            _driver.SelectCustomSelectbox(createBucketElement.SelectTeamDropdown, userOption);
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
        public void ThenUserSelectInTheScopeProjectDropdown(string userOption)
        {
            var createBucketElement = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => createBucketElement.SelectScopeProject);
            _driver.SelectCustomSelectbox(createBucketElement.SelectScopeProject, userOption);
        }

        [Then(@"Create Project button is disabled")]
        public void ThenCreateProjectButtonIsDisabled()
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<ProjectsPage>(() => button.CreateProjectButton);
            Assert.IsTrue(Convert.ToBoolean(button.CreateProjectButton.GetAttribute("disabled")), "Create Project button is active");
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

        //[Then(@"Delete ""(.*)"" Bucket in the Administration")]
        //public void ThenDeleteBucketInTheAdministration(string p0)
        //{
        //    //delete from[PM].[dbo].[EvergreenProjects] where[ProjectId] = '54'
        //    //delete from[PM].[dbo].[ProjectGroups] where[ProjectID] = '54'
        //    //delete from[PM].[dbo].[SelfServiceScreenValueLanguage] where[ProjectId] = '54'
        //    //delete from[PM].[dbo].[SelfService] where[ProjectID] = '54'
        //    //delete from[PM].[dbo].[SelfServiceScreenValues] where[ProjectID] = '54'
        //    //delete from[PM].[dbo].[Projects] where[ProjectID] = '54'
        //    //delete from[PM].[dbo].[Projects] where[ProjectID] = '54'
        //}
    }
}