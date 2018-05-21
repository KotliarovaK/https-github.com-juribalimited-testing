using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Capacity_CapacityPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'Team')]")]
        public IWebElement Team { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'RequestType')]")]
        public IWebElement RequestType { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Team),
                SelectorFor(this, p => p.RequestType)
            };
        }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Start Date']/..//button[@aria-label='Select Date']")]
        public IWebElement StartDateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Start Date']/..//input[contains(@id, 'SelectDate')]")]
        public IWebElement StartDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//tr//td[text()='End Date']/..//button[@class='ui-datepicker-trigger']")]
        public IWebElement EndDateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='End Date']/..//input[contains(@id, 'SelectDate')]")]
        public IWebElement EndDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//table[contains(@class,'pmAdminGrid')]")]
        public IWebElement Table { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Monday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement MondayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Tuesday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement TuesdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Wednesday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement WednesdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Thursday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement ThursdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Friday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement FridayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Saturday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement SaturdayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Sunday')]/..//span[@class='dayCapacityCheckbox']//input")]
        public IWebElement SundayCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Monday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Monday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Tuesday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Tuesday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Wednesday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Wednesday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Thursday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Thursday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Friday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Friday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Saturday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Saturday { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(), 'Sunday')]/..//input[contains(@id,'Capacity_DayMaximum')]")]
        public IWebElement Sunday { get; set; }
    }
}