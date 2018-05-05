using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.ManagementConsole
{
    internal class ManageUserPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Create a new Dashworks User']")]
        public IWebElement CreateNewUserButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'UserName')]")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'FullName')]")]
        public IWebElement FullName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'NewPwd')]")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ConfirmPwd')]")]
        public IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create User']")]
        public IWebElement CreateUserButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.CreateNewUserButton)
            };
        }
    }
}