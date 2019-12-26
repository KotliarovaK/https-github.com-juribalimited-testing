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

        [Then(@"field with ""(.*)"" text is displayed in expanded tab on the Details Page")]
        public void ThenFieldWithTextIsDisplayedInExpandedTabOnTheDetailsPage(string text)
        {
            var content = _driver.NowAt<TabContent>();
            Utils.Verify.IsTrue(content.GetTheDisplayStateOfContentOnOpenTab(text), $"{text} content is not found in opened tab!");
        }

        [Then(@"field with ""(.*)"" text is not displayed in expanded tab on the Details Page")]
        public void ThenFieldWithTextIsNotDisplayedInExpandedTabOnTheDetailsPage(string text)
        {
            var content = _driver.NowAt<TabContent>();
            Utils.Verify.IsFalse(content.GetTheDisplayStateOfContentOnOpenTab(text), $"'{text}' content should not be displayed!");
        }

        [Then(@"element table is displayed on the Details page")]
        public void ThenElementTableIsDisplayedOnTheDetailsPage()
        {
            var content = _driver.NowAt<TabContent>();
            Utils.Verify.IsTrue(content.ElementsTable.Displayed, "Element table is not displayed!");
        }
    }
}