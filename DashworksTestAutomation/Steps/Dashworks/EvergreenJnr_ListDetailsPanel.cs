using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ListDetailsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _userDto;
        private readonly UsersWithSharedLists _usersWithSharedLists;

        public EvergreenJnr_ListDetailsPanel(RemoteWebDriver driver, UserDto userDto, UsersWithSharedLists usersWithSharedLists)
        {
            _driver = driver;
            _userDto = userDto;
            _usersWithSharedLists = usersWithSharedLists;
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
            Verify.AreEqual(listName, listDetailsElement.ListNameField.GetAttribute("value"),
                $"{listName} is not displayed in Name Field");
        }

        [Then(@"Details panel is displayed to the user")]
        public void ThenListDetailsPanelIsDisplayedToTheUser()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.ListDetailsPanel);
            Verify.IsTrue(listDetailsElement.ListDetailsPanel.Displayed(), "List Details panel is not displayed");
        }
        
        [Then(@"'(.*)' label is displayed in List Details")]
        public void ThenLabelIsDisplayedInListDetailsPanel(string text)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Verify.IsTrue(listDetailsElement.GetListDetailsLabelByText(text).Displayed(), $"List Details panel doesn't have {text} label");
        }

        [Then(@"'(.*)' label is not displayed in List Details")]
        public void ThenLabelIsNotDisplayedInListDetailsPanel(string text)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Verify.IsFalse(listDetailsElement.GetListDetailsLabelByText(text).Displayed(), $"List Details panel has {text} label");
            Logger.Write("List Details does not have label");
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
            Verify.IsTrue(list.GetDependentListByName(listName).Displayed(),
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
            Verify.IsFalse(listDetailsElement.AvailableOwnerField.Displayed(), "Owner field is active");
        }

        [Then(@"no Warning message is displayed in the list details panel")]
        public void ThenNoWarningMessageIsDisplayedInTheListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.ListDetailsPanel);
            Verify.IsFalse(listDetailsElement.WarningMessage.Displayed(),
                "Warning message is displayed in the list details panel");
        }

        [Then(@"Dependants section is collapsed by default")]
        public void ThenDependantsSectionIsCollapsedByDefault()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Verify.IsFalse(listDetailsElement.ExpandedDependantsSection.Displayed(), "Dependants section is expanded");
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
            Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"tooltip is displayed with ""(.*)"" text for Dependants section")]
        public void ThenTooltipIsDisplayedWithTextForDependantsSection(string text)
        {
            _driver.MouseHover(By.XPath(".//i[@class='material-icons mat-item_add ng-star-inserted']"));
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText, "PLEASE ADD EXCEPTION MESSAGE");
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
            Verify.IsTrue(listDetailsElement.DependantsSection.Displayed(), "Dependants section is not displayed");
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
            Verify.IsTrue(page.ListNameInDependantsSection(listName).Displayed(), $"{listName} is not displayed");
        }

        [When(@"User clicks '(.*)' option in Cog-menu for '(.*)' user on Details panel")]
        public void WhenUserClickSettingsMenuForSharedUser(string option, string username)
        {
            var page = _driver.NowAt<PermissionsElement>();
            page.GetMenuOfSharedUser(username).Click();

            var cogMenu = _driver.NowAt<CogMenuElements>();
            cogMenu.GetCogMenuOptionByName(option).Click();
        }
       
        [Then(@"There is no user in shared list of Details panel")]
        public void ThenNoUserFoundInSharedList()
        {
            var page = _driver.NowAt<PermissionsElement>();
            Verify.That(page.PermissionAddedUser.Count, Is.EqualTo(0), "Username found in shared list");
        }

        [Then(@"User '(.*)' was added to shared list with '(.*)' permission of Details panel")]
        public void ThenUserWasAddedToSharedList(string username, string permission)
        {
            var page = _driver.NowAt<PermissionsElement>();
            _driver.WaitForElementsToBeDisplayed(page.PermissionAddedUser);

            Verify.That(page.PermissionAddedUser.Select(x => x.Text).ToList(), Does.Contain(username), "Username is not one that expected");
            Verify.That(page.PermissionTypeOfAccess.Select(x => x.Text).ToList(), Does.Contain(permission), "Permission is not one that expected");
        }

        [When(@"User adds user to list of shared person")]
        public void WhenUserAddsNewPersonToSharingList(Table table)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.GetIcon("person_add").Click();

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

                _usersWithSharedLists.Value.Add(row["User"]);
            }
        }

        [When(@"User select current user in Select User dropdown")]
        public void WhenUserSelectCurrentUserInSelectUserDropdown()
        {
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.SelectUserDropdown);
            _driver.SelectCustomSelectbox(listDetailsElement.SelectUserDropdown,
                DatabaseHelper.GetFullNameByUserName(_userDto.Username));
        }

        //warning RED message
        [Then(@"Warning message with ""(.*)"" is displayed")]
        public void ThenWarningMessageWithIsDisplayed(string message)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listElement.ErrorMessage);
            Verify.AreEqual(message, listElement.ErrorMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Warning message with '(.*)' text is not displayed")]
        public void ThenWarningMessageWithTextIsNotDisplayed(string message)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Verify.IsFalse(listElement.ErrorMessage.Displayed(), $"'{message}' was displayed but should not");
        }

        [Then(@"""(.*)"" message is displayed in the lists panel")]
        public void ThenMessageIsDisplayedInTheListsPanel(string warningText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            Verify.IsTrue(listElement.RemovingDependencyListMessage(warningText),
                $"'{warningText}' message is not displayed in the list details panel");
        }

        [Then(@"""(.*)"" message is not displayed in the lists panel")]
        public void ThenMessageIsNotDisplayedInTheListsPanel(string warningText)
        {
            var listElement = _driver.NowAt<BaseDashboardPage>();
            Verify.IsFalse(listElement.DoesNotExistListMessage.Displayed(),
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
            Verify.IsTrue(page.FavoritesIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for My lists")]
        public void ThenAppropriateIconIsDisplayedForMyLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.MyListsIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for Shared with me")]
        public void ThenAppropriateIconIsDisplayedForSharedWithMe()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.SharedWithMeIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for Dynamic lists")]
        public void ThenAppropriateIconIsDisplayedForDynamicLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.DynamicListsIcon.Displayed(), "Appropriate icon is not displayed");
        }

        [Then(@"appropriate icon is displayed for Static lists")]
        public void ThenAppropriateIconIsDisplayedForStaticLists()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.StaticListsIcon.Displayed(), "Appropriate icon is not displayed");
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
            Verify.IsTrue(page.AllListsIcon.Displayed(), "Appropriate icon is not displayed");
        }
    }
}