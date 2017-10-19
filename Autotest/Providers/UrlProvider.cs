using System.Configuration;

namespace Autotest.Providers
{
    class UrlProvider
    {
        public static string Url => ConfigurationManager.AppSettings["appURL"];
        public static string BackupUrl => ConfigurationManager.AppSettings["backupAppURL"];
    }
}
