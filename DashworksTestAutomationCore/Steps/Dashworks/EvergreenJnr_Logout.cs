using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_Logout : SpecFlowContext
    {
        private RemoteWebDriver _driver;

        public EvergreenJnr_Logout(RemoteWebDriver driver, BrowsersList browsersList)
        {
            _driver = browsersList.GetBrowser();
        }

        [When(@"User clicks the Logout button")]
        public void WhenUserClicksTheLogoutButton()
        {
            var header = _driver.NowAt<HeaderElement>();

            header.LogOut();
        }
    }
}