using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class ProjectLogin : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Projects')]")]
        public IWebElement ProjectsLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(text(), 'Evergreen')]")]
        public IWebElement EvergreenLink { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ProjectsLink)
            };
        }
    }
}