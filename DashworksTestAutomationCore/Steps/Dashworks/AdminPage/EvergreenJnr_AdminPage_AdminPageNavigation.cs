using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_AdminPageNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_AdminPageNavigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"""(.*)"" tab is selected on the Admin page")]
        public void ThenTabIsSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectTabs.GetsSelectedTabByName(tabName).Displayed(), "Selected tab is not active");
        }

        [Then(@"""(.*)"" tab in Project selected on the Admin page")]
        public void ThenTabInProjectSelectedOnTheAdminPage(string tabName)
        {
            var projectTabs = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectTabs.GetsSelectedTabInProjectByName(tabName).Displayed(), $"'{tabName}' tab is not active");
        }

        //User navigates to the 'Applications' tab on Project Scope Changes page
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
            Verify.IsFalse(page.Automations.Displayed(), $"{tabName} tab still displayed");
        }
    }
}