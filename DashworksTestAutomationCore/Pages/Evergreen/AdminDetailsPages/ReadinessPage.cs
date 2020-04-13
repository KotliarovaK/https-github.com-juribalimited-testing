using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ReadinessPage : SeleniumBasePage
    {
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
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