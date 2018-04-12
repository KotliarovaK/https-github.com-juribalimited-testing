using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ProjectsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[text()='Projects']")]
        public IWebElement ProjectsPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE PROJECT']")]
        public IWebElement CreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement CreateProjectButtonOnCreateProjectPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Project Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement ProjectNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[@for='scope']span[@class='mat-form-field-label-wrapper mat-input-placeholder-wrapper mat-form-field-placeholder-wrapper']")]
        public IWebElement SelectScopeProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role='combobox']")]
        public IWebElement ScopeProjectField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ProjectsPageTitle),
            };
        }

        public void SelectListForProjectCreation(string listName)
        {
            string ListNameSelector = $".//span[@class='mat-option-text'][text()=' {listName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }

        public void SelectProjectByName(string ProjectName)
        {
            string ProjectNameSelector = $".//a[text()='{ProjectName}']";
            Driver.FindElement(By.XPath(ProjectNameSelector)).Click();
        }
    }
}