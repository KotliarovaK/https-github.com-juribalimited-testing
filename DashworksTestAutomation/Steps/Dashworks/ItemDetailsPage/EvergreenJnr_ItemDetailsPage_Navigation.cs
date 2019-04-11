using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_Navigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_Navigation (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to the ""(.*)"" tab-menu on the Details page")]
        public void WhenUserNavigatesToTheTab_MenuOnTheDetailsPage(string tabMenuName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            detailsPage.GetTabMenuByName(tabMenuName).Click();
        }

        [When(@"User navigates to the ""(.*)"" sub-menu on the Details page")]
        public void WhenUserNavigatesToTheSub_MenuOnTheDetailsPage(string subMenuName)
        {
            var detailsPage = _driver.NowAt<NavigationPage>();
            detailsPage.GetSubMenuByName(subMenuName).Click();
        }
    }
}
