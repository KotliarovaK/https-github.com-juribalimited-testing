using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks
{
    internal class TaskProperties_CreatingValuesPage : SeleniumBasePage
    {
        private const string Readiness = ".//input[contains(@class, 'option_value')]/../label[text()='{0}']";

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'name')]")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'description')]")]
        public IWebElement Help { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@id, 'ColourStatusID')]")]
        public IWebElement ReadinessListClick { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@id, 'ColourStatusID')]//li")]
        public IList<IWebElement> ReadinessOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@name, 'TaskStatus')]")]
        public IWebElement TaskStatus { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@name, 'MakeDefault')]")]
        public IWebElement DefaultValue { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Help)
            };
        }

        public KeyValuePair<int, string> GetRandomReadinessOption(int index)
        {
            ReadinessListClick.Click();
            return new KeyValuePair<int, string>(index, ReadinessOptions[index].Text);
        }

        public KeyValuePair<int, string> SelectReadiness()
        {
            return SelectReadiness(TestDataGenerator.RandomNum(5));
        }

        public KeyValuePair<int, string> SelectReadiness(int index)
        {
            var option = GetRandomReadinessOption(index);
            var selector = string.Format(Readiness, option.Value);
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
            return option;
        }
    }
}