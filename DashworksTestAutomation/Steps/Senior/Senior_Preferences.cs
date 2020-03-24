using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.ManagementConsole;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Senior_Preferences : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        protected readonly UsedUsers UsedUsers;

        public Senior_Preferences(RemoteWebDriver driver, UsedUsers usedUsers)
        {
            _driver = driver;
            UsedUsers = usedUsers;
        }

        [When(@"User navigate to Preferences page")]
        public void WhenUserNavigateToPreferences()
        {
            var page = _driver.NowAt<DashworksHeaderMenuElement>();
            page.PreferencesLink.Click();
        }

        [When(@"User navigate to Change Password page")]
        public void WhenUserNavigateToChangePassword()
        {
            var page = _driver.NowAt<UserProfilePage>();
            page.ChangePasswordButton.Click();
        }

        [When(@"User enters ""(.*)"" in the Current Password field in Senior")]
        public void WhenUserEntersInTheCurrentPasswordField(string currentPassword)
        {
            var page = _driver.NowAt<ChangePasswordPage>();
            page.CurrentPasswordInput.Clear();
            page.CurrentPasswordInput.SendKeys(currentPassword);
        }

        [When(@"User enters ""(.*)"" in the New Password field in Senior")]
        public void WhenUserEntersInTheNewPasswordField(string newPassword)
        {
            var page = _driver.NowAt<ChangePasswordPage>();
            page.NewPasswordInput.Clear();
            page.NewPasswordInput.SendKeys(newPassword);
        }

        [When(@"User enters ""(.*)"" in the Confirm Password field in Senior")]
        public void WhenUserEntersInTheConfirmPasswordField(string confirmPassword)
        {
            var page = _driver.NowAt<ChangePasswordPage>();
            page.ConfirmNewPasswordInput.Clear();
            page.ConfirmNewPasswordInput.SendKeys(confirmPassword);
        }

        [When(@"User submits password changes in Senior")]
        public void WhenUserSubmitsPasswordChanges()
        {
            var page = _driver.NowAt<ChangePasswordPage>();
            page.ChangePasswordButton.Click();
        }

        [Then(@"""(.*)"" message displayed on User Profile page")]
        public void ThenPageIsDisplayedToTheUser(string message)
        {
            var page = _driver.NowAt<UserProfilePage>();

            _driver.WaitForElementToHaveText(page.NotificationBanner, message);
            Logger.Write("Password was successfully updated");
        }
    }
}