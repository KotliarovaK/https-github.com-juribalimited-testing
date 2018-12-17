using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class LeftHandMenuElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//span[text()='Devices']")]
        public IWebElement Devices { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Users']")]
        public IWebElement Users { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Applications']")]
        public IWebElement Applications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Mailboxes']")]
        public IWebElement Mailboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Projects']")]
        public IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Admin']")]
        public IWebElement Admin { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Devices),
                SelectorFor(this, p => p.Users),
                SelectorFor(this, p => p.Applications),
                SelectorFor(this, p => p.Mailboxes),
                SelectorFor(this, p => p.Admin)
            };
        }
    }
}