using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_PMObject : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Projects_PMObject(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigate to ""(.*)"" tab on PMObject page")]
        public void WhenUserNavigateToTabOnPMObjectPage(string tabName)
        {
            var tab = _driver.NowAt<ProjectsBaseElements>();
            tab.GoToTabByName(tabName);
        }

        [Then(@"Application tab content is displayed correctly")]
        public void ThenApplicationTabContentIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<Projects_PMObjectPage>();
            Assert.IsTrue(page.TabContent.Displayed, "Selected tab is not loaded or displayed incorrectly");
        }

        [When(@"User select ""(.*)"" View State on Applications tab")]
        public void WhenUserSelectViewStateOnApplicationsTab(string viewState)
        {
            var page = _driver.NowAt<Projects_PMObjectPage>();
            _driver.WaitForDataLoading();
            page.ViewState.Click();
            page.GetViewStateByName(viewState);
        }

        [When(@"User select ""(.*)"" View Type on Applications tab")]
        public void WhenUserSelectViewTypeOnApplicationsTab(string viewType)
        {
            var page = _driver.NowAt<Projects_PMObjectPage>();
            _driver.WaitForDataLoading();
            page.ViewType.Click();
            page.GetViewTypeByName(viewType);
        }

        [Then(@"Colour of onboarded app is ""(.*)""")]
        public void ThenColorOfOnboardedAppIs(string colorName)
        {
            var page = _driver.NowAt<Projects_PMObjectPage>();
            var color = page.ColorItem.GetAttribute("title");
            Assert.AreEqual(color, colorName, "Colors for item are different");
        }
    }
}