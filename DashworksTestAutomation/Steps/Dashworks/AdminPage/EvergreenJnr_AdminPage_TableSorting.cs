using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
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

        [Then(@"data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var actualList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
            Assert.IsTrue(adminTable.AscendingSortingIcon.Displayed);
        }

        [Then(@"data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Assert.IsTrue(adminTable.DescendingSortingIcon.Displayed);
        }

        [Then(@"data in table is sorted by ""(.*)"" column in ascending order by default on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInAscendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var actualList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(actualList);
            _driver.WaitForDataLoading();
        }

        [Then(@"data in table is sorted by ""(.*)"" column in descending order by default on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
        }

        [Then(@"numeric data in ""(.*)"" column is sorted in ascending order by default on the Admin page")]
        public void ThenNumericDataInColumnIsSortedInAscendingOrderByDefaultOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
        }

        [Then(@"numeric data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenNumericDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();

            var actualList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(actualList);
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"numeric data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"color data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenColorDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<Colors>(new List<string>(expectedList));
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"color data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenColorDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByEnum<Colors>(new List<string>(expectedList), false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Assert.IsTrue(listPageMenu.AscendingSortingIcon.Displayed);
        }

        [Then(@"date in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Assert.IsTrue(listPageMenu.DescendingSortingIcon.Displayed);
        }


        [Then(@"Boolean data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenBooleanDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Assert.IsTrue(adminTable.AscendingSortingIcon.Displayed);
        }


        [Then(@"Boolean data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenBooleanDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList);
            _driver.WaitForDataLoading();
            Assert.IsTrue(adminTable.DescendingSortingIcon.Displayed);
        }
    }
}
