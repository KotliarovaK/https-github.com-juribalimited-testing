using System.Linq;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage_AfterScenario : TechTalk.SpecFlow.Steps
    {
        private readonly RemoteWebDriver _driver;
        private readonly AddedObjects _addedObjects;

        public EvergreenJnr_AdminPage_AfterScenario(AddedObjects addedObjects, RemoteWebDriver driver)
        {
            _addedObjects = addedObjects;
            _driver = driver;
        }

        [AfterScenario("Remove_Added_Objects_From_Buckets")]
        public void RemoveAddedObjectsFromBuckets()
        {
            try
            {
                var allBuckets = _addedObjects.Value.Values.Distinct().ToList();

                if (!allBuckets.Any())
                    return;

                When("User clicks Admin on the left-hand menu");
                When($"User clicks \"{"Buckets"}\" link on the Admin page");
                When("User clicks Reset Filters button on the Admin page");
                foreach (var bucketName in allBuckets)
                {
                    When($"User enters \"{bucketName}\" text in the Search field for \"{"Bucket"}\" column");
                    When($"User clicks content from \"{"Bucket"}\" column");

                    MoveObject("Devices", bucketName, "Hostname");

                    MoveObject("Users", bucketName, "Username");

                    MoveObject("Mailboxes", bucketName, "Email Address (Primary)");
                }
            }
            catch
            {
            }
        }

        private void MoveObject(string sectionName, string bucketName, string columnName)
        {
            When($"User clicks \"{sectionName}\" tab");

            var gridPage = _driver.NowAt<BaseGridPage>();
            var selectedObjects = 0;
            //Select all objects that should be moved
            foreach (var objectName in _addedObjects.Value.Where(x => x.Value.Equals(bucketName)).Select(x => x.Key))
            {
                if (gridPage.NoObjectsMessage.Displayed())
                    break;
                When($"User enters \"{objectName}\" text in the Search field for \"{columnName}\" column");
                When("User selects all rows on the grid");
                selectedObjects++;
            }

            if (selectedObjects == 0) return;
            When("User clicks on Actions button");
            When($"User selects \"{"Move To Another Bucket"}\" in the Actions");
            gridPage = _driver.NowAt<BaseGridPage>();
            if (!gridPage.ContinueButton.Displayed()) return;
            gridPage.ContinueButton.Click();

            var moveToAnotherBucketPage = _driver.NowAt<MoveToAnotherBucketPage>();
            var firstBucket = _driver
                .GetOptionsFromMatSelectbox(moveToAnotherBucketPage.BucketSelectbox)
                .First().Text;
            _driver.SelectMatSelectbox(moveToAnotherBucketPage.BucketSelectbox, firstBucket);
            moveToAnotherBucketPage.MoveButton.Click();
        }
    }
}