using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_NewCustomList : SpecFlowContext
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

        [Then(@"Save to New Custom List element is displayed")]
        public void ThenSaveToNewCustomListElementIsDisplayed()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.SaveCustomListButton);
            Assert.IsTrue(page.SaveCustomListButton.Displayed(),
                "Save Custom list is displayed");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [When(@"User create custom list with ""(.*)"" name")]
        public void WhenUserCreateCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElement>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.CreateNewListButton);
            Assert.IsTrue(listElement.CreateNewListButton.Displayed(), "CreateNewListButton is displayed");
            listElement.CreateNewListButton.Click();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(listElement.SaveButton.Displayed(), "SaveButton is displayed");
            listElement.ListNameTextbox.SendKeys(listName);
            listElement.SaveButton.Click();
            //Small wait for message display
            Thread.Sleep(300);
            _driver.WaitWhileControlIsDisplayed<CustomListElement>(() => listElement.MessageAboutCreatedList);
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
            listElement.CreateNewListButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveButton);
            Assert.IsTrue(Convert.ToBoolean(listElement.SaveButton.GetAttribute("disabled")), "Save button is active");
        }

        [Then(@"""(.*)"" list is displayed to user")]
        public void ThenListIsDisplayedToUser(string listName)
        {
            //Workaround for DAS-11570. Remove after fix
            WhenUserNavigatesToTheList(listName);
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

            if (!listElement.UpdateCurrentListButton.Displayed())
            {
                listElement.SaveAsDropdown.Click();
            }
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
            if (!listElement.UpdateCurrentListButton.Displayed())
            {
                listElement.SaveAsDropdown.Click();
            }
            Assert.IsTrue(listElement.UpdateCurrentListButton.Displayed(),
                "Update Current List button is NOT displayed");
        }

        [Then(@"Save as a new list option is NOT available")]
        public void ThenSaveAsANewListOptionIsNotAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            if (!listElement.SaveAsNewListButton.Displayed())
            {
                listElement.SaveAsDropdown.Click();
            }
            Assert.IsFalse(listElement.SaveAsNewListButton.Displayed(), "Save As New List button is displayed");
        }

        [Then(@"Save as a new list option is available")]
        public void ThenSaveAsANewListOptionIsAvailable()
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElement>(() => listElement.SaveAsDropdown);
            if (!listElement.SaveAsNewListButton.Displayed())
            {
                listElement.SaveAsDropdown.Click();
            }
            Assert.IsTrue(listElement.SaveAsNewListButton.Displayed(), "Save As New List button is NOT displayed");
        }

        [AfterScenario("Delete_Newly_Created_List")]
        public void DeleteAllCustomListsAfterScenarioRun()
        {
            try
            {
                //New implementation
                var listsIds = DatabaseHelper.ExecuteReader("SELECT [ListId] FROM[DesktopBI].[dbo].[EvergreenList]", 0);

                DatabaseHelper.RemoveLists(listsIds);
            }
            catch { }

            //Old implementation
            //try
            //{
            //    var lefthendMenu = _driver.NowAt<LeftHandMenuElement>();
            //    lefthendMenu.Devices.Click();
            //    RemoveAllCustomLists();
            //    lefthendMenu.Applications.Click();
            //    RemoveAllCustomLists();
            //    lefthendMenu.Mailboxes.Click();
            //    RemoveAllCustomLists();
            //    lefthendMenu.Users.Click();
            //    RemoveAllCustomLists();
            //}
            //catch (Exception e)
            //{
            //    Logger.Write($"Some errors appears during List deleting: {e.Message}");
            //}
        }

        public void RemoveAllCustomLists()
        {
            var listElement = _driver.NowAt<CustomListElement>();

            foreach (var button in _driver.FindElements(By.XPath(listElement.SettingButtonSelector)))
            {
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
}