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
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            
        }

        [When(@"User clicks on Collapse All button in Self Service Builder Context Panel")]
        public void WhenUserClicksOnCollapseAllInSelfServiceBuilderContextPanel()
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            
            }
        }
    }
}
