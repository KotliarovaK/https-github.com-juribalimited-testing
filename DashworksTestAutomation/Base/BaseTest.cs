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
            switch (Browser.Type)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    //options.AddArgument("window-position=0,0");
                    //options.AddArgument("start-fullscreen");
                    //options.AddArgument(string.Format("window-size={0}", Browser.Resolution));
                    options.AddArgument("start-maximized");
                    //options.AddArgument(@"user-data-dir=C:\Users\stuar\AppData\Local\Google\Chrome\User Data");
                    //options.AddArgument("cast-initial-screen-width=4000");
                    //options.AddArgument("desktop-window-1080p");
                    //options.AddArgument("ash-host-window-bounds=80x60*2");
                    return new ChromeDriver(options);

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