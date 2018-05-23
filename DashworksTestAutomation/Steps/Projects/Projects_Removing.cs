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

        public Projects_Removing(RemoteWebDriver driver, ProjectDto projectDto)
        {
            _driver = driver;
            _projectDto = projectDto;
        }

        [Then(@"User removes ""(.*)"" Request Type")]
        public void ThenUserRemovesRequestType(string requestType)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(requestType).Click();
        }

        [Then(@"User removes created Request Type")]
        public void ThenUserRemovesCreatedRequestType()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.ReqestTypes.Last().Name).Click();
        }

        [Then(@"User removes ""(.*)"" Category")]
        public void ThenUserRemovesCategory(string categoryName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(categoryName).Click();
        }

        [Then(@"User removes created Category")]
        public void ThenUserRemovesCreatedCategory()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.Categories.Name).Click();
        }

        [Then(@"User removes ""(.*)"" Stage")]
        public void ThenUserRemovesStage(string stageName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteStageButtonElementByName(stageName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes created Stage")]
        public void ThenUserRemovesCreatedStage()
        {
            var page = _driver.NowAt<BaseElements>();

            var t = _projectDto.Stages.Last().StageName;
            page.GetDeleteStageButtonElementByName(t).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes ""(.*)"" Task")]
        public void ThenUserRemovesTask(string taskName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(taskName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes created Task")]
        public void ThenUserRemovesCreatedTask()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.Tasks.Name).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes ""(.*)"" Team")]
        public void ThenUserRemovesTeam(string teamName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(teamName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes created Team")]
        public void ThenUserRemovesCreatedTeam()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.TeamProperties.Last().TeamName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes ""(.*)"" Group")]
        public void ThenUserRemovesGroup(string groupName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(groupName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes created Group")]
        public void ThenUserRemovesCreatedGroup()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.GroupProperties.Last().GroupName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes ""(.*)"" Mail Templates")]
        public void ThenUserRemovesMailTemplates(string templateName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(templateName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes created Mail Template")]
        public void ThenUserRemovesCreatedMailTemplate()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.MailTemplateProperties.Name).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User removes the Project")]
        public void ThenUserRemoveTheProject()
        {
            var page = _driver.NowAt<BaseElements>();

            page.DeleteProjectButton.Click();
            _driver.AcceptAlert();
            page.ConfirmDeletedTheProjectButton.Click();
            _driver.AcceptAlert();
        }

        #region Check removing

        [Then(@"selected Team was removed")]
        public void ThenSelectedTeamWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitForDataLoading();
            Assert.IsFalse(page.GetTheCreatedElementInTableByName(_projectDto.TeamProperties.Last().TeamName).Displayed(), "Selected Team is displayed in the table");
        }

        [Then(@"selected Group was removed")]
        public void ThenSelectedGroupWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitForDataLoading();
            Assert.IsFalse(page.GetTheCreatedElementInTableByName(_projectDto.GroupProperties.Last().GroupName).Displayed(), "Selected Group is displayed in the table");
        }

        [Then(@"selected Task was removed")]
        public void ThenSelectedTaskWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitForDataLoading();
            Assert.IsFalse(page.GetTheCreatedElementInTableByName(_projectDto.Tasks.Name).Displayed(), "Selected Task is displayed in the table");
        }

        [Then(@"selected Stage was removed")]
        public void ThenSelectedStageWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitForDataLoading();
            Assert.IsFalse(page.GetTheCreatedElementInTableByName(_projectDto.Stages.Last().StageName).Displayed(), "Selected Stage is displayed in the table");
        }

        [Then(@"selected Category was removed")]
        public void ThenSelectedCategoryWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            Assert.IsFalse(page.GetTheCreatedElementInTableByName(_projectDto.Categories.Name).Displayed(), "Selected Category is displayed in the table");
        }

        [Then(@"selected Request Type was removed")]
        public void ThenSelectedRequestTypeWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var selectedRequestTypeName = _projectDto.ReqestTypes.Last().Name;
            var group = page.GetTheCreatedElementInTableByName(selectedRequestTypeName);
            Assert.IsFalse(group.Displayed(), "Selected Request Type is displayed in the table");
        }

        [Then(@"selected Mail Template was removed")]
        public void ThenSelectedMailTemplateWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var selectedMailTemplateName = _projectDto.MailTemplateProperties.Name;
            var group = page.GetTheCreatedElementInTableByName(selectedMailTemplateName);
            Assert.IsFalse(group.Displayed(), "Selected Mail Template is displayed in the table");
        }

        #endregion
    }
}