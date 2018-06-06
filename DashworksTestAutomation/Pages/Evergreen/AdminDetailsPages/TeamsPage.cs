using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class TeamsPage : BaseGridPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']")]
        public IWebElement TeamsPageTitle { get; set; }

        /*[FindsBy(How = How.XPath, Using = ".//span[text()='CREATE TEAM']")]
        public IWebElement CreateTeamButton { get; set; }*/

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-tab']//span[@class='ag-icon ag-icon-filter']")]
        public IWebElement FilterButton { get; set; }
        
        /*[FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessageTeamPage { get; set; }*/

        /*[FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessageTeamPage { get; set; }*/

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-body-container']/div")]
        public IWebElement TableContent { get; set; }

        /*[FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-select-all']")]
        public IWebElement SelectAllProjectsCheckbox { get; set; }*/

        /*[FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']")]
        public IWebElement ActionsButton { get; set; }*/

        /*[FindsBy(How = How.XPath,
            Using = ".//button[@class='button-small mat-raised-button mat-accent ng-star-inserted']")]
        public IWebElement DeleteButtonOnPage { get; set; }*/

        [FindsBy(How = How.XPath, Using = ".//h2[text()='Reassign Objects']")]
        public IWebElement ReassignObjectsSummary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement UpdateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD MEMBERS']")]
        public IWebElement AddMembersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='width100']")]
        public IWebElement TeamMembersPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsOnPageCount { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//button[@class='button-small mat-default reset mat-raised-button _mat-animation-noopable']")]
        //public IWebElement ResetFiltersButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TeamsPageTitle)
            };
        }

        /*public int GetColumnNumberByName(string columnName)
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

        public void ClickContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]//a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }*/

        public bool AppropriateTeamName(string teamName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{teamName}']"));
        }

        /*public void SelectTabByName(string tabName)
        {
            string tabNameSelector = $".//li[@class='ng-star-inserted']//span[text()='{tabName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(tabNameSelector));
            Driver.FindElement(By.XPath(tabNameSelector)).Click();
        }*/

        /*public void SelectActions(string actionName)
        {
            string selectedActionName =
                $".//div[@class='mat-select-content ng-trigger ng-trigger-fadeInContent']//span[text()='{actionName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selectedActionName));
            Driver.FindElement(By.XPath(selectedActionName)).Click();
        }*/

        /*public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            var columnHeaderSelector = $".//span[@class='ag-header-cell-text'][text()='{columnName}']";
            Driver.MouseHover(By.XPath(columnHeaderSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }*/
    }
}