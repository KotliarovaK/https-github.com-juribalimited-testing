﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class RequestTypePropertiesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Name')]")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@id, 'Description')]")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Object Type']")]
        public IWebElement ObjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Request Type & Select Tasks...']")]
        public IWebElement ConfirmCreateRequestTypesButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Description),
                SelectorFor(this, p => p.ObjectType),
            };
        }
    }
}