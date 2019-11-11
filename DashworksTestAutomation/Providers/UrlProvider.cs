using System.Configuration;
using System.Linq;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.Providers
{
    internal class UrlProvider
    {
        private static readonly string BaseUrl = bool.Parse(ConfigurationManager.AppSettings["isFutureRelease"]) ?
            ConfigurationManager.AppSettings["appURLFuture"] : ConfigurationManager.AppSettings["appURL"];
        
        public static string Host = BaseUrl.Split("//").Last();
        public static string Url => $"{BaseUrl}/";
        public static string BackupUrl => ConfigurationManager.AppSettings["backupAppURL"];

        private static string _port = bool.Parse(ConfigurationManager.AppSettings["isFutureRelease"]) ?
            ConfigurationManager.AppSettings["restClientBaseUrlPortFuture"] : ConfigurationManager.AppSettings["restClientBaseUrlPort"];

        public static string RestClientBaseUrl =>
            $"{BaseUrl}:{_port}/";

        public static string EvergreenUrl => $"{BaseUrl}/{ConfigurationManager.AppSettings["appURLEvergreen"]}/";
        public static string ProjectsUrl => $"{BaseUrl}/{ConfigurationManager.AppSettings["projectsUrl"]}";
    }
}