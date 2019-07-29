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
    internal class CreateAction : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public CreateAction(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Create Action page is displayed to the User")]
        public void ThenCreateActionPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<CreateActionsPage>();
            _driver.WaitForElementToBeDisplayed(page.CreateActionTitle);
            Utils.Verify.IsTrue(page.CreateActionTitle.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsTrue(page.ActionNameField.Displayed(), "Create Action page is not displayed");
        }
    }
}
