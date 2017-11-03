using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class CustomListElemnt : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='listEdit list-edit-wrapper']")]
        public IWebElement CreateCustomListElement { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='action-item']")]
        public IWebElement CreateNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='List Name']")]
        public IWebElement ListNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Save List']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@title='Settings']")]
        public IWebElement SettingsDropdown { get; set; }

        #region ListSettings

        [FindsBy(How = How.XPath, Using = ".//li[text()='Manage']")]
        public IWebElement ManageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Make Favourite']")]
        public IWebElement MakeFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Duplicate']")]
        public IWebElement BuplicateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Delete']")]
        public IWebElement DeleteButton { get; set; }

        #endregion

        #region DeleteListBlock

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error']")]
        public IWebElement DeleteConfirmationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='DELETE']")]
        public IWebElement ConfirmDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']")]
        public IWebElement CancelDeletingButton { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateCustomListElement),
                SelectorFor(this, p => p.CreateNewListButton)
            };
        }

        public IWebElement GetSettingsButtonByListName(string listName)
        {
            return Driver.FindElement(By.XPath(
                $".//span[@class='submenu-actions-list-name'][text()='{listName}']//ancestor::li//i[@title='Settings']"));
        }
    }
}