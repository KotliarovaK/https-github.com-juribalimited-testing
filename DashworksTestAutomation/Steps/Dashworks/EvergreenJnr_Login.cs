using System;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Providers;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_Login : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;

        public EvergreenJnr_Login(RemoteWebDriver driver, UserDto user)
        {
            _driver = driver;
            _user = user;
        }

        [When(@"User provides the Login and Password and clicks on the login button")]
        public void WhenUserProvidesTheLoginAndPasswordAndClicksOnTheLoginButton()
        {
            //Add user credentials to context
            UserProvider.User.CopyPropertiesTo(_user);

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