﻿using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class TeamsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[text()='Teams']")]
        public IWebElement TeamsPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE TEAM']")]
        public IWebElement CreateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement CreateTeamButtonOnCreateTeamPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[text()='Team Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement TeamNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@placeholder='Team Description']")]
        public IWebElement TeamDescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-success')]")]
        public IWebElement SuccessMessageTeamPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessageTeamPage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TeamsPageTitle),
            };
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']/ancestor::div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eMenu']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }
    }


}
