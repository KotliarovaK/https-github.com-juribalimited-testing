using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.Projects_Dashboards
{
    internal class Projects_DashboardsGroupsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='ui-jqgrid-bdiv']//table[contains(@id,'GroupObjectsDashboard')]")]
        public IWebElement Table { get; set; }

        public IWebElement GetPageHeaderByGroupName(string groupName)
        {
            var selector = By.XPath($"//div[contains(@class, 'ui-helper-clearfix')]//span[text()='{groupName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
