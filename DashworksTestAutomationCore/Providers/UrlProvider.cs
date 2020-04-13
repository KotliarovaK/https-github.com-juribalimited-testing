using System;
using System.Configuration;
using System.Linq;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Providers
{
    internal class UrlProvider
    {
        public static string BaseUrl
        {
            get
            {
                switch (ConfigurationManager.AppSettings["environmentFlag"])
                {
                    case "arelease":
                        return ConfigurationManager.AppSettings["appURL"];
                    case "amaster":
                        return ConfigurationManager.AppSettings["appURLAmaster"];
                    case "master":
                        return ConfigurationManager.AppSettings["appURLFuture"];
                    default: throw new Exception("Unable to generate Base URL");
                }
            }
        }

        public static string Host = BaseUrl.Split("//").Last();
        public static string Url => $"{BaseUrl}/";
        public static string BackupUrl => ConfigurationManager.AppSettings["backupAppURL"];

        private static string _port
        {
            get
            {
                switch (ConfigurationManager.AppSettings["environmentFlag"])
                {
                    case "arelease":
                        return ConfigurationManager.AppSettings["restClientBaseUrlPort"];
                    case "amaster":
                        return ConfigurationManager.AppSettings["restClientBaseUrlPort"];
                    case "master":
                        return ConfigurationManager.AppSettings["restClientBaseUrlPortFuture"];
                    default: throw new Exception("Unable to generate connection string");
                }
            }
        }

        public static string RestClientBaseUrl =>
            $"{BaseUrl}:{_port}/";

        public static string EvergreenUrl => $"{BaseUrl}/{ConfigurationManager.AppSettings["appURLEvergreen"]}/";
        public static string ProjectsUrl => $"{BaseUrl}/{ConfigurationManager.AppSettings["projectsUrl"]}";
    }
}