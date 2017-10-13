using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebdriverTests
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        public TestContext TestContext { get; set; }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.co.uk"); //this will open the webpage
        }

        [TestMethod]
        public void CheckTitleContainsGoogle()
        {
            StringAssert.Contains(driver.Title, "Google");
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
    }
}