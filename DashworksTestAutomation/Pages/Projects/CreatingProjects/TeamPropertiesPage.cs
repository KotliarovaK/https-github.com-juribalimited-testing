using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class TeamPropertiesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@title='Team Name']")]
        public IWebElement TeamName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@title='Short Description']")]
        public IWebElement ShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Team']")]
        public IWebElement ConfirmCreateTeamButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.TeamName),
                SelectorFor(this, p => p.ShortDescription)
            };
        }
    }
}