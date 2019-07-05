using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Providers
{
    public static class BambooProvider
    {
        public static string BaseUrl => "https://panda.corp.juriba.com";
        public static readonly string Username = ConfigurationManager.AppSettings["bamboo.username"];
        public static readonly string Password = ConfigurationManager.AppSettings["bamboo.password"];
        public static readonly string ProjectKey = ConfigurationManager.AppSettings["bamboo.projectKey"];
        public static readonly string BuildKey = ConfigurationManager.AppSettings["bamboo.buildKey"];
    }
}
