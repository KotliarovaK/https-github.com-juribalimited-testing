using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class BucketsPage : BaseGridPage
    {
        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement BucketPageTitle { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-checkbox-label'][text()='Default Bucket']")]
        public IWebElement DefaultBucketCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-checked='true']")]
        public IWebElement SelectedDefaultBucketCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE BUCKET']")]
        public IWebElement UpdateBucketButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsOnPageCount { get; set; }
        
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.BucketPageTitle)
            };
        }
        
        public bool AppropriateBucketName(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{bucketName}']"));
        }

        public bool SuccessUpdatedMessageBucketsPage(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[text()='The {bucketName} bucket has been updated']"));
        }
        
        public bool ActiveBucketByName(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{bucketName}']"));
        }

        public bool WarningDeleteBucketMessage(string warningText)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@id='messageAdmin'][text()='{warningText}']"));
        }

        public void ClickTabByName(string tabName)
        {
            string tabNameSelector = $".//div[@role='tab']/div[text()='{tabName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(tabNameSelector));
            Driver.FindElement(By.XPath(tabNameSelector)).Click();
        }

        public void SelectObjectByName(string objectName)
        {
            string objectNameSelector = $".//span[contains(text(), '{objectName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(objectNameSelector));
            Driver.FindElement(By.XPath(objectNameSelector)).Click();
        }
    }
}