using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    public static class Database
    {
        public static string ConnectionsString => ConfigurationManager.AppSettings["connectionsString"];
    }
}