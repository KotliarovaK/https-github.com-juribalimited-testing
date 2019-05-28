using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class CreateAutomationsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h2[contains(text(), 'Create Automation')]")]
        public IWebElement CreateAutomationsTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Automation Name']")]
        public IWebElement AutomationNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Description']")]
        public IWebElement DescriptionField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateAutomationsTitle)
            };
        }
    }
}