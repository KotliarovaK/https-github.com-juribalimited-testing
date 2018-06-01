using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class GroupPropertiesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'GroupName')]")]
        public IWebElement GroupName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'TeamId')]")]
        public IWebElement OwnedByTeam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Group']")]
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