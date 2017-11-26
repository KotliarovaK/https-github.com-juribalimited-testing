using System;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_NewCustomList : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_NewCustomList(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Save to New Custom List element is NOT displayed")]
        public void SaveToNewCustomListElementIsNOTDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsDisplayed<BaseDashboardPage>(() => page.SaveCustomListButton);
            Assert.IsFalse(page.SaveCustomListButton.Displayed(),
                "Save Custom list is displayed");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [When(@"User create custom list with ""(.*)"" name")]
        public void WhenUserCreateCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            listElement.CreateNewListButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            listElement.ListNameTextbox.SendKeys(listName);
            listElement.SaveButton.Click();
        }

        [Then(@"""(.*)"" list is displayed to user")]
        public void ThenListIsDisplayedToUser(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            Assert.AreEqual(listName, page.ActiveCustomListName());
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
            Assert.IsTrue(listElement.SaveAsDropdown.Displayed(), "Edit List menu is not displayed");
        }

        [Then(@"Edit List menu is not displayed")]
        public void ThenEditListMenuIsNotDisplayed()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            Assert.IsFalse(listElement.SaveAsDropdown.Displayed(), "Edit List menu is displayed");
        }

        [When(@"User is removed custom list with ""(.*)"" name")]
        public void WhenUserIsRemovedCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            listElement.ClickSettingsButtonByListName(listName);
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteButton);
            listElement.DeleteButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteConfirmationMessage);
            listElement.ConfirmDeleteButton.Click();
        }

        [AfterScenario("Delete_Newly_Created_List")]
        public void DeleteAllCustomListsAfterScenarioRun()
        {
            try
            {
                var lefthendMenu = _driver.NowAt<LeftHandMenuElement>();
                lefthendMenu.Devices.Click();
                RemoveAllCustomLists();
                lefthendMenu.Applications.Click();
                RemoveAllCustomLists();
                lefthendMenu.Mailboxes.Click();
                RemoveAllCustomLists();
                lefthendMenu.Users.Click();
                RemoveAllCustomLists();
            }
            catch (Exception e)
            {
                Logger.Write($"Some errors appears during List deleting: {e.Message}");
            }
        }

        [When(@"User navigates to the ""(.*)"" list")]
        public void WhenUserNavigatesToTheList(string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetListElementByName(listName).Click();
        }

        [Then(@"""(.*)"" message is displayed")]
        public void ThenMessageIsDisplayed(string message)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SuccessCreateMessage);
            Assert.AreEqual(message, listElement.SuccessCreateMessage.Text);
        }

        public void RemoveAllCustomLists()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsDisplayed<CustomListElement>(() => listElement.UpdateCurrentListButton);
            foreach (var settingsButton in listElement.SettingsButtons)
            {
                _driver.MouseHover(settingsButton);
                settingsButton.Click();
                _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteButton);
                listElement.DeleteButton.Click();
                _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.DeleteConfirmationMessage);
                listElement.ConfirmDeleteButton.Click();
            }
        }
    }
}