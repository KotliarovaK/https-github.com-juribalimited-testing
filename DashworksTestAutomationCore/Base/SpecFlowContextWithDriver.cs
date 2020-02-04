using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomationCore.Base
{
    [Binding]
    public class SpecFlowContextWithDriver : SpecFlowContext
    {
        protected readonly RemoteWebDriver Driver;

        public SpecFlowContextWithDriver(RemoteWebDriver driver)
        {
            Driver = driver;
        }
    }
}
