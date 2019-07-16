﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    internal class Capacity_UnitsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='title-container']/h1")]
        public IWebElement TitleContainer { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[contains(@class, 'ag-body-viewport ')]//div[@role='row']/div[@col-id='unitName']")]
        public IList<IWebElement> GridUnitsNames { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Default unit']")]
        public IWebElement DefaultCapacityUnitCheckbox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TitleContainer)
            };
        }
    }
}