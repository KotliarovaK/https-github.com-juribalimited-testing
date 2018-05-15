using System.Linq;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.ManagementConsole;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps
{
    [Binding]
    internal class ManagementConsole : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly ManageUsersDto _manageUsers;

        public ManagementConsole(RemoteWebDriver driver, ProjectDto projectDto, ManageUsersDto manageUsers)
        {
            _driver = driver;
            _projectDto = projectDto;
            _manageUsers = manageUsers;
        }

        [When(@"User select ""(.*)"" option in Management Console")]
        public void WhenUserSelectOptionInManagementConsole(string optionName)
        {
            var page = _driver.NowAt<ManagementConsolePage>();

            _driver.MouseHover(page.GetLinkInManagementConsoleByName(optionName));
            page.GetLinkInManagementConsoleByName(optionName).Click();
        }

        [Then(@"User create a new Dashworks User")]
        public void ThenUserCreateANewDashworksUser(Table table)
        {
            var page = _driver.NowAt<ManageUserPage>();

            page.CreateNewUserButton.Click();

            table.CreateInstance<ManageUsersDto>().CopyPropertiesTo(_manageUsers);
            _manageUsers.Username += TestDataGenerator.RandomString();

            page.Username.SendKeys(_manageUsers.Username);
            page.FullName.SendKeys(_manageUsers.FullName);
            page.Password.SendKeys(_manageUsers.Password);
            page.ConfirmPassword.SendKeys(_manageUsers.ConfirmPassword);

            page.CreateUserButton.Click();

            _projectDto.ManageUsers = _manageUsers;
        }

        [Then(@"created User is displayed in the table")]
        public void ThenCreatedUserIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<BaseElements>();

            var user = page.GetTheCreatedElementInTableByName(_projectDto.ManageUsers.Username);
            Assert.IsTrue(user.Displayed(), "Selected User is not displayed in the table");
        }

        [Then(@"User select Users by Username")]
        public void ThenUserSelectUsersByUsername()
        {
            var page = _driver.NowAt<BaseElements>();

            page.SelectUserForMembersByName("Admin").Click();
            page.SelectUserForMembersByName(_projectDto.ManageUsers.Username).Click();
        }

        [Then(@"User removes created User")]
        public void ThenUserRemoveCreatedUser()
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteButtonElementByName(_projectDto.ManageUsers.Username).Click();
            _driver.AcceptAlert();
        }

        [Then(@"selected User was removed")]
        public void ThenSelectedUserWasRemoved()
        {
            var page = _driver.NowAt<BaseElements>();

            var user = page.GetTheCreatedElementInTableByName(_projectDto.ManageUsers.Username);
            Assert.IsFalse(user.Displayed(), "Selected User is displayed in the table");
        }
    }
}