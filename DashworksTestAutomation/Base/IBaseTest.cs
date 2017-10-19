using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Base
{
    public interface IBaseTest
    {
        RemoteWebDriver Driver { get; set; }

        RemoteWebDriver CreateBrowserDriver();
    }
}
