using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Providers
{
    public static class Database
    {
        public static string ConnectionsString => ConfigurationManager.AppSettings["connectionsString"];
    }
}
