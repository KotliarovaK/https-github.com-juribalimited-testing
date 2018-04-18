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
        private readonly StagePropertiesDto _stagePropertiesDto;
        private readonly TaskPropertiesDto _taskPropertiesDto;
        private readonly TeamPropertiesDto _teamPropertiesDto;
        private readonly GroupPropertiesDto _groupPropertiesDto;
        private readonly MailTemplatePropertiesDto _mailTemplatePropertiesDto;
        private readonly NewsDto _newsDto;

        public Projects_CreateProject(RemoteWebDriver driver, ProjectDto projectDto, DetailsDto detailsDto, RequestTypesDto requestTypesDto, CategoryPropertiesDto categoryPropertiesDto, StagePropertiesDto stagePropertiesDto, TaskPropertiesDto taskPropertiesDto, TeamPropertiesDto teamPropertiesDto, GroupPropertiesDto groupPropertiesDto, MailTemplatePropertiesDto mailTemplatePropertiesDto, NewsDto newsDto)
        {
            _driver = driver;
            _projectDto = projectDto;
            _detailsDto = detailsDto;
            _requestTypesDto = requestTypesDto;
            _categoryPropertiesDto = categoryPropertiesDto;
            _stagePropertiesDto = stagePropertiesDto;
            _taskPropertiesDto = taskPropertiesDto;
            _teamPropertiesDto = teamPropertiesDto;
            _groupPropertiesDto = groupPropertiesDto;
            _mailTemplatePropertiesDto = mailTemplatePropertiesDto;
            _newsDto = newsDto;
        }

        [When(@"User clicks create Project button")]
        public void WhenUserClicksCreateProjectButton()
        {
            var menu = _driver.NowAt<BaseElements>();

            _driver.MouseHover(menu.Administration);
            _driver.WaitWhileControlIsNotDisplayed<BaseElements>(() => menu.CreateProject);
            _driver.MouseHover(menu.CreateProject);
            menu.CreateProject.Click();
        }

        [When(@"User navigate to ""(.*)"" tab")]
        public void WhenUserNavigateToTab(string tabName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetTabElementByName(tabName).Click();
        }

        [When(@"User clicks ""(.*)"" create button")]
        public void WhenUserClicksCreateButton(string buttonName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetCreateButtonElementByName(buttonName).Click();
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
            var upd = _driver.NowAt<BaseElements>();

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

            upd.UpdateButton.Click();
        }

        [Then(@"User create Request Type")]
        public void ThenUserCreateRequestType(Table table)
        {
            var page = _driver.NowAt<RequestTypePropertiesPage>();

            table.CreateInstance<RequestTypesDto>().CopyPropertiesTo(_requestTypesDto);

            page.Name.SendKeys(_requestTypesDto.Name);
            page.Description.SendKeys(_requestTypesDto.Description);
            page.ObjectType.SelectboxSelect(_requestTypesDto.ObjectType.GetValue());

            page.ConfirmCreateRequestTypesButton.Click();
        }

        [Then(@"User create Category")]
        public void ThenUserCreateCategory(Table table)
        {
            var page = _driver.NowAt<CategoryPropertiesPage>();

            table.CreateInstance<CategoryPropertiesDto>().CopyPropertiesTo(_categoryPropertiesDto);

            page.Name.SendKeys(_categoryPropertiesDto.Name);
            page.Description.SendKeys(_categoryPropertiesDto.Description);
            page.ObjectType.SelectboxSelect(_categoryPropertiesDto.ObjectType.GetValue());

            page.ConfirmCreateCategoryButton.Click();
        }

        [Then(@"User create Stage")]
        public void ThenUserCreateStage(Table table)
        {
            var page = _driver.NowAt<StagePropertiesPage>();

            table.CreateInstance<StagePropertiesDto>().CopyPropertiesTo(_stagePropertiesDto);

            page.StageName.SendKeys(_stagePropertiesDto.StageName);

            page.ConfirmCreateStageButton.Click();
        }

        [Then(@"User create Task")]
        public void ThenUserCreateTask(Table table)
        {
            var page = _driver.NowAt<TaskPropertiesPage>();

            table.CreateInstance<TaskPropertiesDto>().CopyPropertiesTo(_taskPropertiesDto);

            page.Name.SendKeys(_taskPropertiesDto.Name);
            page.Help.SendKeys(_taskPropertiesDto.Help);
            page.StageName.SelectboxSelect(_taskPropertiesDto.StageName.GetValue());
            page.TaskType.SelectboxSelect(_taskPropertiesDto.TaskType.GetValue());
            page.ValueType.SelectboxSelect(_taskPropertiesDto.ValueType.GetValue());
            page.ObjectType.SelectboxSelect(_taskPropertiesDto.ObjectType.GetValue());
            page.TaskValuesTemplate.SelectboxSelect(_taskPropertiesDto.TaskValuesTemplate.GetValue());
            page.TaskValuesTemplateCheckbox.SetCheckboxState(_taskPropertiesDto.TaskValuesTemplateCheckbox);

            page.ConfirmCreateTaskButton.Click();
        }

        [Then(@"User create Team")]
        public void ThenUserCreateTeam(Table table)
        {
            var page = _driver.NowAt<TeamPropertiesPage>();

            table.CreateInstance<TeamPropertiesDto>().CopyPropertiesTo(_teamPropertiesDto);

            page.TeamName.SendKeys(_teamPropertiesDto.TeamName);
            page.ShortDescription.SendKeys(_teamPropertiesDto.ShortDescription);

            page.ConfirmCreateTeamButton.Click();
        }

        [Then(@"User create Group")]
        public void ThenUserCreateGroup(Table table)
        {
            var page = _driver.NowAt<GroupPropertiesPage>();

            table.CreateInstance<GroupPropertiesDto>().CopyPropertiesTo(_groupPropertiesDto);

            page.GroupName.SendKeys(_groupPropertiesDto.GroupName);
            page.OwnedByTeam.SelectboxSelect(_groupPropertiesDto.OwnedByTeam.GetValue());

            page.ConfirmCreateGroupButton.Click();
        }

        [Then(@"User create Mail Template")]
        public void ThenUserCreateMailTemplate(Table table)
        {
            var page = _driver.NowAt<MailTemplatePropertiesPage>();

            table.CreateInstance<MailTemplatePropertiesDto>().CopyPropertiesTo(_mailTemplatePropertiesDto);

            page.Name.SendKeys(_mailTemplatePropertiesDto.Name);
            page.Description.SendKeys(_mailTemplatePropertiesDto.Description);
            page.SubjectLine.SendKeys(_mailTemplatePropertiesDto.SubjectLine);
            page.BodyText.SendKeys(_mailTemplatePropertiesDto.BodyText);
            //TODO Attachments

            page.ConfirmCreateMailTemplateButton.Click();
        }

        [Then(@"User updating News page")]
        public void ThenUserUpdatingNewsPage(Table table)
        {
            var page = _driver.NowAt<NewsPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<NewsDto>().CopyPropertiesTo(_newsDto);

            page.Title.SendKeys(_newsDto.Title);
            page.Text.SendKeys(_newsDto.Text);

            upd.UpdateButton.Click();
        }

        //TODO Selector for Groups on Teams tab
        [Then(@"in the ""(.*)"" team found ""(.*)"" groups")]
        public void ThenInTheTeamFoundGroups(string teamName, int groups)
        {
        }
    }
}