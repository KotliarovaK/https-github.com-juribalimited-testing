using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    public class BaseDetailsPage : SeleniumBasePage
    {
        private const string RowSelector = ".//tr[@role='row'][not(@hidden)]";
        private const string TitleSelector = "./td[contains(@class,'column-key')]";
        private const string ContentSelector = "./td[contains(@class,'column-value')]";

        [FindsBy(How = How.XPath, Using = ".//div[@class='details-keyvalue']")]
        public IWebElement Table { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.Table)
            };
        }

        public string GetFieldContentByTitleName(string fieldTitle)
        {
            var allRows = Driver.FindElements(By.XPath(RowSelector));

            if (allRows.Any(x => x.FindElement(By.XPath(TitleSelector)).Text.Equals(fieldTitle)))
            {
                var row = allRows.First(x => x.FindElement(By.XPath(TitleSelector)).Text.Equals(fieldTitle));
                var content = row.FindElement(By.XPath(ContentSelector)).Text;
                return content;
            }
            else
                throw new Exception($"There are no field with '{fieldTitle}' title.");
        }
    }
}
