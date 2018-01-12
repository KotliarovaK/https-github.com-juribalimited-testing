using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    public static class Browser
    {
        public static string Type => ConfigurationManager.AppSettings["targetBrowser"];
        public static string Version => ConfigurationManager.AppSettings["browserVersion"];
        public static string Platform => ConfigurationManager.AppSettings["platform"];
        public static string Resolution => ConfigurationManager.AppSettings["browserSize"];
        public static string HubUri => ConfigurationManager.AppSettings["hubUri"];
        public static string RemoteDriver => ConfigurationManager.AppSettings["remoteDriver"];
    }
}