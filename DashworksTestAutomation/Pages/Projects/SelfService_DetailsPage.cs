﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_CB_Details_EnableSelfService']")]
        public IWebElement EnableSelfServicePortal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_CB_Details_AllowAnonymousUsers']")]
        public IWebElement AllowAnonymousUsers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_CB_Details_ProjectDefault']")]
        public IWebElement ThisProjectDefault { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_TB_Details_BaseUrl']")]
        public IWebElement BaseUrl { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_BackgroundColor']")]
        public IWebElement BackgroundColour { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_PrimaryColor']")]
        public IWebElement PrimaryColour { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_SecondaryColor']")]
        public IWebElement SecondaryColour { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_HighlightFontColour']")]
        public IWebElement HighlightFontColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_MenuHeaderFontColour']")]
        public IWebElement MenuHeaderFontColor { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.EnableSelfServicePortal),
                SelectorFor(this, p => p.AllowAnonymousUsers),
                SelectorFor(this, p => p.ThisProjectDefault),
                SelectorFor(this, p => p.BaseUrl),
                SelectorFor(this, p => p.BackgroundColour),
                SelectorFor(this, p => p.PrimaryColour),
                SelectorFor(this, p => p.SecondaryColour),
                SelectorFor(this, p => p.HighlightFontColor),
                SelectorFor(this, p => p.MenuHeaderFontColor),
            };
        }
    }
}