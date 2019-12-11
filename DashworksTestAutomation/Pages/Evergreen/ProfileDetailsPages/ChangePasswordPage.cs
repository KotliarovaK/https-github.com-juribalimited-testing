using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class ChangePasswordPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath,
            Using = ".//input[@aria-label='Current Password']")]
        public IWebElement CurrentPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='New Password']")]
        public IWebElement NewPassword { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Confirm Password']")]
        public IWebElement ConfirmPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button/span[text()='UPDATE']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button/i[@class='material-icons mat-clear']")]
        public IWebElement CloseMessageButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CurrentPasswordField),
                SelectorFor(this, p => p.NewPassword),
                SelectorFor(this, p => p.ConfirmPasswordField),
                SelectorFor(this, p => p.UpdateButton)
            };
        }
    }
}