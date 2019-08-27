using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    class ActionPanelPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='top-tools']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@name='actions']")]
        public IWebElement ActionsDropDown { get; set; }

        #region Messages

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-tip')]")]
        public IWebElement WarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'tooltipbar-success')]")]
        public IWebElement SuccessMessage { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                //SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IWebElement GetActionButtonByName(string name)
        {
            var selector = By.XPath($".//span[@class='mat-accent'][text()='{name}']/ancestor::mat-option");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonInWarningMessage(string buttonName)
        {
            var selector = By.XPath($".//button[contains(@class, 'messageAction ')]//span[text()='{buttonName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
