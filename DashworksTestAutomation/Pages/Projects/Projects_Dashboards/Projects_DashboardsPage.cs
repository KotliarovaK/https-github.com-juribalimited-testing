using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Projects_DashboardsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//select[contains(@name, 'ProjectId')]")]
        public IWebElement ProjectDropDown { get; set; }

        public void GetGroupInTableByName(string groupName)
        {
            var selector = string.Empty;

            if (groupName.Contains("'"))
            {
                var strings = groupName.Split('\'');
                selector = $"//td[contains(@aria-describedby, 'GroupName')]//a[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $"//td[contains(@aria-describedby, 'GroupName')]//a[text()='{groupName}']";
            }
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void GetProjectByNameOnToolbar(string projectName)
        {
            var selector = string.Empty;

            if (projectName.Contains("'"))
            {
                var strings = projectName.Split('\'');
                selector = $".//select[contains(@name, 'ProjectId')]//option[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//select[contains(@name, 'ProjectId')]//option[text()='{projectName}']";
            }
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }
    }
}
