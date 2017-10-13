using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.WebDriverWait
{
    //[TestClass]
    public class TestWebDriverWait
    {
        //[TestMethod]
        public void TestWait()
        {
            NavigationHelper.NagigateToURL("https://www.udemy.com/courses");
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@placeholder='Search for Courses']"), "C#");
        }
    }
}

