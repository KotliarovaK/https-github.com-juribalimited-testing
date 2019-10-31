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

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.BucketPageTitle)
            };
        }

        public bool SuccessUpdatedMessageBucketsPage(string bucketName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[text()='The {bucketName} bucket has been updated']"));
        }
    }
}