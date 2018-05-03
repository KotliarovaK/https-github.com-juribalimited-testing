using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_Removing : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly TeamName _teamName;

        public Projects_Removing(RemoteWebDriver driver, ProjectDto projectDto, TeamName teamName)
        {
            _driver = driver;
            _projectDto = projectDto;
            _teamName = teamName;
        }

        [Then(@"User remove ""(.*)"" Request Type")]
        public void ThenUserRemoveRequestType(string requestType)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteRequestTypeButtonElementByName(requestType).Click();
        }

        [Then(@"User remove created Request Type")]
        public void ThenUserRemoveCreatedRequestType()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteRequestTypeButtonElementByName(_projectDto.ReqestType.Name).Click();
        }

        [Then(@"User remove ""(.*)"" Category")]
        public void ThenUserRemoveCategory(string categoryName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteCategoryButtonElementByName(categoryName).Click();
        }

        [Then(@"User remove created Category")]
        public void ThenUserRemoveCreatedCategory()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteCategoryButtonElementByName(_projectDto.Categories.Name).Click();
        }

        [Then(@"User remove ""(.*)"" Stage")]
        public void ThenUserRemoveStage(string stageName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteStageButtonElementByName(stageName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove created Stage")]
        public void ThenUserRemoveCreatedStage()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteStageButtonElementByName(_projectDto.Stages.StageName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Task")]
        public void ThenUserRemoveTask(string taskName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTaskButtonElementByName(taskName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove created Task")]
        public void ThenUserRemoveCreatedTask()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTaskButtonElementByName(_projectDto.Tasks.Name).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Team")]
        public void ThenUserRemoveTeam(string teamName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTeamButtonElementByName(teamName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove created Team")]
        public void ThenUserRemoveCreatedTeam()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTeamButtonElementByName(_projectDto.TeamProperties.TeamName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Group")]
        public void ThenUserRemoveGroup(string groupName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteGroupButtonElementByName(groupName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove created Group")]
        public void ThenUserRemoveCreatedGroup()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteGroupButtonElementByName(_projectDto.GroupProperties.First().GroupName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Mail Templates")]
        public void ThenUserRemoveMailTemplates(string templateName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTemplateButtonElementByName(templateName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove created Mail Template")]
        public void ThenUserRemoveCreatedMailTemplate()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTemplateButtonElementByName(_projectDto.MailTemplateProperties.Name).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove Project")]
        public void ThenUserRemoveProject()
        {
            var page = _driver.NowAt<BaseElements>();

            page.DeleteProjectButton.Click();
            _driver.AcceptAlert();
            page.ConfirmDeletedTheProjectButton.Click();
            _driver.AcceptAlert();
        }

        #region Checks removing

        [Then(@"selected Team removed")]
        public void ThenSelectedTeamRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var team = page.GetTheCreatedElementInTableByName(_projectDto.TeamProperties.TeamName);
            Assert.IsFalse(team.Displayed(), "Selected Team is displayed in the table");
        }

        [Then(@"selected Group removed")]
        public void ThenSelectedGroupRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.GroupProperties.First().GroupName);
            Assert.IsFalse(group.Displayed(), "Selected Group is displayed in the table");
        }

        [Then(@"selected Task removed")]
        public void ThenSelectedTaskRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.Tasks.Name);
            Assert.IsFalse(group.Displayed(), "Selected Task is displayed in the table");
        }

        [Then(@"selected Stage removed")]
        public void ThenSelectedStageRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.Stages.StageName);
            Assert.IsFalse(group.Displayed(), "Selected Stage is displayed in the table");
        }

        [Then(@"selected Category removed")]
        public void ThenSelectedCategoryRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.Categories.Name);
            Assert.IsFalse(group.Displayed(), "Selected Category is displayed in the table");
        }

        [Then(@"selected Request Type removed")]
        public void ThenSelectedRequestTypeRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.ReqestType.Name);
            Assert.IsFalse(group.Displayed(), "Selected Request Type is displayed in the table");
        }

        [Then(@"selected Mail Template removed")]
        public void ThenSelectedMailTemplateRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.MailTemplateProperties.Name);
            Assert.IsFalse(group.Displayed(), "Selected Mail Template is displayed in the table");
        }

        #endregion
    }
}