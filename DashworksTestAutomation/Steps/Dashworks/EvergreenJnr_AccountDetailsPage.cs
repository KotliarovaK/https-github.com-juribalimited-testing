using System.IO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium;
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
            page.EmailField.Clear();
            page.EmailField.SendKeys(email);
        }

        [Then(@"""(.*)"" is displayed in Email field")]
        public void ThenIsDisplayedInEmailField(string email)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(email, page.EmailField.GetAttribute("value"));
        }

        [When(@"User clears Full name field")]
        public void WhenUserClearsFullNameField()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.FullNameField.ClearWithBackspaces();
        }

        [Then(@"""(.*)"" error message is displayed")]
        public void ThenErrorMessageIsDisplayed(string errorMessage)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(errorMessage, page.ErrorMessage.Text);
        }

        [When(@"User clears Email field")]
        public void WhenUserClearsEmailField()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.EmailField.ClearWithBackspaces();
        }

        [When(@"User Upload incorrect avatar to Account Details")]
        public void WhenUserUploadIncorrectAvatarToAccountDetails()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            IAllowsFileDetection allowsDetection = (IAllowsFileDetection) _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) +
                          "\\Resources\\IncorrectFile.txt";
            page.UploadButton.SendKeys(path);
        }

        [When(@"User Upload correct avatar to Account Details")]
        public void WhenUserUploadIncorrectAvatarToProfileDetails()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            IAllowsFileDetection allowsDetection = (IAllowsFileDetection) _driver;
            allowsDetection.FileDetector = new LocalFileDetector();
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) +
                          "\\Resources\\CorrectFile.png";
            page.UploadButton.SendKeys(path);
        }

        [Then(@"Success message with ""(.*)"" text is displayed on Account Detauils page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnAccountDetauilsPage(string text)
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            Assert.AreEqual(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"User picture is changed to uploaded photo")]
        public void ThenUserPictureIsChangedToUploadedPhoto()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            StringAssert.DoesNotContain("img/UnknownUser.jpg", page.UserPicture.GetAttribute("style"));
        }

        [When(@"User click Remove on Account details page")]
        public void WhenUserClickRemoveOnAccountDetailsPage()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            page.RemoveButton.Click();
        }

        [Then(@"User picture changed to default")]
        public void ThenUserPictureChangedToDefault()
        {
            var page = _driver.NowAt<AccountDetailsPage>();
            StringAssert.Contains("img/UnknownUser.jpg", page.UserPicture.GetAttribute("style"));
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
                page.EmailField.SendKeys("TestMail@test.com");
                page.RemoveButton.Click();
                page.UpdateButton.Click();
            }
            catch
            {
            }
        }
    }
}