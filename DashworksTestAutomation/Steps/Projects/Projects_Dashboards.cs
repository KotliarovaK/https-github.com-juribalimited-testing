using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.Projects_Dashboards;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_Dashboards : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Projects_Dashboards(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User select ""(.*)"" Project on toolbar")]
        public void WhenUserSelectProjectOnToolbar(string projectName)
        {
            var page = _driver.NowAt<Projects_DashboardsPage>();
            _driver.WaitForDataLoading();
            page.ProjectDropDown.Click();
            page.GetProjectByNameOnToolbar(projectName);
        }

        [When(@"User navigate to ""(.*)"" group")]
        public void WhenUserNavigateToGroup(string groupName)
        {
            var group = _driver.NowAt<Projects_DashboardsPage>();
            group.GetGroupInTableByName(groupName);
        }

        [Then(@"content for the ""(.*)"" group is displayed correctly")]
        public void ThenContentForTheGroupIsDisplayedCorrectly(string groupName)
        {
            var page = _driver.NowAt<Projects_DashboardsGroupsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetPageHeaderByGroupName(groupName).Displayed, "Selected Group is not displayed");
            Assert.IsTrue(page.Table.Displayed, "Table for selected group is not loaded");
        }
    }
}
