﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Base;
using Autotest.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Autotest.Pages
{
    class EvergreenDashboardsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@class='form-control search-input ng-untouched ng-pristine ng-valid']")]
        public IWebElement SearchTextbox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.SearchTextbox)
            };
        }
    }
}
