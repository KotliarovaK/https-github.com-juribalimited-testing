using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    class AccountDetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//button[@title='Upload']")]
        public IWebElement UploadButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Remove']")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='UPDATE']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Full Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement FullNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Email']/ancestor::div[@class='form-item']//input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='roles']/li")]
        public IList<IWebElement> RolesList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error']")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success']")]
        public IWebElement SuccessMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.UploadButton),
                SelectorFor(this, p => p.RemoveButton),
                SelectorFor(this, p => p.UpdateButton),
                SelectorFor(this, p => p.FullNameField),
                SelectorFor(this, p => p.EmailField),
                SelectorFor(this, p => p.RolesList),
            };
        }
    }
}