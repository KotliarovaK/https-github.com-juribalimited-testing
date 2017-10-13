using OpenQA.Selenium;
using SeleniumWebdriverTests.BaseClasses;

namespace SeleniumWebdriverTests.PageObject
{
    public class EnterBug : PageBase
    {
        #region Web Element

        //[FindsBy(How = How.LinkText, Using = "Testng")]
        //private IWebElement Testng;

        #endregion Web Element

        public EnterBug(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Navigation

        public BugDetail NavigateToDetail()
        {
            //Testng.Click();
            return new BugDetail(driver);
        }

        #endregion Navigation
    }
}