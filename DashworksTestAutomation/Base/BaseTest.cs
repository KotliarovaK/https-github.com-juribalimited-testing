﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
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
            try
            {
                return CreateDriver();
            }
            //Just retry when node was busy
            catch (AggregateException)
            {
                return CreateDriver();
            }
        }

        private RemoteWebDriver CreateDriver()
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
                    var options = new ChromeOptions();
                    options.AddArgument("--safebrowsing-disable-download-protection");
                    options.AddUserProfilePreference("download.prompt_for_download", false);
                    options.AddUserProfilePreference("download.directory_upgrade", true);
                    options.AddUserProfilePreference("safebrowsing.enabled", true);
                    if (Browser.RemoteDriver.Equals("local"))
                        options.AddArgument("--start-maximized");
                    options.UseSpecCompliantProtocol = false;
                    options.SetLoggingPreference(LogType.Browser, LogLevel.All);

                    var driver = new ChromeDriver(options);

                    var logs = driver.Manage().Logs.GetLog(LogType.Browser).ToList();

                    return driver;

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
                    chromeOptions.AddArguments("headless", "--window-size=1920,1080", "--safebrowsing-disable-download-protection");
                    chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
                    chromeOptions.AddUserProfilePreference("download.directory_upgrade", true);
                    chromeOptions.AddUserProfilePreference("safebrowsing.enabled", true);
                    chromeOptions.UseSpecCompliantProtocol = false;
                    chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
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
            throw new NotImplementedException();
        }
    }
}