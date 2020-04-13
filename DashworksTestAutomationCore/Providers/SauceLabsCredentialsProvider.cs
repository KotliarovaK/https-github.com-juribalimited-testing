using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    public static class SauceLabsCredentialsProvider
    {
        public static string Username => ConfigurationManager.AppSettings["sauceLabs.username"];
        public static string Password => ConfigurationManager.AppSettings["sauceLabs.password"];
        public static string AccessKey => ConfigurationManager.AppSettings["sauceLabs.accessKey"];
    }
}