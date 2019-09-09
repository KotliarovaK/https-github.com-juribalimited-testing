using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class AutomationsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='automationName']")]
        public IWebElement AutomationNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='action-container']//h2")]
        public IWebElement AutomationTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AutomationNameField)
            };
        }

        public IWebElement SelectCheckboxByName(string checkboxName)
        {
            var button = By.XPath($".//mat-checkbox//span[text()='{checkboxName}']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public IWebElement GetAutomationsPageTitle(string checkboxName)
        {
            var button = By.XPath($".//div[@class='action-container']//h2");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }
    }
}