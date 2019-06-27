using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    class ActionPanelPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='top-tools']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@name='actions']")]
        public IWebElement ActionsDropDown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IWebElement GetActionButtonByName(string name)
        {
            var selector = By.XPath($".//span[@class='mat-accent'][text()='{name}']/ancestor::mat-option");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
