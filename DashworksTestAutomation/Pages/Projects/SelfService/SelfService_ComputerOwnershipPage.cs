using System;
using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_ComputerOwnershipPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'OwnershipShowScreen')]")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'ShowComputerNameFromHTTPHeader')]")]
        public IWebElement ShowComputerName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowComputersUsedButNotOwnedByTheUser')]")]
        public IWebElement ShowComputers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowCategory')]")]
        public IWebElement ShowCategory { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToSearch')]")]
        public IWebElement AllowUsersToSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToSetPrimary')]")]
        public IWebElement AllowUsersToSetPrimary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToAddANoteFromThisPage')]")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LimitMaximumComputersOfTheUserTo')]")]
        public IWebElement LimitMaximum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LimitMinimumComputersOfTheUserTo')]")]
        public IWebElement LimitMinimum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@aria-label='Page Description']")]
        public IWebElement PageDescription { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ShowScreen),
                SelectorFor(this, p => p.ShowCategory),
                SelectorFor(this, p => p.AllowUsersToSearch),
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.PageDescription),
            };
        }
    }
}
