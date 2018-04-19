using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_AppsListPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_applicationListShowScreen']")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_applicationsListShowCoreApps']")]
        public IWebElement ShowCoreApps { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_applicationsListShowFutureStateReadinessValue']")]
        public IWebElement ShowTargetStateReadiness { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_applicationsListShowApplicationSelectorDropDownList']")]
        public IWebElement ShowRequiredColumnAndSticky { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_applicationsListShowOnlyAppsFromUsersPrimaryComputerValue']")]
        public IWebElement ShowOnlyApplication { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_applicationsListAllowUsersToAddANoteFromThisPageValue']")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_ApplicationsListView']")]
        public IWebElement View { get; set; }

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
                SelectorFor(this, p => p.ShowCoreApps),
                SelectorFor(this, p => p.ShowTargetStateReadiness),
                SelectorFor(this, p => p.ShowRequiredColumnAndSticky),
                SelectorFor(this, p => p.ShowOnlyApplication),
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.View),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription),
            };
        }
    }
}