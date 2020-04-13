using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder
{
    [Binding]
    class ParentPageLabel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ParentPageLabel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"'(.*)' label with self service parent page name is displayed")]
        public void ThenLabelWithSelfServiceParentPageNameIsDisplayed(string parentPageName)
        {
            var page = _driver.NowAt<SelfServiceBaseComponents>();
            Verify.IsTrue(page.IsPageNameDisplayed(parentPageName),
                $"Incorrect parent page name is displayed. Expected: {parentPageName}");
        }
    }
}
