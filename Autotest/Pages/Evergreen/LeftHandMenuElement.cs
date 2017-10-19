using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Base;
using Autotest.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Autotest.Pages.Evergreen
{
    class LeftHandMenuElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[@title='Devices']")]
        public IWebElement Devices { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Users']")]
        public IWebElement Users { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Applications']")]
        public IWebElement Applications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Mailboxes']")]
        public IWebElement Mailboxes { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.Devices),
                SelectorFor(this, p=> p.Users),
                SelectorFor(this, p=> p.Applications),
                SelectorFor(this, p=> p.Mailboxes)
            };
        }
    }
}
