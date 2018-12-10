using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_Pivot : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_Pivot(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to Pivot")]
        public void WhenUserNavigatesToPivot()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseDashboardPage>(() => page.CreateActionButton);
            page.CreateActionButton.Click();
            page.GetCreateButtonByName("Pivot").Click();
        }

        [When(@"User adds the following Row Groups:")]
        public void WhenUserAddsTheFollowingRowGroups(Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetButtonByNameOnPivot("ADD ROW GROUP").Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["RowGroups"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }

        [When(@"User adds the following Columns:")]
        public void WhenUserAddsTheFollowingColumns(Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetButtonByNameOnPivot("ADD COLUMN").Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["RowGroups"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }

        [When(@"User adds the following Values:")]
        public void WhenUserAddsTheFollowingValues(Table table)
        {
            var page = _driver.NowAt<PivotElementPage>();
            page.GetButtonByNameOnPivot("ADD VALUE").Click();
            var columnElement = _driver.NowAt<ColumnsElement>();
            foreach (var value in table.Rows)
            {
                columnElement.AddColumn(value["RowGroups"]);
                //Clear the textBox after adding a column, so it is reset for the next loop
                columnElement.SearchTextBox.ClearWithHomeButton(_driver);
            }
            page.GetButtonByNameOnPivot("DONE").Click();
        }
    }
}
