using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks
{
    internal class TaskPropertiesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'TaskName')]")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Help')]")]
        public IWebElement Help { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'StageID')]")]
        public IWebElement StageName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'TaskTypes')]")]
        public IWebElement TaskType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'TaskControlTypeID')]")]
        public IWebElement ValueType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'ObjectTypeID')]")]
        public IWebElement ObjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'TaskTemplateID')]")]
        public IWebElement TaskValuesTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@id, 'UpdatePanel')]//select[@disabled='disabled']")]
        public IWebElement DisabledTaskValuesTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllRequestTypes')]")]
        public IWebElement ApplyToAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Task']")]
        public IWebElement ConfirmCreateTaskButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Help),
                SelectorFor(this, p => p.StageName),
                SelectorFor(this, p => p.TaskType),
                SelectorFor(this, p => p.ValueType),
                SelectorFor(this, p => p.ObjectType),
                SelectorFor(this, p => p.TaskValuesTemplate),
                SelectorFor(this, p => p.ApplyToAllCheckbox)
            };
        }
    }
}