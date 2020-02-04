using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Providers
{
    public class JuribaAutomationApiProvider
    {
        public static string Uri => ConfigurationManager.AppSettings["juribaAutomationApiUri"];
    }
}
