using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ImportListsFromCSVPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[contains(text(), 'Import ')]")]
        public IWebElement ImportListsTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ImportListsTitle)
            };
        }

        public IWebElement GetImportPageHeader(string pageHeader)
        {
            var selector = By.XPath($".//h1[contains(text(), '{pageHeader}')]");
            return Driver.FindElement(selector);
        }
    }
}