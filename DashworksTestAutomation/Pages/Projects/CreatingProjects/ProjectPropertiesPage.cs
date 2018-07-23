using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class ProjectPropertiesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Project Name']")]
        public IWebElement ProjectName { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Project Short Name']")]
        public IWebElement ProjectShortName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Project Description']")]
        public IWebElement ProjectDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Project Type']")]
        public IWebElement ProjectType { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[@aria-label='Default Language']")]
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

        public void SelectProjectLanguage(string language)
        {
            string ListNameSelector = $"//span[@class='mat-option-text'][text()='{language}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }
    }
}