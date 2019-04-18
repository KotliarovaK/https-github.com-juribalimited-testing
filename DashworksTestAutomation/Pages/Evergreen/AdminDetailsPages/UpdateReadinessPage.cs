using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    class UpdateReadinessPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'action-container')]/h2[text()='Update Readiness']")]
        public IWebElement UpdateReadinessTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.UpdateReadinessTitle)
            };
        }
    }
}
