using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    class EvergreenJnr_AdminPage_PageActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_PageActions (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"""(.*)"" page is displayed to the user on Admin page")]
        public void ThenPageIsDisplayedToTheUserOnAdminPage(string pageName)
        {
            var page = _driver.NowAtWithoutWait<BaseGridPage>();
            Assert.IsTrue(page.GetOpenedPageByName(pageName).Displayed(), $"{pageName} page is not loaded");
        }
    }
}
