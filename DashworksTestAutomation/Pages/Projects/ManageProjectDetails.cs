using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class ManageProjectDetails : SeleniumBasePage
    {
        public IWebElement GetTabElementByName(string tabName)
        {
            var selector = By.XPath($".//a[@style='font-weight:normal;'][text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonElementByName(string buttonName)
        {
            var selector = By.XPath($".//input[@value='{buttonName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}