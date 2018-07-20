using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class CreateBucketPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]/h2")]
        public IWebElement CreateBucketFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement CreateBucketButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Bucket Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement BucketNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Default bucket']")]
        public IWebElement IncorrectDefaulBucketCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Default Bucket']")]
        public IWebElement DefaulBucketCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='teams']")]
        public IWebElement TeamsNameField { get; set; }
        
        
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateBucketFormTitle)
            };
        }

        public void SelectTeam(string teamName)
        {
            var teamNameSelector = $".//span[@class='mat-option-text'][text()='{teamName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(teamNameSelector));
            Driver.FindElement(By.XPath(teamNameSelector)).Click();
        }
    }
}