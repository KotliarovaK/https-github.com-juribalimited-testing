using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace DashworksTestAutomation.Base
{
    internal class BaseTest : IBaseTest
    {
        public RemoteWebDriver Driver { get; set; }

        public RemoteWebDriver CreateBrowserDriver()
        {
            //#if DEBUG
            //            return new ChromeDriver();
            //#else
            if (Boolean.Parse(Browser.UserRemoteDriver))
            {
                switch (Browser.Type)
                {
                    case "Chrome":
                        var chromeOptions = new ChromeOptions();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), chromeOptions);

                    case "Firefox":
                        var firefoxOptions = new FirefoxOptions();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), firefoxOptions);

                    case "InternetExplorer":
                        var ieOptions = new InternetExplorerOptions();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), ieOptions);

                    case "Edge":
                        var edgeOptions = new EdgeOptions();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), edgeOptions);

                    default:
                        throw new Exception($"Browser type '{Browser.Type}' was not identified");
                }
            }
            else
            {
                switch (Browser.Type)
                {
                    case "Chrome":
                        return new ChromeDriver();

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

            //#endif
        }
    }
}