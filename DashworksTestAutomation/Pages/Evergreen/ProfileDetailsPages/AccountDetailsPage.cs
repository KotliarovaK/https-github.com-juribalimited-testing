using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    class AccountDetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='fileUploader']")]
        public IWebElement UploadButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-describedby='cdk-describedby-message-13']")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@aria-describedby='cdk-describedby-message-15']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Full Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement FullNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Email']/ancestor::div[@class='form-item']//input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='roles']/li")]
        public IList<IWebElement> RolesList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error ng-star-inserted']")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='user-profile']//div[@class='img-bg']")]
        public IWebElement UserPicture { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.RemoveButton),
                SelectorFor(this, p => p.UpdateButton),
                SelectorFor(this, p => p.FullNameField),
                SelectorFor(this, p => p.EmailField),
                SelectorFor(this, p => p.RolesList),
            };
        }
    }
}