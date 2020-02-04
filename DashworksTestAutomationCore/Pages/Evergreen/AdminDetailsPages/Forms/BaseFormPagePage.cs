using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class BaseFormtPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        public IWebElement GetDropdownByName(string dropdownName)
        {
            var byControl = By.XPath($".//div//input[@placeholder='{dropdownName}']");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public IWebElement GetDropdownCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//*[contains(text(), '{checkboxName}')]//parent::label/div[@class='mat-checkbox-inner-container']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}