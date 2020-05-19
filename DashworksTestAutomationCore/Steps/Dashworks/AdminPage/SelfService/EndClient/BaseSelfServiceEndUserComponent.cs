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

            var expectedFirstColumnsList = table.GetDataByKey("FirstColumn");
            var expectedSecondColumnList = table.GetDataByKey("SecondColumn");

            var actualFirstColumnList = component.FindElements(By.XPath(".//li/span[1]")).Select(x => x.Text).ToList();
            var actualSecondColumnList = component.FindElements(By.XPath(".//li/span[2]")).Select(x => x.Text).ToList();

            Verify.AreEqual(expectedFirstColumnsList, actualFirstColumnList, $"Incorrect column items for '{сomponentName}' application ownership component on '{pageName}' end user page");
            Verify.AreEqual(expectedSecondColumnList, actualSecondColumnList, $"Incorrect values items for '{сomponentName}' application ownership component on '{pageName}' end user page");
        }

        [Then(@"User sees error message '(.*)' for '(.*)' component on end user page")]
        public void ThenUserSeesComponentErrorMessageWithReason(string expectedErrorMessage, string componentName)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.AreEqual(expectedErrorMessage, page.GetComponenErrorMessageOnEndUserPage(componentName), $"Component '{componentName}' error message mismatch");
        }
    }
}