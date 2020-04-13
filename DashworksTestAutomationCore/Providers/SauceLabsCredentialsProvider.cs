using System.Configuration;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomation.Providers
{
    public static class SauceLabsCredentialsProvider
    {
        public static string Username => ConfigReader.ByKey("sauceLabsUsername");
        public static string Password => ConfigReader.ByKey("sauceLabsPassword");
        public static string AccessKey => ConfigReader.ByKey("sauceLabsAccessKey");
    }
}