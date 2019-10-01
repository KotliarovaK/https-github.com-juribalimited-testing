using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    //TODO Rename to Element instead of Page
    //!!!Element with header and breadcrumbs under grid!!!
    public class BaseHeaderPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']//h1")]
        public new IWebElement Header { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Header)
            };
        }
    }
}
