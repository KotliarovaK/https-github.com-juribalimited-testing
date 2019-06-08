﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    internal class AggridHeaderCounterPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'aggrid-container')][1]")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='ResetFilters']")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='GroupBy']")]
        public IWebElement GroupByButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='reload']")]
        public IWebElement RefreshButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IWebElement GetValueInGroupByFilterOnDetailsPage(string value)
        {
            var selector = By.XPath($"//*[text()='{value}']/ancestor::label[contains(@class, 'checkbox')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}