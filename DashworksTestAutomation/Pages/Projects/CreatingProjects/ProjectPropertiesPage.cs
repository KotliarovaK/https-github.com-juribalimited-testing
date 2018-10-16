using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class ProjectPropertiesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@title='Project Name']")]
        public IWebElement ProjectName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@title='Project Short Name']")]
        public IWebElement ProjectShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@title='Project Description']")]
        public IWebElement ProjectDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@title='Project Type']")]
        public IWebElement ProjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@title='Default Language']")]
        public IWebElement DefaultLanguage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ProjectName),
                SelectorFor(this, p => p.ProjectShortName),
                SelectorFor(this, p => p.ProjectDescription),
                SelectorFor(this, p => p.DefaultLanguage)
            };
        }
    }
}