using System;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomationCore.Providers
{
    class SelfServiceProvider
    {
        public static string sSDefaultBaseUrl => ConfigReader.ByKey("selfServiceDefaultBaseUrl");
    }
}