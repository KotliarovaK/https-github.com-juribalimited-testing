﻿using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class CreateActionsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h2[contains(text(), 'Create Action')]")]
        public IWebElement CreateActionTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Action Name']")]
        public IWebElement ActionNameField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateActionTitle)
            };
        }
    }
}