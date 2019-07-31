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

        [When(@"User doubleclicks on '(.*)' cell from '(.*)' column")]
        public void WhenUserDoubleclicksOnCellFromColumn(string cellText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var cell = page.GetCellFromColumn(columnName, cellText);
            _driver.DoubleClick(cell);
        }

        [When(@"User change text in '(.*)' cell from '(.*)' column to '(.*)' text")]
        public void WhenUserChangeTextInCellFromColumnToText(string cellText, string columnName, string newCellText)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var cell = page.GetCellFromColumn(columnName, cellText);
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
    }
}
