using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class CreateTeamPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]/h2")]
        public IWebElement CreateTeamFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement CreateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Team Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement TeamNameField { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//textarea[@placeholder='Team Description']")]
        public IWebElement TeamDescriptionField { get; set; }
        
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateTeamFormTitle)
            };
        }
    }
}