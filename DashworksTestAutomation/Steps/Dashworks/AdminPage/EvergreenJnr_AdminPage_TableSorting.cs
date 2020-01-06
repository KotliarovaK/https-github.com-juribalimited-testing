using System;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    class EvergreenJnr_AdminPage_TableSorting : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_TableSorting (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"data in table is sorted by ""(.*)"" column in ascending order by default on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();

            var actualList = adminTable.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            Verify.IsFalse(adminTable.AscendingSortingIcon.Displayed(), $"Sorting order ion should not be displayed for default sorting in the '{columnName}' column");
        }

        [Then(@"data in table is sorted by ""(.*)"" column in descending order by default on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();

            var expectedList = adminTable.GetColumnContentByColumnName(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            Verify.IsFalse(adminTable.DescendingSortingIcon.Displayed(), $"Sorting order ion should not be displayed for default sorting in the '{columnName}' column");
        }
    }
}
