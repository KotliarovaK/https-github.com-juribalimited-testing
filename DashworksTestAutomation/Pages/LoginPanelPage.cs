﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class LoginPanelPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//img[@src='iisstart.png']")]
        public IWebElement WebsiteIsNotAvailable { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_P_Login")]
        public IWebElement LoginButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>();
        }

        #region Forced login splash page

        [FindsBy(How = How.ClassName, Using = "loginsplash-panel")]
        public IWebElement LoginSplashPanel { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_DwTopBar1_DwLogin1_UserLink")]
        public IWebElement LoginLink { get; set; }

        #endregion Forced login splash page
    }
}