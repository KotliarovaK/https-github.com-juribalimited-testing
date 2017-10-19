using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Providers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace Autotest.Base
{
    class BaseTest : IBaseTest
    {
        public RemoteWebDriver Driver { get; set; }

        public RemoteWebDriver CreateBrowserDriver()
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
    }
}
