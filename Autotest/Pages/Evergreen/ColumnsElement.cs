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
    class ColumnsElement : SeleniumBasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".columns-panel")]
        public IWebElement ColumnsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Minimize Group']")]
        public IWebElement MinimizeGroupButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.ColumnsPanel),
                SelectorFor(this, p=> p.SearchTextbox),
                SelectorFor(this, p=> p.MinimizeGroupButton)
            };
        }

        public void AddColumn(string columnName)
        {
            SearchTextbox.SendKeys(columnName);
            var selector = By.XPath($".//span[.='{columnName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
            Driver.WaitForDataLoading();
        }
    }
}
