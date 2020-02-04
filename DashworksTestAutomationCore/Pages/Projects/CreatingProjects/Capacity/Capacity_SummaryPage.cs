﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Capacity
{
    internal class Capacity_SummaryPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'RequestType')]")]
        public IWebElement RequestType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//tr[@class='grid-headerstyle']")]
        public IWebElement Table { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.RequestType)
            };
        }
    }
}