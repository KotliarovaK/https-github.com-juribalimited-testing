using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class GroupPropertiesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_TB_GroupName']")]
        public IWebElement GroupName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_TeamId']")]
        public IWebElement OwnedByTeam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_Create']")]
        public IWebElement ConfirmCreateGroupButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.GroupName),
                SelectorFor(this, p => p.OwnedByTeam)
            };
        }
    }
}