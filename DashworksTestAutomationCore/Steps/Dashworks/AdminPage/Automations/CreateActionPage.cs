using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class CreateActionPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public CreateActionPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Create Action page is displayed to the User")]
        public void ThenCreateActionPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToHaveText(page.SubHeader, "Create Action");
            Verify.IsTrue(page.IsTextboxDisplayed("Action Name"), 
                "Create Action page is not displayed");
        }
    }
}
