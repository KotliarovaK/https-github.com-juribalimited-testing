using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class BaseSelfServiceEndUserComponent : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly SelfServicePages _selfServicePages;

        public BaseSelfServiceEndUserComponent(RemoteWebDriver driver, SelfServicePages selfServicePages)
        {
            _driver = driver;
            _selfServicePages = selfServicePages;
        }

        [Then(@"User sees following items for '(.*)' application ownership component on '(.*)' end user page")]
        public void ThenUserSeesFollowingItemsForApplicationOwnershipComponentOnEndUserPage(string сomponentName, string pageName, Table table)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var selfServicePage = _selfServicePages.Value.First(x => x.Name.Equals(pageName));
            var component = page.GetComponentItemOnEndUserPage(selfServicePage, сomponentName);

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = component.FindElements(By.XPath(".//span")).Select(x => x.Text).ToList();

            Verify.AreEqual(expectedList, actualList, $"Incorrect items for '{сomponentName}' application ownership component on '{pageName}' end user page");
        }
    }
}