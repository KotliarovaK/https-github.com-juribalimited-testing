using System;
using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.Tasks;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
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
        private readonly RequestType_DetailsDto _requestTypeDetailsDto;
        private readonly CategoryPropertiesDto _categoryPropertiesDto;
        private readonly StagePropertiesDto _stagePropertiesDto;
        private readonly TaskPropertiesDto _taskPropertiesDto;
        private readonly TaskProperties_DetailsDto _taskPropertiesDetailsDto;
        private readonly TaskProperties_EmailsDto _taskPropertiesEmailsDto;
        private readonly TaskProperties_ValuesDto _taskPropertiesValuesDto;
        private readonly TeamPropertiesDto _teamPropertiesDto;
        private readonly GroupPropertiesDto _groupPropertiesDto;
        private readonly MailTemplatePropertiesDto _mailTemplatePropertiesDto;
        private readonly NewsDto _newsDto;

        public Projects_CreateProject(RemoteWebDriver driver, ProjectDto projectDto, DetailsDto detailsDto, RequestTypesDto requestTypesDto, CategoryPropertiesDto categoryPropertiesDto, StagePropertiesDto stagePropertiesDto, TaskPropertiesDto taskPropertiesDto, TeamPropertiesDto teamPropertiesDto, GroupPropertiesDto groupPropertiesDto, MailTemplatePropertiesDto mailTemplatePropertiesDto, NewsDto newsDto, TaskProperties_DetailsDto taskPropertiesDetailsDto, RequestType_DetailsDto requestTypeDetailsDto, TaskProperties_ValuesDto taskPropertiesValuesDto, TaskProperties_EmailsDto taskPropertiesEmailsDto)
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
            _taskPropertiesDetailsDto = taskPropertiesDetailsDto;
            _requestTypeDetailsDto = requestTypeDetailsDto;
            _taskPropertiesValuesDto = taskPropertiesValuesDto;
            _taskPropertiesEmailsDto = taskPropertiesEmailsDto;
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

        [When(@"User clicks ""(.*)"" button")]
        public void WhenUserClicksCreateButton(string buttonName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetButtonElementByName(buttonName).Click();
        }

        [Then(@"Success message is displayed with ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedWithText(string text)
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitWhileControlIsNotDisplayed<BaseElements>(() => page.SuccessMessage);
            StringAssert.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Success message is displayed")]
        public void ThenSuccessMessageIsDisplayed()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitWhileControlIsNotDisplayed<BaseElements>(() => page.SuccessMessage);
            Assert.IsTrue(page.SuccessMessage.Displayed(), "Success Message is not displayed");
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
        }

        [When(@"User updates the Details page")]
        public void WhenUserupdatesTheDetailsPage(Table table)
        {
            var page = _driver.NowAt<DetailsPage>();

            table.CreateInstance<DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.SelectOnboardedApplications(_detailsDto.DefaultReadinessForOnboardedApplications);
            page.ShowLinkedObjects.SelectboxSelect(_detailsDto.DefaultValueForShowLinkedObjects.GetValue());
            page.ApplicationsTab1.SelectboxSelect(_detailsDto.DefaultViewForProjectObjectApplicationsTab1.GetValue());
            page.ApplicationsTab2.SelectboxSelect(_detailsDto.DefaultViewForProjectObjectApplicationsTab2.GetValue());
            page.ApplicationRationalisation.SelectboxSelect(_detailsDto.DefaultValueForApplicationRationalization.GetValue());
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

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [When(@"User create Request Type")]
        public void WhenUserCreateRequestType(Table table)
        {
            var page = _driver.NowAt<RequestTypePropertiesPage>();

            table.CreateInstance<RequestTypesDto>().CopyPropertiesTo(_requestTypesDto);
            _requestTypesDto.ObjectType = (ObjectTypeEnum) Enum.Parse(typeof(ObjectTypeEnum), _requestTypesDto.ObjectTypeString);
            _requestTypesDto.Name += TestDataGenerator.RandomString();

            page.Name.SendKeys(_requestTypesDto.Name);
            page.Description.SendKeys(_requestTypesDto.Description);
            page.ObjectType.SelectboxSelect(_requestTypesDto.ObjectType.GetValue());

            page.ConfirmCreateRequestTypesButton.Click();

            _projectDto.ReqestTypes.Add(_requestTypesDto);
        }

        [When(@"User click on the created Request Type")]
        public void WhenUserClickOnTheCreatedRequestType()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetTheCreatedRequestTypeInTableByName(_projectDto.ReqestTypes.Last().Name).Click();
        }

        [When(@"User click on the ""(.*)"" Request Type")]
        public void WhenUserClickOnTheRequestType(string requestTypeName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetTheCreatedRequestTypeInTableByName(requestTypeName).Click();
        }

        [Then(@"User updates the Request Type page")]
        public void ThenUserUpdatesTheRequestTypePage(Table table)
        {
            var page = _driver.NowAt<RequestType_DetailsPage>();

            table.CreateInstance<RequestType_DetailsDto>().CopyPropertiesTo(_requestTypeDetailsDto);

            page.DefaultRequestType.SetCheckboxState(_requestTypeDetailsDto.DefaultRequestType);

            page.UpdateDetailsButton.Click();
        }

        [When(@"User create Category")]
        public void WhenUserCreateCategory(Table table)
        {
            var page = _driver.NowAt<CategoryPropertiesPage>();

            table.CreateInstance<CategoryPropertiesDto>().CopyPropertiesTo(_categoryPropertiesDto);
            _categoryPropertiesDto.Name += TestDataGenerator.RandomString();

            page.Name.SendKeys(_categoryPropertiesDto.Name);
            page.Description.SendKeys(_categoryPropertiesDto.Description);
            page.ObjectType.SelectboxSelect(_categoryPropertiesDto.ObjectType.GetValue());

            page.ConfirmCreateCategoryButton.Click();

            _projectDto.Categories = _categoryPropertiesDto;
        }

        [When(@"User create Stage")]
        public void WhenUserCreateStage(Table table)
        {
            var page = _driver.NowAt<StagePropertiesPage>();

            table.CreateInstance<StagePropertiesDto>().CopyPropertiesTo(_stagePropertiesDto);
            _stagePropertiesDto.StageName += TestDataGenerator.RandomString();

            page.StageName.SendKeys(_stagePropertiesDto.StageName);

            page.ConfirmCreateStageButton.Click();

            _projectDto.Stages.Add(_stagePropertiesDto);
        }

        [When(@"User create Task")]
        public void WhenUserCreateTask(Table table)
        {
            var page = _driver.NowAt<TaskPropertiesPage>();

            table.CreateInstance<TaskPropertiesDto>().CopyPropertiesTo(_taskPropertiesDto);
            _taskPropertiesDto.Name += TestDataGenerator.RandomString();

            page.Name.SendKeys(_taskPropertiesDto.Name);
            page.Help.SendKeys(_taskPropertiesDto.Help);
            page.StageName.SelectboxSelect(_projectDto.Stages[new Random().Next(0, 3)].StageName);
            page.TaskType.SelectboxSelect(_taskPropertiesDto.TaskType.GetValue());
            page.ValueType.SelectboxSelect(_taskPropertiesDto.ValueType.GetValue());
            page.ObjectType.SelectboxSelect(_taskPropertiesDto.ObjectType.GetValue());
            page.TaskValuesTemplate.SelectboxSelect(_taskPropertiesDto.TaskValuesTemplate.GetValue());
            page.TaskValuesTemplateCheckbox.SetCheckboxState(_taskPropertiesDto.TaskValuesTemplateCheckbox);

            page.ConfirmCreateTaskButton.Click();

            _projectDto.Tasks = _taskPropertiesDto;
        }

        [When(@"User updates the Task page")]
        public void WhenUserUpdatesTheTaskPage(Table table)
        {
            var page = _driver.NowAt<TaskProperties_DetailsPage>();

            table.CreateInstance<TaskProperties_DetailsDto>().CopyPropertiesTo(_taskPropertiesDetailsDto);

            page.ValueType.SelectboxSelect(_taskPropertiesDetailsDto.ValueType.GetValue());
            page.TaskHaADueDate.SetCheckboxState(_taskPropertiesDetailsDto.TaskHaADueDate);
            page.DateMode.SelectboxSelect(_taskPropertiesDetailsDto.DateMode.GetValue());
            page.TaskImpactsReadiness.SetCheckboxState(_taskPropertiesDetailsDto.TaskImpactsReadiness);
            page.TaskHasAnOwner.SetCheckboxState(_taskPropertiesDetailsDto.TaskHasAnOwner);
            page.ShowDetails.SetCheckboxState(_taskPropertiesDetailsDto.ShowDetails);
            page.ProjectObject.SetCheckboxState(_taskPropertiesDetailsDto.ProjectObject);
            page.BulkUpdate.SetCheckboxState(_taskPropertiesDetailsDto.BulkUpdate);
            page.SelfService.SetCheckboxState(_taskPropertiesDetailsDto.SelfService);

            page.UpdateTaskButton.Click();
        }

        [When(@"User publishes the task")]
        public void WhenUserPublishesTheTask()
        {
            var page = _driver.NowAt<TaskProperties_DetailsPage>();

            page.PublishTaskButton.Click();
            _driver.AcceptAlert();
        }

        [When(@"User unpublishes the task")]
        public void WhenUserUnpublishesTheTask()
        {
            var page = _driver.NowAt<TaskProperties_DetailsPage>();

            page.UnpublishTaskButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"selected task was published")]
        public void ThenSelectedTaskWasPublished()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitWhileControlIsNotDisplayed<BaseElements>(() => page.SuccessPublishedTaskFlag);
            Assert.IsTrue(page.SuccessPublishedTaskFlag.Displayed(), "Success Flag is not displayed");
        }

        [When(@"User navigate to ""(.*)"" on selected tab")]
        public void WhenUserNavigateToOnTaskTab(string tabName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetTabElementByNameOnSelectedTab(tabName).Click();
        }

        [Then(@"User create new Value")]
        public void ThenUserCreateNewValue(Table table)
        {
            var page = _driver.NowAt<TaskProperties_ValuesPage>();

            table.CreateInstance<TaskProperties_ValuesDto>().CopyPropertiesTo(_taskPropertiesValuesDto);

            page.Name.SendKeys(_taskPropertiesValuesDto.Name);
            page.Help.SendKeys(_taskPropertiesValuesDto.Help);
            page.SelectOnboardedApplications(_taskPropertiesValuesDto.Readiness);
            page.TaskStatus.SelectboxSelect(_taskPropertiesValuesDto.TaskStatus.GetValue());
            page.DefaultValue.SetCheckboxState(_taskPropertiesValuesDto.DefaultValue);
        }

        [Then(@"User create new Email")]
        public void ThenUserCreateNewEmail(Table table)
        {
            var page = _driver.NowAt<TaskProperties_EmailsPage>();

            table.CreateInstance<TaskProperties_EmailsDto>().CopyPropertiesTo(_taskPropertiesEmailsDto);

            page.Days.SelectboxSelect(_taskPropertiesEmailsDto.Days.GetValue());
            page.TaskDue.SelectboxSelect(_taskPropertiesEmailsDto.TaskDue.GetValue());
            page.CountDays.SetCheckboxState(_taskPropertiesEmailsDto.CountDays);
            page.MailTemplate.SelectboxSelect(_projectDto.MailTemplateProperties.Name);
            page.Importance.SelectboxSelect(_taskPropertiesEmailsDto.Importance.GetValue());
            page.SendOnceOnly.SetCheckboxState(_taskPropertiesEmailsDto.SendOnceOnly);
            page.RequestTypesAll.SetCheckboxState(_taskPropertiesEmailsDto.RequestTypesAll);
            page.ApllyEmailToAll.SetCheckboxState(_taskPropertiesEmailsDto.ApllyEmailToAll);
            page.To.SendKeys(_taskPropertiesEmailsDto.To);
        }

        [When(@"User create Team")]
        public void WhenUserCreateTeam(Table table)
        {
            var page = _driver.NowAt<TeamPropertiesPage>();

            table.CreateInstance<TeamPropertiesDto>().CopyPropertiesTo(_teamPropertiesDto);
            _teamPropertiesDto.TeamName += TestDataGenerator.RandomString();

            page.TeamName.SendKeys(_teamPropertiesDto.TeamName);
            page.ShortDescription.SendKeys(_teamPropertiesDto.ShortDescription);

            page.ConfirmCreateTeamButton.Click();

            _projectDto.TeamProperties = _teamPropertiesDto;
        }

        [When(@"User create Group")]
        public void WhenUserCreateGroup(Table table)
        {
            var page = _driver.NowAt<GroupPropertiesPage>();

            table.CreateInstance<GroupPropertiesDto>().CopyPropertiesTo(_groupPropertiesDto);
            _groupPropertiesDto.GroupName += TestDataGenerator.RandomString();
            _projectDto.GroupProperties.Add(_groupPropertiesDto);

            page.GroupName.SendKeys(_groupPropertiesDto.GroupName);
            page.OwnedByTeam.SelectboxSelect(_projectDto.TeamProperties.TeamName);

            page.ConfirmCreateGroupButton.Click();

            _groupPropertiesDto.OwnedByTeam = _projectDto.TeamProperties.TeamName;
        }

        [When(@"User create Mail Template")]
        public void WhenUserCreateMailTemplate(Table table)
        {
            var page = _driver.NowAt<MailTemplatePropertiesPage>();

            table.CreateInstance<MailTemplatePropertiesDto>().CopyPropertiesTo(_mailTemplatePropertiesDto);
            _mailTemplatePropertiesDto.Name += TestDataGenerator.RandomString();

            page.Name.SendKeys(_mailTemplatePropertiesDto.Name);
            page.Description.SendKeys(_mailTemplatePropertiesDto.Description);
            page.SubjectLine.SendKeys(_mailTemplatePropertiesDto.SubjectLine);
            page.BodyText.SendKeys(_mailTemplatePropertiesDto.BodyText);
            //TODO Attachments

            page.ConfirmCreateMailTemplateButton.Click();

            _projectDto.MailTemplateProperties = _mailTemplatePropertiesDto;
        }

        [When(@"User updating News page")]
        public void WhenUserUpdatingNewsPage(Table table)
        {
            var page = _driver.NowAt<NewsPage>();

            table.CreateInstance<NewsDto>().CopyPropertiesTo(_newsDto);

            page.Title.SendKeys(_newsDto.Title);
            page.Text.SendKeys(_newsDto.Text);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"created Team is displayed in the table")]
        public void ThenCreatedTeamIsDisplayedInTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var team = page.GetTheCreatedElementInTableByName(_projectDto.TeamProperties.TeamName);
            Assert.IsTrue(team.Displayed(), "Selected Team is not displayed in the table");
        }

        [Then(@"created Group is displayed in the table")]
        public void ThenCreatedGroupIsDisplayedInTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var group = page.GetTheCreatedElementInTableByName(_projectDto.GroupProperties.First().GroupName);
            Assert.IsTrue(group.Displayed(), "Selected Group is not displayed in the table");
        }

        [Then(@"created Task is displayed in the table")]
        public void ThenCreatedTaskIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var task = page.GetTheCreatedTaskInTableByName(_projectDto.Tasks.Name);
            Assert.IsTrue(task.Displayed(), "Selected Task is not displayed in the table");
        }

        [Then(@"created Email is displayed in the table")]
        public void ThenCreatedEmailIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var email = page.GetTheCreatedEmailInTableByName(_projectDto.MailTemplateProperties.Name);
            Assert.IsTrue(email.Displayed(), "Selected Email is not displayed in the table");
        }

        [Then(@"created Request Type is displayed in the table")]
        public void ThenCreatedRequestTypeIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<BaseElements>();
            _driver.WaitForDataLoading();
            var requestType = page.GetTheCreatedRequestTypeInTableByName(_projectDto.ReqestTypes.Last().Name);
            Assert.IsTrue(requestType.Displayed(), "Selected Request Type is not displayed in the table");
        }

        [Then(@"created Category is displayed in the table")]
        public void ThenCreatedCategoryIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var category = page.GetTheCreatedCategoryInTableByName(_projectDto.Categories.Name);
            Assert.IsTrue(category.Displayed, "Selected Category is not displayed in the table");
        }

        [Then(@"created Stage is displayed in the table")]
        public void ThenCreatedStageIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var stage = page.GetTheCreatedElementInTableByName(_projectDto.Stages.Last().StageName);
            Assert.IsTrue(stage.Displayed(), "Selected Stage is not displayed in the table");
        }

        [Then(@"created Request Type is a Default")]
        public void ThenCreatedRequestTypeIsADefault()
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetDefaultRequestTypeCountByName(_projectDto.ReqestTypes.Last().Name).Displayed(), "Selected Request Type is not 'Default'");
        }

        [Then(@"required number of Groups is displayed for created team")]
        public void ThenRequiredNumberOfGroupsIsDisplayedForCreatedTeam()
        {
            var page = _driver.NowAt<BaseElements>();

            var groupsInTeam = _projectDto.GroupProperties.Count(x => x.OwnedByTeam.Equals(_projectDto.TeamProperties.TeamName));
            var groups = page.GetGroupsCountByTeamName(_projectDto.TeamProperties.TeamName);

            Assert.AreEqual(groups, groupsInTeam, "Number of groups is incorrect");
        }

        [Then(@"""(.*)"" number of Members is displayed for created team")]
        public void ThenRequiredNumberOfMembersIsDisplayedForCreatedTeam(int membersInTeam)
        {
            var page = _driver.NowAt<BaseElements>();

            var members = page.GetMembersCountByTeamName(_projectDto.TeamProperties.TeamName);
            Assert.AreEqual(members, membersInTeam, "Number of members is incorrect");
        }
    }
}