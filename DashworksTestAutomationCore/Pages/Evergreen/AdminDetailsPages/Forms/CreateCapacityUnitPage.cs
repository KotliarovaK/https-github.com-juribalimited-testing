using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class CreateCapacityUnitPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]//h2")]
        public IWebElement CreateCapacityUnitTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Capacity Unit Name']")]
        public IWebElement CapacityNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Description']")]
        public IWebElement CapacityDescriptionField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateCapacityUnitTitle)
            };
        }

      
    }
}
