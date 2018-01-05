using System;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_QueryStrings : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly WebsiteUrl _url;

        public EvergreenJnr_QueryStrings(RemoteWebDriver driver, WebsiteUrl url)
        {
            _driver = driver;
            _url = url;
        }

        [Given(@"User is on Dashworks Homepage")]
        public void GivenUserIsOnDashworksHomepage()
        {
            _driver.NagigateToURL(UrlProvider.Url);
            _url.Value = UrlProvider.Url;

            var loginPage = _driver.NowAt<LoginPanelPage>();

            //If automation.corp.juriba.com is not available, try automation2.corp.juriba.com instead
            if (loginPage.WebsiteIsNotAvailable.Displayed())
            {
                _driver.NagigateToURL(UrlProvider.BackupUrl);
                _url.Value = UrlProvider.BackupUrl;
                Logger.Write("Using automation2.corp.juriba.com instead");
            }
            //Check if the forced login page is displayed
            else if (loginPage.LoginsplashPanel.Displayed())
            {
                Logger.Write("Forced login splash page is visible instead of Dashworks homepage");
            }
        }

        [Given(@"Login link is visible")]
        public void GivenLoginLinkIsVisible()
        {
            var loginPage = _driver.NowAt<LoginPanelPage>();

            //Only check the login link is visible if the forced login splash page is not displayed
            if (loginPage.LoginsplashPanel.Displayed())
            {
                Assert.IsTrue(loginPage.LoginLink.Displayed, "Login link is NOT visible");
                Logger.Write("Login link is visible");
            }
        }

        [When(@"User clicks on the Login link")]
        public void WhenUserClicksOnTheLoginLink()
        {
            var loginPage = _driver.NowAt<LoginPanelPage>();

            //Only click the login link if the forced login splash page is NOT displayed
            if (!loginPage.LoginsplashPanel.Displayed())
            {
                loginPage.LoginLink.Click();
                Logger.Write("Login link was clicked");
            }
        }

        [Then(@"Login Page is displayed to the user")]
        public void ThenLoginPageIsDisplayedToTheUser()
        {
            var loginPage = _driver.NowAt<LoginPage>();

            if (loginPage.LoginGroupbox.Displayed())
            {
                Logger.Write("Login page is visible");
            }
            else
            {
                Assert.IsTrue(loginPage.SplasLoginGroupbox.Displayed(), "Login Splash page is NOT visible");
                Logger.Write("Login Splash page is visible");
            }
        }

        [When(@"Evergreen QueryStringURL is entered for Simple QueryType")]
        [When(@"Evergreen QueryStringURL is entered for Complex QueryType")]
        public void WhenEvergreenQueryStringURLIsEnteredForSimpleQueryType(Table table)
        {
            foreach (var row in table.Rows)
            {
                var combinedURL = _url.Value + row["QueryStringURL"];
                _driver.NagigateToURL(combinedURL);

                var page = _driver.NowAt<EvergreenDashboardsPage>();

                if (page.StatusCodeLabel.Displayed())
                {
                    throw new Exception($"500 error was returned for: {row["QueryType"]} query");
                }

                Logger.Write($"Evergreen agGrid Main Object List is returned with data for: {row["QueryType"]} query");
            }
        }

        [Then(@"agGrid Main Object List is returned with data")]
        public void ThenAgGridMainObjectListIsReturnedWithData()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();

            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => dashboardPage.ResultsOnPageCount);

            Assert.IsTrue(dashboardPage.ResultsOnPageCount.Displayed());
            Assert.IsTrue(dashboardPage.TableBody.Displayed());

            Logger.Write("Main agGrid dataset is displayed");
        }
    }
}