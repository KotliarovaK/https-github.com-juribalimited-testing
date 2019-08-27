using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class UserProfilePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Change Password']")]
        public IWebElement ChangePasswordButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[@role='alert']")]
        public IWebElement NotificationBanner { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }
    }
}