using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    public class SelfServiceEndClientBasePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//das-self-service-header/div")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//das-self-service-footer/div")]
        public IWebElement Footer { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.Header),
                SelectorFor(this, p=> p.Footer)
            };
        }
    }
}
