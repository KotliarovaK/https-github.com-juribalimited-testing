using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Dashboards
{
    internal class PrintDashboardsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'print-preview')]//h2[text()='Print Preview Settings']")]
        public IWebElement PrintPreviewSettingsPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']//a")]
        public IWebElement PrintBreadcrumbs { get; set; }

        [FindsBy(How = How.XPath, Using = ".//body[contains(@class,'dashboardPrintPreview')]//img[@alt='DashWorks']")]
        public IWebElement DashWorksPrintLogo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'mat-expansion-panel-body')]//div[@class='widget']")]
        public IWebElement PrintPreviewWidgets { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='print-preview-buttons']/button/span[text()='CANCEL']")]
        public IWebElement CancelButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PrintPreviewSettingsPopUp),
            };
        }

        public IWebElement PrintPreview(string size, string layout) => Driver.FindElementByXPath($".//body[contains(@class, 'dashboardPrintPreview {size} {layout}')]");
    }
}