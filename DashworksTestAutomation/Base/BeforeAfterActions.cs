using BoDi;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;
using System.Reflection;
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
            this._objectContainer = objectContainer;
            this._scenarioContext = scenarioContext;
        }

        [BeforeScenario()]
        public void OnStartUp()
        {
            var driverInstance = CreateBrowserDriver();

            driverInstance.Manage().Window.Maximize();

            _objectContainer.RegisterInstanceAs<RemoteWebDriver>(driverInstance);
        }

        [AfterScenario()]
        public void OnTearDown()
        {
            try
            {
                var driver = _objectContainer.Resolve<RemoteWebDriver>();
                var testStatus = GetTestStatus();
                if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("TestError"))
                {
                    var testName = GetTestName();
                    if (!string.IsNullOrEmpty(testName))
                        driver.CreateScreenshot(testName);
                }

                Logger.Write($"Closing window at: {driver.Url}");

                driver.QuitDriver();
            }
            catch (ObjectContainerException)
            {
                //There are no driver in the context
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
            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            object testResult = getter.Invoke(_scenarioContext, null);
            var testResults = testResult.ToString();
            return testResults;
        }

        private string GetTestName()
        {
            var testName = _scenarioContext.ScenarioInfo.Title;
            return testName;
        }
    }
}