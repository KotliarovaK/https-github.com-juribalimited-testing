using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

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
            var actualList = topBar.GetTopBarItemsText();
            Verify.AreEqual(expectedList, actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"following Compliance items with appropriate colors are displayed in Top bar on the Item details page:")]
        public void ThenFollowingComplianceItemsWithAppropriateColorsAreDisplayedInTopBarOnTheItemDetailsPage(Table table)
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            foreach (var row in table.Rows)
            {
                _driver.WaitForElementToHaveText(topBar.GetTobBarItemTextElement(row["ComplianceItems"]), row["ColorName"]);
                Verify.AreEqual(row["ColorName"], topBar.GetTobBarItemTextElement(row["ComplianceItems"]).Text,
                    $"Incorrect text is displayed in the '{row["ComplianceItems"]}' tob bar");
            }
        }

        [Then(@"No one Compliance items are displayed for the User in Top bar on the Item details page")]
        public void ThenNoOneComplianceItemsAreDisplayedForTheUserInTopBarOnTheItemDetailsPage()
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            var actualList = topBar.GetTopBarItemsText();
            Utils.Verify.IsEmpty(actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"Top bar on the Item details page is not displayed")]
        public void ThenTopBarOnTheItemDetailsPageIsNotDisplayed()
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            Verify.IsFalse(topBar.TopBarOnItemDetailsPage.Displayed(), "Top bar should not be displayed!");
        }

        //TODO move to baseTable
        [Then(@"Value column of Item Details has no Unknown item")]
        public void ThenValueColumnOfItemDetailsHasNoUnknownItem()
        {
            var page = _driver.NowAt<BaseTable>();

            var listOfValues = page.GetRowsContent();
            Verify.That(listOfValues, Does.Not.Contain("Unknown"),
                "Unknown item displayed in column");
        }
    }
}