﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class BaseDetailsTabsMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-tab-label-content'][text()='Details']")]
        public IWebElement DevicesTab { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.DevicesTab)
            };
        }
    }
}