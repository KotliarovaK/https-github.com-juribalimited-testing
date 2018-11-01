﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    internal class Capacity_SlotsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='title-container']/h1")]
        public IWebElement TitleContainer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-item']//a[contains(text(), 'See Translations')]")]
        public IWebElement LanguageTranslationsLink { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TitleContainer)
            };
        }

        public void EnterValueByColumnName(string value, string columnName)
        {
            var byControl =By.XPath($"//thead//td[text()='{columnName}']//ancestor::table//input");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).Clear();
            Driver.FindElement(byControl).SendKeys(value);
        }

        public void ClickDropdownByName(string dropdownName)
        {
            var byControl = By.XPath($"//div//input[@placeholder='{dropdownName}']");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public IWebElement GetLanguageLinkByName(string link)
        {
            var selector = By.XPath($"//div[@class='form-item']//a[contains(text(), '{link}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetLanguageInTranslationsTableByName(string language)
        {
            var selector = By.XPath($"//div[contains(@class,'translations')]//span[text()='{language}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}