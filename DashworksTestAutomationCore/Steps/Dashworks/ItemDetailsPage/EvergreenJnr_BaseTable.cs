using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using System.Linq;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    class EvergreenJnr_BaseTable : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseTable(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"table is displayed")]
        public void ThenTableIsDisplayed()
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsTrue(page.Table.Displayed(), "Table is not displayed");
        }

        #region Keys

        [Then(@"'(.*)' field is displayed in the table")]
        public void ThenFieldIsDisplayedInTheTable(string key)
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsTrue(page.IsRowWithKeyExists(key), $"'{key}' field was not displayed in the table");
        }

        [Then(@"'(.*)' field is not displayed in the table")]
        public void ThenFieldIsNotDisplayedInTheTable(string key)
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsFalse(page.IsRowWithKeyExists(key), $"'{key}' field is displayed in the table");
        }

        [Then(@"following fields are displayed in the table:")]
        public void ThenFollowingFieldsAreDisplayedInTheTable(Table table)
        {
            var fields = _driver.NowAt<BaseTable>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = fields.GetAllRowsValue();
            Verify.AreEqual(expectedList, actualList, "Fields in the table are different");
        }

        [Then(@"User compares data in the fields from the table:")]
        public void ThenUserComparesDataInTheFieldsFromTheTable(Table table)
        {
            var page = _driver.NowAt<BaseTable>();
            foreach (TableRow row in table.Rows)
            {
                var field = row["Field"];
                var value = row["Data"];
                Verify.AreEqual(page.GetRowContent(field), value,
                    $"Incorrect data in the '{field}' field");
            }
        }

        #endregion

        #region Values

        [Then(@"'(.*)' text is not present in the table")]
        public void ThenTextIsNotPresentInTheTable(string text)
        {
            var page = _driver.NowAt<BaseTable>();
            var listOfValues = page.GetRowsContent();
            Verify.That(listOfValues, Does.Not.Contain(text),
                $"'{text}' item displayed in the table");
        }

        #endregion
    }
}
