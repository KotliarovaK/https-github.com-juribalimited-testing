using System;
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
    class LogoutPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[text()='Signed Out']")]
        public IWebElement SignedOutLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Signed Out']//following-sibling::p")]
        public IWebElement SignedOutMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.SignedOutLabel),
                SelectorFor(this, p=> p.SignedOutMessage)
            };
        }
    }
}
