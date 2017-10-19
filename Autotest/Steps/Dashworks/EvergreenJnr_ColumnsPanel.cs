using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Extensions;
using Autotest.Pages.Evergreen;
using Autotest.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Autotest.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ColumnsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ColumnsPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Columns panel is displayed to the user")]
        public void ThenColumnsPanelIsDisplayedToTheUser()
        {
            var columnElement = _driver.NowAt<ColumnsElement>();
            Assert.IsTrue(columnElement.ColumnsPanel.Displayed());
            Logger.Write("Columns panel is visible");
        }

        [When(@"ColumnName is entered into the search box and the selection is clicked")]
        public void WhenColumnNameIsEnteredIntoTheSearchBoxAndTheSelectionIsClicked(Table table)
        {
            var columnElement = _driver.NowAt<ColumnsElement>();

            foreach (var row in table.Rows)
            {
                columnElement.AddColumn(row["ColumnName"]);
                //Clear the textbox after adding a column, so it is reset for the next loop
                columnElement.SearchTextbox.Clear();
            }
            //Minimise the Selected Columns
            columnElement.MinimizeGroupButton.Click();
            //Close the Columns Panel
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();
            listpageMenu.Column.Click();
        }

        [Then(@"ColumnName is added to the list")]
        public void ThenColumnNameIsAddedToTheList(Table table)
        {
            var listpageMenu = _driver.NowAt<BaseDashbordPage>();
            foreach (var row in table.Rows)
            {
                listpageMenu.IsColumnPresent(row["ColumnName"]);
            }
        }
    }
}
