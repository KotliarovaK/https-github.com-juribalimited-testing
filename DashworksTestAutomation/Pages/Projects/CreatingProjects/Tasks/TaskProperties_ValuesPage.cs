using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks
{
    internal class TaskProperties_ValuesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeader { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeader)
            };
        }

        public void NavigateToSelectedValue(string color)
        {
            var selector = By.XPath($".//a[text()='{color}']");
            Driver.WaitForElementToBeDisplayed(selector);
            Driver.FindElement(selector).Click();
        }
    }
}