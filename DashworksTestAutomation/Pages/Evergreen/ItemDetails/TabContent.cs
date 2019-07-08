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
    internal class TabContent : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//mat-sidenav-content[@id='content']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Elements']")]
        public IWebElement ElementsTable { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public bool GetTheDisplayStateOfContentOnOpenTab(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($"//span[text()='{name}']/ancestor::td[@class='fld-label']"));
        }

        public bool CheckThatSelectedTabHasOpened(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($"//*[text()='{name}']"));
        }

        public IWebElement GetItemDetailsPageByName(string name)
        {
            var selector = By.XPath($".//div[@id='pagetitle-text']//h1[contains(text(), '{name}')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetColorIconsForColorFilters(string color)
        {
            var selector = By.XPath($"//span[@class='status-text'][text()='{color}']/../div");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetContentDisplayState(string text)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[text()='{text}']"));
        }
    }
}
