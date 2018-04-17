using System;
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
        private readonly RequestTypesDto _requestTypesDto;
        private readonly CategoryPropertiesDto _categoryPropertiesDto;

        public Projects_CreateProject(RemoteWebDriver driver, ProjectDto projectDto, DetailsDto detailsDto, RequestTypesDto requestTypesDto, CategoryPropertiesDto categoryPropertiesDto)
        {
            _driver = driver;
            _projectDto = projectDto;
            _detailsDto = detailsDto;
            _requestTypesDto = requestTypesDto;
            _categoryPropertiesDto = categoryPropertiesDto;
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
            var button = _driver.NowAt<BaseElements>();

            table.CreateInstance<DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.SelectOnboardedApplications(_detailsDto.DefaultReadinessForOnboardedApplications);
            page.ShowLinkedObjects.SelectboxSelect(_detailsDto.DefaultValueForShowLinkedObjects.GetValue());
            page.ApplicationsTab1.SelectboxSelect(_detailsDto.DefaultViewForProjectObjectApplicationsTab1.GetValue());
            //TODO DefaultViewForProjectObjectApplicationsTab2
            page.ApplicationRationalization.SelectboxSelect(_detailsDto.DefaultValueForApplicationRationalization.GetValue());
            page.OriginalApplicationColumnCheckbox.SetCheckboxState(_detailsDto.ShowOriginalColumn);
            page.IncludeSiteNameCheckbox.SetCheckboxState(_detailsDto.IncludeSiteName);
            page.OnboardNotApplicableApplicationsCheckbox.SetCheckboxState(_detailsDto.NotApplicableApplications);
            page.OnboardInstalledApplicationsByAssociationCheckbox.SetCheckboxState(_detailsDto.InstalledApplications);
            page.OnboardEntitledApplicationsByAssociationCheckbox.SetCheckboxState(_detailsDto.EntitledApplications);
            page.OnboardUsedApplicationsByAssociationTo.SelectboxSelect(_detailsDto.OnboardUsedApplicationsByAssociationTo.GetValue());
            //TODO Attachments
            page.CcEmail.SendKeys(_detailsDto.TaskEmailCcEmailAddress);
            page.BccEmail.SendKeys(_detailsDto.TaskEmailBccEmailAddress);
            page.StartDate.SendKeys(_detailsDto.StartDate);
            page.EndDate.SendKeys(_detailsDto.EndDate);

            button.UpdateButton.Click();
        }

        [When(@"User navigate to ""(.*)"" tab")]
        public void WhenUserNavigateToTab(string tabName)
        {
            var tab = _driver.NowAt<NavigationTabsMenu>();

            switch (tabName)
            {
                case "Details":
                    tab.DetailsTab.Click();
                    break;

                case "Request Types":
                    tab.RequestTypesTab.Click();
                    break;

                case "Categories":
                    tab.CategoriesTab.Click();
                    break;

                case "Stages":
                    tab.StagesTab.Click();
                    break;

                case "Tasks":
                    tab.TasksTab.Click();
                    break;

                case "Teams":
                    tab.TeamsTab.Click();
                    break;

                case "Users":
                    tab.UsersTab.Click();
                    break;

                case "Groups":
                    tab.GroupsTab.Click();
                    break;

                case "Mail Templates":
                    tab.MailTemplatesTab.Click();
                    break;

                case "News":
                    tab.NewsTab.Click();
                    break;

                case "Self Service":
                    tab.SelfServiceTab.Click();
                    break;

                case "Capacity":
                    tab.CapacityTab.Click();
                    break;

                default:
                    throw new Exception($"'{tab}' tab name is not valid and cannot be opened");
            }

            Logger.Write($"{tab} tab was clicked");

            _driver.WaitForDataLoading();
        }

        [When(@"User click create Request Type button")]
        public void WhenUserClickCreateRequestTypeButton()
        {
            var page = _driver.NowAt<RequestTypePropertiesPage>();
            page.CreateRequestTypesButton.Click();
        }

        [When(@"User create Request Type")]
        public void WhenUserCreateRequestType(Table table)
        {
            var page = _driver.NowAt<RequestTypePropertiesPage>();

            table.CreateInstance<RequestTypesDto>().CopyPropertiesTo(_requestTypesDto);

            page.Name.SendKeys(_requestTypesDto.Name);
            page.Description.SendKeys(_requestTypesDto.Description);
            page.ObjectType.SelectboxSelect(_requestTypesDto.ObjectType.GetValue());

            page.ConfirmCreateRequestTypesButton.Click();
        }

        [When(@"User create Categories")]
        public void WhenUserCreateCategories(Table table)
        {
            var page = _driver.NowAt<CategoryPropertiesPage>();
            var tab = _driver.NowAt<BaseElements>();

            table.CreateInstance<CategoryPropertiesDto>().CopyPropertiesTo(_categoryPropertiesDto);

            page.CreateCategoryButton.Click();

            page.Name.SendKeys(_categoryPropertiesDto.Name);
            page.Description.SendKeys(_categoryPropertiesDto.Description);
            page.ObjectType.SelectboxSelect(_categoryPropertiesDto.ObjectType.GetValue());

            //tab.ConfirmCreationButton.Click();
        }

        //TODO Selector for Groups on Teams tab
        [Then(@"in the ""(.*)"" team found ""(.*)"" groups")]
        public void ThenInTheTeamFoundGroups(string teamName, int groups)
        {
        }
    }
}