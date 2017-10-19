using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Autotest.Pages
{
    class LoginPanelPage : SeleniumBasePage
    {
        #region Forced login splash page

        [FindsBy(How = How.ClassName, Using = "loginsplash-panel")]
        public IWebElement LoginsplashPanel { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_DwTopBar1_DwLogin1_UserLink")]
        public IWebElement LoginLink { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//img[@src='iisstart.png']")]
        public IWebElement WebsiteIsNotAvailable { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_P_Login")]
        public IWebElement LoginButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By> { };
        }
    }
}
