﻿using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Steps.Dashworks.CustomList.AfterScenario;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.CustomList
{
    [Binding]
    internal class EvergreenJnr_NewCustomList : RemoveCustomListAfterScenario
    {
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listsDetails;

        public EvergreenJnr_NewCustomList(RemoteWebDriver driver, ListsDetails listsDetails, UsedUsers usedUsers, UsersWithSharedLists usersWithSharedLists) : base(usedUsers, usersWithSharedLists)
        {
            _driver = driver;
            _listsDetails = listsDetails;
        }

        [Then(@"Save to New Custom List element is NOT displayed")]
        public void SaveToNewCustomListElementIsNOTDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsFalse(page.SaveCustomListButton.Displayed(),
                "Save New Custom List panel is displayed");
            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [Then(@"Save to New Custom List element is displayed")]
        public void ThenSaveToNewCustomListElementIsDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.SaveCustomListButton);
            Utils.Verify.IsTrue(page.SaveCustomListButton.Displayed(),
                "Save Custom list is displayed");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [When(@"User clicks Settings button for ""(.*)"" list")]
        public void WhenUserClicksSettingsButtonForList(string listName)
        {
            var page = _driver.NowAt<CustomListElement>();
            var icon = page.GetSettingsIconForList(listName);
            _driver.MouseHover(icon);
            _driver.WaitForElementToBeDisplayed(icon);
            icon.Click();
        }

        [When(@"User clicks Delete button for custom list")]
        public void WhenUserClicksDeleteButtonForCustomList()
        {
            var button = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(button.MenuItem);
            _driver.WaitForElementToBeDisplayed(button.DeleteButton);
            Thread.Sleep(1000);
            button.DeleteButton.Click();
            _driver.WaitForElementToBeNotDisplayed(button.MenuItem);
        }

        [When(@"User create custom list with ""(.*)"" name")]
        public void WhenUserCreateCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.CreateNewListButton);
            Utils.Verify.IsTrue(listElement.CreateNewListButton.Displayed(), "'Save' button is displayed");
            listElement.CreateNewListButton.Click();

            _driver.WaitForElementToBeDisplayed(listElement.SaveAsNewListButton);
            _driver.MouseHover(listElement.SaveAsNewListButton);
            _driver.WaitForDataLoading();
            listElement.SaveAsNewListButton.Click();

            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Utils.Verify.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.ListNameTextBox.SendKeys(listName);
            listElement.SaveButton.Click();

            //Small wait for message display
            Thread.Sleep(300);
            _driver.WaitForElementToBeNotDisplayed(listElement.SuccessCreateMessage);
            _listsDetails.AddList($"{listName}");
        }

        [When(@"User creates new custom list with ""(.*)"" name")]
        public void WhenUserCreatesNewCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            //_driver.WaitForElementToBeDisplayed(listElement.TopToolsSubmenu);
            //listElement.TopToolsSubmenu.Click();
            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Utils.Verify.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.ListNameTextBox.SendKeys(listName);
            listElement.SaveButton.Click();
        }

        [When(@"User clicks Save button on the list panel")]
        public void WhenUserClicksSaveButtonOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.CreateNewListButton);
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
            _driver.WaitForElementToBeDisplayed(listElement.CancelButton);
            listElement.CancelButton.Click();
        }

        [Then(@"User type ""(.*)"" into Custom list name field")]
        public void ThenUserTypeIntoCustomListNameField(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.SaveAsNewListButton);
            listElement.SaveAsNewListButton.Click();
            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            listElement.ListNameTextBox.SendKeys(listName);
        }

        [Then(@"Save button is inactive for Custom list")]
        public void ThenSaveButtonIsInactiveForCustomList()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.CreateNewListButton);
            if (!listElement.ListNameTextBox.Displayed())
                listElement.CreateNewListButton.Click();
            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            Utils.Verify.IsTrue(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"""(.*)"" list is displayed to user")]
        public void ThenListIsDisplayedToUser(string listName)
        {
            var page = _driver.NowAt<CustomListElement>();
            _driver.WaitForDataLoading(45);
            _driver.ExecuteAction(() => page.GetActiveList().Displayed());
            Verify.AreEqual(listName, page.GetActiveList().Text, "Incorrect list name is displayed");
        }

        [Then(@"""(.*)"" edited list is displayed to user")]
        public void ThenEditedListIsDisplayedToUser(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
            _driver.WaitForElementToBeDisplayed(page.ActiveCustomListEdited);
            Utils.Verify.AreEqual(listName, page.ActiveCustomListEdited.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" list name is displayed correctly on top tools panel")]
        public void ThenListNameIsDisplayedCorrectlyOnTopToolsPanel(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            IWebElement listNameOnTopPanel = null;
            try
            {
                listNameOnTopPanel = listElement.GetListNameOnTopToolsPanel(listName);
            }
            catch
            {
                Utils.Verify.That(listNameOnTopPanel, Is.Null, $"'{listName}' list is not displayed on top tools panel");
            }
        }

        [Then(@"Delete and Cancel buttons are available in the warning message")]
        public void ThenDeleteAndCancelButtonsAreAvailableInTheWarningMessage()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(listDetailsElement.CancelButtonInWarningMessage.Displayed, "Cancel button is not displayed");
            Utils.Verify.IsTrue(listDetailsElement.DeleteButtonInWarning.Displayed, "Delete button is not displayed");
        }

        [When(@"User clicks Delete button on the warning message in the lists panel")]
        [Then(@"User clicks Delete button on the warning message in the lists panel")]
        public void ThenUserClicksDeleteButtonOnTheWarningMessageInTheListsPanel()
        {
            var listDetailsElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.DeleteWarning);
            _driver.WaitForElementToBeDisplayed(listDetailsElement.DeleteButtonInWarningMessage);
            listDetailsElement.DeleteButtonInWarningMessage.Click();
            _driver.WaitForElementToBeNotDisplayed(listDetailsElement.DeleteButtonInWarningMessage);
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
            Utils.Verify.IsTrue(listElement.ListNameWarningMessage(listName),
                $"'{listName}' is not displayed in the list details panel");
            Utils.Verify.IsTrue(listElement.RemovingDependencyListMessage(warningText),
                $"'{warningText}' message is not displayed in the list details panel");
        }

        [When(@"User update current custom list")]
        public void WhenUserUpdateCurrentCustomList()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);
            listElement.SaveAsDropdown.Click();
            _driver.WaitForElementToBeDisplayed(listElement.UpdateCurrentListButton);
            _driver.WaitForElementToBeEnabled(listElement.UpdateCurrentListButton);
            _driver.ClickByJavascript(listElement.UpdateCurrentListButton);
        }

        [Then(@"User save changes in list with ""(.*)"" name")]
        public void ThenUserSaveChangesInListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);
            listElement.SaveAsDropdown.Click();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsNewListButton);
            listElement.SaveAsNewListButton.Click();
            _driver.WaitForElementToBeDisplayed(listElement.SaveButton);
            listElement.ListNameTextBox.SendKeys(listName);
            listElement.SaveButton.Click();
        }

        [Then(@"Edit List menu is displayed")]
        public void ThenEditListMenuIsDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);
            Utils.Verify.IsTrue(listElement.EditedList.Displayed(), "Edit List menu is not displayed");
        }

        [Then(@"Edit List menu is not displayed")]
        public void ThenEditListMenuIsNotDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsFalse(listElement.SaveAsDropdown.Displayed(), "Edit List menu is displayed");
        }

        [When(@"User removes custom list with ""(.*)"" name")]
        public void WhenUserRemovesCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            WhenUserClicksSettingsButtonForList(listName);
            _driver.WaitForElementToBeDisplayed(listElement.DeleteButton);
            listElement.DeleteButton.Click();
            _driver.WaitForElementToBeDisplayed(listElement.DeleteConfirmationMessage);
            listElement.ConfirmDeleteButton.Click();
        }

        [When(@"User click Delete button for custom list with ""(.*)"" name")]
        public void WhenUserClickDeleteButtonForCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            WhenUserClicksSettingsButtonForList(listName);
            _driver.WaitForElementToBeDisplayed(listElement.DeleteButton);
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
            Utils.Verify.IsTrue(button.CancelButtonColor.Displayed(),
                "Cancel button is not displayed or displayed with incorrectly color");
        }

        [Then(@"User sees Cancel button in banner")]
        public void ThenUserSeesCancelButtonInBanner()
        {
            var button = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(button.CancelDeletingButton.Displayed(), "Cancel button is not displayed in banner");
        }

        [When(@"User clicks '(.*)' Settings menu item for '(.*)' list")]
        public void WhenUserClicksSettingsMenuItemForList(string menuItem, string listName)
        {
            WhenUserClicksSettingsButtonForList(listName);
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(menuItem).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"list with ""(.*)"" name is not displayed")]
        [Then(@"list with ""(.*)"" name is removed")]
        public void ThenListWithNameIsRemoved(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsFalse(listElement.CheckThatListIsRemoved(listName), $"List with {listName} is not removed");
        }

        [When(@"User navigates to the ""(.*)"" list")]
        [When(@"User opens '(.*)' dashboard")]
        public void WhenUserNavigatesToTheList(string listName)
        {
            var page = _driver.NowAt<CustomListElement>();
            _driver.WaitForDataLoading();
            _driver.ExecuteAction(() => _driver.ClickByJavascript(page.GetListElementByName(listName)));
            _driver.WaitForDataLoading(60);
        }

        [Then(@"""(.*)"" message is displayed")]
        public void ThenMessageIsDisplayed(string message)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listElement.SuccessCreateMessage);
            Utils.Verify.AreEqual(message, listElement.SuccessCreateMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Save and Cancel buttons are displayed on the list panel")]
        public void ThenSaveAndCancelButtonsAreDisplayedOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(listElement.SaveButton.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsTrue(listElement.CancelButton.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Save and Cancel buttons are not displayed on the list panel")]
        public void ThenSaveAndCancelButtonsAreNotDisplayedOnTheListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsFalse(listElement.SaveButton.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsFalse(listElement.CancelButton.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"lists are sorted in alphabetical order")]
        public void ThenListsAreSortedInAlphabeticalOrder()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            var list = listElement.GetAllListNames();
            Utils.Verify.AreEqual(list.OrderBy(s => s), list, "Lists names are not in alphabetical order");
        }

        [Then(@"Columnmetadata request contains ArchivedItem parameter")]
        public void ThenColumnmetadataRequestContainsArchivedItem()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(_driver.GetAllRequests().Any(x => x.Contains("archiveditems=false")), "Request has no needed parameters");
        }

        [Then(@"Update list option is NOT available")]
        public void ThenUpdateListOptionIsNotAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);

            if (!listElement.UpdateCurrentListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Utils.Verify.IsFalse(listElement.UpdateCurrentListButton.Displayed(), "Update Current List button is displayed");
        }

        [Then(@"Delete List option is NOT available")]
        public void ThenDeleteListOptionIsNOTAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.MouseHover(By.XPath(listElement.SettingButtonSelector));
            _driver.WaitForElementToBeDisplayed(By.XPath(listElement.SettingButtonSelector));
            _driver.FindElement(By.XPath(listElement.SettingButtonSelector)).Click();
            Utils.Verify.IsFalse(listElement.DeleteButton.Displayed(), "Delete Current List button is displayed");
        }

        [Then(@"Delete List option is available")]
        public void ThenDeleteListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.MouseHover(By.XPath(listElement.SettingButtonSelector));
            _driver.WaitForElementToBeDisplayed(By.XPath(listElement.SettingButtonSelector));
            _driver.FindElement(By.XPath(listElement.SettingButtonSelector)).Click();
            Utils.Verify.IsTrue(listElement.DeleteButton.Displayed(), "Delete Current List button is NOT displayed");
        }

        [Then(@"Update list option is available")]
        public void ThenUpdateListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);
            if (!listElement.UpdateCurrentListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Utils.Verify.IsTrue(listElement.UpdateCurrentListButton.Displayed(),
                "Update Current List button is NOT displayed");
        }

        [Then(@"Save as a new list option is NOT available")]
        public void ThenSaveAsANewListOptionIsNotAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);
            if (!listElement.SaveAsNewListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Utils.Verify.IsFalse(listElement.SaveAsNewListButton.Displayed(), "Save As New List button is displayed");
        }

        [Then(@"Save as a new list option is available")]
        public void ThenSaveAsANewListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listElement.SaveAsDropdown);
            if (!listElement.SaveAsNewListButton.Displayed()) listElement.SaveAsDropdown.Click();

            Utils.Verify.IsTrue(listElement.SaveAsNewListButton.Displayed(), "Save As New List button is NOT displayed");
        }

        [Then(@"Star icon is displayed for ""(.*)"" list")]
        public void ThenStarIconIsDisplayedForList(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(listElement.GetFavoriteStatus(listName, true), "Star icon is NOT displayed");
        }

        [Then(@"Star icon is not displayed for ""(.*)"" list")]
        public void ThenStarIconIsNotDisplayedForList(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Verify.IsFalse(listElement.GetFavoriteStatus(listName, false), "Star icon is displayed but shouldn't");
        }

        [When(@"User enters ""(.*)"" text in Search field at List Panel")]
        public void WhenUserEntersTextInSearchFieldAtListPanel(string searchedText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.ListPanelSearchTextBox);
            listElement.ListPanelSearchTextBox.Clear();
            listElement.ListPanelSearchTextBox.SendKeys(searchedText);
        }

        [Then(@"reset button in Search field at List Panel is displayed")]
        public void ThenResetButtonInSearchFieldAtListPanelIsDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(
                listElement.SearchTextBoxResetButtonInListPanel);
            Utils.Verify.IsTrue(listElement.SearchTextBoxResetButtonInListPanel.Displayed(), "Reset button is not displayed");
            Logger.Write("Reset button is displayed");
        }

        [When(@"User closed list panel")]
        public void WhenUserClosedListPanel()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            listElement.CloseButton.Click();
        }

        [Then(@"Lists panel is hidden")]
        public void ThenListsPanelIsHidden()
        {
            var page = _driver.NowAt<CustomListElement>();

            Utils.Verify.That(page.ListsPanel.Displayed(), Is.False);
        }

        [Then(@"User sees correct tooltip for Show Lists panel")]
        public void WhenUserSeesCorrectTooltipForListsPanel()
        {
            var page = _driver.NowAt<CustomListElement>();
            _driver.MouseHover(page.ExpandSideNavPanelIcon);

            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.That(toolTipText, Is.EqualTo("Open menu"), $"Other tooltip is displayed to user: {toolTipText}");
        }

        [When(@"User lists were removed by API")]
        public void WhenUserListsRemovedByApi()
        {
            DeleteAllCustomListsAfterScenarioRun();
        }
    }
}