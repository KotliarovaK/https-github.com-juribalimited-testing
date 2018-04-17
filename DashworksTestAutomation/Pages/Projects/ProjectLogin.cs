using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    public class ProjectLogin : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Projects']")]
        public IWebElement ProjectsLink { get; set; }
    }
}