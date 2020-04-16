using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_TopBar : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_TopBar(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"top bar is not displayed")]
        public void ThenTopBarIsNotDisplayed()
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            Verify.IsFalse(topBar.TopBarElement.Displayed(), 
                "Top bar should not be displayed");
        }

        #region Items/Colors check (Top bar)

        [Then(@"following items are displayed in the top bar:")]
        public void ThenFollowingItemsAreDisplayedInTheTopBar(Table table)
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();
            _driver.WaitForDataLoadingInTopBarOnItemDetailsPage();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = topBar.GetTopBarItemsText();
            Verify.AreEqual(expectedList, actualList, 
                "Incorrect items are displayed in the top bar");
        }

        [Then(@"following items and colors are displayed in the top bar:")]
        public void ThenFollowingItemsAndColorsAreDisplayedInTheTopBar(Table table)
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            foreach (var row in table.Rows)
            {
                _driver.WaitForElementToHaveText(topBar.GetTobBarItemTextElement(row["ComplianceItems"]), row["ColorName"]);
                Verify.AreEqual(row["ColorName"], topBar.GetTobBarItemTextElement(row["ComplianceItems"]).Text,
                    $"Incorrect text is displayed in the '{row["ComplianceItems"]}' tob bar");
            }
        }

        [Then(@"there are no displayed items in the top bar")]
        public void ThenThereAreNoDisplayedItemsInTheTopBar()
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();

            var actualList = topBar.GetTopBarItemsText();
            Verify.IsEmpty(actualList, "Compliance items in Top bar on the Item details page is incorrect!");
        }

        [Then(@"User sees '(.*)' tooltip for '(.*)' value in the top bar")]
        public void ThenUserSeesTooltipForValueInTheTopBar(string tooltip, string value)
        {
            var topBar = _driver.NowAt<ItemDetailsTopBarPage>();
            _driver.MouseHover(topBar.GetTobBarItemTextElement(value));
            var tooltipText = _driver.GetTooltipText();
            Verify.AreEqual(tooltip, tooltipText, $"Oops, it looks like '{tooltip}' is not displayed!");
        }

        #endregion
    }
}