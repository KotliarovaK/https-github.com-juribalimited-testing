using System;
using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_ComputerOwnershipPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnershipShowScreen']")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_ComputerOwnership_ShowComputerNameFromHTTPHeader']")]
        public IWebElement ShowComputerName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnershipShowComputersUsedButNotOwnedByTheUser']")]
        public IWebElement ShowComputers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnerShowCategoryForComputers']")]
        public IWebElement ShowCategory { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnershipAllowUsersToSearchForOtherComputers']")]
        public IWebElement AllowUsersToSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnershipAllowUsersToSetPrimaryComputer']")]
        public IWebElement AllowUsersToSetPrimary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnershipAllowUsersToAddANoteFromThisPageValue']")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='tb_computerOwnershipLimitMaximumComputersOfTheUserTo']")]
        public IWebElement LimitMaximum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='tb_computerOwnershipLimitMinimumComputersOfTheUserTo']")]
        public IWebElement LimitMinimum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Long Name']")]
        public IWebElement LongName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Short Name']")]
        public IWebElement ShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@aria-label='Page Description']")]
        public IWebElement PageDescription { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ShowScreen),
                SelectorFor(this, p => p.ShowComputerName),
                SelectorFor(this, p => p.ShowComputers),
                SelectorFor(this, p => p.ShowCategory),
                SelectorFor(this, p => p.AllowUsersToSearch),
                SelectorFor(this, p => p.AllowUsersToSetPrimary),
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.LimitMaximum),
                SelectorFor(this, p => p.LimitMinimum),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription),
            };
        }
    }
}
