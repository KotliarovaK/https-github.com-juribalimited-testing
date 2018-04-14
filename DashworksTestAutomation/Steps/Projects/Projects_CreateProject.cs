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
            var page = _driver.NowAt<ProjectPropertiesPage>();

            table.CreateInstance<ProjectDto>().CopyPropertiesTo(_projectDto);
            _projectDto.ProjectName += TestDataGenerator.RandomString();

            page.ProjectName.SendKeys(_projectDto.ProjectName);
            page.ProjectShortName.SendKeys(_projectDto.ProjectShortName);
            page.ProjectDescription.SendKeys(_projectDto.ProjectDescription);
            page.ProjectType.SelectboxSelect(_projectDto.ProjectType.GetValue());
            page.DefaultLanguage.SelectboxSelect(_projectDto.DefaultLanguage.GetValue());

            page.CreateProjectButton.Click();
        }

        [When(@"User updating Details page")]
        public void WhenUserupdatingDetailsPage(Table table)
        {
            var page = _driver.NowAt<DetailsPage>();

            table.CreateInstance<DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.OnboardedApplications.SelectboxSelect(_detailsDto.DefaultReadinessForOnboardedApplications.GetValue());
            page.ShowLinkedObjects.SelectboxSelect(_detailsDto.DefaultValueForShowLinkedObjects.GetValue());
            page.ApplicationsTab1.SelectboxSelect(_detailsDto.DefaultViewForProjectObjectApplicationsTab1.GetValue());
            page.ApplicationsTab2.SelectboxSelect(_detailsDto.DefaultViewForProjectObjectApplicationsTab2.GetValue());
            page.ApplicationRationalization.SelectboxSelect(_detailsDto.DefaultValueForApplicationRationalization.GetValue());
            //page.ValueForApplicationRationalization.CheckCheckBox();
            page.OnboardUsedApplicationsByAssociationTo.SelectboxSelect(_detailsDto.OnboardUsedApplicationsByAssociationTo.GetValue());
            //Master HTML Email Template
            //Attachments
            page.CcEmail.SendKeys(_detailsDto.TaskEmailCcEmailAddress);
            page.BccEmail.SendKeys(_detailsDto.TaskEmailBccEmailAddress);
            page.StartDate.SendKeys(_detailsDto.StartDate);
            page.EndDate.SendKeys(_detailsDto.EndDate);

            page.UpdateButton.Click();
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

        [Then(@"in the ""(.*)"" team found ""(.*)"" groups")]
        public void ThenInTheTeamFoundGroups(string teamName, int groups)
        {
            
        }
    }
}