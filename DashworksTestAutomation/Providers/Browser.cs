using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    public static class Browser
    {
        public static string Type => ConfigurationManager.AppSettings["targetBrowser"];
        public static string Resolution => ConfigurationManager.AppSettings["browserSize"];
    }
}