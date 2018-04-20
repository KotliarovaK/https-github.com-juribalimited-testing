using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class TeamsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//table[@id='ctl00_MainContent_GV_Teams']")]
        public IWebElement TeamsTable { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.TeamsTable)
            };
        }

        public int GetGroupsCountByTeamName(string teamName)
        {
            var groupsCount = Driver.FindElement(By.XPath($".//td[@title='{teamName}']/..//td[4]")).Text;
            return int.Parse(groupsCount);
        }
    }
}