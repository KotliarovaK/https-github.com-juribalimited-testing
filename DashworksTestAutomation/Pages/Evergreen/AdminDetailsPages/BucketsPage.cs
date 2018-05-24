using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class BucketsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
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

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-select-all']")]
        public IWebElement SelectAllProjectsCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessageBucketsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[@class='button-small mat-raised-button mat-accent ng-star-inserted']")]
        public IWebElement DeleteButtonOnPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessageBucketsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD DEVICE']")]
        public IWebElement AddDeviceButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD DEVICES']")]
        public IWebElement AddDevicesButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD MAILBOXES']")]
        public IWebElement AddMailboxesButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD USERS']")]
        public IWebElement AddUsersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD USER']")]
        public IWebElement AddUserButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD MAILBOX']")]
        public IWebElement AddMailboxButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-checkbox-label'][text()='Default Bucket']")]
        public IWebElement DefaultBucketCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE BUCKET']")]
        public IWebElement UpdateBucketButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted'][text()='No items']")]
        public IWebElement NoItesMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='button-small mat-primary reset mat-raised-button']")]
        public IWebElement ResetFiltersButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.BucketPageTitle)
            };
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            var columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            var columnHeaderSelector = $".//div[@role='presentation']/span[text()='{columnName}']";
            Driver.MouseHover(By.XPath(columnHeaderSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public void SelectActions(string actionName)
        {
            var selectedActionName =
                $".//div[@class='mat-select-content ng-trigger ng-trigger-fadeInContent']//span[text()='{actionName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selectedActionName));
            Driver.FindElement(By.XPath(selectedActionName)).Click();
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

        public void ClickContentByColumnName(string columnName)
        {
            By byControl =
                By.XPath($".//div[@class='ag-body-container']/div[1]/div[{GetColumnNumberByName(columnName)}]//a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public bool AppropriateBucketName(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{bucketName}']"));
        }

        public bool SuccessUpdatedMessageBucketsPage(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[text()='The {bucketName} bucket has been updated']"));
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

        public void SelectBucketByName(string bucketName)
        {
            var bucketNameSelector = $".//a[text()='{bucketName}']";
            Driver.FindElement(By.XPath(bucketNameSelector)).Click();
        }

        public bool ActiveBucketByName(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{bucketName}']"));
        }

        public bool WarningDeleteBucketMessage(string warningText)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ng-star-inserted inline-tip'][text()='{warningText}']"));
        }

        public void AddBucket(string bucketName)
        {
            SearchTextbox.SendKeys(bucketName);
            var selector = $".//span[text()='{bucketName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void AddMailbox(string mailboxName)
        {
            SearchTextbox.SendKeys(mailboxName);
            var selector = $".//span[text()='{mailboxName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void AddUser(string userName)
        {
            SearchTextbox.SendKeys(userName);
            var selector = $".//span[text()='{userName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void SelectTabByName(string tabName)
        {
            var tabNameSelector = $".//li[@class='ng-star-inserted']//span[text()='{tabName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(tabNameSelector));
            Driver.FindElement(By.XPath(tabNameSelector)).Click();
        }

        public void SelectTeam(string teamName)
        {
            var teamNameSelector = $".//span[@class='mat-option-text'][text()='{teamName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(teamNameSelector));
            Driver.FindElement(By.XPath(teamNameSelector)).Click();
        }
    }
}