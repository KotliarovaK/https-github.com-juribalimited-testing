using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    //!!!Element with header and breadcrumbs under grid!!!
    public class BaseHeaderElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement Header { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Header)
            };
        }

        public void CheckPageHeader(string text)
        {
            Verify.AreEqual(text.ToLower(), Header.Text.ToLower(), "Incorrect page header");
        }

        public void CheckPageHeaderContainsText(string text)
        {
            Verify.IsTrue(Header.Text.ToLower().Contains(text.ToLower()), $"Page header do not contains '{text}' text");
        }
    }
}
