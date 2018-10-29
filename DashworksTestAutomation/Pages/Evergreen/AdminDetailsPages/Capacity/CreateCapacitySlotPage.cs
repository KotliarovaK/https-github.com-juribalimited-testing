using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    internal class CreateCapacitySlotPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h2[contains(text(),'Capacity Slot')]")]
        public IWebElement CreateSlotsTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Unlimited']")]
        public IWebElement UnlimitedField { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-form-field[contains(@class, 'mat-focused')]")]
        public IWebElement EmptyUnlimitedField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateSlotsTitle)
            };
        }

        public void EnterValueToTheDateByPlaceholder(string value, string placeholder)
        {
            var byControl = By.XPath($".//das-datepicker/*//input[@placeholder='{placeholder}']");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).ClearWithBackspaces();
            Driver.FindElement(byControl).SendKeys(value);
        }

        public string GetValueFromDateByPlaceholder(string placeholder)
        {
            var byControl = By.XPath($".//das-datepicker/*//input[@placeholder='{placeholder}']");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);

            return Driver.FindElement(byControl).GetAttribute("value");
        }
    }
}
