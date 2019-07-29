﻿using System;
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
            Utils.Verify.IsTrue(adminTable.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(adminTable.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
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
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"numeric data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenNumericDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var expectedList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsNumericListSorted(expectedList, false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"date in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenDateInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Utils.Verify.IsTrue(listPageMenu.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"date in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenDateInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var listPageMenu = _driver.NowAt<BaseDashboardPage>();
            var originalList = listPageMenu.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSortedByDate(originalList, false);
            Utils.Verify.IsTrue(listPageMenu.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }


        [Then(@"Boolean data in table is sorted by ""(.*)"" column in ascending order on the Admin page")]
        public void ThenBooleanDataInTableIsSortedByColumnInAscendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList, false);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(adminTable.AscendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }


        [Then(@"Boolean data in table is sorted by ""(.*)"" column in descending order on the Admin page")]
        public void ThenBooleanDataInTableIsSortedByColumnInDescendingOrderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();

            var expectedList = adminTable.GetColumnContent(columnName).Where(x => !x.Equals("")).ToList();
            SortingHelper.IsListSorted(expectedList);
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(adminTable.DescendingSortingIcon.Displayed, "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Data in table is sorted by ""(.*)"" column in the next way")]
        public void ThenDataInTableIsSortedInTheNextWay(string columnName, Table table)
        {
            var adminTable = _driver.NowAt<BaseDashboardPage>();
            var actualList = adminTable.GetColumnContent(columnName).Distinct().ToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).Where(x => !x.Equals(String.Empty)).ToList();

            Utils.Verify.That(expectedList, Is.EqualTo(actualList));
        }
    }
}
