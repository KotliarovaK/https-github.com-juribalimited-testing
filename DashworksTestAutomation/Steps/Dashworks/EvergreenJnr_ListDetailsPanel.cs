using System;
using DashworksTestAutomation.Extensions;
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

        public EvergreenJnr_ListDetailsPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User changes list name to ""(.*)""")]
        public void WhenUserChangesListNameTo(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.ListNameField.Clear();
            listDetailsElement.ListNameField.SendKeys(listName);
        }
        
        [Then(@"""(.*)"" name is displayed in list details panel")]
        public void ThenNameIsDisplayedInListDetailsPanel(string listName)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.AreEqual(listName, listDetailsElement.ListNameField.Text);
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
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.SelectCustomSelectbox(listDetailsElement.OwnerDropdown, ownerOption);
        }

        [When(@"User click Accept button in List Details panel")]
        public void WhenUserClickAcceptButtonInListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.AcceptButton.Click();
        }

        [When(@"User click Add User button")]
        public void WhenUserClickAddUserButton()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            listDetailsElement.AddUserButton.Click();
        }

        [When(@"User select '(.*)' in Select User dropdown")]
        public void WhenUserSelectInSelectUserDropdown(string userOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.SelectCustomSelectbox(listDetailsElement.SelectUserDropdown, userOption);
        }

        [When(@"User select ""(.*)"" in Select Access dropdown")]
        public void WhenUserSelectInSelectAccessDropdown(string accessOption)
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            _driver.SelectCustomSelectbox(listDetailsElement.SelectAccessDropdown, accessOption);

        }

        [Then(@"Delete list button is disabled in List Details panel")]
        public void ThenDeleteListButtonIsDisabledInListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<ListDetailsElement>();
            Assert.IsTrue(Convert.ToBoolean(listDetailsElement.RemoveListButton.GetAttribute("disabled")), "Delete List button is enabled");
        }

    }
}