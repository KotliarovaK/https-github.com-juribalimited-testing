using System;
using System.Collections.Generic;
using System.Text;
using DashworksTestAutomation.Base;
using DashworksTestAutomationCore.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomationCore.Pages
{
    class ResultsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/input[@role='combobox']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h3/parent::a")]
        public IList<IWebElement> SearchResultsLinks { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/div/div/div/input[@role='combobox1']")]
        public IWebElement TestElement { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p=> p.SearchTextbox)
            };
        }
    }
}
