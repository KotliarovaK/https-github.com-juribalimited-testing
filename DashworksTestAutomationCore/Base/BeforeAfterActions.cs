using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Reflection;
using AutomationUtils.Utils;
using BoDi;
using DashworksTestAutomation.DTO;
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
        private readonly RestWebClient _client;
        private readonly TestInfo _testInfo;
        private readonly BrowsersList _browsersList;

        public BeforeAfterActions(IObjectContainer objectContainer, ScenarioContext scenarioContext, RestWebClient client, TestInfo testInfo, BrowsersList browsersList)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
            _client = client;
            _testInfo = testInfo;
            _browsersList = browsersList;
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
            _testInfo.StartTime = DateTime.Now;
            _testInfo.Name = GetTestName();
            _testInfo.Tags = GetTags();

            Logger.Write($"TEST STARTED: {_testInfo.Name}");

            LockCategory.AwaitTags(_testInfo.Tags);
            LockCategory.AddTags(_testInfo.Name, _testInfo.Tags);

            //Create browser if not API test
            if (!_testInfo.Tags.Contains("API"))
            {
                var driverInstance = CreateBrowserDriver();
                if (!Browser.RemoteDriver.Equals("local"))
                    driverInstance.Manage().Window.Maximize();
                _objectContainer.RegisterInstanceAs(driverInstance);
                _browsersList.AddDriver(driverInstance);
            }
        }

        [AfterScenario(Order = 0)]
        public void TestResultsAndScreen()
        {
            try
            {
                RemoteWebDriver driver = null;
                if (!_testInfo.Tags.Contains("API"))
                    try
                    {
                        //driver = _objectContainer.Resolve<RemoteWebDriver>();
                        driver = _browsersList.GetBrowser();
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
                        if (!string.IsNullOrEmpty(_testInfo.Name))
                        {
                            if (driver != null)
                                driver.CreateScreenshot(_testInfo.Name);
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
                LockCategory.RemoveTestTags(_testInfo.Name);

                //Unleash test only if NOT in local run
                if (!Browser.RemoteDriver.Equals("local"))
                    try
                    {
                        var testStatus = GetTestStatus();
                        if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("Passed"))
                            BambooUtil.UnleashTest(_testInfo.Name);
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Unable to unleash test: {e}");
                    }

                //RemoteWebDriver driver = null;
                if (!_testInfo.Tags.Contains("API"))
                    try
                    {
                        foreach (RemoteWebDriver browser in _browsersList.GetAllBrowsers())
                        {
                            try
                            {
                                browser?.QuitDriver();
                            }
                            catch (Exception e)
                            {
                                Logger.Write($"Unable to close driver: {e}");
                            }
                        }
                        //driver = _objectContainer.Resolve<RemoteWebDriver>();
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"UNABLE to get driver from context. It was closed before or doesn't exist: {e}");
                        //driver = null;
                    }
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
            finally
            {
                try
                {
                    Logger.Write($"TEST FINISHED: {_testInfo.Name}");
                }
                catch { }
            }
            //FOR DEBUG ONLY
            /*
            try
            {
                var requestUri = "http://autorelease.corp.juriba.com:81/applications?$top=1000&$skip=0&$filter=(project_43_applicationReadinessId%20EQUALS%20(%27NULL%27))&$select=packageName,packageManufacturer,packageVersion,project_43_hideFromEndUsers,project_43_applicationReadiness";
                var request = requestUri.GenerateRequest();

                var resp = _client.Evergreen.Get(request);

                if (!resp.Content.Contains("{\"count\":1155"))
                {
                    Logger.Write("AFTER ============> !!! FILTER WAS CHANGED !!! <============");
                    Logger.Write(resp.Content.Substring(0, 50));
                }
            }
            catch (Exception e)
            {
                Logger.Write(e);
                Logger.Write("AFTER ============> !!! FILTER WAS CHANGED !!! <============");
            }*/
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

            Logger.Write("ALL TESTS ARE FINISHED");
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

        public List<string> GetTags()
        {
            try
            {
                List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();

                //If we are not able to get nUnit tags the try to get them from SpecFlow
                if (!testTags.Any())
                    testTags = _scenarioContext.ScenarioInfo.Tags.ToList();

                return testTags;
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to get Tags from context: {e}");
            }
        }
    }
}