using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_TabContent : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_TabContent (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User sees loaded tab ""(.*)"" on the Details page")]
        public void ThenUserSeesLoadedTabOnTheDetailsPage(string tabName)
        {
            _driver.WaitForDataLoading();

            var page = _driver.NowAt<TabContent>();
            Assert.IsTrue(page.CheckThatSelectedTabHasOpened(tabName), $"{tabName} tab is not loaded!");
        }

        [Then(@"Details page for ""(.*)"" item is displayed to the user")]
        public void ThenDetailsPageForItemIsDisplayedToTheUser(string pageName)
        {
            _driver.WaitForDataLoading();

            var detailsPage = _driver.NowAt<DetailsPage>();
            NUnit.Framework.Assert.IsTrue(detailsPage.GroupIcon.Displayed());

            var page = _driver.NowAt<TabContent>();
            NUnit.Framework.Assert.IsTrue(page.GetItemDetailsPageByName(pageName).Displayed(), $"{pageName} page is not loaded!");
        }

        [Then(@"field with ""(.*)"" text is displayed in expanded tab on the Details Page")]
        public void ThenFieldWithTextIsDisplayedInExpandedTabOnTheDetailsPage(string text)
        {
            var content = _driver.NowAt<TabContent>();
            Assert.IsTrue(content.GetTheDisplayStateOfContentOnOpenTab(text), $"{text} content is not found in opened tab!");
        }

        [Then(@"element table is displayed on the Details page")]
        public void ThenElementTableIsDisplayedOnTheDetailsPage()
        {
            var content = _driver.NowAt<TabContent>();
            Assert.IsTrue(content.ElementsTable.Displayed, "Element table is not displayed!");
        }

        [Then(@"appropriate colored filter icons are displayed for following colors:")]
        public void ThenAppropriateColoredFilterIconsAreDisplayedForFollowingColors(Table table)
        {
            var page = _driver.NowAt<TabContent>();
            foreach (var row in table.Rows)
            {
                var getColor = page.GetColorIconsForColorFilters(row["Color"]).GetAttribute("style").Split(';')
                    .First().Split(':').Last().TrimStart(' ').TrimEnd(' ');
                Assert.AreEqual(ColorsConvertor.Convert(row["Color"]), getColor, "Colors are different or not displayed!");
            }
        }
    }
}