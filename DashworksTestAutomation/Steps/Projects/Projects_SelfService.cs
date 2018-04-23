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

        public Projects_SelfService(RemoteWebDriver driver, SelfService_DetailsDto detailsDto, SelfService_WelcomeDto welcomeDto, SelfService_ComputerOwnershipDto computerOwnershipDto, SelfService_DepartmentAndLocationDto departmentAndLocationDto)
        {
            _driver = driver;
            _detailsDto = detailsDto;
            _welcomeDto = welcomeDto;
            _computerOwnershipDto = computerOwnershipDto;
            _departmentAndLocationDto = departmentAndLocationDto;
        }

        [When(@"User navigate to ""(.*)"" on selected tab")]
        public void WhenUserNavigateToOnSelectedTab(string tabName)
        {
            var tab = _driver.NowAt<BaseElements>();

            tab.GetTabElementByNameOnSelectedTab(tabName).Click();
        }

        [When(@"User updates the Details on Self Service tab")]
        public void WhenUserUpdatesTheDetailsOnSelfServiceTab(Table table)
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

        [When(@"User updates the Welcome on Self Service tab")]
        public void WhenUserUpdatesTheWelcomeOnSelfServiceTab(Table table)
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
            //page.LongName.SendKeys(_welcomeDto.LongName);
            //page.ShortName.SendKeys(_welcomeDto.ShortName);
            page.PageDescription.SendKeys(_welcomeDto.PageDescription);
            page.ProjectName.SendKeys(_welcomeDto.ProjectName);

            upd.UpdateButton.Click();
        }

        [When(@"User updates the Computer Ownership on Self Service tab")]
        public void WhenUserUpdatesTheComputerOwnershipOnSelfServiceTab(Table table)
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

        [When(@"User updates the Department and Location on Self Service tab")]
        public void WhenUserUpdatesTheDepartmentAndLocationOnSelfServiceTab(Table table)
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
    }
}