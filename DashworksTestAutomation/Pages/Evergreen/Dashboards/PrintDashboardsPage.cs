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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'cdk-drop-list')]//div[@class='widget']")]
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

        public IWebElement PrintPreview(string size, string layout) => Driver.FindElementByXPath($".//body[@class='dashboardPrintPreview {size} {layout}']");

        public IWebElement GetPrintPreviewDropdownByName(string dropdown)
        {
            var selector = $".//div[@class='styleSelectDropdown']//*[@aria-label='{dropdown}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public void SelectPrintPreviewSettings(string option)
        {
            var optionSelector = $".//mat-option[@role='option']//span[text()='{option}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(optionSelector));
            Driver.FindElement(By.XPath(optionSelector)).Click();
        }
    }
}