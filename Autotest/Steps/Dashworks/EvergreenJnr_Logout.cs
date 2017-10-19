using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.DTO;
using Autotest.Extensions;
using Autotest.Pages.Evergreen;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Autotest.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_Logout : SpecFlowContext
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
