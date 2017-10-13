using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.Dropdown
{
    //[TestClass]
    public class TestDropDown
    {
        public int Value { get; private set; }

        //[TestMethod]
        public void TestList()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            DropDownHelper.SelectElement(By.Id("bug_severity"), 2);
            DropDownHelper.SelectElement(By.Id("bug_severity"), "blocker");
            foreach (string str in DropDownHelper.GetAllItem(By.Id("bug_severity")))
            {
                Console.WriteLine("Text: {0}",str);
            }
        }
    }
}
