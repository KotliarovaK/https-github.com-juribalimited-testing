using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Providers
{
    public static class SauceLabsCredentialsProvider
    {
        public static string Username => ConfigurationManager.AppSettings["sauceLabs.username"];
        public static string Password => ConfigurationManager.AppSettings["sauceLabs.password"];
        public static string AccessKey => ConfigurationManager.AppSettings["sauceLabs.accessKey"];
    }
}
