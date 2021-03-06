﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.SelfService
{
    internal class SelfService_DepartmentAndLocationPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowScreen')]")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showDepartmentFullPath')]")]
        public IWebElement ShowDepartmentFullPath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showLocationFullPath')]")]
        public IWebElement ShowLocationFullPath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToAddANoteFromThisPageValue')]")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'DisplayDepartment')]")]
        public IWebElement Department { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//td[contains(@id, 'DoNotPushChangeToLinkedComputers')]//following-sibling::td/input[contains(@name, 'Department')]")]
        public IWebElement DepartmentDoNotPush { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//td[contains(@id, 'PushChangeToOwnedComputers')]//following-sibling::td/input[contains(@name, 'Department')]")]
        public IWebElement DepartmentPushToOwned { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//td[contains(@id, 'departmentLocationPushChangeToLinkedComputers')]//following-sibling::td/input[contains(@name, 'Department')]")]
        public IWebElement DepartmentPushToAll { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'departmentLocationDisplayLocation')]")]
        public IWebElement Location { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//td[contains(@id, 'DoNotPushChangeToLinkedComputers')]//following-sibling::td/input[contains(@name, 'Location')]")]
        public IWebElement LocationDoNotPush { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//td[contains(@id, 'PushChangeToOwnedComputers')]//following-sibling::td/input[contains(@name, 'Location')]")]
        public IWebElement LocationPushToOwned { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//td[contains(@id, 'departmentLocationPushChangeToLinkedComputers')]//following-sibling::td/input[contains(@name, 'Location')]")]
        public IWebElement LocationPushToAll { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//td[text()='Department Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement DepartmentFeed { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//td[text()='HR Location Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement HrLocationFeed { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//td[text()='Manual Location Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement ManualLocationFeed { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//td[text()='Historic Location Feed']//following-sibling::td/input[@type='checkbox']")]
        public IWebElement HistoricLocationFeed { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Long Name']")]
        public IWebElement LongName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Short Name']")]
        public IWebElement ShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@class, 'description')]")]
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
                SelectorFor(this, p => p.ShortName)
            };
        }
    }
}