using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class AutomationsGridPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[contains(text(), 'Automation')]")]
        public IWebElement AutomationsTitle { get; set; }

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
            var by = By.XPath(".//div[@col-id='name' and @role='gridcell']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public IWebElement GetMoveButtonByAutomationName(string automation)
        {
            var indexRow = GetAutomationsContent().IndexOf(automation);
            var selector = By.XPath($".//div[@row-index='{indexRow}']/div[@col-id='dragColumn']");
            return Driver.FindElement(selector);
        }
    }
}
