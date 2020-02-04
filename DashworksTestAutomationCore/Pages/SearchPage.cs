using System;
using System.Collections.Generic;
using System.Text;
using DashworksTestAutomation.Base;
using DashworksTestAutomationCore.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomationCore.Pages
{
    class SearchPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/input[@role='combobox']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@type='submit']")]
        public IWebElement SearchButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p=> p.SearchTextbox)
            };
        }
    }
}
