using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.Capacity
{
    internal class Capacity_SummaryPage : BaseDashboardPage
    {

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'RequestType')]")]
        public IWebElement RequestType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//tr[@class='grid-headerstyle']")]
        public IWebElement Table { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.RequestType)
            };
        }
    }
}