using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Utils;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomation.Providers
{
    public static class BambooProvider
    {
        public static string BaseUrl => "https://panda.corp.juriba.com";
        public static readonly string Username = ConfigReader.ByKey("bambooUsername");
        public static readonly string Password = ConfigReader.ByKey("bambooPassword");
        public static readonly string BuildResultKey = ConfigReader.ByKey("bambooBuildResultKey");
        public static int BuildNumber
        {
            get
            {
                try
                {
                    return int.Parse(BuildResultKey.Split('-').Last());
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to get BuildNumber: {e}");
                    return -1;
                }
            }
        }
        public static string ProjAndBuild
        {
            get
            {
                try
                {
                    return $"{BuildResultKey.Split('-')[0]}-{BuildResultKey.Split('-')[1]}";
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to get Proj And Build: {e}");
                    return null;
                }
            }
        }
    }
}