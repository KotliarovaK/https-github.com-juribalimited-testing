using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class AutomationsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[contains(text(), 'Automation')]")]
        public IWebElement AutomationsTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']/div[@col-id='processingOrder']")]
        public IList<IWebElement> ProcessingOrderValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role='combobox']")]
        public IWebElement ScopeField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AutomationsTitle)
            };
        }

        public IList<string> GetAutomationsContent()
        {
            var by = By.XPath(".//div[@col-id='automationName' and @role='gridcell']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public IWebElement GetMoveButtonBySlotName(string slot)
        {
            var indexRow = GetAutomationsContent().IndexOf(slot);
            var selector = By.XPath($".//div[@row-index='{indexRow}']/div[@col-id='dragColumn']");
            return Driver.FindElement(selector);
        }

        public IWebElement SelectCheckboxByName(string checkboxName)
        {
            var button = By.XPath($".//mat-checkbox//span[text()='{checkboxName}']");
            Driver.WaitWhileControlIsNotDisplayed(button);
            return Driver.FindElement(button);
        }
    }
}
