using System.Configuration;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomation.Providers
{
    public static class Browser
    {
        public static string Type => ConfigReader.ByKey("targetBrowser");
        public static string Version => ConfigReader.ByKey("browserVersion");
        public static string Platform => ConfigReader.ByKey("platform");
        public static string Resolution => ConfigReader.ByKey("browserSize");
        public static string HubUri => ConfigReader.ByKey("hubUri");
        public static string RemoteDriver => ConfigReader.ByKey("remoteDriver");
    }
}