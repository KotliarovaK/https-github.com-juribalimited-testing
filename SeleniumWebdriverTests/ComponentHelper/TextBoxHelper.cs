using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement element;
        private static SelectElement select;

        public static void TypeInTextBox(By Locator, string text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(text);
        }

        public static void ClearTextBox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Clear();
        }

        public static void SelectElement(IWebElement element, string visibletext)
        {
            select = new SelectElement(element);
            select.SelectByValue(visibletext);
        }
    }
}
