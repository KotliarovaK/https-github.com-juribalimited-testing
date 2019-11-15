using System;
using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    public static class Database
    {
        public static string ConnectionsString
        {
            get
            {
                switch (ConfigurationManager.AppSettings["environmentFlag"])
                {
                    case "arelease":
                        return ConfigurationManager.AppSettings["connectionsString"];
                    case "amaster":
                        return ConfigurationManager.AppSettings["connectionsStringAmaster"];
                    case "master":
                        return ConfigurationManager.AppSettings["connectionsStringFuture"];
                    default: throw new Exception("Unable to generate connection string");
                }
            }
        }
    }
}