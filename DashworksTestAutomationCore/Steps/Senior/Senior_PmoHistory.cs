using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Senior;
using DashworksTestAutomation.Providers;
using AutomationUtils.Extensions;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Senior_PmoHistory : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Senior_PmoHistory(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to '(.*)' page of Onboarding on Senior")]
        public void WhenUserNavigateToBulkUpdate(string subMenu)
        {
            var menu = _driver.NowAt<SeniorProjectsBaseElements>();
            _driver.MouseHover(menu.OnboardingTab);
            _driver.MouseHover(menu.GetSubTabByName(subMenu));
            menu.GetSubTabByName(subMenu).Click();
        }

        [When(@"User selects '(.*)' project in Project dropdown")]
        public void WhenUserSelectsProjectInDropdown(string value)
        {
            var page = _driver.NowAt<Projects_PmoHistory>();
            _driver.WaitForDataLoading();
            page.ProjectSelector.SelectboxSelect(value);
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks '(.*)' value in History grid")]
        public void WhenUserClicksValueInHistoryGrid(string value)
        {
            var page = _driver.NowAt<Projects_PmoHistory>();
            _driver.WaitForDataLoading();
            page.GetHistoryValueByName(value).Click();
        }
    }
}