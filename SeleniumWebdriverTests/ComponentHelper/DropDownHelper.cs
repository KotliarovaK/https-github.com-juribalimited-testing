using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.ComponentHelper
{
    public class DropDownHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
        }

        public static void SelectElement(By locator, string visibleText)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByText(visibleText);
        }

        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }

        public static void SelectElement(IWebElement element, string visibletext)
        {
            select = new SelectElement(element);
            select.SelectByValue(visibletext);
        }
    }
}