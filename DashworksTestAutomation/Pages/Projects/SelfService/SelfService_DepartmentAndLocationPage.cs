using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_DepartmentAndLocationPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowScreen')]")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showDepartmentFullPath')]")]
        public IWebElement ShowDepartmentFullPath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showLocationFullPath')]")]
        public IWebElement ShowLocationFullPath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToAddANoteFromThisPageValue')]")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'DisplayDepartmentForUsers')]")]
        public IWebElement Department { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Do not push changes to linked mailboxes']//following-sibling::td/input[@name='computersTakingUserDepartment']")]
        public IWebElement DepartmentDoNotPush { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Push changes to owned mailboxes only']//following-sibling::td/input[@name='computersTakingUserDepartment']")]
        public IWebElement DepartmentPushToOwned { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Push changes to all linked mailboxes']//following-sibling::td/input[@name='computersTakingUserDepartment']")]
        public IWebElement DepartmentPushToAll { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'departmentLocationDisplayLocationForUsers')]")]
        public IWebElement Location { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Do not push changes to linked mailboxes']//following-sibling::td/input[@name='computersTakingUserLocation']")]
        public IWebElement LocationDoNotPush { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Push changes to owned mailboxes only']//following-sibling::td/input[@name='computersTakingUserLocation']")]
        public IWebElement LocationPushToOwned { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Push changes to all linked mailboxes']//following-sibling::td/input[@name='computersTakingUserLocation']")]
        public IWebElement LocationPushToAll { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Department Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement DepartmentFeed { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='HR Location Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement HrLocationFeed { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Manual Location Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement ManualLocationFeed { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[text()='Historic Location Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement HistoricLocationFeed { get; set; }

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
                SelectorFor(this, p => p.ShowDepartmentFullPath),
                SelectorFor(this, p => p.ShowLocationFullPath),
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.Department),
                SelectorFor(this, p => p.Location),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription)
            };
        }
    }
}
