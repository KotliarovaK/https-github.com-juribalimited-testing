using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class CreateAutomation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Automations _automation;
        private readonly RestWebClient _client;

        public CreateAutomation(RemoteWebDriver driver, RestWebClient client, DTO.RuntimeVariables.Automations automation)
        {
            _driver = driver;
            _client = client;
            _automation = automation;
        }

        [Then(@"""(.*)"" title is displayed on the Automations page")]
        public void ThenTitleIsDisplayedOnTheAutomationsPage(string title)
        {
            var page = _driver.NowAt<AutomationsPage>();
            Utils.Verify.AreEqual(page.AutomationTitle.Text, title, "Title is incorrect");
        }

        [Then(@"Automation page is displayed correctly")]
        public void ThenAutomationPageIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<AutomationsPage>();
            Utils.Verify.IsTrue(page.AutomationNameField.Displayed(), "Edit Automation page is not displayed");
            var autocompleteElement = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToNotContainsTextInAttribute(autocompleteElement.GetNamedTextbox("Scope"), "Scope", "value");
        }
    }
}