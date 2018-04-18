using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class TaskPropertiesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_TB_TaskName']")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_TB_Help']")]
        public IWebElement Help { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_StageID']")]
        public IWebElement StageName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_TaskTypes']")]
        public IWebElement TaskType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_TaskControlTypeID']")]
        public IWebElement ValueType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_ObjectTypeID']")]
        public IWebElement ObjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_TaskTemplateID']")]
        public IWebElement TaskValuesTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@type='checkbox']")]
        public IWebElement TaskValuesTemplateCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_Create']")]
        public IWebElement ConfirmCreateTaskButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Help),
                SelectorFor(this, p => p.TaskType),
                SelectorFor(this, p => p.ValueType),
                SelectorFor(this, p => p.ObjectType),
                SelectorFor(this, p => p.TaskValuesTemplate),
                SelectorFor(this, p => p.TaskValuesTemplateCheckbox)
            };
        }
    }
}
