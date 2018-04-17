using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class NavigationTabsMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Details']")]
        public IWebElement DetailsTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_RequestTypes']")]
        public IWebElement RequestTypesTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_SubCategories']")]
        public IWebElement CategoriesTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Stages']")]
        public IWebElement StagesTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Tasks']")]
        public IWebElement TasksTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Teams']")]
        public IWebElement TeamsTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Users']")]
        public IWebElement UsersTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Groups']")]
        public IWebElement GroupsTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_MailTemplates']")]
        public IWebElement MailTemplatesTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_News']")]
        public IWebElement NewsTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_SelfService']")]
        public IWebElement SelfServiceTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@id='ctl00_MainContent_PMManageNav_LB_Capacity']")]
        public IWebElement CapacityTab { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.DetailsTab),
                SelectorFor(this, p => p.RequestTypesTab),
                SelectorFor(this, p => p.CategoriesTab),
                SelectorFor(this, p => p.StagesTab),
                SelectorFor(this, p => p.TasksTab),
                SelectorFor(this, p => p.TeamsTab),
                SelectorFor(this, p => p.UsersTab),
                SelectorFor(this, p => p.GroupsTab),
                SelectorFor(this, p => p.MailTemplatesTab),
                SelectorFor(this, p => p.NewsTab),
                SelectorFor(this, p => p.SelfServiceTab),
                SelectorFor(this, p => p.CapacityTab),
            };
        }
    }
}