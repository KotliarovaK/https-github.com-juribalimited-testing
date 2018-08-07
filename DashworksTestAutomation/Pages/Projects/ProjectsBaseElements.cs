using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class ProjectsBaseElements : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement AdministrationTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Dashboards']")]
        public IWebElement DashboardsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@aria-label='Additional Tasks']")]
        public IWebElement AdditionalTasks { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@class, 'addAdditionalTask')]")]
        public IWebElement AddAdditionalTasks { get; set; }

        public IWebElement OpenMainTabByName(string mainTabName)
        {
            var selector = By.XPath($".//ul[contains(@id, 'Menu')]/../following-sibling::li/a[text()='{mainTabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubTabByName(string subTabName)
        {
            var selector = By.XPath($".//a[text()='{subTabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GoToTabByName(string tabName)
        {
            var selector = By.XPath($"//a[contains(@onclick, '{tabName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
        }

        public void SelectCheckboxByName(string checkboxName)
        {
            string selector = $"//td[text()='{checkboxName}']//following-sibling::td//input[@name='TaskId']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public IWebElement SelectTaskByName(string taskName)
        {
            var selector = By.XPath($"//select[@aria-label='Additional Tasks']/option[text()='{taskName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
