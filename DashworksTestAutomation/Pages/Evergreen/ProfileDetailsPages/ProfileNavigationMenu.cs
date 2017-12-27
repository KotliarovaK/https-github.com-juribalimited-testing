using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
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
    }
}
