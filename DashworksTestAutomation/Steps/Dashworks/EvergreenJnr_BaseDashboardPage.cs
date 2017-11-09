using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_BaseDashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseDashboardPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User have opened column settings for ""(.*)"" column")]
        public void WhenUserHaveOpenedColumnSettingsForColumn(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.OpenColumnSettingsByName(columnName);
        }

        [When(@"User have select ""(.*)"" option from column settings")]
        public void WhenUserHaveSelectOptionFromColumnSettings(string settingName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetSettingButtonByName(settingName).Click();
        }

        [Then(@"""(.*)"" column is ""(.*)"" Pinned")]
        public void ThenColumnIsPinned(string columnName, string pinStatus)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.AreEqual(columnName, page.GetPinnedColumnName(pinStatus), "Column is pinned incorrectly");
        }
    }
}