using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_SelfService : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly SelfService_DetailsDto _detailsDto;
        private readonly SelfService_WelcomeDto _welcomeDto;
        private readonly SelfService_ComputerOwnershipDto _computerOwnershipDto;
        private readonly SelfService_DepartmentAndLocationDto _departmentAndLocationDto;
        private readonly SelfService_AppsListDto _appsListDto;
        private readonly SelfService_ProjectDateDto _projectDateDto;
        private readonly SelfService_OtherOptions1Dto _options1Dto;
        private readonly SelfService_OtherOptions2Dto _options2Dto;
        private readonly SelfService_ThankYouDto _thankYouDto;

        public Projects_SelfService(RemoteWebDriver driver, SelfService_DetailsDto detailsDto, SelfService_WelcomeDto welcomeDto, SelfService_ComputerOwnershipDto computerOwnershipDto, SelfService_DepartmentAndLocationDto departmentAndLocationDto, SelfService_AppsListDto appsListDto, SelfService_ProjectDateDto projectDateDto, SelfService_OtherOptions1Dto otherOptions1Dto, SelfService_OtherOptions2Dto otherOptions2Dto, SelfService_ThankYouDto thankYouDto, ProjectDto projectDto)
        {
            _driver = driver;
            _detailsDto = detailsDto;
            _welcomeDto = welcomeDto;
            _computerOwnershipDto = computerOwnershipDto;
            _departmentAndLocationDto = departmentAndLocationDto;
            _appsListDto = appsListDto;
            _projectDateDto = projectDateDto;
            _options1Dto = otherOptions1Dto;
            _options2Dto = otherOptions2Dto;
            _thankYouDto = thankYouDto;
            _projectDto = projectDto;
        }

        [When(@"User navigate to ""(.*)"" page on Self Service tab")]
        public void WhenUserNavigateToPageOnSelfServiceTab(string tabName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetTabElementByNameOnSelfServiceTab(tabName).Click();
        }

        [Then(@"User updates the Details page on Self Service tab")]
        public void ThenUserUpdatesTheDetailsPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_DetailsPage>();

            table.CreateInstance<SelfService_DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.EnableSelfServicePortal.SetCheckboxState(_detailsDto.EnableSelfServicePortal);
            page.AllowAnonymousUsers.SetCheckboxState(_detailsDto.AllowAnonymousUsers);
            page.ThisProjectDefault.SetCheckboxState(_detailsDto.ThisProjectDefault);
            if (!_projectDto.ProjectType.Equals(ProjectTypeEnum.UserScheduledProject))
            {
                page.Mode1.SetCheckboxState(_detailsDto.Mode1);
                page.Mode2.SetCheckboxState(_detailsDto.Mode2);
            }
            page.NoLink.SetCheckboxState(_detailsDto.NoLink);
            page.DashworksProjectHomepage.SetCheckboxState(_detailsDto.DashworksProjectHomepage);
            page.CustomUrl.SetCheckboxState(_detailsDto.CustomUrl);
            if (_detailsDto.CustomUrl.Equals(true))
                page.CustomUrlTextFiald.SendKeys(_detailsDto.CustomUrlTextFiald);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Welcome page on Self Service tab")]
        public void ThenUserUpdatesTheWelcomePageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_WelcomePage>();

            table.CreateInstance<SelfService_WelcomeDto>().CopyPropertiesTo(_welcomeDto);

            page.Languages.SelectboxSelect(_welcomeDto.Language.GetValue());
            page.AddLanguageButton.Click();
            var language = page.GetLanguagesByName(_welcomeDto.Language.GetValue());
            Assert.IsTrue(language.Displayed(), "Selected Language is not displayed");
            page.GetDeleteButtonByLanguages(_welcomeDto.Language.GetValue()).Click();
            _driver.AcceptAlert();

            page.AllowToSearchForAnotherUser.SetCheckboxState(_welcomeDto.AllowToSearchForAnotherUser);
            page.AllowToChangeLanguage.SetCheckboxState(_welcomeDto.AllowToChangeLanguage);
            page.ShowProjectSelector.SetCheckboxState(_welcomeDto.ShowProjectSelector);
            page.ShowMoreDetailsLink.SetCheckboxState(_welcomeDto.ShowMoreDetailsLink);
            page.Type.SelectboxSelect(_welcomeDto.Type.GetValue());
            page.Field.SelectboxSelect(_welcomeDto.Field.GetValue());
            page.PageDescription.SendKeys(_welcomeDto.PageDescription);
            page.ProjectName.SendKeys(_welcomeDto.ProjectName);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Ownership page on Self Service tab")]
        public void ThenUserUpdatesTheOwnershipPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_ComputerOwnershipPage>();

            table.CreateInstance<SelfService_ComputerOwnershipDto>().CopyPropertiesTo(_computerOwnershipDto);

            page.ShowScreen.SetCheckboxState(_computerOwnershipDto.ShowScreen);
            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.ComputerScheduledProject))
            {
                page.ShowComputerName.SelectboxSelect(_computerOwnershipDto.ShowComputerName.GetValue());
                page.ShowComputers.SetCheckboxState(_computerOwnershipDto.ShowComputers);
                page.AllowUsersToSetPrimary.SetCheckboxState(_computerOwnershipDto.AllowUsersToSetPrimary);
                page.LimitMaximum.SendKeys(_computerOwnershipDto.LimitMaximum);
                page.LimitMinimum.SendKeys(_computerOwnershipDto.LimitMinimum);
            }
            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.UserScheduledProject))
            {
                page.ShowComputerName.SelectboxSelect(_computerOwnershipDto.ShowComputerName.GetValue());
                page.ShowComputers.SetCheckboxState(_computerOwnershipDto.ShowComputers);
                page.AllowUsersToSetPrimary.SetCheckboxState(_computerOwnershipDto.AllowUsersToSetPrimary);
                page.LimitMaximum.SendKeys(_computerOwnershipDto.LimitMaximum);
                page.LimitMinimum.SendKeys(_computerOwnershipDto.LimitMinimum);
            }
            page.ShowCategory.SetCheckboxState(_computerOwnershipDto.ShowCategory);
            page.AllowUsersToSearch.SetCheckboxState(_computerOwnershipDto.AllowUsersToSearch);
            page.AllowUsersToAddANote.SetCheckboxState(_computerOwnershipDto.AllowUsersToAddANote);

            page.PageDescription.SendKeys(_computerOwnershipDto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Department and Location page on Self Service tab")]
        public void ThenUserUpdatesTheDepartmentAndLocationPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_DepartmentAndLocationPage>();

            table.CreateInstance<SelfService_DepartmentAndLocationDto>().CopyPropertiesTo(_departmentAndLocationDto);

            page.ShowScreen.SetCheckboxState(_departmentAndLocationDto.ShowScreen);
            page.ShowDepartmentFullPath.SetCheckboxState(_departmentAndLocationDto.ShowDepartmentFullPath);
            page.ShowLocationFullPath.SetCheckboxState(_departmentAndLocationDto.ShowLocationFullPath);
            page.AllowUsersToAddANote.SetCheckboxState(_departmentAndLocationDto.AllowUsersToAddANote);
            page.Department.SetCheckboxState(_departmentAndLocationDto.Department);
            page.DepartmentDoNotPush.SetCheckboxState(_departmentAndLocationDto.DepartmentDoNotPush);
            page.DepartmentPushToOwned.SetCheckboxState(_departmentAndLocationDto.DepartmentPushToOwned);
            page.DepartmentPushToAll.SetCheckboxState(_departmentAndLocationDto.DepartmentPushToAll);
            page.Location.SetCheckboxState(_departmentAndLocationDto.Location);
            page.LocationDoNotPush.SetCheckboxState(_departmentAndLocationDto.LocationDoNotPush);
            page.LocationPushToOwned.SetCheckboxState(_departmentAndLocationDto.LocationPushToOwned);
            page.LocationPushToAll.SetCheckboxState(_departmentAndLocationDto.LocationPushToAll);
            page.DepartmentFeed.SetCheckboxState(_departmentAndLocationDto.DepartmentFeed);
            page.HrLocationFeed.SetCheckboxState(_departmentAndLocationDto.HrLocationFeed);
            page.ManualLocationFeed.SetCheckboxState(_departmentAndLocationDto.ManualLocationFeed);
            page.HistoricLocationFeed.SetCheckboxState(_departmentAndLocationDto.HistoricLocationFeed);
            page.PageDescription.SendKeys(_departmentAndLocationDto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Apps List page on Self Service tab")]
        public void ThenUserUpdatesTheAppsListPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_AppsListPage>();

            table.CreateInstance<SelfService_AppsListDto>().CopyPropertiesTo(_appsListDto);

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.ComputerScheduledProject))
                _appsListDto.View = ViewEnum.ComparisonConsolidated;

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.MailboxScheduledProject))
                _appsListDto.View = ViewEnum.TargetState;

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.UserScheduledProject))
                _appsListDto.View = ViewEnum.ComparisonConsolidated;

            page.ShowScreen.SetCheckboxState(_appsListDto.ShowThisScreen);
            page.ShowCoreApps.SetCheckboxState(_appsListDto.ShowCoreApps);
            page.ShowTargetStateReadiness.SetCheckboxState(_appsListDto.ShowTargetStateReadiness);
            page.ShowRequiredColumnAndSticky.SetCheckboxState(_appsListDto.ShowRequiredColumnAndSticky);
            page.ShowOnlyApplication.SetCheckboxState(_appsListDto.ShowOnlyApplication);
            page.AllowUsersToAddANote.SetCheckboxState(_appsListDto.AllowUsersToAddANote);
            page.View.SelectboxSelect(_appsListDto.View.GetValue());
            page.PageDescription.SendKeys(_appsListDto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();

            _projectDto.SelfServiceAppsListDto = _appsListDto;
        }

        [Then(@"User updates the Project Date page on Self Service tab")]
        public void ThenUserUpdatesTheProjectDatePageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_ProjectDatePage>();

            table.CreateInstance<SelfService_ProjectDateDto>().CopyPropertiesTo(_projectDateDto);

            //page.ShowScreen.SetCheckboxState(_projectDateDto.ShowThisScreen);
            page.ShowComputerName.SelectboxSelect(_projectDateDto.ShowComputerName.GetValue());
            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.ComputerScheduledProject))
                page.ShowComputerName.SelectboxSelect(_projectDateDto.ShowComputerName.GetValue());

            if (_projectDto.ProjectType.Equals(ProjectTypeEnum.UserScheduledProject))
                page.ShowComputerName.SelectboxSelect(_projectDateDto.ShowComputerName.GetValue());

            page.AllowUsersToAddANote.SetCheckboxState(_projectDateDto.AllowUsersToAddANote);
            page.MinimumHours.SendKeys(_projectDateDto.MinimumHours);
            page.MaximumHours.SendKeys(_projectDateDto.MaximumHours);
            page.PageDescription.SendKeys(_projectDateDto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the first Other Options page on Self Service tab")]
        public void ThenUserUpdatesTheFirstOtherOptionsPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_OtherOptionsPage>();

            table.CreateInstance<SelfService_OtherOptions1Dto>().CopyPropertiesTo(_options1Dto);

            page.ShowScreen.SetCheckboxState(_options1Dto.ShowScreen);
            page.AllowUsersToAddANote.SetCheckboxState(_options1Dto.AllowUsersToAddANote);
            page.OnlyOwned.SetCheckboxState(_options1Dto.OnlyOwned);
            page.AllLinked.SetCheckboxState(_options1Dto.AllLinked);
            page.PageDescription.SendKeys(_options1Dto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the second Other Options page on Self Service tab")]
        public void ThenUserUpdatesTheSecondOtherOptionsPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_OtherOptionsPage>();

            table.CreateInstance<SelfService_OtherOptions2Dto>().CopyPropertiesTo(_options2Dto);

            page.ShowScreen.SetCheckboxState(_options2Dto.ShowScreen);
            page.AllowUsersToAddANote.SetCheckboxState(_options1Dto.AllowUsersToAddANote);
            page.OnlyOwned.SetCheckboxState(_options2Dto.OnlyOwned);
            page.AllLinked.SetCheckboxState(_options2Dto.AllLinked);
            page.PageDescription.SendKeys(_options2Dto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Thank You page on Self Service tab")]
        public void ThenUserUpdatesTheThankYouPageOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_ThankYouPage>();

            table.CreateInstance<SelfService_ThankYouDto>().CopyPropertiesTo(_thankYouDto);

            page.ShowInTheSelfServicePortal.SetCheckboxState(_thankYouDto.SelfServicePortal);
            page.ShowInTheNavigationMenu.SetCheckboxState(_thankYouDto.NavigationMenu);
            page.ShowChoicesSummary.SetCheckboxState(_thankYouDto.ChoicesSummary);
            page.IncludeLink.SetCheckboxState(_thankYouDto.IncludeLink);
            page.PageDescription.SendKeys(_thankYouDto.PageDescription);

            var upd = _driver.NowAt<BaseElements>();
            upd.UpdateButton.Click();
        }
    }
}