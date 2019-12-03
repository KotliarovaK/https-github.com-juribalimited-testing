﻿using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
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
    }
}