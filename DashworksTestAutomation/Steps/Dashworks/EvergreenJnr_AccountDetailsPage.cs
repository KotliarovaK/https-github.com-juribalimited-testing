using System.IO;
using System.Linq;
using System.Threading;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
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
            Verify.AreEqual(2, header.MenuItems.Count, "Account Profile dropdown is not displayed");
        }

        [When(@"User clicks Profile in Account Dropdown")]
        public void WhenUserClicksProfileInAccountDropdown()
        {
            var header = _driver.NowAt<HeaderElement>();
            header.UserNameDropdown.Click();
            _driver.WaitForElementToBeDisplayed(header.ProfileButton);
            header.ProfileButton.Click();
        }

        [Then(@"Profile page is displayed to user")]
        public void ThenProfilePageIsDisplayedToUser()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            _userDto.FullName = page.FullNameField.GetAttribute("value");
            _userDto.Email = page.EmailField.GetAttribute("value");
        }

        [Then(@"Change Password page is displayed to user")]
        public void ThenChangePasswordPageIsDisplayedToUser()
        {
            var page = _driver.NowAt<ChangePasswordPage>();
            Verify.IsTrue(page.CurrentPasswordField.Displayed(), "Change Password page is not displayed");
        }

        [Then(@"page elements are translated into French")]
        public void ThenPageElementsAreTranslatedIntoFrench()
        {
            var page = _driver.NowAt<PreferencesPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.LeftHandMenuOnFrench.Displayed(), "Left Hand Menu is not translated into French");
            Verify.IsTrue(page.UpdateButtonOnFrench.Displayed(), "Update Button is not translated into French");
            Verify.IsTrue(page.CaptionOnFrench.Displayed(), "Caption is not translated into French");
        }

        [Then(@"Display Mode is changed to High Contrast")]
        public void ThenDisplayModeIsChangedToHighContrast()
        {
            var page = _driver.NowAt<PreferencesPage>();
            _driver.WaitForDataLoading();
            Verify.AreEqual("rgba(21, 40, 69, 1)", page.GetUpdateButtonColor(), "'Update Button' is not changed to High Contrast");
            Verify.AreEqual("rgba(21, 40, 69, 1)", page.GetLinkMenuColor(), "Link Menu is not changed to High Contrast");
        }

        [When(@"User clears Full name field")]
        public void WhenUserClearsFullNameField()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.FullNameField.ClearWithHomeButton(_driver);
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
            var file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                       ResourceFilesNamesProvider.IncorrectFile;
            page.UploadButton.SendKeys(file);
        }

        [When(@"User Upload correct avatar to Account Details")]
        public void WhenUserUploadIncorrectAvatarToProfileDetails()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            var file = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) +
                       ResourceFilesNamesProvider.CorrectFile;
            page.UploadButton.SendKeys(file);
            _driver.WaitForDataLoading();
        }

        [Then(@"User picture is changed to uploaded photo")]
        public void ThenUserPictureIsChangedToUploadedPhoto()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Verify.DoesNotContain("img/UnknownUser.jpg", page.UserPicture.GetAttribute("style"),
                "Picture is not changed");
        }

        [Then(@"User picture changed to default")]
        public void ThenUserPictureChangedToDefault()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Verify.Contains("img/UnknownUser.jpg", page.UserPicture.GetAttribute("style"),
                "Picture is not default");
        }

        [Then(@"Notification message is displayed for a few seconds on Preferences page")]
        public void ThenNotificationMessageIsDisplayedForAFewSecondsOnPreferencesPage()
        {
            var page = _driver.NowAt<PreferencesPage>();
            Verify.IsTrue(page.SuccessMessage.Displayed(), "Success message is not displayed");
            Thread.Sleep(10000);
            Verify.IsFalse(page.SuccessMessage.Displayed(), "Success message is displayed for more than 5 seconds");
        }

        [Then(@"following Roles are available for User:")]
        public void ThenFollowingRolesAreAvailableForUser(Table table)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = page.AvailableRoles.Select(value => value.Text);
            Verify.AreEqual(expectedList, actualList, "Available Roles are different");
        }
    }
}