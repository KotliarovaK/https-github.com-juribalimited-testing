using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class CreateAutomationPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public CreateAutomationPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Automation page is displayed correctly")]
        public void ThenAutomationPageIsDisplayedCorrectly()
        {
            var autocompleteElement = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(autocompleteElement.IsTextboxDisplayed("Automation Name"),
                "Automation page is not displayed correctly");
            _driver.WaitForElementToHaveText(autocompleteElement.GetTextbox("Scope"));
            _driver.WaitForElementToHaveText(autocompleteElement.GetDropdown("Run"));
            //For the stability of the Automation's tests
            Thread.Sleep(800);
        }
    }
}