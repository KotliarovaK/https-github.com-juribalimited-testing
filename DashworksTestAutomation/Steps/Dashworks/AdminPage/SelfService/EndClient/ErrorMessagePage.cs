using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class ErrorMessagePage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ErrorMessagePage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"self service error page with '(.*)' text is displayed for end client")]
        public void ThenSelfServiceErrorPageWithTextIsDisplayedForEndClient(string text)
        {
            var epage = _driver.NowAt<SelfServiceEndClientErrorPage>();
            Verify.IsTrue(epage.ErrorPageIsDisplayed(text),
                $"Self service error page with '{text}' text is not displayed for end client");
        }
    }
}
