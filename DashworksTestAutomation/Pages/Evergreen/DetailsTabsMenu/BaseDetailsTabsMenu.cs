using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class BaseDetailsTabsMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-tab-labels']/div[contains(text(),'Details')]")]
        public IWebElement DevicesTab { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.DevicesTab)
            };
        }

        public void NavigateToTabByName(string tabName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//div[@class='mat-tab-labels']/div[contains(text(),'{tabName}')]"));
            tab.Click();
        }
    }
}