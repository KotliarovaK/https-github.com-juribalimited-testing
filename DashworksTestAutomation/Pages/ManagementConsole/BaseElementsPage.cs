using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.ManagementConsole
{
    internal class BaseElementsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Dashworks User Site')]")]
        public IWebElement DashworksUserSiteLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), '[Logout]')]")]
        public IWebElement LogoutLink { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.DashworksUserSiteLink)
            };
        }
    }
}