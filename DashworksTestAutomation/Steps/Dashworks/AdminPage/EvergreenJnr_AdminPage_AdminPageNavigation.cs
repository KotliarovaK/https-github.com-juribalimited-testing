using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_AdminPageNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_AdminPageNavigation (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks ""(.*)"" link on the Admin page")]
        public void WhenUserClicksLinkOnTheAdminPage(string adminLinks)
        {
            var menu = _driver.NowAt<AdminLeftHandMenu>();

            switch (adminLinks)
            {
                case "Projects":
                    menu.Projects.Click();
                    break;

                case "Teams":
                    menu.Teams.Click();
                    break;

                case "Automations":
                    menu.Automations.Click();
                    break;

                case "Evergreen":
                    menu.EvergreenSectionTab.Click();
                    break;

                default:
                    throw new Exception($"'{adminLinks}' link is not valid menu item and can not be opened");
            }

            Logger.Write($"{adminLinks} left-hand menu was clicked");
        }

        [Then(@"""(.*)"" page should be displayed to the user")]
        public void ThenPageShouldBeDisplayedToTheUser(string pageTitle)
        {
            switch (pageTitle)
            {
                case "Projects":
                    var projectsPage = _driver.NowAt<AdminLeftHandMenu>();
                    Utils.Verify.Contains(projectsPage.ProjectsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Teams":
                    var teamsPage = _driver.NowAt<AdminLeftHandMenu>();
                    Utils.Verify.Contains(teamsPage.TeamsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Buckets":
                    var bucketsPage = _driver.NowAt<AdminLeftHandMenu>();
                    Utils.Verify.Contains(bucketsPage.BucketsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Automations":
                    var automationsPage = _driver.NowAt<AdminLeftHandMenu>();
                    Utils.Verify.Contains(automationsPage.Automations.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Capacity Units":
                    var capacityUnitsPage = _driver.NowAt<AdminLeftHandMenu>();
                    Utils.Verify.Contains(capacityUnitsPage.CapacityUnitsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Rings":
                    var ringsPage = _driver.NowAt<AdminLeftHandMenu>();
                    Utils.Verify.Contains(ringsPage.RingsPage.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Project":
                    var createProjectPage = _driver.NowAt<CreateProjectPage>();
                    Utils.Verify.Contains(createProjectPage.CreateProjectFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Team":
                    var createTeamPage = _driver.NowAt<CreateTeamPage>();
                    Utils.Verify.Contains(createTeamPage.CreateTeamFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Evergreen Bucket":
                    var createBucketPage = _driver.NowAt<CreateBucketPage>();
                    Utils.Verify.Contains(createBucketPage.CreateBucketFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Project Capacity Unit":
                    var createProjectCapacityUnitPage = _driver.NowAt<CreateCapacityUnitPage>();
                    Utils.Verify.Contains(createProjectCapacityUnitPage.CreateCapacityUnitTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Evergreen Capacity Unit":
                    var createEvergreenCapacityUnitPage = _driver.NowAt<CreateCapacityUnitPage>();
                    Utils.Verify.Contains(createEvergreenCapacityUnitPage.CreateCapacityUnitTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Ring":
                    var createRingPage = _driver.NowAt<CreateRingPage>();
                    Utils.Verify.Contains(createRingPage.CreateRingFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Create Project Ring":
                    var createProjectRingPage = _driver.NowAt<CreateRingPage>();
                    Utils.Verify.Contains(createProjectRingPage.CreateRingFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Import Project":
                    var importProjectPage = _driver.NowAt<ImportProjectPage>();
                    Utils.Verify.Contains(importProjectPage.ImportProjectFormTitle.Text.ToLower(), pageTitle.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                default:
                    throw new Exception($"'{pageTitle}' menu item is not valid ");
            }

            Logger.Write($"'{pageTitle}' page is visible");
        }

        [When(@"User clicks ""(.*)"" navigation link on the Admin page")]
        public void WhenUserClicksNavigationLinkOnTheAdminPage(string linkName)
        {
            var link = _driver.NowAt<ProjectsPage>();
            link.GetNavigationLinkByName(linkName).Click();
        }

        [When(@"User open ""(.*)"" sub menu on Admin page")]
        public void WhenUserOpenSubMenuOnAdminPage(string menuName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.GetSubMenuByName(menuName).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" tab on the Project details page")]
        public void WhenUserSelectTabOnTheProjectDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            projectTabs.NavigateToProjectTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" tab is selected on the Admin page")]
        public void ThenTabIsSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Utils.Verify.IsTrue(projectTabs.GetsSelectedTabByName(tabName).Displayed(), "Selected tab is not active");
        }

        [Then(@"""(.*)"" tab in Project selected on the Admin page")]
        public void ThenTabInProjectSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Utils.Verify.IsTrue(projectTabs.GetsSelectedTabInProjectByName(tabName).Displayed(), $"'{tabName}' tab is not active");
        }

        [When(@"User selects ""(.*)"" tab on the Capacity Units page")]
        public void WhenUserSelectsTabOnTheCapacityUnitsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            projectTabs.GetTabByNameOnCapacityUnits(tabName).Click();
        }

        [Then(@"""(.*)"" tab is not displayed to the User on Admin Page Navigation")]
        public void ThenTabIsNotDisplayedToTheUserOnAdminPageNavigation(string tabName)
        {
            var page = _driver.NowAt<AdminLeftHandMenu>();
            Utils.Verify.IsFalse(page.Automations.Displayed(), $"{tabName} tab still displayed");
        }
    }
}