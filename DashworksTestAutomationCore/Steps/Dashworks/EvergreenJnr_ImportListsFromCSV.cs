using System;
using System.IO;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Providers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_ImportListsFromCSV : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ImportListsFromCSV(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"""(.*)"" Import page is displayed to the User")]
        public void ThenImportPageIsDisplayedToTheUser(string pageHeader)
        {
            var importPage = _driver.NowAt<ImportListsFromCSVPage>();
            Verify.IsTrue(importPage.GetImportPageHeader(pageHeader).Displayed(), $"{pageHeader} Import page is not displayed");
        }

        [When(@"User selects ""(.*)"" file to upload on Import Lists from CSV page")]
        public void WhenUserSelectsFileToUploadOnImportListsFromCSVPage(string fileName)
        {
            var dashboardPage = _driver.NowAt<ImportListsFromCSVPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();

            try
            {
                var file = FileSystemHelper.GeneratePathToEmbeddedResource(fileName,
                    FileSystemHelper.DataFolder.Resources);
                dashboardPage.ChooseFile.SendKeys(file);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to locate file in Resources folder: {e}");
            }
        }
    }
}