using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    //ONLY actions with BaseHeaderElement !!!
    [Binding]
    class EvergreenJnr_BaseHeader : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseHeader(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Page with '(.*)' header is displayed to user")]
        public void ThenPageWithHeaderIsDisplayedToUser(string pageTitle)
        {
            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(pageTitle);
        }

        [When(@"User clicks '(.*)' header breadcrumb")]
        public void WhenUserClicksHeaderBreadcrumb(string breadcrumb)
        {
            var header = _driver.NowAt<BaseHeaderElement>();
            header.ClickBreadcrumb(breadcrumb);
        }
    }
}
