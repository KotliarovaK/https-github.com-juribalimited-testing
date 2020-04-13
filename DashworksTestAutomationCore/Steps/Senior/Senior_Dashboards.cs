using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks;
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
        private readonly DTO.RuntimeVariables.Projects _projects;

        public Projects_Dashboards(RemoteWebDriver driver, DTO.RuntimeVariables.Projects projects)
        {
            _driver = driver;
            _projects = projects;
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
            Verify.IsTrue(page.GetPageHeaderByGroupName(groupName).Displayed, "Selected Group is not displayed");
            Verify.IsTrue(page.Table.Displayed, "Table for selected group is not loaded");
        }

        [When(@"User creates new Project on Senior")]
        public void WhenUserCreatesNewProjectOnSenior(Table table)
        {
            var page = _driver.NowAt<ProjectPropertiesPage>();
            foreach (var row in table.Rows)
            {
                page.ProjectName.SendKeys(row["ProjectName"]);
                page.ProjectShortName.SendKeys(row["ShortName"]);
                if (!string.IsNullOrEmpty(row["Description"]))
                    page.ProjectDescription.SendKeys(row["Description"]);
                if (!string.IsNullOrEmpty(row["Type"]))
                    page.ProjectType.SelectboxSelect(row["Type"]);

                _projects.Value.Add(row["ProjectName"]);
            }

            var tab = _driver.NowAt<MainElementsOfProjectCreation>();
            tab.CreatedProjectButton.Click();
            //[YT] added thread sleep since we have max 30 sec delay between senior and evergreen
            Thread.Sleep(10000);
        }

        [When(@"User updates Project Name to ""(.*)"" on Senior")]
        public void WhenUserUpdatesProjectNameToOnSenior(string projectName)
        {
            var page = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoadingOnProjects();
            page.ProjectName.Clear();
            page.ProjectName.SendKeys(projectName);

            _projects.Value.Add(projectName);
        }

        [When(@"User updates Project Short Name to ""(.*)"" on Senior")]
        public void WhenUserUpdatesProjectShortNameToOnSenior(string shortProjectName)
        {
            var page = _driver.NowAt<DetailsPage>();
            page.ProjectShortName.Clear();
            page.ProjectShortName.SendKeys(shortProjectName); ;
        }

        [Then(@"CC email field is displayed with ""(.*)"" text on Senior")]
        public void ThenCсEmailFieldIsDisplayedWithTextOnSenior(string emailText)
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(page.GetTextInCcEmailAddressField(emailText).Displayed(),
                $"Email with '{emailText}' text is not displayed");
        }

        [Then(@"BCC email field is displayed with ""(.*)"" text on Senior")]
        public void ThenBCсEmailFieldIsDisplayedWithTextOnSenior(string emailText)
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(page.GetTextInBccEmailAddressField(emailText).Displayed(),
                $"Email with '{emailText}' text is not displayed");
        }

        [When(@"User clears the CC email field on Senior")]
        public void WhenUserClearsTheCсEmailFieldOnSenior()
        {
            var page = _driver.NowAt<DetailsPage>();
            page.CcEmail.Clear();
        }

        [When(@"User clears the BCC email field on Senior")]
        public void WhenUserClearsTheBссEmailFieldOnSenior()
        {
            var page = _driver.NowAt<DetailsPage>();
            page.BccEmail.Clear();
        }

        [Then(@"CC email field on Senior is empty")]
        public void ThenCсEmailFieldOnSeniorIsEmpty()
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsEmpty(page.CcEmail.GetAttribute("value"), "CC email field is not empty");
        }

        [Then(@"BCC email field on Senior is empty")]
        public void ThenBссEmailFieldOnSeniorIsEmpty()
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsEmpty(page.BccEmail.GetAttribute("value"), "BCC email field is not empty");
        }

        [When(@"User selects ""(.*)"" as Task Value Type")]
        public void WhenUserSetsTaskValueTypeOnSenior(string valueType)
        {
            var page = _driver.NowAt<TaskPropertiesPage>();
            if (!string.IsNullOrEmpty(valueType))
                page.ValueType.SelectboxSelect(valueType);
        }

        [Then(@"Next items are displayed as options of Object Type property:")]
        public void ThenNextItemsAreDisplayedAsPropertyOptions(Table table)
        {
            var action = _driver.NowAt<TaskPropertiesPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Thread.Sleep(500);
            var actualList = action.OptionsOfObjectTypeProperty.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList, "Items are different");
        }
    }
}