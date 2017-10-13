using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.BrowserActions
{
    //[TestClass]
    public class TestBrowserActions
    {
        //[TestMethod]
        public void TestActions()
        {
            NavigationHelper.NagigateToURL("https://www.udemy.com/bdd-with-selenium-webdriver-and-speckflow-using-c/");
            ButtonHelper.ClickButton(By.XPath("//a[@href='/bdd-with-selenium-webdriver-and-speckflow-using-c/']"));
            BrowserHelper.BrowserGoBack();
            BrowserHelper.BrowserGoForward();
            BrowserHelper.BrowserRefresh();
        }
    }
}
