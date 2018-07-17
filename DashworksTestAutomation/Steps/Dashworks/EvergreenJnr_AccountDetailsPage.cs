using System.IO;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages;
using DashworksTestAutomation.Providers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AccountDetailsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _userDto;

        public EvergreenJnr_AccountDetailsPage(RemoteWebDriver driver, UserDto userDto)
        {
            _driver = driver;
            _userDto = userDto;
        }

        [When(@"User click User Notifications button")]
        public void WhenUserClickUserNotificationsButton()
        {
            var header = _driver.NowAt<HeaderElement>();
            header.UserNotificationsButton.Click();
        }

        [When(@"User clicks Account Profile dropdown")]
        public void WhenUserClicksAccountProfileDropdown()
        {
            var header = _driver.NowAt<HeaderElement>();
            header.UserNameDropdown.Click();
        }

        [Then(@"Account Profile dropdown is displayed to user")]
        public void ThenAccountProfileDropdownIsDisplayedToUser()
        {
            var header = _driver.NowAt<HeaderElement>();
            Assert.AreEqual(2, header.MenuItems.Count, "Account Profile dropdown is not displayed");
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
            _userDto.FullName = page.FullNameField.GetAttribute("value");
            _userDto.Email = page.EmailField.GetAttribute("value");
        }

        [When(@"User navigates to the ""(.*)"" page on Account details")]
        public void WhenUserNavigatesToThePageOnAccountDetails(string pageToNavigate)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.NavigateToPage(pageToNavigate);
        }

        [When(@"User changes language to ""(.*)""")]
        public void WhenUserChangesLanguageTo(string language)
        {
            var page = _driver.NowAt<PreferencesPage>();
            _driver.SelectCustomSelectbox(page.LanguageDropdown, language);
        }

        [When(@"User clicks Update button on Preferences page")]
        public void WhenUserClicksUpdateButtonOnPreferencesPage()
        {
            var page = _driver.NowAt<PreferencesPage>();
            page.UpdateButton.Click();
        }

        [When(@"User changes Full Name to ""(.*)""")]
        public void WhenUserChangesFullNameTo(string fullName)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
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
            Assert.IsFalse(page.ErrorMessage.Displayed(),
                $"Error message is displayed on Account Page");
        }

        [Then(@"""(.*)"" is displayed in Full Name field")]
        public void ThenIsDisplayedInFullNameField(string fullName)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(fullName, page.FullNameField.GetAttribute("value"),
                $"{fullName} is not displayed in Full Name field");
        }

        [When(@"User changes Email to ""(.*)""")]
        public void WhenUserChangesEmailTo(string email)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.EmailField.Clear();
            page.EmailField.SendKeys(email);
        }

        [Then(@"""(.*)"" is displayed in Email field")]
        public void ThenIsDisplayedInEmailField(string email)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(email, page.EmailField.GetAttribute("value"), $"{email} is not displayed in Email field");
        }

        [When(@"User clears Full name field")]
        public void WhenUserClearsFullNameField()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.FullNameField.ClearWithHomeButton(_driver);
        }

        [Then(@"""(.*)"" error message is displayed")]
        public void ThenErrorMessageIsDisplayed(string errorMessage)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<AccountDetailsPage>(() => page.ErrorMessage);
            Assert.AreEqual(errorMessage, page.ErrorMessage.Text, "Incorrect Error message text");
        }

        [When(@"User clears Email field")]
        public void WhenUserClearsEmailField()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.EmailField.ClearWithHomeButton(_driver);
        }

        [When(@"User Upload incorrect avatar to Account Details")]
        public void WhenUserUploadIncorrectAvatarToAccountDetails()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            string file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                          ResourceFilesNamesProvider.IncorrectFile;
            page.UploadButton.SendKeys(file);
        }

        [When(@"User Upload correct avatar to Account Details")]
        public void WhenUserUploadIncorrectAvatarToProfileDetails()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            string file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                          ResourceFilesNamesProvider.CorrectFile;
            page.UploadButton.SendKeys(file);
        }

        [Then(@"Success message with ""(.*)"" text is displayed on Account Details page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnAccountDetailsPage(string text)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<AccountDetailsPage>(() => page.SuccessMessage);
            Assert.AreEqual(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"User picture is changed to uploaded photo")]
        public void ThenUserPictureIsChangedToUploadedPhoto()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            StringAssert.DoesNotContain("img/UnknownUser.jpg", page.UserPicture.GetAttribute("style"),
                "Picture is not changed");
        }

        [When(@"User clicks Remove on Account details page")]
        public void WhenUserClicksRemoveOnAccountDetailsPage()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.RemoveButton.Click();
        }

        [Then(@"User picture changed to default")]
        public void ThenUserPictureChangedToDefault()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            StringAssert.Contains("img/UnknownUser.jpg", page.UserPicture.GetAttribute("style"),
                "Picture is not default");
        }

        [Then(@"Notification message is displayed for a few seconds on Preferences page")]
        public void ThenNotificationMessageIsDisplayedForAFewSecondsOnPreferencesPage()
        {
            var page = _driver.NowAt<PreferencesPage>();
            Assert.IsTrue(page.SuccessMessage.Displayed(), "Success message is not displayed");
            Thread.Sleep(5000);
            Assert.IsFalse(page.SuccessMessage.Displayed(), "Success message is displayed for more than 5 seconds");
        }

        [Then(@"following Roles are available for User:")]
        public void ThenFollowingRolesAreAvailableForUser(Table table)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = page.AvailableRoles.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Available Roles are different");
        }

        [AfterScenario("Remove_Profile_Changes")]
        public void RemoveProfileChangesAfterscenario()
        {
            try
            {
                var page = _driver.NowAt<AccountDetailsPage>();
                page.FullNameField.Clear();
                page.FullNameField.SendKeys(_userDto.FullName);
                page.EmailField.Clear();
                page.EmailField.SendKeys(string.IsNullOrEmpty(_userDto.Email)
                    ? "automation@juriba.com"
                    : _userDto.Email);
                page.RemoveButton.Click();
                page.UpdateButton.Click();
            }
            catch {}
        }
    }
}