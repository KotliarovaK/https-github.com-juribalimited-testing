using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumWebdriverTests.TestScript.ScreenShot
{
    //[TestClass]
    public class TakeScreenShots
    {
        //[TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.jpeg");
        }
    }
}
