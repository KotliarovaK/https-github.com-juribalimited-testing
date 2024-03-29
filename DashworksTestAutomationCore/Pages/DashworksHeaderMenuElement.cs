﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class DashworksHeaderMenuElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@id='mainContentContainer']/descendant::h1[position()=1]")]
        public IWebElement PageHeader { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_DwTopBar1_DwLogin1_UserLink")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_DwTopBar1_DwLogin1_LogoutLink")]
        public IWebElement LogoutLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Switch Sites']")]
        public IWebElement AnalysisLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Evergreen']")]
        public IWebElement EvergreenLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@href='/Preferences.aspx']")]
        public IWebElement PreferencesLink { get; set; }
        

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeader)
            };
        }
    }
}