﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.Providers
{
    public static class BambooProvider
    {
        public static string BaseUrl => "https://panda.corp.juriba.com";
        public static readonly string Username = ConfigurationManager.AppSettings["bamboo.username"];
        public static readonly string Password = ConfigurationManager.AppSettings["bamboo.password"];
        public static readonly string ProjectKey = ConfigurationManager.AppSettings["bamboo.projectKey"];
        public static readonly string BuildKey = ConfigurationManager.AppSettings["bamboo.buildKey"];
        public static readonly string BuildResultKey = ConfigurationManager.AppSettings["bamboo.buildResultKey"];
        public static int BuildNumber
        {
            get
            {
                try
                {
                    Logger.Write($"BuildResultKey is {BuildResultKey}");
                    Logger.Write($"Last part is {BuildResultKey.Split('-').Last()}");
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
