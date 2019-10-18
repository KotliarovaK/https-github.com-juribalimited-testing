using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class CustomListElement : SeleniumBasePage
    {
        public string SettingButtonSelector =
            ".//li//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']";

        public string TopSubMenuItemByName = ".//div[contains(@class,'submenu-top')]//*[text()='{0}']";

        public By AllListNamesInListsPanel = By.XPath(".//span[contains(@class,'list-name')]");

        public By ListSubMenusInListsPanel = By.XPath(".//ancestor::submenu-item");

        public By SettingsIcon = By.XPath(".//ancestor::div[@class='submenu-item']//i[contains(@class,'settings')]");

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'list-edit-wrapper')]//button")]
        public IWebElement CreateNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='search']")]
        public IWebElement ListPanelSearchTextBox { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//list-submenu-container//button")]
        public IWebElement CloseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='content']//i[@class='material-icons mat-menu']")]
        public IWebElement ExpandSideNavPanelIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessCreateMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'SelectDropdownActions')]//mat-select")]
        public IWebElement DropdownFilterList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@id,'submenuBlock')]//ul[contains(@class,'submenu-actions-list')]/li")]
        public IList<IWebElement> ListElementsInListsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenu']")]
        public IWebElement ListsPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>();
        }

        public List<string> GetAllListNames()
        {
            return ListElementsInListsPanel.Select(x => x.FindElement(AllListNamesInListsPanel))
                .Select(c => c.Text).ToList();
        }

        public IWebElement GetListElementByName(string listName)
        {
            switch (listName)
            {
                case "All Devices":
                case "All Users":
                case "All Applications":
                case "All Device Applications":
                case "All Mailboxes":
                    return Driver.FindElementByXPath(string.Format(TopSubMenuItemByName, listName));

                default:
                    var listElement = ListElementsInListsPanel.Select(x => x.FindElement(AllListNamesInListsPanel))
                        .FirstOrDefault(c => c.Text.Equals(listName));
                    if (listElement.Displayed())
                    {
                        return listElement;
                    }
                    else
                    {
                        throw new Exception($"'{listName}' list is not found in Lists panel");
                    }
            }
        }

        public IWebElement GetActiveList()
        {
            Driver.WaitForAnyElementToContainsTextInAttribute(ListElementsInListsPanel.Select(x => x.FindElement(ListSubMenusInListsPanel)).ToList(),
                "active", "class");
            return ListElementsInListsPanel.Select(x => x.FindElement(ListSubMenusInListsPanel))
                .FirstOrDefault(WebElementExtensions.IsElementActive);
        }

        public bool GetFavoriteStatus(string listName)
        {
            return Driver.IsElementDisplayed(By.XPath(
                $".//span[@class='submenu-actions-list-name'][text()='{listName}']//ancestor::li//i[@class='material-icons mat-star']"), WebDriverExtensions.WaitTime.Medium);
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

        public IWebElement GetSettingsIconForList(string listName)
        {
            return GetListElementByName(listName).FindElement(SettingsIcon);
        }

        public IWebElement ListInBottomSection(string listName)
        {
            var listSelector =
                By.XPath($".//li[contains(@class, 'menu-show-on-hover ng-star-inserted')]//span[text()='{listName}']");
            return Driver.FindElement(listSelector);
        }

        public bool DisplayStatusForListByName(string listName)
        {
            return Driver.IsElementDisplayed(By.XPath($"//span[@class='submenu-actions-list-name'][text()='{listName}']"));
        }

        public IWebElement GetListNameOnTopToolsPanel(string listName)
        {
            var allListName = $".//*[text()='{listName}']/ancestor::div[@class='top-tools']//div[@aria-controls='submenu']";
            Driver.WaitForElementToBeDisplayed(By.XPath(allListName));
            return Driver.FindElement(By.XPath(allListName));
        }

        public IWebElement GetFilterForListsByName(string filterListName)
        {
            var selector = By.XPath($"//div[contains(@class, 'transformPanel ')]//mat-option//span[text()='{filterListName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IList<IWebElement> GetFilterForListsItemsFromExpandedList()
        {
            var selector = By.XPath($"//div[contains(@class, 'transformPanel ')]//mat-option//span[text()]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElements(selector);
        }

        #region ListSettings

        [FindsBy(How = How.XPath, Using = ".//span/div[contains(@class,'inline-tip')]")]
        public IWebElement DeleteWarning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='menu']//li[contains(text(), 'Delete')]")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='menu']/ul[@class='menu-settings']")]
        public IWebElement MenuItem { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'saveAs')]//button[text()='UPDATE LIST']")]
        public IWebElement UpdateCurrentListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'saveAs')]//button[text()='SAVE AS NEW LIST']")]
        public IWebElement SaveAsNewListButton { get; set; }

        #endregion UpdateList
    }
}