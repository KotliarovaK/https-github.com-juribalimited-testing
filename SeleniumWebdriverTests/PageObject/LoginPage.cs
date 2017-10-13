using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriverTests.BaseClasses;

namespace SeleniumWebdriverTests.PageObject
{
    public class LoginPage : PageBase
    {
        #region WebElement

        [FindsBy(How = How.Id, Using = "Bugzilla_login")]
        private IWebElement LoginTextBox = null;

        [FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PassTextBox = null;

        [FindsBy(How = How.Id, Using = "log_in")]
        [CacheLookup]
        private IWebElement LoginButton = null;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink = null;

        #endregion WebElement

        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions

        public EnterBug Login(string Username, string Password)
        {
            LoginTextBox.SendKeys(Username);
            PassTextBox.SendKeys(Password);
            LoginButton.Click();
            return new EnterBug(driver);
        }

        //public void Login1(string Username, string Password)
        //{
        //    ObjectRepository.Driver.FindElement(LoginTextBox).SendKeys(Username);
        //    ObjectRepository.Driver.FindElement(PassTextBox).SendKeys(Password);
        //    ObjectRepository.Driver.FindElement(LoginButton).Click();
        //}

        #endregion Actions

        #region Navigation

        public void NavigateToHome()
        {
            HomeLink.Click();
        }

        #endregion Navigation
    }
}