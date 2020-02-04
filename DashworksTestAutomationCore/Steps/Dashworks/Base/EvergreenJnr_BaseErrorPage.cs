using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    public class EvergreenJnr_BaseErrorPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseErrorPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"error page with '(.*)' status code and '(.*)' error message is displayed")]
        public void ThenErrorPageWithStatusCodeAndErrorMessageIsDisplayed(string statusCode, string errorMessage)
        {
            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader("Oops!");

            var page = _driver.NowAt<BaseErrorPage>();
            page.VerifyStatusCode(statusCode);
            page.VerifyErrorMessage(errorMessage);
        }
    }
}
