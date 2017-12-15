﻿using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class ListDetailsElement: SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='listPanel ng-star-inserted']")]
        public IWebElement ListDetailsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List Name']")]
        public IWebElement ListNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[contains(text(),'star')]")]
        public IWebElement FavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Remove']")]
        public IWebElement RemoveListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions action-panel-ddl']")]
        public IWebElement PermissionsBlock { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions action-panel-ddl']//button[@title='Close']")]
        public IWebElement ClosePermissionBlockButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Owner ']/ancestor::div[@class='mat-select-trigger']")]
        public IWebElement OwnerDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Sharing ']/ancestor::div[@class='mat-select-trigger']")]
        public IWebElement SharingDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ACCEPT']/ancestor::button")]
        public IWebElement AcceptButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']/ancestor::button")]
        public IWebElement CancelButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ListDetailsPanel),
            };
        }
    }
}
