using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.TextBox
{
    //[TestClass]
    public class TestTextBox
    {
        //[TestMethod]
        public void TextBox()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.SendKeys(ObjectRepository.Config.GetUsername());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));
            //ele.SendKeys(ObjectRepository.Config.GetPassword());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.Clear();

            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
        }
    }
}
