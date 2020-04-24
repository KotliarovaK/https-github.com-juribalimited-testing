using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ActionsElement : SeleniumBasePage
    {
        private const string RowsSelectedCountSelector = ".//div[@class='actions-container-row-select']";
        private const string ListsDropdownSelector = ".//mat-select[@aria-label='Static Lists']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='spinner small-grey']")]
        public IWebElement ActionsSpinner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List Name']")]
        public IWebElement ListNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement DropdownBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='REMOVE']//ancestor::button")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD']//ancestor::button")]
        public IWebElement AddButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option//mat-icon/parent::span/span")]
        public IList<IWebElement> FavouriteBulkUpdateList { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }

        public void SelectList(string listName)
        {
            var listNameSelector =
                $".//mat-option//span[text()='{listName}']";
            Driver.FindElement(By.XPath(ListsDropdownSelector)).Click();
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public string GetSelectedRowsCount()
        {
            Driver.WaitForElementToBeDisplayed(By.XPath(RowsSelectedCountSelector));
            return Driver.FindElement(By.XPath(RowsSelectedCountSelector)).Text.Split(' ').First();
        }

        public IWebElement GetDropdownOnActionPanelByName(string name)
        {
            var dropDown = By.XPath($"//*[contains(text(),'{name}')]/parent::span//preceding-sibling::mat-select");
            Driver.WaitForElementToBeDisplayed(dropDown);
            return Driver.FindElement(dropDown);
        }
    }
}