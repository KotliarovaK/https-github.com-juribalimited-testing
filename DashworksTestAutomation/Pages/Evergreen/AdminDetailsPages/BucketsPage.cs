using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE']")]
        public IWebElement UpdateBucketButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        public IWebElement SearchFieldForBucketsPage { get; set; }

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

        public void ClickTabByName(string tabName)
        {
            var tabNameSelector = $".//div[@role='tab']/div[text()='{tabName}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(tabNameSelector));
            Driver.FindElement(By.XPath(tabNameSelector)).Click();
        }

        public IWebElement SelectObjectByName(string objectName)
        {
            var selector = By.XPath($".//span[contains(text(), '{objectName}')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}