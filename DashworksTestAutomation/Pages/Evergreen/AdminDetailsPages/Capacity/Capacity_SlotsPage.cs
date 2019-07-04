﻿using System;
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
        public const string SelectedValueTextBox = "//mat-chip[@class='mat-chip mat-primary mat-standard-chip mat-chip-with-trailing-icon ng-star-inserted']//span";

        [FindsBy(How = How.XPath, Using = "//div[@class='title-container']/h1")]
        public IWebElement TitleContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']/div[@col-id='slotName']")]
        public IList<IWebElement> GridSlotsNames { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-item']//a[contains(text(), 'See Translations')]")]
        public IWebElement LanguageTranslationsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'chips-item-text')][text()='1 more']/ancestor::button")]
        public IWebElement ExpandItemsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='cdk-overlay-pane small-dialogs-styling']")]
        public IWebElement MoveToPositionDialog { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//div[@class='dialog-small mat-dialog-content']//input[contains(@placeholder, 'Move to position')]")]
        public IWebElement MoveToPositionInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='dialog-small mat-dialog-content']//*[@role='alert']//span[1]")]
        public IWebElement MoveToPositionAlert { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@aria-live='assertive'][text()='0 shown']")]
        public IWebElement NoValuesAvailableInDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedValueTextBox)]
        public IList<IWebElement> SelectedValuesList { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TitleContainer)
            };
        }


        public IWebElement RemoveTaskIcon(string taskName)
        {
            return Driver.FindElement(By.XPath($".//span[text()='{taskName}']/parent:: mat-chip/button"));
        }

        public void EnterValueByColumnName(string value, string columnName)
        {
            var byControl =By.XPath($"//thead//td[text()='{columnName}']//ancestor::table//input");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(value);
        }

        public void EnterValueByDayName(string value, string columnName)
        {
            var byControl = By.XPath($".//input[@id='{columnName.ToLower()}']");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(value);
        }

        public void ClickDropdownByName(string dropdownName)
        {
            var byControl = By.XPath($"//div//input[@placeholder='{dropdownName}']");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public IWebElement GetLanguageLinkByName(string link)
        {
            var selector = By.XPath($"//div[@class='form-item']//a[contains(text(), '{link}')]");
            Driver.WaitForElementToBeDisplayed(selector);
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

        public IWebElement GetCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//div[@role='presentation']//span[text()='{checkboxName}']");
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
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public IWebElement GetMoveToPositionDialogButtonByText(string buttonText)
        {
            var selector = By.XPath($"//div[@class='dialog-small mat-dialog-content']/following-sibling :: div//button/span[contains(text(), '{buttonText.ToUpper()}')]/parent :: button");
            return Driver.FindElement(selector);
        }
    }
}