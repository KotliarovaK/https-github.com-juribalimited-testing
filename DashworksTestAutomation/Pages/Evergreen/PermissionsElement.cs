﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class PermissionsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'context-container')]//div[contains(@class, 'header')]/span[contains(text(), 'Permissions')]")]
        public IWebElement PermissionsPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PermissionsPanel)
            };
        }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-labelledby='sharing-label']")]
        public IWebElement SharingDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Owner']")]
        public IWebElement OwnerDropdown { get; set; }

        public string GetSelectedValue(IWebElement dropdown)
        {
            return dropdown.FindElement(By.XPath(".//span[contains(@class, 'mat-select-value-text')]/span")).Text;
        }
    }
}