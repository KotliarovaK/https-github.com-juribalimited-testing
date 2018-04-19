using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Capacity_OverrideDatesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_UC_OverrideDates_Date_TB_SelectDate']")]
        public IWebElement Date { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_OverrideDates_Team']")]
        public IWebElement OverrideTeam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_OverrideDates_RequestType']")]
        public IWebElement OverrideRequestType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_TB_OverrideDates_Capacity']")]
        public IWebElement Capacity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@id='ctl00_MainContent_TB_OverrideDates_Comment']")]
        public IWebElement Comment { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Date),
                SelectorFor(this, p => p.OverrideTeam),
                SelectorFor(this, p => p.OverrideRequestType),
                SelectorFor(this, p => p.Capacity),
                SelectorFor(this, p => p.Comment)
            };
        }
    }
}