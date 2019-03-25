﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class CustomListElement : SeleniumBasePage
    {
        public string SettingButtonSelector =
            ".//li//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='listEdit list-edit-wrapper']")]
        public IWebElement CreateCustomListElement { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'list-edit-wrapper')]//button")]
        public IWebElement CreateNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='search']")]
        public IWebElement ListPanelSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='top-tools']//div[@aria-controls='submenu']")]
        public IWebElement TopToolsSubmenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='save-action-bar ng-star-inserted']")]
        public IWebElement SavePivotButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='clearButton ng-star-inserted']")]
        public IWebElement SearchTextBoxResetButtonInListPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='List Name']")]
        public IWebElement ListNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Dashboard Name']")]
        public IWebElement DashboardNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'button-small mat-primary save-actions-save')]")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'button-small save-actions-cancel')]")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[contains(@class, 'material-icons mat-clear')]/ancestor::button[contains(@class, 'btn mat-icon-button ')]")]
        public IWebElement CloseButton { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']")]
        public IWebElement SettingsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='menu']")]
        public IWebElement SettingsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessCreateMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'SelectDropdownActions')]//mat-select")]
        public IWebElement DropdownFilterList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenuBlock']//ul//span[@class='submenu-actions-list-name']")]
        public IList<IWebElement> ListsNames { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>();
        }

        public bool GetFavoriteStatus(string listName)
        {
            return Driver.IsElementDisplayed(By.XPath(
                $".//span[@class='submenu-actions-list-name'][text()='{listName}']//ancestor::li//i[@class='material-icons mat-star']"));
        }

        public void ClickSettingsButtonByListName(string listName)
        {
            var settingsButton =
                $".//span[@class='submenu-actions-list-name'][text()='{listName}']//ancestor::li//i[contains(@class,'settings')]";
            Driver.WaitWhileControlIsDisplayed<CustomListElement>(() => UpdateCurrentListButton);
            Driver.MouseHover(By.XPath(settingsButton));
            Driver.FindElement(By.XPath(settingsButton)).Click();
        }

        public IWebElement CheckAllListName(string listName)
        {
            var allListName = $".//div[@class='submenu-selected-list list-selected'][text()='{listName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(allListName));
            return Driver.FindElement(By.XPath(allListName));
        }

        public bool ListNameWarningMessage(string listName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='inline-box-text']//span[contains(text(), '{listName}')]"));
        }

        public bool RemovingDependencyListMessage(string warningText)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div//span[contains(text(),'{warningText}')]"));
        }

        public bool CheckThatListIsRemoved(string listName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//span[@class='submenu-actions-list-name'][text()='{listName}']"));
        }

        public IWebElement OpenSettingsByListName(string listName)
        {
            var listSettingsSelector =
                By.XPath(
                    $".//ul[@class='submenu-actions-list ng-star-inserted']//span[text()='{listName}']//ancestor::li[@class='menu-show-on-hover ng-star-inserted']//div[@class='menu-wrapper']//i");
            Driver.MouseHover(listSettingsSelector);
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(listSettingsSelector);
            return Driver.FindElement(listSettingsSelector);
        }

        public IWebElement OpenSettingsByDashboardName(string dashboardName)
        {
            var dashboardSettingsSelector =
                By.XPath(
                    $".//ul[@class='submenu-actions-dashboards']//span[text()='{dashboardName}']/ancestor::li//i");
            Driver.MouseHover(dashboardSettingsSelector);
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(dashboardSettingsSelector);
            return Driver.FindElement(dashboardSettingsSelector);
        }

        public IWebElement ListInBottomSection(string listName)
        {
            var listSelector =
                By.XPath($".//li[contains(@class, 'menu-show-on-hover ng-star-inserted')]/span[text()='{listName}']");
            return Driver.FindElement(listSelector);
        }

        public bool DisplayStatusForListByName(string listName)
        {
            return Driver.IsElementDisplayed(By.XPath($"//span[@class='submenu-actions-list-name'][text()='{listName}']"));
        }

        public IWebElement GetListNameOnTopToolsPanel(string listName)
        {
            var allListName = $".//*[text()='{listName}']/ancestor::div[@class='top-tools']//div[@aria-controls='submenu']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(allListName));
            return Driver.FindElement(By.XPath(allListName));
        }

        public IWebElement GetFilterForListsByName(string filterListName)
        {
            var selector = By.XPath($"//div[contains(@class, 'transformPanel ')]//mat-option//span[text()='{filterListName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #region ListSettings

        [FindsBy(How = How.XPath, Using = ".//li[text()='Manage']")]
        public IWebElement ManageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Make Favorite']")]
        public IWebElement MakeFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Duplicate']")]
        public IWebElement DuplicateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span/div[contains(@class,'inline-tip')]")]
        public IWebElement DeleteWarning { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//li[contains(text(), 'Delete')]")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenuBlock']//button[contains(@class, 'btn mat-button')]/span[text()='DELETE']")]
        public IWebElement DeleteButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn mat-button')]/span[text()='DELETE']")]
        public IWebElement DeleteButtonInWarning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-transparent ')]/span[text()='CANCEL']")]
        public IWebElement CancelButtonInWarningMessage { get; set; }

        #endregion ListSettings

        #region DeleteListBlock

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement DeleteConfirmationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='DELETE']")]
        public IWebElement ConfirmDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-transparent')]//span[text()='CANCEL']")]
        public IWebElement CancelButtonColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']")]
        public IWebElement CancelDeletingButton { get; set; }

        #endregion DeleteListBlock

        #region UpdateList

        [FindsBy(How = How.XPath, Using = "//span[text()='SAVE']/ancestor::button")]
        public IWebElement SaveAsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(text(),'Edited')]")]
        public IWebElement EditedList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[contains(@class, 'saveAs')]//span[text()='UPDATE LIST']")]
        public IWebElement UpdateCurrentListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[contains(@class, 'saveAs')]//span[text()='SAVE AS NEW LIST']")]
        public IWebElement SaveAsNewListButton { get; set; }

        #endregion UpdateList
    }
}