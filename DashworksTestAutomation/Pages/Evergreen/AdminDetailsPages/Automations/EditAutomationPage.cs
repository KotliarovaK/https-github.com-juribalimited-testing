using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class EditAutomationPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h2[contains(text(), 'Edit Automation')]")]
        public IWebElement EditAutomationTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.EditAutomationTitle)
            };
        }
    }
}