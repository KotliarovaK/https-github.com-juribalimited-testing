using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    //For now this element is used only on ItemDetails page
    //Move it to Base if it will be used in some other place
    class BaseTable : SeleniumBasePage
    {
        private const string TableSelector = ".//div[contains(@class,'table-responsive')]";

        [FindsBy(How = How.XPath, Using = TableSelector)]
        public IWebElement Table { get; set; }

        [FindsBy(How = How.XPath, Using = TableSelector + "//thead//tr")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = TableSelector + "//tbody//tr")]
        public IList<IWebElement> Rows { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this,p=>p.Table)
            };
        }

        public IWebElement GetRowByKey(string key)
        {
            Driver.WaitForElementsToBeDisplayed(Rows);
            if (Rows.Any(x => x.FindElement(By.XPath(".//td[1]//span")).Text.Equals(key)))
            {
                return Rows.First(x => x.FindElement(By.XPath(".//td[1]//span")).Text.Equals(key));
            }
            else
            {
                throw new Exception($"There are not row with '{key}' key in the table");
            }
        }

        public bool IsRowWithKeyExists(string key)
        {
            try
            {
                return GetRowByKey(key).Displayed();
            }
            catch
            {
                return false;
            }
        }

        //column = 1 is a first column after keys
        public string GetRowContent(string key, int column = 1)
        {
            var row = GetRowByKey(key);
            var content = GetContentFromRow(row);
            return content;
        }

        //column = 1 is a first column after keys
        public List<string> GetRowsContent(int column = 1)
        {
            var content = Rows.Select(x => GetContentFromRow(x)).ToList();
            return content;
        }

        //column = 1 is a first column after keys
        private string GetContentFromRow(IWebElement element, int column = 1)
        {
            var content = element.FindElement(By.XPath($".//td[{column + 1}]//span | .//td[{column + 1}]//div[count(*)=0]"));

            return content.Text;

        }
    }
}
