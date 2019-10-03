using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Buckets
{
    [Binding]
    public class AddBucketsToTeam : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public AddBucketsToTeam(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User expands '(.*)' multiselect and selects following Buckets")]
        public void WhenUserExpandsMultiselectAndSelectsFollowingBuckets(string multiselectTitle, Table table)
        {
            var itemsToAdd = table.Rows.Select(x => x["Objects"]).ToList();
            var basePage = _driver.NowAt<BaseDashboardPage>();
            basePage.ExpandCollapseMultiselectButton(multiselectTitle).Click();
            basePage.AddItemsToMultiSelect(itemsToAdd);

            //Save added objects to remove it from the bucket
            foreach (string s in itemsToAdd)
            {
                //TODO implement store Buckets functionality.
                //TODO currently it is in DeleteNewlyCreatedTeam
            }

            basePage.GetButtonByName("ADD BUCKETS").Click();
        }
    }
}
