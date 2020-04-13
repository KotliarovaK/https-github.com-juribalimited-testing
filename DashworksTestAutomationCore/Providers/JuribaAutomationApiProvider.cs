using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomationCore.Utils;

namespace DashworksTestAutomation.Providers
{
    public class JuribaAutomationApiProvider
    {
        public static string Uri => ConfigReader.ByKey("juribaAutomationApiUri");
    }
}