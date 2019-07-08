using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class LeavePageWarning : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container")]
        public IWebElement LeavePageWarningDialog { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-dialog-actions']/button/span[text()='YES']")]
        public IWebElement ButtonYes { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.LeavePageWarningDialog)
            };
        }
    }
}