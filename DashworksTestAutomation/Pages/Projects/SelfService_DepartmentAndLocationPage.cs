﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_DepartmentAndLocationPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_departmentLocationShowScreen']")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_showDepartmentFullPath']")]
        public IWebElement ShowDepartmentFullPath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_showLocationFullPath']")]
        public IWebElement ShowLocationFullPath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_computerOwnershipAllowUsersToAddANoteFromThisPageValue']")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_departmentLocationDisplayDepartmentForUsers']")]
        public IWebElement Department { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_departmentLocationDisplayLocationForUsers']")]
        public IWebElement Location { get; set; }

        //TODO checkbox for Department, Location

        //TODO checkbox for ShowDepartmentFeed, ShowHRLocationFeed, ShowManualLocationFeed, ShowHistoricLocationFeed

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
