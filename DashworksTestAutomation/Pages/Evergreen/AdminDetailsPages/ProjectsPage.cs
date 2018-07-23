using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ProjectsPage : BaseGridPage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement AdminPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-checked='false']")]
        public IWebElement UncheckedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'wrapper-disabled')]")]
        public IWebElement DisabledAllAssociations { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-option-text']")]
        public IWebElement DeleteProjectInActions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class, 'mat-form-field-empty')]")]
        public IWebElement EmptyScopeField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@title, 'Update')]")]
        public IWebElement UpdateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Update All Changes']")]
        public IWebElement UpdateAllChangesButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span['_ngcontent-c11'][text()='Scope']")]
        public IWebElement ScopeSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='buckets']")]
        public IWebElement BucketsProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role='combobox']")]
        public IWebElement ScopeProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Scope']")]
        public IWebElement ScopeListDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='inline-link ng-star-inserted']/a")]
        public IWebElement NewProjectLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='wrapper-disabled']//mat-select[@aria-label='User Scope']")]
        public IWebElement DisabledOwnerDropDown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AdminPageTitle)
            };
        }

        public string GetDllPanelHeight()
        {
            return Driver.FindElement(By.XPath("//div[@class='cdk-overlay-pane']")).GetCssValue("height");
        }

        public string GetDllPanelWidth()
        {
            return Driver.FindElement(By.XPath("//div[@class='cdk-overlay-pane']")).GetCssValue("width");
        }

        public void NavigateToProjectTabByName(string tabName)
        {
            var tab = Driver.FindElement(By.XPath($".//ul[@class='subMenu-items ng-star-inserted']//span[text()='{tabName}']"));
            tab.Click();
        }

        public void NavigateToProjectTabInScopSectionByName(string tabName)
        {
            var tab = Driver.FindElement(By.XPath($".//div[@class='detail-label ng-star-inserted']//span[text()='{tabName}']"));
            tab.Click();
        }

        public void ClickToTabByNameProjectScopeChanges(string tabName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//div[@class='detail-label ng-star-inserted']/span[contains(text(), '{tabName}')]"));
            tab.Click();
        }

        public void SelectRadioButtonByName(string radioButtonName)
        {
            var button = By.XPath($"//div[text()='{radioButtonName}']/../div[@class='mat-radio-container']");
            Driver.WaitWhileControlIsNotDisplayed(button);
            Driver.FindElement(button).Click();
        }

        public void SelectCheckboxByName(string checkboxName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//span[@class='mat-checkbox-label'][text()='{checkboxName}']"));
            tab.Click();
        }

        public bool ActiveProjectByName(string projectName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{projectName}']"));
        }

        public bool SuccessTextMessage(string textMessage)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[text()='{textMessage}']"));
        }

        public bool BucketDropdownDisplay(string textBucket)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[text()='{textBucket}']"));
        }

        public bool SelectedItemInProjectScopeChangesSection(string text)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='title'][contains(text(), '{text}')]"));
        }

        public void SelectObjectForProjectCreation(string objectName)
        {
            string ListNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }

        public bool SelectedTabInProjectScopeChangesSection(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div//span[contains(text(),'{tabName} ')]"));
        }
    }
}