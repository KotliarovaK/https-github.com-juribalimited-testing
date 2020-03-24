using System;
using System.Configuration;
using System.Linq;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.Login
{
    [Binding]
    internal class EvergreenJnr_Login : BaseLoginActions
    {
        private RemoteWebDriver _driver;

        public EvergreenJnr_Login(RemoteWebDriver driver, UserDto user, UsedUsers usedUsers, RestWebClient client, AuthObject authObject, BrowsersList browsersList) :
            base(user, usedUsers, client, authObject)
        {
            _driver = browsersList.GetBrowser();
        }

        [Given(@"User is logged in to the Evergreen")]
        public void GivenUserIsLoggedInToTheEvergreen()
        {
            //Login to website via api
            LoginViaApi(_driver);
            //Navigate to Evergreen page
            _driver.NavigateToUrl(UrlProvider.EvergreenUrl);
        }

        [When(@"User is logged in to the Evergreen as")]
        public void GivenSpecificUserIsLoggedInToTheEvergreen(Table table)
        {
            UserDto user = table.CreateInstance<UserDto>();
            user.Language = UserProvider.DefaultUserLanguage;

            if (user == null)
                throw new Exception("User table is not set");

            //Login to website via api
            LoginViaApiAsUser(_driver, user);
            //Navigate to Evergreen page
            _driver.NavigateToUrl(UrlProvider.EvergreenUrl);
        }

        [Given(@"User is logged in to the Projects")]
        public void GivenUserIsLoggedInToTheProjects()
        {
            //Login to website via api
            LoginViaApiOnSenior(_driver, GetFreeUserAndAddToUsedUsersList());
            //navigate to Projects page
            _driver.NavigateToUrl(UrlProvider.ProjectsUrl);
        }

        [Given(@"User is logged in to the Projects as Admin")]
        public void GivenUserIsLoggedInToTheProjectsAsAdmin()
        {
            //Login to website via api
            LoginViaApiOnSenior(_driver, GetSupperAdminAndAddToUsedUsersList());
            //navigate to Projects page
            _driver.NavigateToUrl(UrlProvider.ProjectsUrl);
        }

        [When(@"User provides the Login and Password and clicks on the login button")]
        public void WhenUserProvidesTheLoginAndPasswordAndClicksOnTheLoginButton()
        {
            var user = GetFreeUserAndAddToUsedUsersList();

            var loginPage = _driver.NowAt<LoginPage>();

            if (loginPage.LoginGroupBox.Displayed())
            {
                loginPage.UserNameTextBox.SendKeys(user.Username);
                loginPage.PasswordTextBox.SendKeys(user.Password);
                loginPage.LoginButton.Click();
            }
            else
            {
                loginPage.SplashUserNameTextBox.SendKeys(user.Username);
                loginPage.SplashPasswordTextBox.SendKeys(user.Password);
                loginPage.SplashLoginButton.Click();
            }
        }

        [When(@"User login with ""(.*)"" account")]
        public void WhenUserLoginWithAccount(int userIterator)
        {
            var user = UsedUsers.Value[userIterator - 1];
            user.CopyPropertiesTo(User);

            var loginPage = _driver.NowAt<LoginPage>();

            if (loginPage.LoginGroupBox.Displayed())
            {
                loginPage.UserNameTextBox.SendKeys(User.Username);
                loginPage.PasswordTextBox.SendKeys(User.Password);
                loginPage.LoginButton.Click();
            }
            else
            {
                loginPage.SplashUserNameTextBox.SendKeys(User.Username);
                loginPage.SplashPasswordTextBox.SendKeys(User.Password);
                loginPage.SplashLoginButton.Click();
            }
        }

        [When(@"User login with following credentials:")]
        public void WhenUserLoginWithFollowingCredentials(Table table)
        {
            var loginPage = _driver.NowAt<LoginPage>();

            foreach (var row in table.Rows)
                if (loginPage.LoginGroupBox.Displayed())
                {
                    loginPage.UserNameTextBox.SendKeys(row["Username"]);
                    loginPage.PasswordTextBox.SendKeys(row["Password"]);
                    loginPage.LoginButton.Click();
                    UserDto user = new UserDto();
                    user.Username = row["Username"];
                    user.Password = row["Password"];
                    UsedUsers.Value.Add(user);
                }
                else
                {
                    loginPage.SplashUserNameTextBox.SendKeys(row["Username"]);
                    loginPage.SplashPasswordTextBox.SendKeys(row["Password"]);
                    loginPage.SplashLoginButton.Click();
                    UserDto user = new UserDto();
                    user.Username = row["Username"];
                    user.Password = row["Password"];
                    UsedUsers.Value.Add(user);
                }
        }

        [Then(@"Dashworks homepage is displayed to the user in a logged in state")]
        public void ThenDashworksHomepageIsDisplayedToTheUserInALoggedInState()
        {
            var headerMenu = _driver.NowAt<DashworksHeaderMenuElement>();

            Verify.AreEqual("Home - Dashworks", _driver.Title, "Incorrect page is displayed");
            Verify.AreEqual("Home", headerMenu.PageHeader.Text, "Incorrect page is displayed");
            Logger.Write("Dashworks homepage is displayed and is in a logged in state");
        }

        [When(@"User clicks the Switch to Evergreen link")]
        public void WhenUserClicksTheSwitchToEvergreenLink()
        {
            var headerMenu = _driver.NowAt<DashworksHeaderMenuElement>();

            //Commented this part because now Switch to Evergreen link is displayed on page header, without Switch Site
            //_driver.MouseHover(headerMenu.AnalysisLink);

            _driver.WaitForElementToBeEnabled(headerMenu.EvergreenLink);
            headerMenu.EvergreenLink.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Evergreen Dashboards page should be displayed to the user")]
        public void ThenEvergreenDashboardsPageShouldBeDisplayedToTheUser()
        {
            var dashboardsPage = _driver.NowAt<BaseErrorPage>();

            if (_driver.IsElementExists(dashboardsPage.StatusCode))
                throw new Exception($"'{dashboardsPage.StatusCode.Text}'Error was displayed");

            Logger.Write("Evergreen Dashboards page is displayed");
        }
    }
}