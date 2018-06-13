﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
   internal class NewsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'NewsTitle')]")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@id, 'NewsText')]")]
        public IWebElement Text { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Title),
                SelectorFor(this, p => p.Text)
            };
        }
    }
}