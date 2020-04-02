using System;
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

        [Then(@"User sees following items for '(.*)' component on '(.*)' end user page:")]
        public void ThenUserSeesFollowingItemsForComponentOnEndUserPage(string сomponentName, string pageName, Table table)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var selfServicePage = _selfServicePages.Value.First(x => x.Name.Equals(pageName));
            var component = page.GetComponentItemOnEndUserPage(selfServicePage, сomponentName);
            var eachValueInRow = By.XPath(".//span");
            var i = 0;
            
            IList<IWebElement> rowList = component.FindElements(By.XPath(".//li"));
            
            foreach (var row in table.Rows)
            {
                var expectedColumn = row["Column"];
                var expectedValue = row["Value"];

                Verify.IsTrue(
                    rowList[i].FindElements(eachValueInRow).Any(x => x.Text.Equals(expectedColumn)),
                    $"Incorrect items for '{сomponentName}' component on '{pageName}' end user page");
                Verify.IsTrue(
                    rowList[i].FindElements(eachValueInRow).Any(x => x.Text.Equals(expectedValue)),
                    $"Incorrect items for '{сomponentName}' component on '{pageName}' end user page");
                i++;
            }
        }
    }
}