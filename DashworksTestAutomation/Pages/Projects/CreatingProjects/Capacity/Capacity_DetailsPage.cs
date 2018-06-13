﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Capacity_DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'EnableCapacityPlanning')]")]
        public IWebElement EnablePlanning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'CapacityVisibleWhenEditingDate')]")]
        public IWebElement DisplayColorsOnDatePicker { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'EnforceCapacityOnSelfServicePage')]")]
        public IWebElement EnforceOonSelfServicePage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'EnforceCapacityOnProjectObjectPage')]")]
        public IWebElement EnforceOnProjectObjectPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'PercentageCapacity')]")]
        public IWebElement CapacityToReach { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.EnablePlanning),
                SelectorFor(this, p => p.DisplayColorsOnDatePicker),
                SelectorFor(this, p => p.EnforceOonSelfServicePage),
                SelectorFor(this, p => p.EnforceOnProjectObjectPage),
                SelectorFor(this, p => p.CapacityToReach),
            };
        }
    }
}