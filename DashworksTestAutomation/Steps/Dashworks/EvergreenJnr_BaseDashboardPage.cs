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

        [Then(@"Columns is displayed to user in following order")]
        public void ThenColumnsIsDisplayedToUserInFollowingOrder(Table table)
        {
            List<string> columnnNames = new List<string>();
            List<string> expectedList = new List<string>();
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var column in page.GetColumnHeadersNames())
            {
                columnnNames.Add(column.Text);
            }
            foreach (var row in table.Rows)
            {
                expectedList.AddRange(row.Values);
            }
            Assert.AreEqual(expectedList, columnnNames, "Column headers order is uncorrect");
        }
    }
}