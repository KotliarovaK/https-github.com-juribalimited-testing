using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriverTests.ComponentHelper;

namespace SeleniumWebdriverTests.BaseClasses
{
    public class PageBase
    {
        public IWebDriver driver;

#pragma warning disable 0649

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

#pragma warning restore 0649

        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
        }

        public void Logout()
        {
            if (GenericHelper.IsElementPresent(By.XPath("//div[@id='header']/ul[1]/li[11]/a")))
            {
                ButtonHelper.ClickButton(By.XPath("//div[@id='header']/ul[1]/li[11]/a"));
            }
        }

        protected void NavigateToHomePage()
        {
            HomeLink.Click();
        }

        public string Title //may need to add this to BaseClass ??
        {
            get { return driver.Title; }
        }
    }
}