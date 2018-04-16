using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class BucketsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[text()='Buckets']")]
        public IWebElement BucketPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE BUCKET']")]
        public IWebElement CreateBucketButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Bucket Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement BucketNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='teams']")]
        public IWebElement TeamsNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Select a team']/ancestor::div[@class='mat-select-trigger']")]
        public IWebElement SelectTeamDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessageBucketsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessageBucketsPage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.BucketPageTitle),
            };
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']/ancestor::div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eMenu']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public void SelectTeam(string teamName)
        {
            string TeamNameSelector = $".//span[@class='mat-option-text'][text()='{teamName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(TeamNameSelector));
            Driver.FindElement(By.XPath(TeamNameSelector)).Click();
        }

    }
}