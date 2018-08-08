using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_ProjectDatePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'projectDateShowScreen')]")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'ShowComputerNameFromHTTPHeader')]")]
        public IWebElement ShowComputerName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToAddANoteFromThisPageValue')]")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ScheduleWindowMinimumHoursValue')]")]
        public IWebElement MinimumHours { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ScheduleWindowMaximumHoursValue')]")]
        public IWebElement MaximumHours { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Long Name']")]
        public IWebElement LongName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Short Name']")]
        public IWebElement ShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@aria-label='Page Description']")]
        public IWebElement PageDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@aria-label='Additional Tasks']")]
        public IWebElement AdditionalTasks { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@class, 'addAdditionalTask')]")]
        public IWebElement AddAdditionalTasks { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ShowScreen),
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.MinimumHours),
                SelectorFor(this, p => p.MaximumHours),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription)
            };
        }

        public IWebElement SelectTaskByName(string taskName)
        {
            var selector = By.XPath($"//select[@aria-label='Additional Tasks']/option[text()='{taskName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}