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

        [Then(@"User sees loaded tab ""(.*)"" on the Details page")]
        public void ThenUserSeesLoadedTabOnTheDetailsPage(string tabName)
        {
            _driver.WaitForDataLoading();

            var page = _driver.NowAt<TabContent>();
            Utils.Verify.IsTrue(page.CheckThatSelectedTabHasOpened(tabName), $"{tabName} tab is not loaded!");
        }

        [Then(@"Details page for ""(.*)"" item is displayed to the user")]
        public void ThenDetailsPageForItemIsDisplayedToTheUser(string pageName)
        {
            var page = _driver.NowAt<BaseHeaderElement>();
            page.CheckPageHeaderContainsText(pageName);

            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsTrue(detailsPage.GroupIcon.Displayed(), "Item details icon is not displayed");
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

        [Then(@"appropriate colored filter icons are displayed for following colors:")]
        public void ThenAppropriateColoredFilterIconsAreDisplayedForFollowingColors(Table table)
        {
            var page = _driver.NowAt<TabContent>();
            foreach (var row in table.Rows)
            {
                var getColor = page.GetColorIconsForColorFilters(row["Color"]).GetAttribute("style").Split(';')
                    .First().Split(':').Last().TrimStart(' ').TrimEnd(' ');
                Utils.Verify.AreEqual(ColorsConvertor.Convert(row["Color"]), getColor, "Colors are different or not displayed!");
            }
        }

        [Then(@"""(.*)"" content is not displayed in the grid on the Item details page")]
        public void ThenContentIsNotDisplayedInTheGridOnTheItemDetailsPage(string textContent)
        {
            var projectTabs = _driver.NowAt<TabContent>();
            Utils.Verify.IsFalse(projectTabs.GetContentDisplayState(textContent), $"{textContent} content should not be displayed in the grid on the Item details page!");
        }

        [Then(@"User sees the following Column Settings")]
        public void ThenUserSeesTheFollowingColumnSettings(Table table)
        {
            var projectTabs = _driver.NowAt<TabContent>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = projectTabs.GetColumnSettings().Select(p => p.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Column settings are not displayed correctly!");
        }
    }
}