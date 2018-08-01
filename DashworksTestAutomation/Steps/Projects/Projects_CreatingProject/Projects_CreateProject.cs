using System;
using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks;
using DashworksTestAutomation.Pages.Projects.Tasks;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ReadinessEnum = DashworksTestAutomation.DTO.Projects.ReadinessEnum;
using TaskStatusEnum = DashworksTestAutomation.DTO.Projects.TaskStatusEnum;

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
            var menu = _driver.NowAt<ProjectsBaseElements>();
            _driver.MouseHover(menu.AdministrationTab);
            var project = _driver.NowAt<MainElementsOfProjectCreation>();
            _driver.WaitWhileControlIsNotDisplayed<MainElementsOfProjectCreation>(() => project.CreatedProject);
            _driver.MouseHover(project.CreatedProject);
            project.CreatedProject.Click();
        }

        [When(@"User navigate to ""(.*)"" tab")]
        public void WhenUserNavigateToTab(string tabName)
        {
            var tab = _driver.NowAt<MainElementsOfProjectCreation>();

            tab.GetTabElementByName(tabName).Click();
        }

        [When(@"User clicks ""(.*)"" button")]
        public void WhenUserClicksCreateButton(string buttonName)
        {
            var tab = _driver.NowAt<MainElementsOfProjectCreation>();

            tab.GetButtonElementByName(buttonName).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Success message is displayed with ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedWithText(string text)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            _driver.WaitWhileControlIsNotDisplayed<MainElementsOfProjectCreation>(() => page.SuccessMessage);
            StringAssert.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Success message is displayed")]
        public void ThenSuccessMessageIsDisplayed()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<MainElementsOfProjectCreation>(() => page.SuccessMessage);
            Assert.IsTrue(page.SuccessMessage.Displayed(), "Success Message is not displayed");
        }

        [Then(@"Error message is not displayed")]
        public void ThenErrorMessageIsNotDisplayed()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            if (page.ErrorMessage.Displayed())
                Assert.IsFalse(page.ErrorMessage.Displayed(), $"Error message is displayed with following text: {page.ErrorMessage.Text}");
        }

        [When(@"User creates Project")]
        public void WhenUserCreatesProject(Table table)
        {
            var page = _driver.NowAt<ProjectPropertiesPage>();

            table.CreateInstance<ProjectDto>().CopyPropertiesTo(_projectDto);
            //assign ProjectTypeString to ProjectTypeEnum
            _projectDto.ProjectType = (ProjectTypeEnum)Enum.Parse(typeof(ProjectTypeEnum), _projectDto.ProjectTypeString);
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

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.ComputerScheduledProject))
                _detailsDto.OnboardUsedApplicationsByAssociationTo = OnboardUsedApplicationsByAssociationToEnum.Computer;

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.MailboxScheduledProject))
                _detailsDto.OnboardUsedApplicationsByAssociationTo = OnboardUsedApplicationsByAssociationToEnum.User;

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.UserScheduledProject))
                _detailsDto.OnboardUsedApplicationsByAssociationTo = OnboardUsedApplicationsByAssociationToEnum.Computer;


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
            page.CcEmail.SendKeys(_detailsDto.TaskEmailCcEmailAddress);
            page.BccEmail.SendKeys(_detailsDto.TaskEmailBccEmailAddress);
            page.StartDate.SendKeys(_detailsDto.StartDate);
            page.EndDate.SendKeys(_detailsDto.EndDate);
            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.MailboxScheduledProject))
                page.PermissionCategoryExists.SelectboxSelect(_detailsDto.OnboardMailboxUsersWithPermissions.GetValue());

            var upd = _driver.NowAt<MainElementsOfProjectCreation>();
            upd.UpdateButton.Click();

            _projectDto.Details = _detailsDto;
        }

        [Then(@"CC email field is displayed with ""(.*)"" text")]
        public void ThenCсEmailFieldIsDisplayedWithText(string emailText)
        {
            var page = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(page.GetTextInCcEmailAddressField(emailText).Displayed(), $"Email with '{emailText}' text is not displayed");
        }

        [Then(@"BCC email field is displayed with ""(.*)"" text")]
        public void ThenBCсEmailFieldIsDisplayedWithText(string emailText)
        {
            var page = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(page.GetTextInBccEmailAddressField(emailText).Displayed(), $"Email with '{emailText}' text is not displayed");
        }

        [When(@"User clearing CC email field")]
        public void WhenUserClearingCсEmailField()
        {
            var page = _driver.NowAt<DetailsPage>();
            page.CcEmail.Clear();
        }

        [When(@"User clearing BCC email field")]
        public void WhenUserClearingBссEmailField()
        {
            var page = _driver.NowAt<DetailsPage>();
            page.BccEmail.Clear();
        }

        [Then(@"CC email field is empty")]
        public void ThenCсEmailFieldIsEmpty()
        {
            var page = _driver.NowAt<DetailsPage>();
            Assert.IsEmpty(page.CcEmail.GetAttribute("value"), "CC email field is not empty");
        }

        [Then(@"BCC email field is empty")]
        public void ThenBссEmailFieldIsEmpty()
        {
            var page = _driver.NowAt<DetailsPage>();
            Assert.IsEmpty(page.BccEmail.GetAttribute("value"), "BCC email field is not empty");
        }

        [When(@"User create Request Type")]
        public void WhenUserCreateRequestType(Table table)
        {
            var page = _driver.NowAt<RequestTypePropertiesPage>();

            table.CreateInstance<RequestTypesDto>().CopyPropertiesTo(_requestTypesDto);
            //assign ObjectTypeString to ObjectTypeEnum
            _requestTypesDto.ObjectType = (ObjectTypeEnum)Enum.Parse(typeof(ObjectTypeEnum), _requestTypesDto.ObjectTypeString);
            //_requestTypesDto.Name += TestDataGenerator.RandomString();
            RequestTypesDto tempRequestTypesDto = new RequestTypesDto();
            _requestTypesDto.CopyPropertiesTo(tempRequestTypesDto);
            _projectDto.ReqestTypes.Add(tempRequestTypesDto);


            page.Name.SendKeys(_requestTypesDto.Name);
            page.Description.SendKeys(_requestTypesDto.Description);
            page.ObjectType.SelectboxSelect(_requestTypesDto.ObjectType.GetValue());

            page.ConfirmCreateRequestTypesButton.Click();
        }

        [When(@"User click on the created Request Type")]
        public void WhenUserClickOnTheCreatedRequestType()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            page.GetTheCreatedRequestTypeInTableByName(_projectDto.ReqestTypes.Last().Name).Click();
        }

        [When(@"User makes ""(.*)"" Request Type default")]
        public void WhenUserMakesRequestTypeDefault(string requestTypeName, Table table)
        {
            var tequest = _driver.NowAt<MainElementsOfProjectCreation>();
            tequest.GetTheCreatedRequestTypeInTableByName(requestTypeName).Click();

            var page = _driver.NowAt<RequestType_DetailsPage>();
            table.CreateInstance<RequestType_DetailsDto>().CopyPropertiesTo(_requestTypeDetailsDto);
            page.DefaultRequestTypeCheckbox.SetCheckboxState(_requestTypeDetailsDto.DefaultRequestType);
            Assert.IsTrue(page.DefaultRequestTypeCheckbox.Selected, "Selected checkbox is not checked");

            page.UpdateDetailsButton.Click();
        }

        [When(@"User click on the ""(.*)"" Request Type")]
        public void WhenUserClickOnTheRequestType(string requestTypeName)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            page.GetTheCreatedRequestTypeInTableByName(requestTypeName).Click();
        }

        [When(@"User updates the Request Type page")]
        public void ThenUserUpdatesTheRequestTypePage(Table table)
        {
            var page = _driver.NowAt<RequestType_DetailsPage>();

            table.CreateInstance<RequestType_DetailsDto>().CopyPropertiesTo(_requestTypeDetailsDto);
            page.DefaultRequestTypeCheckbox.SetCheckboxState(_requestTypeDetailsDto.DefaultRequestType);

            page.UpdateDetailsButton.Click();
        }

        [When(@"User create Category")]
        public void WhenUserCreateCategory(Table table)
        {
            var page = _driver.NowAt<CategoryPropertiesPage>();

            table.CreateInstance<CategoryPropertiesDto>().CopyPropertiesTo(_categoryPropertiesDto);
            //assign ObjectTypeString to CategoryObjectTypeEnum
            _categoryPropertiesDto.ObjectType = (CategoryObjectTypeEnum)Enum.Parse(typeof(CategoryObjectTypeEnum), _categoryPropertiesDto.ObjectTypeString);
            _categoryPropertiesDto.Name += TestDataGenerator.RandomString();
            CategoryPropertiesDto tempCategoryPropertiesDto = new CategoryPropertiesDto();
            _categoryPropertiesDto.CopyPropertiesTo(tempCategoryPropertiesDto);
            _projectDto.Categories.Add(tempCategoryPropertiesDto);

            page.Name.SendKeys(_categoryPropertiesDto.Name);
            page.Description.SendKeys(_categoryPropertiesDto.Description);
            page.ObjectType.SelectboxSelect(_categoryPropertiesDto.ObjectType.GetValue());

            page.ConfirmCreateCategoryButton.Click();
        }

        [When(@"User create Stage")]
        public void WhenUserCreateStage(Table table)
        {
            var page = _driver.NowAt<StagePropertiesPage>();

            table.CreateInstance<StagePropertiesDto>().CopyPropertiesTo(_stagePropertiesDto);
            //_stagePropertiesDto.StageName += TestDataGenerator.RandomString();
            StagePropertiesDto tempStagePropertiesDto = new StagePropertiesDto();
            _stagePropertiesDto.CopyPropertiesTo(tempStagePropertiesDto);
            _projectDto.Stages.Add(tempStagePropertiesDto);

            page.StageName.SendKeys(_stagePropertiesDto.StageName);
            _driver.WaitForDataLoading();

            //page.ConfirmCreateStageButton.Click();
        }

        [When(@"User create Task")]
        public void WhenUserCreateTask(Table table)
        {
            var page = _driver.NowAt<TaskPropertiesPage>();

            table.CreateInstance<TaskPropertiesDto>().CopyPropertiesTo(_taskPropertiesDto);
            //assign StagesNameString to StageNameEnum
            _taskPropertiesDto.Stages = (StageNameEnum)Enum.Parse(typeof(StageNameEnum), _taskPropertiesDto.StagesNameString);
            //assign TaskTypeString to TaskTypeEnum
            _taskPropertiesDto.TaskType = (TaskTypeEnum)Enum.Parse(typeof(TaskTypeEnum), _taskPropertiesDto.TaskTypeString);
            //assign ValueTypeString to ValueTypeEnum
            _taskPropertiesDto.ValueType = (ValueTypeEnum)Enum.Parse(typeof(ValueTypeEnum), _taskPropertiesDto.ValueTypeString);
            //assign ObjectTypeString to TaskObjectTypeEnum
            _taskPropertiesDto.ObjectType = (TaskObjectTypeEnum)Enum.Parse(typeof(TaskObjectTypeEnum), _taskPropertiesDto.ObjectTypeString);

            TaskPropertiesDto tempTaskPropertiesDto = new TaskPropertiesDto();
            _taskPropertiesDto.CopyPropertiesTo(tempTaskPropertiesDto);
            _projectDto.Tasks.Add(tempTaskPropertiesDto);

            page.Name.SendKeys(_taskPropertiesDto.Name);
            page.Help.SendKeys(_taskPropertiesDto.Help);
            page.StageName.SelectboxSelect(_taskPropertiesDto.Stages.GetValue());
            page.TaskType.SelectboxSelect(_taskPropertiesDto.TaskType.GetValue());
            page.ValueType.SelectboxSelect(_taskPropertiesDto.ValueType.GetValue());
            _driver.WaitForDataLoading();
            page.ObjectType.SelectboxSelect(_taskPropertiesDto.ObjectType.GetValue());

            if (!string.IsNullOrEmpty(_taskPropertiesDto.TaskValuesTemplateString))
            {
                //assign TaskValuesTemplateString to TaskValuesTemplateEnum
                _taskPropertiesDto.TaskValuesTemplate = (TaskValuesTemplateEnum)Enum.Parse(typeof(TaskValuesTemplateEnum), _taskPropertiesDto.TaskValuesTemplateString);

                if (_taskPropertiesDto.ValueType.Equals(ValueTypeEnum.Radiobutton))
                    page.TaskValuesTemplate.SelectboxSelect(_taskPropertiesDto.TaskValuesTemplate.GetValue());
                if (_taskPropertiesDto.ValueType.Equals(ValueTypeEnum.DropDownList))
                    page.TaskValuesTemplate.SelectboxSelect(_taskPropertiesDto.TaskValuesTemplate.GetValue());
            }

            _driver.WaitForDataLoading();
            page.ApplyToAllCheckbox.SetCheckboxState(_taskPropertiesDto.ApplyToAllCheckbox);

            page.ConfirmCreateTaskButton.Click();

            tempTaskPropertiesDto.TaskType = _taskPropertiesDto.TaskType;
            tempTaskPropertiesDto.ValueType = _taskPropertiesDto.ValueType;
            tempTaskPropertiesDto.ObjectType = _taskPropertiesDto.ObjectType;
        }

        [When(@"User updates the Task page")]
        public void WhenUserUpdatesTheTaskPage(Table table)
        {
            var page = _driver.NowAt<TaskProperties_DetailsPage>();

            table.CreateInstance<TaskProperties_DetailsDto>().CopyPropertiesTo(_taskPropertiesDetailsDto);

            if (_taskPropertiesDto.ValueType.Equals(ValueTypeEnum.Text))
            {
                //assign TextModeString to TextModeEnum
                _taskPropertiesDetailsDto.TextMode = (TextModeEnum)Enum.Parse(typeof(TextModeEnum), _taskPropertiesDetailsDto.TextModeString);

                page.TextMode.SelectboxSelect(_taskPropertiesDetailsDto.TextMode.GetValue());
                if (!string.IsNullOrEmpty(_taskPropertiesDetailsDto.TaskProjectRoleString))
                {
                    //assign TaskProjectRoleString to TaskProjectRoleEnum
                    _taskPropertiesDetailsDto.TaskProjectRole = (TaskProjectRoleEnum)Enum.Parse(typeof(TaskProjectRoleEnum), _taskPropertiesDetailsDto.TaskProjectRoleString);

                    page.TaskProjectRole.SelectboxSelect(_taskPropertiesDetailsDto.TaskProjectRole.GetValue());
                }
            }

            if (_taskPropertiesDto.ValueType.Equals(ValueTypeEnum.Date))
            {
                //assign TaskProjectRoleString to TaskProjectRoleEnum
                _taskPropertiesDetailsDto.TaskProjectRole = (TaskProjectRoleEnum)Enum.Parse(typeof(TaskProjectRoleEnum), _taskPropertiesDetailsDto.TaskProjectRoleString);

                _driver.WaitForDataLoading();
                Assert.AreEqual(_taskPropertiesDetailsDto.TaskHaADueDate, page.TaskHaADueDate.Selected,
                    "Cheked state is incorrect");
                Assert.AreEqual(_taskPropertiesDetailsDto.TaskHaADueDate,
                    Convert.ToBoolean(page.TaskHaADueDate.GetAttribute("disabled")),
                    "Checkbox state is incorrect");
                if (!string.IsNullOrEmpty(_taskPropertiesDetailsDto.DateModeString))
                {
                    //assign DateModeString to DateModeEnum
                    _taskPropertiesDetailsDto.DateMode = (DateModeEnum)Enum.Parse(typeof(DateModeEnum), _taskPropertiesDetailsDto.DateModeString);
                    page.DateMode.SelectboxSelect(_taskPropertiesDetailsDto.DateMode.GetValue());
                }
                page.TaskProjectRole.SelectboxSelect(_taskPropertiesDetailsDto.TaskProjectRole.GetValue());
            }

            if (_taskPropertiesDto.ValueType.Equals(ValueTypeEnum.DropDownList))
            {
                //assign TaskProjectRoleString to TaskProjectRoleEnum
                _taskPropertiesDetailsDto.TaskProjectRole = (TaskProjectRoleEnum)Enum.Parse(typeof(TaskProjectRoleEnum), _taskPropertiesDetailsDto.TaskProjectRoleString);

                page.TaskProjectRole.SelectboxSelect(_taskPropertiesDetailsDto.TaskProjectRole.GetValue());
                page.TaskImpactsReadiness.SetCheckboxState(_taskPropertiesDetailsDto.TaskImpactsReadiness);
                page.TaskHasAnOwner.SetCheckboxState(_taskPropertiesDetailsDto.TaskHasAnOwner);
                page.TaskHaADueDate.SetCheckboxState(_taskPropertiesDetailsDto.TaskHaADueDate);

                if (!string.IsNullOrEmpty(_taskPropertiesDetailsDto.DateModeString))
                {
                    //assign DateModeString to DateModeEnum
                    _taskPropertiesDetailsDto.DateMode = (DateModeEnum)Enum.Parse(typeof(DateModeEnum), _taskPropertiesDetailsDto.DateModeString);
                    page.DateMode.SelectboxSelect(_taskPropertiesDetailsDto.DateMode.GetValue());
                }      
            }

            if (_taskPropertiesDto.ValueType.Equals(ValueTypeEnum.Radiobutton))
            {
                //assign TaskProjectRoleString to TaskProjectRoleEnum
                _taskPropertiesDetailsDto.TaskProjectRole = (TaskProjectRoleEnum)Enum.Parse(typeof(TaskProjectRoleEnum), _taskPropertiesDetailsDto.TaskProjectRoleString);

                page.TaskProjectRole.SelectboxSelect(_taskPropertiesDetailsDto.TaskProjectRole.GetValue());
                page.TaskImpactsReadiness.SetCheckboxState(_taskPropertiesDetailsDto.TaskImpactsReadiness);
                page.TaskHasAnOwner.SetCheckboxState(_taskPropertiesDetailsDto.TaskHasAnOwner);
                page.TaskHaADueDate.SetCheckboxState(_taskPropertiesDetailsDto.TaskHaADueDate);

                if (page.TaskHaADueDate.Selected)
                {
                    //assign DateModeString to DateModeEnum
                    _taskPropertiesDetailsDto.DateMode = (DateModeEnum)Enum.Parse(typeof(DateModeEnum), _taskPropertiesDetailsDto.DateModeString);
                    page.DateMode.SelectboxSelect(_taskPropertiesDetailsDto.DateMode.GetValue());
                }
            }

            page.ShowDetails.SetCheckboxState(_taskPropertiesDetailsDto.ShowDetails);

            if (_taskPropertiesDto.TaskType.Equals(TaskTypeEnum.Group))
                page.GroupTaskDashboard.SetCheckboxState(_taskPropertiesDetailsDto.GroupTaskDashboard);

            if (_taskPropertiesDto.TaskType.Equals(TaskTypeEnum.Normal))
            {
                page.ProjectObject.SetCheckboxState(_taskPropertiesDetailsDto.ProjectObject);
                page.SelfService.SetCheckboxState(_taskPropertiesDetailsDto.SelfService);
            }
            page.BulkUpdate.SetCheckboxState(_taskPropertiesDetailsDto.BulkUpdate);

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
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            _driver.WaitWhileControlIsNotDisplayed<MainElementsOfProjectCreation>(() => page.SuccessPublishedTaskFlag);
            Assert.IsTrue(page.SuccessPublishedTaskFlag.Displayed(), "Success Flag is not displayed");
        }

        [When(@"User navigate to ""(.*)"" page")]
        public void WhenUserNavigateToPage(string tabName)
        {
            var tab = _driver.NowAt<MainElementsOfProjectCreation>();

            tab.GetTabElementByNameOnSelectedTab(tabName).Click();
        }

        [When(@"User create new Value")]
        public void ThenUserCreateNewValue(Table table)
        {
            var page = _driver.NowAt<TaskProperties_CreatingValuesPage>();

            table.CreateInstance<TaskProperties_ValuesDto>().CopyPropertiesTo(_taskPropertiesValuesDto);

            //assign TaskStatusString to TaskStatusEnum
            _taskPropertiesValuesDto.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), _taskPropertiesValuesDto.TaskStatusString);

            page.Name.SendKeys(_taskPropertiesValuesDto.Name);
            if (!string.IsNullOrEmpty(_taskPropertiesValuesDto.ReadinessString))
            {
                //assign ReadinessString to ReadinessEnum
                _taskPropertiesValuesDto.Readiness = (ReadinessEnum)Enum.Parse(typeof(ReadinessEnum), _taskPropertiesValuesDto.ReadinessString);
                page.SelectOnboardedApplications(_taskPropertiesValuesDto.Readiness);
            }
            page.TaskStatus.SelectboxSelect(_taskPropertiesValuesDto.TaskStatus.GetValue());
            page.DefaultValue.SetCheckboxState(_taskPropertiesValuesDto.DefaultValue);
        }

        [When(@"User navigates to ""(.*)"" Value")]
        public void WhenUserNavigatesToValue(string value)
        {
            var page = _driver.NowAt<TaskProperties_ValuesPage>();

            page.NavigateToSelectedValue(value);
        }

        [When(@"User edit selected Value")]
        public void WhenUserEditSelectedValue(Table table)
        {
            var page = _driver.NowAt<TaskProperties_CreatingValuesPage>();

            table.CreateInstance<TaskProperties_ValuesDto>().CopyPropertiesTo(_taskPropertiesValuesDto);

            if (!string.IsNullOrEmpty(_taskPropertiesValuesDto.Name))
            {
                page.Name.Clear();
                page.Name.SendKeys(_taskPropertiesValuesDto.Name);
            }
            if (!string.IsNullOrEmpty(_taskPropertiesValuesDto.ReadinessString))
            {
                //assign ReadinessString to ReadinessEnum
                _taskPropertiesValuesDto.Readiness = (ReadinessEnum)Enum.Parse(typeof(ReadinessEnum), _taskPropertiesValuesDto.ReadinessString);
                page.SelectOnboardedApplications(_taskPropertiesValuesDto.Readiness);
            }
            if (!string.IsNullOrEmpty(_taskPropertiesValuesDto.TaskStatusString))
            {
                //assign TaskStatusString to TaskStatusEnum
                _taskPropertiesValuesDto.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), _taskPropertiesValuesDto.TaskStatusString);
                page.TaskStatus.SelectboxSelect(_taskPropertiesValuesDto.TaskStatus.GetValue());
            }
            page.DefaultValue.SetCheckboxState(_taskPropertiesValuesDto.DefaultValue);
        }

        [When(@"User select ""(.*)"" Request Type on Task page")]
        public void WhenUserSelectRequestTypeOnTaskPage(string requestTypeName)
        {
            var page = _driver.NowAt<TaskProperties_RequestTypesPage>();
            page.GetRequestTypeCheckboxByName(requestTypeName);
        }

        [When(@"User save selected Request Type")]
        public void WhenUserSaveSelectedRequestType()
        {
            var page = _driver.NowAt<TaskProperties_RequestTypesPage>();
            page.SaveRequestTypeButton.Click();
            _driver.AcceptAlert();
        }

        [When(@"User create new Email")]
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
            TeamPropertiesDto tempTeamPropertiesDto = new TeamPropertiesDto();
            _teamPropertiesDto.CopyPropertiesTo(tempTeamPropertiesDto);
            _projectDto.TeamProperties.Add(tempTeamPropertiesDto);

            page.TeamName.SendKeys(_teamPropertiesDto.TeamName);
            page.ShortDescription.SendKeys(_teamPropertiesDto.ShortDescription);

            page.ConfirmCreateTeamButton.Click();

            tempTeamPropertiesDto.TeamName = _teamPropertiesDto.TeamName;
        }

        [When(@"User create Group owned for ""(.*)"" Team")]
        public void WhenUserCreateGroupOwnedForTeam(int teamIndex, Table table)
        {
            var page = _driver.NowAt<GroupPropertiesPage>();

            table.CreateInstance<GroupPropertiesDto>().CopyPropertiesTo(_groupPropertiesDto);
            _groupPropertiesDto.GroupName += TestDataGenerator.RandomString();
            GroupPropertiesDto tempGroupPropertiesDto = new GroupPropertiesDto();
            _groupPropertiesDto.CopyPropertiesTo(tempGroupPropertiesDto);
            _projectDto.GroupProperties.Add(tempGroupPropertiesDto);

            page.GroupName.SendKeys(_groupPropertiesDto.GroupName);
            _driver.WaitForDataLoading();
            try
            {
                page.OwnedByTeam.SelectboxSelect(_projectDto.TeamProperties[teamIndex - 1].TeamName);
                _driver.WaitForDataLoading();
            }
            catch (NoSuchElementException)
            {
                page = _driver.NowAt<GroupPropertiesPage>();
                page.OwnedByTeam.SelectboxSelect(_projectDto.TeamProperties[teamIndex - 1].TeamName);
                _driver.WaitForDataLoading();
            }

            page.ConfirmCreateGroupButton.Click();

            tempGroupPropertiesDto.OwnedByTeam = _projectDto.TeamProperties.Last().TeamName;
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
            var upd = _driver.NowAt<MainElementsOfProjectCreation>();
            upd.UpdateButton.Click();
        }

        [Then(@"created Team is displayed in the table")]
        public void ThenCreatedTeamIsDisplayedInTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var team = page.GetTheCreatedElementInTableByName(_projectDto.TeamProperties.Last().TeamName);
            Assert.IsTrue(team.Displayed(), "Selected Team is not displayed in the table");
        }

        [Then(@"created Group is displayed in the table")]
        public void ThenCreatedGroupIsDisplayedInTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var group = page.GetTheCreatedElementInTableByName(_projectDto.GroupProperties.First().GroupName);
            Assert.IsTrue(group.Displayed(), "Selected Group is not displayed in the table");
        }

        [Then(@"created Task is displayed in the table")]
        public void ThenCreatedTaskIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var task = page.GetTheCreatedTaskInTableByName(_projectDto.Tasks.Last().Name);
            Assert.IsTrue(task.Displayed(), "Selected Task is not displayed in the table");
        }

        [Then(@"created Email is displayed in the table")]
        public void ThenCreatedEmailIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var email = page.GetTheCreatedEmailInTableByName(_projectDto.MailTemplateProperties.Name);
            Assert.IsTrue(email.Displayed(), "Selected Email is not displayed in the table");
        }

        [Then(@"created Request Type is displayed in the table")]
        public void ThenCreatedRequestTypeIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetTheCreatedRequestTypeInTableByName(_projectDto.ReqestTypes.Last().Name).Displayed(), "Selected Request Type is not displayed in the table");
        }

        [Then(@"created Category is displayed in the table")]
        public void ThenCreatedCategoryIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            Assert.IsTrue(page.GetTheCreatedCategoryInTableByName(_projectDto.Categories.Last().Name).Displayed, "Selected Category is not displayed in the table");
        }

        [Then(@"created Stage is displayed in the table")]
        public void ThenCreatedStageIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Assert.IsTrue(page.GetTheCreatedElementInTableByName(_projectDto.Stages.Last().StageName).Displayed(), "Selected Stage is not displayed in the table");
        }

        [Then(@"created Request Type is a Default")]
        public void ThenCreatedRequestTypeIsADefault()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetDefaultRequestTypeCountByName(_projectDto.ReqestTypes.Last().Name).Displayed(), "Selected Request Type is not 'Default'");
        }

        [Then(@"required number of Groups is displayed for created team")]
        public void ThenRequiredNumberOfGroupsIsDisplayedForCreatedTeam()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var teamName = _projectDto.TeamProperties.Last().TeamName;
            var groupsInTeam = _projectDto.GroupProperties.Count(x => x.OwnedByTeam.Equals(teamName));
            var groups = page.GetGroupsCountByTeamName(_projectDto.TeamProperties.Last().TeamName);
            Assert.AreEqual(groups, groupsInTeam, "Number of groups is incorrect");
        }

        [Then(@"""(.*)"" number of Groups is displayed for ""(.*)"" Team")]
        public void ThenNumberOfGroupsIsDisplayedForTeam(int numberOfGroups, int teamIndex)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var groups = page.GetGroupsCountByTeamName(_projectDto.TeamProperties.Last().TeamName);
            Assert.AreEqual(groups, numberOfGroups, "Number of groups is incorrect");
        }

        [Then(@"""(.*)"" number of Members is displayed for created Team")]
        public void ThenRequiredNumberOfMembersIsDisplayedForCreatedTeam(int numberOfMembers)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            var members = page.GetMembersCountByTeamName(_projectDto.TeamProperties.Last().TeamName);
            Assert.AreEqual(members, numberOfMembers, "Number of members is incorrect");
        }
    }
}