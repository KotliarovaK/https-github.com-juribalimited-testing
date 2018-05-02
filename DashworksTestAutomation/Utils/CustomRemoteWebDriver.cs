using System;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Utils
{
    internal class CustomRemoteWebDriver : RemoteWebDriver
    {
        public CustomRemoteWebDriver(Uri uri, DesiredCapabilities capabilities, TimeSpan commandTimeout) : base(uri,
            capabilities, commandTimeout)
        {
        }

        public SessionId getSessionId()
        {
            return SessionId;
        }
    }
}