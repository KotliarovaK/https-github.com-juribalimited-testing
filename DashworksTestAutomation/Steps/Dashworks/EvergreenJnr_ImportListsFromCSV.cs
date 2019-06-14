using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

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
            Assert.IsTrue(importPage.GetImportPageHeader(pageHeader).Displayed(), $"{pageHeader} Import page is not displayed");
        }
    }
}