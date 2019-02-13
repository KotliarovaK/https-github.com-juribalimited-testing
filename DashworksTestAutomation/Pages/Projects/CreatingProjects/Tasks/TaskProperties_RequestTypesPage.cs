using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks
{
    internal class TaskProperties_RequestTypesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SaveRequestType')]")]
        public IWebElement SaveRequestTypeButton { get; set; }

        public void GetRequestTypeCheckboxByName(string requestTypeName)
        {
            var selector =
                By.XPath(
                    $".//table[@class='grid']//tr[not(@class='grid-headerstyle')][@class='grid-alternatingrowstyle' or @class='grid-rowstyle']//a[text()='{requestTypeName}']/../..//input");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
        }
    }
}