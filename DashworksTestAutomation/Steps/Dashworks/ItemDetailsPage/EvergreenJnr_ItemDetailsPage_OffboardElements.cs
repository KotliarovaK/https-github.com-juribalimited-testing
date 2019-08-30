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
    class EvergreenJnr_ItemDetailsPage_OffboardElements : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_OffboardElements (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Offboard Pop-up is displayed on the Item Details page")]
        public void ThenOffboardPop_UpIsDisplayedOnTheItemDetailsPage()
        {
            var page = _driver.NowAt<ItemDetails_OffboardElementsPage>();
            Utils.Verify.IsTrue(page.OffboardPopUp.Displayed(), "Offboard Pop-up is not displayed");
        }
    }
}