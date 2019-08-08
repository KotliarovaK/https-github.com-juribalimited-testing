using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
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

        [Then(@"""(.*)"" content is displayed in the ""(.*)"" column")]
        public void ThenContentIsDisplayedInTheColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetListContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            Verify.Contains(textContent, columnContent, $"'{textContent}' is not present in the '{columnName}' column");
        }

        [Then(@"Content is displayed in the ""(.*)"" column")]
        public void ThenContentIsDisplayedInTheColumn(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var column = page.GetListContentByColumnName(columnName).ToList();
            var columnContent = column.Select(x => x.Text).ToList();
            var expectedList = table.Rows.Select(x => x["Content"]).ToList();
            Verify.IsTrue(columnContent.SequenceEqual(expectedList), 
                $"Expected content is not present in the '{columnName}' column");
        }

        [Then(@"""(.*)"" text is displayed in the ""(.*)"" column")]
        public void ThenTextIsDisplayedInTheColumn(string text, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var originalList = page.GetColumnContentByColumnNameForCapacity(columnName);
            Verify.AreEqual(text, originalList, "Content is not displayed correctly");
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
    }
}
