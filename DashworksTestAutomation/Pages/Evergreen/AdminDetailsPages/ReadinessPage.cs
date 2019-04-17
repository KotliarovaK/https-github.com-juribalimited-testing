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

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE READINESS']/ancestor::button")]
        public IWebElement CreateNewReadinessBtn { get; set; }



        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateNewReadinessBtn)
            };
        }

        public IWebElement GetReadinessDialogContainerButtonByName(string button)
        {
            var selector = By.XPath(
                $".//div[@class='mat-dialog-actions']/button/span[text()='{button}']");
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
