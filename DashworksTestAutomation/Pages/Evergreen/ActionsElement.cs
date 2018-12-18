using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ActionsElement : SeleniumBasePage
    {
        private const string ActionValuesSelector = ".//mat-option[contains(@id, 'mat-option')]";
        private const string RowsSelectedCountSelector = ".//div[@class='actions-container-row-select']";
        private const string ListsDropdownSelector = ".//mat-select[@aria-label='Static Lists']";

        [FindsBy(How = How.XPath, Using = ListsDropdownSelector)]
        public IWebElement ListsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='actions-container']")]
        public IWebElement ActionsPanel { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//button[@class='btn btn-default mat-icon-button']/span/i[@class='material-icons mat-static-list']")]
        public IWebElement InactiveActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='Select at least one row']")]
        public IWebElement ActionsContainerMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='spinner small-grey']")]
        public IWebElement ActionsSpinner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List Name']")]
        public IWebElement ListNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE']//ancestor::button")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@mattooltip='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement DropdownBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='REMOVE']//ancestor::button")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD']//ancestor::button")]
        public IWebElement AddButton { get; set; }

        [FindsBy(How = How.XPath, Using = ActionValuesSelector)]
        public IList<IWebElement> ActionValues { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ActionsPanel)
            };
        }

        public void SelectList(string listName)
        {
            var listNameSelector =
                $".//mat-option//span[text()='{listName}']";
            Driver.FindElement(By.XPath(ListsDropdownSelector)).Click();
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public IList<IWebElement> GetDropdownOptions()
        {
            return Driver.FindElements(By.XPath(".//mat-option"));
        }

        public string GetSelectedRowsCount()
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(RowsSelectedCountSelector));
            return Driver.FindElement(By.XPath(RowsSelectedCountSelector)).Text.Split(' ').First();
        }
    }
}