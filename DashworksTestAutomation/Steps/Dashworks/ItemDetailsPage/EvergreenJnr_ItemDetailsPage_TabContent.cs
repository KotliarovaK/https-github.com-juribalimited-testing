using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_TabContent : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_TabContent(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Details page for '(.*)' item is displayed to the user")]
        public void ThenDetailsPageForItemIsDisplayedToTheUser(string pageName)
        {
            var page = _driver.NowAt<BaseHeaderElement>();
            page.CheckPageHeaderContainsText(pageName);

            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(detailsPage.GroupIcon.Displayed(), 
                "Item details icon is not displayed on Item details page");
        }
    }
}