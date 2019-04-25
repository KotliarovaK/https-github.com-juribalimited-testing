using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    internal class TabContent : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//mat-sidenav-content[@id='content']")]
        public IWebElement PageIdentitySelectors { get; set; }


        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IWebElement GetItemDetailsPageByName(string name)
        {
            var selector = By.XPath($".//div[@id='pagetitle-text']//h1[contains(text(), '{name}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetTheDisplayStateOfContentOnOpenTab(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($"//div[contains(@class, 'details-bordered-box')]//span[text()='{name}']"));
        }
    }
}
