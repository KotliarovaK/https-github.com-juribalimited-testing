using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    //TODO mb we do not need this. Or just check rows count in the grid
    public class EvergreenJnr_BaseGridHeader : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseGridHeader(RemoteWebDriver driver)
        {
            _driver = driver;
        }
    }
}
