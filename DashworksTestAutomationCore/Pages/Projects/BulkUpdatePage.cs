using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.BulkUpdatePage
{
    internal class BulkUpdatePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Project']")]
        public IWebElement Project { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Object Type']")]
        public IWebElement ObjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Bulk Update Type']")]
        public IWebElement BulkUpdateType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Bulk Update Type']/option")]
        public IList<IWebElement>BulkUpdateTypeOptions { get; set; }


        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Project),
            };
        }
    }
}