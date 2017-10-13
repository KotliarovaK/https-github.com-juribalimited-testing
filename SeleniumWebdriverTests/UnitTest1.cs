using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumWebdriverTests
{
    [TestClass]
    public class UnitTest1 : IDisposable
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

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                driver.Close();
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}