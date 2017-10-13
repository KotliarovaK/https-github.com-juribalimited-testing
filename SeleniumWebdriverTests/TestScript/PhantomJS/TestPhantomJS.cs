using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.PhantomJS;

namespace SeleniumWebdriverTests.TestScript.PhantomJS
{
    //[TestClass]
    public class TestPhantomJS
    {
        //[TestMethod]
        public void TestPhantomJSDriver()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            GenericHelper.TakeScreenShot();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            GenericHelper.TakeScreenShot();
            ButtonHelper.ClickButton(By.Id("log_in"));
            GenericHelper.TakeScreenShot();
        }
    }
}
