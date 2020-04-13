using System;
using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Scope
{
    public class ScopeChangePage : SeleniumBasePage
    {
        public static string TabSelector = ".//div[contains(@class,'mat-tab-label')][@role='tab']//span[contains(text(),'{0}')]";

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'scope-block-tabs')]")]
        public IWebElement ScopeBlockTabs { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[contains(@class, 'mat-checkbox-checked')]")]
        public IWebElement CheckedAllItemCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-pseudo-checkbox[contains(@class, 'checkbox-checked')]")]
        public IWebElement CheckedSomeItemCheckbox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ScopeBlockTabs)
            };
        }

        public IWebElement GetTabByName(string tabName)
        {
            var selector = By.XPath(string.Format(TabSelector, tabName));
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Short))
                throw new Exception($"'{tabName}' tab was not displayed on Scope Page");
            return Driver.FindElement(selector);
        }

        public bool IsTabDisplayed(string tabName)
        {
            try
            {
                return GetTabByName(tabName).Displayed();
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
