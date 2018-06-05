﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ProjectsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement AdminPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Projects']")]
        public IWebElement ProjectsPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE PROJECT']")]
        public IWebElement CreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement CreateProjectButtonOnCreateProjectPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-raised-button']/span[text()='CANCEL']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Project Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement ProjectNameField { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//label[@for='scope']span[@class='mat-form-field-label-wrapper mat-input-placeholder-wrapper mat-form-field-placeholder-wrapper']")]
        public IWebElement SelectScopeProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement UpdateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role='combobox']")]
        public IWebElement ScopeProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-select-all']")]
        public IWebElement SelectAllProjectsCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-option-text']")]
        public IWebElement DeleteProjectButtonInActions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Delete Project']")]
        public IWebElement DeleteProjectValueInActions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-placeholder[text()='Actions']")]
        public IWebElement ActionsInDropdown { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[@class='button-small mat-raised-button mat-accent ng-star-inserted']")]
        public IWebElement DeleteButtonOnPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ng-star-inserted inline-tip']")]
        public IWebElement DeleteWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='messageAction btn mat-button ng-star-inserted']")]
        public IWebElement DeleteButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-checked='false']")]
        public IWebElement UncheckedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE PROJECT']")]
        public IWebElement UpdateProjectInTheWarning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span['_ngcontent-c11'][text()='Scope']")]
        public IWebElement ScopeSection { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AdminPageTitle)
            };
        }

        public void SelectListForProjectCreation(string listName)
        {
            string ListNameSelector = $".//span[@class='mat-option-text'][text()=' {listName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }

        public void SelectProjectByName(string projectName)
        {
            string projectNameSelector = $".//a[text()='{projectName}']";
            Driver.FindElement(By.XPath(projectNameSelector)).Click();
        }

        public void NavigateToProjectTabByName(string tabName)
        {
            var tab = Driver.FindElement(By.XPath($".//ul[@class='subMenu-items ng-star-inserted']//span[text()='{tabName}']"));
            tab.Click();
        }

        public void ClickUpdateButtonByName(string buttonName)
        {
            var tab = Driver.FindElement(By.XPath($".//span[text()='{buttonName}']"));
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
            var tab = Driver.FindElement(
                By.XPath($".//div[@class='mat-radio-label-content'][text()='{radioButtonName}']"));
            tab.Click();
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

        public bool SelectedItemInProjectScopeChangesSection(string text)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='title'][text()='{text}']"));
        }

        public bool SelectedTabInProjectScopeChangesSection(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div//span[contains(text(),'{tabName} ')]"));
        }

        public int GetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//div[@class='ag-header-container']/div/div");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            if (!allHeaders.Any())
                throw new Exception("Table does not contains any columns");
            var columnNumber =
                allHeaders.IndexOf(allHeaders.First(x =>
                    x.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).Text.Equals(columnName))) + 1;

            return columnNumber;
        }

        public void GetSearchFieldByColumnName(string columnName, string text)
        {
            By byControl =
                By.XPath(
                    $".//div[@role='presentation']/div[2]/div[{GetColumnNumberByName(columnName)}]//div[@class='ag-floating-filter-full-body']//input");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).SendKeys(text);
        }

        public bool WarningMessageProjectPage(string text)
        {
            Driver.WaitForElement(By.XPath(".//div[@class='inline-tip ng-star-inserted']"));
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='inline-tip ng-star-inserted'][text()='{text}']"));
        }
    }
}