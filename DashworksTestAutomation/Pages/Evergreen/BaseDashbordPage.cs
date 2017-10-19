using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class BaseDashbordPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-text']/descendant::h1")]
        public IWebElement Heading { get; set; }

        [FindsBy(How = How.Id, Using = "_clmnBtn")]
        public IWebElement Column { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class,'test-dg-vsbl')]")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='rowCount']")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']")]
        public IWebElement TableBody { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='save-action-bar']//span[text()='Save']")]
        public IWebElement SaveCustomListButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p=> p.Heading),
                SelectorFor(this, p=> p.List)
            };
        }

        public bool IsColumnPresent(string columnName)
        {
            var selector = By.XPath($"//div[@role='presentation']/span[text()='{columnName}']");
            return Driver.IsElementDisplayed(selector);
        }
    }
}
