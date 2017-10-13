using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.MultipleBrowsers
{
    //[TestClass]
    public class TestMultipleBrowserWindows
    {
        //[TestMethod]
        public void TestMultipleBrowserWindow()
        {
            NavigationHelper.NagigateToURL("https://www.w3schools.com/");
            LinkHelper.ClickLink(By.XPath("//a[@href='/html/tryit.asp?filename=tryhtml_default']"));
            BrowserHelper.SwitchToWindow(1);
            NavigationHelper.NagigateToURL("https://www.w3schools.com/");
            LinkHelper.ClickLink(By.XPath("//a[@href='/html/tryit.asp?filename=tryhtml_default']"));
            BrowserHelper.SwitchToWindow(2);
            LinkHelper.ClickLink(By.XPath("//a[@class='w3-button w3-bar-item topnav-icons fa fa-rotate']"));
            BrowserHelper.SwitchToParent();
        }
    }
}
