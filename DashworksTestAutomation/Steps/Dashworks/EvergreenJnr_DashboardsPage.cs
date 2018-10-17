using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_DashboardsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_DashboardsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks ""(.*)"" section from ""(.*)"" circle chart on Dashboards page")]
        public void WhenUserClicksSectionFromChartOnDashboardsPage(string sectionName, string chartName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();
            page.ClickSectionFromCircleChart(chartName, sectionName);
        }
    }
}