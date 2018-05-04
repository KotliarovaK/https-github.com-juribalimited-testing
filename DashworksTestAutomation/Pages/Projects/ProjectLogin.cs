using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class ProjectLogin : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Projects']")]
        public IWebElement ProjectsLink { get; set; }

        public IWebElement GetLinkByName(string linkName)
        {
            var selector = By.XPath($".//a[text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}