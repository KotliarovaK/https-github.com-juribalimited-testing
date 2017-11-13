using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    class BaseDetailsTabsMenu : SeleniumBasePage
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