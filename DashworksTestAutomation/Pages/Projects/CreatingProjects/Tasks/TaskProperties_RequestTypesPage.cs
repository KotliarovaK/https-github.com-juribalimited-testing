using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks
{
    internal class TaskProperties_RequestTypesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SaveRequestType')]")]
        public IWebElement SaveRequestTypeButton { get; set; }

        public IWebElement GetRequestTypeCheckboxByName(string requestTypeName)
        {
            var selector = By.XPath($".//td[text()='{requestTypeName}']/..//input");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
