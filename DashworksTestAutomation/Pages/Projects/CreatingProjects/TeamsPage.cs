﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class TeamsPage : SeleniumBasePage
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