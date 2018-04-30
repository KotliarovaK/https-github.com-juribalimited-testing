using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_SelfService : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly SelfService_DetailsDto _detailsDto;
        private readonly SelfService_WelcomeDto _welcomeDto;
        private readonly SelfService_ComputerOwnershipDto _computerOwnershipDto;
        private readonly SelfService_DepartmentAndLocationDto _departmentAndLocationDto;
        private readonly SelfService_AppsListDto _appsListDto;
        private readonly SelfService_ProjectDateDto _projectDateDto;
        private readonly SelfService_OtherOptions1Dto _options1Dto;
        private readonly SelfService_OtherOptions2Dto _options2Dto;
        private readonly SelfService_ThankYouDto _thankYouDto;

        public Projects_SelfService(RemoteWebDriver driver, SelfService_DetailsDto detailsDto, SelfService_WelcomeDto welcomeDto, SelfService_ComputerOwnershipDto computerOwnershipDto, SelfService_DepartmentAndLocationDto departmentAndLocationDto, SelfService_AppsListDto appsListDto, SelfService_ProjectDateDto projectDateDto, SelfService_OtherOptions1Dto otherOptions1Dto, SelfService_OtherOptions2Dto otherOptions2Dto, SelfService_ThankYouDto thankYouDto)
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
        }

        [When(@"User navigate to ""(.*)"" on selected tab")]
        public void WhenUserNavigateToOnSelectedTab(string tabName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetTabElementByNameOnSelectedTab(tabName).Click();
        }

        [Then(@"User updates the Details on Self Service tab")]
        public void ThenUserUpdatesTheDetailsOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_DetailsPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.EnableSelfServicePortal.SetCheckboxState(_detailsDto.EnableSelfServicePortal);
            page.AllowAnonymousUsers.SetCheckboxState(_detailsDto.AllowAnonymousUsers);
            page.ThisProjectDefault.SetCheckboxState(_detailsDto.ThisProjectDefault);
            page.ModeUser.SetCheckboxState(_detailsDto.ModeUser);
            page.ModeComputer.SetCheckboxState(_detailsDto.ModeComputer);
            //page.BaseUrl.SendKeys(_selfServiceDetailsDto.BaseUrl);
            page.NoLink.SetCheckboxState(_detailsDto.NoLink);
            page.DashworksProjectHomepage.SetCheckboxState(_detailsDto.DashworksProjectHomepage);
            page.CustomUrl.SetCheckboxState(_detailsDto.CustomUrl);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Welcome on Self Service tab")]
        public void ThenUserUpdatesTheWelcomeOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_WelcomePage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_WelcomeDto>().CopyPropertiesTo(_welcomeDto);

            page.AllowToSearchForAnotherUser.SetCheckboxState(_welcomeDto.AllowToSearchForAnotherUser);
            page.AllowToChangeLanguage.SetCheckboxState(_welcomeDto.AllowToChangeLanguage);
            page.ShowProjectSelector.SetCheckboxState(_welcomeDto.ShowProjectSelector);
            page.ShowMoreDetailsLink.SetCheckboxState(_welcomeDto.ShowMoreDetailsLink);
            page.Type.SelectboxSelect(_welcomeDto.Type.GetValue());
            page.Field.SelectboxSelect(_welcomeDto.Field.GetValue());
            page.PageDescription.SendKeys(_welcomeDto.PageDescription);
            page.ProjectName.SendKeys(_welcomeDto.ProjectName);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Computer Ownership on Self Service tab")]
        public void ThenUserUpdatesTheComputerOwnershipOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_ComputerOwnershipPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_ComputerOwnershipDto>().CopyPropertiesTo(_computerOwnershipDto);

            page.ShowScreen.SetCheckboxState(_computerOwnershipDto.ShowScreen);
            page.ShowComputerName.SelectboxSelect(_computerOwnershipDto.ShowComputerName.GetValue());
            page.ShowComputers.SetCheckboxState(_computerOwnershipDto.ShowComputers);
            page.ShowCategory.SetCheckboxState(_computerOwnershipDto.ShowCategory);
            page.AllowUsersToSearch.SetCheckboxState(_computerOwnershipDto.AllowUsersToSearch);
            page.AllowUsersToSetPrimary.SetCheckboxState(_computerOwnershipDto.AllowUsersToSetPrimary);
            page.AllowUsersToAddANote.SetCheckboxState(_computerOwnershipDto.AllowUsersToAddANote);
            page.LimitMaximum.SendKeys(_computerOwnershipDto.LimitMaximum);
            page.LimitMinimum.SendKeys(_computerOwnershipDto.LimitMinimum);
            page.PageDescription.SendKeys(_computerOwnershipDto.PageDescription);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Department and Location on Self Service tab")]
        public void ThenUserUpdatesTheDepartmentAndLocationOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_DepartmentAndLocationPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_DepartmentAndLocationDto>().CopyPropertiesTo(_departmentAndLocationDto);

            page.ShowScreen.SetCheckboxState(_departmentAndLocationDto.ShowScreen);
            page.ShowDepartmentFullPath.SetCheckboxState(_departmentAndLocationDto.ShowDepartmentFullPath);
            page.ShowLocationFullPath.SetCheckboxState(_departmentAndLocationDto.ShowLocationFullPath);
            page.AllowUsersToAddANote.SetCheckboxState(_departmentAndLocationDto.AllowUsersToAddANote);
            page.Department.SetCheckboxState(_departmentAndLocationDto.Department);
            //TODO
            page.Location.SetCheckboxState(_departmentAndLocationDto.Location);
            //TODO

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Apps List on Self Service tab")]
        public void ThenUserUpdatesTheAppsListOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_AppsListPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_AppsListDto>().CopyPropertiesTo(_appsListDto);

            page.ShowScreen.SetCheckboxState(_appsListDto.ShowThisScreen);
            page.ShowCoreApps.SetCheckboxState(_appsListDto.ShowCoreApps);
            page.ShowTargetStateReadiness.SetCheckboxState(_appsListDto.ShowTargetStateReadiness);
            page.ShowRequiredColumnAndSticky.SetCheckboxState(_appsListDto.ShowRequiredColumnAndSticky);
            page.ShowOnlyApplication.SetCheckboxState(_appsListDto.ShowOnlyApplication);
            page.AllowUsersToAddANote.SetCheckboxState(_appsListDto.AllowUsersToAddANote);
            page.View.SelectboxSelect(_appsListDto.View.GetValue());
            page.PageDescription.SendKeys(_appsListDto.PageDescription);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Project Date on Self Service tab")]
        public void ThenUserUpdatesTheProjectDateOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_ProjectDatePage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_ProjectDateDto>().CopyPropertiesTo(_projectDateDto);

            //page.ShowScreen.SetCheckboxState(_projectDateDto.ShowThisScreen);
            page.ShowComputerName.SelectboxSelect(_projectDateDto.ShowComputerName.GetValue());
            page.AllowUsersToAddANote.SetCheckboxState(_projectDateDto.AllowUsersToAddANote);
            page.MinimumHours.SendKeys(_projectDateDto.MinimumHours);
            page.MaximumHours.SendKeys(_projectDateDto.MaximumHours);
            page.PageDescription.SendKeys(_projectDateDto.PageDescription);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the first Other Options on Self Service tab")]
        public void ThenUserUpdatesTheFirstOtherOptionsOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_OtherOptions1Page>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_OtherOptions1Dto>().CopyPropertiesTo(_options1Dto);

            page.ShowScreen.SetCheckboxState(_options1Dto.ShowScreen);
            page.AllowUsersToAddANote.SetCheckboxState(_options1Dto.AllowUsersToAddANote);
            page.OnlyOwned.SetCheckboxState(_options1Dto.OnlyOwned);
            page.AllLinked.SetCheckboxState(_options1Dto.AllLinked);
            page.PageDescription.SendKeys(_options1Dto.PageDescription);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the second Other Options on Self Service tab")]
        public void ThenUserUpdatesTheSecondOtherOptionsOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_OtherOptions2Page>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_OtherOptions2Dto>().CopyPropertiesTo(_options2Dto);

            page.ShowScreen.SetCheckboxState(_options1Dto.ShowScreen);
            page.AllowUsersToAddANote.SetCheckboxState(_options1Dto.AllowUsersToAddANote);
            page.OnlyOwned.SetCheckboxState(_options1Dto.OnlyOwned);
            page.AllLinked.SetCheckboxState(_options1Dto.AllLinked);
            page.PageDescription.SendKeys(_options1Dto.PageDescription);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Thank You on Self Service tab")]
        public void ThenUserUpdatesTheThankYouOnSelfServiceTab(Table table)
        {
            var page = _driver.NowAt<SelfService_ThankYouPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<SelfService_ThankYouDto>().CopyPropertiesTo(_thankYouDto);

            page.ShowInTheSelfServicePortal.SetCheckboxState(_thankYouDto.SelfServicePortal);
            page.ShowInTheNavigationMenu.SetCheckboxState(_thankYouDto.NavigationMenu);
            page.ShowChoicesSummary.SetCheckboxState(_thankYouDto.ChoicesSummary);
            page.IncludeLink.SetCheckboxState(_thankYouDto.IncludeLink);
            page.PageDescription.SendKeys(_thankYouDto.PageDescription);

            upd.UpdateButton.Click();
        }
    }
}