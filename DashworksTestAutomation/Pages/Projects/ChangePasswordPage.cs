using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class ChangePasswordPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ExistingPwd')]")]
        public IWebElement CurrentPasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'NewPwd')]")]
        public IWebElement NewPasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ConfirmPwd')]")]
        public IWebElement ConfirmNewPasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Change Password']")]
        public IWebElement ChangePasswordButton { get; set; }


        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }
    }
}