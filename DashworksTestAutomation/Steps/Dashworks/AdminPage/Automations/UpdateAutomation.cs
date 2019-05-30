using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class UpdateAutomation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public UpdateAutomation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Edit Automation page is displayed to the User")]
        public void ThenEditAutomationPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EditAutomationPage>();
            Assert.IsTrue(page.EditAutomationTitle.Displayed(), "Edit Automation page is not displayed");
        }
    }
}