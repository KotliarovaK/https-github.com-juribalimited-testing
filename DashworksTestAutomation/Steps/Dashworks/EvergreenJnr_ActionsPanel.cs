using NUnit.Framework;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ActionsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ActionsPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Actions panel is displayed to user")]
        public void ThenActionsPanelIsDisplayedToUser()
        {
            var actionsElement = _driver.NowAt<ActionsElement>();
            Assert.IsTrue(actionsElement.ActionsPanel.Displayed());
            Logger.Write("Actions panel is visible");
        }
    }
}
