using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    class EvergreenJnr_BaseTable : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseTable(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"table is displayed")]
        public void ThenTableIsDisplayed()
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsTrue(page.Table.Displayed(), "Table is not displayed");

        }
    }
}
