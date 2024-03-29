﻿using System;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using DashworksTestAutomation.Helpers;


namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_QueryStrings : SpecFlowContext
    {
        private RemoteWebDriver _driver;
        private readonly WebsiteUrl _url;

        public EvergreenJnr_QueryStrings(RemoteWebDriver driver, WebsiteUrl url, BrowsersList browsersList)
        {
            _driver = browsersList.GetBrowser();
            _url = url;
        }

        [Given(@"User is on Dashworks Homepage")]
        public void GivenUserIsOnDashworksHomepage()
        {
            _driver.NavigateToUrl(UrlProvider.Url);
            _url.Value = UrlProvider.Url;

            var loginPage = _driver.NowAt<LoginPanelPage>();

            //If automation.corp.juriba.com is not available, try automation2.corp.juriba.com instead
            if (loginPage.WebsiteIsNotAvailable.Displayed())
            {
                _driver.NavigateToUrl(UrlProvider.BackupUrl);
                _url.Value = UrlProvider.BackupUrl;
                Logger.Write("Using automation2.corp.juriba.com instead");
            }
            //Check if the forced login page is displayed
            else if (loginPage.LoginSplashPanel.Displayed())
            {
                Logger.Write("Forced login splash page is visible instead of Dashworks homepage");
            }
        }

        [Given(@"Login link is visible")]
        public void GivenLoginLinkIsVisible()
        {
            var loginPage = _driver.NowAt<LoginPanelPage>();

            //Only check the login link is visible if the forced login splash page is not displayed
            if (!loginPage.LoginSplashPanel.Displayed()) return;
            Verify.IsTrue(loginPage.LoginLink.Displayed, "Login link is NOT visible");
            Logger.Write("Login link is visible");
        }

        [When(@"User clicks on the Login link")]
        public void WhenUserClicksOnTheLoginLink()
        {
            var loginPage = _driver.NowAt<LoginPanelPage>();
            _driver.WaitForDataLoading();
            //Only click the login link if the forced login splash page is NOT displayed
            if (!loginPage.LoginSplashPanel.Displayed())
            {
                loginPage.LoginLink.Click();
                Logger.Write("Login link was clicked");
            }
        }

        [Then(@"Login Page is displayed to the user")]
        public void ThenLoginPageIsDisplayedToTheUser()
        {
            var loginPage = _driver.NowAt<LoginPage>();

            if (loginPage.LoginGroupBox.Displayed())
            {
                Logger.Write("Login page is visible");
            }
            else
            {
                Verify.IsTrue(loginPage.SplashLoginGroupBox.Displayed(), "Login Splash page is NOT visible");
                Logger.Write("Login Splash page is visible");
            }
        }

        [When(@"Evergreen QueryStringURL is entered for Simple QueryType")]
        [When(@"Evergreen QueryStringURL is entered for Complex QueryType")]
        public void WhenEvergreenQueryStringURLIsEnteredForSimpleQueryType(Table table)
        {
            foreach (var row in table.Rows)
            {
                _url.Value = UrlProvider.Url;
                var combinedUrl = _url.Value + row["QueryStringURL"];

                if (table.ContainsColumn("ListName"))
                {
                    var listId = DatabaseHelper.GetListId(row["ListName"]);
                    combinedUrl = combinedUrl.Replace("ListName", listId);
                }

                _driver.NowAt<BaseHeaderElement>();
                _driver.NavigateToUrl(combinedUrl);

                var page = _driver.NowAt<BaseDashboardPage>();

                if (page.StatusCodeLabel.Displayed())
                    throw new Exception($"500 error was returned for: {row["QueryType"]} query");

                Logger.Write($"Evergreen agGrid Main Object List is returned with data for: {row["QueryType"]} query");
            }
        }

        [When(@"Evergreen QueryStringURL is entered for Simple QueryType with expecting error")]
        public void WhenEvergreenQueryStringURLIsEnteredForSimpleQueryTypeWithExpectingError(Table table)
        {
            foreach (var row in table.Rows)
            {
                _url.Value = UrlProvider.Url;
                var combinedURL = _url.Value + row["QueryStringURL"];
                _driver.NavigateToUrl(combinedURL);

                var page = _driver.NowAt<BaseDashboardPage>();

                Logger.Write($"Evergreen agGrid Main Object List is returned with data for: {row["QueryType"]} query");
            }
        }

        [Then(@"agGrid Main Object List is returned with data")]
        public void ThenAgGridMainObjectListIsReturnedWithData()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();

            _driver.WaitForDataLoading();
            if (!dashboardPage.ResultsOnPageCount.Displayed())
            {
                Verify.IsTrue(_driver.IsElementDisplayed(dashboardPage.NoResultsFoundMessage, WebDriverExtensions.WaitTime.Long),
                    "'No Results Found' message is not displayed");
                Logger.Write(
                    $"Evergreen agGrid Search returned '{dashboardPage.NoResultsFoundMessage.Text}' message");
            }
            else
            {
                Verify.IsTrue(dashboardPage.ResultsOnPageCount.Displayed(), "Results count is not displayed");
                var page = _driver.NowAt<BaseGridPage>();
                Verify.IsTrue(page.TableBody.Displayed(), "Table is not displayed");
                Logger.Write("Main agGrid dataset is displayed");
            }
        }

        [When(@"Evergreen QueryStringURL is entered for Simple QueryType and appropriate RowCount is displayed")]
        public void WhenEvergreenQueryStringURLIsEnteredForSimpleQueryTypeAndAppropriateRowCountIsDisplayed(Table table)
        {
            foreach (var row in table.Rows)
            {
                _url.Value = UrlProvider.Url;
                var combinedURL = _url.Value + row["QueryStringURL"];
                _driver.NowAt<BaseHeaderElement>();
                _driver.NavigateToUrl(combinedURL);

                var page = _driver.NowAt<BaseDashboardPage>();

                if (page.StatusCodeLabel.Displayed())
                    throw new Exception($"500 error was returned for: {row["QueryType"]} query");

                Logger.Write($"Evergreen agGrid Main Object List is returned with data for: {row["QueryType"]} query");
                ThenAgGridMainObjectListIsReturnedWithData();
                var evergreenJnrListSearch = new EvergreenJnr_ListSearch(_driver);
                evergreenJnrListSearch.ThenRowsAreDisplayedInTheAgGrid(row["RowCount"]);
            }
        }
    }
}