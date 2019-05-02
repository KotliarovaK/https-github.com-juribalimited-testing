using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using BoDi;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Base
{
    [Binding]
    internal class BeforeAfterActions : BaseTest
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;

        public BeforeAfterActions(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void OnStartUp()
        {
            List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();
            LockCategory.AwaitTags(testTags);
            LockCategory.AddTags(testTags);

            var driverInstance = CreateBrowserDriver();

            driverInstance.Manage().Window.Maximize();

            _objectContainer.RegisterInstanceAs(driverInstance);
        }

        [AfterScenario]
        public void OnTearDown()
        {
            try
            {
                List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();
                LockCategory.RemoveTags(testTags);

                var driver = _objectContainer.Resolve<RemoteWebDriver>();

                try
                {
                    if (Browser.RemoteDriver.Equals("sauceLabs"))
                    {
                        bool passed = TestContext.CurrentContext.Result.Outcome.Status ==
                                      TestStatus.Passed;

                        try
                        {
                            // Logs the result to Sauce Labs
                            ((IJavaScriptExecutor) driver).ExecuteScript(
                                "sauce:job-result=" + (passed ? "passed" : "failed"));
                        }
                        finally
                        {
                            Console.WriteLine(
                                $"SauceOnDemandSessionID={((CustomRemoteWebDriver) driver).getSessionId()} job-name={TestContext.CurrentContext.Test.MethodName}");
                        }
                    }

                    var testStatus = GetTestStatus();
                    if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("Failed"))
                    {
                        var testName = GetTestName();
                        if (!string.IsNullOrEmpty(testName))
                            driver.CreateScreenshot(testName);
                    }

                    Logger.Write($"Closing window at: {driver.Url}");
                }
                catch (Exception e)
                {
                    Logger.Write(e);
                }

                driver.QuitDriver();
            }
            catch (ObjectContainerException e)
            {
                //There are no driver in the context
                Logger.Write(e + "There are no driver in the context");
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }

        [BeforeTestRun]
        public static void OnTestsStart()
        {
            if (bool.Parse(ConfigurationManager.AppSettings["browsersCleanup"]))
                KillDriverProcesses.Do();
        }

        [AfterTestRun]
        public static void OnTestsComplete()
        {
            if (bool.Parse(ConfigurationManager.AppSettings["browsersCleanup"]))
                KillDriverProcesses.Do();
        }

        private string GetTestStatus()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            return testStatus.ToString();
        }

        private string GetTestName()
        {
            var testName = _scenarioContext.ScenarioInfo.Title;
            return testName;
        }
    }
}