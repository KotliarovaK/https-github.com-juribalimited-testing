using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing;
using System.Linq;

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
                switch (Browser.Type)
                {
                    case "Chrome":
                        DesiredCapabilities chCap = DesiredCapabilities.Chrome();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), chCap);
                    case "Firefox":
                        DesiredCapabilities ffCap = DesiredCapabilities.Firefox();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), ffCap);

                    case "InternetExplorer":
                        DesiredCapabilities ieCap = DesiredCapabilities.InternetExplorer();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), ieCap);

                    case "Edge":
                        DesiredCapabilities eCap = DesiredCapabilities.Edge();
                        return new RemoteWebDriver(new Uri(Browser.HubUri), eCap);

                    default:
                        throw new Exception($"Browser type '{Browser.Type}' was not identified");
                }
            else
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
            //#endif
        }
    }
}