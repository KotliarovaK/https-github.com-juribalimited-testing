using System;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class TeamsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[text()='Teams']")]
        public IWebElement TeamsPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE TEAM']")]
        public IWebElement CreateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement CreateTeamButtonOnCreateTeamPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Team Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement TeamNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@placeholder='Team Description']")]
        public IWebElement TeamDescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessageTeamPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessageTeamPage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TeamsPageTitle),
            };
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

        public void GetSearchByColumnName(string columnName, string searchText)
        {
            By byControl =
                By.XPath($".//div[@class='ag-header-row']/div[2]/div[{GetColumnNumberByName(columnName)}][@aria-hidden='true']");
            Driver.WaitForDataLoading();
            Driver.FindElement(byControl).Click();
            Driver.FindElement(byControl).SendKeys(searchText);
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']/ancestor::div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eMenu']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }
    }


}
