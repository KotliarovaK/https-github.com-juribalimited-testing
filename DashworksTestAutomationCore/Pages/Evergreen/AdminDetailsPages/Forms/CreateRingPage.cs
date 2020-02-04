﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class CreateRingPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]/h2")]
        public IWebElement CreateRingFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[@class='mat-checkbox-layout']/span[text()='Default Ring']")]
        public IWebElement DefaultRingCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement CreateRingButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='description']")]
        public IWebElement DescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='evergreenRings']")]
        public IWebElement MapsToEvergreenField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateRingFormTitle)
            };
        }

        public void SelectOptionInMapsToEvergreenRingDropdown(string option)
        {
            var listNameSelector = $"//span[@class='mat-option-text' and contains(text(), '{option}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }
    }
}