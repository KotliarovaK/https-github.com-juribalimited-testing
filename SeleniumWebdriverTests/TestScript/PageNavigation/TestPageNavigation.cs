using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriverTests.Settings;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;

namespace SeleniumWebdriverTests.TestScript.PageNavigation
{
    //[TestClass]
    public class TestPageNavigation
    {
        //[TestMethod]
        public void OpenPage()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            Console.WriteLine("Title of Page : {0}", WindowHelper.GetTitle());
        }
    }
}
