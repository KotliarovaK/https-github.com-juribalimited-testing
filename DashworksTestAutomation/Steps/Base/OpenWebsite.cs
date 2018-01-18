using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Base
{
    [Binding]
    internal class OpenWebsite : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public OpenWebsite(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I have opened Juriba website")]
        public void GivenIHaveOpenedJuribaWebsite()
        {
            _driver.Navigate().GoToUrl(UrlProvider.Url);
        }
    }
}