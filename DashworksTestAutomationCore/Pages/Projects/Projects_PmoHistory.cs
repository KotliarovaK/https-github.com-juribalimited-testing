using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Projects_PmoHistory : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@id, 'ctl00_MainContent_DDL_ProjectID')]")]
        public IWebElement ProjectSelector { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }
        public IWebElement GetHistoryValueByName(string objName)
        {
            var selector = By.XPath($".//caption[contains(text(), 'History')]/parent::table//a[text()='{objName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}