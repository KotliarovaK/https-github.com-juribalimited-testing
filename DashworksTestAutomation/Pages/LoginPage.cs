using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages
{
    internal class LoginPage : SeleniumBasePage
    {
        [FindsBy(How = How.Id, Using = "ctl00_MainContent_P_Login")]
        public IWebElement LoginGroupbox { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_TB_UserName")]
        public IWebElement UserNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_TB_Password")]
        public IWebElement PasswordTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_Btn_Login")]
        public IWebElement LoginButton { get; set; }

        #region Login Splash page

        [FindsBy(How = How.XPath, Using = ".//div[@class='loginsplash-panel']")]
        public IWebElement SplasLoginGroupbox { get; set; }

        [FindsBy(How = How.Id, Using = "TB_UserName")]
        public IWebElement SplashUserNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "TB_Password")]
        public IWebElement SplashPasswordTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "Btn_Login")]
        public IWebElement SplashLoginButton { get; set; }

        #endregion Login Splash page

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By> { };
        }
    }
}