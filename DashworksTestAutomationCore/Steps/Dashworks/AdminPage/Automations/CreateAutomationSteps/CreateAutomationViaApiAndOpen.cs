using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations.CreateAutomationSteps
{
    [Binding]
    public class CreateAutomationViaApiAndOpen : CreateAutomationBase
    {
        private readonly RemoteWebDriver _driver;

        private CreateAutomationViaApiAndOpen(DTO.RuntimeVariables.Automations automation, RestWebClient client, RemoteWebDriver driver) : base(
            automation, client)
        {
            _driver = driver;
        }

        [When(@"User creates new Automation via API and open it")]
        public void WhenUserCreatesNewAutomationViaApiAndOpenIt(Table table)
        {
            var lastCreatedAutomation = CreateAutomationViaApi(table);
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/automation/{lastCreatedAutomation}/details");
            _driver.WaitForDataLoading();
            var page = _driver.NowAt<AdminLeftHandMenu>();
            if (page.ExpandSidePanelIcon.Displayed())
                page.ExpandSidePanelIcon.Click();
        }
    }
}