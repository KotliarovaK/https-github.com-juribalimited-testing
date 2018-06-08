using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Projects_DashboardsPage : SeleniumBasePage
    {
        public IWebElement GetGroupInTableByName(string groupName)
        {
            var selector = By.XPath($"//td[contains(@aria-describedby, 'GroupName')]//a[text()='{groupName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GetProjectByNameOnToolbar(string projectName)
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath(".//select[contains(@name, 'ProjectId')]"));
            var selectbox =
                Driver.FindElement(By.XPath(".//select[contains(@name, 'ProjectId')]"));
            Driver.SelectCustomSelectbox(selectbox, projectName);
        }
    }
}
