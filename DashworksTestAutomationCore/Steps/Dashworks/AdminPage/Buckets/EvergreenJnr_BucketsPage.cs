using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.RuntimeVariables.Buckets;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Providers;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BucketsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BucketsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User updates the ""(.*)"" checkbox state")]
        public void WhenUserUpdatesTheCheckboxState(string checkbox)
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.GetDefaultCheckboxByName(checkbox).Click();
        }

        [Then(@"following Objects are displayed in Buckets table:")]
        public void ThenFollowingObjectsAreDisplayedInBuckets(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualRowList = page.RowsList.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedRowList, actualRowList, "Buckets lists are different");
        }

        [Then(@"User sees Buckets in next default sort order:")]
        public void ThenUserSeesBuketsInNextDefaultSortOrder(Table buckets)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < buckets.RowCount; i++)
                Verify.That(page.GridBucketsNames[i].Text, Is.EqualTo(buckets.Rows[i].Values.FirstOrDefault()),
                    "Buckets are not the same");
        }

        [Then(@"Delete ""(.*)"" Bucket in the Administration")]
        [When(@"User deletes ""(.*)"" Bucket in the Administration")]
        public void ThenDeleteBucketInTheAdministration(string bucketName)
        {
            //var projectId = DatabaseHelper.ExecuteReader($"SELECT [ProjectID] FROM[PM].[dbo].[Projects] where[ProjectName] = '{projectName}'", 0)[0];
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectGroups] where [GroupName] = '{bucketName}'");
        }
    }
}