using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ButtonsOnDashbordsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ButtonsOnDashbordsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks the Actions button")]
        public void WhenUserClicksTheActionsButton()
        {
            var menu = _driver.NowAt<BaseDashbordPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashbordPage>(() => menu.ActionsButton);
            menu.ActionsButton.Click();
            Logger.Write("Actions button was clicked");
        }

        [When(@"User clicks the Columns button")]
        public void WhenUserClicksTheColumnsButton()
        {
            var menu = _driver.NowAt<BaseDashbordPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashbordPage>(() => menu.ColumnButton);
            menu.ColumnButton.Click();
            Logger.Write("Column button was clicked");
        }

        [When(@"User clicks the Filters button")]
        public void WhenUserClicksTheFiltersButton()
        {
            var menu = _driver.NowAt<BaseDashbordPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashbordPage>(() => menu.FilterButton);
            menu.FilterButton.Click();
            Logger.Write("Filters button was clicked");
        }
    }
}