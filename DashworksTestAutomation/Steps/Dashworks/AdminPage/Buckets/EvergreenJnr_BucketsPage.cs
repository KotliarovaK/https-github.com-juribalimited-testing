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
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.RuntimeVariables.Buckets;
using DashworksTestAutomation.Providers;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BucketsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly Buckets _buckets;

        public EvergreenJnr_BucketsPage(RemoteWebDriver driver, Buckets buckets)
        {
            _driver = driver;
            _buckets = buckets;
        }

        [Then(@"Bucket dropdown is not displayed on the Project details page")]
        public void ThenBucketDropdownIsNotDisplayedOnTheProjectDetailsPage()
        {
            var projectPage = _driver.NowAt<ProjectsPage>();
            Assert.IsFalse(projectPage.BucketDropdown.Displayed(), "Bucket dropdown is displayed");
        }

        [Then(@"Add Buckets page is displayed to the user")]
        public void ThenAddBucketsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddBucketToTeamPage>();
            Assert.IsTrue(page.PageTitle.Displayed(), "Add Buckets page is not displayed");
        }

        [Then(@"Reassign Buckets page is displayed to the user")]
        public void ThenReassignBucketsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ReassignBucketsPage>();
            Assert.IsTrue(page.PageReassignBucketsTitle.Displayed(), "Reassign Buckets page is not displayed");
        }

        [When(@"User selects ""(.*)"" in the Select a team dropdown")]
        public void WhenUserSelectsInTheSelectATeamDropdown(string teamName)
        {
            var page = _driver.NowAt<ReassignBucketsPage>();
            page.SelectTeamDropdown.Click();
            _driver.WaitForDataLoading();
            page.SelectTeamToReassign(teamName);
        }

        [When(@"User expands ""(.*)"" project to add bucket")]
        public void WhenUserExpandsProjectToAddBucket(string projectName)
        {
            var teamElement = _driver.NowAt<AddBucketToTeamPage>();
            teamElement.ExpandProjectByName(projectName).Click();
        }

        [Then(@"Default Bucket checkbox is selected")]
        public void ThenDefaultBucketCheckboxIsSelected()
        {
            var page = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(page.SelectedDefaultBucketCheckbox.Displayed(), "Default Bucket checkbox is not selected");
        }

        [When(@"User clicks ""(.*)"" tab on the Buckets page")]
        public void WhenUserClicksTabOnTheBucketsPage(string tabName)
        {
            var tab = _driver.NowAt<BucketsPage>();
            tab.ClickTabByName(tabName);
        }

        [When(@"User adds ""(.*)"" objects to bucket")]
        public void WhenUserAddsObjectsToBucket(string objectName)
        {
            var objects = _driver.NowAt<BucketsPage>();
            objects.SearchFieldForBucketsPage.SendKeys(objectName);
            objects.SelectObjectByName(objectName).Click();
        }

        [When(@"User selects ""(.*)"" team in the Team dropdown on the Buckets page")]
        public void ThenUserSelectTeamInTheTeamDropdownOnTheBucketsPage(string teamName)
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.TeamsNameField.Clear();
            _driver.WaitForDataLoading();
            createBucketElement.TeamsNameField.SendKeys(teamName);
            createBucketElement.SelectTeam(teamName);
            _buckets.Value.Last().TeamName = teamName;
        }

        [When(@"User updates the ""(.*)"" checkbox state")]
        public void WhenUserUpdatesTheCheckboxState(string checkbox)
        {
            var createBucketElement = _driver.NowAt<CreateBucketPage>();
            createBucketElement.GetDefaultCheckboxByName(checkbox).Click();
        }

        [Then(@"""(.*)"" bucket details is displayed to the user")]
        public void ThenBucketDetailsIsDisplayedToTheUser(string bucketName)
        {
            var teamElement = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(teamElement.AppropriateBucketName(bucketName),
                $"{bucketName} is not displayed on the Bucket page");
        }

        [Then(@"Move To Another Bucket Page is displayed to the user")]
        public void ThenMoveToAnotherBucketPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<MoveToAnotherBucketPage>();
            Assert.IsTrue(page.MoveToSelectBox.Displayed, "Move To Another Bucket Page is not displayed to the user");
        }

        [When(@"User moves selected objects to ""(.*)"" Capacity Unit")]
        [When(@"User moves selected objects to ""(.*)"" bucket")]
        public void WhenUserMovesSelectedObjectsToBucket(string bucketName)
        {
            var page = _driver.NowAt<MoveToAnotherBucketPage>();
            page.MoveToBucketByName(bucketName);
        }

        [Then(@"Bucket ""(.*)"" is displayed to user")]
        public void ThenBucketIsDisplayedToUser(string bucketName)
        {
            var page = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(page.ActiveBucketByName(bucketName), $"{bucketName} is not displayed on the Buckets page");
        }

        [Then(@"No items text is displayed")]
        public void ThenNoItemsTextIsDisplayed()
        {
            var text = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(text.NoItemsMessage.Displayed, "No items text is not displayed");
        }

        [When(@"User clicks Update Bucket button on the Buckets page")]
        public void WhenUserClicksUpdateBucketButtonOnTheBucketsPage()
        {
            var button = _driver.NowAt<BucketsPage>();
            button.UpdateBucketButton.Click();
        }

        [Then(@"following Objects are displayed in Buckets table:")]
        public void ThenFollowingObjectsAreDisplayedInBuckets(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualRowList = page.RowsList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedRowList, actualRowList, "Buckets lists are different");
        }

        [Then(@"User sees Buckets in next default sort order:")]
        public void ThenUserSeesBuketsInNextDefaultSortOrder(Table buckets)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            for (var i = 0; i < buckets.RowCount; i++)
                Assert.That(page.GridBucketsNames[i].Text, Is.EqualTo(buckets.Rows[i].Values.FirstOrDefault()),
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