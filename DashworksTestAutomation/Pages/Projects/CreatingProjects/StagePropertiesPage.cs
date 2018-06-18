﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class StagePropertiesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@title='Stage Name']")]
        public IWebElement StageName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Stage']")]
        public IWebElement ConfirmCreateStageButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.StageName)
            };
        }
    }
}