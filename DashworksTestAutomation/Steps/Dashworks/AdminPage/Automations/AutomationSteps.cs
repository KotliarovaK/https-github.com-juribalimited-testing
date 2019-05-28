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
    internal class AutomationSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public AutomationSteps(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User selects ""(.*)"" checkbox on the Automation Page")]
        public void WhenUserSelectsCheckboxOnTheAutomationPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<AutomationsPage>();
            checkbox.SelectCheckboxByName(checkboxName).Click();
        }
    }
}
