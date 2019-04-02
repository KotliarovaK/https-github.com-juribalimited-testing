using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ReadinessPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container[@role='dialog']/change-readiness-dialog")]
        public IWebElement ReadinessDialogContainer { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ReadinessDialogContainer)
            };
        }

        public IWebElement GetReadinessDialogContainerButtonByName(string button)
        {
            var selector = By.XPath(
                $".//div[@class='mat-dialog-actions']/button/span[text()='{button}']");
            return Driver.FindElement(selector);
        }
    }
}
