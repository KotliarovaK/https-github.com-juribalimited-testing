using System;
using System.Configuration;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomation.Providers
{
    internal class UrlProvider
    {
        public static string BaseUrl
        {
            get
            {
                switch (ConfigReader.ByKey("environmentFlag"))
                {
                    case "arelease":
                        return ConfigReader.ByKey("appURL");
                    case "amaster":
                        return ConfigReader.ByKey("appURLAmaster");
                    case "master":
                        return ConfigReader.ByKey("appURLFuture");
                    default: throw new Exception("Unable to generate Base URL");
                }
            }
        }

        public static string Host = BaseUrl.Split("//").Last();
        public static string Url => $"{BaseUrl}/";
        public static string BackupUrl => ConfigReader.ByKey("backupAppURL");

        private static string _port
        {
            get
            {
                switch (ConfigReader.ByKey("environmentFlag"))
                {
                    case "arelease":
                        return ConfigReader.ByKey("restClientBaseUrlPort");
                    case "amaster":
                        return ConfigReader.ByKey("restClientBaseUrlPort");
                    case "master":
                        return ConfigReader.ByKey("restClientBaseUrlPortFuture");
                    default: throw new Exception("Unable to generate connection string");
                }
            }
        }

        public static string RestClientBaseUrl =>
            $"{BaseUrl}:{_port}/";

        public static string EvergreenUrl => $"{BaseUrl}/{ConfigReader.ByKey("appURLEvergreen")}/";
        public static string ProjectsUrl => $"{BaseUrl}/{ConfigReader.ByKey("projectsUrl")}";
        public static string SelfServiceDefaultBaseUrl => ConfigReader.ByKey("selfServiceDefaultBaseUrl");
    }
}