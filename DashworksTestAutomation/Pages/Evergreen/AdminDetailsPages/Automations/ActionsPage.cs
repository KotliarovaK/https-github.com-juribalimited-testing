using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class ActionsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Automations')]")]
        public IWebElement AutomationsLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select//div[@class='mat-select-value']/span[contains(@class, 'placeholder')]")]
        public IWebElement ValueDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']//div[@role='gridcell']")]
        public IWebElement ActionsTableContent { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AutomationsLink)
            };
        }
    }
}