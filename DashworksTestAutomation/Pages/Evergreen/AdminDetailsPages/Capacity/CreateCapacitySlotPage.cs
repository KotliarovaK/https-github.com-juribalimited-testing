using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    internal class CreateCapacitySlotPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//h2[text()='Create Capacity Slot']")]
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
    }
}
