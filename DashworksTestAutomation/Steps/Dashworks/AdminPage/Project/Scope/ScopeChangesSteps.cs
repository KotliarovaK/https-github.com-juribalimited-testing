using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Scope;
using OpenQA.Selenium.Remote;
using RestSharp.Extensions;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.Scope
{
    [Binding]
    public class ScopeChangesSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ScopeChangesSteps(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to the '(.*)' tab on Scope Changes page")]
        public void WhenUserNavigatesToTheTabOnScopeChangesPage(string tabName)
        {
            var page = _driver.NowAt<ScopeChangePage>();
            _driver.ExecuteAction(() => page.GetTabByName(tabName).Click());
        }
    }
}
