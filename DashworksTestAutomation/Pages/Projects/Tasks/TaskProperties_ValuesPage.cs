using System.Collections.Generic;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
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
        public IWebElement ReadinessListClick { get; set; }

        private const string Readiness = ".//input[contains(@class, 'option_value')]/../label[text()='{0}']";

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
            };
        }

        public void SelectOnboardedApplications(ReadinessEnum color)
        {
            ReadinessListClick.Click();
            string selector = string.Format(Readiness, color.GetValue());
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }
    }
}