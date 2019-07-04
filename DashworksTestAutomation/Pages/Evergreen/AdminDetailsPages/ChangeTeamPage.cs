﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ChangeTeamPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h2[text()='Change Team']")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='teams']")]
        public IWebElement SelectTeamDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        public void SelectTeamToChange(string teamName)
        {
            var teamSelector = $".//span[@class='mat-option-text'][(text()= '{teamName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(teamSelector));
            Driver.FindElement(By.XPath(teamSelector)).Click();
        }
    }
}