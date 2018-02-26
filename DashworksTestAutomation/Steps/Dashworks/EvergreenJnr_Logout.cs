using System.Collections;
using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_Logout : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_Logout(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks the Logout button")]
        public void WhenUserClicksTheLogoutButton()
        {
            var header = _driver.NowAt<HeaderElement>();

            header.LogOut();
        }
    }
}