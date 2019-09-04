using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    //ONLY actions with BaseGridPage !!!
    [Binding]
    class EvergreenJnr_BaseGrid : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseGrid(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"'(.*)' content is displayed in the '(.*)' column")]
        public void ThenContentIsDisplayedInTheColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetColumnContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            Verify.Contains(textContent, columnContent, $"'{textContent}' is not present in the '{columnName}' column");
        }

        [Then(@"""(.*)"" content is not displayed in the ""(.*)"" column")]
        public void ThenContentIsNotDisplayedInTheColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            if (_driver.IsElementDisplayed(page.NoFoundMessage, WebDriverExtensions.WaitTime.Short))
            {
                //Message about no content in the table is displayed
                return;
            }
            else
            {
                var column = page.GetColumnContentByColumnName(columnName).ToList();
                if (column.Any())
                {
                    var columnContent = column.Select(x => x.Text).ToList();
                    Verify.IsFalse(columnContent.Contains(textContent), $"'{textContent}' is present in the '{columnName}' column");
                }
                else
                {
                    //Column doesn't have any data. Everything was removed
                    return;
                }
            }
        }

        [Then(@"Content in the '(.*)' column is equal to")]
        public void ThenContentInTheColumnIsEqualTo(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetColumnContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            Verify.IsTrue(columnContent.SequenceEqual(expectedList),
                $"Expected content is not present in the '{columnName}' column");
        }

        [Then(@"'(.*)' column contains following content")]
        public void ThenColumnContainsFollowingContent(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetColumnContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            foreach (string content in expectedList)
            {
                Verify.IsTrue(columnContent.Contains(content),
                    $"'{content}' content is not displayed in the '{columnName}' column");
            }
        }

        [When(@"User doubleclicks on '(.*)' cell from '(.*)' column")]
        public void WhenUserDoubleclicksOnCellFromColumn(string cellText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var cell = page.GetCellFromColumn(columnName, cellText);
            _driver.DoubleClick(cell);
        }

        #region Clicable value

        //Change By double click
        [When(@"User change text in '(.*)' cell from '(.*)' column to '(.*)' text")]
        public void WhenUserChangeTextInCellFromColumnToText(string cellText, string columnName, string newCellText)
        {
            ChangeClickableValue(cellText, columnName, newCellText);

            SaveClickableValue();
        }

        //Change by CogMenu or when already opened for edit
        [When(@"User save '(.*)' text in clickable value")]
        public void WhenUserSaveTextInClickableValue(string newCellText)
        {
            EnterTextInClickableValue(newCellText);

            SaveClickableValue();
        }

        [When(@"User change text in '(.*)' cell from '(.*)' column to '(.*)' text without saving")]
        public void WhenUserChangeTextInCellFromColumnToTextWithoutSaving(string cellText, string columnName, string newCellText)
        {
            ChangeClickableValue(cellText, columnName, newCellText);
        }

        private void SaveClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.SaveInlineButton.Click();
            _driver.WaitForDataLoading();
        }

        private void ChangeClickableValue(string cellText, string columnName, string newCellText)
        {
            //Updated value will not be saved in test context!!!
            WhenUserDoubleclicksOnCellFromColumn(cellText, columnName);

            EnterTextInClickableValue(newCellText);
        }

        private void EnterTextInClickableValue(string newCellText)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.InputInlineTextbox.ClearWithBackspaces();
            page.InputInlineTextbox.SendKeys(newCellText);
        }

        [Then(@"Save and Cancel buttons with tooltips are displayed for clickable value")]
        public void ThenSaveAndCancelButtonsWithTooltipsAreDisplayedForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.SaveInlineButton);
            Verify.IsTrue(page.SaveInlineButton.Displayed(), "Save Inline Button is not displayed");
            Verify.IsTrue(page.CancelInlineButton.Displayed(), "Cancel Inline Button is not displayed");

            _driver.MouseHover(page.SaveInlineButton);
            Thread.Sleep(200);
            var tooltip = _driver.GetTooltipText();
            Verify.AreEqual("Save", tooltip, "Incorrect tooltip for Save button");

            _driver.MouseHover(page.CancelInlineButton);
            Thread.Sleep(200);
            var tooltip1 = _driver.GetTooltipText();
            Verify.AreEqual("Save", tooltip, "Incorrect tooltip for Cancel button");
        }

        [Then(@"Save and Cancel buttons are NOT displayed for clickable value")]
        public void ThenSaveAndCancelButtonsAreNotDisplayedForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();

            Verify.IsFalse(page.SaveInlineButton.Displayed(), "Save Inline Button is displayed");
            Verify.IsFalse(page.CancelInlineButton.Displayed(), "Cancel Inline Button is displayed");
        }

        [When(@"User clicks Save button for clickable value")]
        public void WhenUserClicksSaveButtonForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.SaveInlineButton.Click();

            _driver.WaitForDataLoading();
        }

        [When(@"User clicks Cancel button for clickable value")]
        public void WhenUserClicksCancelButtonForClickableValue()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.CancelInlineButton.Click();

            _driver.WaitForDataLoading();
        }

        #endregion

        #region GroupBy

        [When(@"User expands '(.*)' row in the groped grid")]
        public void WhenUserExpandsRowInTheGropedGrid(string groupedBy)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.ExpandGroupedRowByContent(groupedBy);
        }

        [Then(@"Grid is grouped")]
        public void ThenGridIsGrouped()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(page.IsGridGrouped(), "Grid is not grouped");
        }

        [Then(@"Grid is not grouped")]
        public void ThenGridIsNotGrouped()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(page.IsGridGrouped(), "Grid is grouped");
        }

        #endregion
    }
}
