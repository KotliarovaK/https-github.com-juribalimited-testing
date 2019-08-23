using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Reflection;
using BoDi;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using HtmlAgilityPack;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RestSharp;
using RestSharp.Authenticators;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Base
{
    [Binding]
    internal class BeforeAfterActions : BaseTest
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;
        //TODO remove this
        private readonly RestWebClient _client;

        public BeforeAfterActions(IObjectContainer objectContainer, ScenarioContext scenarioContext, RestWebClient client)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
            _client = client;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            if (!Browser.RemoteDriver.Equals("local") && !string.IsNullOrEmpty(BambooProvider.BuildResultKey))
                BambooUtil.GetAllQuarantinedTests();
        }

        [BeforeScenario]
        public void OnStartUp()
        {
            Logger.Write($"TEST STARTED: {GetTestName()}");

            List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();

            //If we are not able to get nUnit tags the try to get them from SpecFlow
            if (!testTags.Any())
                testTags = _scenarioContext.ScenarioInfo.Tags.ToList();

            LockCategory.AwaitTags(testTags);
            LockCategory.AddTags(testTags);

            //Create browser if not API test
            if (!testTags.Contains("API"))
            {
                var driverInstance = CreateBrowserDriver();
                if (!Browser.RemoteDriver.Equals("local"))
                    driverInstance.Manage().Window.Maximize();
                _objectContainer.RegisterInstanceAs(driverInstance);
            }
        }

        [AfterScenario(Order = 0)]
        public void TestResultsAndScreen()
        {
            try
            {
                List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString())
                    .ToList();

                RemoteWebDriver driver = null;
                if (!testTags.Contains("API"))
                    try
                    {
                        driver = _objectContainer.Resolve<RemoteWebDriver>();
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"UNABLE to get driver from context. It was closed before or doesn't exist: {e}");
                        driver = null;
                    }

                try
                {
                    var testStatus = GetTestStatus();
                    Logger.Write($"Test status is '{testStatus}'");
                    if (!string.IsNullOrEmpty(testStatus) && (testStatus.Equals("Failed") || testStatus.Equals("Inconclusive")))
                    {
                        var testName = GetTestName();
                        if (!string.IsNullOrEmpty(testName))
                        {
                            if (driver != null)
                                driver.CreateScreenshot(testName);
                            else
                                Logger.Write("Unable to get screenshot as no Driver in the context");
                        }

                    }

                    if (driver != null)
                        Logger.Write($"Test finished on: {driver.Url}");
                }
                catch (Exception e)
                {
                    Logger.Write(e);
                }
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }

        [AfterScenario(Order = 10000)]
        public void QuiteDriver()
        {
            try
            {
                List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString())
                    .ToList();
                LockCategory.RemoveTags(testTags);

                //Unleash test only if NOT in local run
                if (!Browser.RemoteDriver.Equals("local"))
                    try
                    {
                        var testStatus = GetTestStatus();
                        if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("Passed"))
                            BambooUtil.UnleashTest(GetTestName());
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Unable to unleash test: {e}");
                    }

                RemoteWebDriver driver = null;
                if (!testTags.Contains("API"))
                    try
                    {
                        driver = _objectContainer.Resolve<RemoteWebDriver>();
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"UNABLE to get driver from context. It was closed before or doesn't exist: {e}");
                        driver = null;
                    }

                driver?.QuitDriver();
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
            finally
            {
                try
                {
                    Logger.Write($"TEST FINISHED: {GetTestName()}");
                }
                catch { }
            }

            //TODO remove this
            var requestUri = "http://automation.corp.juriba.com:81/lists/devices/108";
            var request = requestUri.GenerateRequest();
            var response = _client.Value.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"BROKEN LIST was deleted!!!");
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