using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class LeftHandMenuElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//p[@title='Devices']")]
        public IWebElement Devices { get; set; }

        [FindsBy(How = How.XPath, Using = ".//p[@title='Users']")]
        public IWebElement Users { get; set; }

        [FindsBy(How = How.XPath, Using = ".//p[@title='Applications']")]
        public IWebElement Applications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//p[@title='Mailboxes']")]
        public IWebElement Mailboxes { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Devices),
                SelectorFor(this, p => p.Users),
                SelectorFor(this, p => p.Applications),
                SelectorFor(this, p => p.Mailboxes)
            };
        }
    }
}