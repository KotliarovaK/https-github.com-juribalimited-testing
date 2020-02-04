using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Senior
{
    internal class SeniorProjectsBaseElements : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Actions']")]
        public IWebElement ActionsTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement AdministrationTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Dashboards']")]
        public IWebElement DashboardsTab { get; set; }

        public IWebElement GetSubTabByName(string subTabName)
        {
            var selector = By.XPath($".//a[text()='{subTabName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GoToTabByName(string tabName)
        {
            var selector = By.XPath($"//a[contains(@onclick, '{tabName}')]");
            Driver.WaitForElementToBeDisplayed(selector);
            Driver.FindElement(selector).Click();
        }

        public void SelectCheckboxByName(string checkboxName)
        {
            var selector = $"//td[text()='{checkboxName}']//following-sibling::td//input[@name='TaskId']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }
    }
}