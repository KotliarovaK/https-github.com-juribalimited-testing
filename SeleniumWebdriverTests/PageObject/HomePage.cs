using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriverTests.BaseClasses;

namespace SeleniumWebdriverTests.PageObject
{
    public class HomePage : PageBase
    {
        #region WebElement

        [FindsBy(How = How.Id, Using = "quicksearch_main")]
        private IWebElement QuickSearchTextBox = null;

        [FindsBy(How = How.Id, Using = "find")]
        [CacheLookup]
        private IWebElement QuickSearchButton = null;

        [FindsBy(How = How.LinkText, Using = "File a Bug")]
        private IWebElement FileABugLink = null;

        #endregion WebElement

        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions

        public void QuickSearch(string text)
        {
            QuickSearchTextBox.SendKeys(text);
            QuickSearchButton.Click();
        }

        #endregion Actions

        #region Navigation

        public LoginPage NavigateToLogin()
        {
            FileABugLink.Click();
            return new LoginPage(driver);
        }

        #endregion Navigation
    }
}