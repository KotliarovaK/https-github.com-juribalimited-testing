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
        public void BeforeTestRun()
        {
            if (!Browser.RemoteDriver.Equals("local"))
                BambooUtil.GetAllQuarantinedTests();
        }

        [BeforeScenario]
        public void OnStartUp()
        {
            //try
            //{
            //    if (string.IsNullOrEmpty(BambooProvider.BuildKey))
            //        return;

            //    var projAndBuild = $"{BambooProvider.ProjectKey}-{BambooProvider.BuildKey}";
            //    var client = new RestClient
            //    {
            //        BaseUrl = new Uri(BambooProvider.BaseUrl),
            //        Authenticator = new HttpBasicAuthenticator(BambooProvider.Username, BambooProvider.Password)
            //    };

            //    var request = new RestRequest(Method.GET) {Resource = $"/browse/{projAndBuild}"};
            //    request.AddHeader("Accept", "application/json");
            //    request.AddHeader("Content-Type", "application/json; charset=utf-8");
            //    request.RequestFormat = DataFormat.Json;
            //    IRestResponse response = client.Execute(request);

            //    #region Get previous build ID

            //    HtmlDocument doc = new HtmlDocument();
            //    string html = response.Content;
            //    doc.LoadHtml(html);
            //    var buildIdElement = doc.DocumentNode.SelectNodes("//a[@class='statusIndicator']");
            //    var prevBuildId = int.Parse(buildIdElement.First().GetAttributeValue("href", null).Split('/').Last().Split('-').Last()) - 1;

            //    #endregion

            //    #region Get all quarantined Tests 

            //    request = new RestRequest(Method.GET) {Resource = $"/browse/{projAndBuild}-{prevBuildId}/test"};
            //    request.AddHeader("Accept", "application/json");
            //    request.AddHeader("Content-Type", "application/json; charset=utf-8");
            //    request.RequestFormat = DataFormat.Json;
            //    response = client.Execute(request);

            //    html = response.Content;
            //    doc.LoadHtml(html);

            //    var quarantinedTests =
            //        doc.DocumentNode.SelectNodes("//table[@id='skipped-tests']//a[@class='test-name']");

            //    List<KeyValuePair<string, string>> testIdsWithNames = new List<KeyValuePair<string, string>>();
            //    foreach (HtmlNode node in quarantinedTests)
            //    {
            //        var id = node.GetAttributeValue("href", null).Split('/').Last();
            //        var name = node.InnerText;
            //        testIdsWithNames.Add(new KeyValuePair<string, string>(id, name));
            //    }

            //    #endregion

            //    foreach (KeyValuePair<string, string> pair in testIdsWithNames)
            //    {
            //        request = new RestRequest(Method.POST)
            //        {
            //            Resource = $"/rest/api/latest/plan/{projAndBuild}-{prevBuildId + 1}/test/{pair.Key}/unleash"
            //        };
            //        request.AddHeader("Accept", "application/json");
            //        request.AddHeader("Content-Type", "application/json; charset=utf-8");

            //        request.RequestFormat = DataFormat.Json;

            //        response = client.Execute(request);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            List<string> testTags = TestContext.CurrentContext.Test.Properties["Category"].Select(x => x.ToString()).ToList();
            LockCategory.AwaitTags(testTags);
            LockCategory.AddTags(testTags);

            var driverInstance = CreateBrowserDriver();

            if (!Browser.RemoteDriver.Equals("local"))
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
                    var testStatus = GetTestStatus();
                    if (!string.IsNullOrEmpty(testStatus) && testStatus.Equals("Failed"))
                    {
                        var testName = GetTestName();
                        if (!string.IsNullOrEmpty(testName))
                            driver.CreateScreenshot(testName);
                    }
                    else
                    {
                        BambooUtil.UnleashTest(GetTestName());
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