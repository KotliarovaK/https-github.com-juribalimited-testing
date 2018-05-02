using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
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
    }
}