using System;
using System.Linq;
using System.Threading;
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
        private readonly RemoteWebDriver _driver;

        public BaseActions(RemoteWebDriver driver)
        {
            _driver = driver;
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

        [When(@"User clicks Body container")]
        public void WhenUserClicksBodyContainer()
        {
            var page = _driver.NowAt<BasePage>();
            page.BodyContainer.Click();
        }

        [When(@"User navigates to '(.*)' url via address line")]
        public void ThenUserNavigatesToTheSpecificUrlViaAddressLine(string url)
        {
            _driver.NavigateToUrl($"{UrlProvider.EvergreenUrl}#/{url}");
        }

        [Then(@"'(.*)' text is highlighted")]
        public void ThenSelectedTextIsHighlighted(string textSelected)
        {
            Utils.Verify.That(_driver.GetSelectedText(), Is.EqualTo(textSelected));
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