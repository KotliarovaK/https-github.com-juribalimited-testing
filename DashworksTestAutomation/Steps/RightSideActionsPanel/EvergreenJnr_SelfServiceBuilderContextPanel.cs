using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.RightSideActionsPanel
{
    [Binding]
    class EvergreenJnr_SelfServiceBuilderContextPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_SelfServiceBuilderContextPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks on Expand All button in Self Service Builder Context Panel")]
        public void WhenUserClicksOnExpandAllInSelfServiceBuilderContextPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(true);

        }

        [When(@"User clicks on Collapse All button in Self Service Builder Context Panel ")]
        public void WhenUserClicksOnCollapseAllInSelfServiceBuilderContextPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(false);
        }
        
        [When(@"User clicks on Expand page components button with page '(.*)' type and '(.*)' page name in Self Service Page Builder Context Panel")]
        public void WhenUserСlicksOnExpandPageComponentsButtonWithPageTypeAndPageNameInSelfServicePageBuilderContextPanel(string contextPannelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(true, contextPannelType, contextPanelName);
        }

        [When(@"User clicks on Collapse '(.*)' page components button in Self Service Page Builder Context Panel")]
        public void WhenUserСlicksOnCollapsePageComponentsButtonWithPageTypeAndPageNameInSelfServicePageBuilderContextPanel(string contextPannelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(false, contextPannelType, contextPanelName);
        }

        [When(@"User clicks on Add Item button of '(.*)' page with '(.*)' item type on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnAddItemButtonOfThePageWitItemTypeOnSelfServicePageBuilderContextPanel(string contextPanelName, string contextPannelType)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ClickOnContextPanelPageAddItemButton(contextPannelType, contextPanelName);
        }

        [When(@"User clicks on Cog Menu button of '(.*)' page with '(.*)' item type on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnCogMenuButtonOfThePageWithItemTypeOnSelfServicePageBuilderContextPanel(string contextPanelName, string contextPannelType)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ClickOnContextPanelItemCogMenuButton(contextPannelType, contextPanelName);
        }

        [When(@"User clicks on component Cog Menu button with '(.*)' type and '(.*)' name on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnComponentCogMenuButtonWithTheTypeAndNameOnSelfServicePageBuilderContextPanel(string contextPanelName, string contextPannelType)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ClickOnContextPanelItemCogMenuButton(contextPanelName, contextPannelType);
        }

        [When(@"User enters '(.*)' text in Self Service Page Builder Context Panel Search Field")]
        public void WhenUserEntersTextInSelfServicePageBuilderContextPanelSearchField(string searchedText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.ListPanelSearchTextBox);
            listElement.ListPanelSearchTextBox.Clear();
            listElement.ListPanelSearchTextBox.SendKeys(searchedText);
        }

        [When(@"User clicks Close Self Service Page Builder Context Panel button")]
        public void WhenUserClicksCloseSelfServicePageBuilderContextPanelButton()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            button.ClosePanelButton.Click();
        }

        [When(@"User clicks '(.*)' option in opened Self Service Page Builder Context Panel Cog-menu")]
        public void WhenUserClicksOptionInOpenedCogMenu(string option)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks on '(.*)' button on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnCreatePageButtonOnSelfServicePageBuilderContextPanel(String buttonName)
        {
            var action = _driver.NowAt<BaseDashboardPage>();
            action.ClickButtonByName(buttonName);
        }
    }
}
