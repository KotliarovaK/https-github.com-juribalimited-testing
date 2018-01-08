using System;
using System.Collections.Generic;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ListDetailsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UsersWithSharedLists _usersWithSharedLists;

        public EvergreenJnr_ListDetailsPanel(RemoteWebDriver driver, UsersWithSharedLists usersWithSharedLists)
        {
            _driver = driver;
            _usersWithSharedLists = usersWithSharedLists;
        }

        [When(@"User changes list name to ""(.*)""")]
        public void WhenUserChangesListNameTo(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ListNameField.ClearWithBackspaces();
            listDetailsElement.ListNameField.SendkeysWithDelay(listName);
        }

        [When(@"User is closed List Details panel")]
        public void WhenUserIsClosedListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.CloseListDetailsPanelButton.Click();
            _driver.WaitWhileControlIsDisplayed<ListDetailsElement>(() => listDetailsElement.ListDetailsPanel);
        }

        [When(@"User mark list as favorite")]
        public void WhenUserMarkListAsFavorite()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.FavoriteButton.Click();
        }

        [Then(@"List is NOT marked as favorite")]
        public void ThenListIsNOTMarkedAsFavorite()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.IsTrue(listDetailsElement.FavoriteButton.Displayed(), "List is marked as favorite");
        }

        [Then(@"current user is selected as a owner of a list")]
        public void ThenCurrentUserIsSelectedAsAOwnerOfAList()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            var header = _driver.NowAt<HeaderElement>();
            Assert.AreEqual(header.UserNameDropdown.Text, listDetailsElement.GetSelectedValue(listDetailsElement.OwnerDropdown),
                "Another User is selected as a owner");
        }

        [Then(@"""(.*)"" sharing option is selected")]
        public void ThenSharingOptionIsSelected(string sharingOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.AreEqual(sharingOption, listDetailsElement.GetSelectedValue(listDetailsElement.SharingDropdown), $"Selected option is not {sharingOption}");
        }

        [When(@"User mark list as unfavorite")]
        public void WhenUserMarkListAUnfavorite()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.UnfavoriteButton.Click();
        }

        [Then(@"List is marked as favorite")]
        public void ThenListIsMarkedAsFavorite()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.IsTrue(listDetailsElement.UnfavoriteButton.Displayed(), "List is marked as unfavorite");
        }

        [Then(@"""(.*)"" name is displayed in list details panel")]
        public void ThenNameIsDisplayedInListDetailsPanel(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.AreEqual(listName, listDetailsElement.ListNameField.GetAttribute("value"));
        }

        [Then(@"List details panel is displayed to the user")]
        public void ThenListDetailsPanelIsDisplayedToTheUser()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.IsTrue(listDetailsElement.ListDetailsPanel.Displayed(), "List Details panel was not displayed");
            Logger.Write("List Details panel is visible");
        }

        [When(@"User select ""(.*)"" sharing option")]
        public void WhenUserSelectSharingOption(string sharingOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.SelectCustomSelectbox(listDetailsElement.SharingDropdown, sharingOption);
        }

        [When(@"User select ""(.*)"" as a Owner of a list")]
        public void WhenUserSelectAsAOwnerOfAList(string ownerOption)
        {
            if (_usersWithSharedLists.Value == null)
                _usersWithSharedLists.Value = new List<string>();

            //Save user to remove its lists after test execution
            _usersWithSharedLists.Value.Add(GetUserNameByFullName(ownerOption));

            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.SelectCustomSelectbox(listDetailsElement.OwnerDropdown, ownerOption);
        }

        private string GetUserNameByFullName(string fullName)
        {
            var userName = DatabaseHelper.ExecuteReader(
                $"select u.LoweredUserName from[aspnetdb].[dbo].[aspnet_Users] u join[DesktopBI].[dbo].[UserProfiles] up on up.UserId = u.UserId where up.FullName = '{fullName}'",
                0)[0];
            return userName;
        }

        [When(@"User click Accept button in List Details panel")]
        public void WhenUserClickAcceptButtonInListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.AcceptButton);
            listDetailsElement.AcceptButton.Click();
        }

        [When(@"User click Add User button")]
        public void WhenUserClickAddUserButton()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.AddUserButton);
            listDetailsElement.AddUserButton.Click();
        }

        [When(@"User select '(.*)' in Select User dropdown")]
        public void WhenUserSelectInSelectUserDropdown(string userOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.SelectUserDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectUserDropdown, userOption);
        }

        [When(@"User select ""(.*)"" in Select Access dropdown")]
        public void WhenUserSelectInSelectAccessDropdown(string accessOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.SelectAccessDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectAccessDropdown, accessOption);
        }

        [Then(@"Delete list button is disabled in List Details panel")]
        public void ThenDeleteListButtonIsDisabledInListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.IsTrue(Convert.ToBoolean(listDetailsElement.RemoveListButton.GetAttribute("disabled")),
                "Delete List button is enabled");
        }
    }
}