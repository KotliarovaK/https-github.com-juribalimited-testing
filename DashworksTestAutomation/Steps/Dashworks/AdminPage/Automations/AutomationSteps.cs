using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
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
            var checkbox = _driver.NowAt<CreateAutomationsPage>();
            checkbox.SelectCheckboxByName(checkboxName).Click();
        }

        [When(@"User type ""(.*)"" Name in the ""(.*)"" field on the Automation details page")]
        public void WhenUserTypeNameInTheFieldOnTheProjectDetailsPage(string text, string fieldName)
        {
            var page = _driver.NowAt<ProjectsPage>();

            page.GetFieldByName(fieldName).ClearWithBackspaces();
            page.GetFieldByName(fieldName).SendKeys(text);
            page.BodyContainer.Click();
        }
    }
}
