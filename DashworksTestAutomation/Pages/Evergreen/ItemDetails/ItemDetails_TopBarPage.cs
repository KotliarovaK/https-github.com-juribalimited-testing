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
    internal class ItemDetails_TopBarPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='topbar']")]
        public IWebElement PageIdentitySelectors { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public List<string> GetComplianceItemsOnTopBar()
        {
            var selector = By.XPath("//div[@class='topbar-item-label']");
            return Driver.FindElements(selector).Select(x => x.Text).ToList();
        }
    }
}