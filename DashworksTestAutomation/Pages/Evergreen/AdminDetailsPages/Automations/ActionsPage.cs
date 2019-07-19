using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class ActionsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//button//span[text()='CREATE ACTION']")]
        public IWebElement CreateActionButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select//span[text()='Value']")]
        public IWebElement ValueDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']//div[@role='gridcell']")]
        public IWebElement ActionsTableContent { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateActionButton)
            };
        }

        public IWebElement GetMoveButtonByActionName(string action)
        {
            var indexRow = GetActionContent().IndexOf(action);
            var selector = By.XPath($".//div[@row-index='{indexRow}']/div[@col-id='dragColumn']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownByName(string dropdown)
        {
            var selector = By.XPath($".//div//*[@placeholder='{dropdown}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GetSelectValueForActions(string dropdown)
        {
            Driver.WaitForElementToBeDisplayed(ValueDropdown);
            ValueDropdown.Click();
            var selector = By.XPath($".//mat-option//span[text()='{dropdown}']");
            Driver.WaitForElementToBeDisplayed(selector);
            Driver.FindElement(selector).Click();
        }

        public IList<string> GetActionContent()
        {
            var by = By.XPath(".//div[@col-id='actionName' and @role='gridcell']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }
    }
}
