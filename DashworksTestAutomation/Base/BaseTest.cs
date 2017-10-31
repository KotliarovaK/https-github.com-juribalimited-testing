using System;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Base
{
    class BaseTest : IBaseTest
    {
        public RemoteWebDriver Driver { get; set; }

        public RemoteWebDriver CreateBrowserDriver()
        {
            switch (Browser.Type)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument($"--window-size={Browser.Resolution}");
                    var driver = new ChromeDriver(options);
                    return driver;
                case "Firefox":
                    return new FirefoxDriver();
                case "InternetExplorer":
                    return new InternetExplorerDriver();
                case "Edge":
                    return new EdgeDriver();
                default:
                    throw new Exception($"Browser type '{Browser.Type}' was not identified");
            }
        }
    }
}
