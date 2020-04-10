using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder
{
    [Binding]
    class TextComponentUI : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public TextComponentUI(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"formatting options are displayed on the text component page")]
        public void ThenFormattingOptionsAreDisplayedOnTheTextComponentPage()
        {
            var page = _driver.NowAt<TextComponentPage>();
            _driver.WaitForElementToBeDisplayed(page.ToolbarWithFormattingOptions);

            Verify.That(page.BoldStyleButton.Displayed(), "Bold style button is not displayed");
            Verify.That(page.ItalicStyleButton.Displayed(), "Italic style button is not displayed");
            Verify.That(page.UnderlineStyleButton.Displayed(), "Underline style button is not displayed");
            Verify.That(page.HeadersPickerButton.Displayed(), "Headers picker button is not displayed");
        }

        [Then(@"header format options are displayed on the text component page")]
        public void ThenHeaderFormatOPtionsAreDisplayedOnTheTextComponentPage(Table table)
        {
            var page = _driver.NowAt<TextComponentPage>();
            _driver.WaitForElementToBeDisplayed(page.ToolbarWithFormattingOptions);

            page.HeadersPickerButton.Click();
            _driver.WaitForElementsToBeDisplayed(page.HeaderOptions);

            List<string> expectedOptionNames = table.Rows.SelectMany(row => row.Values).ToList();
            List<string> actualheaderOptionNames = new List<string>();

            for (int i = 0; i < page.HeaderOptions.Count; i++)
            {
                string script = $"return window.getComputedStyle(document.getElementsByClassName('ql-picker-item')[{i}], ':before').getPropertyValue('content');";
                string value = _driver.ExecuteScript(script).ToString().Trim('"');
                actualheaderOptionNames.Add(value);
            }

            Verify.AreEqual(expectedOptionNames, actualheaderOptionNames, "Header format options does not equals to expecting options");
        }
    }
}
