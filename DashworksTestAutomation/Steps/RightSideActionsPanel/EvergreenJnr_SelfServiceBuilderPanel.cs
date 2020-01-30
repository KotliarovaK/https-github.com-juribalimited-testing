using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.RightSideActionsPanel
{
    [Binding]
    class EvergreenJnr_SelfServiceBuilderPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_SelfServiceBuilderPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Expand All Sections button on Self Service Builder Panel")]
        public void WhenUserClicksExpandAllSectionsButtonOnSelfServiceBuilderPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(true);
        }

        [When(@"User clicks on Collapse All Sections button on Self Service Builder Panel")]
        public void WhenUserClicksOnCollapseAllSectionsButtonOnSelfServiceBuilderPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(false);
        }

        [When(@"User clicks on Expand button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnExpandButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(true, contextPanelType, contextPanelName);
        }

        [When(@"User clicks on Collapse button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnCollapseButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(false, contextPanelType, contextPanelName);
        }

        [When(@"User clicks on Add Item button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnAddItemButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ContextPanelPageAddItemButton(contextPanelType, contextPanelName).Click();
        }

        [Then(@"User sees item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void ThenUserSeesItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var rightSidePanel = _driver.NowAt<SelfServiceBuilderContextPanel>();

            rightSidePanel.CheckBuilderContextPanelItemDisplayState(contextPanelType, contextPanelName, true);
        }

        [Then(@"User doesn't see item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void ThenUserDoesntSeeItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var rightSidePanel = _driver.NowAt<SelfServiceBuilderContextPanel>();

            rightSidePanel.CheckBuilderContextPanelItemDisplayState(contextPanelType, contextPanelName, false);
        }
    }
}
