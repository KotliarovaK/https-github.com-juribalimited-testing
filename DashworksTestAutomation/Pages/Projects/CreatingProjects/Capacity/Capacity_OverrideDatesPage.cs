using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Capacity
{
    internal class Capacity_OverrideDatesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SelectDate')]")]
        public IWebElement Date { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'OverrideDates_Team')]")]
        public IWebElement OverrideTeam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'OverrideDates_RequestType')]")]
        public IWebElement OverrideRequestType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'dayCapacityTextbox')]")]
        public IWebElement Capacity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@id, 'Comment')]")]
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