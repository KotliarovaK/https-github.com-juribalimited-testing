﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using BoDi;
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

        public BeforeAfterActions(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
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
            List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();

            //If we are not able to get nUnit tags the try to get them from SpecFlow
            if (!testTags.Any())
                testTags = ScenarioContext.Current.ScenarioInfo.Tags.ToList();

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

        [AfterScenario]
        public void OnTearDown()
        {
            try
            {
                List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();
                LockCategory.RemoveTags(testTags);

                RemoteWebDriver driver = null;
                if (!testTags.Contains("API"))
                    driver = _objectContainer.Resolve<RemoteWebDriver>();

                try
                {
                    var testStatus = GetTestStatus();
                    if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("Failed"))
                    {
                        var testName = GetTestName();
                        if (!string.IsNullOrEmpty(testName))
                            driver?.CreateScreenshot(testName);
                    }
                    else if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("Passed"))
                    {
                        BambooUtil.UnleashTest(GetTestName());
                    }

                    if (driver != null)
                        Logger.Write($"Closing window at: {driver.Url}");
                }
                catch (Exception e)
                {
                    Logger.Write(e);
                }

                driver?.QuitDriver();
            }
            catch (ObjectContainerException e)
            {
                //There are no driver in the context
                Logger.Write($"There are no driver in the context: {e}");
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