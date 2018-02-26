using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.DTO.RuntimeVariables;
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

        [Then(@"There are no errors in the browser console")]
        public void ThenThereAreNoErrorsInTheBrowserConsole()
        {
            List<LogEntry> errorsList = new List<LogEntry>();
            foreach (var entry in _driver.Manage().Logs.GetLog(LogType.Browser).ToList())
            {
                if (entry.Level == LogLevel.Severe)
                {
                    errorsList.Add(entry);
                }
            }
            Assert.IsEmpty(errorsList, "Error message is displayed in the console");
        }
    }
}