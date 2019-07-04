﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ReassignBucketsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Reassign Buckets']")]
        public IWebElement PageReassignBucketsTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[@id='teams']")]
        public IWebElement SelectTeamDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeader)
            };
        }

        public void SelectTeamToReassign(string teamName)
        {
            var teamSelector = $".//span[@class='mat-option-text'][(text()= '{teamName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(teamSelector));
            Driver.FindElement(By.XPath(teamSelector)).Click();
        }
    }
}