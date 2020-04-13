using System;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.Components;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder.Components
{
    [Binding]
    class AppOwnershipComponentSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public AppOwnershipComponentSteps(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"following fields to display are displayed on application ownership component page")]
        public void ThenFollowingFieldsToDisplayAreDisplayedOnApplicationOwnershipComponentPage(Table table)
        {
            var page = _driver.NowAt<AppOwnershipComponentPage>();
            var expectedFieldsToDisplay = table.Rows.Select(x => x.Values.First()).ToList();
            var actualFieldsToDisplay = page.FieldsToDisplay;

            Verify.AreEqual(expectedFieldsToDisplay.Count(), actualFieldsToDisplay.Count,
                "Incorrect number of Fields to display items");

            //Check content if count more than zero
            if (expectedFieldsToDisplay.Any())
            {
                if (!actualFieldsToDisplay.Any())
                {
                    throw new Exception("Fields to display are not displayed");
                }

                Verify.AreEqual(expectedFieldsToDisplay, actualFieldsToDisplay.Select(x => x.Text), "Incorrect Fields to display are displayed");
            }
        }
    }
}
