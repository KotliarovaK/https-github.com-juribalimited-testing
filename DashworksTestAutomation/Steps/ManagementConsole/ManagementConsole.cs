using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.ManagementConsole;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps
{
    [Binding]
    internal class ManagementConsole : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ManageUsers _manageUsers;

        public ManagementConsole(RemoteWebDriver driver, ManageUsers manageUsers)
        {
            _driver = driver;
            _manageUsers = manageUsers;
        }

        [When(@"User select ""(.*)"" option in Management Console")]
        public void WhenUserSelectOptionInManagementConsole(string optionName)
        {
            var page = _driver.NowAt<ManagementConsolePage>();

            _driver.MouseHover(page.GetLinkInManagementConsoleByName(optionName));
            page.GetLinkInManagementConsoleByName(optionName).Click();
        }

        [Then(@"User create a new Dashworks User")]
        public void ThenUserCreateANewDashworksUser(Table table)
        {
            var page = _driver.NowAt<ManageUserPage>();

            page.CreateNewUserButton.Click();


        }
    }
}