using System;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ListDetailsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _userDto;
        private readonly UsersWithSharedLists _usersWithSharedLists;

        public EvergreenJnr_ListDetailsPanel(RemoteWebDriver driver, UsersWithSharedLists usersWithSharedLists,
            UserDto userDto)
        {
            _driver = driver;
            _usersWithSharedLists = usersWithSharedLists;
            _userDto = userDto;
        }

        [When(@"User changes list name to ""(.*)""")]
        public void WhenUserChangesListNameTo(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ListNameField.Clear();
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
            Assert.AreEqual(header.UserNameDropdown.Text,
                listDetailsElement.OwnerDropdown.GetAttribute("value"),
                "Another User is selected as a owner");
        }

        [Then(@"""(.*)"" sharing option is selected")]
        public void ThenSharingOptionIsSelected(string sharingOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForDataLoading();
            Assert.AreEqual(sharingOption, listDetailsElement.GetSelectedValue(listDetailsElement.SharingDropdown),
                $"Selected option is not {sharingOption}");
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
            Assert.AreEqual(listName, listDetailsElement.ListNameField.GetAttribute("value"),
                $"{listName} is not displayed in Name Field");
        }

        [Then(@"List details panel is displayed to the user")]
        public void ThenListDetailsPanelIsDisplayedToTheUser()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.ListDetailsPanel);
            Assert.IsTrue(listDetailsElement.ListDetailsPanel.Displayed(), "List Details panel is not displayed");
            Logger.Write("List Details panel is visible");
        }

        [When(@"User clicks Delete List button on the List Details panel")]
        public void WhenUserClicksDeleteListButtonOnTheListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.RemoveListButton.Click();
            listDetailsElement.DeleteButtonInTheWarningMessage.Click();
        }

        [Then(@"no Warning message is displayed in the list details panel")]
        public void ThenNoWarningMessageIsDisplayedInTheListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.ListDetailsPanel);
            Assert.IsFalse(listDetailsElement.WarningMessage.Displayed(), "Warning message is displayed in the list details panel");
        }

        [Then(@"Dependants section is collapsed by default")]
        public void ThenDependantsSectionIsCollapsedByDefault()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.IsFalse(listDetailsElement.ExpandedDependantsSection.Displayed(), "Dependants section is expanded");
        }

        [When(@"User closes Permissions section in the list panel")]
        public void WhenUserClosesPermissionsSectionInTheListPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ClosePermissionsButton.Click();
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for Permissions section")]
        public void ThenTooltipIsDisplayedWithTextForPermissionsSection(string text)
        {
            _driver.MouseHover(By.XPath(".//i[@class='material-icons mat-item_add ng-star-inserted']"));
            var toolTipText = _driver.GetTooltipText();
            Assert.AreEqual(text, toolTipText);
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for Dependants section")]
        public void ThenTooltipIsDisplayedWithTextForDependantsSection(string text)
        {
            _driver.MouseHover(By.XPath(".//i[@class='material-icons mat-item_add ng-star-inserted']"));
            var toolTipText = _driver.GetTooltipText();
            Assert.AreEqual(text, toolTipText);
        }

        [When(@"User expand Dependants section")]
        public void WhenUserExpandDependantsSection()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.OpenDependantsButton.Click();
        }

        [Then(@"Dependants section is displayed to the user")]
        public void ThenDependantsSectionIsDisplayedToTheUser()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.ListDetailsPanel);
            Assert.IsTrue(listDetailsElement.DependantsSection.Displayed(), "Dependants section is not displayed");
            Logger.Write("Dependants section is visible");
        }

        [When(@"User clicks ""(.*)"" list in the Dependants section")]
        public void WhenUserClicksListInTheDependantsSection(string listName)
        {
            var page = _driver.NowAt<ListDetailsElement>();
            page.ListNameInDependantsSection(listName).Click();
        }


        [Then(@"""(.*)"" list is displayed in the Dependants section")]
        public void ThenListIsDisplayedInTheDependantsSection(string listName)
        {
            var page = _driver.NowAt<ListDetailsElement>();
            Assert.IsTrue(page.ListNameInDependantsSection(listName).Displayed(), $"{listName} is not displayed");
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
            //Save user to remove its lists after test execution
            _usersWithSharedLists.Value.Add(DatabaseWorker.GetUserNameByFullName(ownerOption));

            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.SelectCustomSelectbox(listDetailsElement.OwnerDropdown, ownerOption);
        }

        private string GetFullNameByUserName(string userName)
        {
            var fullName = DatabaseHelper.ExecuteReader(
                $" select up.FullName from [DesktopBI].[dbo].[UserProfiles] up join [aspnetdb].[dbo].[aspnet_Users] u on up.UserId = u.UserId where u.LoweredUserName = '{userName}'",
                0)[0];
            return fullName;
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

        [When(@"User select current user in Select User dropdown")]
        public void WhenUserSelectCurrentUserInSelectUserDropdown()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.SelectUserDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectUserDropdown,
                GetFullNameByUserName(_userDto.UserName));
        }

        [When(@"User select ""(.*)"" in Select Access dropdown")]
        public void WhenUserSelectInSelectAccessDropdown(string accessOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitWhileControlIsNotDisplayed<ListDetailsElement>(() => listDetailsElement.SelectAccessDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectAccessDropdown, accessOption);
        }

        [Then(@"Warning message with ""(.*)"" is displayed")]
        public void ThenWarningMessageWithIsDisplayed(string message)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => listElement.ErrorMessage);
            Assert.AreEqual(message, listElement.ErrorMessage.Text, $"{message} is not displayed");
        }

        [Then(@"""(.*)"" message is displayed in the lists panel")]
        public void ThenMessageIsDisplayedInTheListsPanel(string warningText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listElement.RemovingDependencyListMessage(warningText),
                $"{warningText} message is not displayed in the list details panel");
        }

        [Then(@"no Warning message is displayed in the lists panel")]
        public void ThenNoWarningMessageIsDisplayedInTheLissPanel()
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(listElement.WarningMessage.Displayed(),
                "Warning message is displayed in the list details panel");
        }

        [Then(@"""(.*)"" message is not displayed in the lists panel")]
        public void ThenMessageIsNotDisplayedInTheListsPanel(string warningText)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(listElement.DoesNotExistListMessage.Displayed(),
                $"{warningText} message is displayed in the list details panel");
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