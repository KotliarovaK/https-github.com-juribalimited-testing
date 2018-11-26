using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects.Projects_CreatingProject
{
    [Binding]
    internal class Projects_Removing : SpecFlowContext
    {
        private readonly PrjLastDeletedRequestTypeName _deletedRequestTypeName;
        private readonly PrjLastDeletedStageName _deletedStageName;
        private readonly PrjLastDeletedTaskName _deletedTaskName;
        private readonly PrjLastDeletedTeamName _deletedTeamName;
        private readonly PrjLastDeletedGroupName _deletedGroupName;
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;

        public Projects_Removing(RemoteWebDriver driver, ProjectDto projectDto,
            PrjLastDeletedGroupName deletedGroupName, PrjLastDeletedTeamName deletedTeamName,
            PrjLastDeletedTaskName deletedTaskName, PrjLastDeletedStageName deletedStageName,
            PrjLastDeletedRequestTypeName deletedRequestTypeName)
        {
            _driver = driver;
            _projectDto = projectDto;
            _deletedGroupName = deletedGroupName;
            _deletedTeamName = deletedTeamName;
            _deletedTaskName = deletedTaskName;
            _deletedStageName = deletedStageName;
            _deletedRequestTypeName = deletedRequestTypeName;
        }

        [When(@"User removes created Request Type")]
        public void ThenUserRemovesCreatedRequestType()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _deletedRequestTypeName.Value = _projectDto.ReqestTypes.Last().Name;
            _driver.WaitForDataLoading();
            page.GetDeleteButtonElementByName(_deletedRequestTypeName.Value).Click();
            //Removing deleted Request Type from request types list
            _projectDto.ReqestTypes.RemoveAt(_projectDto.ReqestTypes.Count - 1);
        }

        [When(@"User removes created Category")]
        public void ThenUserRemovesCreatedCategory()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            page.GetDeleteButtonElementByName(_projectDto.Categories.Last().Name).Click();
        }

        [When(@"User removes created Stage")]
        public void ThenUserRemovesCreatedStage()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _deletedStageName.Value = _projectDto.Stages.Last().StageName;
            page.GetDeleteStageButtonElementByName(_deletedStageName.Value).Click();
            _driver.AcceptAlert();
            //Removing deleted Stage from stages list
            _projectDto.Stages.RemoveAt(_projectDto.Stages.Count - 1);
        }

        [When(@"User removes created Task")]
        public void ThenUserRemovesCreatedTask()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _deletedTaskName.Value = _projectDto.Tasks.Last().Name;
            page.GetDeleteButtonElementByName(_deletedTaskName.Value).Click();
            _driver.AcceptAlert();
            //Removing deleted Task from tasks list
            _projectDto.Tasks.RemoveAt(_projectDto.Tasks.Count - 1);
        }

        [When(@"User removes ""(.*)"" Task")]
        public void WhenUserRemovesTask(string taskName)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            page.GetDeleteButtonElementByName(taskName).Click();
            _driver.AcceptAlert();
        }

        [When(@"User removes created Team")]
        public void ThenUserRemovesCreatedTeam()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _deletedTeamName.Value = _projectDto.TeamProperties.Last().TeamName;
            page.GetDeleteButtonElementByName(_deletedTeamName.Value).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
            //Removing deleted Team from teams list
            _projectDto.TeamProperties.RemoveAt(_projectDto.TeamProperties.Count - 1);
        }

        [When(@"User removes created Group")]
        public void ThenUserRemovesCreatedGroup()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _deletedGroupName.Value = _projectDto.GroupProperties.Last().GroupName;
            page.GetDeleteButtonElementByName(_deletedGroupName.Value).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
            //Removing deleted Group from groups list
            _projectDto.GroupProperties.RemoveAt(_projectDto.GroupProperties.Count - 1);
        }

        [When(@"User removes created Mail Template")]
        public void ThenUserRemovesCreatedMailTemplate()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            page.GetDeleteButtonElementByName(_projectDto.MailTemplateProperties.Name).Click();
            _driver.AcceptAlert();
        }

        [When(@"User removes the Project")]
        public void ThenUserRemoveTheProject()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            page.DeleteProjectButton.Click();
            _driver.AcceptAlert();
            page.ConfirmDeletedTheProjectButton.Click();
            _driver.AcceptAlert();
        }

        #region Check removing

        [Then(@"selected Team was removed")]
        public void ThenSelectedTeamWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            _driver.WaitForDataLoading();
            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_deletedTeamName.Value),
                "Selected Team is displayed in the table");
        }

        [Then(@"selected Group was removed")]
        public void ThenSelectedGroupWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_deletedGroupName.Value),
                "Selected Group is displayed in the table");
        }

        [Then(@"selected Task was removed")]
        public void ThenSelectedTaskWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_deletedTaskName.Value),
                "Selected Task is displayed in the table");
        }

        [Then(@"selected Stage was removed")]
        public void ThenSelectedStageWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_deletedStageName.Value),
                "Selected Stage is displayed in the table");
        }

        [Then(@"selected Category was removed")]
        public void ThenSelectedCategoryWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_projectDto.Categories.Last().Name),
                "Selected Category is displayed in the table");
        }

        [Then(@"selected Request Type was removed")]
        public void ThenSelectedRequestTypeWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_deletedRequestTypeName.Value),
                "Selected Request Type is displayed in the table");
        }

        [Then(@"selected Mail Template was removed")]
        public void ThenSelectedMailTemplateWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsFalse(page.CheckThatCreatedElementIsRemoved(_projectDto.MailTemplateProperties.Name),
                "Selected Mail Template is displayed in the table");
        }

        #endregion
    }
}