using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class BaseSelfServiceEndUserComponent : SpecFlowContext
    {
            
        private readonly RemoteWebDriver _driver;
            public BaseSelfServiceEndUserComponent(RemoteWebDriver driver)
            {
                _driver = driver;
            }

        [Then(@"User sees component with '(.*)' name placed on '(.*)' position")]
        public void ThenUserSeesComponentWithNameOnEndUserPageOnPosition(string componentName, int order)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            Verify.IsTrue(page.СheckThatComponentIsDisplayedOnEndUserPage(componentName, order), "Self Service Tools Panel is missing");
        }

    }
}
