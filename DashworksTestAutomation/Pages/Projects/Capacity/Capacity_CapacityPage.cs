using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Capacity_CapacityPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_Capacity_Team']")]
        public IWebElement Team { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DDL_Capacity_RequestType']")]
        public IWebElement RequestType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Start Date']/..//button[@aria-label='Select Date']")]
        public IWebElement StartDateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_UC_Capacity_StartDate_TB_SelectDate']")]
        public IWebElement StartDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//tr//td[text()='End Date']/..//button[@class='ui-datepicker-trigger']")]
        public IWebElement EndDateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='End Date']/..//input[@class='datepicker hasDatepicker']")]
        public IWebElement EndDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//table[@class='pmGrid pmAdminGrid']")]
        public IWebElement Table { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl01_CB_Capacity_DayEnabled']")]
        public IWebElement MondayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl02_CB_Capacity_DayEnabled']")]
        public IWebElement TuesdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl03_CB_Capacity_DayEnabled']")]
        public IWebElement WednesdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl04_CB_Capacity_DayEnabled']")]
        public IWebElement ThursdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl05_CB_Capacity_DayEnabled']")]
        public IWebElement FridayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl06_CB_Capacity_DayEnabled']")]
        public IWebElement SaturdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl07_CB_Capacity_DayEnabled']")]
        public IWebElement SundayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl01_TB_Capacity_DayMaximum']")]
        public IWebElement Monday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl02_TB_Capacity_DayMaximum']")]
        public IWebElement Tuesday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl03_TB_Capacity_DayMaximum']")]
        public IWebElement Wednesday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl04_TB_Capacity_DayMaximum']")]
        public IWebElement Thursday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl05_TB_Capacity_DayMaximum']")]
        public IWebElement Friday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl06_TB_Capacity_DayMaximum']")]
        public IWebElement Saturday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_RP_Capacity_Days_ctl07_TB_Capacity_DayMaximum']")]
        public IWebElement Sunday { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Team),
                SelectorFor(this, p => p.RequestType)
            };
        }
    }
}