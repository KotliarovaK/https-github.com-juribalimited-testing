using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Pages
{
    internal class ManagementConsolePage : SeleniumBasePage
    {
        public IWebElement GetLinkInManagementConsoleByName(string linkName)
        {
            var selector = By.XPath($".//table[@class='table_features']/..//a[text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}