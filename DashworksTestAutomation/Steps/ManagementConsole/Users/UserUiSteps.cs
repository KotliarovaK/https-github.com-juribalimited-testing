using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.ManagementConsole;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.ManagementConsole
{
    [Binding]
    internal class UserUiSteps : SpecFlowContext
    {
        private readonly PrjLastDeletedUserName _deletedUserName;
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly ManageUsersDto _manageUsers;
        private readonly DTO.RuntimeVariables.Users _users;

        public UserUiSteps(RemoteWebDriver driver, ProjectDto projectDto, ManageUsersDto manageUsers,
            PrjLastDeletedUserName deletedUserName, DTO.RuntimeVariables.Users users)
        {
            _driver = driver;
            _projectDto = projectDto;
            _manageUsers = manageUsers;
            _deletedUserName = deletedUserName;
            _users = users;
        }

        //| Username | FullName | Password | ConfirmPassword | Roles |
        [When(@"User creates new clear User")]
        public void WhenUserCreatesNewClearUser(Table table)
        {
            var user = table.CreateInstance<UserDto>();

            CreateUser(user);
        }

        //| Username | FullName | Password | ConfirmPassword | Roles |
        [When(@"User create new User")]
        public void WhenUserCreateNewUser(Table table)
        {
            var user = table.CreateInstance<UserDto>();

            CreateUser(user, new List<string>() { "Dashworks Users", "Dashworks Evergreen Users" });
        }

        private void CreateUser(UserDto user, List<string> additionalRoles = null)
        {
            if (additionalRoles != null && additionalRoles.Any())
                user.UserRoles.AddRange(additionalRoles);
            var page = _driver.NowAt<ManageUserPage>();
            page.CreateNewUserButton.Click();
            page.Username.SendKeys(user.Username);
            page.FullName.SendKeys(user.FullName);
            page.Password.SendKeys(user.Password);
            page.ConfirmPassword.SendKeys(user.ConfirmPassword);
            if (user.UserRoles.Any())
                foreach (string role in user.UserRoles.Where(x => !string.IsNullOrEmpty(x)))
                {
                    page.Roles.SelectboxSelect(role);
                }
            page.AddRoleButton.Click();

            _users.Value.Add(user);

            page.CreateUserButton.Click();
        }

        [Then(@"User create a new Dashworks User")]
        public void ThenUserCreateANewDashworksUser(Table table)
        {
            var page = _driver.NowAt<ManageUserPage>();

            page.CreateNewUserButton.Click();

            table.CreateInstance<ManageUsersDto>().CopyPropertiesTo(_manageUsers);
            _manageUsers.Username += TestDataGenerator.RandomString();
            var tempManageUsersDto = new ManageUsersDto();
            _manageUsers.CopyPropertiesTo(tempManageUsersDto);
            _projectDto.ManageUsers.Add(tempManageUsersDto);

            page.Username.SendKeys(_manageUsers.Username);
            page.FullName.SendKeys(_manageUsers.FullName);
            page.Password.SendKeys(_manageUsers.Password);
            page.ConfirmPassword.SendKeys(_manageUsers.ConfirmPassword);
            page.Roles.SelectboxSelect(_manageUsers.Roles.GetValue());
            page.Roles.SelectboxSelect("Dashworks Users");
            page.AddRoleButton.Click();
            if (!string.IsNullOrEmpty(_manageUsers.RolesString))
            {
                //assign RolesString to RolesEnum
                _manageUsers.Roles = (RolesEnum)Enum.Parse(typeof(RolesEnum), _manageUsers.RolesString);
                page.Roles.SelectboxSelect(_manageUsers.Roles.GetValue());
            }

            page.AddRoleButton.Click();

            page.CreateUserButton.Click();
        }

        [Then(@"created User is displayed in the table")]
        public void ThenCreatedUserIsDisplayedInTheTable()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            //Perform search because newly created items not always on first page
            page.SearchTextBox.SendKeys(_projectDto.ManageUsers.Last().Username);
            page.SearchButton.Click();

            var user = page.GetTheCreatedElementInTableByName(_projectDto.ManageUsers.Last().Username);
            Verify.IsTrue(user.Displayed(), "Selected User is not displayed in the table");
        }

        [When(@"User select user with ""(.*)"" name to add as member")]
        public void WhenUserSelectUserWithNameToAddAsMember(string userName)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            // Perform search because created items not always on first page
            page.SearchTextBoxForMembers.Clear();
            page.SearchTextBoxForMembers.SendKeys(userName);
            page.SearchButtonForMembers.Click();
            page.SelectUserForMembersByName(userName).Click();
            page.GetButtonElementByName("Add Selected").Click();
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User select ""(.*)"" user to add as member")]
        public void WhenUserSelectUserToAddAsMember(int userIndex)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            // Perform search because created items not always on first page
            page.SearchTextBoxForMembers.Clear();
            page.SearchTextBoxForMembers.SendKeys(_projectDto.ManageUsers[userIndex - 1].Username);
            page.SearchButtonForMembers.Click();
            page.SelectUserForMembersByName(_projectDto.ManageUsers[userIndex - 1].Username).Click();
            page.GetButtonElementByName("Add Selected").Click();
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User removes created User")]
        public void ThenUserRemoveCreatedUser()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            //Perform search because newly created items not always on first page
            page.SearchTextBox.Clear();
            page.SearchTextBox.SendKeys(_projectDto.ManageUsers.Last().Username);
            page.SearchButton.Click();

            _deletedUserName.Value = _projectDto.ManageUsers.Last().Username;
            page.GetDeleteButtonElementByName(_deletedUserName.Value).Click();
            _driver.AcceptAlert();
            //Removing deleted User from userd list
            _projectDto.ManageUsers.RemoveAt(_projectDto.ManageUsers.Count - 1);
        }

        [When(@"User removes ""(.*)"" User")]
        public void WhenUserRemovesUser(string userName)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();
            //Perform search because newly created items not always on first page
            page.SearchTextBox.Clear();
            page.SearchTextBox.SendKeys(userName);
            page.SearchButton.Click();
            page.GetDeleteButtonElementByName(userName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"selected User was removed")]
        public void ThenSelectedUserWasRemoved()
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            Verify.IsFalse(page.CheckThatCreatedElementIsRemoved(_deletedUserName.Value),
                "Selected User is displayed in the table");
        }
    }
}