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
            dashboardPage.CollapseExpandSelfServiceBuilderContextPanelElements(true);

        }

        [When(@"User clicks on Collapse All button in Self Service Builder Context Panel")]
        public void WhenUserClicksOnCollapseAllInSelfServiceBuilderContextPanel()
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandSelfServiceBuilderContextPanelElements(false);
        }
        
        [When(@"User clicks on Expand ""(.*)"" page items button in Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnExpandThePageItemsButtonInSelfServicePageBuilderContextPanel(String contextPanelPageName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            _driver.WaitForDataLoading();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(contextPanelPageName, true);
        }

        [When(@"User clicks on Collapse ""(.*)"" page items button in Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnCollapseThePageItemsButtonInSelfServicePageBuilderContextPanel(String contextPanelPageName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.CollapseExpandSelfServiceBuilderPageOnContextPanel(contextPanelPageName, false);
        }

        [When(@"User clicks on Add Item button of ""(.*)"" page on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnAddItemButtonOfThePageOnSelfServicePageBuilderContextPanel(String contextPanelPageName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ClickOnContextPanelPageAddItemButton(contextPanelPageName);
        }

        [When(@"User clicks on Cog Menu button of ""(.*)"" page on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnCogMenuButtonOfThePageOnSelfServicePageBuilderContextPanel(String contextPanelPageName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ClickOnContextPanelPageCogMenuButton(contextPanelPageName);
        }

        [When(@"User clicks on Cog Menu button of ""(.*)"" page with ""(.*)"" component heading and ""(.*)"" component name on Self Service Page Builder Context Panel")]
        public void WhenUserClicksOnCogMenuButtonOfThePageWithTheComponentHeadinAndNameOnSelfServicePageBuilderContextPanel(String contextPanelPageName, String componentHeading, String componentName)
        {
            var dashboardPage = _driver.NowAt<SelfServiceBuilderContextPanel>();
            dashboardPage.ClickOnContextPanelPageSubCogMenuButton(contextPanelPageName, componentHeading, componentName);
        }

        [When(@"User enters ""(.*)"" text in Self Service Page Builder Context Panel Search Field")]
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

        [When(@"User clicks '(.*)' option in opened Cog-menu")]
        public void WhenUserClicksOptionInOpenedCogMenu(string option)
        {
            var cogMenu = _driver.NowAt<CogMenuElements>();
            _driver.WaitForElementToBeDisplayed(cogMenu.CogMenuList);
            cogMenu.GetCogMenuOptionByName(option).Click();
            _driver.WaitForDataLoading();
        }
    }
}
