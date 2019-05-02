using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ReadinessPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container[@role='dialog']//label[text()='Replacement Readiness']")]
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

        public IWebElement GetReadinessDialogContainerTitle(string text)
        {
            var selector = By.XPath(
                $".//mat-dialog-container[@role='dialog']//h1[text()='{text}']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetReadinessDialogContainerText(string text)
        {
            var selector = By.XPath(
                $".//mat-dialog-container[@role='dialog']//p[text()='{text}']");
            return Driver.FindElement(selector);
        }

        public List<string> GetListOfReadinessLabel()
        {
            List<string> labels = new List<string>();
            IList<IWebElement> webLabels = Driver.FindElements(By.XPath(".//div[@role='gridcell']//a"));

            foreach (var webEl in webLabels)
            {
                labels.Add(webEl.Text);
            }

            return labels;
        }
    }
}