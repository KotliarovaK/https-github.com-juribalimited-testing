using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.ManagementConsole.CustomFields
{
    //Page on senior
    class ManageCustomFieldsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//a[contains(@id,'CreateCustomField')]")]
        public IWebElement CreateNewCustomField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.CreateNewCustomField)
            };
        }
    }
}
