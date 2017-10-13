using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.AutoSuggest
{
    //[TestClass]
    public class TestAutoSuggest
    {
        //[TestMethod]
        public void AutoSuggest()
        {
            NavigationHelper.NagigateToURL("http://demos.telerik.com/kendo-ui/autocomplete/index");
            
            //step 1 - supply the intial string, e.g. "a"
            IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("countries"));
            ele.SendKeys("a");
            Thread.Sleep(1000); //allow time for the list to become visible

            //step 2 - wait for auto suggest list to appear
            var wait = GenericHelper.GetWebdriverWait(TimeSpan.FromSeconds(40));

            //step 3 - get list of all the values in the auto suggest list (calls the private method below)
            IList<IWebElement> elements = wait.Until(GetAllElements(By.XPath("//ul[@id='countries_listbox']/child::li")));

            //step 4 - select the wanted value using a foreach loop, from the list of auto suggest values
            foreach (var ele1 in elements)
            {
                if (ele1.Text.Equals("Austria"))
                {
                    ele1.Click();
                }
            }
            Thread.Sleep(5000);

        }

        //private method that collects all the auto suggest values
        private Func<IWebDriver,IList<IWebElement>> GetAllElements(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
        }
    }
}
