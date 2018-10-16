using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    public class MoveToAnotherBucketPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h2")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='buckets']")]
        public IWebElement BucketSelectbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@mattooltip='Move']")]
        public IWebElement MoveButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle),
                SelectorFor(this, p => p.BucketSelectbox)
            };
        }

        public void MoveToBucketByName(string bucketName)
        {
            BucketSelectbox.Click();
            Driver.WaitForDataLoading();
            var bucketSelector = $".//mat-option/span[contains(text(), '{bucketName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(bucketSelector));
            Driver.FindElement(By.XPath(bucketSelector)).Click();
            MoveButton.Click();
        }
    }
}