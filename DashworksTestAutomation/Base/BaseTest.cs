using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.Base
{
    internal class BaseTest : IBaseTest
    {
        public RemoteWebDriver Driver { get; set; }

        public RemoteWebDriver CreateBrowserDriver()
        {
            switch (Browser.RemoteDriver)
            {
                case "local":
                    return CreateLocalDriver();
                case "remote":
                    return CreateRemoteDriver();
                case "sauceLabs":
                    return CreateSauceLabsDriver();

                default:
                    throw new Exception($"Browser type '{Browser.Type}' was not identified");
            }
        }

        private RemoteWebDriver CreateLocalDriver()
        {
            switch (Browser.Type)
            {
                case "chrome":
                    return new ChromeDriver();

                case "firefox":
                    return new FirefoxDriver();

                case "internet explorer":
                    return new InternetExplorerDriver();

                case "edge":
                    return new EdgeDriver();

                default:
                    throw new Exception($"Browser type '{Browser.Type}' was not identified");
            }
        }

        private RemoteWebDriver CreateRemoteDriver()
        {
            switch (Browser.Type)
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    return new RemoteWebDriver(new Uri(Browser.HubUri), chromeOptions);

                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    return new RemoteWebDriver(new Uri(Browser.HubUri), firefoxOptions);

                case "internet explorer":
                    var ieOptions = new InternetExplorerOptions();
                    return new RemoteWebDriver(new Uri(Browser.HubUri), ieOptions);

                case "edge":
                    var edgeOptions = new EdgeOptions();
                    return new RemoteWebDriver(new Uri(Browser.HubUri), edgeOptions);

                default:
                    throw new Exception($"Browser type '{Browser.Type}' was not identified");
            }
        }

        private RemoteWebDriver CreateSauceLabsDriver()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, Browser.Type);
            capabilities.SetCapability(CapabilityType.Version, Browser.Version);
            capabilities.SetCapability(CapabilityType.Platform, Browser.Platform);
            capabilities.SetCapability("screenResolution", Browser.Resolution);

            capabilities.SetCapability("username",SauceLabsCredentialsProvider.Username);
            capabilities.SetCapability("accessKey", SauceLabsCredentialsProvider.AccessKey);

            var driver = new CustomRemoteWebDriver(new Uri(Browser.HubUri), capabilities, TimeSpan.FromSeconds(60));
            return driver;
        }
    }
}