using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.Capacity
{
    internal class Capacity_SummaryPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//table[@class='grid capacitySummaryGrid']")]
        public IWebElement Table { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Table)
            };
        }

        public IWebElement GetDefaultRequestTypeByName(string requestType)
        {
            var selector = By.XPath($".//select[contains(@id, 'Summary_RequestType')]/..//option[contains(text(), '{requestType}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}