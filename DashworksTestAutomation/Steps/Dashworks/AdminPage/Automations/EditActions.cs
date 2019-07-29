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
    internal class EditActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EditActions(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Edit Action page is displayed to the User")]
        public void ThenEditActionPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<EditActionPage>();
            Utils.Verify.IsTrue(page.EditActionTitle.Displayed(), "Edit Action page is not displayed");
        }

    }
}
