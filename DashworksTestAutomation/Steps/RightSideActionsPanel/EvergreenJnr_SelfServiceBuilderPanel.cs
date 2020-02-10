using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using DashworksTestAutomation.Pages.Evergreen.Base;
using System.Linq;
using System.Collections.Generic;
using System;

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

        [When(@"User clicks on '(.*)' option in Cog-menu with '(.*)' item type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnCogMenuButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string option, string contextPanelType, string contextPanelName)
        {
            ClickOnCogMenuButtonOnSelfServiceBuilderPanel(contextPanelType, contextPanelName);
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();
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

        [Then(@"Item with '(.*)' type and '(.*)' name on Self Service Builder Panel is highlighted")]
        public void ThenItemWithTypeAndNameOnSelfServiceBuilderPanelIsHighlighted(string contextPanelType, string contextPanelName)
        {
            var rightSidePanel = _driver.NowAt<SelfServiceBuilderContextPanel>();

            Verify.IsTrue(rightSidePanel.IsContentPanelHighlighted(contextPanelType, contextPanelName), $"The {contextPanelName} item wasn't highlighted");
        }

        [When("User clicks on CogMenu button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnCogMenuButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            ClickOnCogMenuButtonOnSelfServiceBuilderPanel(contextPanelType, contextPanelName);
        }

        [Then("User clicks on CogMenu button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel and sees the following cog-menu options")]
        public void ThenUserClicksOnCogMenuButtonForItemWithTypeAndNameOnSelfServiceBuilderPanelAndSeesTheFollowingCogmenuOptions(string contextPanelType, string contextPanelName, Table options)
        {
            ClickOnCogMenuButtonOnSelfServiceBuilderPanel(contextPanelType, contextPanelName);
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            _driver.WaitForDataLoading();

            List<String> expectedCogMenuOptions = options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()).ToList();
            List<String> cogMenuOptions = cogMenu.CogMenuItems.Select(x => x.GetText()).ToList();

            Verify.AreEqual(cogMenuOptions, expectedCogMenuOptions,
                            "Items are not the same");
        }

        public void ClickOnCogMenuButtonOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ContextPanelPageCogMenuButton(contextPanelType, contextPanelName).Click();
        }
    }
}