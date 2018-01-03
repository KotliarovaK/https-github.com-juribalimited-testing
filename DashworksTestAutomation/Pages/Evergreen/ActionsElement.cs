using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class ActionsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='actions-container']")]
        public IWebElement ActionsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='Select at least one row']")]
        public IWebElement ActionsContainerMessage { get; set; }

        private const string RowsSelectedCountSelctor = ".//div[@class='actions-container-row-select']";

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List name']")]
        public IWebElement ListNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE']//ancestor::button")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement DropdownBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='REMOVE']//ancestor::button")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD']//ancestor::button")]
        public IWebElement AddButton { get; set; }

        public string listsDropdown = ".//div[@class='form-group form-group-fix-select ng-star-inserted']";

        public void SelectList(string listName)
        {
            string listNameSelector = $".//div[@class='mat-select-content ng-trigger ng-trigger-fadeInContent']//md-option[text()='{listName}']";
            string dropdownBoxList = listsDropdown;
            Driver.FindElement(By.XPath(dropdownBoxList)).Click();
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public IList<IWebElement> GetDropdownOptions()
        {
            return Driver.FindElements(By.XPath(".//md-option"));
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ActionsPanel),
            };
        }

        public string GetSelectedRowsCount()
        {
            return Driver.FindElement(By.XPath(RowsSelectedCountSelctor)).Text.Split(' ').First();
        }
    }
}