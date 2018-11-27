using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class LoginPage : SeleniumBasePage
    {
        [FindsBy(How = How.Id, Using = "ctl00_MainContent_P_Login")]
        public IWebElement LoginGroupBox { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_TB_UserName")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_TB_Password")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_Btn_Login")]
        public IWebElement LoginButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>();
        }

        #region Login Splash page

        [FindsBy(How = How.XPath, Using = ".//div[@class='loginsplash-panel']")]
        public IWebElement SplashLoginGroupBox { get; set; }

        [FindsBy(How = How.Id, Using = "TB_UserName")]
        public IWebElement SplashUserNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "TB_Password")]
        public IWebElement SplashPasswordTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Btn_Login")]
        public IWebElement SplashLoginButton { get; set; }

        #endregion Login Splash page
    }
}