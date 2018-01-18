using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    class UrlProvider
    {
        public static string Url => ConfigurationManager.AppSettings["appURL"];
        public static string BackupUrl => ConfigurationManager.AppSettings["backupAppURL"];
        public static string RestClientBaseUrl => ConfigurationManager.AppSettings["restClientBaseUrl"];
        public static string EvergreenUrl => ConfigurationManager.AppSettings["appURLEvergreen"];
    }
}
