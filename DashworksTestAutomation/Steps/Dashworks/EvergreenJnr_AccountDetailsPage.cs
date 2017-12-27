using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_AccountDetailsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AccountDetailsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Profile in Account Dropdown")]
        public void WhenUserClicksProfileInAccountDropdown()
        {
            var header = _driver.NowAt<HeaderElement>();
            header.UserNameDropdown.Click();
            _driver.WaitWhileControlIsNotDisplayed<HeaderElement>(() => header.ProfileButton);
            header.ProfileButton.Click();
        }

        [Then(@"Profile page is displayed to user")]
        public void ThenProfilePageIsDisplayedToUser()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
        }

        [When(@"User changes Full Name to ""(.*)""")]
        public void WhenUserChangesFullNameTo(string fullName)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.FullNameField.Click();
            page.FullNameField.Clear();
            page.FullNameField.SendKeys(fullName);
        }

        [When(@"User clicks Update button on Profile page")]
        public void WhenUserClicksUpdateButtonOnProfilePage()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.UpdateButton.Click();
        }

        [Then(@"Error message is not displayed on Profile page")]
        public void ThenErrorMessageIsNotDisplayedOnProfilePage()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.IsFalse(page.ErrorMessage.Displayed());
        }

        [Then(@"""(.*)"" is displayed in Full Name field")]
        public void ThenIsDisplayedInFullNameField(string fullName)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(fullName, page.FullNameField.GetAttribute("value"));
        }

        [When(@"User changes Email to ""(.*)""")]
        public void WhenUserChangesEmailTo(string email)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.EmailField.Click();
            page.EmailField.Clear();
            page.EmailField.SendKeys(email);
        }

        [Then(@"""(.*)"" is displayed in Email field")]
        public void ThenIsDisplayedInEmailField(string email)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(email, page.EmailField.GetAttribute("value"));
        }

        [AfterScenario("Delete_Newly_Created_List")]
        public void RemoveProfileChangesAfterscenario()
        {
            try
            {
                var page = _driver.NowAt<AccountDetailsPage>();
                page.FullNameField.Clear();
                page.FullNameField.SendKeys("Administrator");
                page.EmailField.Clear();
                page.UpdateButton.Click();
            }
            catch
            {
            }
        }
    }
}