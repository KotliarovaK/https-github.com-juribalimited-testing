using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class BaseProjectsElements : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[text()='Projects Home']")]
        public IWebElement ProjectsHomePage { get; set; }

        #region Navigation Tab
        [FindsBy(How = How.XPath, Using = ".//a[text()='Onboarding']")]
        public IWebElement Onboarding { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//a[text()='Actions']")]
        //public IWebElement Actions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Dashboards']")]
        public IWebElement Dashboards { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Reporting']")]
        public IWebElement Reporting { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement Administration { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Create Project']")]
        public IWebElement CreateProject { get; set; }
#endregion
    }
}