using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    //ONLY actions with BaseHeaderPage !!!
    [Binding]
    class EvergreenJnr_BaseHeader : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseHeader(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"'(.*)' page header is displayed to the User")]
        public void ThenPageHeaderIsDisplayedToTheUser(string expectedHeader)
        {
            var headerElement = _driver.NowAtWithoutWait<BaseHeaderPage>();
            Verify.AreEqual(expectedHeader, headerElement.Header.Text, 
                $"Header '{expectedHeader}' is not displayed");
        }
    }
}
