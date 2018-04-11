using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_CreateProject : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly DetailsDto _detailsDto;

        public Projects_CreateProject(RemoteWebDriver driver, ProjectDto projectDto, DetailsDto detailsDto)
        {
            _driver = driver;
            _projectDto = projectDto;
            _detailsDto = detailsDto;
        }

        [When(@"User clicks create Project button")]
        public void WhenUserClicksCreateProjectButton()
        {
            var menu = _driver.NowAt<NavigationMenu>();
            _driver.MouseHover(menu.Administration);
            _driver.WaitWhileControlIsNotDisplayed<NavigationMenu>(() => menu.CreateProject);
            _driver.MouseHover(menu.CreateProject);
            menu.CreateProject.Click();
        }

        [When(@"User creates Project")]
        public void WhenUserCreatesProject(Table table)
        {
            table.CreateInstance<ProjectDto>().CopyPropertiesTo(_projectDto);
            _projectDto.ProjectName += TestDataGenerator.RandomString();
        }

        [Then(@"User fills up Details page")]
        public void WhenUserFillsUpDetailsPage(Table table)
        {
            table.CreateInstance<DetailsDto>().CopyPropertiesTo(_detailsDto);
        }

        [When(@"User navigate to ""(.*)"" tab")]
        public void WhenUserNavigateToTab(string tabName)
        {
            var tab = _driver.NowAt<ManageProjectDetails>();
            tab.GetTabElementByName(tabName).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User click on ""(.*)"" button")]
        public void WhenUserClickOnButton(string buttonName)
        {
            var tab = _driver.NowAt<ManageProjectDetails>();
            tab.GetButtonElementByName(buttonName).Click();
            _driver.WaitForDataLoading();
        }
    }
}