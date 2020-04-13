using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations.CreateAutomationSteps
{
    [Binding]
    public class CreateAutomationsViaApi : CreateAutomationBase
    {
        private CreateAutomationsViaApi(DTO.RuntimeVariables.Automations automation, RestWebClient client, RemoteWebDriver driver) : base(
            automation, client)
        { }

        [When(@"User creates new Automation via API")]
        public void WhenUserCreatesNewAutomationViaAPI(Table table)
        {
            CreateAutomationViaApi(table);
        }
    }
}