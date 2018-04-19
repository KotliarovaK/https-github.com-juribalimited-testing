using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_ProjectDatePage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_projectDateShowScreen']")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_ProjectDate_ShowComputerNameFromHTTPHeader']")]
        public IWebElement ShowComputerName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_projectDateAllowUsersToAddANoteFromThisPageValue']")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='tb_projectDateScheduleWindowMinimumHoursValue']")]
        public IWebElement MinimumHours { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='tb_projectDateScheduleWindowMaximumHoursValue']")]
        public IWebElement MaximumHours { get; set; }

        //TODO Additional Tasks

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
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.MinimumHours),
                SelectorFor(this, p => p.MaximumHours),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription)
            };
        }
    }
}