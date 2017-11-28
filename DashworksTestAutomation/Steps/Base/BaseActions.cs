using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Base
{
    [Binding]
    class BaseActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public BaseActions(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User click back button in the browser")]
        public void ThenUserClickBackButtonInTheBrowser()
        {
            _driver.Navigate().Back();
        }
    }
}