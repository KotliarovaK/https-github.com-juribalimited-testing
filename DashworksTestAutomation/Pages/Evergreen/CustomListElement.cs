using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class CustomListElement : SeleniumBasePage
    {
        public string SettingButtonSelector =
            ".//li//i[@class='menu-trigger material-icons mat-settings mat-18 pull-right settings-icon settings-area']";

        public string TopSubMenuItemByName = ".//div[contains(@class,'submenu-top')]//*[text()='{0}']";

        public By AllListNamesInListsPanel = By.XPath(".//*[contains(@class,'-name')]"); //old .//span[contains(@class,'list-name')]

        public By ListSubMenusInListsPanel = By.XPath(".//ancestor::submenu-item");

        public By ListStarIcons = By.XPath(".//preceding-sibling::span//i[contains(@class,'star')]");

        public By SettingsIcon = By.XPath(".//ancestor::li//i[contains(@class,'settings')]");

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@id,'submenuBlock')]//ul[contains(@class,'submenu-actions')]/li")]
        public IList<IWebElement> ListElementsInListsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenu']")]
        public IWebElement ListsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-top-item')]")]
        public IList<IWebElement> SubMenuTopItems { get; set; }

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
                        .FirstOrDefault(c => c.GetAttribute("innerText").Equals(listName));
                    if (listElement.Displayed())
                    {
                        return listElement;
                    }
                    else if (!listElement.Displayed())
                    {
                        Driver.MoveToElement(listElement);
                        Driver.WaitForElementToBeDisplayed(listElement);
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
            Driver.WaitForElementsToBeExists(SubMenuTopItems);

            if (SubMenuTopItems.Any(x => x.GetAttribute("class").Contains("selected")))
            {
                var element = SubMenuTopItems.FirstOrDefault(x => x.IsElementSelected());

                if (!element.Displayed())
                {
                    return element;
                }
                else
                {
                    Driver.MoveToElement(element);
                    Driver.WaitForElementToBeDisplayed(element);
                    return element;
                }
            }

            Driver.WaitForAnyElementToContainsTextInAttribute(ListElementsInListsPanel.Select(x => x.FindElement(ListSubMenusInListsPanel)),
                "active", "class");
            return ListElementsInListsPanel.Select(x => x.FindElement(ListSubMenusInListsPanel))
                .FirstOrDefault(c => c.IsElementActive());
        }

        public bool GetFavoriteStatus(string listName, bool expectedCondition)
        {
            Driver.ExecuteAction(() => Driver.WaitForElementInElementDisplayCondition(GetListElementByName(listName),
                ListStarIcons, expectedCondition, 15));
            return Driver.IsElementInElementDisplayed(GetListElementByName(listName), ListStarIcons, WebDriverExtensions.WaitTime.Short);
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

        //TODO Delete this section!!!
        #region UpdateList

        [FindsBy(How = How.XPath, Using = "//span[text()='SAVE']/ancestor::button")]
        public IWebElement SaveAsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(text(),'Edited')]")]
        public IWebElement EditedList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'saveAs')]//button[text()='UPDATE LIST']")]
        public IWebElement UpdateCurrentListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'saveAs')]//button[text()='SAVE AS NEW LIST']")]
        public IWebElement SaveAsNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'saveAs')]//button[text()='SAVE AS DYNAMIC LIST']")]
        public IWebElement SaveAsDynamicListButton { get; set; }

        public IWebElement SaveAsMenuOption(string name)
        {
            return Driver.FindElementByXPath($".//div[contains(@class, 'saveAs')]//button[text()='{name}']");
        }

        #endregion UpdateList
    }
}