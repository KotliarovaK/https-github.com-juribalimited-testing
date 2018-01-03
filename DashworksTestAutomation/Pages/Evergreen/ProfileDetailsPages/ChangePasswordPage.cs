using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    class ChangePasswordPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath,
            Using = ".//span[text()='Current Password']/ancestor::div[@class='form-item']//input")]
        public IWebElement CurrentPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='New Password']/ancestor::div[@class='form-item']//input")]
        public IWebElement NewPassword { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//span[text()='Confirm Password']/ancestor::div[@class='form-item']//input")]
        public IWebElement ConfirmPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='UPDATE']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success']")]
        public IWebElement SuccessMessage { get; set; }

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