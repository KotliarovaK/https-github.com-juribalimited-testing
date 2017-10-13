using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriverTests.Interfaces;
using OpenQA.Selenium;

namespace SeleniumWebdriverTests.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }

        public static IWebDriver Driver { get; set; }
    }
}
