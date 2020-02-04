﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
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

        public EvergreenJnr_ListDetailsPanel(RemoteWebDriver driver, UserDto userDto)
        {
            _driver = driver;
            _userDto = userDto;
        }

        [When(@"User changes list name to ""(.*)""")]
        public void WhenUserChangesListNameTo(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ListNameField.ClearWithHomeButton(_driver);
            listDetailsElement.ListNameField.SendkeysWithDelay(listName);
            Thread.Sleep(3000);//Wait for autosave action, no indicators available
            _driver.WaitForDataLoading();
        }

        [When(@"User adds ""(.*)"" to list name")]
        public void WhenUserAddsTextToListName(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ListNameField.Click();
            listDetailsElement.ListNameField.SendkeysWithDelay(listName);
            Thread.Sleep(3000);//Wait for autosave action, no indicators available
            _driver.WaitForDataLoading();
        }

        [When(@"User is closed List Details panel")]
        public void WhenUserIsClosedListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.CloseListDetailsPanelButton.Click();
            _driver.WaitForElementToBeNotDisplayed(listDetailsElement.ListDetailsPanel);
        }

        [Then(@"""(.*)"" name is displayed in list details panel")]
        public void ThenNameIsDisplayedInListDetailsPanel(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForDataLoadingInActionsPanel();
            Utils.Verify.AreEqual(listName, listDetailsElement.ListNameField.GetAttribute("value"),
                $"{listName} is not displayed in Name Field");
        }

        [Then(@"Details panel is displayed to the user")]
        public void ThenListDetailsPanelIsDisplayedToTheUser()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.ListDetailsPanel);
            Utils.Verify.IsTrue(listDetailsElement.ListDetailsPanel.Displayed(), "List Details panel is not displayed");
        }
        
        [Then(@"'(.*)' label is displayed in List Details")]
        public void ThenLabelIsDisplayedInListDetailsPanel(string text)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsTrue(listDetailsElement.GetListDetailsLabelByText(text).Displayed(), $"List Details panel doesn't have {text} label");
        }

        [Then(@"'(.*)' label is not displayed in List Details")]
        public void ThenLabelIsNotDisplayedInListDetailsPanel(string text)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsFalse(listDetailsElement.GetListDetailsLabelByText(text).Displayed(), $"List Details panel has {text} label");
            Logger.Write("List Details does not have label");
        }
        
        [When(@"User clicks '(.*)' checkbox in List Details")]
        public void ThenUserClicksCheckboxInListDetailsPanel(string text)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.GetListDetailsLabelByText(text).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"User open the Dependents component")]
        public void ThenUserOpenTheDependentsComponent()
        {
            var list = _driver.NowAt<ListDetailsElement>();
            list.DependantsButton.Click();
        }

        [Then(@"dependent ""(.*)"" list is displayed")]
        public void ThenDependentListIsDisplayed(string listName)
        {
            var list = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsTrue(list.GetDependentListByName(listName).Displayed(),
                $"Dependent '{listName}' list is not displayed");
        }

        [When(@"User navigates to the dependent ""(.*)"" list")]
        public void WhenUserNavigatesToTheDependentList(string listName)
        {
            var list = _driver.NowAt<ListDetailsElement>();
            list.GetDependentListByName(listName).Click();
        }

        [Then(@"Owner field is disabled as read-only")]
        public void ThenOwnerFieldIsDisabledAsRead_Only()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsFalse(listDetailsElement.AvailableOwnerField.Displayed(), "Owner field is active");
        }

        [Then(@"no Warning message is displayed in the list details panel")]
        public void ThenNoWarningMessageIsDisplayedInTheListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.ListDetailsPanel);
            Utils.Verify.IsFalse(listDetailsElement.WarningMessage.Displayed(),
                "Warning message is displayed in the list details panel");
        }

        [Then(@"Dependants section is collapsed by default")]
        public void ThenDependantsSectionIsCollapsedByDefault()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsFalse(listDetailsElement.ExpandedDependantsSection.Displayed(), "Dependants section is expanded");
        }

        [When(@"User closes Permissions section in the list panel")]
        public void WhenUserClosesPermissionsSectionInTheListPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ClosePermissionsButton.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for Permissions section")]
        public void ThenTooltipIsDisplayedWithTextForPermissionsSection(string text)
        {
            _driver.MouseHover(By.XPath(".//i[@class='material-icons mat-item_add ng-star-inserted']"));
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for Dependants section")]
        public void ThenTooltipIsDisplayedWithTextForDependantsSection(string text)
        {
            _driver.MouseHover(By.XPath(".//i[@class='material-icons mat-item_add ng-star-inserted']"));
            var toolTipText = _driver.GetTooltipText();
            Utils.Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
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
            _driver.WaitForElementToBeDisplayed(listDetailsElement.ListDetailsPanel);
            Utils.Verify.IsTrue(listDetailsElement.DependantsSection.Displayed(), "Dependants section is not displayed");
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
            Utils.Verify.IsTrue(page.ListNameInDependantsSection(listName).Displayed(), $"{listName} is not displayed");
        }


        [When(@"User selects the ""(.*)"" user for sharing")]
        public void WhenUserSelectsTheUserForSharing(string userName)
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();
            baseActionItem.AutocompleteSelect("User", userName);
        }

        [Then(@"User list for sharing is not displayed")]
        public void ThenUserListForSharingIsNotDisplayed()
        {
            var page = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsFalse(page.SharingUserList.Displayed(), "User list for sharing is displayed");
        }

        [Then(@"""(.*)"" Sharing user is displayed correctly")]
        public void ThenSharingUserIsDisplayedCorrectly(string userName)
        {
            var page = _driver.NowAt<ListDetailsElement>();
            Utils.Verify.IsTrue(page.GetSharingUserOnDetailsPanelByName(userName).Displayed(),
                "Selected Sharing user is not displayed on Details panel");
        }

        [When(@"User clicks '(.*)' option in Cog-menu for '(.*)' user on Details panel")]
        public void WhenUserClickSettingsMenuForSharedUser(string option, string username)
        {
            var page = _driver.NowAt<ListDetailsElement>();
            page.GetMenuOfSharedUser(username).Click();

            var cogMenu = _driver.NowAt<CogMenuElements>();
            cogMenu.GetCogMenuOptionByName(option).Click();
        }
       
        [Then(@"There is no user in shared list of Details panel")]
        public void ThenNoUserFoundInSharedList()
        {
            var page = _driver.NowAt<ListDetailsElement>();
            Verify.That(page.PermissionAddedUser.Count, Is.EqualTo(0), "Username found in shared list");
        }

        [Then(@"User '(.*)' was added to shared list with '(.*)' permission of Details panel")]
        public void ThenUserWasAddedToSharedList(string username, string permission)
        {
            var page = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementsToBeDisplayed(page.PermissionAddedUser);

            Verify.That(page.PermissionAddedUser.Select(x => x.Text).ToList(), Does.Contain(username), "Username is not one that expected");
            Verify.That(page.PermissionTypeOfAccess.Select(x => x.Text).ToList(), Does.Contain(permission), "Permission is not one that expected");
        }

        [When(@"User adds user to list of shared person")]
        public void WhenUserAddsNewPersonToSharingList(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ClickButton("ADD USER");

            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["User"]))
                {
                    action.AutocompleteSelect("User", row["User"], true);
                }

                if (!string.IsNullOrEmpty(row["Permission"]))
                {
                    action.SelectDropdown(row["Permission"], "Select access");
                }
                action.ClickButton("ADD USER");

                //TODO Section reloads with delay
                Thread.Sleep(2000);
            }
        }

        [Then(@"Owners is displayed in alphabetical order")]
        public void ThenOwnersIsDisplayedInAlphabeticalOrder()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            var list = listDetailsElement.OwnersList.Select(x => x.Text).ToList();
            Verify.AreEqual(list.OrderBy(s => s), list, "Owners are not in alphabetical order");
        }

        [When(@"User click Add User button")]
        public void WhenUserClickAddUserButton()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.AddUserButton);
            listDetailsElement.AddUserButton.Click();
        }

        [When(@"User select '(.*)' in Select User dropdown")]
        public void WhenUserSelectInSelectUserDropdown(string userOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.SelectUserDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectUserDropdown, userOption);
        }

        [When(@"User select current user in Select User dropdown")]
        public void WhenUserSelectCurrentUserInSelectUserDropdown()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.SelectUserDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectUserDropdown,
                DatabaseHelper.GetFullNameByUserName(_userDto.Username));
        }

        [When(@"User select ""(.*)"" in Select Access dropdown")]
        public void WhenUserSelectInSelectAccessDropdown(string accessOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.SelectAccessDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectAccessDropdown, accessOption);
            _driver.WaitForDataLoading();
        }

        [When(@"User select ""(.*)"" in Permission dropdown")]
        public void WhenUserSelectInPermissionDropdown(string option)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.SelectPermissionDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectPermissionDropdown, option);
            _driver.WaitForDataLoading();
        }

        //warning RED message
        [Then(@"Warning message with ""(.*)"" is displayed")]
        public void ThenWarningMessageWithIsDisplayed(string message)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listElement.ErrorMessage);
            Utils.Verify.AreEqual(message, listElement.ErrorMessage.Text, $"{message} is not displayed");
        }

        [Then(@"""(.*)"" message is displayed in the lists panel")]
        public void ThenMessageIsDisplayedInTheListsPanel(string warningText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Utils.Verify.IsTrue(listElement.RemovingDependencyListMessage(warningText),
                $"'{warningText}' message is not displayed in the list details panel");
        }

        [Then(@"""(.*)"" message is not displayed in the lists panel")]
        public void ThenMessageIsNotDisplayedInTheListsPanel(string warningText)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsFalse(listElement.DoesNotExistListMessage.Displayed(),
                $"{warningText} message is displayed in the list details panel");
        }

        [When(@"User clicks Delete list button")]
        public void WhenUserClicksDeleteListButton()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.RemoveListButton.Click();
        }

        [Then(@"Delete list button is disabled in List Details panel")]
        public void ThenDeleteListButtonIsDisabledInListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Verify.IsTrue(Convert.ToBoolean(listDetailsElement.RemoveListButton.GetAttribute("disabled")),
                "Delete List button is enabled");
        }

        [When(@"User clicks All lists dropdown on Lists panel")]
        public void WhenUserClicksAllListsDropdownOnListsPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.DropdownLists.Click();
        }

        [Then(@"appropriate icon is displayed for Favourites")]
        public void ThenAppropriateIconIsDisplayedForFavourites()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(page.FavoritesIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for My lists")]
        public void ThenAppropriateIconIsDisplayedForMyLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(page.MyListsIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for Shared with me")]
        public void ThenAppropriateIconIsDisplayedForSharedWithMe()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(page.SharedWithMeIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for Dynamic lists")]
        public void ThenAppropriateIconIsDisplayedForDynamicLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(page.DynamicListsIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for Static lists")]
        public void ThenAppropriateIconIsDisplayedForStaticLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(page.StaticListsIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [When(@"User selects ""(.*)"" option on the All lists dropdown")]
        public void WhenUserSelectsOptionOnTheAllListsDropdown(string optionName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdownValueByName(optionName).Click();
        }

        [Then(@"appropriate icon is displayed for All lists")]
        public void ThenAppropriateIconIsDisplayedForAllLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(page.AllListsIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"Owner Drop-down list is disabled on List details panel")]
        public void ThenOwnerDrop_DownListIsDisabledOnListDetailsPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.IsTrue(Convert.ToBoolean(page.OwnerDropDown.GetAttribute("disabled")), "Owner Drop-down list is available!");
        }
    }
}