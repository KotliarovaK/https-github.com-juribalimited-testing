using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class ManagementConsolePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Manage')]")]
        public IWebElement ManageLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Manage Users')]")]
        public IWebElement ManageUsersLink { get; set; }

        public IWebElement GetLinkInManagementConsoleByName(string linkName)
        {
            var selector = By.XPath($".//table[@class='table_features']/..//a[text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ManageLink)
            };
        }
    }
}