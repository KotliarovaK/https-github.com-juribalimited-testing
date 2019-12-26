using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService
{
    [Binding]
    class SelfService : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public SelfService(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User sees Ag-Grid")]
        public void ThenUserSeesAgGrid()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.IsElementDisplayed(page.AgGrid);
            Verify.IsTrue(_driver.IsElementDisplayed(page.AgGrid),
                "Ag-Grid doesn't displayed to the user");
        }
    }
}

        
    
