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
            }
            var tab = _driver.NowAt<MainElementsOfProjectCreation>();
            tab.CreatedProjectButton.Click();
        }

        [When(@"User updates Project Name to ""(.*)"" on Senior")]
        public void WhenUserUpdatesProjectNameToOnSenior(string projectName)
        {
            var page = _driver.NowAt<DetailsPage>();
            page.ProjectName.Clear();
            page.ProjectName.SendKeys(projectName);
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
            Assert.IsTrue(page.GetTextInCcEmailAddressField(emailText).Displayed(),
                $"Email with '{emailText}' text is not displayed");
        }

        [Then(@"BCC email field is displayed with ""(.*)"" text on Senior")]
        public void ThenBCсEmailFieldIsDisplayedWithTextOnSenior(string emailText)
        {
            var page = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(page.GetTextInBccEmailAddressField(emailText).Displayed(),
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
            Assert.IsEmpty(page.CcEmail.GetAttribute("value"), "CC email field is not empty");
        }

        [Then(@"BCC email field on Senior is empty")]
        public void ThenBссEmailFieldOnSeniorIsEmpty()
        {
            var page = _driver.NowAt<DetailsPage>();
            Assert.IsEmpty(page.BccEmail.GetAttribute("value"), "BCC email field is not empty");
        }

        [When(@"User creates new Task on Senior")]
        public void WhenUserCreatesNewTaskOnSenior(Table table)
        {
            var page = _driver.NowAt<TaskPropertiesPage>();
            foreach (var row in table.Rows)
            {
                page.Name.SendKeys(row["Name"]);
                page.Help.SendKeys(row["Help"]);
                page.StageName.SelectboxSelect(row["StagesName"]);
                if (!string.IsNullOrEmpty(row["TaskType"]))
                    page.TaskType.SelectboxSelect(row["TaskType"]);
                if (!string.IsNullOrEmpty(row["ValueType"]))
                    page.ValueType.SelectboxSelect(row["ValueType"]);
                _driver.WaitForDataLoadingOnProjects();
                page.ObjectType.SelectboxSelect(row["ObjectType"]);
                if (!string.IsNullOrEmpty(row["TaskValuesTemplate"]))
                    page.TaskValuesTemplate.SelectboxSelect(row["TaskValuesTemplate"]);
                page.ConfirmCreateTaskButton.Click();
            }
        }
    }
}