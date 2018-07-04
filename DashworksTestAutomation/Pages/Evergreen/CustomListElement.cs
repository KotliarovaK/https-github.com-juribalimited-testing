using System.Collections.Generic;
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

        [FindsBy(How = How.XPath, Using = ".//span[@class='action-item']")]
        public IWebElement CreateNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='search']")]
        public IWebElement ListPanelSearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='clearButton ng-star-inserted']")]
        public IWebElement SearchTextboxResetButtonInListPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='List Name']")]
        public IWebElement ListNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'button-small mat-primary save-actions-save')]")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'button-small save-actions-cancel')]")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']")]
        public IWebElement SettingsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='menu']")]
        public IWebElement SettingsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessCreateMessage { get; set; }

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
                $".//span[@class='submenu-actions-list-name'][text()='{listName}']//ancestor::li//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']";
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
                By.XPath($".//div[@class='inline-box-text']//span[text()='\"{listName}\" ']"));
        }

        public bool RemovingDependencyListMessage(string warningText)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div//span[text()='{warningText}']"));
        }

        public bool CheckThatListIsRemoved(string listName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//span[@class='submenu-actions-list-name'][text()='{listName}']"));
        }

        public IWebElement OpenSettingsByListName(string listName)
        {
            var listSettingsSelector =
                By.XPath($".//ul[@class='submenu-actions-list ng-star-inserted']//span[text()='{listName}']//ancestor::li[@class='menu-show-on-hover ng-star-inserted']//div[@class='menu-wrapper']//i");
            Driver.MouseHover(listSettingsSelector);
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(listSettingsSelector);
            return Driver.FindElement(listSettingsSelector);
        }

        public IWebElement ListInBottomSection(string listName)
        {
            var listSelector =
                By.XPath($".//li[contains(@class, 'menu-show-on-hover ng-star-inserted')]/span[text()='{listName}']");
            return Driver.FindElement(listSelector);
        }

        #region ListSettings

        [FindsBy(How = How.XPath, Using = ".//li[text()='Manage']")]
        public IWebElement ManageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Make Favourite']")]
        public IWebElement MakeFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Duplicate']")]
        public IWebElement DuplicateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[contains(text(), 'Delete')]")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn mat-button')]")]
        public IWebElement DeleteButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-transparent mat-button')]")]
        public IWebElement CancelButtonInWarningMessage { get; set; }

        #endregion ListSettings

        #region DeleteListBlock

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement DeleteConfirmationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='DELETE']")]
        public IWebElement ConfirmDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']")]
        public IWebElement CancelDeletingButton { get; set; }

        #endregion DeleteListBlock

        #region UpdateList

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'open-action')]/span")]
        public IWebElement SaveAsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(text(),'Edited')]")]
        public IWebElement EditedList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Update list']")]
        public IWebElement UpdateCurrentListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Save as new list']")]
        public IWebElement SaveAsNewListButton { get; set; }

        #endregion UpdateList
    }
}