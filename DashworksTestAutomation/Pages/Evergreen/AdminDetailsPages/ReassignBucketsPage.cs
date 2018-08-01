﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    class ReassignBucketsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//h2[text()='Reassign Buckets']")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[@id='teams']")]
        public IWebElement SelectTeamDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        public void SelectTeamToReassign(string teamName)
        {
            string teamSelector = $".//span[@class='mat-option-text'][(text()= '{teamName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(teamSelector));
            Driver.FindElement(By.XPath(teamSelector)).Click();
        }
    }
}
