using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.ManagementConsole
{
    internal class ManageUserPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Create a new Dashworks User']")]
        public IWebElement CreateNewUserButton { get; set; }
    }
}