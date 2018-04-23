using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Capacity_CapacityPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_Capacity_Team']")]
        public IWebElement Team { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_Capacity_RequestType']")]
        public IWebElement RequestType { get; set; }

        //TODO Request Type [Default(Computer)]

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Team),
                SelectorFor(this, p => p.RequestType)
            };
        }
    }
}