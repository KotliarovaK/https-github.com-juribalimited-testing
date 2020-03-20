using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using DashworksTestAutomation.Pages.Evergreen.Base;
using System.Linq;
using System.Collections.Generic;
using System;
using AutomationUtils.Utils;
using DashworksTestAutomation.Steps.Dashworks.AdminPage;
using DashworksTestAutomation.DTO.RuntimeVariables;

namespace DashworksTestAutomation.Steps.RightSideActionsPanel
{
    [Binding]
    class EvergreenJnr_SelfServiceBuilderPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly RunNowAutomationStartTime _automationStartTime;


        public EvergreenJnr_SelfServiceBuilderPanel(RemoteWebDriver driver, RunNowAutomationStartTime automationStartTime)
        {
            _driver = driver;
            _automationStartTime = automationStartTime;
        }

        [When(@"User clicks on item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var builderPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            builderPage.ContextPanelItem(contextPanelType, contextPanelName).Click();
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

        [Then("User sees '(.*)' tootltip text of Add Item button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void ThenUserSeesTootltipTextOfAddItemButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string text, string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            var button = dashboardPage.ContextPanelPageAddItemButton(contextPanelType, contextPanelName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(text, toolTipText,
                $"'{contextPanelName}' button tooltip is incorrect");
        }

        [When(@"User selects '(.*)' cogmenu option for '(.*)' item type with '(.*)' name on Self Service Builder Panel")]
        public void WhenUserSelectsCogmenuOptionForItemTypeWithNameOnSelfServiceBuilderPanel(string option, string contextPanelType, string contextPanelName)
        {
            ClickOnCogMenuButtonOnSelfServiceBuilderPanel(contextPanelType, contextPanelName);
            var cogMenu = new EvergreenJnr_CogMenuActions(_driver, _automationStartTime);
            cogMenu.ClickOnCogMenuOption(option);
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

        [Then(@"Item name text with '(.*)' type and '(.*)' name on Self Service Builder Panel is not highlighted")]
        public void ThenItemNameTextWithTypeAndNameOnSelfServiceBuilderPanelIsnotHighlighted(string contextPanelType, string contextPanelName)
        {
            var rightSidePanel = _driver.NowAt<SelfServiceBuilderContextPanel>();
            Verify.IsFalse(rightSidePanel.IsContentPanelNameTextHighlighted(contextPanelType, contextPanelName), $"The '{contextPanelName}' name text shouldn't be highlighted");
        }

        //This step can only been used on specific cases!!! 
        [When("User clicks on cogmenu button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnCogMenuButtonForItemWithTypeAndNameOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            ClickOnCogMenuButtonOnSelfServiceBuilderPanel(contextPanelType, contextPanelName);
        }

        [Then("User clicks on cogmenu button for item with '(.*)' type and '(.*)' name on Self Service Builder Panel and sees the following cogmenu options")]
        public void ThenUserClicksOnCogMenuButtonForItemWithTypeAndNameOnSelfServiceBuilderPanelAndSeesTheFollowingCogmenuOptions(string contextPanelType, string contextPanelName, Table options)
        {
            ClickOnCogMenuButtonOnSelfServiceBuilderPanel(contextPanelType, contextPanelName);
            var cogMenu = _driver.NowAt<CogMenuElements>();
            CheckThatFollowingItemsAreDisplaysInCogMenu(options);
        }

        public void ClickOnCogMenuButtonOnSelfServiceBuilderPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ContextPanelPageCogMenuButton(contextPanelType, contextPanelName).Click();
        }

        public void CheckThatFollowingItemsAreDisplaysInCogMenu(Table options)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            _driver.WaitForDataLoading();

            List<String> expectedCogMenuOptions = options.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault()).ToList();
            List<String> cogMenuOptions = cogMenu.CogMenuItems.Select(x => x.GetText()).ToList();

            Verify.AreEqual(cogMenuOptions, expectedCogMenuOptions,
                            "Items are not the same");
        }
    }
}