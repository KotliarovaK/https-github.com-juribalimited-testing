using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Autotest.Steps.Base
{
    [Binding]
    class OpenWebsite : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public OpenWebsite(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I have opened google website")]
        public void GivenIHaveOpenedGoogleWebsite()
        {
            _driver.Navigate().GoToUrl(UrlProvider.Url);
        }
    }
}
