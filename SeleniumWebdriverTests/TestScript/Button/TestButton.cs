using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.Button
{
    //[TestClass]
    public class TestButton
    {
        //[TestCategory("Smoke")]
        //[TestMethod]
        public void Button()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            Console.WriteLine("Enabled: {0}", ButtonHelper.IsButtonEnabled(By.Id("log_in")));
            Console.WriteLine("Button Text: {0}", ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));
        }
    }
}
