using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_ProjectsHome : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;

        public Projects_ProjectsHome(RemoteWebDriver driver, ProjectDto projectDto)
        {
            _driver = driver;
            _projectDto = projectDto;
        }

        [When(@"User select Project")]
        public void WhenUserSelectProject()
        {
            var page = _driver.NowAt<ProjectsHomePage>();

            page.ProjectDropDownList.Click();
            page.GetProjectInDropDownListByName(_projectDto.ProjectName).Click();
        }

        [Then(@"User make this Project Default")]
        public void ThenUserMakeThisProjectDefault()
        {
            var page = _driver.NowAt<ProjectsHomePage>();

            page.MakeDefaultButton.Click();
        }

        [Then(@"Default Project News Title is displayed correctly")]
        public void ThenDefaultProjectNewsTitleIsDisplayedCorrectly()
        {
            var message = _driver.NowAt<ProjectsHomePage>();

            Assert.IsTrue(message.DefaultProjectNewsTitle.Displayed(), "Default message is not displayed");
        }

        [Then(@"User navigate to created Project")]
        public void ThenUserNavigateToProject()
        {
            var menu = _driver.NowAt<BaseElements>();

            _driver.MouseHover(menu.Administration);
            _driver.WaitWhileControlIsNotDisplayed<BaseElements>(() => menu.ManageProject);
            _driver.MouseHover(menu.ManageProject);
            _driver.MouseHover(menu.GetProjectByName(_projectDto.ProjectName));
            menu.GetProjectByName(_projectDto.ProjectName).Click();
        }

        [Then(@"Project Name is displayed correctly")]
        public void ThenProjectNameIsDisplayedCorrectly()
        {
            var menu = _driver.NowAt<BaseElements>();

            var projectName = menu.GetOpenedProjectName(_projectDto.ProjectName);
            Assert.IsTrue(projectName.Displayed, "Project Name is not displayed correctly");
        }
    }
}