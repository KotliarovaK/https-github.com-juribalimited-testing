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

        [Then(@"Create Automation page is displayed to the User")]
        public void ThenCreateAutomationPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<CreateAutomationsPage>();
            Utils.Verify.IsTrue(page.CreateAutomationsTitle.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsTrue(page.AutomationNameField.Displayed(), "Create Automation page is not displayed");
        }
    }
}