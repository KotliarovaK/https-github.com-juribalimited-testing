using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Management;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_Login : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;
        private readonly UsedUsers _usedUsers;

        public EvergreenJnr_Login(RemoteWebDriver driver, UserDto user, UsedUsers usedUsers)
        {
            _driver = driver;
            _user = user;
            _usedUsers = usedUsers;
        }

        private UserDto GetFreeUserAndAddToUsedUsersList()
        {
            var user = UserProvider.GetFreeUserAccount();
            if (_usedUsers.Value == null)
            {
                _usedUsers.Value = new List<UserDto>();
            }
            _usedUsers.Value.Add(user);

            //Add user credentials to context
            user.CopyPropertiesTo(_user);

            //Change User Language to avoid spelling issues
            DatabaseWorker.ChangeUserProfileLanguage(_user.UserName, _user.Language);

            return user;
        }

        [Given(@"User is logged in to the Evergreen")]
        public void GivenUserIsLoggedInToTheEvergreen()
        {
            var user = GetFreeUserAndAddToUsedUsersList();

            var restClient = new RestClient(UrlProvider.Url);
            //Get cookies
            HttpClientHelper client = new HttpClientHelper(user, restClient);

            //Init session
            _driver.NagigateToURL(UrlProvider.Url);

            //Set cookies to browser
            foreach (Cookie cookie in client._cookiesJar)
            {
                _driver.Manage().Cookies.AddCookie(cookie);
            }

            //Open website
            _driver.NagigateToURL(UrlProvider.EvergreenUrl);
        }

        [When(@"User provides the Login and Password and clicks on the login button")]
        public void WhenUserProvidesTheLoginAndPasswordAndClicksOnTheLoginButton()
        {
            var user = GetFreeUserAndAddToUsedUsersList();

            var loginPage = _driver.NowAt<LoginPage>();

            if (loginPage.LoginGroupbox.Displayed())
            {
                loginPage.UserNameTextbox.SendKeys(user.UserName);
                loginPage.PasswordTextbox.SendKeys(user.Password);
                loginPage.LoginButton.Click();
            }
            else
            {
                loginPage.SplashUserNameTextbox.SendKeys(user.UserName);
                loginPage.SplashPasswordTextbox.SendKeys(user.Password);
                loginPage.SplashLoginButton.Click();
            }
        }

        [When(@"User login with ""(.*)"" account")]
        public void WhenUserLoginWithAccount(int userIterator)
        {
            var user = _usedUsers.Value[userIterator - 1];
            user.CopyPropertiesTo(_user);

            var loginPage = _driver.NowAt<LoginPage>();

            if (loginPage.LoginGroupbox.Displayed())
            {
                loginPage.UserNameTextbox.SendKeys(_user.UserName);
                loginPage.PasswordTextbox.SendKeys(_user.Password);
                loginPage.LoginButton.Click();
            }
            else
            {
                loginPage.SplashUserNameTextbox.SendKeys(_user.UserName);
                loginPage.SplashPasswordTextbox.SendKeys(_user.Password);
                loginPage.SplashLoginButton.Click();
            }
        }

        [Then(@"Dashworks homepage is displayed to the user in a logged in state")]
        public void ThenDashworksHomepageIsDisplayedToTheUserInALoggedInState()
        {
            var headerMenu = _driver.NowAt<DashworksHeaderMenuElement>();

            Assert.AreEqual("Home - Dashworks", _driver.Title);
            Assert.AreEqual("Home", headerMenu.PageHeader.Text);
            Logger.Write("Dashworks homepage is displayed and is in a logged in state");
        }

        [When(@"User clicks the Switch to Evergreen link")]
        public void WhenUserClicksTheSwitchToEvergreenLink()
        {
            var headerMenu = _driver.NowAt<DashworksHeaderMenuElement>();

            _driver.MouseHover(headerMenu.AnalysisLink);

            _driver.WaitWhileControlIsNotClickable<DashworksHeaderMenuElement>(() => headerMenu.EvergreenLink);
            headerMenu.EvergreenLink.Click();
        }

        [Then(@"Evergreen Dashboards page should be displayed to the user")]
        public void ThenEvergreenDashboardsPageShouldBeDisplayedToTheUser()
        {
            var dashboardsPage = _driver.NowAt<EvergreenDashboardsPage>();

            if (_driver.IsElementExists(dashboardsPage.StatusCodeLabel))
                throw new Exception("500 error was displayed");

            Logger.Write("Evergreen Dashboards page is displayed");
        }
    }
}