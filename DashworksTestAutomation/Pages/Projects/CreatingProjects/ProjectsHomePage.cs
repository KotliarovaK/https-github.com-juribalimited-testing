using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class ProjectsHomePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Make Default']")]
        public IWebElement MakeDefaultButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'ProjectID')]")]
        public IWebElement ProjectDropDownList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//p[contains(text(),'Default Project News Title')]")]
        public IWebElement DefaultProjectNewsTitle { get; set; }

        public IWebElement GetProjectInDropDownListByName(string projectName)
        {
            var selector = By.XPath($".//option[contains(text(), '{projectName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ProjectDropDownList)
            };
        }
    }
}