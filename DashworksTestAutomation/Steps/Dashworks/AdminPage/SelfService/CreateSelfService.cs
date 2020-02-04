using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService
{
    [Binding]
    class CreateSelfService
    {
        private readonly RemoteWebDriver _driver;

        public CreateSelfService(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Self Service Details page is displayed correctly")]
        public void ThenSelfServiceDetailsPageIsDisplayedCorrectly()
        {
            var autocompleteElement = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(autocompleteElement.IsTextboxDisplayed("Self Service Name"),
                "Self Service Details page is not displayed correctly");
            Verify.IsTrue(autocompleteElement.IsTextboxDisplayed("Self Service Identifier"),
                "Self Service Details page is not displayed correctly");
            _driver.WaitForElementToHaveText(autocompleteElement.GetTextbox("Self Service Scope"));
            //For the stability of the Self Service's tests
            Thread.Sleep(5000);
        }
    }
}