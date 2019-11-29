﻿using System;
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

        [When(@"User clicks Expand All Sections button on Self Service Builder Panel")]
        public void WhenUserClicksOnExpandSectionsAllInSelfServiceBuilderContextPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(true);
        }

        [When(@"User clicks on Collapse All Sections button on Self Service Builder Panel")]
        public void WhenUserClicksOnCollapseAllSectionsInSelfServiceBuilderContextPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(false);
        }
        
        [When(@"User clicks on Expand page components button with page '(.*)' type and '(.*)' page name on Self Service Builder Panel")]
        public void WhenUserСlicksOnExpandPageComponentsButtonWithPageTypeAndPageNameInSelfServicePageBuilderContextPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(true, contextPanelType, contextPanelName);
        }

        [When(@"User clicks on Collapse '(.*)' page components button on Self Service Builder Panel")]
        public void WhenUserСlicksOnCollapsePageComponentsButtonWithPageTypeAndPageNameInSelfServicePageBuilderContextPanel(string contextPanelType, string contextPanelName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(false, contextPanelType, contextPanelName);
        }

        [When(@"User clicks on Add Item button of '(.*)' page with '(.*)' item type on Self Service Builder Panel")]
        public void WhenUserClicksOnAddItemButtonOfThePageWitItemTypeOnSelfServicePageBuilderContextPanel(string contextPanelName, string contextPanelType)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ContextPanelPageAddItemButton(contextPanelType, contextPanelName).Click();
        }

        [When(@"User clicks on Cog Menu button of '(.*)' page with '(.*)' item type on Self Service Builder Panel")]
        public void WhenUserClicksOnCogMenuButtonOfThePageWithItemTypeOnSelfServicePageBuilderContextPanel(string contextPanelName, string contextPanelType)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ContextPanelPageCogMenuButton(contextPanelType, contextPanelName).Click();
        }

        [When(@"User clicks on component Cog Menu button with '(.*)' type and '(.*)' name on Self Service Builder Panel")]
        public void WhenUserClicksOnComponentCogMenuButtonWithTheTypeAndNameOnSelfServicePageBuilderContextPanel(string contextPanelName, string contextPanelType)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ContextPanelPageCogMenuButton(contextPanelType, contextPanelName).Click();
        }

        [When(@"User enters '(.*)' text in Self Service Builder Panel Search Field")]
        public void WhenUserEntersTextInSelfServicePageBuilderContextPanelSearchField(string searchedText)
        {
            var listElement = _driver.NowAt<CustomListElement>();
            _driver.WaitForElementToBeDisplayed(listElement.ListPanelSearchTextBox);
            listElement.ListPanelSearchTextBox.Clear();
            listElement.ListPanelSearchTextBox.SendKeys(searchedText);
        }

        [When(@"User clicks Close Self Service Builder Panel button")]
        public void WhenUserClicksCloseSelfServicePageBuilderContextPanelButton()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            button.ClosePanelButton.Click();
        }

        [When(@"User clicks '(.*)' option in opened Self Service Builder Panel Cog-menu")]
        public void WhenUserClicksOptionInOpenedCogMenu(string option)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }
    }
}
