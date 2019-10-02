using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    //TODO Rename to Element instead of Page
    //!!!Element with header and breadcrumbs under grid!!!
    public class BaseHeaderElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement Header { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Header)
            };
        }

        public void CheckPageHeader(string text)
        {
            Verify.AreEqual(text, Header.Text, "Incorrect page header");
        }

        public void CheckPageHeaderContainsText(string text)
        {
            Verify.IsTrue(Header.Text.Contains(text), $"Page header do not contains '{text}' text");
        }
    }
}
