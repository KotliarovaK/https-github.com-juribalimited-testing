using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class CreateProjectPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]//*/h2")]
        public IWebElement CreateProjectFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE PROJECT']")]
        public IWebElement CreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'mat-raised-button')]/span[text()='CANCEL']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Project Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement ProjectNameField { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//label[@for='scope']span[@class='mat-form-field-label-wrapper mat-input-placeholder-wrapper mat-form-field-placeholder-wrapper']")]
        public IWebElement SelectScopeProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role='combobox']")]
        public IWebElement ScopeProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement UpdateProjectButton { get; set; }


        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateProjectFormTitle)
            };
        }

        public void SelectListForProjectCreation(string listName)
        {
            string ListNameSelector = $".//span[@class='mat-option-text'][text()=' {listName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }

    }
}