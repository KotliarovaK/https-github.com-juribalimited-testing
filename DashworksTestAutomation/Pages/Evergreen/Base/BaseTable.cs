using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
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
            var content = row.FindElement(By.XPath($".//td[{column + 1}]//span"));
            return content.Text;
        }
    }
}
