using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_Actions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_Actions(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Actions button")]
        public void WhenUserClicksActionsButton()
        {
            var menu = _driver.NowAt<BaseDashbordPage>();
            menu.Actions.Click();
            Logger.Write("Actions button was clicked");
        }

        [When(@"User select all rows")]
        public void WhenUserSelectAllRows()
        {
            var dashboardPage = _driver.NowAt<BaseDashbordPage>();
            dashboardPage.SelecAllCheckbox.Click();
        }
    }
}