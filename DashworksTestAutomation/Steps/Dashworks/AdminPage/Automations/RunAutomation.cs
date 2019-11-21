using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    public class RunAutomation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public RunAutomation(RemoteWebDriver driver)
        {
            _driver = driver;
        }
         
    }
}
