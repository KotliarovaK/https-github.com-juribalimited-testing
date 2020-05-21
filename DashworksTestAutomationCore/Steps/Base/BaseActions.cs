using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Base
{
    [Binding]
    internal class BaseActions : SpecFlowContext
    {
        private RemoteWebDriver _driver;
        private readonly BrowsersList _browsersList;

        public BaseActions(RemoteWebDriver driver, BrowsersList browsersList)
        {
            _driver = browsersList.GetBrowser();
            _browsersList = browsersList;
        }

        [Then(@"User click back button in the browser")]
        public void ThenUserClickBackButtonInTheBrowser()
        {
            _driver.Navigate().Back();
        }

        [When(@"User clicks refresh button in the browser")]
        public void WhenUserClicksRefreshButtonInTheBrowser()
        {
            _driver.Navigate().Refresh();
        }

        [Then(@"There are no errors in the browser console")]
        public void ThenThereAreNoErrorsInTheBrowserConsole()
        {
            _driver.WaitForDataLoading();
            _driver.CheckConsoleErrors();
        }

        [Then(@"There are only 'Page not found' errors in console")]
        public void ThenThereAreOnlyPageNotFoundErrorsInTheBrowserConsole()
        {
            _driver.CheckConsoleErrors("the server responded with a status of 404(Not Found)");
        }

        [Then(@"Number of requests to '(.*)' is not greater than '(.*)'")]
        public void ThenNumberOfRequestsToHostIsEqualToExpectedNumber(string partOfLink, string requestNumber)
        {
            _driver.WaitForDataLoading();
            Verify.That(_driver.GetAllRequests().FindAll(x => x.Contains(partOfLink)).Count, Is.LessThan(Int32.Parse(requestNumber)), $"Requests count is greater than {requestNumber}.");
        }

        [When(@"User clicks Body container")]
        public void WhenUserClicksBodyContainer()
        {
            var page = _driver.NowAt<BasePage>();
            _driver.ClickByActions(page.BodyContainer);
        }

        [When(@"User navigates to '(.*)' url via address line")]
        public void ThenUserNavigatesToTheSpecificUrlViaAddressLine(string url)
        {
            string navigationUrl = $"{UrlProvider.EvergreenUrl}#/{url}";
            _driver.NavigateToUrl(navigationUrl);
        }

        [Then(@"'(.*)' text is highlighted")]
        public void ThenSelectedTextIsHighlighted(string textSelected)
        {
            Verify.That(_driver.GetSelectedText(), Is.EqualTo(textSelected));
        }

        [When(@"User waits for '(.*)' seconds")]
        public void WhenUserWaitsForSeconds(int seconds)
        {
            if (seconds > 10)
            {
                throw new Exception("Unable to wait longer than 10 seconds");
            }

            Thread.Sleep(seconds * 1000);
        }

        [When(@"User switches to previous tab")]
        public void WhenUserSwitchesToPreviousTab()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.First());
        }

        [Given(@"User creates new browser")]
        public void GivenUserCreatesNewBrowser()
        {
            _browsersList.AddDriver(BrowserFactory.CreateDriver());
            _driver = _browsersList.GetBrowser(1);
        }

        #region Check/Navigate to URL

        [When(@"User navigates to '(.*)' URL in a new tab")]
        public void WhenUserNavigatesToURLInANewTab(string urlParameters)
        {
            _driver.OpenInNewTab($"{UrlProvider.Url}{urlParameters}");
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }

        [Then(@"URL is '(.*)'")]
        public void ThenURLIs(string urlPart)
        {
            var expectedUrl = $"{UrlProvider.Url}{urlPart}";
            Verify.AreEqual(expectedUrl, _driver.Url, $"URL is not equals to '{expectedUrl}'");
        }

        [Then(@"URL contains '(.*)'")]
        public void ThenURLContains(string url)
        {
            Verify.Contains(url, _driver.Url, $"URL is not contains '{url}'");
        }

        #endregion
    }
}