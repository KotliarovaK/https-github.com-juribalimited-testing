using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    internal class Capacity_SlotsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='cdk-overlay-pane small-dialogs-styling']")]
        public IWebElement MoveToPositionDialog { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@placeholder, 'Move to position')]")]
        public IWebElement MoveToPositionInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-error/span")]
        public IWebElement MoveToPositionAlert { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@aria-live='assertive'][text()='0 shown']")]
        public IWebElement NoValuesAvailableInDropDown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }

        public IWebElement RemoveTaskIcon(string taskName)
        {
            return Driver.FindElement(By.XPath($".//span[text()='{taskName}']/parent:: mat-chip/button"));
        }

        public void EnterValueByColumnName(string value, string columnName)
        {
            var byControl = By.XPath($"//thead//td[text()='{columnName}']//ancestor::table//input");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(value);
        }

        public void EnterValueByDayName(string value, string columnName)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var byControl = By.XPath($".//input[@id='{columnName.ToLower()}']");
                Driver.WaitForDataLoading();
                Driver.WaitForElementToBeDisplayed(byControl);
                Driver.FindElement(byControl).Click();
                Driver.FindElement(byControl).Clear();
                Driver.FindElement(byControl).SendKeys(value);
                Driver.ClickByJavascript(BodyContainer);
            }
        }

        public IWebElement GetLanguageLinkByName(string link)
        {
            var selector = By.XPath($"//div[@class='form-item']//a[contains(text(), '{link}')]");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Short))
                throw new Exception($"'{link}' link is not displayed");
            return Driver.FindElement(selector);
        }

        public IWebElement GetTilesByDropdownName(string dropdownName)
        {
            var selector = By.XPath($".//span[text()='{dropdownName}']//parent::mat-chip[@role='option']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetLanguageInTranslationsTableByName(string language)
        {
            var selector = By.XPath($"//div[contains(@class,'translations')]//span[text()='{language}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDisplayNameFieldByLanguage(string language)
        {
            var selector = By.XPath($"//span[text()='{language}']/../following-sibling::td//input[@name='displayName']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetMoveButtonBySlotName(string slot)
        {
            var indexRow = GetSlotContent().IndexOf(slot);
            var selector = By.XPath($".//div[@row-index='{indexRow}']/div[@col-id='dragColumn']");
            return Driver.FindElement(selector);
        }

        public IList<string> GetSlotContent()
        {
            var by = By.XPath(".//div[@col-id='slotName' and @role='gridcell']");
            Driver.WaitForElementsToBeDisplayed(by, 30, false);
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }
    }
}