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
    }
}
