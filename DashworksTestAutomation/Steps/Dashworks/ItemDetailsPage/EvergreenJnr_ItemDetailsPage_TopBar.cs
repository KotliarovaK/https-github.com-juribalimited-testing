using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Plugins;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_TopBar : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_TopBar(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"following Compliance items are displayed in Top bar on the Item details page:")]
        public void ThenFollowingComplianceItemsAreDisplayedInTopBarOnTheItemDetailsPage(Table table)
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();
            _driver.WaitForDataLoadingInTopBarOnItemDetailsPage();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = topBar.GetComplianceItemsOnTopBar();
            Verify.AreEqual(expectedList, actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"following Compliance items with appropriate colors are displayed in Top bar on the Item details page:")]
        public void ThenFollowingComplianceItemsWithAppropriateColorsAreDisplayedInTopBarOnTheItemDetailsPage(Table table)
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            foreach (var row in table.Rows)
            {
                _driver.WaitForElementToHaveText(topBar.GetTobBarItemTextElement(row["ComplianceItems"]), row["ColorName"]);
                Verify.AreEqual(row["ColorName"],topBar.GetTobBarItemTextElement(row["ComplianceItems"]).Text,
                    $"Incorrect text is displayed in the '{row["ComplianceItems"]}' tob bar");
            }
        }

        [Then(@"No one Compliance items are displayed for the User in Top bar on the Item details page")]
        public void ThenNoOneComplianceItemsAreDisplayedForTheUserInTopBarOnTheItemDetailsPage()
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            var actualList = topBar.GetComplianceItemsOnTopBar();
            Utils.Verify.IsEmpty(actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"Top bar on the Item details page is not displayed")]
        public void ThenTopBarOnTheItemDetailsPageIsNotDisplayed()
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            Utils.Verify.IsFalse(topBar.TopBarOnItemDetailsPage.Displayed(), "Top bar should not be displayed!");
        }
        
        [Then(@"Value column of Item Details has no Unknown item")]
        public void ThenValueColumnOfItemDetailsHasNoUnknownItem()
        {
            var page = _driver.NowAt<ItemDetailsTopBarPage>();

            var listOfValues = page.GetValuesColumnDataOfItemDetails().Select(x => x.Text).ToList();
            Utils.Verify.That(listOfValues, Does.Not.Contain("Unknown"), "Unknown item displayed in column");
        }
    }
}