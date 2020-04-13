using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Base
{
    internal class BaseTest : IBaseTest
    {
        public RemoteWebDriver Driver { get; set; }

        public RemoteWebDriver CreateBrowserDriver()
        {
            return BrowserFactory.CreateDriver();
        }
    }
}