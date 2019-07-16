using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class EditActionPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='action-container']//h2[text()='Edit Action']")]
        public IWebElement EditActionTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.EditActionTitle)
            };
        }
    }
}