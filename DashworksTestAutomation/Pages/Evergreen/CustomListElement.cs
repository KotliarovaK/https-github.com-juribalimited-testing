using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class CustomListElement : SeleniumBasePage
    {
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

        [FindsBy(How = How.XPath, Using = ".//button[@mattooltip='Save List']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@mattooltip='Cancel']")]
        public IWebElement CancelButton { get; set; }

        public string SettingButtonSelector = ".//li//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessCreateMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenuBlock']//ul//span[@class='submenu-actions-list-name']")]
        public IList<IWebElement> ListsNames { get; set; }

        #region ListSettings

        [FindsBy(How = How.XPath, Using = ".//li[text()='Manage']")]
        public IWebElement ManageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Make Favourite']")]
        public IWebElement MakeFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Duplicate']")]
        public IWebElement DuplicateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Delete']")]
        public IWebElement DeleteButton { get; set; }

        #endregion

        #region DeleteListBlock

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error ng-star-inserted']")]
        public IWebElement DeleteConfirmationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='DELETE']")]
        public IWebElement ConfirmDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']")]
        public IWebElement CancelDeletingButton { get; set; }

        #endregion

        #region UpdateList

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'open-action')]/span")]
        public IWebElement SaveAsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Update list']")]
        public IWebElement UpdateCurrentListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Save as new list']")]
        public IWebElement SaveAsNewListButton { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
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

        public bool CheckThatListIsRemoved(string listName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='submenu-actions-list-name'][text()='{listName}']"));
        }
    }
}