using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.RadioButton
{
    //[TestClass]
    public class TestRadioButton
    {
        //[TestMethod]
        public void TestRadio()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            IWebElement  webElement = ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            Console.WriteLine("Text: {0}", webElement.Text);
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            LinkHelper.ClickLink(By.XPath("//div[@id='header']/ul[1]/li[9]/a"));
            LinkHelper.ClickLink(By.XPath("//dt[@id='parameters']/a"));
            Console.WriteLine("Selected: {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-on")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));
       }

    }
}
