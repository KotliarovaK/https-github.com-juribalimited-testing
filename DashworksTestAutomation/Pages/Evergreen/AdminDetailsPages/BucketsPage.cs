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

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.BucketPageTitle),
            };
        }

    }
}