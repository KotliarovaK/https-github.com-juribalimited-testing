using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class DevicesDetailsTabsMenu : BaseDetailsTabsMenu
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-tab-labels']/div[contains(text(),'Specification')]")]
        public IWebElement SpecificationTab { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.SpecificationTab)
            };
        }
    }
}