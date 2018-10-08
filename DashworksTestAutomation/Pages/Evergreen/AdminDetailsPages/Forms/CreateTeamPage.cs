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

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Members (Optional)']")]
        public IWebElement AddMembersCheckbox { get; set; }

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

        public void SelectObjectForTeamCreation(string objectName)
        {
            string ListNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }
    }
}