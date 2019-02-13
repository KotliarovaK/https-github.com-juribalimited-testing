using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class AccountDetailsPage : SeleniumBasePage
    {
        public const string RoleSelector = "//li[@class='ng-star-inserted']/span";

        [FindsBy(How = How.XPath, Using = ".//input[@id='fileUploader']")]
        public IWebElement UploadButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()= 'REMOVE']/ancestor::button")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Full Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement FullNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Email']/ancestor::div[@class='form-item']//input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='roles']/li")]
        public IList<IWebElement> RolesList { get; set; }
  
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//li//span[text()='Account Details']")]
        public IWebElement AccountDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button/i[@class='material-icons mat-clear']")]
        public IWebElement CloseMessageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='user-profile']//div[@class='img-bg']")]
        public IWebElement UserPicture { get; set; }

        [FindsBy(How = How.XPath, Using = RoleSelector)]
        public IList<IWebElement> AvailableRoles { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.UpdateButton),
                SelectorFor(this, p => p.FullNameField),
                SelectorFor(this, p => p.EmailField),
                SelectorFor(this, p => p.RolesList)
            };
        }

        public void NavigateToPage(string pageName)
        {
            Driver.FindElement(By.XPath($".//span[text()='{pageName}']")).Click();
        }
    }
}