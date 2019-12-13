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
        [FindsBy(How = How.XPath, Using = ".//mat-drawer-content[@id='content']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Elements']")]
        public IWebElement ElementsTable { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By> { };
        }

        public IList<IWebElement> GetColumnSettings()
        {
            return Driver.FindElements(By.XPath(".//div[contains(@class, 'menu-option')]//span[@ref='eName']"));
        }

        public bool GetTheDisplayStateOfContentOnOpenTab(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@class='table-responsive ng-star-inserted']//span[text()='{name}']"));
        }

        public bool CheckThatSelectedTabHasOpened(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($"//*[text()='{name}']"));
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