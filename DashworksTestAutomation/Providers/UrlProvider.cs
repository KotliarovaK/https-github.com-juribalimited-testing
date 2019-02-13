using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    internal class UrlProvider
    {
        private static readonly string BaseUrl = ConfigurationManager.AppSettings["appURL"];

        public static string Url => $"{BaseUrl}/";
        public static string BackupUrl => ConfigurationManager.AppSettings["backupAppURL"];

        public static string RestClientBaseUrl =>
            $"{BaseUrl}:{ConfigurationManager.AppSettings["restClientBaseUrlPort"]}/";

        public static string EvergreenUrl => $"{BaseUrl}/{ConfigurationManager.AppSettings["appURLEvergreen"]}/";
        public static string ProjectsUrl => $"{BaseUrl}/{ConfigurationManager.AppSettings["projectsUrl"]}";
    }
}