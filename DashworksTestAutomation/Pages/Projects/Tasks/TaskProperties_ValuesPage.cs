using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.Tasks
{
    internal class TaskProperties_ValuesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'name')]")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'description')]")]
        public IWebElement Help { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='selectedItemBox']")]
        public IWebElement ReadinessClick { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[contains (@class, 'listItems')]//li")]
        public IWebElement Readiness { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@name, 'TaskStatus')]")]
        public IWebElement TaskStatus { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@name, 'MakeDefault')]")]
        public IWebElement DefaultValue { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Help),
                //SelectorFor(this, p => p.Readiness),
                //SelectorFor(this, p => p.TaskStatus),
                //SelectorFor(this, p => p.DefaultValue),
            };
        }
    }
}