using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    class ProfileNavigationMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//span[@title='Account Details']")]
        public IWebElement AccountDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@title='Change Password']")]
        public IWebElement ChangePassword { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@title='Preferences']")]
        public IWebElement Preferences { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@title='Advanced']")]
        public IWebElement Advanced { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AccountDetails),
                SelectorFor(this, p => p.ChangePassword),
                SelectorFor(this, p => p.Preferences),
                SelectorFor(this, p => p.Advanced)
            };
        }

    }
}
