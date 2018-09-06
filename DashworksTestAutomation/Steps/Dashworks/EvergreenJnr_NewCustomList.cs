using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
    internal class EvergreenJnr_NewCustomList : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listsDetails;
        private readonly UsedUsers _usedUsers;
        private readonly UserDto _user;
        private readonly UsersWithSharedLists _usersWithSharedLists;

        public EvergreenJnr_NewCustomList(RemoteWebDriver driver, UserDto user, UsedUsers usedUsers,
            UsersWithSharedLists usersWithSharedLists, ListsDetails listsDetails)
        {
            _driver = driver;
            _user = user;
            _usedUsers = usedUsers;
            _usersWithSharedLists = usersWithSharedLists;
            _listsDetails = listsDetails;
        }

        [Then(@"Save to New Custom List element is NOT displayed")]
        public void SaveToNewCustomListElementIsNOTDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.IsFalse(page.SaveCustomListButton.Displayed(),
                "Save New Custom List panel is displayed");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [Then(@"Save to New Custom List element is displayed")]
        public void ThenSaveToNewCustomListElementIsDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.SaveCustomListButton);
            Assert.IsTrue(page.SaveCustomListButton.Displayed(),
                "Save Custom list is displayed");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [When(@"User clicks Settings button in the list panel")]
        public void WhenUserClicksSettingsButtonInTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.MouseHover(listElement.SettingsButton);
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SettingsButton);
            listElement.SettingsButton.Click();
        }

        [When(@"User clicks Settings button for ""(.*)"" list")]
        public void WhenUserClicksSettingsButtonForList(string listName)
        {
            var page = _driver.NowAt<CustomListElement>();
            page.OpenSettingsByListName(listName).Click();
        }

        [When(@"User clicks Delete button for custom list")]
        public void WhenUserClicksDeleteButtonForCustomList()
        {
            var button = _driver.NowAt<CustomListElement>();
            button.DeleteButton.Click();
        }

        [Then(@"Settings panel is displayed to the user")]
        public void ThenSettingsPanelIsDisplayedToTheUser()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listElement.SettingsPanel.Displayed(), "Settings panel is not displayed");
        }

        [Then(@"""(.*)"" list is displayed in the bottom section of the List Panel")]
        public void ThenListIsDisplayedInTheBottomSectionOfTheListPanel(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listElement.ListInBottomSection(listName).Displayed(), "List is not displayed in the bottom section");
        }

        [When(@"User create custom list with ""(.*)"" name")]
        public void WhenUserCreateCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            Assert.IsTrue(listElement.CreateNewListButton.Displayed(), "'Save' button is displayed");
            listElement.CreateNewListButton.Click();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.ListNameTextbox.SendKeys(listName);
            listElement.SaveButton.Click();

            //Small wait for message display
            Thread.Sleep(300);
            _driver.WaitWhileControlIsDisplayed<CustomListElement>(() => listElement.SuccessCreateMessage);
            _listsDetails.AddList($"{listName}");
        }

        [When(@"User creates new custom list with ""(.*)"" name")]
        public void WhenUserCreatesNewCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.ListNameTextbox.SendKeys(listName);
            listElement.SaveButton.Click();
        }

        [When(@"User clicks Save button on the list panel")]
        public void WhenUserClicksSaveButtonOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            listElement.CreateNewListButton.Click();
        }

        [When(@"User selects Save as new list option")]
        public void WhenUserSelectsSaveAsNewListOption()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            listElement.SaveAsNewListButton.Click();
        }

        [When(@"User clicks Cancel button on the list panel")]
        public void WhenUserClicksCancelButtonOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CancelButton);
            listElement.CancelButton.Click();
        }

        [Then(@"User type ""(.*)"" into Custom list name field")]
        public void ThenUserTypeIntoCustomListNameField(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            listElement.CreateNewListButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            listElement.ListNameTextbox.SendKeys(listName);
        }

        [Then(@"Save button is inactive for Custom list")]
        public void ThenSaveButtonIsInactiveForCustomList()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            if (!listElement.ListNameTextbox.Displayed())
                listElement.CreateNewListButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"""(.*)"" list is displayed to user")]
        public void ThenListIsDisplayedToUser(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.ActiveCustomList);
            Assert.AreEqual(listName, page.ActiveCustomListName());
        }

        [Then(@"""(.*)"" edited list is displayed to user")]
        public void ThenEditedListIsDisplayedToUser(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.ActiveCustomListEdited);
            Assert.AreEqual(listName, page.ActiveCustomListEdited.Text);
        }

        [Then(@"""(.*)"" list name is displayed correctly")]
        public void ThenListNameIsDisplayedCorrectly(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.AreEqual(listName, listElement.CheckAllListName(listName).Text, "Incorrect list name is displayed");
        }

        [When(@"User clicks ""(.*)"" link in Lists panel")]
        public void WhenUserClicksLinkInListsPanel(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            listElement.CheckAllListName(listName).Click();
        }   

        [When(@"User clicks Manage in the list panel")]
        public void WhenUserClicksManageInTheListPanel()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            listDetailsElement.ManageButton.Click();
        }

        [When(@"User clicks Delete in the list panel")]
        public void WhenUserClicksDeleteInTheListPanel()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            listDetailsElement.DeleteButton.Click();
        }

        [Then(@"Delete and Cancel buttons are available in the warning message")]
        public void ThenDeleteAndCancelButtonsAreAvailableInTheWarningMessage()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listDetailsElement.CancelButtonInWarningMessage.Displayed, "Cancel button is not displayed");
            Assert.IsTrue(listDetailsElement.DeleteButtonInWarningMessage.Displayed, "Delete button is not displayed");
        }

        [Then(@"User clicks Delete button on the warning message in the lists panel")]
        public void ThenUserClicksDeleteButtonOnTheWarningMessageInTheListsPanel()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            listDetailsElement.DeleteButtonInWarningMessage.Click();
        }

        [When(@"User clicks Cancel button in the warning message")]
        public void WhenUserClicksCancelButtonInTheWarningMessage()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            listDetailsElement.CancelButtonInWarningMessage.Click();
        }

        [Then(@"""(.*)"" list ""(.*)"" message is displayed in the list panel")]
        public void ThenListMessageIsDisplayedInTheListPanel(string listName, string warningText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listElement.ListNameWarningMessage(listName),
                $"{listName} is not displayed in the list details panel");
            Assert.IsTrue(listElement.RemovingDependencyListMessage(warningText),
                $"{warningText} message is not displayed in the list details panel");
        }

        [When(@"User update current custom list")]
        public void WhenUserUpdateCurrentCustomList()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            listElement.SaveAsDropdown.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.UpdateCurrentListButton);
            listElement.UpdateCurrentListButton.Click();
        }

        [Then(@"User save changes in list with ""(.*)"" name")]
        public void ThenUserSaveChangesInListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            listElement.SaveAsDropdown.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsNewListButton);
            listElement.SaveAsNewListButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            listElement.ListNameTextbox.SendKeys(listName);
            listElement.SaveButton.Click();
        }

        [Then(@"Edit List menu is displayed")]
        public void ThenEditListMenuIsDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            Assert.IsTrue(listElement.EditedList.Displayed(), "Edit List menu is not displayed");
        }

        [Then(@"Edit List menu is not displayed")]
        public void ThenEditListMenuIsNotDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsFalse(listElement.SaveAsDropdown.Displayed(), "Edit List menu is displayed");
        }

        [When(@"User removes custom list with ""(.*)"" name")]
        public void WhenUserRemovesCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            listElement.ClickSettingsButtonByListName(listName);
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteButton);
            listElement.DeleteButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteConfirmationMessage);
            listElement.ConfirmDeleteButton.Click();
        }

        [When(@"User click Delete button for custom list with ""(.*)"" name")]
        public void WhenUserClickDeleteButtonForCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            listElement.ClickSettingsButtonByListName(listName);
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteButton);
            listElement.DeleteButton.Click();
        }

        [Then(@"User confirm removed list")]
        public void ThenUserConfirmRemovedList()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            listElement.ConfirmDeleteButton.Click();
        }

        [Then(@"Cancel button is displayed with correctly color")]
        public void ThenCancelButtonIsDisplayedWithCorrectlyColor()
        {
            var button = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(button.CancelButtonColor.Displayed(), "Cancel button is not displayed or displayed with incorrectly color");
        }

        [Then(@"User sees Cancel button in banner")]
        public void ThenUserSeesCancelButtonInBanner()
        {
            var button = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(button.CancelDeletingButton.Displayed(), "Cancel button is not displayed in banner");
        }

        [When(@"User duplicates list with ""(.*)"" name")]
        public void WhenUserDuplicatesListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            listElement.ClickSettingsButtonByListName(listName);
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DuplicateButton);
            listElement.DuplicateButton.Click();
        }

        [Then(@"list name automatically changed to ""(.*)"" name")]
        public void ThenListNameAutomaticallyChangedToName(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual(listName, page.ActiveCustomListName());
        }

        [Then(@"list with ""(.*)"" name is removed")]
        public void ThenListWithNameIsRemoved(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsFalse(listElement.CheckThatListIsRemoved(listName), $"List with {listName} is not removed");
        }

        [When(@"User navigates to the ""(.*)"" list")]
        public void WhenUserNavigatesToTheList(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            page.GetListElementByName(listName).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" message is displayed")]
        public void ThenMessageIsDisplayed(string message)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SuccessCreateMessage);
            Assert.AreEqual(message, listElement.SuccessCreateMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Save and Cancel buttons are displayed on the list panel")]
        public void ThenSaveAndCancelButtonsAreDisplayedOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listElement.SaveButton.Displayed());
            Assert.IsTrue(listElement.CancelButton.Displayed());
        }

        [Then(@"Save and Cancel buttons are not displayed on the list panel")]
        public void ThenSaveAndCancelButtonsAreNotDisplayedOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsFalse(listElement.SaveButton.Displayed());
            Assert.IsFalse(listElement.CancelButton.Displayed());
        }

        [Then(@"lists are sorted in alphabetical order")]
        public void ThenListsAreSortedInAlphabeticalOrder()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            List<string> list = listElement.ListsNames.Select(x => x.Text).ToList();
            Assert.AreEqual(list.OrderBy(s => s), list, "Lists names are not in alphabetical order");
        }

        [Then(@"Update list option is NOT available")]
        public void ThenUpdateListOptionIsNotAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);

            if (!listElement.UpdateCurrentListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Assert.IsFalse(listElement.UpdateCurrentListButton.Displayed(), "Update Current List button is displayed");
        }

        [Then(@"Delete List option is NOT available")]
        public void ThenDeleteListOptionIsNOTAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.MouseHover(By.XPath(listElement.SettingButtonSelector));
            _driver.WaitWhileControlIsNotDisplayed(By.XPath(listElement.SettingButtonSelector));
            _driver.FindElement(By.XPath(listElement.SettingButtonSelector)).Click();
            Assert.IsFalse(listElement.DeleteButton.Displayed(), "Delete Current List button is displayed");
        }

        [Then(@"Delete List option is available")]
        public void ThenDeleteListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.MouseHover(By.XPath(listElement.SettingButtonSelector));
            _driver.WaitWhileControlIsNotDisplayed(By.XPath(listElement.SettingButtonSelector));
            _driver.FindElement(By.XPath(listElement.SettingButtonSelector)).Click();
            Assert.IsTrue(listElement.DeleteButton.Displayed(), "Delete Current List button is NOT displayed");
        }

        [Then(@"Update list option is available")]
        public void ThenUpdateListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            if (!listElement.UpdateCurrentListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Assert.IsTrue(listElement.UpdateCurrentListButton.Displayed(),
                "Update Current List button is NOT displayed");
        }

        [Then(@"Save as a new list option is NOT available")]
        public void ThenSaveAsANewListOptionIsNotAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            if (!listElement.SaveAsNewListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Assert.IsFalse(listElement.SaveAsNewListButton.Displayed(), "Save As New List button is displayed");
        }

        [Then(@"Save as a new list option is available")]
        public void ThenSaveAsANewListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            if (!listElement.SaveAsNewListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Assert.IsTrue(listElement.SaveAsNewListButton.Displayed(), "Save As New List button is NOT displayed");
        }

        [Then(@"Star icon is displayed for ""(.*)"" list")]
        public void ThenStarIconIsDisplayedForList(string listnName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsTrue(listElement.GetFavoriteStatus(listnName));
        }

        [Then(@"Star icon is not displayed for ""(.*)"" list")]
        public void ThenStarIconIsNotDisplayedForList(string listnName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Assert.IsFalse(listElement.GetFavoriteStatus(listnName));
        }

        [When(@"User enters ""(.*)"" text in Search field at List Panel")]
        public void WhenUserEntersTextInSearchFieldAtListPanel(string searchedText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.ListPanelSearchTextbox);
            listElement.ListPanelSearchTextbox.Clear();
            listElement.ListPanelSearchTextbox.SendKeys(searchedText);
        }

        [Then(@"reset button in Search field at List Panel is displayed")]
        public void ThenResetButtonInSearchFieldAtListPanelIsDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() =>
                listElement.SearchTextboxResetButtonInListPanel);
            Assert.IsTrue(listElement.SearchTextboxResetButtonInListPanel.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [AfterScenario("Delete_Newly_Created_List")]
        public void DeleteAllCustomListsAfterScenarioRun()
        {
            try
            {
                RemoveUserLists();
                RemoveSharedLists();
            }
            catch { }
        }

        private void RemoveUserLists()
        {
            try
            {
                //If non users were logged in then just return. None lists were created
                if (_usedUsers.Value == null || !_usedUsers.Value.Any())
                    return;

                foreach (UserDto userDto in _usedUsers.Value)
                    try
                    {
                        //All lists for all users
                        //var listsIds = DatabaseHelper.ExecuteReader("SELECT [ListId] FROM[DesktopBI].[dbo].[EvergreenList]", 0);
                        //All lists for specific user
                        var listsIds = DatabaseHelper.ExecuteReader(
                            $"select l.ListId from [aspnetdb].[dbo].[aspnet_Users] u join [DesktopBI].[dbo].[EvergreenList] l on u.UserId = l.UserId where u.LoweredUserName = '{userDto.UserName}'",
                            0);
                        DatabaseHelper.RemoveLists(listsIds);
                    }
                    catch
                    {
                    }
            }
            catch
            {
            }
        }

        private void RemoveSharedLists()
        {
            try
            {
                //If none lists were shared
                if (_usersWithSharedLists.Value == null || !_usersWithSharedLists.Value.Any())
                    return;

                foreach (string user in _usersWithSharedLists.Value)
                    try
                    {
                        //All lists for all users
                        //var listsIds = DatabaseHelper.ExecuteReader("SELECT [ListId] FROM[DesktopBI].[dbo].[EvergreenList]", 0);
                        //All lists for specific user
                        var listsIds = DatabaseHelper.ExecuteReader(
                            $"select l.ListId from[aspnetdb].[dbo].[aspnet_Users] u join[DesktopBI].[dbo].[EvergreenList] l on u.UserId = l.UserId where u.LoweredUserName = '{user}'",
                            0);
                        DatabaseHelper.RemoveLists(listsIds);
                    }
                    catch
                    {
                    }
            }
            catch
            {
            }
        }

        public void RemoveAllCustomLists()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            foreach (var button in _driver.FindElements(By.XPath(listElement.SettingButtonSelector)))
                if (_driver.IsElementExists(By.XPath(listElement.SettingButtonSelector)))
                {
                    Thread.Sleep(500);
                    var settingsButton = _driver.FindElement(By.XPath(listElement.SettingButtonSelector));
                    _driver.MouseHover(settingsButton);
                    settingsButton.Click();
                    _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteButton);
                    listElement.DeleteButton.Click();
                    _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() =>
                        listElement.DeleteConfirmationMessage);
                    listElement.ConfirmDeleteButton.Click();
                }
        }
    }
}