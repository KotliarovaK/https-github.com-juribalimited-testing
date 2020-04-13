using System;
using System.Configuration;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomation.Providers
{
    public static class Database
    {
        public static string ConnectionsString
        {
            get
            {
                switch (ConfigReader.ByKey("environmentFlag"))
                {
                    case "arelease":
                        return ConfigReader.ByKey("connectionsString");
                    case "amaster":
                        return ConfigReader.ByKey("connectionsStringAmaster");
                    case "master":
                        return ConfigReader.ByKey("connectionsStringFuture");
                    default: throw new Exception("Unable to generate connection string");
                }
            }
        }
    }
}