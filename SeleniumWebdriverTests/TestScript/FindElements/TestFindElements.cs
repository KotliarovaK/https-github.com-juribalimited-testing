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

namespace SeleniumWebdriverTests.TestScript.FindElements
{
    //[TestClass]
    public class TestFindElements
    {
        //[TestMethod]
        public void GetAllElements()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.XPath("//input"));
            ReadOnlyCollection<IWebElement> elements2 = ObjectRepository.Driver.FindElements(By.Id("123"));
            foreach (var ele in elements)
            {
                Console.WriteLine("ID: {0}", ele.GetAttribute("id"));
            }
        }
    }
}
