using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
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
            _driver.CheckConsoleErrors();
        }

        [Then(@"There are only page not found errors in console")]
        public void ThenThereAreOnlyPageNotFoundErrorsInTheBrowserConsole()
        {
            var errorsList = new List<LogEntry>();

            foreach (var entry in _driver.Manage().Logs.GetLog(LogType.Browser).ToList())
                if (entry.Level == LogLevel.Severe)
                    errorsList.Add(entry);

            Assert.That(errorsList.Count, 
                Is.EqualTo(errorsList.FindAll(x=>x.Message.Contains("the server responded with a status of 404 (Not Found)")).Count), 
                "There are another errors in console");
        }
    }
}