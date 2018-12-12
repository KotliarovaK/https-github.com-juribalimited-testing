using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
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

        [When(@"User navigates to the ""(.*)"" page on Dashboards tab")]
        public void WhenUserNavigatesToThePageOnDashboardsTab(string pageName)
        {
            var page = _driver.NowAt<ProjectsBaseElements>();
            _driver.MouseHover(page.DashboardsTab);
            _driver.MouseHover(page.GetSubTabByName(pageName));
            page.GetSubTabByName(pageName).Click();
        }

        [Then(@"User navigate to created Project")]
        public void ThenUserNavigateToProject()
        {
            var menu = _driver.NowAt<ProjectsBaseElements>();
            _driver.WaitForDataLoadingOnProjects();
            _driver.MouseHover(menu.AdministrationTab);
            var project = _driver.NowAt<MainElementsOfProjectCreation>();
            _driver.WaitWhileControlIsNotDisplayed<MainElementsOfProjectCreation>(() => project.ManageProject);
            _driver.MouseHover(project.ManageProject);
            _driver.MouseHover(menu.GetSubTabByName(_projectDto.ProjectName));
            menu.GetSubTabByName(_projectDto.ProjectName).Click();
        }

        [When(@"User navigate to ""(.*)"" Project")]
        public void WhenUserNavigateToProject(string projectName)
        {
            var menu = _driver.NowAt<ProjectsBaseElements>();
            _driver.WaitForDataLoadingOnProjects();
            _driver.MouseHover(menu.AdministrationTab);
            var project = _driver.NowAt<MainElementsOfProjectCreation>();
            _driver.WaitWhileControlIsNotDisplayed<MainElementsOfProjectCreation>(() => project.ManageProject);
            _driver.MouseHover(project.ManageProject);
            _driver.MouseHover(menu.GetSubTabByName(projectName));
            menu.GetSubTabByName(projectName).Click();
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

        [Then(@"Project Name is displayed correctly")]
        public void ThenProjectNameIsDisplayedCorrectly()
        {
            var menu = _driver.NowAt<MainElementsOfProjectCreation>();

            var projectName = menu.GetOpenedProjectName(_projectDto.ProjectName);
            Assert.IsTrue(projectName.Displayed, "Project Name is not displayed correctly");
        }

        [Then(@"Project with ""(.*)"" name is displayed correctly")]
        public void ThenProjectWithNameIsDisplayedCorrectly(string projectName)
        {
            var menu = _driver.NowAt<MainElementsOfProjectCreation>();
            Assert.IsTrue(menu.GetOpenedProjectName(projectName).Displayed, "Project Name is not displayed correctly");
        }
    }
}