using System.Configuration;

namespace DashworksTestAutomation.Providers
{
    public static class Database
    {
        public static string ConnectionsString => bool.Parse(ConfigurationManager.AppSettings["isFutureRelease"]) ?
            ConfigurationManager.AppSettings["connectionsStringFuture"] : ConfigurationManager.AppSettings["connectionsString"];
    }
}