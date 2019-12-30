using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using HeaderElement = System.Web.Caching.HeaderElement;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    //TODO Rename this class
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
            Verify.IsTrue(detailsPage.GroupIcon.Displayed(), "Item details icon is not displayed");
        }
    }
}